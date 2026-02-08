using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000217 RID: 535
	public class ObjectPreDeselectCustomizeInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x000C7B80 File Offset: 0x000C5D80
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPreDeselectCustomizeInfo()
		{
			Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectPreDeselectCustomizeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr);
			ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__toBeDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, "_toBeDeselected");
			ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__deselectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, "_deselectReason");
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669715);
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_ToBeDeselectedCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669716);
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_ToBeDeselected_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669717);
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669718);
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_DeselectThese_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669719);
			ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr, 100669720);
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000C7C50 File Offset: 0x000C5E50
		public unsafe ObjectDeselectReason DeselectReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr3) : null;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000C7C90 File Offset: 0x000C5E90
		public unsafe int ToBeDeselectedCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93240, XrefRangeEnd = 93241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_ToBeDeselectedCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000C7CCC File Offset: 0x000C5ECC
		public unsafe List<GameObject> ToBeDeselected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93241, XrefRangeEnd = 93247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_get_ToBeDeselected_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000C7D0C File Offset: 0x000C5F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93247, XrefRangeEnd = 93255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPreDeselectCustomizeInfo(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPreDeselectCustomizeInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000C7D6C File Offset: 0x000C5F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93255, XrefRangeEnd = 93266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectThese(IEnumerable<GameObject> toBeDeselected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_DeselectThese_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000C7DB0 File Offset: 0x000C5FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93266, XrefRangeEnd = 93286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeIgnored);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPreDeselectCustomizeInfo.NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0001090C File Offset: 0x0000EB0C
		public ObjectPreDeselectCustomizeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000C7DF4 File Offset: 0x000C5FF4
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x00010915 File Offset: 0x0000EB15
		public unsafe List<GameObject> _toBeDeselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__toBeDeselected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__toBeDeselected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000C7E24 File Offset: 0x000C6024
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00010934 File Offset: 0x0000EB34
		public unsafe ObjectDeselectReason _deselectReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__deselectReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPreDeselectCustomizeInfo.NativeFieldInfoPtr__deselectReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeFieldInfoPtr__toBeDeselected;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeFieldInfoPtr__deselectReason;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_get_ToBeDeselectedCount_Public_get_Int32_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_get_ToBeDeselected_Public_get_List_1_GameObject_0;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectDeselectReason_0;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr_DeselectThese_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreThese_Public_Void_IEnumerable_1_GameObject_0;
	}
}
