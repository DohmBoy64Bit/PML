using Avalonia.Media;
using AvaloniaEdit.Document;
using AvaloniaEdit.Rendering;
using Frontend.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Frontend.Editors;

public class LuaApiHighlighter : DocumentColorizingTransformer
{
    private readonly ApiParser apiParser;
    private readonly Dictionary<string, string> globalObjectMap;
    private readonly HashSet<string> executorFunctions;
    
    private static readonly SolidColorBrush GlobalObjectBrush = new SolidColorBrush(Color.Parse("#DCDCAA"));
    private static readonly SolidColorBrush ClassNameBrush = new SolidColorBrush(Color.Parse("#4EC9B0"));
    private static readonly SolidColorBrush PropertyBrush = new SolidColorBrush(Color.Parse("#9CDCFE"));
    private static readonly SolidColorBrush MethodBrush = new SolidColorBrush(Color.Parse("#DCDCAA"));
    private static readonly SolidColorBrush EventBrush = new SolidColorBrush(Color.Parse("#C586C0"));
    private static readonly SolidColorBrush ExecutorFunctionBrush = new SolidColorBrush(Color.Parse("#DCDCAA"));

    public LuaApiHighlighter(ApiParser parser)
    {
        apiParser = parser;
        
        globalObjectMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "game", "Environment" },
            { "workspace", "Environment" },
            { "script", "BaseScript" }
        };
        
        executorFunctions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "readfile", "writefile", "appendfile", "isfile", "isfolder",
            "makefolder", "delfile", "delfolder", "listfiles",
            "getclipboard", "setclipboard", "toclipboard"
        };
    }

    protected override void ColorizeLine(DocumentLine line)
    {
        if (apiParser == null || CurrentContext == null)
            return;

        string lineText = CurrentContext.Document.GetText(line);
        if (string.IsNullOrWhiteSpace(lineText))
            return;

        ColorizeApiElements(line, lineText);
    }

    private void ColorizeApiElements(DocumentLine line, string lineText)
    {
        var tokens = TokenizeLine(lineText);
        int lineOffset = line.Offset;

        for (int i = 0; i < tokens.Count; i++)
        {
            var token = tokens[i];
            
            if (globalObjectMap.ContainsKey(token.Text))
            {
                ChangeLinePart(lineOffset + token.StartIndex, lineOffset + token.EndIndex, 
                    element => element.TextRunProperties.SetForegroundBrush(GlobalObjectBrush));
            }
            else if (apiParser.Classes.ContainsKey(token.Text))
            {
                ChangeLinePart(lineOffset + token.StartIndex, lineOffset + token.EndIndex,
                    element => element.TextRunProperties.SetForegroundBrush(ClassNameBrush));
            }
            else if (executorFunctions.Contains(token.Text))
            {
                ChangeLinePart(lineOffset + token.StartIndex, lineOffset + token.EndIndex,
                    element => element.TextRunProperties.SetForegroundBrush(ExecutorFunctionBrush));
            }
            else if (i > 0 && tokens[i - 1].Text == ".")
            {
                string? ownerToken = null;
                if (i >= 2)
                {
                    ownerToken = tokens[i - 2].Text;
                }

                if (ownerToken != null)
                {
                    string? className = GetClassNameForToken(ownerToken);
                    if (className != null)
                    {
                        ColorizeMember(className, token.Text, lineOffset + token.StartIndex, lineOffset + token.EndIndex, tokens, i);
                    }
                }
            }
        }
    }

    private void ColorizeMember(string className, string memberName, int startOffset, int endOffset, List<Token> tokens, int currentIndex)
    {
        var properties = apiParser.GetAllProperties(className);
        if (properties.Any(p => p.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase)))
        {
            ChangeLinePart(startOffset, endOffset,
                element => element.TextRunProperties.SetForegroundBrush(PropertyBrush));
            return;
        }

        var methods = apiParser.GetAllMethods(className);
        if (methods.Any(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase)))
        {
            ChangeLinePart(startOffset, endOffset,
                element => element.TextRunProperties.SetForegroundBrush(MethodBrush));
            return;
        }

        var events = apiParser.GetAllEvents(className);
        if (events.Any(e => e.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase)))
        {
            ChangeLinePart(startOffset, endOffset,
                element => element.TextRunProperties.SetForegroundBrush(EventBrush));
            return;
        }
    }

    private string? GetClassNameForToken(string token)
    {
        if (globalObjectMap.TryGetValue(token, out var className))
        {
            return className;
        }

        if (apiParser.Classes.ContainsKey(token))
        {
            return token;
        }

        return null;
    }

    private List<Token> TokenizeLine(string line)
    {
        var tokens = new List<Token>();
        var regex = new Regex(@"(\w+|\.|\(|\)|:|\[|\]|,|;)");
        var matches = regex.Matches(line);

        foreach (Match match in matches)
        {
            if (match.Value == "." || match.Value == "(" || match.Value == ")" || 
                match.Value == ":" || match.Value == "[" || match.Value == "]" ||
                match.Value == "," || match.Value == ";")
            {
                tokens.Add(new Token
                {
                    Text = match.Value,
                    StartIndex = match.Index,
                    EndIndex = match.Index + match.Length
                });
            }
            else if (Regex.IsMatch(match.Value, @"^\w+$"))
            {
                tokens.Add(new Token
                {
                    Text = match.Value,
                    StartIndex = match.Index,
                    EndIndex = match.Index + match.Length
                });
            }
        }

        return tokens;
    }

    private class Token
    {
        public string Text { get; set; } = "";
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}
