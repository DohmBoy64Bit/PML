using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D2 RID: 210
	public class GizmoRotationArc2D : global::Il2CppSystem.Object
	{
		// Token: 0x060010F1 RID: 4337 RVA: 0x000605EC File Offset: 0x0005E7EC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRotationArc2D()
		{
			Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRotationArc2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr);
			GizmoRotationArc2D.NativeFieldInfoPtr__arc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, "_arc");
			GizmoRotationArc2D.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, "_type");
			GizmoRotationArc2D.NativeFieldInfoPtr__projectionPoly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, "_projectionPoly");
			GizmoRotationArc2D.NativeFieldInfoPtr__numProjectedPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, "_numProjectedPoints");
			GizmoRotationArc2D.NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665603);
			GizmoRotationArc2D.NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665604);
			GizmoRotationArc2D.NativeMethodInfoPtr_get_Type_Public_get_ArcType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665605);
			GizmoRotationArc2D.NativeMethodInfoPtr_set_Type_Public_set_Void_ArcType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665606);
			GizmoRotationArc2D.NativeMethodInfoPtr_get_ProjectionPoly_Public_get_PolygonShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665607);
			GizmoRotationArc2D.NativeMethodInfoPtr_set_ProjectionPoly_Public_set_Void_PolygonShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665608);
			GizmoRotationArc2D.NativeMethodInfoPtr_get_NumProjectedPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665609);
			GizmoRotationArc2D.NativeMethodInfoPtr_set_NumProjectedPoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665610);
			GizmoRotationArc2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665613);
			GizmoRotationArc2D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665611);
			GizmoRotationArc2D.NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc2DLookAndFeel_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr, 100665612);
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00060748 File Offset: 0x0005E948
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00060784 File Offset: 0x0005E984
		public unsafe float RotationAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69309, RefRangeEnd = 69311, XrefRangeStart = 69307, XrefRangeEnd = 69309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x000607C4 File Offset: 0x0005E9C4
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00060800 File Offset: 0x0005EA00
		public unsafe GizmoRotationArc2D.ArcType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_get_Type_Public_get_ArcType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_set_Type_Public_set_Void_ArcType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00060840 File Offset: 0x0005EA40
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00060880 File Offset: 0x0005EA80
		public unsafe PolygonShape2D ProjectionPoly
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_get_ProjectionPoly_Public_get_PolygonShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_set_ProjectionPoly_Public_set_Void_PolygonShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x000608C4 File Offset: 0x0005EAC4
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x00060900 File Offset: 0x0005EB00
		public unsafe int NumProjectedPoints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_get_NumProjectedPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_set_NumProjectedPoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00060940 File Offset: 0x0005EB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69317, RefRangeEnd = 69319, XrefRangeStart = 69311, XrefRangeEnd = 69317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRotationArc2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRotationArc2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0006097C File Offset: 0x0005EB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69319, XrefRangeEnd = 69322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStart);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x000609E0 File Offset: 0x0005EBE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69369, RefRangeEnd = 69371, XrefRangeStart = 69322, XrefRangeEnd = 69369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookAndFeel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2D.NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc2DLookAndFeel_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00008A12 File Offset: 0x00006C12
		public GizmoRotationArc2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00060A34 File Offset: 0x0005EC34
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00008A1B File Offset: 0x00006C1B
		public unsafe ArcShape2D _arc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__arc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__arc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00060A64 File Offset: 0x0005EC64
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00008A3A File Offset: 0x00006C3A
		public unsafe GizmoRotationArc2D.ArcType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00060A8C File Offset: 0x0005EC8C
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00008A55 File Offset: 0x00006C55
		public unsafe PolygonShape2D _projectionPoly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__projectionPoly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__projectionPoly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00060ABC File Offset: 0x0005ECBC
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00008A74 File Offset: 0x00006C74
		public unsafe int _numProjectedPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__numProjectedPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2D.NativeFieldInfoPtr__numProjectedPoints)) = value;
			}
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr__arc;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr__projectionPoly;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr__numProjectedPoints;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ArcType_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ArcType_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectionPoly_Public_get_PolygonShape2D_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectionPoly_Public_set_Void_PolygonShape2D_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_get_NumProjectedPoints_Public_get_Int32_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_set_NumProjectedPoints_Public_set_Void_Int32_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Vector2_Single_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc2DLookAndFeel_Camera_0;

		// Token: 0x02000373 RID: 883
		public enum ArcType
		{
			// Token: 0x0400397E RID: 14718
			Standard,
			// Token: 0x0400397F RID: 14719
			PolyProjected
		}
	}
}
