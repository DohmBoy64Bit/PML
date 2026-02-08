using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008C RID: 140
	public static class PlatformAutoDetector : Object
	{
		// Token: 0x06000BE0 RID: 3040 RVA: 0x00043F2C File Offset: 0x0004212C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformAutoDetector()
		{
			Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Platforms", "PlatformAutoDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr);
			PlatformAutoDetector.NativeFieldInfoPtr_m_IsRunningOnAOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "m_IsRunningOnAOT");
			PlatformAutoDetector.NativeFieldInfoPtr_m_AutoDetectionsDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "m_AutoDetectionsDone");
			PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnMono_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsRunningOnMono>k__BackingField");
			PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnClr4_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsRunningOnClr4>k__BackingField");
			PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnUnity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsRunningOnUnity>k__BackingField");
			PlatformAutoDetector.NativeFieldInfoPtr__IsPortableFramework_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsPortableFramework>k__BackingField");
			PlatformAutoDetector.NativeFieldInfoPtr__IsUnityNative_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsUnityNative>k__BackingField");
			PlatformAutoDetector.NativeFieldInfoPtr__IsUnityIL2CPP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<IsUnityIL2CPP>k__BackingField");
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnMono_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665350);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnMono_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665351);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnClr4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665352);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnClr4_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665353);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnUnity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665354);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnUnity_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665355);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsPortableFramework_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665356);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsPortableFramework_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665357);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsUnityNative_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665358);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsUnityNative_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665359);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsUnityIL2CPP_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665360);
			PlatformAutoDetector.NativeMethodInfoPtr_set_IsUnityIL2CPP_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665361);
			PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnAOT_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665362);
			PlatformAutoDetector.NativeMethodInfoPtr_AutoDetectPlatformFlags_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665363);
			PlatformAutoDetector.NativeMethodInfoPtr_GetDefaultPlatform_Internal_Static_IPlatformAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665364);
			PlatformAutoDetector.NativeMethodInfoPtr_GetDefaultScriptLoader_Internal_Static_IScriptLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, 100665365);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0004413C File Offset: 0x0004233C
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0004416C File Offset: 0x0004236C
		public unsafe static bool IsRunningOnMono
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32309, XrefRangeEnd = 32311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnMono_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32311, XrefRangeEnd = 32313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnMono_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000441A0 File Offset: 0x000423A0
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000441D0 File Offset: 0x000423D0
		public unsafe static bool IsRunningOnClr4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32313, XrefRangeEnd = 32315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnClr4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32315, XrefRangeEnd = 32317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnClr4_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00044204 File Offset: 0x00042404
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00044234 File Offset: 0x00042434
		public unsafe static bool IsRunningOnUnity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32317, XrefRangeEnd = 32319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnUnity_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32319, XrefRangeEnd = 32321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsRunningOnUnity_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00044268 File Offset: 0x00042468
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00044298 File Offset: 0x00042498
		public unsafe static bool IsPortableFramework
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32321, XrefRangeEnd = 32323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsPortableFramework_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32323, XrefRangeEnd = 32325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsPortableFramework_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000442CC File Offset: 0x000424CC
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x000442FC File Offset: 0x000424FC
		public unsafe static bool IsUnityNative
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32325, XrefRangeEnd = 32327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsUnityNative_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32327, XrefRangeEnd = 32329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsUnityNative_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00044330 File Offset: 0x00042530
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00044360 File Offset: 0x00042560
		public unsafe static bool IsUnityIL2CPP
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32329, XrefRangeEnd = 32331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsUnityIL2CPP_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32331, XrefRangeEnd = 32333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_set_IsUnityIL2CPP_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00044394 File Offset: 0x00042594
		public unsafe static bool IsRunningOnAOT
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_get_IsRunningOnAOT_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000443C4 File Offset: 0x000425C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32395, RefRangeEnd = 32397, XrefRangeStart = 32333, XrefRangeEnd = 32395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoDetectPlatformFlags()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_AutoDetectPlatformFlags_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000443EC File Offset: 0x000425EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32406, RefRangeEnd = 32407, XrefRangeStart = 32397, XrefRangeEnd = 32406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPlatformAccessor GetDefaultPlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_GetDefaultPlatform_Internal_Static_IPlatformAccessor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlatformAccessor>(intPtr3) : null;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00044420 File Offset: 0x00042620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32407, XrefRangeEnd = 32415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IScriptLoader GetDefaultScriptLoader()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.NativeMethodInfoPtr_GetDefaultScriptLoader_Internal_Static_IScriptLoader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptLoader>(intPtr3) : null;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000058F4 File Offset: 0x00003AF4
		public PlatformAutoDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00044454 File Offset: 0x00042654
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000058FD File Offset: 0x00003AFD
		public unsafe static Nullable<bool> m_IsRunningOnAOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr_m_IsRunningOnAOT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Nullable<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr_m_IsRunningOnAOT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0004447C File Offset: 0x0004267C
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0000590F File Offset: 0x00003B0F
		public unsafe static bool m_AutoDetectionsDone
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr_m_AutoDetectionsDone, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr_m_AutoDetectionsDone, (void*)(&value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00044498 File Offset: 0x00042698
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0000591D File Offset: 0x00003B1D
		public unsafe static bool _IsRunningOnMono_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnMono_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnMono_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000444B4 File Offset: 0x000426B4
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000592B File Offset: 0x00003B2B
		public unsafe static bool _IsRunningOnClr4_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnClr4_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnClr4_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000444D0 File Offset: 0x000426D0
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00005939 File Offset: 0x00003B39
		public unsafe static bool _IsRunningOnUnity_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnUnity_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsRunningOnUnity_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x000444EC File Offset: 0x000426EC
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00005947 File Offset: 0x00003B47
		public unsafe static bool _IsPortableFramework_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsPortableFramework_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsPortableFramework_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00044508 File Offset: 0x00042708
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00005955 File Offset: 0x00003B55
		public unsafe static bool _IsUnityNative_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsUnityNative_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsUnityNative_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00044524 File Offset: 0x00042724
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00005963 File Offset: 0x00003B63
		public unsafe static bool _IsUnityIL2CPP_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.NativeFieldInfoPtr__IsUnityIL2CPP_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.NativeFieldInfoPtr__IsUnityIL2CPP_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRunningOnAOT;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoDetectionsDone;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr__IsRunningOnMono_k__BackingField;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr__IsRunningOnClr4_k__BackingField;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr__IsRunningOnUnity_k__BackingField;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr__IsPortableFramework_k__BackingField;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr__IsUnityNative_k__BackingField;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr__IsUnityIL2CPP_k__BackingField;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnMono_Public_Static_get_Boolean_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunningOnMono_Private_Static_set_Void_Boolean_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnClr4_Public_Static_get_Boolean_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunningOnClr4_Private_Static_set_Void_Boolean_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnUnity_Public_Static_get_Boolean_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunningOnUnity_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPortableFramework_Public_Static_get_Boolean_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPortableFramework_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnityNative_Public_Static_get_Boolean_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnityNative_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnityIL2CPP_Public_Static_get_Boolean_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnityIL2CPP_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnAOT_Public_Static_get_Boolean_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_AutoDetectPlatformFlags_Private_Static_Void_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPlatform_Internal_Static_IPlatformAccessor_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultScriptLoader_Internal_Static_IScriptLoader_0;

		// Token: 0x020001A7 RID: 423
		[ObfuscatedName("MoonSharp.Interpreter.Platforms.PlatformAutoDetector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AAA RID: 6826 RVA: 0x00082080 File Offset: 0x00080280
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformAutoDetector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr);
				PlatformAutoDetector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, "<>9");
				PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, "<>9__28_0");
				PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, "<>9__28_1");
				PlatformAutoDetector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, 100665367);
				PlatformAutoDetector.__c.NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_0_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, 100665368);
				PlatformAutoDetector.__c.NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_1_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr, 100665369);
			}

			// Token: 0x06001AAB RID: 6827 RVA: 0x00082124 File Offset: 0x00080324
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformAutoDetector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x00082160 File Offset: 0x00080360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32304, XrefRangeEnd = 32305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Type> _AutoDetectPlatformFlags_b__28_0(Assembly a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.__c.NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_0_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001AAD RID: 6829 RVA: 0x000821B0 File Offset: 0x000803B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32305, XrefRangeEnd = 32309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AutoDetectPlatformFlags_b__28_1(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetector.__c.NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_1_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x0000A8CA File Offset: 0x00008ACA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00082200 File Offset: 0x00080400
			// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x0000A8D3 File Offset: 0x00008AD3
			public unsafe static PlatformAutoDetector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformAutoDetector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00082228 File Offset: 0x00080428
			// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x0000A8E5 File Offset: 0x00008AE5
			public unsafe static Func<Assembly, IEnumerable<Type>> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Assembly, IEnumerable<Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00082250 File Offset: 0x00080450
			// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0000A8F7 File Offset: 0x00008AF7
			public unsafe static Func<Type, bool> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetector.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_0_Internal_IEnumerable_1_Type_Assembly_0;

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeMethodInfoPtr__AutoDetectPlatformFlags_b__28_1_Internal_Boolean_Type_0;
		}
	}
}
