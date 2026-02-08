using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028F RID: 655
	public class AnimationInfo : Object
	{
		// Token: 0x06003440 RID: 13376 RVA: 0x000EE644 File Offset: 0x000EC844
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationInfo()
		{
			Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "AnimationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr);
			AnimationInfo.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, "<Name>k__BackingField");
			AnimationInfo.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, "<Path>k__BackingField");
			AnimationInfo.NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, "<Length>k__BackingField");
			AnimationInfo.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, "<IsPlaying>k__BackingField");
			AnimationInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671199);
			AnimationInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671200);
			AnimationInfo.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671201);
			AnimationInfo.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671202);
			AnimationInfo.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671203);
			AnimationInfo.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671204);
			AnimationInfo.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671205);
			AnimationInfo.NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671206);
			AnimationInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr, 100671207);
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x000EE778 File Offset: 0x000EC978
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x000EE7B0 File Offset: 0x000EC9B0
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x000EE7F4 File Offset: 0x000EC9F4
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x000EE82C File Offset: 0x000ECA2C
		public unsafe string Path
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x000EE870 File Offset: 0x000ECA70
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x000EE8AC File Offset: 0x000ECAAC
		public unsafe float Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x000EE8EC File Offset: 0x000ECAEC
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x000EE928 File Offset: 0x000ECB28
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000EE968 File Offset: 0x000ECB68
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00014967 File Offset: 0x00012B67
		public AnimationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00014970 File Offset: 0x00012B70
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x000EE9CC File Offset: 0x000ECBCC
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x0001498F File Offset: 0x00012B8F
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x000EE9F4 File Offset: 0x000ECBF4
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x000149AE File Offset: 0x00012BAE
		public unsafe float _Length_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Length_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__Length_k__BackingField)) = value;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x000EEA1C File Offset: 0x000ECC1C
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x000149C9 File Offset: 0x00012BC9
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationInfo.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeFieldInfoPtr__Length_k__BackingField;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Boolean_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
