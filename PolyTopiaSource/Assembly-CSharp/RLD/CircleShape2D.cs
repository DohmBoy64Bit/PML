using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D8 RID: 472
	public class CircleShape2D : Shape2D
	{
		// Token: 0x06002515 RID: 9493 RVA: 0x000B3834 File Offset: 0x000B1A34
		// Note: this type is marked as 'beforefieldinit'.
		static CircleShape2D()
		{
			Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CircleShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr);
			CircleShape2D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_center");
			CircleShape2D.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_radius");
			CircleShape2D.NativeFieldInfoPtr__rotationDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_rotationDegrees");
			CircleShape2D.NativeFieldInfoPtr__numBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_numBorderPoints");
			CircleShape2D.NativeFieldInfoPtr__modelBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_modelBorderPoints");
			CircleShape2D.NativeFieldInfoPtr__areModelBorderPointsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_areModelBorderPointsDirty");
			CircleShape2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_epsilon");
			CircleShape2D.NativeFieldInfoPtr__ptContainMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, "_ptContainMode");
			CircleShape2D.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668858);
			CircleShape2D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668859);
			CircleShape2D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668860);
			CircleShape2D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668861);
			CircleShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668862);
			CircleShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668863);
			CircleShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668864);
			CircleShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668865);
			CircleShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668866);
			CircleShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668867);
			CircleShape2D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668868);
			CircleShape2D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668869);
			CircleShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668870);
			CircleShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668871);
			CircleShape2D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668872);
			CircleShape2D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668873);
			CircleShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668874);
			CircleShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668875);
			CircleShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668876);
			CircleShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668877);
			CircleShape2D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668878);
			CircleShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668886);
			CircleShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668879);
			CircleShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668880);
			CircleShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668881);
			CircleShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668882);
			CircleShape2D.NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668883);
			CircleShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668884);
			CircleShape2D.NativeMethodInfoPtr_CalcModelBorderPoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr, 100668885);
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000B3B48 File Offset: 0x000B1D48
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x000B3B88 File Offset: 0x000B1D88
		public unsafe Vector2 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89146, RefRangeEnd = 89148, XrefRangeStart = 89146, XrefRangeEnd = 89146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000B3BCC File Offset: 0x000B1DCC
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x000B3C08 File Offset: 0x000B1E08
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88928, XrefRangeStart = 88914, XrefRangeEnd = 88928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000B3C48 File Offset: 0x000B1E48
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x000B3C84 File Offset: 0x000B1E84
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57146, RefRangeEnd = 57149, XrefRangeStart = 57146, XrefRangeEnd = 57149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000B3CC4 File Offset: 0x000B1EC4
		public unsafe Vector2 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89148, XrefRangeEnd = 89154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x000B3D04 File Offset: 0x000B1F04
		public unsafe Vector2 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89154, XrefRangeEnd = 89160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000B3D44 File Offset: 0x000B1F44
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x000B3D84 File Offset: 0x000B1F84
		public unsafe CircleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CircleEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000B3DC8 File Offset: 0x000B1FC8
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x000B3E04 File Offset: 0x000B2004
		public unsafe float RadiusEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89161, RefRangeEnd = 89164, XrefRangeStart = 89160, XrefRangeEnd = 89161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000B3E44 File Offset: 0x000B2044
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x000B3E80 File Offset: 0x000B2080
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89165, RefRangeEnd = 89166, XrefRangeStart = 89164, XrefRangeEnd = 89165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000B3EC0 File Offset: 0x000B20C0
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x000B3EFC File Offset: 0x000B20FC
		public unsafe int NumBorderPoints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000B3F3C File Offset: 0x000B213C
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x000B3F7C File Offset: 0x000B217C
		public unsafe Shape2DPtContainMode PtContainMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000B3FC0 File Offset: 0x000B21C0
		public unsafe static Vector2 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89166, XrefRangeEnd = 89168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000B3FF4 File Offset: 0x000B21F4
		public unsafe static Vector2 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89168, XrefRangeEnd = 89170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000B4028 File Offset: 0x000B2228
		public unsafe static Vector2 ModelCenter
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 89172, RefRangeEnd = 89203, XrefRangeStart = 89170, XrefRangeEnd = 89172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000B405C File Offset: 0x000B225C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 89213, RefRangeEnd = 89216, XrefRangeStart = 89203, XrefRangeEnd = 89213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircleShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000B4098 File Offset: 0x000B2298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89218, RefRangeEnd = 89219, XrefRangeStart = 89216, XrefRangeEnd = 89218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000B40E8 File Offset: 0x000B22E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89219, XrefRangeEnd = 89222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000B4138 File Offset: 0x000B2338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89222, XrefRangeEnd = 89227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000B4188 File Offset: 0x000B2388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89227, XrefRangeEnd = 89228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000B41E0 File Offset: 0x000B23E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89228, XrefRangeEnd = 89229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetExtentPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000B4220 File Offset: 0x000B2420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89229, XrefRangeEnd = 89231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000B426C File Offset: 0x000B246C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89235, RefRangeEnd = 89237, XrefRangeStart = 89231, XrefRangeEnd = 89235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcModelBorderPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape2D.NativeMethodInfoPtr_CalcModelBorderPoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0000F272 File Offset: 0x0000D472
		public CircleShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000B42A0 File Offset: 0x000B24A0
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0000F27B File Offset: 0x0000D47B
		public unsafe Vector2 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000B42D0 File Offset: 0x000B24D0
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x0000F29A File Offset: 0x0000D49A
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000B42F8 File Offset: 0x000B24F8
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x0000F2B5 File Offset: 0x0000D4B5
		public unsafe float _rotationDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__rotationDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__rotationDegrees)) = value;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x000B4320 File Offset: 0x000B2520
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		public unsafe int _numBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__numBorderPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__numBorderPoints)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000B4348 File Offset: 0x000B2548
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x0000F2EB File Offset: 0x0000D4EB
		public unsafe List<Vector2> _modelBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__modelBorderPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__modelBorderPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000B4378 File Offset: 0x000B2578
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x0000F30A File Offset: 0x0000D50A
		public unsafe bool _areModelBorderPointsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__areModelBorderPointsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__areModelBorderPointsDirty)) = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000B43A0 File Offset: 0x000B25A0
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x0000F325 File Offset: 0x0000D525
		public unsafe CircleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000B43D0 File Offset: 0x000B25D0
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x0000F344 File Offset: 0x0000D544
		public unsafe Shape2DPtContainMode _ptContainMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__ptContainMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape2D.NativeFieldInfoPtr__ptContainMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeFieldInfoPtr__rotationDegrees;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeFieldInfoPtr__numBorderPoints;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeFieldInfoPtr__modelBorderPoints;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr__areModelBorderPointsDirty;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeFieldInfoPtr__ptContainMode;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector2_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_get_NumBorderPoints_Public_get_Int32_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_set_NumBorderPoints_Public_set_Void_Int32_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector2_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_CalcModelBorderPoints_Private_Void_0;
	}
}
