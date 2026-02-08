using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x02000190 RID: 400
	[Serializable]
	public class ObjectKeyRotationSettings : Settings
	{
		// Token: 0x06001F1B RID: 7963 RVA: 0x0009D77C File Offset: 0x0009B97C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectKeyRotationSettings()
		{
			Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectKeyRotationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr);
			ObjectKeyRotationSettings.NativeFieldInfoPtr__xRotationStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, "_xRotationStep");
			ObjectKeyRotationSettings.NativeFieldInfoPtr__yRotationStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, "_yRotationStep");
			ObjectKeyRotationSettings.NativeFieldInfoPtr__zRotationStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, "_zRotationStep");
			ObjectKeyRotationSettings.NativeMethodInfoPtr_get_XRotationStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668034);
			ObjectKeyRotationSettings.NativeMethodInfoPtr_set_XRotationStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668035);
			ObjectKeyRotationSettings.NativeMethodInfoPtr_get_YRotationStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668036);
			ObjectKeyRotationSettings.NativeMethodInfoPtr_set_YRotationStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668037);
			ObjectKeyRotationSettings.NativeMethodInfoPtr_get_ZRotationStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668038);
			ObjectKeyRotationSettings.NativeMethodInfoPtr_set_ZRotationStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668039);
			ObjectKeyRotationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr, 100668040);
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0009D874 File Offset: 0x0009BA74
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x0009D8B0 File Offset: 0x0009BAB0
		public unsafe float XRotationStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_get_XRotationStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65070, XrefRangeStart = 65039, XrefRangeEnd = 65070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_set_XRotationStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0009D8F0 File Offset: 0x0009BAF0
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x0009D92C File Offset: 0x0009BB2C
		public unsafe float YRotationStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_get_YRotationStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 65070, RefRangeEnd = 65083, XrefRangeStart = 65070, XrefRangeEnd = 65083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_set_YRotationStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0009D96C File Offset: 0x0009BB6C
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0009D9A8 File Offset: 0x0009BBA8
		public unsafe float ZRotationStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_get_ZRotationStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 65083, RefRangeEnd = 65089, XrefRangeStart = 65083, XrefRangeEnd = 65089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr_set_ZRotationStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0009D9E8 File Offset: 0x0009BBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83136, RefRangeEnd = 83138, XrefRangeStart = 83135, XrefRangeEnd = 83136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectKeyRotationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectKeyRotationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectKeyRotationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0000CADF File Offset: 0x0000ACDF
		public ObjectKeyRotationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0009DA24 File Offset: 0x0009BC24
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		public unsafe float _xRotationStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__xRotationStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__xRotationStep)) = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0009DA4C File Offset: 0x0009BC4C
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0000CB03 File Offset: 0x0000AD03
		public unsafe float _yRotationStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__yRotationStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__yRotationStep)) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0009DA74 File Offset: 0x0009BC74
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000CB1E File Offset: 0x0000AD1E
		public unsafe float _zRotationStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__zRotationStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectKeyRotationSettings.NativeFieldInfoPtr__zRotationStep)) = value;
			}
		}

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr__xRotationStep;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr__yRotationStep;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr__zRotationStep;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_get_XRotationStep_Public_get_Single_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_set_XRotationStep_Public_set_Void_Single_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_get_YRotationStep_Public_get_Single_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_set_YRotationStep_Public_set_Void_Single_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_get_ZRotationStep_Public_get_Single_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_set_ZRotationStep_Public_set_Void_Single_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
