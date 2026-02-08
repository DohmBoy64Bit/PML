using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000313 RID: 787
	public class TweenServiceProxy : global::Il2CppSystem.Object
	{
		// Token: 0x060043CC RID: 17356 RVA: 0x00130530 File Offset: 0x0012E730
		// Note: this type is marked as 'beforefieldinit'.
		static TweenServiceProxy()
		{
			Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "TweenServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr);
			TweenServiceProxy.NativeFieldInfoPtr_tweenService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, "tweenService");
			TweenServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_TweenService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674035);
			TweenServiceProxy.NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674036);
			TweenServiceProxy.NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674037);
			TweenServiceProxy.NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674038);
			TweenServiceProxy.NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674039);
			TweenServiceProxy.NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674040);
			TweenServiceProxy.NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674041);
			TweenServiceProxy.NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674042);
			TweenServiceProxy.NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674043);
			TweenServiceProxy.NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674044);
			TweenServiceProxy.NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674045);
			TweenServiceProxy.NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674046);
			TweenServiceProxy.NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr, 100674047);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00130678 File Offset: 0x0012E878
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenServiceProxy(TweenService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_TweenService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x001306C4 File Offset: 0x0012E8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129384, XrefRangeEnd = 129385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x0013074C File Offset: 0x0012E94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129385, XrefRangeEnd = 129386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x001307D4 File Offset: 0x0012E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129386, XrefRangeEnd = 129387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0013085C File Offset: 0x0012EA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129387, XrefRangeEnd = 129388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x001308F0 File Offset: 0x0012EAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129388, XrefRangeEnd = 129389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x0013098C File Offset: 0x0012EB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129389, XrefRangeEnd = 129390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00130A28 File Offset: 0x0012EC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129390, XrefRangeEnd = 129391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00130AC4 File Offset: 0x0012ECC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00130B04 File Offset: 0x0012ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelAll(bool callOnComplete = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callOnComplete;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00130B38 File Offset: 0x0012ED38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00130B6C File Offset: 0x0012ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resume(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00130BA0 File Offset: 0x0012EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPaused(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenServiceProxy.NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x00018F4B File Offset: 0x0001714B
		public TweenServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x00130BE0 File Offset: 0x0012EDE0
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x00018F54 File Offset: 0x00017154
		public unsafe TweenService tweenService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenServiceProxy.NativeFieldInfoPtr_tweenService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenServiceProxy.NativeFieldInfoPtr_tweenService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeFieldInfoPtr_tweenService;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TweenService_0;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeMethodInfoPtr_TweenPosition_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeMethodInfoPtr_TweenRotation_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeMethodInfoPtr_TweenSize_Public_Static_Int32_DynamicInstance_Vector3_Single_LeanTweenType_DynValue_0;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeMethodInfoPtr_TweenNumber_Public_Static_Int32_Single_Single_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr_TweenColor_Public_Static_Int32_Color_Color_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr_TweenVector3_Public_Static_Int32_Vector3_Vector3_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeMethodInfoPtr_TweenVector2_Public_Static_Int32_Vector2_Vector2_Single_DynValue_LeanTweenType_DynValue_0;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeMethodInfoPtr_CancelAll_Public_Static_Void_Boolean_0;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_Int32_0;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_Int32_0;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Static_Boolean_Int32_0;
	}
}
