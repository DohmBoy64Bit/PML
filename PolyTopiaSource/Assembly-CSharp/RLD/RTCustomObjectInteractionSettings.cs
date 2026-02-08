using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B5 RID: 437
	[Serializable]
	public class RTCustomObjectInteractionSettings : Settings
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x000A78B8 File Offset: 0x000A5AB8
		// Note: this type is marked as 'beforefieldinit'.
		static RTCustomObjectInteractionSettings()
		{
			Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTCustomObjectInteractionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr);
			RTCustomObjectInteractionSettings.NativeFieldInfoPtr__noVolumeObjectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr, "_noVolumeObjectSize");
			RTCustomObjectInteractionSettings.NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr, 100668420);
			RTCustomObjectInteractionSettings.NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr, 100668421);
			RTCustomObjectInteractionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr, 100668422);
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000A7938 File Offset: 0x000A5B38
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000A7978 File Offset: 0x000A5B78
		public unsafe Vector3 NoVolumeObjectSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCustomObjectInteractionSettings.NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86296, XrefRangeEnd = 86302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCustomObjectInteractionSettings.NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000A79BC File Offset: 0x000A5BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86302, XrefRangeEnd = 86304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTCustomObjectInteractionSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCustomObjectInteractionSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCustomObjectInteractionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0000DCCD File Offset: 0x0000BECD
		public RTCustomObjectInteractionSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000A79F8 File Offset: 0x000A5BF8
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0000DCD6 File Offset: 0x0000BED6
		public unsafe Vector3 _noVolumeObjectSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCustomObjectInteractionSettings.NativeFieldInfoPtr__noVolumeObjectSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCustomObjectInteractionSettings.NativeFieldInfoPtr__noVolumeObjectSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeFieldInfoPtr__noVolumeObjectSize;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_get_NoVolumeObjectSize_Public_get_Vector3_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_set_NoVolumeObjectSize_Public_set_Void_Vector3_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
