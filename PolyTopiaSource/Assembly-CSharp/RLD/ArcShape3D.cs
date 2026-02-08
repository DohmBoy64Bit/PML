using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D6 RID: 470
	public class ArcShape3D : Shape3D
	{
		// Token: 0x06002496 RID: 9366 RVA: 0x000B1648 File Offset: 0x000AF848
		// Note: this type is marked as 'beforefieldinit'.
		static ArcShape3D()
		{
			Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ArcShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr);
			ArcShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_wireRenderDesc");
			ArcShape3D.NativeFieldInfoPtr__startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_startPoint");
			ArcShape3D.NativeFieldInfoPtr__endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_endPoint");
			ArcShape3D.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_origin");
			ArcShape3D.NativeFieldInfoPtr__plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_plane");
			ArcShape3D.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_radius");
			ArcShape3D.NativeFieldInfoPtr__aabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_aabb");
			ArcShape3D.NativeFieldInfoPtr__degreeAngleFromStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_degreeAngleFromStart");
			ArcShape3D.NativeFieldInfoPtr__forceShortestArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_forceShortestArc");
			ArcShape3D.NativeFieldInfoPtr__borderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_borderPoints");
			ArcShape3D.NativeFieldInfoPtr__numBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_numBorderPoints");
			ArcShape3D.NativeFieldInfoPtr__areBorderPointsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_areBorderPointsDirty");
			ArcShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_epsilon");
			ArcShape3D.NativeFieldInfoPtr__raycastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "_raycastMode");
			ArcShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668765);
			ArcShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668766);
			ArcShape3D.NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668767);
			ArcShape3D.NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668768);
			ArcShape3D.NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668769);
			ArcShape3D.NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668770);
			ArcShape3D.NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668771);
			ArcShape3D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668772);
			ArcShape3D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668773);
			ArcShape3D.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668774);
			ArcShape3D.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668775);
			ArcShape3D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668776);
			ArcShape3D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668777);
			ArcShape3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668778);
			ArcShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668779);
			ArcShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668780);
			ArcShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668781);
			ArcShape3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668782);
			ArcShape3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668783);
			ArcShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668784);
			ArcShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668785);
			ArcShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668786);
			ArcShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668787);
			ArcShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668788);
			ArcShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668789);
			ArcShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668790);
			ArcShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668800);
			ArcShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668791);
			ArcShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668792);
			ArcShape3D.NativeMethodInfoPtr_SetArcData_Public_Void_Plane_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668793);
			ArcShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668794);
			ArcShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668795);
			ArcShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668796);
			ArcShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668797);
			ArcShape3D.NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668798);
			ArcShape3D.NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, 100668799);
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000B1A60 File Offset: 0x000AFC60
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x000B1A9C File Offset: 0x000AFC9C
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88839, RefRangeEnd = 88840, XrefRangeStart = 88834, XrefRangeEnd = 88839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000B1ADC File Offset: 0x000AFCDC
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x000B1B18 File Offset: 0x000AFD18
		public unsafe bool ForceShortestArc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88841, RefRangeEnd = 88842, XrefRangeStart = 88840, XrefRangeEnd = 88841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000B1B58 File Offset: 0x000AFD58
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x000B1B94 File Offset: 0x000AFD94
		public unsafe float DegreeAngleFromStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88844, RefRangeEnd = 88845, XrefRangeStart = 88842, XrefRangeEnd = 88844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000B1BD4 File Offset: 0x000AFDD4
		public unsafe float AbsDegreeAngleFromStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000B1C10 File Offset: 0x000AFE10
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x000B1C4C File Offset: 0x000AFE4C
		public unsafe int NumBorderPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000B1C8C File Offset: 0x000AFE8C
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x000B1CCC File Offset: 0x000AFECC
		public unsafe Vector3 Origin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88845, XrefRangeEnd = 88850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000B1D10 File Offset: 0x000AFF10
		public unsafe Vector3 StartPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000B1D50 File Offset: 0x000AFF50
		public unsafe Vector3 EndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x000B1D90 File Offset: 0x000AFF90
		public unsafe Plane Plane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000B1DD0 File Offset: 0x000AFFD0
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000B1E10 File Offset: 0x000B0010
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x000B1E50 File Offset: 0x000B0050
		public unsafe ArcEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArcEpsilon>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000B1E94 File Offset: 0x000B0094
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x000B1ED0 File Offset: 0x000B00D0
		public unsafe float AreaEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88850, XrefRangeEnd = 88851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000B1F10 File Offset: 0x000B0110
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x000B1F4C File Offset: 0x000B014C
		public unsafe float ExtrudeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88851, XrefRangeEnd = 88852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000B1F8C File Offset: 0x000B018C
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		public unsafe float WireEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88852, XrefRangeEnd = 88853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000B2008 File Offset: 0x000B0208
		public unsafe ArcShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArcShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x000B2048 File Offset: 0x000B0248
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x000B2088 File Offset: 0x000B0288
		public unsafe Shape3DRaycastMode RaycastMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000B20CC File Offset: 0x000B02CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88859, RefRangeEnd = 88860, XrefRangeStart = 88853, XrefRangeEnd = 88859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArcShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000B2108 File Offset: 0x000B0308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88860, XrefRangeEnd = 88862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000B2144 File Offset: 0x000B0344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88862, XrefRangeEnd = 88884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000B2180 File Offset: 0x000B0380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88891, RefRangeEnd = 88892, XrefRangeStart = 88884, XrefRangeEnd = 88891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(origin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_SetArcData_Public_Void_Plane_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000B21F4 File Offset: 0x000B03F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88892, XrefRangeEnd = 88893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Raycast(Ray ray, out float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000B225C File Offset: 0x000B045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88893, XrefRangeEnd = 88894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool RaycastWire(Ray ray, out float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000B22C4 File Offset: 0x000B04C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88894, XrefRangeEnd = 88895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000B2320 File Offset: 0x000B0520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88895, XrefRangeEnd = 88896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000B236C File Offset: 0x000B056C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88900, RefRangeEnd = 88903, XrefRangeStart = 88896, XrefRangeEnd = 88900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBorderPointsFoundDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000B23A0 File Offset: 0x000B05A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 88905, RefRangeEnd = 88910, XrefRangeStart = 88903, XrefRangeEnd = 88905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateEndPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0000F027 File Offset: 0x0000D227
		public ArcShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000B23D4 File Offset: 0x000B05D4
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0000F030 File Offset: 0x0000D230
		public unsafe ArcShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000B2404 File Offset: 0x000B0604
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000F04F File Offset: 0x0000D24F
		public unsafe Vector3 _startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000B2434 File Offset: 0x000B0634
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0000F06E File Offset: 0x0000D26E
		public unsafe Vector3 _endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000B2464 File Offset: 0x000B0664
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000F08D File Offset: 0x0000D28D
		public unsafe Vector3 _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000B2494 File Offset: 0x000B0694
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		public unsafe Plane _plane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__plane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__plane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000B24C4 File Offset: 0x000B06C4
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000F0CB File Offset: 0x0000D2CB
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000B24EC File Offset: 0x000B06EC
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0000F0E6 File Offset: 0x0000D2E6
		public unsafe AABB _aabb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__aabb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__aabb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000B251C File Offset: 0x000B071C
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0000F105 File Offset: 0x0000D305
		public unsafe float _degreeAngleFromStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__degreeAngleFromStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__degreeAngleFromStart)) = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000B2544 File Offset: 0x000B0744
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0000F120 File Offset: 0x0000D320
		public unsafe bool _forceShortestArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__forceShortestArc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__forceShortestArc)) = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000B256C File Offset: 0x000B076C
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0000F13B File Offset: 0x0000D33B
		public unsafe List<Vector3> _borderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__borderPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__borderPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000B259C File Offset: 0x000B079C
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0000F15A File Offset: 0x0000D35A
		public unsafe int _numBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__numBorderPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__numBorderPoints)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000B25C4 File Offset: 0x000B07C4
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000F175 File Offset: 0x0000D375
		public unsafe bool _areBorderPointsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__areBorderPointsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__areBorderPointsDirty)) = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000B25EC File Offset: 0x000B07EC
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0000F190 File Offset: 0x0000D390
		public unsafe ArcEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000B261C File Offset: 0x000B081C
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public unsafe Shape3DRaycastMode _raycastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__raycastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.NativeFieldInfoPtr__raycastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr__startPoint;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr__endPoint;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr__plane;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr__aabb;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr__degreeAngleFromStart;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr__forceShortestArc;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr__borderPoints;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr__numBorderPoints;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr__areBorderPointsDirty;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr__raycastMode;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_get_Plane_Public_get_Plane_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_SetArcData_Public_Void_Plane_Vector3_Vector3_Single_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0;

		// Token: 0x020003B1 RID: 945
		public enum WireRenderFlags
		{
			// Token: 0x04003AED RID: 15085
			None,
			// Token: 0x04003AEE RID: 15086
			ExtremitiesBorder,
			// Token: 0x04003AEF RID: 15087
			ArcBorder,
			// Token: 0x04003AF0 RID: 15088
			All
		}

		// Token: 0x020003B2 RID: 946
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004BF1 RID: 19441 RVA: 0x0014BFB0 File Offset: 0x0014A1B0
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr);
				ArcShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireFlags");
				ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr, 100668801);
				ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr, 100668802);
				ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr, 100668803);
			}

			// Token: 0x17001993 RID: 6547
			// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0014C02C File Offset: 0x0014A22C
			// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x0014C068 File Offset: 0x0014A268
			public unsafe ArcShape3D.WireRenderFlags WireFlags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004BF4 RID: 19444 RVA: 0x0014C0A8 File Offset: 0x0014A2A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88771, RefRangeEnd = 88772, XrefRangeStart = 88771, XrefRangeEnd = 88772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BF5 RID: 19445 RVA: 0x0001C7D6 File Offset: 0x0001A9D6
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001992 RID: 6546
			// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x0014C0E4 File Offset: 0x0014A2E4
			// (set) Token: 0x06004BF7 RID: 19447 RVA: 0x0001C7DF File Offset: 0x0001A9DF
			public unsafe ArcShape3D.WireRenderFlags _wireFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags)) = value;
				}
			}

			// Token: 0x04003AF1 RID: 15089
			private static readonly IntPtr NativeFieldInfoPtr__wireFlags;

			// Token: 0x04003AF2 RID: 15090
			private static readonly IntPtr NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0;

			// Token: 0x04003AF3 RID: 15091
			private static readonly IntPtr NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0;

			// Token: 0x04003AF4 RID: 15092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
