using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011D RID: 285
	public class ColorTransition : global::Il2CppSystem.Object
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x00089C5C File Offset: 0x00087E5C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorTransition()
		{
			Il2CppClassPointerStore<ColorTransition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ColorTransition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr);
			ColorTransition.NativeFieldInfoPtr_TransitionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "TransitionBegin");
			ColorTransition.NativeFieldInfoPtr_TransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "TransitionEnd");
			ColorTransition.NativeFieldInfoPtr__colorRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_colorRef");
			ColorTransition.NativeFieldInfoPtr__fadeInColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_fadeInColor");
			ColorTransition.NativeFieldInfoPtr__fadeOutColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_fadeOutColor");
			ColorTransition.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_state");
			ColorTransition.NativeFieldInfoPtr__durationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_durationInSeconds");
			ColorTransition.NativeFieldInfoPtr__elapsedTimeInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_elapsedTimeInSeconds");
			ColorTransition.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "_isActive");
			ColorTransition.NativeMethodInfoPtr_get_TransitionState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667307);
			ColorTransition.NativeMethodInfoPtr_get_FadeInColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667308);
			ColorTransition.NativeMethodInfoPtr_set_FadeInColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667309);
			ColorTransition.NativeMethodInfoPtr_get_FadeOutColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667310);
			ColorTransition.NativeMethodInfoPtr_set_FadeOutColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667311);
			ColorTransition.NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667312);
			ColorTransition.NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667313);
			ColorTransition.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667314);
			ColorTransition.NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_ColorTransitionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667303);
			ColorTransition.NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_ColorTransitionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667304);
			ColorTransition.NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_ColorTransitionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667305);
			ColorTransition.NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_ColorTransitionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667306);
			ColorTransition.NativeMethodInfoPtr__ctor_Public_Void_ColorRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667315);
			ColorTransition.NativeMethodInfoPtr_BeginFadeIn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667316);
			ColorTransition.NativeMethodInfoPtr_BeginFadeOut_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667317);
			ColorTransition.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667318);
			ColorTransition.NativeMethodInfoPtr_End_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, 100667319);
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00089E94 File Offset: 0x00088094
		public unsafe ColorTransition.State TransitionState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_get_TransitionState_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00089ED0 File Offset: 0x000880D0
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x00089F10 File Offset: 0x00088110
		public unsafe Color FadeInColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_get_FadeInColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_set_FadeInColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00089F54 File Offset: 0x00088154
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x00089F94 File Offset: 0x00088194
		public unsafe Color FadeOutColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_get_FadeOutColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_set_FadeOutColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00089FD8 File Offset: 0x000881D8
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0008A014 File Offset: 0x00088214
		public unsafe float DurationInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76034, RefRangeEnd = 76036, XrefRangeStart = 76034, XrefRangeEnd = 76034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0008A054 File Offset: 0x00088254
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0008A090 File Offset: 0x00088290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76036, XrefRangeEnd = 76040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TransitionBegin(ColorTransition.ColorTransitionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_ColorTransitionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0008A0D4 File Offset: 0x000882D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76040, XrefRangeEnd = 76044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TransitionBegin(ColorTransition.ColorTransitionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_ColorTransitionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0008A118 File Offset: 0x00088318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76044, XrefRangeEnd = 76048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TransitionEnd(ColorTransition.ColorTransitionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_ColorTransitionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0008A15C File Offset: 0x0008835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76048, XrefRangeEnd = 76052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TransitionEnd(ColorTransition.ColorTransitionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_ColorTransitionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0008A1A0 File Offset: 0x000883A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76054, RefRangeEnd = 76055, XrefRangeStart = 76052, XrefRangeEnd = 76054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorTransition(ColorRef colorRef)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr__ctor_Public_Void_ColorRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0008A1EC File Offset: 0x000883EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76055, RefRangeEnd = 76056, XrefRangeStart = 76055, XrefRangeEnd = 76055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFadeIn(bool startFromCurrentColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startFromCurrentColor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_BeginFadeIn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0008A22C File Offset: 0x0008842C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76056, RefRangeEnd = 76057, XrefRangeStart = 76056, XrefRangeEnd = 76056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFadeOut(bool startFromCurrentColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startFromCurrentColor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_BeginFadeOut_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0008A26C File Offset: 0x0008846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76059, RefRangeEnd = 76060, XrefRangeStart = 76057, XrefRangeEnd = 76059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float elapsedTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsedTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0008A2AC File Offset: 0x000884AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76060, XrefRangeEnd = 76061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.NativeMethodInfoPtr_End_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000BBBE File Offset: 0x00009DBE
		public ColorTransition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0008A2E0 File Offset: 0x000884E0
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000BBC7 File Offset: 0x00009DC7
		public unsafe ColorTransition.ColorTransitionBeginHandler TransitionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr_TransitionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorTransition.ColorTransitionBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr_TransitionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0008A310 File Offset: 0x00088510
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000BBE6 File Offset: 0x00009DE6
		public unsafe ColorTransition.ColorTransitionEndHandler TransitionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr_TransitionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorTransition.ColorTransitionEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr_TransitionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0008A340 File Offset: 0x00088540
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000BC05 File Offset: 0x00009E05
		public unsafe ColorRef _colorRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__colorRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__colorRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0008A370 File Offset: 0x00088570
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000BC24 File Offset: 0x00009E24
		public unsafe Color _fadeInColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__fadeInColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__fadeInColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0008A3A0 File Offset: 0x000885A0
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000BC43 File Offset: 0x00009E43
		public unsafe Color _fadeOutColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__fadeOutColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__fadeOutColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0008A3D0 File Offset: 0x000885D0
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000BC62 File Offset: 0x00009E62
		public unsafe ColorTransition.State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0008A3F8 File Offset: 0x000885F8
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000BC7D File Offset: 0x00009E7D
		public unsafe float _durationInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__durationInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__durationInSeconds)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0008A420 File Offset: 0x00088620
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000BC98 File Offset: 0x00009E98
		public unsafe float _elapsedTimeInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__elapsedTimeInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__elapsedTimeInSeconds)) = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0008A448 File Offset: 0x00088648
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000BCB3 File Offset: 0x00009EB3
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTransition.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_TransitionBegin;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_TransitionEnd;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeFieldInfoPtr__colorRef;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeFieldInfoPtr__fadeInColor;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr__fadeOutColor;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeFieldInfoPtr__durationInSeconds;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeFieldInfoPtr__elapsedTimeInSeconds;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_get_TransitionState_Public_get_State_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_get_FadeInColor_Public_get_Color_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_set_FadeInColor_Public_set_Void_Color_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_get_FadeOutColor_Public_get_Color_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_set_FadeOutColor_Public_set_Void_Color_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_ColorTransitionBeginHandler_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_ColorTransitionBeginHandler_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_ColorTransitionEndHandler_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_ColorTransitionEndHandler_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorRef_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_BeginFadeIn_Public_Void_Boolean_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_BeginFadeOut_Public_Void_Boolean_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_End_Private_Void_0;

		// Token: 0x0200038A RID: 906
		public enum State
		{
			// Token: 0x04003A3C RID: 14908
			CompleteFadeIn,
			// Token: 0x04003A3D RID: 14909
			CompleteFadeOut,
			// Token: 0x04003A3E RID: 14910
			FadingIn,
			// Token: 0x04003A3F RID: 14911
			FadingOut,
			// Token: 0x04003A40 RID: 14912
			Ready
		}

		// Token: 0x0200038B RID: 907
		public sealed class ColorTransitionBeginHandler : MulticastDelegate
		{
			// Token: 0x06004B08 RID: 19208 RVA: 0x00149584 File Offset: 0x00147784
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTransitionBeginHandler()
			{
				Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "ColorTransitionBeginHandler");
				ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr, 100667320);
				ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr, 100667321);
				ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr, 100667322);
				ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr, 100667323);
			}

			// Token: 0x06004B09 RID: 19209 RVA: 0x001495F8 File Offset: 0x001477F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTransitionBeginHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTransition.ColorTransitionBeginHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B0A RID: 19210 RVA: 0x00149654 File Offset: 0x00147854
			[CallerCount(0)]
			public unsafe void Invoke(ColorTransition colorTransition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTransition);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B0B RID: 19211 RVA: 0x00149698 File Offset: 0x00147898
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTransition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B0C RID: 19212 RVA: 0x0014970C File Offset: 0x0014790C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B0D RID: 19213 RVA: 0x0001C166 File Offset: 0x0001A366
			public ColorTransitionBeginHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B0E RID: 19214 RVA: 0x0001C16F File Offset: 0x0001A36F
			public static implicit operator ColorTransition.ColorTransitionBeginHandler(Action<ColorTransition> A_0)
			{
				return DelegateSupport.ConvertDelegate<ColorTransition.ColorTransitionBeginHandler>(A_0);
			}

			// Token: 0x06004B0F RID: 19215 RVA: 0x0001C177 File Offset: 0x0001A377
			public static ColorTransition.ColorTransitionBeginHandler operator +(ColorTransition.ColorTransitionBeginHandler A_0, ColorTransition.ColorTransitionBeginHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ColorTransition.ColorTransitionBeginHandler>();
			}

			// Token: 0x06004B10 RID: 19216 RVA: 0x0001C185 File Offset: 0x0001A385
			public static ColorTransition.ColorTransitionBeginHandler operator -(ColorTransition.ColorTransitionBeginHandler A_0, ColorTransition.ColorTransitionBeginHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ColorTransition.ColorTransitionBeginHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A41 RID: 14913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A42 RID: 14914
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0;

			// Token: 0x04003A43 RID: 14915
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0;

			// Token: 0x04003A44 RID: 14916
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200038C RID: 908
		public sealed class ColorTransitionEndHandler : MulticastDelegate
		{
			// Token: 0x06004B11 RID: 19217 RVA: 0x00149750 File Offset: 0x00147950
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTransitionEndHandler()
			{
				Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTransition>.NativeClassPtr, "ColorTransitionEndHandler");
				ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr, 100667324);
				ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr, 100667325);
				ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr, 100667326);
				ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr, 100667327);
			}

			// Token: 0x06004B12 RID: 19218 RVA: 0x001497C4 File Offset: 0x001479C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTransitionEndHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTransition.ColorTransitionEndHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B13 RID: 19219 RVA: 0x00149820 File Offset: 0x00147A20
			[CallerCount(0)]
			public unsafe void Invoke(ColorTransition colorTransition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTransition);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B14 RID: 19220 RVA: 0x00149864 File Offset: 0x00147A64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTransition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B15 RID: 19221 RVA: 0x001498D8 File Offset: 0x00147AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTransition.ColorTransitionEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B16 RID: 19222 RVA: 0x0001C196 File Offset: 0x0001A396
			public ColorTransitionEndHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B17 RID: 19223 RVA: 0x0001C19F File Offset: 0x0001A39F
			public static implicit operator ColorTransition.ColorTransitionEndHandler(Action<ColorTransition> A_0)
			{
				return DelegateSupport.ConvertDelegate<ColorTransition.ColorTransitionEndHandler>(A_0);
			}

			// Token: 0x06004B18 RID: 19224 RVA: 0x0001C1A7 File Offset: 0x0001A3A7
			public static ColorTransition.ColorTransitionEndHandler operator +(ColorTransition.ColorTransitionEndHandler A_0, ColorTransition.ColorTransitionEndHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ColorTransition.ColorTransitionEndHandler>();
			}

			// Token: 0x06004B19 RID: 19225 RVA: 0x0001C1B5 File Offset: 0x0001A3B5
			public static ColorTransition.ColorTransitionEndHandler operator -(ColorTransition.ColorTransitionEndHandler A_0, ColorTransition.ColorTransitionEndHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ColorTransition.ColorTransitionEndHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A45 RID: 14917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A46 RID: 14918
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ColorTransition_0;

			// Token: 0x04003A47 RID: 14919
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ColorTransition_AsyncCallback_Object_0;

			// Token: 0x04003A48 RID: 14920
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
