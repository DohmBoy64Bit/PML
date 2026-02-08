using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020D RID: 525
	public class ObjectSurfaceSnap : global::Il2CppSystem.Object
	{
		// Token: 0x060029A2 RID: 10658 RVA: 0x000C65CC File Offset: 0x000C47CC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSurfaceSnap()
		{
			Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSurfaceSnap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr);
			ObjectSurfaceSnap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669667);
			ObjectSurfaceSnap.NativeMethodInfoPtr_SnapHierarchy_Public_Static_SnapResult_GameObject_SnapConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669662);
			ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_OBB_Plane_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669663);
			ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_AABB_Plane_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669664);
			ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateEmbedVector_Public_Static_Vector3_List_1_Vector3_GameObject_Vector3_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669665);
			ObjectSurfaceSnap.NativeMethodInfoPtr_CreateSurfaceRaycaster_Private_Static_SurfaceRaycaster_Type_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, 100669666);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000C6674 File Offset: 0x000C4874
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSurfaceSnap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000C66B0 File Offset: 0x000C48B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92625, RefRangeEnd = 92627, XrefRangeStart = 92426, XrefRangeEnd = 92625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectSurfaceSnap.SnapResult SnapHierarchy(GameObject root, ObjectSurfaceSnap.SnapConfig snapConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(snapConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr_SnapHierarchy_Public_Static_SnapResult_GameObject_SnapConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000C6708 File Offset: 0x000C4908
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 92633, RefRangeEnd = 92643, XrefRangeStart = 92627, XrefRangeEnd = 92633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalculateSitOnSurfaceOffset(OBB obb, Plane surfacePlane, float offsetFromSurface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfacePlane);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetFromSurface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_OBB_Plane_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000C676C File Offset: 0x000C496C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92649, RefRangeEnd = 92650, XrefRangeStart = 92643, XrefRangeEnd = 92649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalculateSitOnSurfaceOffset(AABB aabb, Plane surfacePlane, float offsetFromSurface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfacePlane);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetFromSurface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_AABB_Plane_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000C67D0 File Offset: 0x000C49D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92670, RefRangeEnd = 92672, XrefRangeStart = 92650, XrefRangeEnd = 92670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalculateEmbedVector(List<Vector3> embedPoints, GameObject embedSurface, Vector3 embedDirection, ObjectSurfaceSnap.Type surfaceType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(embedPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(embedSurface);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(embedDirection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr_CalculateEmbedVector_Public_Static_Vector3_List_1_Vector3_GameObject_Vector3_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000C6848 File Offset: 0x000C4A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92673, RefRangeEnd = 92675, XrefRangeStart = 92672, XrefRangeEnd = 92673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectSurfaceSnap.SurfaceRaycaster CreateSurfaceRaycaster(ObjectSurfaceSnap.Type surfaceType, GameObject surfaceObject, bool raycastReverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref surfaceType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref raycastReverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.NativeMethodInfoPtr_CreateSurfaceRaycaster_Private_Static_SurfaceRaycaster_Type_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSurfaceSnap.SurfaceRaycaster>(intPtr3) : null;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00010664 File Offset: 0x0000E864
		public ObjectSurfaceSnap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_SnapHierarchy_Public_Static_SnapResult_GameObject_SnapConfig_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_OBB_Plane_Single_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSitOnSurfaceOffset_Public_Static_Vector3_AABB_Plane_Single_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEmbedVector_Public_Static_Vector3_List_1_Vector3_GameObject_Vector3_Type_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_CreateSurfaceRaycaster_Private_Static_SurfaceRaycaster_Type_GameObject_Boolean_0;

		// Token: 0x020003CC RID: 972
		public enum Type
		{
			// Token: 0x04003B90 RID: 15248
			UnityTerrain,
			// Token: 0x04003B91 RID: 15249
			Mesh,
			// Token: 0x04003B92 RID: 15250
			TerrainMesh,
			// Token: 0x04003B93 RID: 15251
			SphericalMesh,
			// Token: 0x04003B94 RID: 15252
			SceneGrid
		}

		// Token: 0x020003CD RID: 973
		public sealed class SnapConfig : ValueType
		{
			// Token: 0x06004CA2 RID: 19618 RVA: 0x0014E004 File Offset: 0x0014C204
			// Note: this type is marked as 'beforefieldinit'.
			static SnapConfig()
			{
				Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, "SnapConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr);
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "AlignAxis");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignmentAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "AlignmentAxis");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "SurfaceType");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_OffsetFromSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "OffsetFromSurface");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "SurfaceHitPoint");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "SurfaceHitNormal");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "SurfaceHitPlane");
				ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, "SurfaceObject");
				ObjectSurfaceSnap.SnapConfig.NativeMethodInfoPtr_IsSurfaceMesh_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr, 100669668);
			}

			// Token: 0x06004CA3 RID: 19619 RVA: 0x0014E0E4 File Offset: 0x0014C2E4
			[CallerCount(0)]
			public unsafe bool IsSurfaceMesh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.SnapConfig.NativeMethodInfoPtr_IsSurfaceMesh_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004CA4 RID: 19620 RVA: 0x0001CD85 File Offset: 0x0001AF85
			public SnapConfig(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004CA5 RID: 19621 RVA: 0x0001CD8E File Offset: 0x0001AF8E
			public SnapConfig()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapConfig>.NativeClassPtr))
			{
			}

			// Token: 0x170019D4 RID: 6612
			// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x0014E128 File Offset: 0x0014C328
			// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
			public unsafe bool AlignAxis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignAxis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignAxis)) = value;
				}
			}

			// Token: 0x170019D5 RID: 6613
			// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x0014E150 File Offset: 0x0014C350
			// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x0001CDBB File Offset: 0x0001AFBB
			public unsafe TransformAxis AlignmentAxis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignmentAxis);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransformAxis>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_AlignmentAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D6 RID: 6614
			// (get) Token: 0x06004CAA RID: 19626 RVA: 0x0014E180 File Offset: 0x0014C380
			// (set) Token: 0x06004CAB RID: 19627 RVA: 0x0001CDDA File Offset: 0x0001AFDA
			public unsafe ObjectSurfaceSnap.Type SurfaceType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceType)) = value;
				}
			}

			// Token: 0x170019D7 RID: 6615
			// (get) Token: 0x06004CAC RID: 19628 RVA: 0x0014E1A8 File Offset: 0x0014C3A8
			// (set) Token: 0x06004CAD RID: 19629 RVA: 0x0001CDF5 File Offset: 0x0001AFF5
			public unsafe float OffsetFromSurface
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_OffsetFromSurface);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_OffsetFromSurface)) = value;
				}
			}

			// Token: 0x170019D8 RID: 6616
			// (get) Token: 0x06004CAE RID: 19630 RVA: 0x0014E1D0 File Offset: 0x0014C3D0
			// (set) Token: 0x06004CAF RID: 19631 RVA: 0x0001CE10 File Offset: 0x0001B010
			public unsafe Vector3 SurfaceHitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D9 RID: 6617
			// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x0014E200 File Offset: 0x0014C400
			// (set) Token: 0x06004CB1 RID: 19633 RVA: 0x0001CE2F File Offset: 0x0001B02F
			public unsafe Vector3 SurfaceHitNormal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitNormal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DA RID: 6618
			// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x0014E230 File Offset: 0x0014C430
			// (set) Token: 0x06004CB3 RID: 19635 RVA: 0x0001CE4E File Offset: 0x0001B04E
			public unsafe Plane SurfaceHitPlane
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPlane);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceHitPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DB RID: 6619
			// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x0014E260 File Offset: 0x0014C460
			// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x0001CE6D File Offset: 0x0001B06D
			public unsafe GameObject SurfaceObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SnapConfig.NativeFieldInfoPtr_SurfaceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B95 RID: 15253
			private static readonly IntPtr NativeFieldInfoPtr_AlignAxis;

			// Token: 0x04003B96 RID: 15254
			private static readonly IntPtr NativeFieldInfoPtr_AlignmentAxis;

			// Token: 0x04003B97 RID: 15255
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

			// Token: 0x04003B98 RID: 15256
			private static readonly IntPtr NativeFieldInfoPtr_OffsetFromSurface;

			// Token: 0x04003B99 RID: 15257
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceHitPoint;

			// Token: 0x04003B9A RID: 15258
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceHitNormal;

			// Token: 0x04003B9B RID: 15259
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceHitPlane;

			// Token: 0x04003B9C RID: 15260
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceObject;

			// Token: 0x04003B9D RID: 15261
			private static readonly IntPtr NativeMethodInfoPtr_IsSurfaceMesh_Public_Boolean_0;
		}

		// Token: 0x020003CE RID: 974
		[StructLayout(2)]
		public struct SnapResult
		{
			// Token: 0x06004CB6 RID: 19638 RVA: 0x0014E290 File Offset: 0x0014C490
			// Note: this type is marked as 'beforefieldinit'.
			static SnapResult()
			{
				Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, "SnapResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr);
				ObjectSurfaceSnap.SnapResult.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr, "Success");
				ObjectSurfaceSnap.SnapResult.NativeFieldInfoPtr_SittingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr, "SittingPlane");
				ObjectSurfaceSnap.SnapResult.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr, "SittingPoint");
				ObjectSurfaceSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr, 100669669);
			}

			// Token: 0x06004CB7 RID: 19639 RVA: 0x0014E30C File Offset: 0x0014C50C
			[CallerCount(0)]
			public unsafe SnapResult(Plane sittingPlane, Vector3 sittingPoint)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sittingPlane);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sittingPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_Plane_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CB8 RID: 19640 RVA: 0x0001CE8C File Offset: 0x0001B08C
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectSurfaceSnap.SnapResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04003B9E RID: 15262
			private static readonly IntPtr NativeFieldInfoPtr_Success;

			// Token: 0x04003B9F RID: 15263
			private static readonly IntPtr NativeFieldInfoPtr_SittingPlane;

			// Token: 0x04003BA0 RID: 15264
			private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

			// Token: 0x04003BA1 RID: 15265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Plane_Vector3_0;

			// Token: 0x04003BA2 RID: 15266
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool Success;

			// Token: 0x04003BA3 RID: 15267
			[FieldOffset(4)]
			public IntPtr SittingPlane;

			// Token: 0x04003BA4 RID: 15268
			[FieldOffset(20)]
			public IntPtr SittingPoint;
		}

		// Token: 0x020003CF RID: 975
		public class SurfaceRaycaster : global::Il2CppSystem.Object
		{
			// Token: 0x06004CB9 RID: 19641 RVA: 0x0014E354 File Offset: 0x0014C554
			// Note: this type is marked as 'beforefieldinit'.
			static SurfaceRaycaster()
			{
				Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, "SurfaceRaycaster");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr);
				ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__surfaceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr, "_surfaceObject");
				ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__raycastReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr, "_raycastReverse");
				ObjectSurfaceSnap.SurfaceRaycaster.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr, 100669670);
				ObjectSurfaceSnap.SurfaceRaycaster.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_GameObjectRayHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr, 100669671);
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x0014E3D0 File Offset: 0x0014C5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92417, XrefRangeEnd = 92419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSurfaceSnap.SurfaceRaycaster>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(surfaceObject);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref raycastReverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.SurfaceRaycaster.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CBB RID: 19643 RVA: 0x0014E42C File Offset: 0x0014C62C
			[CallerCount(0)]
			public unsafe virtual GameObjectRayHit Raycast(Ray ray)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSurfaceSnap.SurfaceRaycaster.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_GameObjectRayHit_Ray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
				}
			}

			// Token: 0x06004CBC RID: 19644 RVA: 0x0001CE9E File Offset: 0x0001B09E
			public SurfaceRaycaster(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019DC RID: 6620
			// (get) Token: 0x06004CBD RID: 19645 RVA: 0x0014E488 File Offset: 0x0014C688
			// (set) Token: 0x06004CBE RID: 19646 RVA: 0x0001CEA7 File Offset: 0x0001B0A7
			public unsafe GameObject _surfaceObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__surfaceObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__surfaceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DD RID: 6621
			// (get) Token: 0x06004CBF RID: 19647 RVA: 0x0014E4B8 File Offset: 0x0014C6B8
			// (set) Token: 0x06004CC0 RID: 19648 RVA: 0x0001CEC6 File Offset: 0x0001B0C6
			public unsafe bool _raycastReverse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__raycastReverse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSurfaceSnap.SurfaceRaycaster.NativeFieldInfoPtr__raycastReverse)) = value;
				}
			}

			// Token: 0x04003BA5 RID: 15269
			private static readonly IntPtr NativeFieldInfoPtr__surfaceObject;

			// Token: 0x04003BA6 RID: 15270
			private static readonly IntPtr NativeFieldInfoPtr__raycastReverse;

			// Token: 0x04003BA7 RID: 15271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0;

			// Token: 0x04003BA8 RID: 15272
			private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_GameObjectRayHit_Ray_0;
		}

		// Token: 0x020003D0 RID: 976
		public class MeshSurfaceRaycaster : ObjectSurfaceSnap.SurfaceRaycaster
		{
			// Token: 0x06004CC1 RID: 19649 RVA: 0x0014E4E0 File Offset: 0x0014C6E0
			// Note: this type is marked as 'beforefieldinit'.
			static MeshSurfaceRaycaster()
			{
				Il2CppClassPointerStore<ObjectSurfaceSnap.MeshSurfaceRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSurfaceSnap>.NativeClassPtr, "MeshSurfaceRaycaster");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSurfaceSnap.MeshSurfaceRaycaster>.NativeClassPtr);
				ObjectSurfaceSnap.MeshSurfaceRaycaster.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.MeshSurfaceRaycaster>.NativeClassPtr, 100669672);
				ObjectSurfaceSnap.MeshSurfaceRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_GameObjectRayHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSurfaceSnap.MeshSurfaceRaycaster>.NativeClassPtr, 100669673);
			}

			// Token: 0x06004CC2 RID: 19650 RVA: 0x0014E534 File Offset: 0x0014C734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSurfaceSnap.MeshSurfaceRaycaster>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(surfaceObject);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref raycastReverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSurfaceSnap.MeshSurfaceRaycaster.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CC3 RID: 19651 RVA: 0x0014E590 File Offset: 0x0014C790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92419, XrefRangeEnd = 92426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override GameObjectRayHit Raycast(Ray ray)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSurfaceSnap.MeshSurfaceRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_GameObjectRayHit_Ray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
				}
			}

			// Token: 0x06004CC4 RID: 19652 RVA: 0x0001CEE1 File Offset: 0x0001B0E1
			public MeshSurfaceRaycaster(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003BA9 RID: 15273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Boolean_0;

			// Token: 0x04003BAA RID: 15274
			private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_GameObjectRayHit_Ray_0;
		}
	}
}
