using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x02000084 RID: 132
	public class GizmoBoxLineSlider2DController : GizmoLineSlider2DController
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00048494 File Offset: 0x00046694
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoBoxLineSlider2DController()
		{
			Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoBoxLineSlider2DController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr);
			GizmoBoxLineSlider2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoLineSlider2DControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr, 100664807);
			GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr, 100664808);
			GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr, 100664809);
			GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr, 100664810);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00048514 File Offset: 0x00046714
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoBoxLineSlider2DController(GizmoLineSlider2DControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoBoxLineSlider2DController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBoxLineSlider2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoLineSlider2DControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00048560 File Offset: 0x00046760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65093, XrefRangeEnd = 65096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0004859C File Offset: 0x0004679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65096, XrefRangeEnd = 65099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000485D8 File Offset: 0x000467D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65099, XrefRangeEnd = 65104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoBoxLineSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00005716 File Offset: 0x00003916
		public GizmoBoxLineSlider2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoLineSlider2DControllerData_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;
	}
}
