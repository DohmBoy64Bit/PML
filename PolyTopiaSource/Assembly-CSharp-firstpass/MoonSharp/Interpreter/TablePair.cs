using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000037 RID: 55
	public sealed class TablePair : ValueType
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0003148C File Offset: 0x0002F68C
		// Note: this type is marked as 'beforefieldinit'.
		static TablePair()
		{
			Il2CppClassPointerStore<TablePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "TablePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TablePair>.NativeClassPtr);
			TablePair.NativeFieldInfoPtr_s_NilNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TablePair>.NativeClassPtr, "s_NilNode");
			TablePair.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TablePair>.NativeClassPtr, "key");
			TablePair.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TablePair>.NativeClassPtr, "value");
			TablePair.NativeMethodInfoPtr_get_Key_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664694);
			TablePair.NativeMethodInfoPtr_set_Key_Private_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664695);
			TablePair.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664696);
			TablePair.NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664697);
			TablePair.NativeMethodInfoPtr_get_Nil_Public_Static_get_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664699);
			TablePair.NativeMethodInfoPtr__ctor_Public_Void_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TablePair>.NativeClassPtr, 100664698);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00031570 File Offset: 0x0002F770
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x000315B4 File Offset: 0x0002F7B4
		public unsafe DynValue Key
		{
			[CallerCount(116)]
			[CachedScanResults(RefRangeStart = 24169, RefRangeEnd = 24285, XrefRangeStart = 24169, XrefRangeEnd = 24169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr_get_Key_Public_get_DynValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24285, XrefRangeEnd = 24289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr_set_Key_Private_set_Void_DynValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000315FC File Offset: 0x0002F7FC
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00031640 File Offset: 0x0002F840
		public unsafe DynValue Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24289, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00031688 File Offset: 0x0002F888
		public unsafe static TablePair Nil
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24293, XrefRangeEnd = 24297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr_get_Nil_Public_Static_get_TablePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TablePair>(intPtr3) : null;
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000316BC File Offset: 0x0002F8BC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 24299, RefRangeEnd = 24329, XrefRangeStart = 24297, XrefRangeEnd = 24299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TablePair(DynValue key, DynValue val)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TablePair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TablePair.NativeMethodInfoPtr__ctor_Public_Void_DynValue_DynValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00003CA3 File Offset: 0x00001EA3
		public TablePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00003CAC File Offset: 0x00001EAC
		public TablePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TablePair>.NativeClassPtr))
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00031720 File Offset: 0x0002F920
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00003CBE File Offset: 0x00001EBE
		public unsafe static TablePair s_NilNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TablePair.NativeFieldInfoPtr_s_NilNode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TablePair>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TablePair.NativeFieldInfoPtr_s_NilNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00031748 File Offset: 0x0002F948
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public unsafe DynValue key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TablePair.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TablePair.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00031778 File Offset: 0x0002F978
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00003CEF File Offset: 0x00001EEF
		public unsafe DynValue value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TablePair.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TablePair.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_s_NilNode;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_DynValue_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Private_set_Void_DynValue_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_DynValue_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_get_Nil_Public_Static_get_TablePair_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynValue_DynValue_0;
	}
}
