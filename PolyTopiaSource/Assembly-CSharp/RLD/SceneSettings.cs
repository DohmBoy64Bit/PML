using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public class SceneSettings : Settings
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x000A9BEC File Offset: 0x000A7DEC
		// Note: this type is marked as 'beforefieldinit'.
		static SceneSettings()
		{
			Il2CppClassPointerStore<SceneSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr);
			SceneSettings.NativeFieldInfoPtr__physicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, "_physicsMode");
			SceneSettings.NativeFieldInfoPtr__noVolumeObjectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, "_noVolumeObjectSize");
			SceneSettings.NativeMethodInfoPtr_get_PhysicsMode_Public_get_ScenePhysicsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, 100668494);
			SceneSettings.NativeMethodInfoPtr_set_PhysicsMode_Public_set_Void_ScenePhysicsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, 100668495);
			SceneSettings.NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, 100668496);
			SceneSettings.NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, 100668497);
			SceneSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr, 100668498);
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000A9CA8 File Offset: 0x000A7EA8
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x000A9CE8 File Offset: 0x000A7EE8
		public unsafe ScenePhysicsMode PhysicsMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneSettings.NativeMethodInfoPtr_get_PhysicsMode_Public_get_ScenePhysicsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScenePhysicsMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87066, XrefRangeEnd = 87070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneSettings.NativeMethodInfoPtr_set_PhysicsMode_Public_set_Void_ScenePhysicsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000A9D2C File Offset: 0x000A7F2C
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x000A9D68 File Offset: 0x000A7F68
		public unsafe float NoVolumeObjectSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneSettings.NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87070, XrefRangeEnd = 87074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneSettings.NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000A9DA8 File Offset: 0x000A7FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87074, XrefRangeEnd = 87075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		public SceneSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x000A9DE4 File Offset: 0x000A7FE4
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		public unsafe ScenePhysicsMode _physicsMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneSettings.NativeFieldInfoPtr__physicsMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScenePhysicsMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneSettings.NativeFieldInfoPtr__physicsMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x000A9E14 File Offset: 0x000A8014
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0000E11B File Offset: 0x0000C31B
		public unsafe float _noVolumeObjectSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneSettings.NativeFieldInfoPtr__noVolumeObjectSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneSettings.NativeFieldInfoPtr__noVolumeObjectSize)) = value;
			}
		}

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeFieldInfoPtr__physicsMode;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeFieldInfoPtr__noVolumeObjectSize;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_get_PhysicsMode_Public_get_ScenePhysicsMode_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_set_PhysicsMode_Public_set_Void_ScenePhysicsMode_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Single_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Single_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
