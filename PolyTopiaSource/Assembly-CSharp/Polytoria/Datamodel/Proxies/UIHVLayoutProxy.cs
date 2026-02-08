using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000301 RID: 769
	public class UIHVLayoutProxy : UIFieldProxy
	{
		// Token: 0x060042D1 RID: 17105 RVA: 0x0012C0F8 File Offset: 0x0012A2F8
		// Note: this type is marked as 'beforefieldinit'.
		static UIHVLayoutProxy()
		{
			Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIHVLayoutProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr);
			UIHVLayoutProxy.NativeFieldInfoPtr_uiHVLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, "uiHVLayout");
			UIHVLayoutProxy.NativeMethodInfoPtr_get_Spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673858);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673859);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673860);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673861);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673862);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673863);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673864);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673865);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673866);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673867);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673868);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673869);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673870);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673871);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673872);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673873);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673874);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673875);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673876);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673877);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673878);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673879);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673880);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673881);
			UIHVLayoutProxy.NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673882);
			UIHVLayoutProxy.NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673883);
			UIHVLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIHVLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr, 100673857);
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x0012C358 File Offset: 0x0012A558
		// (set) Token: 0x060042D3 RID: 17107 RVA: 0x0012C394 File Offset: 0x0012A594
		public unsafe float Spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_Spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129096, XrefRangeEnd = 129098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x0012C3D4 File Offset: 0x0012A5D4
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x0012C410 File Offset: 0x0012A610
		public unsafe bool ChildControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129098, XrefRangeEnd = 129100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0012C450 File Offset: 0x0012A650
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x0012C48C File Offset: 0x0012A68C
		public unsafe bool ChildControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129100, XrefRangeEnd = 129102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x0012C4CC File Offset: 0x0012A6CC
		// (set) Token: 0x060042D9 RID: 17113 RVA: 0x0012C508 File Offset: 0x0012A708
		public unsafe bool ChildScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129102, XrefRangeEnd = 129104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x0012C548 File Offset: 0x0012A748
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x0012C584 File Offset: 0x0012A784
		public unsafe bool ChildScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129104, XrefRangeEnd = 129106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x0012C5C4 File Offset: 0x0012A7C4
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x0012C600 File Offset: 0x0012A800
		public unsafe bool ChildForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129106, XrefRangeEnd = 129108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x0012C640 File Offset: 0x0012A840
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x0012C67C File Offset: 0x0012A87C
		public unsafe bool ChildForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129108, XrefRangeEnd = 129110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x0012C6BC File Offset: 0x0012A8BC
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x0012C6F8 File Offset: 0x0012A8F8
		public unsafe int PaddingLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129110, XrefRangeEnd = 129112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x0012C738 File Offset: 0x0012A938
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x0012C774 File Offset: 0x0012A974
		public unsafe int PaddingRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129112, XrefRangeEnd = 129114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0012C7B4 File Offset: 0x0012A9B4
		// (set) Token: 0x060042E5 RID: 17125 RVA: 0x0012C7F0 File Offset: 0x0012A9F0
		public unsafe int PaddingTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129114, XrefRangeEnd = 129116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x0012C830 File Offset: 0x0012AA30
		// (set) Token: 0x060042E7 RID: 17127 RVA: 0x0012C86C File Offset: 0x0012AA6C
		public unsafe int PaddingBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129116, XrefRangeEnd = 129118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x0012C8AC File Offset: 0x0012AAAC
		// (set) Token: 0x060042E9 RID: 17129 RVA: 0x0012C8EC File Offset: 0x0012AAEC
		public unsafe TextAnchor ChildAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAnchor>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129118, XrefRangeEnd = 129120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x0012C930 File Offset: 0x0012AB30
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x0012C96C File Offset: 0x0012AB6C
		public unsafe bool ReverseAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129120, XrefRangeEnd = 129122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x0012C9AC File Offset: 0x0012ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIHVLayoutProxy(UIHVLayout target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHVLayoutProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIHVLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00018C69 File Offset: 0x00016E69
		public UIHVLayoutProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0012C9F8 File Offset: 0x0012ABF8
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x00018C72 File Offset: 0x00016E72
		public unsafe UIHVLayout uiHVLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayoutProxy.NativeFieldInfoPtr_uiHVLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIHVLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayoutProxy.NativeFieldInfoPtr_uiHVLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeFieldInfoPtr_uiHVLayout;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeMethodInfoPtr_get_Spacing_Public_get_Single_0;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0;

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0;

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIHVLayout_0;
	}
}
