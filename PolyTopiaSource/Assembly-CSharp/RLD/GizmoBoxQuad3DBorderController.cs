using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000C7 RID: 199
	public class GizmoBoxQuad3DBorderController : GizmoQuad3DBorderController
	{
		// Token: 0x06001023 RID: 4131 RVA: 0x0005E138 File Offset: 0x0005C338
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoBoxQuad3DBorderController()
		{
			Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoBoxQuad3DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr);
			GizmoBoxQuad3DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoQuad3DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr, 100665551);
			GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr, 100665552);
			GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr, 100665553);
			GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr, 100665554);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0005E1B8 File Offset: 0x0005C3B8
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoBoxQuad3DBorderController(GizmoQuad3DBorderControllerData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoBoxQuad3DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBoxQuad3DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoQuad3DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0005E204 File Offset: 0x0005C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68781, XrefRangeEnd = 68799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0005E240 File Offset: 0x0005C440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68799, XrefRangeEnd = 68809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0005E28C File Offset: 0x0005C48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68809, XrefRangeEnd = 68889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxQuad3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000081F2 File Offset: 0x000063F2
		public GizmoBoxQuad3DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoQuad3DBorderControllerData_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0;
	}
}
