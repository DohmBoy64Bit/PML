using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CD RID: 717
	public class TweenService : global::Il2CppSystem.Object
	{
		// Token: 0x06003F70 RID: 16240 RVA: 0x0011CA40 File Offset: 0x0011AC40
		// Note: this type is marked as 'beforefieldinit'.
		static TweenService()
		{
			Il2CppClassPointerStore<TweenService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "TweenService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService>.NativeClassPtr);
			TweenService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673193);
			TweenService.NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673181);
			TweenService.NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673182);
			TweenService.NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673183);
			TweenService.NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673184);
			TweenService.NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673185);
			TweenService.NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673186);
			TweenService.NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673187);
			TweenService.NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673188);
			TweenService.NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673189);
			TweenService.NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673190);
			TweenService.NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673191);
			TweenService.NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService>.NativeClassPtr, 100673192);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0011CB74 File Offset: 0x0011AD74
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0011CBB0 File Offset: 0x0011ADB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128197, RefRangeEnd = 128198, XrefRangeStart = 128160, XrefRangeEnd = 128197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x0011CC38 File Offset: 0x0011AE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128235, RefRangeEnd = 128236, XrefRangeStart = 128198, XrefRangeEnd = 128235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0011CCC0 File Offset: 0x0011AEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128273, RefRangeEnd = 128274, XrefRangeStart = 128236, XrefRangeEnd = 128273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0011CD48 File Offset: 0x0011AF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128310, RefRangeEnd = 128311, XrefRangeStart = 128274, XrefRangeEnd = 128310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0011CDDC File Offset: 0x0011AFDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128350, RefRangeEnd = 128351, XrefRangeStart = 128311, XrefRangeEnd = 128350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x0011CE78 File Offset: 0x0011B078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128390, RefRangeEnd = 128391, XrefRangeStart = 128351, XrefRangeEnd = 128390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x0011CF14 File Offset: 0x0011B114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128430, RefRangeEnd = 128431, XrefRangeStart = 128391, XrefRangeEnd = 128430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x0011CFB0 File Offset: 0x0011B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128431, XrefRangeEnd = 128435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cancel(int id, bool callOnComplete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callOnComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x0011CFF0 File Offset: 0x0011B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128435, XrefRangeEnd = 128439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelAll(bool callOnComplete = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callOnComplete;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x0011D024 File Offset: 0x0011B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128439, XrefRangeEnd = 128443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x0011D058 File Offset: 0x0011B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128443, XrefRangeEnd = 128447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x0011D08C File Offset: 0x0011B28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128447, XrefRangeEnd = 128451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPaused(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00018459 File Offset: 0x00016659
		public TweenService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0;

		// Token: 0x02000417 RID: 1047
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050BB RID: 20667 RVA: 0x0015A3E0 File Offset: 0x001585E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr);
				TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_inst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr, "inst");
				TweenService.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr, 100673194);
				TweenService.__c__DisplayClass0_0.NativeMethodInfoPtr__TweenPosition_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr, 100673195);
			}

			// Token: 0x060050BC RID: 20668 RVA: 0x0015A470 File Offset: 0x00158670
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050BD RID: 20669 RVA: 0x0015A4AC File Offset: 0x001586AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128078, XrefRangeEnd = 128087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenPosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass0_0.NativeMethodInfoPtr__TweenPosition_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050BE RID: 20670 RVA: 0x0001EDF6 File Offset: 0x0001CFF6
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B3A RID: 6970
			// (get) Token: 0x060050BF RID: 20671 RVA: 0x0015A4E0 File Offset: 0x001586E0
			// (set) Token: 0x060050C0 RID: 20672 RVA: 0x0001EDFF File Offset: 0x0001CFFF
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3B RID: 6971
			// (get) Token: 0x060050C1 RID: 20673 RVA: 0x0015A510 File Offset: 0x00158710
			// (set) Token: 0x060050C2 RID: 20674 RVA: 0x0001EE1E File Offset: 0x0001D01E
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3C RID: 6972
			// (get) Token: 0x060050C3 RID: 20675 RVA: 0x0015A540 File Offset: 0x00158740
			// (set) Token: 0x060050C4 RID: 20676 RVA: 0x0001EE3D File Offset: 0x0001D03D
			public unsafe DynamicInstance inst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_inst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass0_0.NativeFieldInfoPtr_inst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E28 RID: 15912
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E29 RID: 15913
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E2A RID: 15914
			private static readonly IntPtr NativeFieldInfoPtr_inst;

			// Token: 0x04003E2B RID: 15915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E2C RID: 15916
			private static readonly IntPtr NativeMethodInfoPtr__TweenPosition_b__0_Internal_Void_0;
		}

		// Token: 0x02000418 RID: 1048
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050C5 RID: 20677 RVA: 0x0015A570 File Offset: 0x00158770
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr);
				TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_inst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr, "inst");
				TweenService.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr, 100673196);
				TweenService.__c__DisplayClass1_0.NativeMethodInfoPtr__TweenRotation_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr, 100673197);
			}

			// Token: 0x060050C6 RID: 20678 RVA: 0x0015A600 File Offset: 0x00158800
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C7 RID: 20679 RVA: 0x0015A63C File Offset: 0x0015883C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128087, XrefRangeEnd = 128096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass1_0.NativeMethodInfoPtr__TweenRotation_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C8 RID: 20680 RVA: 0x0001EE5C File Offset: 0x0001D05C
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B3D RID: 6973
			// (get) Token: 0x060050C9 RID: 20681 RVA: 0x0015A670 File Offset: 0x00158870
			// (set) Token: 0x060050CA RID: 20682 RVA: 0x0001EE65 File Offset: 0x0001D065
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3E RID: 6974
			// (get) Token: 0x060050CB RID: 20683 RVA: 0x0015A6A0 File Offset: 0x001588A0
			// (set) Token: 0x060050CC RID: 20684 RVA: 0x0001EE84 File Offset: 0x0001D084
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3F RID: 6975
			// (get) Token: 0x060050CD RID: 20685 RVA: 0x0015A6D0 File Offset: 0x001588D0
			// (set) Token: 0x060050CE RID: 20686 RVA: 0x0001EEA3 File Offset: 0x0001D0A3
			public unsafe DynamicInstance inst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_inst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass1_0.NativeFieldInfoPtr_inst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E2D RID: 15917
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E2E RID: 15918
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E2F RID: 15919
			private static readonly IntPtr NativeFieldInfoPtr_inst;

			// Token: 0x04003E30 RID: 15920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E31 RID: 15921
			private static readonly IntPtr NativeMethodInfoPtr__TweenRotation_b__0_Internal_Void_0;
		}

		// Token: 0x02000419 RID: 1049
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050CF RID: 20687 RVA: 0x0015A700 File Offset: 0x00158900
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr);
				TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_inst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr, "inst");
				TweenService.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr, 100673198);
				TweenService.__c__DisplayClass2_0.NativeMethodInfoPtr__TweenSize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr, 100673199);
			}

			// Token: 0x060050D0 RID: 20688 RVA: 0x0015A790 File Offset: 0x00158990
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050D1 RID: 20689 RVA: 0x0015A7CC File Offset: 0x001589CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128096, XrefRangeEnd = 128105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass2_0.NativeMethodInfoPtr__TweenSize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050D2 RID: 20690 RVA: 0x0001EEC2 File Offset: 0x0001D0C2
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B40 RID: 6976
			// (get) Token: 0x060050D3 RID: 20691 RVA: 0x0015A800 File Offset: 0x00158A00
			// (set) Token: 0x060050D4 RID: 20692 RVA: 0x0001EECB File Offset: 0x0001D0CB
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B41 RID: 6977
			// (get) Token: 0x060050D5 RID: 20693 RVA: 0x0015A830 File Offset: 0x00158A30
			// (set) Token: 0x060050D6 RID: 20694 RVA: 0x0001EEEA File Offset: 0x0001D0EA
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B42 RID: 6978
			// (get) Token: 0x060050D7 RID: 20695 RVA: 0x0015A860 File Offset: 0x00158A60
			// (set) Token: 0x060050D8 RID: 20696 RVA: 0x0001EF09 File Offset: 0x0001D109
			public unsafe DynamicInstance inst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_inst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass2_0.NativeFieldInfoPtr_inst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E32 RID: 15922
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E33 RID: 15923
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E34 RID: 15924
			private static readonly IntPtr NativeFieldInfoPtr_inst;

			// Token: 0x04003E35 RID: 15925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E36 RID: 15926
			private static readonly IntPtr NativeMethodInfoPtr__TweenSize_b__0_Internal_Void_0;
		}

		// Token: 0x0200041A RID: 1050
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050D9 RID: 20697 RVA: 0x0015A890 File Offset: 0x00158A90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr);
				TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, 100673200);
				TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, 100673201);
				TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr__TweenNumber_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr, 100673202);
			}

			// Token: 0x060050DA RID: 20698 RVA: 0x0015A934 File Offset: 0x00158B34
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DB RID: 20699 RVA: 0x0015A970 File Offset: 0x00158B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128105, XrefRangeEnd = 128113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref val;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050DC RID: 20700 RVA: 0x0015A9B0 File Offset: 0x00158BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128113, XrefRangeEnd = 128118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenNumber_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass3_0.NativeMethodInfoPtr__TweenNumber_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DD RID: 20701 RVA: 0x0001EF28 File Offset: 0x0001D128
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B43 RID: 6979
			// (get) Token: 0x060050DE RID: 20702 RVA: 0x0015A9E4 File Offset: 0x00158BE4
			// (set) Token: 0x060050DF RID: 20703 RVA: 0x0001EF31 File Offset: 0x0001D131
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B44 RID: 6980
			// (get) Token: 0x060050E0 RID: 20704 RVA: 0x0015AA14 File Offset: 0x00158C14
			// (set) Token: 0x060050E1 RID: 20705 RVA: 0x0001EF50 File Offset: 0x0001D150
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B45 RID: 6981
			// (get) Token: 0x060050E2 RID: 20706 RVA: 0x0015AA44 File Offset: 0x00158C44
			// (set) Token: 0x060050E3 RID: 20707 RVA: 0x0001EF6F File Offset: 0x0001D16F
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass3_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E37 RID: 15927
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E38 RID: 15928
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003E39 RID: 15929
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E3A RID: 15930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E3B RID: 15931
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

			// Token: 0x04003E3C RID: 15932
			private static readonly IntPtr NativeMethodInfoPtr__TweenNumber_b__1_Internal_Void_0;
		}

		// Token: 0x0200041B RID: 1051
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050E4 RID: 20708 RVA: 0x0015AA74 File Offset: 0x00158C74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr);
				TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, "callback");
				TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, 100673203);
				TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_Color_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, 100673204);
				TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr__TweenColor_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr, 100673205);
			}

			// Token: 0x060050E5 RID: 20709 RVA: 0x0015AB18 File Offset: 0x00158D18
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050E6 RID: 20710 RVA: 0x0015AB54 File Offset: 0x00158D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128118, XrefRangeEnd = 128127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Color_PDM_0(Color val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_Color_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050E7 RID: 20711 RVA: 0x0015AB98 File Offset: 0x00158D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128127, XrefRangeEnd = 128132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenColor_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass4_0.NativeMethodInfoPtr__TweenColor_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050E8 RID: 20712 RVA: 0x0001EF8E File Offset: 0x0001D18E
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B46 RID: 6982
			// (get) Token: 0x060050E9 RID: 20713 RVA: 0x0015ABCC File Offset: 0x00158DCC
			// (set) Token: 0x060050EA RID: 20714 RVA: 0x0001EF97 File Offset: 0x0001D197
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B47 RID: 6983
			// (get) Token: 0x060050EB RID: 20715 RVA: 0x0015ABFC File Offset: 0x00158DFC
			// (set) Token: 0x060050EC RID: 20716 RVA: 0x0001EFB6 File Offset: 0x0001D1B6
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B48 RID: 6984
			// (get) Token: 0x060050ED RID: 20717 RVA: 0x0015AC2C File Offset: 0x00158E2C
			// (set) Token: 0x060050EE RID: 20718 RVA: 0x0001EFD5 File Offset: 0x0001D1D5
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass4_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E3D RID: 15933
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E3E RID: 15934
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003E3F RID: 15935
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E40 RID: 15936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E41 RID: 15937
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Color_PDM_0;

			// Token: 0x04003E42 RID: 15938
			private static readonly IntPtr NativeMethodInfoPtr__TweenColor_b__1_Internal_Void_0;
		}

		// Token: 0x0200041C RID: 1052
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050EF RID: 20719 RVA: 0x0015AC5C File Offset: 0x00158E5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr);
				TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, 100673206);
				TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__TweenVector3_b__0_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, 100673207);
				TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__TweenVector3_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr, 100673208);
			}

			// Token: 0x060050F0 RID: 20720 RVA: 0x0015AD00 File Offset: 0x00158F00
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050F1 RID: 20721 RVA: 0x0015AD3C File Offset: 0x00158F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128132, XrefRangeEnd = 128141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenVector3_b__0(Vector3 val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__TweenVector3_b__0_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050F2 RID: 20722 RVA: 0x0015AD80 File Offset: 0x00158F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128141, XrefRangeEnd = 128146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenVector3_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass5_0.NativeMethodInfoPtr__TweenVector3_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050F3 RID: 20723 RVA: 0x0001EFF4 File Offset: 0x0001D1F4
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B49 RID: 6985
			// (get) Token: 0x060050F4 RID: 20724 RVA: 0x0015ADB4 File Offset: 0x00158FB4
			// (set) Token: 0x060050F5 RID: 20725 RVA: 0x0001EFFD File Offset: 0x0001D1FD
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4A RID: 6986
			// (get) Token: 0x060050F6 RID: 20726 RVA: 0x0015ADE4 File Offset: 0x00158FE4
			// (set) Token: 0x060050F7 RID: 20727 RVA: 0x0001F01C File Offset: 0x0001D21C
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4B RID: 6987
			// (get) Token: 0x060050F8 RID: 20728 RVA: 0x0015AE14 File Offset: 0x00159014
			// (set) Token: 0x060050F9 RID: 20729 RVA: 0x0001F03B File Offset: 0x0001D23B
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass5_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E43 RID: 15939
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E44 RID: 15940
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003E45 RID: 15941
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E46 RID: 15942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E47 RID: 15943
			private static readonly IntPtr NativeMethodInfoPtr__TweenVector3_b__0_Internal_Void_Vector3_0;

			// Token: 0x04003E48 RID: 15944
			private static readonly IntPtr NativeMethodInfoPtr__TweenVector3_b__1_Internal_Void_0;
		}

		// Token: 0x0200041D RID: 1053
		[ObfuscatedName("Polytoria.Datamodel.Services.TweenService+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060050FA RID: 20730 RVA: 0x0015AE44 File Offset: 0x00159044
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenService>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr);
				TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, "ss");
				TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, "callback");
				TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, "callOnComplete");
				TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, 100673209);
				TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__TweenVector2_b__0_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, 100673210);
				TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__TweenVector2_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr, 100673211);
			}

			// Token: 0x060050FB RID: 20731 RVA: 0x0015AEE8 File Offset: 0x001590E8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenService.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FC RID: 20732 RVA: 0x0015AF24 File Offset: 0x00159124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128146, XrefRangeEnd = 128155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenVector2_b__0(Vector2 val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__TweenVector2_b__0_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050FD RID: 20733 RVA: 0x0015AF68 File Offset: 0x00159168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128155, XrefRangeEnd = 128160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TweenVector2_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenService.__c__DisplayClass6_0.NativeMethodInfoPtr__TweenVector2_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FE RID: 20734 RVA: 0x0001F05A File Offset: 0x0001D25A
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B4C RID: 6988
			// (get) Token: 0x060050FF RID: 20735 RVA: 0x0015AF9C File Offset: 0x0015919C
			// (set) Token: 0x06005100 RID: 20736 RVA: 0x0001F063 File Offset: 0x0001D263
			public unsafe ScriptService ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_ss);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_ss), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4D RID: 6989
			// (get) Token: 0x06005101 RID: 20737 RVA: 0x0015AFCC File Offset: 0x001591CC
			// (set) Token: 0x06005102 RID: 20738 RVA: 0x0001F082 File Offset: 0x0001D282
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4E RID: 6990
			// (get) Token: 0x06005103 RID: 20739 RVA: 0x0015AFFC File Offset: 0x001591FC
			// (set) Token: 0x06005104 RID: 20740 RVA: 0x0001F0A1 File Offset: 0x0001D2A1
			public unsafe DynValue callOnComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callOnComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenService.__c__DisplayClass6_0.NativeFieldInfoPtr_callOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E49 RID: 15945
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04003E4A RID: 15946
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003E4B RID: 15947
			private static readonly IntPtr NativeFieldInfoPtr_callOnComplete;

			// Token: 0x04003E4C RID: 15948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E4D RID: 15949
			private static readonly IntPtr NativeMethodInfoPtr__TweenVector2_b__0_Internal_Void_Vector2_0;

			// Token: 0x04003E4E RID: 15950
			private static readonly IntPtr NativeMethodInfoPtr__TweenVector2_b__1_Internal_Void_0;
		}
	}
}
