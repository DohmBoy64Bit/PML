using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BE RID: 702
	public class UIView : UIField
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x00116BE8 File Offset: 0x00114DE8
		// Note: this type is marked as 'beforefieldinit'.
		static UIView()
		{
			Il2CppClassPointerStore<UIView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UIView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIView>.NativeClassPtr);
			UIView.NativeFieldInfoPtr_border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "border");
			UIView.NativeFieldInfoPtr_borderRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "borderRect");
			UIView.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "fill");
			UIView.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "color");
			UIView.NativeFieldInfoPtr_borderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "borderWidth");
			UIView.NativeFieldInfoPtr_borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "borderColor");
			UIView.NativeFieldInfoPtr_cornerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "cornerRadius");
			UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_borderWidth");
			UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_borderColor");
			UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_cornerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIView>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_cornerRadius");
			UIView.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672824);
			UIView.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672825);
			UIView.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672826);
			UIView.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672827);
			UIView.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672828);
			UIView.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672829);
			UIView.NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672830);
			UIView.NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672831);
			UIView.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672844);
			UIView.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672845);
			UIView.NativeMethodInfoPtr_get_NetworkborderWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672846);
			UIView.NativeMethodInfoPtr_set_NetworkborderWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672847);
			UIView.NativeMethodInfoPtr_get_NetworkborderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672848);
			UIView.NativeMethodInfoPtr_set_NetworkborderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672849);
			UIView.NativeMethodInfoPtr_get_NetworkcornerRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672850);
			UIView.NativeMethodInfoPtr_set_NetworkcornerRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672851);
			UIView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672842);
			UIView.NativeMethodInfoPtr_UpdateBorder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672832);
			UIView.NativeMethodInfoPtr_SyncSetBorderWidth_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672833);
			UIView.NativeMethodInfoPtr_SyncSetBorderColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672834);
			UIView.NativeMethodInfoPtr_SyncSetCornerRadius_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672835);
			UIView.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672836);
			UIView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672837);
			UIView.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672838);
			UIView.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672839);
			UIView.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672840);
			UIView.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672841);
			UIView.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672843);
			UIView.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672852);
			UIView.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIView>.NativeClassPtr, 100672853);
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x00116F4C File Offset: 0x0011514C
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x00116F8C File Offset: 0x0011518C
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123253, RefRangeEnd = 123254, XrefRangeStart = 123250, XrefRangeEnd = 123253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x00116FD0 File Offset: 0x001151D0
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x00117010 File Offset: 0x00115210
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123257, RefRangeEnd = 123258, XrefRangeStart = 123254, XrefRangeEnd = 123257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00117054 File Offset: 0x00115254
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x00117090 File Offset: 0x00115290
		public unsafe float BorderWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 123263, RefRangeEnd = 123267, XrefRangeStart = 123258, XrefRangeEnd = 123263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x001170D0 File Offset: 0x001152D0
		// (set) Token: 0x06003DF6 RID: 15862 RVA: 0x0011710C File Offset: 0x0011530C
		public unsafe float CornerRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 123273, RefRangeEnd = 123277, XrefRangeStart = 123267, XrefRangeEnd = 123273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x0011714C File Offset: 0x0011534C
		// (set) Token: 0x06003DF8 RID: 15864 RVA: 0x0011718C File Offset: 0x0011538C
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123277, XrefRangeEnd = 123280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x001171D0 File Offset: 0x001153D0
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x0011720C File Offset: 0x0011540C
		public unsafe float NetworkborderWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_NetworkborderWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123280, XrefRangeEnd = 123283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_NetworkborderWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x0011724C File Offset: 0x0011544C
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x0011728C File Offset: 0x0011548C
		public unsafe Color NetworkborderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_NetworkborderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123283, XrefRangeEnd = 123286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_NetworkborderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x001172D0 File Offset: 0x001154D0
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x0011730C File Offset: 0x0011550C
		public unsafe float NetworkcornerRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_get_NetworkcornerRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123286, XrefRangeEnd = 123289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_set_NetworkcornerRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0011734C File Offset: 0x0011554C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123316, RefRangeEnd = 123318, XrefRangeStart = 123289, XrefRangeEnd = 123316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00117388 File Offset: 0x00115588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123323, RefRangeEnd = 123325, XrefRangeStart = 123318, XrefRangeEnd = 123323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_UpdateBorder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x001173BC File Offset: 0x001155BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123325, XrefRangeEnd = 123326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetBorderWidth(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_SyncSetBorderWidth_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00117408 File Offset: 0x00115608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123326, XrefRangeEnd = 123329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetBorderColor(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_SyncSetBorderColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0011745C File Offset: 0x0011565C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123329, XrefRangeEnd = 123330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetCornerRadius(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_SyncSetCornerRadius_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x001174A8 File Offset: 0x001156A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123330, XrefRangeEnd = 123333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetColor(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIView.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x001174FC File Offset: 0x001156FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123354, RefRangeEnd = 123357, XrefRangeStart = 123333, XrefRangeEnd = 123354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00117538 File Offset: 0x00115738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123368, RefRangeEnd = 123371, XrefRangeStart = 123357, XrefRangeEnd = 123368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00117574 File Offset: 0x00115774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123371, XrefRangeEnd = 123377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x001175B0 File Offset: 0x001157B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123382, RefRangeEnd = 123384, XrefRangeStart = 123377, XrefRangeEnd = 123382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x001175EC File Offset: 0x001157EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123397, RefRangeEnd = 123400, XrefRangeStart = 123384, XrefRangeEnd = 123397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0011763C File Offset: 0x0011583C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00117684 File Offset: 0x00115884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123410, RefRangeEnd = 123412, XrefRangeStart = 123400, XrefRangeEnd = 123410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x001176E0 File Offset: 0x001158E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123438, RefRangeEnd = 123440, XrefRangeStart = 123412, XrefRangeEnd = 123438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIView.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00017BF3 File Offset: 0x00015DF3
		public UIView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x0011773C File Offset: 0x0011593C
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x00017BFC File Offset: 0x00015DFC
		public unsafe Image border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x0011776C File Offset: 0x0011596C
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x00017C1B File Offset: 0x00015E1B
		public unsafe RectTransform borderRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x0011779C File Offset: 0x0011599C
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x00017C3A File Offset: 0x00015E3A
		public unsafe Image fill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_fill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x001177CC File Offset: 0x001159CC
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x00017C59 File Offset: 0x00015E59
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x001177FC File Offset: 0x001159FC
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x00017C78 File Offset: 0x00015E78
		public unsafe float borderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderWidth)) = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x00117824 File Offset: 0x00115A24
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00017C93 File Offset: 0x00015E93
		public unsafe Color borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00117854 File Offset: 0x00115A54
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x00017CB2 File Offset: 0x00015EB2
		public unsafe float cornerRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_cornerRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr_cornerRadius)) = value;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x0011787C File Offset: 0x00115A7C
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00017CCD File Offset: 0x00015ECD
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x001178AC File Offset: 0x00115AAC
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00017CEC File Offset: 0x00015EEC
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_borderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x001178DC File Offset: 0x00115ADC
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00017D0B File Offset: 0x00015F0B
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0011790C File Offset: 0x00115B0C
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x00017D2A File Offset: 0x00015F2A
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_cornerRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_cornerRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIView.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_cornerRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeFieldInfoPtr_border;

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeFieldInfoPtr_borderRect;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeFieldInfoPtr_fill;

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeFieldInfoPtr_borderWidth;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeFieldInfoPtr_borderColor;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeFieldInfoPtr_cornerRadius;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderWidth;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_borderColor;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_cornerRadius;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0;

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkborderWidth_Public_get_Single_0;

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkborderWidth_Public_set_Void_Single_0;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkborderColor_Public_get_Color_0;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkborderColor_Public_set_Void_Color_0;

		// Token: 0x0400304B RID: 12363
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcornerRadius_Public_get_Single_0;

		// Token: 0x0400304C RID: 12364
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcornerRadius_Public_set_Void_Single_0;

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBorder_Private_Void_0;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetBorderWidth_Private_Void_Single_Single_0;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetBorderColor_Private_Void_Color_Color_0;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetCornerRadius_Private_Void_Single_Single_0;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
