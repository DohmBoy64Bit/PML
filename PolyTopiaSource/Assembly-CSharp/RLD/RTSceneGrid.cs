using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class RTSceneGrid : MonoSingleton<RTSceneGrid>
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x000A5874 File Offset: 0x000A3A74
		// Note: this type is marked as 'beforefieldinit'.
		static RTSceneGrid()
		{
			Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTSceneGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr);
			RTSceneGrid.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, "_hotkeys");
			RTSceneGrid.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, "_settings");
			RTSceneGrid.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, "_lookAndFeel");
			RTSceneGrid.NativeFieldInfoPtr__renderIgnoreCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, "_renderIgnoreCameras");
			RTSceneGrid.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668351);
			RTSceneGrid.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668352);
			RTSceneGrid.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668353);
			RTSceneGrid.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668354);
			RTSceneGrid.NativeMethodInfoPtr_get_WorldPlane_Public_Virtual_Final_New_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668355);
			RTSceneGrid.NativeMethodInfoPtr_get_WorldMatrix_Public_Virtual_Final_New_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668356);
			RTSceneGrid.NativeMethodInfoPtr_get_YOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668357);
			RTSceneGrid.NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668358);
			RTSceneGrid.NativeMethodInfoPtr_get_Hotkeys_Public_get_SceneGridHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668359);
			RTSceneGrid.NativeMethodInfoPtr_get_Settings_Public_get_XZGridSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668360);
			RTSceneGrid.NativeMethodInfoPtr_get_LookAndFeel_Public_get_XZGridLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668361);
			RTSceneGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668376);
			RTSceneGrid.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668362);
			RTSceneGrid.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668363);
			RTSceneGrid.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668364);
			RTSceneGrid.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668365);
			RTSceneGrid.NativeMethodInfoPtr_CellFromWorldPoint_Public_Virtual_Final_New_XZGridCell_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668366);
			RTSceneGrid.NativeMethodInfoPtr_Raycast_Public_Virtual_Final_New_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668367);
			RTSceneGrid.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668368);
			RTSceneGrid.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668369);
			RTSceneGrid.NativeMethodInfoPtr_MoveUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668370);
			RTSceneGrid.NativeMethodInfoPtr_MoveDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668371);
			RTSceneGrid.NativeMethodInfoPtr_CalculateCellFadeZoom_Private_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668372);
			RTSceneGrid.NativeMethodInfoPtr_GetSceneHitForGridSnap_Private_SceneRaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668373);
			RTSceneGrid.NativeMethodInfoPtr_OnInputDeviceDoubleTap_Private_Void_IInputDevice_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668374);
			RTSceneGrid.NativeMethodInfoPtr_SnapToObjectHitPoint_Private_Void_GameObjectRayHit_SnapToPointMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr, 100668375);
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x000A5AFC File Offset: 0x000A3CFC
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85927, XrefRangeEnd = 85928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000A5B3C File Offset: 0x000A3D3C
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85932, RefRangeEnd = 85933, XrefRangeStart = 85928, XrefRangeEnd = 85932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x000A5B7C File Offset: 0x000A3D7C
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85937, RefRangeEnd = 85938, XrefRangeStart = 85933, XrefRangeEnd = 85937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000A5BBC File Offset: 0x000A3DBC
		public unsafe Vector3 Normal
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 85942, RefRangeEnd = 85947, XrefRangeStart = 85938, XrefRangeEnd = 85942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x000A5BFC File Offset: 0x000A3DFC
		public unsafe virtual Plane WorldPlane
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 85951, RefRangeEnd = 85955, XrefRangeStart = 85947, XrefRangeEnd = 85951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_WorldPlane_Public_Virtual_Final_New_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000A5C3C File Offset: 0x000A3E3C
		public unsafe virtual Matrix4x4 WorldMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85955, XrefRangeEnd = 85960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_WorldMatrix_Public_Virtual_Final_New_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x000A5C7C File Offset: 0x000A3E7C
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x000A5CB8 File Offset: 0x000A3EB8
		public unsafe float YOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_YOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x000A5CF8 File Offset: 0x000A3EF8
		public unsafe SceneGridHotkeys Hotkeys
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Hotkeys_Public_get_SceneGridHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGridHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000A5D38 File Offset: 0x000A3F38
		public unsafe XZGridSettings Settings
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_Settings_Public_get_XZGridSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x000A5D78 File Offset: 0x000A3F78
		public unsafe XZGridLookAndFeel LookAndFeel
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_get_LookAndFeel_Public_get_XZGridLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000A5DB8 File Offset: 0x000A3FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85960, XrefRangeEnd = 86013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTSceneGrid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTSceneGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000A5DF4 File Offset: 0x000A3FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86030, RefRangeEnd = 86031, XrefRangeStart = 86013, XrefRangeEnd = 86030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000A5E28 File Offset: 0x000A4028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86031, XrefRangeEnd = 86035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000A5E78 File Offset: 0x000A4078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86041, RefRangeEnd = 86042, XrefRangeStart = 86035, XrefRangeEnd = 86041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000A5EBC File Offset: 0x000A40BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86042, XrefRangeEnd = 86046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000A5F00 File Offset: 0x000A4100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86047, RefRangeEnd = 86048, XrefRangeStart = 86046, XrefRangeEnd = 86047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XZGridCell CellFromWorldPoint(Vector3 worldPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(worldPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_CellFromWorldPoint_Public_Virtual_Final_New_XZGridCell_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridCell>(intPtr3) : null;
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000A5F50 File Offset: 0x000A4150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86048, XrefRangeEnd = 86050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Raycast(Ray ray, out float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_Raycast_Public_Virtual_Final_New_Boolean_Ray_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000A5FAC File Offset: 0x000A41AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86071, RefRangeEnd = 86072, XrefRangeStart = 86050, XrefRangeEnd = 86071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000A5FE0 File Offset: 0x000A41E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86136, RefRangeEnd = 86137, XrefRangeStart = 86072, XrefRangeEnd = 86136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000A6024 File Offset: 0x000A4224
		[CallerCount(0)]
		public unsafe void MoveUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_MoveUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000A6058 File Offset: 0x000A4258
		[CallerCount(0)]
		public unsafe void MoveDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_MoveDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000A608C File Offset: 0x000A428C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86137, XrefRangeEnd = 86141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateCellFadeZoom(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_CalculateCellFadeZoom_Private_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000A60DC File Offset: 0x000A42DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86171, RefRangeEnd = 86173, XrefRangeStart = 86141, XrefRangeEnd = 86171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneRaycastHit GetSceneHitForGridSnap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_GetSceneHitForGridSnap_Private_SceneRaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneRaycastHit>(intPtr3) : null;
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000A611C File Offset: 0x000A431C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86173, XrefRangeEnd = 86176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_OnInputDeviceDoubleTap_Private_Void_IInputDevice_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000A6170 File Offset: 0x000A4370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86198, RefRangeEnd = 86200, XrefRangeStart = 86176, XrefRangeEnd = 86198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapToObjectHitPoint(GameObjectRayHit objectHit, RTSceneGrid.SnapToPointMode snapMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectHit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGrid.NativeMethodInfoPtr_SnapToObjectHitPoint_Private_Void_GameObjectRayHit_SnapToPointMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0000D8FF File Offset: 0x0000BAFF
		public RTSceneGrid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000A61C0 File Offset: 0x000A43C0
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x0000D908 File Offset: 0x0000BB08
		public unsafe SceneGridHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGridHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000A61F0 File Offset: 0x000A43F0
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x0000D927 File Offset: 0x0000BB27
		public unsafe XZGridSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XZGridSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000A6220 File Offset: 0x000A4420
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x0000D946 File Offset: 0x0000BB46
		public unsafe XZGridLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XZGridLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000A6250 File Offset: 0x000A4450
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x0000D965 File Offset: 0x0000BB65
		public unsafe List<Camera> _renderIgnoreCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__renderIgnoreCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGrid.NativeFieldInfoPtr__renderIgnoreCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeFieldInfoPtr__renderIgnoreCameras;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldPlane_Public_Virtual_Final_New_get_Plane_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldMatrix_Public_Virtual_Final_New_get_Matrix4x4_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_get_YOffset_Public_get_Single_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_SceneGridHotkeys_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_XZGridSettings_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_XZGridLookAndFeel_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_CellFromWorldPoint_Public_Virtual_Final_New_XZGridCell_Vector3_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Final_New_Boolean_Ray_byref_Single_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCellFadeZoom_Private_Single_Camera_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneHitForGridSnap_Private_SceneRaycastHit_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceDoubleTap_Private_Void_IInputDevice_Vector2_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_SnapToObjectHitPoint_Private_Void_GameObjectRayHit_SnapToPointMode_0;

		// Token: 0x020003A4 RID: 932
		public enum SnapToPointMode
		{
			// Token: 0x04003AA4 RID: 15012
			Exact,
			// Token: 0x04003AA5 RID: 15013
			ClosestExtremity
		}
	}
}
