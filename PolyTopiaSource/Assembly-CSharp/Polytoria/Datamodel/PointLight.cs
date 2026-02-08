using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A4 RID: 676
	public class PointLight : DynamicInstance
	{
		// Token: 0x06003962 RID: 14690 RVA: 0x00103BF4 File Offset: 0x00101DF4
		// Note: this type is marked as 'beforefieldinit'.
		static PointLight()
		{
			Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "PointLight");
			PointLight.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "intensityMultiplier");
			PointLight.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "rangeMultiplier");
			PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "range");
			PointLight.NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "brightness");
			PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "color");
			PointLight.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "shadows");
			PointLight.NativeMethodInfoPtr_get_Range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672074);
			PointLight.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672075);
			PointLight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672076);
			PointLight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672077);
			PointLight.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672078);
			PointLight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672079);
			PointLight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672080);
			PointLight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672081);
			PointLight.NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672091);
			PointLight.NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672092);
			PointLight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672093);
			PointLight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672094);
			PointLight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672095);
			PointLight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672096);
			PointLight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672097);
			PointLight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672098);
			PointLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672088);
			PointLight.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672072);
			PointLight.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672073);
			PointLight.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672082);
			PointLight.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672083);
			PointLight.NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672084);
			PointLight.NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672085);
			PointLight.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672086);
			PointLight.NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672087);
			PointLight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672090);
			PointLight.NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672099);
			PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672100);
			PointLight.NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672101);
			PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672102);
			PointLight.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672103);
			PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672104);
			PointLight.NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672105);
			PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672106);
			PointLight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672107);
			PointLight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLight>.NativeClassPtr, 100672108);
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x00103F64 File Offset: 0x00102164
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x00103FA0 File Offset: 0x001021A0
		public unsafe float Range
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116633, RefRangeEnd = 116634, XrefRangeStart = 116625, XrefRangeEnd = 116633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 116665, RefRangeEnd = 116670, XrefRangeStart = 116634, XrefRangeEnd = 116665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00103FE0 File Offset: 0x001021E0
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x0010401C File Offset: 0x0010221C
		public unsafe float Brightness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116678, RefRangeEnd = 116679, XrefRangeStart = 116670, XrefRangeEnd = 116678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 116710, RefRangeEnd = 116715, XrefRangeStart = 116679, XrefRangeEnd = 116710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0010405C File Offset: 0x0010225C
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x0010409C File Offset: 0x0010229C
		public unsafe Color Color
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116719, RefRangeEnd = 116720, XrefRangeStart = 116715, XrefRangeEnd = 116719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 116746, RefRangeEnd = 116751, XrefRangeStart = 116720, XrefRangeEnd = 116746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x001040E0 File Offset: 0x001022E0
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x0010411C File Offset: 0x0010231C
		public unsafe bool Shadows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116755, RefRangeEnd = 116756, XrefRangeStart = 116751, XrefRangeEnd = 116755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 116782, RefRangeEnd = 116787, XrefRangeStart = 116756, XrefRangeEnd = 116782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x0010415C File Offset: 0x0010235C
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x00104198 File Offset: 0x00102398
		public unsafe float Networkrange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116787, XrefRangeEnd = 116793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x001041D8 File Offset: 0x001023D8
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x00104214 File Offset: 0x00102414
		public unsafe float Networkbrightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116793, XrefRangeEnd = 116799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x00104254 File Offset: 0x00102454
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x00104294 File Offset: 0x00102494
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116799, XrefRangeEnd = 116805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x001042D8 File Offset: 0x001024D8
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x00104314 File Offset: 0x00102514
		public unsafe bool Networkshadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116805, XrefRangeEnd = 116811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00104354 File Offset: 0x00102554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116811, XrefRangeEnd = 116815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00104390 File Offset: 0x00102590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116815, XrefRangeEnd = 116821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x001043CC File Offset: 0x001025CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116821, XrefRangeEnd = 116827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00104408 File Offset: 0x00102608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116827, XrefRangeEnd = 116842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00104444 File Offset: 0x00102644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116842, XrefRangeEnd = 116875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00104494 File Offset: 0x00102694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116875, XrefRangeEnd = 116896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetRange(float range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x001044D4 File Offset: 0x001026D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116896, XrefRangeEnd = 116917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetBrightness(float brightness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brightness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00104514 File Offset: 0x00102714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116917, XrefRangeEnd = 116938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00104558 File Offset: 0x00102758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116938, XrefRangeEnd = 116959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetShadowsEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00104598 File Offset: 0x00102798
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x001045E0 File Offset: 0x001027E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116959, XrefRangeEnd = 116961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetRange__Single(float range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00104620 File Offset: 0x00102820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116961, XrefRangeEnd = 116972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetRange__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0010467C File Offset: 0x0010287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116972, XrefRangeEnd = 116974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetBrightness__Single(float brightness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brightness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x001046BC File Offset: 0x001028BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116974, XrefRangeEnd = 116985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetBrightness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00104718 File Offset: 0x00102918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116985, XrefRangeEnd = 116987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetColor__Color(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0010475C File Offset: 0x0010295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116987, XrefRangeEnd = 116998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x001047B8 File Offset: 0x001029B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116998, XrefRangeEnd = 117000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x001047F8 File Offset: 0x001029F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117000, XrefRangeEnd = 117015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetShadowsEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLight.NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00104854 File Offset: 0x00102A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117015, XrefRangeEnd = 117025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x001048B0 File Offset: 0x00102AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117025, XrefRangeEnd = 117052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointLight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x000164E8 File Offset: 0x000146E8
		public PointLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x0010490C File Offset: 0x00102B0C
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x000164F1 File Offset: 0x000146F1
		public unsafe static float intensityMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PointLight.NativeFieldInfoPtr_intensityMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointLight.NativeFieldInfoPtr_intensityMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x00104928 File Offset: 0x00102B28
		// (set) Token: 0x0600398B RID: 14731 RVA: 0x000164FF File Offset: 0x000146FF
		public unsafe static float rangeMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PointLight.NativeFieldInfoPtr_rangeMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointLight.NativeFieldInfoPtr_rangeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x00104944 File Offset: 0x00102B44
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x0001650D File Offset: 0x0001470D
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x0010496C File Offset: 0x00102B6C
		// (set) Token: 0x0600398F RID: 14735 RVA: 0x00016528 File Offset: 0x00014728
		public unsafe float brightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_brightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_brightness)) = value;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x00104994 File Offset: 0x00102B94
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x00016543 File Offset: 0x00014743
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x001049C4 File Offset: 0x00102BC4
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x00016562 File Offset: 0x00014762
		public unsafe bool shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_shadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLight.NativeFieldInfoPtr_shadows)) = value;
			}
		}

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr_brightness;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeFieldInfoPtr_shadows;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Single_0;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0;

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
