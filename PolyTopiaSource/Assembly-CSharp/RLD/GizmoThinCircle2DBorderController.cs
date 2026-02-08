using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000B3 RID: 179
	public class GizmoThinCircle2DBorderController : GizmoCircle2DBorderController
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x0005B018 File Offset: 0x00059218
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoThinCircle2DBorderController()
		{
			Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoThinCircle2DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr);
			GizmoThinCircle2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle2DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr, 100665465);
			GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr, 100665466);
			GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr, 100665467);
			GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr, 100665468);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0005B098 File Offset: 0x00059298
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoThinCircle2DBorderController(GizmoCircle2DBorderControllerData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoThinCircle2DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoThinCircle2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle2DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0005B0E4 File Offset: 0x000592E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68307, XrefRangeEnd = 68309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0005B120 File Offset: 0x00059320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68309, XrefRangeEnd = 68312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0005B15C File Offset: 0x0005935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68312, XrefRangeEnd = 68314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinCircle2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000079E5 File Offset: 0x00005BE5
		public GizmoThinCircle2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle2DBorderControllerData_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;
	}
}
