using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D5 RID: 469
	public class ArcShape2D : Shape2D
	{
		// Token: 0x06002462 RID: 9314 RVA: 0x000B0A60 File Offset: 0x000AEC60
		// Note: this type is marked as 'beforefieldinit'.
		static ArcShape2D()
		{
			Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ArcShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr);
			ArcShape2D.NativeFieldInfoPtr__borderRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_borderRenderDesc");
			ArcShape2D.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_rect");
			ArcShape2D.NativeFieldInfoPtr__forceShortestArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_forceShortestArc");
			ArcShape2D.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_radius");
			ArcShape2D.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_origin");
			ArcShape2D.NativeFieldInfoPtr__startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_startPoint");
			ArcShape2D.NativeFieldInfoPtr__endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_endPoint");
			ArcShape2D.NativeFieldInfoPtr__borderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_borderPoints");
			ArcShape2D.NativeFieldInfoPtr__degreeAngleFromStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_degreeAngleFromStart");
			ArcShape2D.NativeFieldInfoPtr__numBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_numBorderPoints");
			ArcShape2D.NativeFieldInfoPtr__areBorderPointsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_areBorderPointsDirty");
			ArcShape2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "_epsilon");
			ArcShape2D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668736);
			ArcShape2D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668737);
			ArcShape2D.NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668738);
			ArcShape2D.NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668739);
			ArcShape2D.NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668740);
			ArcShape2D.NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668741);
			ArcShape2D.NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668742);
			ArcShape2D.NativeMethodInfoPtr_get_Origin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668743);
			ArcShape2D.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668744);
			ArcShape2D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668745);
			ArcShape2D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668746);
			ArcShape2D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668747);
			ArcShape2D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668748);
			ArcShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668749);
			ArcShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668750);
			ArcShape2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668751);
			ArcShape2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668752);
			ArcShape2D.NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668753);
			ArcShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668761);
			ArcShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668754);
			ArcShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668755);
			ArcShape2D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668756);
			ArcShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668757);
			ArcShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668758);
			ArcShape2D.NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668759);
			ArcShape2D.NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, 100668760);
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000B0D88 File Offset: 0x000AEF88
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x000B0DC4 File Offset: 0x000AEFC4
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88772, XrefRangeEnd = 88774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000B0E04 File Offset: 0x000AF004
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x000B0E40 File Offset: 0x000AF040
		public unsafe bool ForceShortestArc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88774, XrefRangeEnd = 88775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000B0E80 File Offset: 0x000AF080
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x000B0EBC File Offset: 0x000AF0BC
		public unsafe float DegreeAngleFromStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88777, RefRangeEnd = 88778, XrefRangeStart = 88775, XrefRangeEnd = 88777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000B0EFC File Offset: 0x000AF0FC
		public unsafe float AbsDegreeAngleFromStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000B0F38 File Offset: 0x000AF138
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x000B0F78 File Offset: 0x000AF178
		public unsafe Vector2 Origin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_Origin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88780, RefRangeEnd = 88781, XrefRangeStart = 88778, XrefRangeEnd = 88780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x000B0FBC File Offset: 0x000AF1BC
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x000B0FF8 File Offset: 0x000AF1F8
		public unsafe int NumBorderPoints
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 88781, RefRangeEnd = 88785, XrefRangeStart = 88781, XrefRangeEnd = 88781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x000B1038 File Offset: 0x000AF238
		public unsafe Vector2 StartPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000B1078 File Offset: 0x000AF278
		public unsafe Vector2 EndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000B10B8 File Offset: 0x000AF2B8
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x000B10F8 File Offset: 0x000AF2F8
		public unsafe ArcEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000B113C File Offset: 0x000AF33C
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x000B1178 File Offset: 0x000AF378
		public unsafe float AreaEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88785, XrefRangeEnd = 88786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000B11B8 File Offset: 0x000AF3B8
		public unsafe ArcShape2D.BorderRenderDescriptor BorderRenderDesc
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArcShape2D.BorderRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88792, RefRangeEnd = 88793, XrefRangeStart = 88786, XrefRangeEnd = 88792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArcShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x000B1234 File Offset: 0x000AF434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88793, XrefRangeEnd = 88795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x000B1284 File Offset: 0x000AF484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88795, XrefRangeEnd = 88813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x000B12D4 File Offset: 0x000AF4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88815, RefRangeEnd = 88816, XrefRangeStart = 88813, XrefRangeEnd = 88815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArcData(Vector2 startPoint, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000B1324 File Offset: 0x000AF524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88816, XrefRangeEnd = 88817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x000B1370 File Offset: 0x000AF570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88817, XrefRangeEnd = 88818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArcShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000B13C8 File Offset: 0x000AF5C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88821, RefRangeEnd = 88824, XrefRangeStart = 88818, XrefRangeEnd = 88821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBorderPointsFoundDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000B13FC File Offset: 0x000AF5FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 88829, RefRangeEnd = 88834, XrefRangeStart = 88824, XrefRangeEnd = 88829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateEndPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0000EEBE File Offset: 0x0000D0BE
		public ArcShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000B1430 File Offset: 0x000AF630
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0000EEC7 File Offset: 0x0000D0C7
		public unsafe ArcShape2D.BorderRenderDescriptor _borderRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__borderRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcShape2D.BorderRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__borderRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000B1460 File Offset: 0x000AF660
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x0000EEE6 File Offset: 0x0000D0E6
		public unsafe Rect _rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000B1490 File Offset: 0x000AF690
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0000EF05 File Offset: 0x0000D105
		public unsafe bool _forceShortestArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__forceShortestArc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__forceShortestArc)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000B14B8 File Offset: 0x000AF6B8
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x0000EF20 File Offset: 0x0000D120
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000B14E0 File Offset: 0x000AF6E0
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0000EF3B File Offset: 0x0000D13B
		public unsafe Vector2 _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000B1510 File Offset: 0x000AF710
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0000EF5A File Offset: 0x0000D15A
		public unsafe Vector2 _startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000B1540 File Offset: 0x000AF740
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x0000EF79 File Offset: 0x0000D179
		public unsafe Vector2 _endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000B1570 File Offset: 0x000AF770
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x0000EF98 File Offset: 0x0000D198
		public unsafe List<Vector2> _borderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__borderPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__borderPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x000B15A0 File Offset: 0x000AF7A0
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0000EFB7 File Offset: 0x0000D1B7
		public unsafe float _degreeAngleFromStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__degreeAngleFromStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__degreeAngleFromStart)) = value;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x000B15C8 File Offset: 0x000AF7C8
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x0000EFD2 File Offset: 0x0000D1D2
		public unsafe int _numBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__numBorderPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__numBorderPoints)) = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000B15F0 File Offset: 0x000AF7F0
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x0000EFED File Offset: 0x0000D1ED
		public unsafe bool _areBorderPointsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__areBorderPointsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__areBorderPointsDirty)) = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000B1618 File Offset: 0x000AF818
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x0000F008 File Offset: 0x0000D208
		public unsafe ArcEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr__borderRenderDesc;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr__rect;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr__forceShortestArc;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr__startPoint;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr__endPoint;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeFieldInfoPtr__borderPoints;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr__degreeAngleFromStart;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr__numBorderPoints;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr__areBorderPointsDirty;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceShortestArc_Public_get_Boolean_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_set_ForceShortestArc_Public_set_Void_Boolean_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_get_DegreeAngleFromStart_Public_get_Single_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_set_DegreeAngleFromStart_Public_set_Void_Single_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsDegreeAngleFromStart_Public_get_Single_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_Vector2_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector2_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_ArcEpsilon_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ArcEpsilon_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_SetArcData_Public_Void_Vector2_Single_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_OnBorderPointsFoundDirty_Private_Void_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEndPoint_Private_Void_0;

		// Token: 0x020003AF RID: 943
		public enum BorderRenderFlags
		{
			// Token: 0x04003AE4 RID: 15076
			None,
			// Token: 0x04003AE5 RID: 15077
			ExtremitiesBorder,
			// Token: 0x04003AE6 RID: 15078
			ArcBorder,
			// Token: 0x04003AE7 RID: 15079
			All
		}

		// Token: 0x020003B0 RID: 944
		public class BorderRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004BEA RID: 19434 RVA: 0x0014BE54 File Offset: 0x0014A054
			// Note: this type is marked as 'beforefieldinit'.
			static BorderRenderDescriptor()
			{
				Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcShape2D>.NativeClassPtr, "BorderRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr);
				ArcShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr, "_borderFlags");
				ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_BorderFlags_Public_get_BorderRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr, 100668762);
				ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_BorderFlags_Public_set_Void_BorderRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr, 100668763);
				ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr, 100668764);
			}

			// Token: 0x17001991 RID: 6545
			// (get) Token: 0x06004BEB RID: 19435 RVA: 0x0014BED0 File Offset: 0x0014A0D0
			// (set) Token: 0x06004BEC RID: 19436 RVA: 0x0014BF0C File Offset: 0x0014A10C
			public unsafe ArcShape2D.BorderRenderFlags BorderFlags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_BorderFlags_Public_get_BorderRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_BorderFlags_Public_set_Void_BorderRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004BED RID: 19437 RVA: 0x0014BF4C File Offset: 0x0014A14C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88771, RefRangeEnd = 88772, XrefRangeStart = 88770, XrefRangeEnd = 88771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BorderRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcShape2D.BorderRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcShape2D.BorderRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BEE RID: 19438 RVA: 0x0001C7B2 File Offset: 0x0001A9B2
			public BorderRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001990 RID: 6544
			// (get) Token: 0x06004BEF RID: 19439 RVA: 0x0014BF88 File Offset: 0x0014A188
			// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x0001C7BB File Offset: 0x0001A9BB
			public unsafe ArcShape2D.BorderRenderFlags _borderFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArcShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderFlags)) = value;
				}
			}

			// Token: 0x04003AE8 RID: 15080
			private static readonly IntPtr NativeFieldInfoPtr__borderFlags;

			// Token: 0x04003AE9 RID: 15081
			private static readonly IntPtr NativeMethodInfoPtr_get_BorderFlags_Public_get_BorderRenderFlags_0;

			// Token: 0x04003AEA RID: 15082
			private static readonly IntPtr NativeMethodInfoPtr_set_BorderFlags_Public_set_Void_BorderRenderFlags_0;

			// Token: 0x04003AEB RID: 15083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
