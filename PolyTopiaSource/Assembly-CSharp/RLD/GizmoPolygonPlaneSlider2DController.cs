using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000095 RID: 149
	public class GizmoPolygonPlaneSlider2DController : GizmoPlaneSlider2DController
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x00050004 File Offset: 0x0004E204
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPolygonPlaneSlider2DController()
		{
			Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPolygonPlaneSlider2DController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr);
			GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2DControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr, 100665073);
			GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr, 100665074);
			GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr, 100665075);
			GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr, 100665076);
			GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_GetRealExtentPoint_Public_Virtual_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr, 100665077);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00050098 File Offset: 0x0004E298
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPolygonPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPolygonPlaneSlider2DController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2DControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000500E4 File Offset: 0x0004E2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66290, XrefRangeEnd = 66297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00050120 File Offset: 0x0004E320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66297, XrefRangeEnd = 66299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0005015C File Offset: 0x0004E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66299, XrefRangeEnd = 66301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00050198 File Offset: 0x0004E398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66301, XrefRangeEnd = 66303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygonPlaneSlider2DController.NativeMethodInfoPtr_GetRealExtentPoint_Public_Virtual_Vector2_Shape2DExtentPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00006669 File Offset: 0x00004869
		public GizmoPolygonPlaneSlider2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2DControllerData_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_GetRealExtentPoint_Public_Virtual_Vector2_Shape2DExtentPoint_0;
	}
}
