using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text.RegularExpressions;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CD RID: 205
	public static class Tools : Object
	{
		// Token: 0x06000FFB RID: 4091 RVA: 0x000566EC File Offset: 0x000548EC
		// Note: this type is marked as 'beforefieldinit'.
		static Tools()
		{
			Il2CppClassPointerStore<Tools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.LuaStateInterop", "Tools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tools>.NativeClassPtr);
			Tools.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tools>.NativeClassPtr, "r");
			Tools.NativeMethodInfoPtr_IsNumericType_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666173);
			Tools.NativeMethodInfoPtr_IsPositive_Public_Static_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666174);
			Tools.NativeMethodInfoPtr_ToUnsigned_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666175);
			Tools.NativeMethodInfoPtr_ToInteger_Public_Static_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666176);
			Tools.NativeMethodInfoPtr_UnboxToLong_Public_Static_Int64_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666177);
			Tools.NativeMethodInfoPtr_ReplaceMetaChars_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666178);
			Tools.NativeMethodInfoPtr_ReplaceMetaCharsMatch_Private_Static_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666179);
			Tools.NativeMethodInfoPtr_fprintf_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666180);
			Tools.NativeMethodInfoPtr_sprintf_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666181);
			Tools.NativeMethodInfoPtr_FormatOct_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666182);
			Tools.NativeMethodInfoPtr_FormatHex_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666183);
			Tools.NativeMethodInfoPtr_FormatNumber_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Boolean_Boolean_Char_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tools>.NativeClassPtr, 100666184);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00056820 File Offset: 0x00054A20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40459, RefRangeEnd = 40463, XrefRangeStart = 40447, XrefRangeEnd = 40459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumericType(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_IsNumericType_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00056864 File Offset: 0x00054A64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40567, RefRangeEnd = 40569, XrefRangeStart = 40463, XrefRangeEnd = 40567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPositive(Object Value, bool ZeroIsPositive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ZeroIsPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_IsPositive_Public_Static_Boolean_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000568B4 File Offset: 0x00054AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40627, RefRangeEnd = 40628, XrefRangeStart = 40569, XrefRangeEnd = 40627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToUnsigned(Object Value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_ToUnsigned_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000568F8 File Offset: 0x00054AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40628, XrefRangeEnd = 40701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToInteger(Object Value, bool Round)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Round;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_ToInteger_Public_Static_Object_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0005694C File Offset: 0x00054B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40784, RefRangeEnd = 40785, XrefRangeStart = 40701, XrefRangeEnd = 40784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long UnboxToLong(Object Value, bool Round)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Round;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_UnboxToLong_Public_Static_Int64_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0005699C File Offset: 0x00054B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40785, XrefRangeEnd = 40797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceMetaChars(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_ReplaceMetaChars_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000569D8 File Offset: 0x00054BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40797, XrefRangeEnd = 40821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceMetaCharsMatch(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_ReplaceMetaCharsMatch_Private_Static_String_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00056A14 File Offset: 0x00054C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40821, XrefRangeEnd = 40826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fprintf(TextWriter Destination, string Format, [Optional] Il2CppReferenceArray<Object> Parameters)
		{
			if (Parameters == null)
			{
				Parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_fprintf_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00056A7C File Offset: 0x00054C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41060, RefRangeEnd = 41062, XrefRangeStart = 40826, XrefRangeEnd = 41060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string sprintf(string Format, [Optional] Il2CppReferenceArray<Object> Parameters)
		{
			if (Parameters == null)
			{
				Parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_sprintf_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00056AD8 File Offset: 0x00054CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41105, RefRangeEnd = 41106, XrefRangeStart = 41062, XrefRangeEnd = 41105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatOct(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, Object Value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NativeFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Alternate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldPrecision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Left2Right;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Padding;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_FormatOct_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00056B70 File Offset: 0x00054D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41157, RefRangeEnd = 41159, XrefRangeStart = 41106, XrefRangeEnd = 41157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHex(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, Object Value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NativeFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Alternate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldPrecision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Left2Right;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Padding;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_FormatHex_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00056C08 File Offset: 0x00054E08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41223, RefRangeEnd = 41228, XrefRangeStart = 41159, XrefRangeEnd = 41223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatNumber(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, bool PositiveSign, bool PositiveSpace, char Padding, Object Value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NativeFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Alternate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FieldPrecision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Left2Right;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PositiveSign;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PositiveSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Padding;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tools.NativeMethodInfoPtr_FormatNumber_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Boolean_Boolean_Char_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00006BF5 File Offset: 0x00004DF5
		public static void fprintf(TextWriter Destination, string Format, params Object[] Parameters)
		{
			Tools.fprintf(Destination, Format, new Il2CppReferenceArray<Object>(Parameters));
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00006C04 File Offset: 0x00004E04
		public static string sprintf(string Format, params Object[] Parameters)
		{
			return Tools.sprintf(Format, new Il2CppReferenceArray<Object>(Parameters));
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00006C12 File Offset: 0x00004E12
		public Tools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00056CBC File Offset: 0x00054EBC
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00006C1B File Offset: 0x00004E1B
		public unsafe static Regex r
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Tools.NativeFieldInfoPtr_r, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tools.NativeFieldInfoPtr_r, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_IsNumericType_Public_Static_Boolean_Object_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_IsPositive_Public_Static_Boolean_Object_Boolean_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_ToUnsigned_Public_Static_Object_Object_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_ToInteger_Public_Static_Object_Object_Boolean_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_UnboxToLong_Public_Static_Int64_Object_Boolean_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceMetaChars_Public_Static_String_String_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceMetaCharsMatch_Private_Static_String_Match_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_fprintf_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_sprintf_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_FormatOct_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_FormatHex_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Char_Object_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_String_String_Boolean_Int32_Int32_Boolean_Boolean_Boolean_Char_Object_0;
	}
}
