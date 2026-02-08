using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EC RID: 748
	public class PlayerGUIProxy : InstanceProxy
	{
		// Token: 0x06004193 RID: 16787 RVA: 0x0012695C File Offset: 0x00124B5C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerGUIProxy()
		{
			Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PlayerGUIProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr);
			PlayerGUIProxy.NativeFieldInfoPtr_playerGUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, "playerGUI");
			PlayerGUIProxy.NativeMethodInfoPtr_get_Opacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, 100673624);
			PlayerGUIProxy.NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, 100673625);
			PlayerGUIProxy.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, 100673626);
			PlayerGUIProxy.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, 100673627);
			PlayerGUIProxy.NativeMethodInfoPtr__ctor_Public_Void_PlayerGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr, 100673623);
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x00126A04 File Offset: 0x00124C04
		// (set) Token: 0x06004195 RID: 16789 RVA: 0x00126A40 File Offset: 0x00124C40
		public unsafe float Opacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUIProxy.NativeMethodInfoPtr_get_Opacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128852, XrefRangeEnd = 128854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUIProxy.NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x00126A80 File Offset: 0x00124C80
		// (set) Token: 0x06004197 RID: 16791 RVA: 0x00126ABC File Offset: 0x00124CBC
		public unsafe bool Interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUIProxy.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128854, XrefRangeEnd = 128856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUIProxy.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00126AFC File Offset: 0x00124CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerGUIProxy(PlayerGUI target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerGUIProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUIProxy.NativeMethodInfoPtr__ctor_Public_Void_PlayerGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00018921 File Offset: 0x00016B21
		public PlayerGUIProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x00126B48 File Offset: 0x00124D48
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x0001892A File Offset: 0x00016B2A
		public unsafe PlayerGUI playerGUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUIProxy.NativeFieldInfoPtr_playerGUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUIProxy.NativeFieldInfoPtr_playerGUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeFieldInfoPtr_playerGUI;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_get_Opacity_Public_get_Single_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0;

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerGUI_0;
	}
}
