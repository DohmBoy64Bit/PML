using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000C3 RID: 195
	public class GizmoCylindricalTorusCircle3DBorderController : GizmoCircle3DBorderController
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x0005DA60 File Offset: 0x0005BC60
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCylindricalTorusCircle3DBorderController()
		{
			Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCylindricalTorusCircle3DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr);
			GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle3DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr, 100665534);
			GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr, 100665535);
			GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr, 100665536);
			GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr, 100665537);
			GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_GetTorusCoreRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr, 100665538);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0005DAF4 File Offset: 0x0005BCF4
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCylindricalTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCylindricalTorusCircle3DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle3DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0005DB40 File Offset: 0x0005BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68730, XrefRangeEnd = 68734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0005DB7C File Offset: 0x0005BD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68734, XrefRangeEnd = 68739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0005DBC8 File Offset: 0x0005BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68739, XrefRangeEnd = 68749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0005DC14 File Offset: 0x0005BE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68751, RefRangeEnd = 68753, XrefRangeStart = 68749, XrefRangeEnd = 68751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTorusCoreRadius(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCylindricalTorusCircle3DBorderController.NativeMethodInfoPtr_GetTorusCoreRadius_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000081CE File Offset: 0x000063CE
		public GizmoCylindricalTorusCircle3DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoCircle3DBorderControllerData_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_GetTorusCoreRadius_Public_Single_Single_0;
	}
}
