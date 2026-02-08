using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E0 RID: 480
	public class PolygonShape2D : Shape2D
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x000B9B70 File Offset: 0x000B7D70
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonShape2D()
		{
			Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PolygonShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr);
			PolygonShape2D.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_rect");
			PolygonShape2D.NativeFieldInfoPtr__isRectDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_isRectDirty");
			PolygonShape2D.NativeFieldInfoPtr__isClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_isClosed");
			PolygonShape2D.NativeFieldInfoPtr__cwPolyPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_cwPolyPoints");
			PolygonShape2D.NativeFieldInfoPtr__thickCwBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_thickCwBorderPoints");
			PolygonShape2D.NativeFieldInfoPtr__isThickBorderDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_isThickBorderDirty");
			PolygonShape2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_epsilon");
			PolygonShape2D.NativeFieldInfoPtr__ptContainMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_ptContainMode");
			PolygonShape2D.NativeFieldInfoPtr__borderRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "_borderRenderDesc");
			PolygonShape2D.NativeMethodInfoPtr_get_NumPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669124);
			PolygonShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669125);
			PolygonShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669126);
			PolygonShape2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669127);
			PolygonShape2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669128);
			PolygonShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669129);
			PolygonShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669130);
			PolygonShape2D.NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669131);
			PolygonShape2D.NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669132);
			PolygonShape2D.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669133);
			PolygonShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669134);
			PolygonShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669135);
			PolygonShape2D.NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669136);
			PolygonShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669148);
			PolygonShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669137);
			PolygonShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669138);
			PolygonShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669139);
			PolygonShape2D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669140);
			PolygonShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669141);
			PolygonShape2D.NativeMethodInfoPtr_CopyPoints_Public_Void_PolygonShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669142);
			PolygonShape2D.NativeMethodInfoPtr_SetClockwisePoints_Public_Void_List_1_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669143);
			PolygonShape2D.NativeMethodInfoPtr_MakeSphereBorder_Public_Void_Vector3_Single_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669144);
			PolygonShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669145);
			PolygonShape2D.NativeMethodInfoPtr_CalculateRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669146);
			PolygonShape2D.NativeMethodInfoPtr_CalculateThickBorderPoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, 100669147);
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000B9E48 File Offset: 0x000B8048
		public unsafe int NumPoints
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90074, XrefRangeEnd = 90075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_NumPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000B9E84 File Offset: 0x000B8084
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x000B9EC4 File Offset: 0x000B80C4
		public unsafe PolygonEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_PolygonEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolygonEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PolygonEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x000B9F08 File Offset: 0x000B8108
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x000B9F44 File Offset: 0x000B8144
		public unsafe float AreaEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89461, RefRangeEnd = 89463, XrefRangeStart = 89461, XrefRangeEnd = 89463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x000B9F84 File Offset: 0x000B8184
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x000B9FC0 File Offset: 0x000B81C0
		public unsafe float WireEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90076, RefRangeEnd = 90078, XrefRangeStart = 90075, XrefRangeEnd = 90076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x000BA000 File Offset: 0x000B8200
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x000BA03C File Offset: 0x000B823C
		public unsafe float ThickWireEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90079, RefRangeEnd = 90080, XrefRangeStart = 90078, XrefRangeEnd = 90079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x000BA07C File Offset: 0x000B827C
		public unsafe bool IsClosed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x000BA0B8 File Offset: 0x000B82B8
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x000BA0F8 File Offset: 0x000B82F8
		public unsafe Shape2DPtContainMode PtContainMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90080, RefRangeEnd = 90081, XrefRangeStart = 90080, XrefRangeEnd = 90080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x000BA13C File Offset: 0x000B833C
		public unsafe PolygonShape2D.BorderRenderDescriptor BorderRenderDesc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolygonShape2D.BorderRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000BA17C File Offset: 0x000B837C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90099, RefRangeEnd = 90102, XrefRangeStart = 90081, XrefRangeEnd = 90099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000BA1B8 File Offset: 0x000B83B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90125, RefRangeEnd = 90126, XrefRangeStart = 90102, XrefRangeEnd = 90125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000BA208 File Offset: 0x000B8408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90126, XrefRangeEnd = 90130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PolygonShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000BA258 File Offset: 0x000B8458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90130, XrefRangeEnd = 90138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PolygonShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000BA2A8 File Offset: 0x000B84A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90144, RefRangeEnd = 90145, XrefRangeStart = 90138, XrefRangeEnd = 90144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000BA2E8 File Offset: 0x000B84E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90145, XrefRangeEnd = 90146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PolygonShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000BA334 File Offset: 0x000B8534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90150, RefRangeEnd = 90152, XrefRangeStart = 90146, XrefRangeEnd = 90150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPoints(PolygonShape2D sourcePoly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourcePoly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_CopyPoints_Public_Void_PolygonShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000BA378 File Offset: 0x000B8578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90163, RefRangeEnd = 90164, XrefRangeStart = 90152, XrefRangeEnd = 90163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cwBorderPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_SetClockwisePoints_Public_Void_List_1_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000BA3C8 File Offset: 0x000B85C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90180, RefRangeEnd = 90181, XrefRangeStart = 90164, XrefRangeEnd = 90180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeSphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_MakeSphereBorder_Public_Void_Vector3_Single_Int32_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000BA43C File Offset: 0x000B863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90181, XrefRangeEnd = 90183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PolygonShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000BA494 File Offset: 0x000B8694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90183, XrefRangeEnd = 90184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_CalculateRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000BA4C8 File Offset: 0x000B86C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90186, RefRangeEnd = 90187, XrefRangeStart = 90184, XrefRangeEnd = 90186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateThickBorderPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.NativeMethodInfoPtr_CalculateThickBorderPoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public PolygonShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000BA4FC File Offset: 0x000B86FC
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x0000F805 File Offset: 0x0000DA05
		public unsafe Rect _rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000BA52C File Offset: 0x000B872C
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x0000F824 File Offset: 0x0000DA24
		public unsafe bool _isRectDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isRectDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isRectDirty)) = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000BA554 File Offset: 0x000B8754
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x0000F83F File Offset: 0x0000DA3F
		public unsafe bool _isClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isClosed)) = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000BA57C File Offset: 0x000B877C
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0000F85A File Offset: 0x0000DA5A
		public unsafe List<Vector2> _cwPolyPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__cwPolyPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__cwPolyPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000BA5AC File Offset: 0x000B87AC
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0000F879 File Offset: 0x0000DA79
		public unsafe List<Vector2> _thickCwBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__thickCwBorderPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__thickCwBorderPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000BA5DC File Offset: 0x000B87DC
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x0000F898 File Offset: 0x0000DA98
		public unsafe bool _isThickBorderDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isThickBorderDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__isThickBorderDirty)) = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000BA604 File Offset: 0x000B8804
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x0000F8B3 File Offset: 0x0000DAB3
		public unsafe PolygonEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000BA634 File Offset: 0x000B8834
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x0000F8D2 File Offset: 0x0000DAD2
		public unsafe Shape2DPtContainMode _ptContainMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__ptContainMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__ptContainMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000BA664 File Offset: 0x000B8864
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x0000F8F1 File Offset: 0x0000DAF1
		public unsafe PolygonShape2D.BorderRenderDescriptor _borderRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__borderRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D.BorderRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.NativeFieldInfoPtr__borderRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeFieldInfoPtr__rect;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeFieldInfoPtr__isRectDirty;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeFieldInfoPtr__isClosed;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr__cwPolyPoints;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeFieldInfoPtr__thickCwBorderPoints;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr__isThickBorderDirty;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeFieldInfoPtr__ptContainMode;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeFieldInfoPtr__borderRenderDesc;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_get_NumPoints_Public_get_Int32_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_PolygonEpsilon_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PolygonEpsilon_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderRenderDesc_Public_get_BorderRenderDescriptor_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_CopyPoints_Public_Void_PolygonShape2D_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_SetClockwisePoints_Public_Void_List_1_Vector2_Boolean_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_MakeSphereBorder_Public_Void_Vector3_Single_Int32_Camera_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRect_Private_Void_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_CalculateThickBorderPoints_Private_Void_0;

		// Token: 0x020003B7 RID: 951
		public enum ThickBorderFillMode
		{
			// Token: 0x04003B0D RID: 15117
			Filled,
			// Token: 0x04003B0E RID: 15118
			Border
		}

		// Token: 0x020003B8 RID: 952
		public class BorderRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004C12 RID: 19474 RVA: 0x0014C664 File Offset: 0x0014A864
			// Note: this type is marked as 'beforefieldinit'.
			static BorderRenderDescriptor()
			{
				Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PolygonShape2D>.NativeClassPtr, "BorderRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr);
				PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, "_borderType");
				PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, "_thickness");
				PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, "_direction");
				PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, "_fillMode");
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_BorderType_Public_get_Shape2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669149);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_BorderType_Public_set_Void_Shape2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669150);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_Thickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669151);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669152);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_Direction_Public_get_Shape2DBorderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669153);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_Direction_Public_set_Void_Shape2DBorderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669154);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_FillMode_Public_get_ThickBorderFillMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669155);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_FillMode_Public_set_Void_ThickBorderFillMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669156);
				PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr, 100669157);
			}

			// Token: 0x170019A2 RID: 6562
			// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0014C794 File Offset: 0x0014A994
			// (set) Token: 0x06004C14 RID: 19476 RVA: 0x0014C7D4 File Offset: 0x0014A9D4
			public unsafe Shape2DBorderType BorderType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_BorderType_Public_get_Shape2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2DBorderType>(intPtr3) : null;
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_BorderType_Public_set_Void_Shape2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019A3 RID: 6563
			// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0014C818 File Offset: 0x0014AA18
			// (set) Token: 0x06004C16 RID: 19478 RVA: 0x0014C854 File Offset: 0x0014AA54
			public unsafe float Thickness
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_Thickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 89737, RefRangeEnd = 89740, XrefRangeStart = 89737, XrefRangeEnd = 89740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019A4 RID: 6564
			// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0014C894 File Offset: 0x0014AA94
			// (set) Token: 0x06004C18 RID: 19480 RVA: 0x0014C8D4 File Offset: 0x0014AAD4
			public unsafe Shape2DBorderDirection Direction
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_Direction_Public_get_Shape2DBorderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2DBorderDirection>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_Direction_Public_set_Void_Shape2DBorderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019A5 RID: 6565
			// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0014C918 File Offset: 0x0014AB18
			// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0014C954 File Offset: 0x0014AB54
			public unsafe PolygonShape2D.ThickBorderFillMode FillMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_get_FillMode_Public_get_ThickBorderFillMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr_set_FillMode_Public_set_Void_ThickBorderFillMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C1B RID: 19483 RVA: 0x0014C994 File Offset: 0x0014AB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90073, XrefRangeEnd = 90074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BorderRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonShape2D.BorderRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonShape2D.BorderRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C1C RID: 19484 RVA: 0x0001C893 File Offset: 0x0001AA93
			public BorderRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700199E RID: 6558
			// (get) Token: 0x06004C1D RID: 19485 RVA: 0x0014C9D0 File Offset: 0x0014ABD0
			// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0001C89C File Offset: 0x0001AA9C
			public unsafe Shape2DBorderType _borderType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2DBorderType>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__borderType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700199F RID: 6559
			// (get) Token: 0x06004C1F RID: 19487 RVA: 0x0014CA00 File Offset: 0x0014AC00
			// (set) Token: 0x06004C20 RID: 19488 RVA: 0x0001C8BB File Offset: 0x0001AABB
			public unsafe float _thickness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__thickness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__thickness)) = value;
				}
			}

			// Token: 0x170019A0 RID: 6560
			// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0014CA28 File Offset: 0x0014AC28
			// (set) Token: 0x06004C22 RID: 19490 RVA: 0x0001C8D6 File Offset: 0x0001AAD6
			public unsafe Shape2DBorderDirection _direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__direction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2DBorderDirection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__direction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019A1 RID: 6561
			// (get) Token: 0x06004C23 RID: 19491 RVA: 0x0014CA58 File Offset: 0x0014AC58
			// (set) Token: 0x06004C24 RID: 19492 RVA: 0x0001C8F5 File Offset: 0x0001AAF5
			public unsafe PolygonShape2D.ThickBorderFillMode _fillMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__fillMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonShape2D.BorderRenderDescriptor.NativeFieldInfoPtr__fillMode)) = value;
				}
			}

			// Token: 0x04003B0F RID: 15119
			private static readonly IntPtr NativeFieldInfoPtr__borderType;

			// Token: 0x04003B10 RID: 15120
			private static readonly IntPtr NativeFieldInfoPtr__thickness;

			// Token: 0x04003B11 RID: 15121
			private static readonly IntPtr NativeFieldInfoPtr__direction;

			// Token: 0x04003B12 RID: 15122
			private static readonly IntPtr NativeFieldInfoPtr__fillMode;

			// Token: 0x04003B13 RID: 15123
			private static readonly IntPtr NativeMethodInfoPtr_get_BorderType_Public_get_Shape2DBorderType_0;

			// Token: 0x04003B14 RID: 15124
			private static readonly IntPtr NativeMethodInfoPtr_set_BorderType_Public_set_Void_Shape2DBorderType_0;

			// Token: 0x04003B15 RID: 15125
			private static readonly IntPtr NativeMethodInfoPtr_get_Thickness_Public_get_Single_0;

			// Token: 0x04003B16 RID: 15126
			private static readonly IntPtr NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0;

			// Token: 0x04003B17 RID: 15127
			private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Shape2DBorderDirection_0;

			// Token: 0x04003B18 RID: 15128
			private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Public_set_Void_Shape2DBorderDirection_0;

			// Token: 0x04003B19 RID: 15129
			private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_ThickBorderFillMode_0;

			// Token: 0x04003B1A RID: 15130
			private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_ThickBorderFillMode_0;

			// Token: 0x04003B1B RID: 15131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
