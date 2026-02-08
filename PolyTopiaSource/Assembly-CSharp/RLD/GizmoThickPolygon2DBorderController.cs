using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000B8 RID: 184
	public class GizmoThickPolygon2DBorderController : GizmoPolygon2DBorderController
	{
		// Token: 0x06000F6F RID: 3951 RVA: 0x0005BD08 File Offset: 0x00059F08
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoThickPolygon2DBorderController()
		{
			Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoThickPolygon2DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr);
			GizmoThickPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr, 100665485);
			GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr, 100665486);
			GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr, 100665487);
			GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr, 100665488);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0005BD88 File Offset: 0x00059F88
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoThickPolygon2DBorderController(GizmoPolygon2DBorderControllerData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoThickPolygon2DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoThickPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0005BDD4 File Offset: 0x00059FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68432, XrefRangeEnd = 68435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0005BE10 File Offset: 0x0005A010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68435, XrefRangeEnd = 68438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0005BE4C File Offset: 0x0005A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68438, XrefRangeEnd = 68442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThickPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00007C85 File Offset: 0x00005E85
		public GizmoThickPolygon2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;
	}
}
