using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000196 RID: 406
	public class PrefabSpawnSnap : MonoBehaviour
	{
		// Token: 0x06001F57 RID: 8023 RVA: 0x0009E540 File Offset: 0x0009C740
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabSpawnSnap()
		{
			Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabSpawnSnap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr);
			PrefabSpawnSnap.NativeFieldInfoPtr__isSnapSessionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, "_isSnapSessionActive");
			PrefabSpawnSnap.NativeFieldInfoPtr__targetHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, "_targetHierarchy");
			PrefabSpawnSnap.NativeFieldInfoPtr__snapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, "_snapConfig");
			PrefabSpawnSnap.NativeFieldInfoPtr__objectSurfaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, "_objectSurfaceLayers");
			PrefabSpawnSnap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668080);
			PrefabSpawnSnap.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668071);
			PrefabSpawnSnap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668072);
			PrefabSpawnSnap.NativeMethodInfoPtr_EvaluateSessionEndCondition_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668073);
			PrefabSpawnSnap.NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_IInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668074);
			PrefabSpawnSnap.NativeMethodInfoPtr_BeginSnapSession_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668075);
			PrefabSpawnSnap.NativeMethodInfoPtr_EndSnapSession_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668076);
			PrefabSpawnSnap.NativeMethodInfoPtr_OnAppInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668077);
			PrefabSpawnSnap.NativeMethodInfoPtr_OnPrefabSpawned_Private_Void_RTPrefab_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668078);
			PrefabSpawnSnap.NativeMethodInfoPtr_OnCanChangeObjectSelection_Private_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr, 100668079);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0009E688 File Offset: 0x0009C888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83374, XrefRangeEnd = 83375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabSpawnSnap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabSpawnSnap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0009E6C4 File Offset: 0x0009C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83375, XrefRangeEnd = 83389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x0009E6F8 File Offset: 0x0009C8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83389, XrefRangeEnd = 83408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0009E72C File Offset: 0x0009C92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83408, XrefRangeEnd = 83417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EvaluateSessionEndCondition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_EvaluateSessionEndCondition_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0009E768 File Offset: 0x0009C968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83462, RefRangeEnd = 83463, XrefRangeStart = 83417, XrefRangeEnd = 83462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceMoved(IInputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_IInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0009E7AC File Offset: 0x0009C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83463, XrefRangeEnd = 83464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSnapSession(GameObject targetHierarchy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetHierarchy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_BeginSnapSession_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83464, XrefRangeEnd = 83465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSnapSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_EndSnapSession_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0009E824 File Offset: 0x0009CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83465, XrefRangeEnd = 83514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAppInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_OnAppInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0009E858 File Offset: 0x0009CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83514, XrefRangeEnd = 83515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabSpawned(RTPrefab prefab, GameObject spawnedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_OnPrefabSpawned_Private_Void_RTPrefab_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0009E8AC File Offset: 0x0009CAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83515, XrefRangeEnd = 83518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanChangeObjectSelection(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabSpawnSnap.NativeMethodInfoPtr_OnCanChangeObjectSelection_Private_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000CC21 File Offset: 0x0000AE21
		public PrefabSpawnSnap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x0000CC2A File Offset: 0x0000AE2A
		public unsafe bool _isSnapSessionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__isSnapSessionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__isSnapSessionActive)) = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x0009E918 File Offset: 0x0009CB18
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x0000CC45 File Offset: 0x0000AE45
		public unsafe GameObject _targetHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__targetHierarchy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__targetHierarchy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x0009E948 File Offset: 0x0009CB48
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x0000CC64 File Offset: 0x0000AE64
		public ObjectSurfaceSnap.SnapConfig _snapConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__snapConfig);
				return new ObjectSurfaceSnap.SnapConfig(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__snapConfig), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x0009E978 File Offset: 0x0009CB78
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x0000CC92 File Offset: 0x0000AE92
		public unsafe int _objectSurfaceLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__objectSurfaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabSpawnSnap.NativeFieldInfoPtr__objectSurfaceLayers)) = value;
			}
		}

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeFieldInfoPtr__isSnapSessionActive;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeFieldInfoPtr__targetHierarchy;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeFieldInfoPtr__snapConfig;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeFieldInfoPtr__objectSurfaceLayers;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSessionEndCondition_Private_Boolean_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_IInputDevice_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_BeginSnapSession_Private_Void_GameObject_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_EndSnapSession_Private_Void_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_OnAppInitialized_Private_Void_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabSpawned_Private_Void_RTPrefab_GameObject_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_OnCanChangeObjectSelection_Private_Void_YesNoAnswer_0;
	}
}
