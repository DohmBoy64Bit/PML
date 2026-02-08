using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FE RID: 766
	public class UIButtonProxy : UILabelProxy
	{
		// Token: 0x060042AE RID: 17070 RVA: 0x0012B7E8 File Offset: 0x001299E8
		// Note: this type is marked as 'beforefieldinit'.
		static UIButtonProxy()
		{
			Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIButtonProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr);
			UIButtonProxy.NativeFieldInfoPtr_uiButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr, "uiButton");
			UIButtonProxy.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr, 100673834);
			UIButtonProxy.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr, 100673835);
			UIButtonProxy.NativeMethodInfoPtr__ctor_Public_Void_UIButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr, 100673836);
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x0012B868 File Offset: 0x00129A68
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x0012B8A4 File Offset: 0x00129AA4
		public unsafe bool Interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIButtonProxy.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129074, XrefRangeEnd = 129076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIButtonProxy.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0012B8E4 File Offset: 0x00129AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIButtonProxy(UIButton target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIButtonProxy.NativeMethodInfoPtr__ctor_Public_Void_UIButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00018BF1 File Offset: 0x00016DF1
		public UIButtonProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x0012B930 File Offset: 0x00129B30
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x00018BFA File Offset: 0x00016DFA
		public unsafe UIButton uiButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIButtonProxy.NativeFieldInfoPtr_uiButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIButtonProxy.NativeFieldInfoPtr_uiButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr_uiButton;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIButton_0;
	}
}
