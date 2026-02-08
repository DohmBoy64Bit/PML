using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public class CameraSettings : Settings
	{
		// Token: 0x06001958 RID: 6488 RVA: 0x00083B14 File Offset: 0x00081D14
		// Note: this type is marked as 'beforefieldinit'.
		static CameraSettings()
		{
			Il2CppClassPointerStore<CameraSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr);
			CameraSettings.NativeFieldInfoPtr__canProcessInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "_canProcessInput");
			CameraSettings.NativeMethodInfoPtr_get_CanProcessInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100667019);
			CameraSettings.NativeMethodInfoPtr_set_CanProcessInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100667020);
			CameraSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100667021);
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00083B94 File Offset: 0x00081D94
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x00083BD0 File Offset: 0x00081DD0
		public unsafe bool CanProcessInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSettings.NativeMethodInfoPtr_get_CanProcessInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSettings.NativeMethodInfoPtr_set_CanProcessInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00083C10 File Offset: 0x00081E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74638, XrefRangeEnd = 74643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0000B294 File Offset: 0x00009494
		public CameraSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00083C4C File Offset: 0x00081E4C
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0000B29D File Offset: 0x0000949D
		public unsafe bool _canProcessInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSettings.NativeFieldInfoPtr__canProcessInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSettings.NativeFieldInfoPtr__canProcessInput)) = value;
			}
		}

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeFieldInfoPtr__canProcessInput;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_CanProcessInput_Public_get_Boolean_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_set_CanProcessInput_Public_set_Void_Boolean_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
