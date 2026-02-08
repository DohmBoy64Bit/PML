using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000061 RID: 97
	public class GizmoHandleHoverData : global::Il2CppSystem.Object
	{
		// Token: 0x06000696 RID: 1686 RVA: 0x0003A5AC File Offset: 0x000387AC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandleHoverData()
		{
			Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandleHoverData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr);
			GizmoHandleHoverData.NativeFieldInfoPtr__handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_handleId");
			GizmoHandleHoverData.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_gizmo");
			GizmoHandleHoverData.NativeFieldInfoPtr__handleDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_handleDimension");
			GizmoHandleHoverData.NativeFieldInfoPtr__hoverRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_hoverRay");
			GizmoHandleHoverData.NativeFieldInfoPtr__hoverPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_hoverPoint");
			GizmoHandleHoverData.NativeFieldInfoPtr__hoverEnter3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, "_hoverEnter3D");
			GizmoHandleHoverData.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664248);
			GizmoHandleHoverData.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664249);
			GizmoHandleHoverData.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664250);
			GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverRay_Public_get_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664251);
			GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664252);
			GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverEnter3D_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664253);
			GizmoHandleHoverData.NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664254);
			GizmoHandleHoverData.NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr, 100664255);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0003A6F4 File Offset: 0x000388F4
		public unsafe int HandleId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0003A730 File Offset: 0x00038930
		public unsafe Gizmo Gizmo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0003A770 File Offset: 0x00038970
		public unsafe GizmoDimension HandleDimension
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr3) : null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0003A7B0 File Offset: 0x000389B0
		public unsafe Ray HoverRay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverRay_Public_get_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0003A7F0 File Offset: 0x000389F0
		public unsafe Vector3 HoverPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0003A830 File Offset: 0x00038A30
		public unsafe float HoverEnter3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr_get_HoverEnter3D_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0003A86C File Offset: 0x00038A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61516, XrefRangeEnd = 61523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmoHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoverEnter3D;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61523, XrefRangeEnd = 61530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleHoverData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmoHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hoverPt2D);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleHoverData.NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000045C0 File Offset: 0x000027C0
		public GizmoHandleHoverData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0003A948 File Offset: 0x00038B48
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x000045C9 File Offset: 0x000027C9
		public unsafe int _handleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__handleId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__handleId)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0003A970 File Offset: 0x00038B70
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x000045E4 File Offset: 0x000027E4
		public unsafe Gizmo _gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00004603 File Offset: 0x00002803
		public unsafe GizmoDimension _handleDimension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__handleDimension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__handleDimension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0003A9D0 File Offset: 0x00038BD0
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe Ray _hoverRay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverRay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverRay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0003AA00 File Offset: 0x00038C00
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00004641 File Offset: 0x00002841
		public unsafe Vector3 _hoverPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0003AA30 File Offset: 0x00038C30
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00004660 File Offset: 0x00002860
		public unsafe float _hoverEnter3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverEnter3D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleHoverData.NativeFieldInfoPtr__hoverEnter3D)) = value;
			}
		}

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr__handleId;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr__gizmo;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr__handleDimension;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr__hoverRay;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr__hoverPoint;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr__hoverEnter3D;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverRay_Public_get_Ray_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverEnter3D_Public_get_Single_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Single_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_IGizmoHandle_Vector2_0;
	}
}
