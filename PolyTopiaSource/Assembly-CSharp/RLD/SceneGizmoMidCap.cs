using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007B RID: 123
	public class SceneGizmoMidCap : SceneGizmoCap
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00044450 File Offset: 0x00042650
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoMidCap()
		{
			Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoMidCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr);
			SceneGizmoMidCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr, 100664656);
			SceneGizmoMidCap.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr, 100664657);
			SceneGizmoMidCap.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr, 100664658);
			SceneGizmoMidCap.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr, 100664659);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000444D0 File Offset: 0x000426D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64126, XrefRangeEnd = 64149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoMidCap(SceneGizmo sceneGizmo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoMidCap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoMidCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0004451C File Offset: 0x0004271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64149, XrefRangeEnd = 64150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmoMidCap.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0004456C File Offset: 0x0004276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64150, XrefRangeEnd = 64152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoMidCap.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000445B0 File Offset: 0x000427B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64152, XrefRangeEnd = 64160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoMidCap.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00005129 File Offset: 0x00003329
		public SceneGizmoMidCap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0;
	}
}
