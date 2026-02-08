using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace RLD
{
	// Token: 0x020000F3 RID: 243
	public class RLDApp : MonoSingleton<RLDApp>
	{
		// Token: 0x060017D7 RID: 6103 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		// Note: this type is marked as 'beforefieldinit'.
		static RLDApp()
		{
			Il2CppClassPointerStore<RLDApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RLDApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RLDApp>.NativeClassPtr);
			RLDApp.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, "Initialized");
			RLDApp.NativeFieldInfoPtr__renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, "_renderCamera");
			RLDApp.NativeFieldInfoPtr__renderPipelineId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, "_renderPipelineId");
			RLDApp.NativeFieldInfoPtr__dynamicConvertSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, "_dynamicConvertSettings");
			RLDApp.NativeMethodInfoPtr_get_DynamicConvertSettings_Public_get_DynamicConvertSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666823);
			RLDApp.NativeMethodInfoPtr_get_RenderPipelineId_Public_get_RenderPipelineId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666824);
			RLDApp.NativeMethodInfoPtr_get_RenderCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666825);
			RLDApp.NativeMethodInfoPtr_add_Initialized_Public_add_Void_RLDAppInitializedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666821);
			RLDApp.NativeMethodInfoPtr_remove_Initialized_Public_rem_Void_RLDAppInitializedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666822);
			RLDApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666841);
			RLDApp.NativeMethodInfoPtr_OnSceneCanRenderCameraIcon_Private_Void_Camera_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666826);
			RLDApp.NativeMethodInfoPtr_OnCanCameraUseScrollWheel_Private_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666827);
			RLDApp.NativeMethodInfoPtr_OnCanCameraProcessInput_Private_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666828);
			RLDApp.NativeMethodInfoPtr_OnCanUndoRedo_Private_Void_UndoRedoOpType_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666829);
			RLDApp.NativeMethodInfoPtr_OnCanDoGizmoHoverUpdate_Private_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666830);
			RLDApp.NativeMethodInfoPtr_OnCanObjectSelectionClickAndMultiSelectDeselect_Private_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666831);
			RLDApp.NativeMethodInfoPtr_OnViewportsCameraAdded_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666832);
			RLDApp.NativeMethodInfoPtr_OnViewportCameraRemoved_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666833);
			RLDApp.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666834);
			RLDApp.NativeMethodInfoPtr_DetectRenderPipeline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666835);
			RLDApp.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666836);
			RLDApp.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666837);
			RLDApp.NativeMethodInfoPtr_OnRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666838);
			RLDApp.NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666839);
			RLDApp.NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RLDApp>.NativeClassPtr, 100666840);
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0007E6EC File Offset: 0x0007C8EC
		public unsafe DynamicConvertSettings DynamicConvertSettings
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_get_DynamicConvertSettings_Public_get_DynamicConvertSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicConvertSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0007E72C File Offset: 0x0007C92C
		public unsafe RenderPipelineId RenderPipelineId
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_get_RenderPipelineId_Public_get_RenderPipelineId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineId>(intPtr3) : null;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0007E76C File Offset: 0x0007C96C
		public unsafe Camera RenderCamera
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_get_RenderCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0007E7AC File Offset: 0x0007C9AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73850, RefRangeEnd = 73852, XrefRangeStart = 73846, XrefRangeEnd = 73850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Initialized(RLDAppInitializedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_add_Initialized_Public_add_Void_RLDAppInitializedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0007E7F0 File Offset: 0x0007C9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73852, XrefRangeEnd = 73856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Initialized(RLDAppInitializedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_remove_Initialized_Public_rem_Void_RLDAppInitializedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0007E834 File Offset: 0x0007CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73856, XrefRangeEnd = 73867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RLDApp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RLDApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0007E870 File Offset: 0x0007CA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73867, XrefRangeEnd = 73884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneCanRenderCameraIcon(Camera camera, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnSceneCanRenderCameraIcon_Private_Void_Camera_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0007E8C4 File Offset: 0x0007CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73884, XrefRangeEnd = 73891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanCameraUseScrollWheel(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnCanCameraUseScrollWheel_Private_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0007E908 File Offset: 0x0007CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73891, XrefRangeEnd = 73897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanCameraProcessInput(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnCanCameraProcessInput_Private_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0007E94C File Offset: 0x0007CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73897, XrefRangeEnd = 73916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoRedoOpType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnCanUndoRedo_Private_Void_UndoRedoOpType_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0007E9A0 File Offset: 0x0007CBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73916, XrefRangeEnd = 73931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanDoGizmoHoverUpdate(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnCanDoGizmoHoverUpdate_Private_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73931, XrefRangeEnd = 73938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanObjectSelectionClickAndMultiSelectDeselect(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnCanObjectSelectionClickAndMultiSelectDeselect_Private_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0007EA28 File Offset: 0x0007CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73938, XrefRangeEnd = 73946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewportsCameraAdded(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnViewportsCameraAdded_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73946, XrefRangeEnd = 73954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewportCameraRemoved(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnViewportCameraRemoved_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73954, XrefRangeEnd = 74192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0007EAE4 File Offset: 0x0007CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74192, XrefRangeEnd = 74214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectRenderPipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_DetectRenderPipeline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0007EB18 File Offset: 0x0007CD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74214, XrefRangeEnd = 74235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0007EB4C File Offset: 0x0007CD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74235, XrefRangeEnd = 74321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0007EB80 File Offset: 0x0007CD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74321, XrefRangeEnd = 74379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74379, XrefRangeEnd = 74380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0007EC08 File Offset: 0x0007CE08
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RLDApp.NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0000A8B9 File Offset: 0x00008AB9
		public RLDApp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0007EC5C File Offset: 0x0007CE5C
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x0000A8C2 File Offset: 0x00008AC2
		public unsafe RLDAppInitializedHandler Initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr_Initialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RLDAppInitializedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr_Initialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0000A8E1 File Offset: 0x00008AE1
		public unsafe Camera _renderCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__renderCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__renderCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0007ECBC File Offset: 0x0007CEBC
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0000A900 File Offset: 0x00008B00
		public unsafe RenderPipelineId _renderPipelineId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__renderPipelineId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineId>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__renderPipelineId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0007ECEC File Offset: 0x0007CEEC
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000A91F File Offset: 0x00008B1F
		public unsafe DynamicConvertSettings _dynamicConvertSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__dynamicConvertSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicConvertSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RLDApp.NativeFieldInfoPtr__dynamicConvertSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr_Initialized;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeFieldInfoPtr__renderCamera;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr__renderPipelineId;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr__dynamicConvertSettings;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_get_DynamicConvertSettings_Public_get_DynamicConvertSettings_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderPipelineId_Public_get_RenderPipelineId_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderCamera_Public_get_Camera_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_add_Initialized_Public_add_Void_RLDAppInitializedHandler_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_remove_Initialized_Public_rem_Void_RLDAppInitializedHandler_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneCanRenderCameraIcon_Private_Void_Camera_YesNoAnswer_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_OnCanCameraUseScrollWheel_Private_Void_YesNoAnswer_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_OnCanCameraProcessInput_Private_Void_YesNoAnswer_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_OnCanUndoRedo_Private_Void_UndoRedoOpType_YesNoAnswer_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_OnCanDoGizmoHoverUpdate_Private_Void_YesNoAnswer_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_OnCanObjectSelectionClickAndMultiSelectDeselect_Private_Void_YesNoAnswer_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_OnViewportsCameraAdded_Private_Void_Camera_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_OnViewportCameraRemoved_Private_Void_Camera_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_DetectRenderPipeline_Private_Void_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderObject_Private_Void_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;
	}
}
