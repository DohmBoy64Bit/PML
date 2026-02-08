using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D2 RID: 722
	public class CameraProxy : DynamicInstanceProxy
	{
		// Token: 0x06003F9F RID: 16287 RVA: 0x0011D7F8 File Offset: 0x0011B9F8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProxy()
		{
			Il2CppClassPointerStore<CameraProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "CameraProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr);
			CameraProxy.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, "camera");
			CameraProxy.NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673228);
			CameraProxy.NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673229);
			CameraProxy.NativeMethodInfoPtr_get_FOV_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673230);
			CameraProxy.NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673231);
			CameraProxy.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673232);
			CameraProxy.NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673233);
			CameraProxy.NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673234);
			CameraProxy.NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673235);
			CameraProxy.NativeMethodInfoPtr_get_Distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673236);
			CameraProxy.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673237);
			CameraProxy.NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673238);
			CameraProxy.NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673239);
			CameraProxy.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673240);
			CameraProxy.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673241);
			CameraProxy.NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673242);
			CameraProxy.NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673243);
			CameraProxy.NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673244);
			CameraProxy.NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673245);
			CameraProxy.NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673246);
			CameraProxy.NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673247);
			CameraProxy.NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673248);
			CameraProxy.NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673249);
			CameraProxy.NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673250);
			CameraProxy.NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673251);
			CameraProxy.NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673252);
			CameraProxy.NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673253);
			CameraProxy.NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673254);
			CameraProxy.NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673255);
			CameraProxy.NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673256);
			CameraProxy.NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673257);
			CameraProxy.NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673258);
			CameraProxy.NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673259);
			CameraProxy.NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673260);
			CameraProxy.NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673261);
			CameraProxy.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673262);
			CameraProxy.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673263);
			CameraProxy.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673264);
			CameraProxy.NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673265);
			CameraProxy.NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673266);
			CameraProxy.NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673267);
			CameraProxy.NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673268);
			CameraProxy.NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr, 100673227);
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x0011DB84 File Offset: 0x0011BD84
		// (set) Token: 0x06003FA1 RID: 16289 RVA: 0x0011DBC4 File Offset: 0x0011BDC4
		public unsafe CameraMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x0011DC08 File Offset: 0x0011BE08
		// (set) Token: 0x06003FA3 RID: 16291 RVA: 0x0011DC44 File Offset: 0x0011BE44
		public unsafe float FOV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128469, XrefRangeEnd = 128471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FOV_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128471, XrefRangeEnd = 128473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x0011DC84 File Offset: 0x0011BE84
		// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x0011DCC0 File Offset: 0x0011BEC0
		public unsafe bool Orthographic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128473, XrefRangeEnd = 128475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128475, XrefRangeEnd = 128477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x0011DD00 File Offset: 0x0011BF00
		// (set) Token: 0x06003FA7 RID: 16295 RVA: 0x0011DD3C File Offset: 0x0011BF3C
		public unsafe float OrthographicSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128477, XrefRangeEnd = 128479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128479, XrefRangeEnd = 128481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x0011DD7C File Offset: 0x0011BF7C
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x0011DDB8 File Offset: 0x0011BFB8
		public unsafe float Distance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_Distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06003FAA RID: 16298 RVA: 0x0011DDF8 File Offset: 0x0011BFF8
		// (set) Token: 0x06003FAB RID: 16299 RVA: 0x0011DE34 File Offset: 0x0011C034
		public unsafe float MinDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06003FAC RID: 16300 RVA: 0x0011DE74 File Offset: 0x0011C074
		// (set) Token: 0x06003FAD RID: 16301 RVA: 0x0011DEB0 File Offset: 0x0011C0B0
		public unsafe float MaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06003FAE RID: 16302 RVA: 0x0011DEF0 File Offset: 0x0011C0F0
		// (set) Token: 0x06003FAF RID: 16303 RVA: 0x0011DF2C File Offset: 0x0011C12C
		public unsafe float HorizontalSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x0011DF6C File Offset: 0x0011C16C
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x0011DFA8 File Offset: 0x0011C1A8
		public unsafe float VerticalSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x0011E024 File Offset: 0x0011C224
		public unsafe float ScrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x0011E064 File Offset: 0x0011C264
		// (set) Token: 0x06003FB5 RID: 16309 RVA: 0x0011E0A0 File Offset: 0x0011C2A0
		public unsafe bool ClipThroughWalls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x0011E0E0 File Offset: 0x0011C2E0
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x0011E11C File Offset: 0x0011C31C
		public unsafe float FlySpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x0011E15C File Offset: 0x0011C35C
		// (set) Token: 0x06003FB9 RID: 16313 RVA: 0x0011E198 File Offset: 0x0011C398
		public unsafe float FastFlySpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06003FBA RID: 16314 RVA: 0x0011E1D8 File Offset: 0x0011C3D8
		// (set) Token: 0x06003FBB RID: 16315 RVA: 0x0011E214 File Offset: 0x0011C414
		public unsafe float FreeLookSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x0011E254 File Offset: 0x0011C454
		// (set) Token: 0x06003FBD RID: 16317 RVA: 0x0011E290 File Offset: 0x0011C490
		public unsafe float LerpSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06003FBE RID: 16318 RVA: 0x0011E2D0 File Offset: 0x0011C4D0
		// (set) Token: 0x06003FBF RID: 16319 RVA: 0x0011E30C File Offset: 0x0011C50C
		public unsafe bool FollowLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x0011E34C File Offset: 0x0011C54C
		// (set) Token: 0x06003FC1 RID: 16321 RVA: 0x0011E388 File Offset: 0x0011C588
		public unsafe float SensitivityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x0011E3C8 File Offset: 0x0011C5C8
		// (set) Token: 0x06003FC3 RID: 16323 RVA: 0x0011E408 File Offset: 0x0011C608
		public unsafe Vector3 PositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x0011E44C File Offset: 0x0011C64C
		// (set) Token: 0x06003FC5 RID: 16325 RVA: 0x0011E48C File Offset: 0x0011C68C
		public unsafe Vector3 RotationOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x0011E4D0 File Offset: 0x0011C6D0
		public unsafe bool IsFirstPerson
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128481, XrefRangeEnd = 128483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x0011E50C File Offset: 0x0011C70C
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x0011E54C File Offset: 0x0011C74C
		public unsafe DynamicInstance FollowTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128483, XrefRangeEnd = 128485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0011E590 File Offset: 0x0011C790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraProxy(Camera target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProxy.NativeMethodInfoPtr__ctor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00018511 File Offset: 0x00016711
		public CameraProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x0011E5DC File Offset: 0x0011C7DC
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x0001851A File Offset: 0x0001671A
		public unsafe Camera camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProxy.NativeFieldInfoPtr_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProxy.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeFieldInfoPtr_camera;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr_get_FOV_Public_get_Single_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_Single_0;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;
	}
}
