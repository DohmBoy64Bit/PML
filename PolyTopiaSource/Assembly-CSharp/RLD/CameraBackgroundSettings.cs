using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class CameraBackgroundSettings : Settings
	{
		// Token: 0x06001836 RID: 6198 RVA: 0x0007FE3C File Offset: 0x0007E03C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraBackgroundSettings()
		{
			Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraBackgroundSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr);
			CameraBackgroundSettings.NativeFieldInfoPtr__firstColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, "_firstColor");
			CameraBackgroundSettings.NativeFieldInfoPtr__secondColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, "_secondColor");
			CameraBackgroundSettings.NativeFieldInfoPtr__gradientOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, "_gradientOffset");
			CameraBackgroundSettings.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, "_isVisible");
			CameraBackgroundSettings.NativeMethodInfoPtr_get_FirstColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666876);
			CameraBackgroundSettings.NativeMethodInfoPtr_set_FirstColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666877);
			CameraBackgroundSettings.NativeMethodInfoPtr_get_SecondColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666878);
			CameraBackgroundSettings.NativeMethodInfoPtr_set_SecondColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666879);
			CameraBackgroundSettings.NativeMethodInfoPtr_get_GradientOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666880);
			CameraBackgroundSettings.NativeMethodInfoPtr_set_GradientOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666881);
			CameraBackgroundSettings.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666882);
			CameraBackgroundSettings.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666883);
			CameraBackgroundSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr, 100666884);
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0007FF70 File Offset: 0x0007E170
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0007FFB0 File Offset: 0x0007E1B0
		public unsafe Color FirstColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_get_FirstColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_set_FirstColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x00080034 File Offset: 0x0007E234
		public unsafe Color SecondColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_get_SecondColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_set_SecondColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00080078 File Offset: 0x0007E278
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x000800B4 File Offset: 0x0007E2B4
		public unsafe float GradientOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_get_GradientOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_set_GradientOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x000800F4 File Offset: 0x0007E2F4
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00080130 File Offset: 0x0007E330
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00080170 File Offset: 0x0007E370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74380, XrefRangeEnd = 74387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraBackgroundSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraBackgroundSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBackgroundSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0000AAAB File Offset: 0x00008CAB
		public CameraBackgroundSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000801AC File Offset: 0x0007E3AC
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public unsafe Color _firstColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__firstColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__firstColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000801DC File Offset: 0x0007E3DC
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000AAD3 File Offset: 0x00008CD3
		public unsafe Color _secondColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__secondColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__secondColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0008020C File Offset: 0x0007E40C
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000AAF2 File Offset: 0x00008CF2
		public unsafe float _gradientOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__gradientOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__gradientOffset)) = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00080234 File Offset: 0x0007E434
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000AB0D File Offset: 0x00008D0D
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraBackgroundSettings.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr__firstColor;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr__secondColor;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr__gradientOffset;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstColor_Public_get_Color_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_set_FirstColor_Public_set_Void_Color_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondColor_Public_get_Color_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondColor_Public_set_Void_Color_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_get_GradientOffset_Public_get_Single_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_set_GradientOffset_Public_set_Void_Single_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
