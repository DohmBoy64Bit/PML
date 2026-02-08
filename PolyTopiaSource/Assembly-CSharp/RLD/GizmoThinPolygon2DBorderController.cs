using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000B9 RID: 185
	public class GizmoThinPolygon2DBorderController : GizmoPolygon2DBorderController
	{
		// Token: 0x06000F75 RID: 3957 RVA: 0x0005BE88 File Offset: 0x0005A088
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoThinPolygon2DBorderController()
		{
			Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoThinPolygon2DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr);
			GizmoThinPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr, 100665489);
			GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr, 100665490);
			GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr, 100665491);
			GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr, 100665492);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0005BF08 File Offset: 0x0005A108
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoThinPolygon2DBorderController(GizmoPolygon2DBorderControllerData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoThinPolygon2DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoThinPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0005BF54 File Offset: 0x0005A154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68442, XrefRangeEnd = 68445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0005BF90 File Offset: 0x0005A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68445, XrefRangeEnd = 68448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0005BFCC File Offset: 0x0005A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68448, XrefRangeEnd = 68450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoThinPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00007C8E File Offset: 0x00005E8E
		public GizmoThinPolygon2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;
	}
}
