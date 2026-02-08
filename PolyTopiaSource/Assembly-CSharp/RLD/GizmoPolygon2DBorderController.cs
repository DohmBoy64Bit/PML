using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000B6 RID: 182
	public class GizmoPolygon2DBorderController : Object
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x0005B870 File Offset: 0x00059A70
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPolygon2DBorderController()
		{
			Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPolygon2DBorderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr);
			GizmoPolygon2DBorderController.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr, "_data");
			GizmoPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr, 100665480);
			GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr, 100665481);
			GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr, 100665482);
			GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr, 100665483);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0005B904 File Offset: 0x00059B04
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPolygon2DBorderController(GizmoPolygon2DBorderControllerData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPolygon2DBorderController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorderController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0005B950 File Offset: 0x00059B50
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0005B98C File Offset: 0x00059B8C
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPolygon2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00007B45 File Offset: 0x00005D45
		public GizmoPolygon2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0005BA04 File Offset: 0x00059C04
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00007B4E File Offset: 0x00005D4E
		public unsafe GizmoPolygon2DBorderControllerData _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderController.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderController.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPolygon2DBorderControllerData_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0;
	}
}
