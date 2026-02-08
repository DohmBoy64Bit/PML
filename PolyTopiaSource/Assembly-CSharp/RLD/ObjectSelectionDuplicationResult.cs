using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200022B RID: 555
	public class ObjectSelectionDuplicationResult : global::Il2CppSystem.Object
	{
		// Token: 0x06002B14 RID: 11028 RVA: 0x000CB7CC File Offset: 0x000C99CC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionDuplicationResult()
		{
			Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionDuplicationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr);
			ObjectSelectionDuplicationResult.NativeFieldInfoPtr__duplicateParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr, "_duplicateParents");
			ObjectSelectionDuplicationResult.NativeMethodInfoPtr_get_DuplicateParents_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr, 100669845);
			ObjectSelectionDuplicationResult.NativeMethodInfoPtr_get_NumDuplicateParents_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr, 100669846);
			ObjectSelectionDuplicationResult.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr, 100669847);
			ObjectSelectionDuplicationResult.NativeMethodInfoPtr_GetParentByIndex_Public_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr, 100669848);
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000CB860 File Offset: 0x000C9A60
		public unsafe List<GameObject> DuplicateParents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93884, XrefRangeEnd = 93890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicationResult.NativeMethodInfoPtr_get_DuplicateParents_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000CB8A0 File Offset: 0x000C9AA0
		public unsafe int NumDuplicateParents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93890, XrefRangeEnd = 93891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicationResult.NativeMethodInfoPtr_get_NumDuplicateParents_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93899, RefRangeEnd = 93901, XrefRangeStart = 93891, XrefRangeEnd = 93899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionDuplicationResult(List<GameObject> duplicatedParents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionDuplicationResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(duplicatedParents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicationResult.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000CB928 File Offset: 0x000C9B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93901, XrefRangeEnd = 93905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetParentByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicationResult.NativeMethodInfoPtr_GetParentByIndex_Public_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00011076 File Offset: 0x0000F276
		public ObjectSelectionDuplicationResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x000CB974 File Offset: 0x000C9B74
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x0001107F File Offset: 0x0000F27F
		public unsafe List<GameObject> _duplicateParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionDuplicationResult.NativeFieldInfoPtr__duplicateParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionDuplicationResult.NativeFieldInfoPtr__duplicateParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeFieldInfoPtr__duplicateParents;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicateParents_Public_get_List_1_GameObject_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_get_NumDuplicateParents_Public_get_Int32_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_GetParentByIndex_Public_GameObject_Int32_0;
	}
}
