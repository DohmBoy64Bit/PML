using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class ObjectGrabHotkeys : Settings
	{
		// Token: 0x06002328 RID: 9000 RVA: 0x000AC6C8 File Offset: 0x000AA8C8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGrabHotkeys()
		{
			Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGrabHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr);
			ObjectGrabHotkeys.NativeFieldInfoPtr__toggleGrab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_toggleGrab");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableRotation");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotationAroundAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableRotationAroundAnchor");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableScaling");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableOffsetFromSurface");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableAnchorAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableAnchorAdjust");
			ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_enableOffsetFromAnchor");
			ObjectGrabHotkeys.NativeFieldInfoPtr__nextAlignmentAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, "_nextAlignmentAxis");
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_ToggleGrab_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668585);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableRotation_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668586);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableRotationAroundAnchor_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668587);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableScaling_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668588);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableOffsetFromSurface_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668589);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableAnchorAdjust_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668590);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableOffsetFromAnchor_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668591);
			ObjectGrabHotkeys.NativeMethodInfoPtr_get_NextAlignmentAxis_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668592);
			ObjectGrabHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668593);
			ObjectGrabHotkeys.NativeMethodInfoPtr_EstablishPotentialOverlaps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr, 100668594);
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000AC860 File Offset: 0x000AAA60
		public unsafe Hotkeys ToggleGrab
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_ToggleGrab_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000AC8A0 File Offset: 0x000AAAA0
		public unsafe Hotkeys EnableRotation
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableRotation_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000AC8E0 File Offset: 0x000AAAE0
		public unsafe Hotkeys EnableRotationAroundAnchor
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableRotationAroundAnchor_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000AC920 File Offset: 0x000AAB20
		public unsafe Hotkeys EnableScaling
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableScaling_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000AC960 File Offset: 0x000AAB60
		public unsafe Hotkeys EnableOffsetFromSurface
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableOffsetFromSurface_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000AC9A0 File Offset: 0x000AABA0
		public unsafe Hotkeys EnableAnchorAdjust
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableAnchorAdjust_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000AC9E0 File Offset: 0x000AABE0
		public unsafe Hotkeys EnableOffsetFromAnchor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_EnableOffsetFromAnchor_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000ACA20 File Offset: 0x000AAC20
		public unsafe Hotkeys NextAlignmentAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_get_NextAlignmentAxis_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000ACA60 File Offset: 0x000AAC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87801, RefRangeEnd = 87802, XrefRangeStart = 87745, XrefRangeEnd = 87801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGrabHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGrabHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000ACA9C File Offset: 0x000AAC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87839, RefRangeEnd = 87840, XrefRangeStart = 87802, XrefRangeEnd = 87839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EstablishPotentialOverlaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabHotkeys.NativeMethodInfoPtr_EstablishPotentialOverlaps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0000E630 File Offset: 0x0000C830
		public ObjectGrabHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000E639 File Offset: 0x0000C839
		public unsafe Hotkeys _toggleGrab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__toggleGrab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__toggleGrab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000ACB00 File Offset: 0x000AAD00
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000E658 File Offset: 0x0000C858
		public unsafe Hotkeys _enableRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000ACB30 File Offset: 0x000AAD30
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000E677 File Offset: 0x0000C877
		public unsafe Hotkeys _enableRotationAroundAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotationAroundAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableRotationAroundAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000ACB60 File Offset: 0x000AAD60
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000E696 File Offset: 0x0000C896
		public unsafe Hotkeys _enableScaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableScaling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableScaling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000ACB90 File Offset: 0x000AAD90
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000E6B5 File Offset: 0x0000C8B5
		public unsafe Hotkeys _enableOffsetFromSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000ACBC0 File Offset: 0x000AADC0
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		public unsafe Hotkeys _enableAnchorAdjust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableAnchorAdjust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableAnchorAdjust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000ACBF0 File Offset: 0x000AADF0
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0000E6F3 File Offset: 0x0000C8F3
		public unsafe Hotkeys _enableOffsetFromAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__enableOffsetFromAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000ACC20 File Offset: 0x000AAE20
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x0000E712 File Offset: 0x0000C912
		public unsafe Hotkeys _nextAlignmentAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__nextAlignmentAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabHotkeys.NativeFieldInfoPtr__nextAlignmentAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr__toggleGrab;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr__enableRotation;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr__enableRotationAroundAnchor;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr__enableScaling;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr__enableOffsetFromSurface;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr__enableAnchorAdjust;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr__enableOffsetFromAnchor;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr__nextAlignmentAxis;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_get_ToggleGrab_Public_get_Hotkeys_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableRotation_Public_get_Hotkeys_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableRotationAroundAnchor_Public_get_Hotkeys_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableScaling_Public_get_Hotkeys_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableOffsetFromSurface_Public_get_Hotkeys_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableAnchorAdjust_Public_get_Hotkeys_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableOffsetFromAnchor_Public_get_Hotkeys_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_get_NextAlignmentAxis_Public_get_Hotkeys_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_EstablishPotentialOverlaps_Private_Void_0;
	}
}
