using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200007D RID: 125
	public class SceneGizmoCamViewportUpdater : Object
	{
		// Token: 0x06000927 RID: 2343 RVA: 0x00044B5C File Offset: 0x00042D5C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoCamViewportUpdater()
		{
			Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoCamViewportUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr);
			SceneGizmoCamViewportUpdater.NativeFieldInfoPtr__sceneGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr, "_sceneGizmo");
			SceneGizmoCamViewportUpdater.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr, 100664672);
			SceneGizmoCamViewportUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_RTSceneGizmoCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr, 100664673);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00044BC8 File Offset: 0x00042DC8
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoCamViewportUpdater(SceneGizmo sceneGizmo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoCamViewportUpdater>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamViewportUpdater.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00044C14 File Offset: 0x00042E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64364, XrefRangeEnd = 64378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update(RTSceneGizmoCamera sceneGizmoCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmoCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoCamViewportUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_RTSceneGizmoCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00005214 File Offset: 0x00003414
		public SceneGizmoCamViewportUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00044C58 File Offset: 0x00042E58
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0000521D File Offset: 0x0000341D
		public unsafe SceneGizmo _sceneGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamViewportUpdater.NativeFieldInfoPtr__sceneGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoCamViewportUpdater.NativeFieldInfoPtr__sceneGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmo;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_RTSceneGizmoCamera_0;
	}
}
