using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AF RID: 687
	public class SunLight : DynamicInstance
	{
		// Token: 0x06003AED RID: 15085 RVA: 0x0010A8A4 File Offset: 0x00108AA4
		// Note: this type is marked as 'beforefieldinit'.
		static SunLight()
		{
			Il2CppClassPointerStore<SunLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "SunLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunLight>.NativeClassPtr);
			SunLight.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "light");
			SunLight.NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "brightness");
			SunLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "color");
			SunLight.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "shadows");
			SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_brightness");
			SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLight>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shadows");
			SunLight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672363);
			SunLight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672364);
			SunLight.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672365);
			SunLight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672366);
			SunLight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672367);
			SunLight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672368);
			SunLight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672375);
			SunLight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672376);
			SunLight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672377);
			SunLight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672378);
			SunLight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672379);
			SunLight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672380);
			SunLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672373);
			SunLight.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672369);
			SunLight.NativeMethodInfoPtr_OnBrightnessChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672370);
			SunLight.NativeMethodInfoPtr_OnColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672371);
			SunLight.NativeMethodInfoPtr_OnShadowsChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672372);
			SunLight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672374);
			SunLight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672381);
			SunLight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLight>.NativeClassPtr, 100672382);
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x0010AAF0 File Offset: 0x00108CF0
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x0010AB2C File Offset: 0x00108D2C
		public unsafe float Brightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119529, RefRangeEnd = 119531, XrefRangeStart = 119524, XrefRangeEnd = 119529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x0010AB6C File Offset: 0x00108D6C
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x0010ABAC File Offset: 0x00108DAC
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119535, RefRangeEnd = 119537, XrefRangeStart = 119531, XrefRangeEnd = 119535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x0010ABF0 File Offset: 0x00108DF0
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x0010AC2C File Offset: 0x00108E2C
		public unsafe bool Shadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119542, RefRangeEnd = 119544, XrefRangeStart = 119537, XrefRangeEnd = 119542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x0010AC6C File Offset: 0x00108E6C
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x0010ACA8 File Offset: 0x00108EA8
		public unsafe float Networkbrightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119544, XrefRangeEnd = 119547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x0010ACE8 File Offset: 0x00108EE8
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x0010AD28 File Offset: 0x00108F28
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119547, XrefRangeEnd = 119550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0010AD6C File Offset: 0x00108F6C
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x0010ADA8 File Offset: 0x00108FA8
		public unsafe bool Networkshadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119550, XrefRangeEnd = 119553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x0010ADE8 File Offset: 0x00108FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119553, XrefRangeEnd = 119581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SunLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x0010AE24 File Offset: 0x00109024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119581, XrefRangeEnd = 119586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunLight.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x0010AE60 File Offset: 0x00109060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119586, XrefRangeEnd = 119591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBrightnessChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_OnBrightnessChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x0010AEAC File Offset: 0x001090AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119591, XrefRangeEnd = 119596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorChanged(Color oldValue, Color newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_OnColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x0010AF00 File Offset: 0x00109100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119596, XrefRangeEnd = 119601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShadowsChanged(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLight.NativeMethodInfoPtr_OnShadowsChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x0010AF4C File Offset: 0x0010914C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunLight.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x0010AF94 File Offset: 0x00109194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119601, XrefRangeEnd = 119609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunLight.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x0010AFF0 File Offset: 0x001091F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119609, XrefRangeEnd = 119630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunLight.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00016ACF File Offset: 0x00014CCF
		public SunLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x0010B04C File Offset: 0x0010924C
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x00016AD8 File Offset: 0x00014CD8
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x0010B07C File Offset: 0x0010927C
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x00016AF7 File Offset: 0x00014CF7
		public unsafe float brightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_brightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_brightness)) = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x0010B0A4 File Offset: 0x001092A4
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x00016B12 File Offset: 0x00014D12
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x0010B0D4 File Offset: 0x001092D4
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x00016B31 File Offset: 0x00014D31
		public unsafe bool shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_shadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr_shadows)) = value;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x0010B0FC File Offset: 0x001092FC
		// (set) Token: 0x06003B0C RID: 15116 RVA: 0x00016B4C File Offset: 0x00014D4C
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_brightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_brightness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_brightness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x0010B12C File Offset: 0x0010932C
		// (set) Token: 0x06003B0E RID: 15118 RVA: 0x00016B6B File Offset: 0x00014D6B
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x0010B15C File Offset: 0x0010935C
		// (set) Token: 0x06003B10 RID: 15120 RVA: 0x00016B8A File Offset: 0x00014D8A
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLight.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeFieldInfoPtr_brightness;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeFieldInfoPtr_shadows;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_brightness;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shadows;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkbrightness_Public_get_Single_0;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkbrightness_Public_set_Void_Single_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkshadows_Public_get_Boolean_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkshadows_Public_set_Void_Boolean_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_OnBrightnessChanged_Private_Void_Single_Single_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeMethodInfoPtr_OnColorChanged_Private_Void_Color_Color_0;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeMethodInfoPtr_OnShadowsChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
