using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Serialization
{
	// Token: 0x02000081 RID: 129
	public static class SerializationExtensions : Object
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00041C6C File Offset: 0x0003FE6C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationExtensions()
		{
			Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Serialization", "SerializationExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr);
			SerializationExtensions.NativeFieldInfoPtr_LUAKEYWORDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, "LUAKEYWORDS");
			SerializationExtensions.NativeMethodInfoPtr_Serialize_Public_Static_String_Table_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, 100665268);
			SerializationExtensions.NativeMethodInfoPtr_IsStringIdentifierValid_Private_Static_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, 100665269);
			SerializationExtensions.NativeMethodInfoPtr_SerializeValue_Public_Static_String_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, 100665270);
			SerializationExtensions.NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, 100665271);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00041D00 File Offset: 0x0003FF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31731, RefRangeEnd = 31732, XrefRangeStart = 31655, XrefRangeEnd = 31731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Serialize(this Table table, bool prefixReturn = false, int tabs = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixReturn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tabs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationExtensions.NativeMethodInfoPtr_Serialize_Public_Static_String_Table_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00041D58 File Offset: 0x0003FF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31754, RefRangeEnd = 31755, XrefRangeStart = 31732, XrefRangeEnd = 31754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStringIdentifierValid(DynValue dynValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationExtensions.NativeMethodInfoPtr_IsStringIdentifierValid_Private_Static_Boolean_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00041D9C File Offset: 0x0003FF9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31768, RefRangeEnd = 31770, XrefRangeStart = 31755, XrefRangeEnd = 31768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeValue(this DynValue dynValue, int tabs = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tabs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationExtensions.NativeMethodInfoPtr_SerializeValue_Public_Static_String_DynValue_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00041DE8 File Offset: 0x0003FFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31770, XrefRangeEnd = 31823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeString(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationExtensions.NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000576C File Offset: 0x0000396C
		public SerializationExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00041E24 File Offset: 0x00040024
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00005775 File Offset: 0x00003975
		public unsafe static HashSet<string> LUAKEYWORDS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationExtensions.NativeFieldInfoPtr_LUAKEYWORDS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationExtensions.NativeFieldInfoPtr_LUAKEYWORDS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_LUAKEYWORDS;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Table_Boolean_Int32_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_IsStringIdentifierValid_Private_Static_Boolean_DynValue_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_String_DynValue_Int32_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0;
	}
}
