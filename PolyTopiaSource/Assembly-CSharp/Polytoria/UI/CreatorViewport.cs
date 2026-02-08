using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.UI
{
	// Token: 0x02000252 RID: 594
	public class CreatorViewport : MonoBehaviour
	{
		// Token: 0x06002E3A RID: 11834 RVA: 0x000D6618 File Offset: 0x000D4818
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorViewport()
		{
			Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "CreatorViewport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr);
			CreatorViewport.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr, "rect");
			CreatorViewport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr, 100670258);
			CreatorViewport.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr, 100670256);
			CreatorViewport.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr, 100670257);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000D6698 File Offset: 0x000D4898
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorViewport()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorViewport>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorViewport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000D66D4 File Offset: 0x000D48D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98888, XrefRangeEnd = 98892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorViewport.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000D6708 File Offset: 0x000D4908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98892, XrefRangeEnd = 98904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorViewport.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x0001276D File Offset: 0x0001096D
		public CreatorViewport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000D673C File Offset: 0x000D493C
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00012776 File Offset: 0x00010976
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorViewport.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorViewport.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
	}
}
