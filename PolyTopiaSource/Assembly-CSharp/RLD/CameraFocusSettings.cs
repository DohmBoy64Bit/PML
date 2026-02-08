using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class CameraFocusSettings : Settings
	{
		// Token: 0x0600184C RID: 6220 RVA: 0x000802C4 File Offset: 0x0007E4C4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraFocusSettings()
		{
			Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraFocusSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr);
			CameraFocusSettings.NativeFieldInfoPtr__focusMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, "_focusMode");
			CameraFocusSettings.NativeFieldInfoPtr__constantSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, "_constantSpeed");
			CameraFocusSettings.NativeFieldInfoPtr__smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, "_smoothTime");
			CameraFocusSettings.NativeFieldInfoPtr__focusDistanceAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, "_focusDistanceAdd");
			CameraFocusSettings.NativeMethodInfoPtr_get_FocusMode_Public_get_CameraFocusMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666890);
			CameraFocusSettings.NativeMethodInfoPtr_set_FocusMode_Public_set_Void_CameraFocusMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666891);
			CameraFocusSettings.NativeMethodInfoPtr_get_ConstantSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666892);
			CameraFocusSettings.NativeMethodInfoPtr_set_ConstantSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666893);
			CameraFocusSettings.NativeMethodInfoPtr_get_SmoothTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666894);
			CameraFocusSettings.NativeMethodInfoPtr_set_SmoothTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666895);
			CameraFocusSettings.NativeMethodInfoPtr_get_FocusDistanceAdd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666896);
			CameraFocusSettings.NativeMethodInfoPtr_set_FocusDistanceAdd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666897);
			CameraFocusSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr, 100666898);
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000803F8 File Offset: 0x0007E5F8
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x00080438 File Offset: 0x0007E638
		public unsafe CameraFocusMode FocusMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_get_FocusMode_Public_get_CameraFocusMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraFocusMode>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_set_FocusMode_Public_set_Void_CameraFocusMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0008047C File Offset: 0x0007E67C
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x000804B8 File Offset: 0x0007E6B8
		public unsafe float ConstantSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_get_ConstantSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_set_ConstantSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x000804F8 File Offset: 0x0007E6F8
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00080534 File Offset: 0x0007E734
		public unsafe float SmoothTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_get_SmoothTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_set_SmoothTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00080574 File Offset: 0x0007E774
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x000805B0 File Offset: 0x0007E7B0
		public unsafe float FocusDistanceAdd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_get_FocusDistanceAdd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr_set_FocusDistanceAdd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000805F0 File Offset: 0x0007E7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74404, XrefRangeEnd = 74409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraFocusSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFocusSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocusSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0000AB6A File Offset: 0x00008D6A
		public CameraFocusSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x0008062C File Offset: 0x0007E82C
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x0000AB73 File Offset: 0x00008D73
		public unsafe CameraFocusMode _focusMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__focusMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraFocusMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__focusMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0008065C File Offset: 0x0007E85C
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x0000AB92 File Offset: 0x00008D92
		public unsafe float _constantSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__constantSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__constantSpeed)) = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00080684 File Offset: 0x0007E884
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x0000ABAD File Offset: 0x00008DAD
		public unsafe float _smoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__smoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__smoothTime)) = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x000806AC File Offset: 0x0007E8AC
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		public unsafe float _focusDistanceAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__focusDistanceAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocusSettings.NativeFieldInfoPtr__focusDistanceAdd)) = value;
			}
		}

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr__focusMode;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr__constantSpeed;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr__smoothTime;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr__focusDistanceAdd;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusMode_Public_get_CameraFocusMode_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusMode_Public_set_Void_CameraFocusMode_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstantSpeed_Public_get_Single_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstantSpeed_Public_set_Void_Single_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothTime_Public_get_Single_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothTime_Public_set_Void_Single_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusDistanceAdd_Public_get_Single_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusDistanceAdd_Public_set_Void_Single_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
