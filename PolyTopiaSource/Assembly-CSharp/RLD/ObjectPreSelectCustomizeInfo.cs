using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000218 RID: 536
	public class ObjectPreSelectCustomizeInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x000C7E54 File Offset: 0x000C6054
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPreSelectCustomizeInfo()
		{
			Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectPreSelectCustomizeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr);
			ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__toBeSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, "_toBeSelected");
			ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__selectRason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, "_selectRason");
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669721);
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_ToBeSelectedCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669722);
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_ToBeSelected_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669723);
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669724);
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_SelectThese_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669725);
			ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr, 100669726);
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000C7F24 File Offset: 0x000C6124
		public unsafe ObjectSelectReason SelectReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr3) : null;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000C7F64 File Offset: 0x000C6164
		public unsafe int ToBeSelectedCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93286, XrefRangeEnd = 93287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_ToBeSelectedCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000C7FA0 File Offset: 0x000C61A0
		public unsafe List<GameObject> ToBeSelected
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93293, RefRangeEnd = 93296, XrefRangeStart = 93287, XrefRangeEnd = 93293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_get_ToBeSelected_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000C7FE0 File Offset: 0x000C61E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93296, XrefRangeEnd = 93304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPreSelectCustomizeInfo(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPreSelectCustomizeInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000C8040 File Offset: 0x000C6240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93304, XrefRangeEnd = 93315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectThese(IEnumerable<GameObject> toBeSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_SelectThese_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000C8084 File Offset: 0x000C6284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93315, XrefRangeEnd = 93335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeIgnored);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreSelectCustomizeInfo.NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00010953 File Offset: 0x0000EB53
		public ObjectPreSelectCustomizeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000C80C8 File Offset: 0x000C62C8
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0001095C File Offset: 0x0000EB5C
		public unsafe List<GameObject> _toBeSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__toBeSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__toBeSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000C80F8 File Offset: 0x000C62F8
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0001097B File Offset: 0x0000EB7B
		public unsafe ObjectSelectReason _selectRason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__selectRason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreSelectCustomizeInfo.NativeFieldInfoPtr__selectRason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr__toBeSelected;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeFieldInfoPtr__selectRason;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_get_ToBeSelectedCount_Public_get_Int32_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_get_ToBeSelected_Public_get_List_1_GameObject_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectReason_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_SelectThese_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0;
	}
}
