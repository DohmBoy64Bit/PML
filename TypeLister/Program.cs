using System; using System.Reflection; foreach(var t in typeof(Il2CppInterop.Runtime.Injection.ClassInjector).Assembly.GetTypes()) { if(t.IsPublic) Console.WriteLine(t.FullName); }  
