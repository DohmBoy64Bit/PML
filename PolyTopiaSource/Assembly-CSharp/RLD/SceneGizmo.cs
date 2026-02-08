using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class SceneGizmo : GizmoBehaviour
	{
		// Token: 0x0600090D RID: 2317 RVA: 0x00044600 File Offset: 0x00042800
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmo()
		{
			Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr);
			SceneGizmo.NativeFieldInfoPtr__camPrjSwitchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_camPrjSwitchLabel");
			SceneGizmo.NativeFieldInfoPtr__midAxisHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_midAxisHandle");
			SceneGizmo.NativeFieldInfoPtr__axesHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_axesHandles");
			SceneGizmo.NativeFieldInfoPtr__renderSortedHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_renderSortedHandles");
			SceneGizmo.NativeFieldInfoPtr__sceneGizmoCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_sceneGizmoCamera");
			SceneGizmo.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_lookAndFeel");
			SceneGizmo.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "_sharedLookAndFeel");
			SceneGizmo.NativeMethodInfoPtr_get_SceneGizmoCamera_Public_get_RTSceneGizmoCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664660);
			SceneGizmo.NativeMethodInfoPtr_get_OwnerGizmo_Public_Virtual_Final_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664661);
			SceneGizmo.NativeMethodInfoPtr_get_SceneCamera_Public_Virtual_Final_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664662);
			SceneGizmo.NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneGizmoLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664663);
			SceneGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_SceneGizmoLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664664);
			SceneGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_SceneGizmoLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664665);
			SceneGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664669);
			SceneGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664666);
			SceneGizmo.NativeMethodInfoPtr_OnGUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664667);
			SceneGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, 100664668);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00044784 File Offset: 0x00042984
		public unsafe RTSceneGizmoCamera SceneGizmoCamera
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_get_SceneGizmoCamera_Public_get_RTSceneGizmoCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTSceneGizmoCamera>(intPtr3) : null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000447C4 File Offset: 0x000429C4
		public unsafe virtual Gizmo OwnerGizmo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_get_OwnerGizmo_Public_Virtual_Final_New_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00044804 File Offset: 0x00042A04
		public unsafe virtual Camera SceneCamera
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64163, RefRangeEnd = 64164, XrefRangeStart = 64163, XrefRangeEnd = 64163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_get_SceneCamera_Public_Virtual_Final_New_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00044844 File Offset: 0x00042A44
		public unsafe SceneGizmoLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneGizmoLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00044884 File Offset: 0x00042A84
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000448C4 File Offset: 0x00042AC4
		public unsafe SceneGizmoLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_SceneGizmoLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_SceneGizmoLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00044908 File Offset: 0x00042B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64164, XrefRangeEnd = 64181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00044944 File Offset: 0x00042B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64181, XrefRangeEnd = 64330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00044980 File Offset: 0x00042B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64330, XrefRangeEnd = 64332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmo.NativeMethodInfoPtr_OnGUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000449BC File Offset: 0x00042BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64332, XrefRangeEnd = 64364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00005132 File Offset: 0x00003332
		public SceneGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00044A0C File Offset: 0x00042C0C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0000513B File Offset: 0x0000333B
		public unsafe SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__camPrjSwitchLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoCamPrjSwitchLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__camPrjSwitchLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00044A3C File Offset: 0x00042C3C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0000515A File Offset: 0x0000335A
		public unsafe SceneGizmoMidCap _midAxisHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__midAxisHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoMidCap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__midAxisHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00044A6C File Offset: 0x00042C6C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00005179 File Offset: 0x00003379
		public unsafe Il2CppReferenceArray<SceneGizmoAxisCap> _axesHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__axesHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SceneGizmoAxisCap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__axesHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00044A9C File Offset: 0x00042C9C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00005198 File Offset: 0x00003398
		public unsafe List<SceneGizmoCap> _renderSortedHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__renderSortedHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SceneGizmoCap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__renderSortedHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00044ACC File Offset: 0x00042CCC
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000051B7 File Offset: 0x000033B7
		public unsafe RTSceneGizmoCamera _sceneGizmoCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__sceneGizmoCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTSceneGizmoCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__sceneGizmoCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00044AFC File Offset: 0x00042CFC
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000051D6 File Offset: 0x000033D6
		public unsafe SceneGizmoLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00044B2C File Offset: 0x00042D2C
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000051F5 File Offset: 0x000033F5
		public unsafe SceneGizmoLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr__camPrjSwitchLabel;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr__midAxisHandle;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr__axesHandles;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr__renderSortedHandles;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmoCamera;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneGizmoCamera_Public_get_RTSceneGizmoCamera_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerGizmo_Public_Virtual_Final_New_get_Gizmo_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneCamera_Public_Virtual_Final_New_get_Camera_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneGizmoLookAndFeel_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_SceneGizmoLookAndFeel_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_SceneGizmoLookAndFeel_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Virtual_Void_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x02000369 RID: 873
		[ObfuscatedName("RLD.SceneGizmo+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049DC RID: 18908 RVA: 0x00145D3C File Offset: 0x00143F3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneGizmo>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr);
				SceneGizmo.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr, "cameraPos");
				SceneGizmo.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr, 100664670);
				SceneGizmo.__c__DisplayClass20_0.NativeMethodInfoPtr__OnGizmoRender_b__0_Internal_Int32_SceneGizmoCap_SceneGizmoCap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr, 100664671);
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x00145DA4 File Offset: 0x00143FA4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmo.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049DE RID: 18910 RVA: 0x00145DE0 File Offset: 0x00143FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64160, XrefRangeEnd = 64163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnGizmoRender_b__0(SceneGizmoCap h0, SceneGizmoCap h1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(h0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmo.__c__DisplayClass20_0.NativeMethodInfoPtr__OnGizmoRender_b__0_Internal_Int32_SceneGizmoCap_SceneGizmoCap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049DF RID: 18911 RVA: 0x0001B7CF File Offset: 0x000199CF
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001905 RID: 6405
			// (get) Token: 0x060049E0 RID: 18912 RVA: 0x00145E40 File Offset: 0x00144040
			// (set) Token: 0x060049E1 RID: 18913 RVA: 0x0001B7D8 File Offset: 0x000199D8
			public unsafe Vector3 cameraPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmo.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400395D RID: 14685
			private static readonly IntPtr NativeFieldInfoPtr_cameraPos;

			// Token: 0x0400395E RID: 14686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400395F RID: 14687
			private static readonly IntPtr NativeMethodInfoPtr__OnGizmoRender_b__0_Internal_Int32_SceneGizmoCap_SceneGizmoCap_0;
		}
	}
}
