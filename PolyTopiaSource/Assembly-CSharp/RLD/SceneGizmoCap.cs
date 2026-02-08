using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007A RID: 122
	public class SceneGizmoCap : global::Il2CppSystem.Object
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x000441CC File Offset: 0x000423CC
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoCap()
		{
			Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr);
			SceneGizmoCap.NativeFieldInfoPtr__sceneGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, "_sceneGizmo");
			SceneGizmoCap.NativeFieldInfoPtr__cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, "_cap");
			SceneGizmoCap.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, 100664651);
			SceneGizmoCap.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, 100664652);
			SceneGizmoCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, 100664653);
			SceneGizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, 100664654);
			SceneGizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr, 100664655);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00044288 File Offset: 0x00042488
		public unsafe int HandleId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64113, XrefRangeEnd = 64115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCap.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000442C4 File Offset: 0x000424C4
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64115, XrefRangeEnd = 64116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCap.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00044304 File Offset: 0x00042504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64116, XrefRangeEnd = 64124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoCap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capHandleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00044360 File Offset: 0x00042560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64124, XrefRangeEnd = 64126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000443A0 File Offset: 0x000425A0
		[CallerCount(0)]
		public unsafe virtual void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000050E2 File Offset: 0x000032E2
		public SceneGizmoCap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000443F0 File Offset: 0x000425F0
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000050EB File Offset: 0x000032EB
		public unsafe SceneGizmo _sceneGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCap.NativeFieldInfoPtr__sceneGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCap.NativeFieldInfoPtr__sceneGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00044420 File Offset: 0x00042620
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0000510A File Offset: 0x0000330A
		public unsafe GizmoCap3D _cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCap.NativeFieldInfoPtr__cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCap.NativeFieldInfoPtr__cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmo;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr__cap;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0;
	}
}
