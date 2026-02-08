using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002D RID: 45
	public static class LuaTypeExtensions : Object
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x0002D54C File Offset: 0x0002B74C
		// Note: this type is marked as 'beforefieldinit'.
		static LuaTypeExtensions()
		{
			Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "LuaTypeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr);
			LuaTypeExtensions.NativeFieldInfoPtr_MaxMetaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, "MaxMetaTypes");
			LuaTypeExtensions.NativeFieldInfoPtr_MaxConvertibleTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, "MaxConvertibleTypes");
			LuaTypeExtensions.NativeMethodInfoPtr_CanHaveTypeMetatables_Public_Static_Boolean_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, 100664530);
			LuaTypeExtensions.NativeMethodInfoPtr_ToErrorTypeString_Public_Static_String_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, 100664531);
			LuaTypeExtensions.NativeMethodInfoPtr_ToLuaDebuggerString_Public_Static_String_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, 100664532);
			LuaTypeExtensions.NativeMethodInfoPtr_ToLuaTypeString_Public_Static_String_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTypeExtensions>.NativeClassPtr, 100664533);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002D5F4 File Offset: 0x0002B7F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 21673, RefRangeEnd = 21678, XrefRangeStart = 21673, XrefRangeEnd = 21673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanHaveTypeMetatables(this DataType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaTypeExtensions.NativeMethodInfoPtr_CanHaveTypeMetatables_Public_Static_Boolean_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0002D638 File Offset: 0x0002B838
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 21690, RefRangeEnd = 21701, XrefRangeStart = 21678, XrefRangeEnd = 21690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToErrorTypeString(this DataType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaTypeExtensions.NativeMethodInfoPtr_ToErrorTypeString_Public_Static_String_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0002D674 File Offset: 0x0002B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21701, XrefRangeEnd = 21705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToLuaDebuggerString(this DataType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaTypeExtensions.NativeMethodInfoPtr_ToLuaDebuggerString_Public_Static_String_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 21714, RefRangeEnd = 21734, XrefRangeStart = 21705, XrefRangeEnd = 21714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToLuaTypeString(this DataType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaTypeExtensions.NativeMethodInfoPtr_ToLuaTypeString_Public_Static_String_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00003859 File Offset: 0x00001A59
		public LuaTypeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0002D6EC File Offset: 0x0002B8EC
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00003862 File Offset: 0x00001A62
		public unsafe static DataType MaxMetaTypes
		{
			get
			{
				DataType dataType;
				IL2CPP.il2cpp_field_static_get_value(LuaTypeExtensions.NativeFieldInfoPtr_MaxMetaTypes, (void*)(&dataType));
				return dataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaTypeExtensions.NativeFieldInfoPtr_MaxMetaTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0002D708 File Offset: 0x0002B908
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00003874 File Offset: 0x00001A74
		public unsafe static DataType MaxConvertibleTypes
		{
			get
			{
				DataType dataType;
				IL2CPP.il2cpp_field_static_get_value(LuaTypeExtensions.NativeFieldInfoPtr_MaxConvertibleTypes, (void*)(&dataType));
				return dataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaTypeExtensions.NativeFieldInfoPtr_MaxConvertibleTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_MaxMetaTypes;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_MaxConvertibleTypes;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_CanHaveTypeMetatables_Public_Static_Boolean_DataType_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_ToErrorTypeString_Public_Static_String_DataType_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_ToLuaDebuggerString_Public_Static_String_DataType_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_ToLuaTypeString_Public_Static_String_DataType_0;
	}
}
