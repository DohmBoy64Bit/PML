using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x0200005C RID: 92
	public class GizmoCollectionEnabledStateSnapshot : Object
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x000386CC File Offset: 0x000368CC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCollectionEnabledStateSnapshot()
		{
			Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCollectionEnabledStateSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr);
			GizmoCollectionEnabledStateSnapshot.NativeFieldInfoPtr__gizmoToState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr, "_gizmoToState");
			GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr, 100664171);
			GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_IEnumerable_1_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr, 100664169);
			GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr, 100664170);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0003874C File Offset: 0x0003694C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60818, RefRangeEnd = 60819, XrefRangeStart = 60810, XrefRangeEnd = 60818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCollectionEnabledStateSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCollectionEnabledStateSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00038788 File Offset: 0x00036988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60842, RefRangeEnd = 60844, XrefRangeStart = 60819, XrefRangeEnd = 60842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snapshot(IEnumerable<Gizmo> gizmos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_IEnumerable_1_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000387CC File Offset: 0x000369CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60864, RefRangeEnd = 60866, XrefRangeStart = 60844, XrefRangeEnd = 60864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCollectionEnabledStateSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00004337 File Offset: 0x00002537
		public GizmoCollectionEnabledStateSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00038800 File Offset: 0x00036A00
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00004340 File Offset: 0x00002540
		public unsafe Dictionary<Gizmo, bool> _gizmoToState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCollectionEnabledStateSnapshot.NativeFieldInfoPtr__gizmoToState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Gizmo, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCollectionEnabledStateSnapshot.NativeFieldInfoPtr__gizmoToState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr__gizmoToState;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_Snapshot_Public_Void_IEnumerable_1_Gizmo_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
	}
}
