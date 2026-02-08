using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter.Serialization.Json
{
	// Token: 0x02000083 RID: 131
	public static class JsonTableConverter : Object
	{
		// Token: 0x06000B77 RID: 2935 RVA: 0x00041FB0 File Offset: 0x000401B0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTableConverter()
		{
			Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Serialization.Json", "JsonTableConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr);
			JsonTableConverter.NativeMethodInfoPtr_TableToJson_Public_Static_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665277);
			JsonTableConverter.NativeMethodInfoPtr_TableToJson_Private_Static_Void_StringBuilder_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665278);
			JsonTableConverter.NativeMethodInfoPtr_ObjectToJson_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665279);
			JsonTableConverter.NativeMethodInfoPtr_ValueToJson_Private_Static_Void_StringBuilder_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665280);
			JsonTableConverter.NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665281);
			JsonTableConverter.NativeMethodInfoPtr_IsValueJsonCompatible_Private_Static_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665282);
			JsonTableConverter.NativeMethodInfoPtr_JsonToTable_Public_Static_Table_String_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665283);
			JsonTableConverter.NativeMethodInfoPtr_AssertToken_Private_Static_Void_Lexer_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665284);
			JsonTableConverter.NativeMethodInfoPtr_ParseJsonArray_Private_Static_Table_Lexer_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665285);
			JsonTableConverter.NativeMethodInfoPtr_ParseJsonObject_Private_Static_Table_Lexer_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665286);
			JsonTableConverter.NativeMethodInfoPtr_ParseJsonValue_Private_Static_DynValue_Lexer_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665287);
			JsonTableConverter.NativeMethodInfoPtr_ParseJsonNumberValue_Private_Static_DynValue_Lexer_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTableConverter>.NativeClassPtr, 100665288);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000420D0 File Offset: 0x000402D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31850, RefRangeEnd = 31851, XrefRangeStart = 31844, XrefRangeEnd = 31850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TableToJson(this Table table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_TableToJson_Public_Static_String_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0004210C File Offset: 0x0004030C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31871, RefRangeEnd = 31873, XrefRangeStart = 31851, XrefRangeEnd = 31871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TableToJson(StringBuilder sb, Table table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_TableToJson_Private_Static_Void_StringBuilder_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00042154 File Offset: 0x00040354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31873, XrefRangeEnd = 31887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ObjectToJson(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ObjectToJson_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00042190 File Offset: 0x00040390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31897, RefRangeEnd = 31898, XrefRangeStart = 31887, XrefRangeEnd = 31897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValueToJson(StringBuilder sb, DynValue value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ValueToJson_Private_Static_Void_StringBuilder_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000421D8 File Offset: 0x000403D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31898, XrefRangeEnd = 31941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeString(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00042214 File Offset: 0x00040414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31954, RefRangeEnd = 31955, XrefRangeStart = 31941, XrefRangeEnd = 31954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueJsonCompatible(DynValue value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_IsValueJsonCompatible_Private_Static_Boolean_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00042258 File Offset: 0x00040458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31981, RefRangeEnd = 31982, XrefRangeStart = 31955, XrefRangeEnd = 31981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table JsonToTable(string json, Script script = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_JsonToTable_Public_Static_Table_String_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000422B0 File Offset: 0x000404B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31983, RefRangeEnd = 31985, XrefRangeStart = 31982, XrefRangeEnd = 31983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssertToken(Lexer L, MoonSharp.Interpreter.Tree.TokenType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_AssertToken_Private_Static_Void_Lexer_TokenType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000422F8 File Offset: 0x000404F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31996, RefRangeEnd = 31998, XrefRangeStart = 31985, XrefRangeEnd = 31996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table ParseJsonArray(Lexer L, Script script)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ParseJsonArray_Private_Static_Table_Lexer_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00042350 File Offset: 0x00040550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32014, RefRangeEnd = 32016, XrefRangeStart = 31998, XrefRangeEnd = 32014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table ParseJsonObject(Lexer L, Script script)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ParseJsonObject_Private_Static_Table_Lexer_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000423A8 File Offset: 0x000405A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32065, RefRangeEnd = 32067, XrefRangeStart = 32016, XrefRangeEnd = 32065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ParseJsonValue(Lexer L, Script script)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ParseJsonValue_Private_Static_DynValue_Lexer_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00042400 File Offset: 0x00040600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32096, RefRangeEnd = 32097, XrefRangeStart = 32067, XrefRangeEnd = 32096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ParseJsonNumberValue(Lexer L, Script script)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTableConverter.NativeMethodInfoPtr_ParseJsonNumberValue_Private_Static_DynValue_Lexer_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00005790 File Offset: 0x00003990
		public JsonTableConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_TableToJson_Public_Static_String_Table_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_TableToJson_Private_Static_Void_StringBuilder_Table_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_ObjectToJson_Public_Static_String_Object_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_ValueToJson_Private_Static_Void_StringBuilder_DynValue_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_IsValueJsonCompatible_Private_Static_Boolean_DynValue_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_JsonToTable_Public_Static_Table_String_Script_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_AssertToken_Private_Static_Void_Lexer_TokenType_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_ParseJsonArray_Private_Static_Table_Lexer_Script_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_ParseJsonObject_Private_Static_Table_Lexer_Script_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_ParseJsonValue_Private_Static_DynValue_Lexer_Script_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_ParseJsonNumberValue_Private_Static_DynValue_Lexer_Script_0;
	}
}
