using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AD RID: 685
	public class Spotlight : DynamicInstance
	{
		// Token: 0x06003AA2 RID: 15010 RVA: 0x001093C0 File Offset: 0x001075C0
		// Note: this type is marked as 'beforefieldinit'.
		static Spotlight()
		{
			Il2CppClassPointerStore<Spotlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Spotlight");
			Spotlight.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "intensityMultiplier");
			Spotlight.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "rangeMultiplier");
			Spotlight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "range");
			Spotlight.NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "brightness");
			Spotlight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "color");
			Spotlight.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "angle");
			Spotlight.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, "shadows");
			Spotlight.NativeMethodInfoPtr_get_Range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672311);
			Spotlight.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672312);
			Spotlight.NativeMethodInfoPtr_get_Angle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672313);
			Spotlight.NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672314);
			Spotlight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672315);
			Spotlight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672316);
			Spotlight.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672317);
			Spotlight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672318);
			Spotlight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672319);
			Spotlight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672320);
			Spotlight.NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672331);
			Spotlight.NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672332);
			Spotlight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672333);
			Spotlight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672334);
			Spotlight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672335);
			Spotlight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672336);
			Spotlight.NativeMethodInfoPtr_get_Networkangle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672337);
			Spotlight.NativeMethodInfoPtr_set_Networkangle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672338);
			Spotlight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672339);
			Spotlight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672340);
			Spotlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672328);
			Spotlight.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672309);
			Spotlight.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672310);
			Spotlight.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672321);
			Spotlight.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672322);
			Spotlight.NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672323);
			Spotlight.NativeMethodInfoPtr_RpcSetAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672324);
			Spotlight.NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672325);
			Spotlight.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672326);
			Spotlight.NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672327);
			Spotlight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672330);
			Spotlight.NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672341);
			Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672342);
			Spotlight.NativeMethodInfoPtr_UserCode_RpcSetAngle__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672343);
			Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetAngle__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672344);
			Spotlight.NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672345);
			Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672346);
			Spotlight.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672347);
			Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672348);
			Spotlight.NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672349);
			Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672350);
			Spotlight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672351);
			Spotlight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spotlight>.NativeClassPtr, 100672352);
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x001097D0 File Offset: 0x001079D0
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x0010980C File Offset: 0x00107A0C
		public unsafe float Range
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118976, RefRangeEnd = 118977, XrefRangeStart = 118968, XrefRangeEnd = 118976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119008, RefRangeEnd = 119013, XrefRangeStart = 118977, XrefRangeEnd = 119008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x0010984C File Offset: 0x00107A4C
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00109888 File Offset: 0x00107A88
		public unsafe float Angle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119018, RefRangeEnd = 119019, XrefRangeStart = 119013, XrefRangeEnd = 119018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Angle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119045, RefRangeEnd = 119050, XrefRangeStart = 119019, XrefRangeEnd = 119045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x001098C8 File Offset: 0x00107AC8
		// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x00109904 File Offset: 0x00107B04
		public unsafe float Brightness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119058, RefRangeEnd = 119059, XrefRangeStart = 119050, XrefRangeEnd = 119058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119090, RefRangeEnd = 119095, XrefRangeStart = 119059, XrefRangeEnd = 119090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x00109944 File Offset: 0x00107B44
		// (set) Token: 0x06003AAA RID: 15018 RVA: 0x00109984 File Offset: 0x00107B84
		public unsafe Color Color
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119099, RefRangeEnd = 119100, XrefRangeStart = 119095, XrefRangeEnd = 119099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119126, RefRangeEnd = 119131, XrefRangeStart = 119100, XrefRangeEnd = 119126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x001099C8 File Offset: 0x00107BC8
		// (set) Token: 0x06003AAC RID: 15020 RVA: 0x00109A04 File Offset: 0x00107C04
		public unsafe bool Shadows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119135, RefRangeEnd = 119136, XrefRangeStart = 119131, XrefRangeEnd = 119135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119162, RefRangeEnd = 119167, XrefRangeStart = 119136, XrefRangeEnd = 119162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00109A44 File Offset: 0x00107C44
		// (set) Token: 0x06003AAE RID: 15022 RVA: 0x00109A80 File Offset: 0x00107C80
		public unsafe float Networkrange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119167, XrefRangeEnd = 119173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x00109AC0 File Offset: 0x00107CC0
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x00109AFC File Offset: 0x00107CFC
		public unsafe float Networkbrightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119173, XrefRangeEnd = 119179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x00109B3C File Offset: 0x00107D3C
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x00109B7C File Offset: 0x00107D7C
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119179, XrefRangeEnd = 119185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x00109BC0 File Offset: 0x00107DC0
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x00109BFC File Offset: 0x00107DFC
		public unsafe float Networkangle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Networkangle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119185, XrefRangeEnd = 119191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Networkangle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x00109C3C File Offset: 0x00107E3C
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x00109C78 File Offset: 0x00107E78
		public unsafe bool Networkshadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119191, XrefRangeEnd = 119197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x00109CB8 File Offset: 0x00107EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119197, XrefRangeEnd = 119201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spotlight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spotlight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00109CF4 File Offset: 0x00107EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119201, XrefRangeEnd = 119207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00109D30 File Offset: 0x00107F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119207, XrefRangeEnd = 119213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x00109D6C File Offset: 0x00107F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119213, XrefRangeEnd = 119229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x00109DA8 File Offset: 0x00107FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119229, XrefRangeEnd = 119267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00109DF8 File Offset: 0x00107FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119267, XrefRangeEnd = 119288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetRange(float range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00109E38 File Offset: 0x00108038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119288, XrefRangeEnd = 119309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_RpcSetAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00109E78 File Offset: 0x00108078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119309, XrefRangeEnd = 119330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetBrightness(float brightness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brightness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00109EB8 File Offset: 0x001080B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119330, XrefRangeEnd = 119351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00109EFC File Offset: 0x001080FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119351, XrefRangeEnd = 119372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetShadowsEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00109F3C File Offset: 0x0010813C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00109F84 File Offset: 0x00108184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119372, XrefRangeEnd = 119374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetRange__Single(float range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00109FC4 File Offset: 0x001081C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119374, XrefRangeEnd = 119385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x0010A020 File Offset: 0x00108220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119385, XrefRangeEnd = 119387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAngle__Single(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_UserCode_RpcSetAngle__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x0010A060 File Offset: 0x00108260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119387, XrefRangeEnd = 119398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAngle__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetAngle__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x0010A0BC File Offset: 0x001082BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119398, XrefRangeEnd = 119400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetBrightness__Single(float brightness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brightness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x0010A0FC File Offset: 0x001082FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119400, XrefRangeEnd = 119411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x0010A158 File Offset: 0x00108358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119411, XrefRangeEnd = 119413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetColor__Color(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0010A19C File Offset: 0x0010839C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119413, XrefRangeEnd = 119424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x0010A1F8 File Offset: 0x001083F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119424, XrefRangeEnd = 119426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x0010A238 File Offset: 0x00108438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119426, XrefRangeEnd = 119441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spotlight.NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x0010A294 File Offset: 0x00108494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119441, XrefRangeEnd = 119453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x0010A2F0 File Offset: 0x001084F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119453, XrefRangeEnd = 119486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spotlight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x000169D8 File Offset: 0x00014BD8
		public Spotlight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0010A34C File Offset: 0x0010854C
		// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x000169E1 File Offset: 0x00014BE1
		public unsafe static float intensityMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Spotlight.NativeFieldInfoPtr_intensityMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spotlight.NativeFieldInfoPtr_intensityMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x0010A368 File Offset: 0x00108568
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x000169EF File Offset: 0x00014BEF
		public unsafe static float rangeMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Spotlight.NativeFieldInfoPtr_rangeMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spotlight.NativeFieldInfoPtr_rangeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x0010A384 File Offset: 0x00108584
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x000169FD File Offset: 0x00014BFD
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x0010A3AC File Offset: 0x001085AC
		// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x00016A18 File Offset: 0x00014C18
		public unsafe float brightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_brightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_brightness)) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x0010A3D4 File Offset: 0x001085D4
		// (set) Token: 0x06003AD8 RID: 15064 RVA: 0x00016A33 File Offset: 0x00014C33
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x0010A404 File Offset: 0x00108604
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x00016A52 File Offset: 0x00014C52
		public unsafe float angle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_angle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_angle)) = value;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x0010A42C File Offset: 0x0010862C
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x00016A6D File Offset: 0x00014C6D
		public unsafe bool shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_shadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spotlight.NativeFieldInfoPtr_shadows)) = value;
			}
		}

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeFieldInfoPtr_brightness;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeFieldInfoPtr_angle;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeFieldInfoPtr_shadows;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Single_0;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeMethodInfoPtr_get_Angle_Public_get_Single_0;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkrange_Public_get_Single_0;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkrange_Public_set_Void_Single_0;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkangle_Public_get_Single_0;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkangle_Public_set_Void_Single_0;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetRange_Private_Void_Single_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAngle_Private_Void_Single_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetBrightness_Private_Void_Single_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetShadowsEnabled_Private_Void_Boolean_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetRange__Single_Protected_Void_Single_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetRange__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAngle__Single_Protected_Void_Single_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAngle__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetBrightness__Single_Protected_Void_Single_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetBrightness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetShadowsEnabled__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetShadowsEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
