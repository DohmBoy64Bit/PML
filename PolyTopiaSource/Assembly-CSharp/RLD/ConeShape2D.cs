using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DA RID: 474
	public class ConeShape2D : Shape2D
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x000B5188 File Offset: 0x000B3388
		// Note: this type is marked as 'beforefieldinit'.
		static ConeShape2D()
		{
			Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ConeShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr);
			ConeShape2D.NativeFieldInfoPtr__baseCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, "_baseCenter");
			ConeShape2D.NativeFieldInfoPtr__rotationDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, "_rotationDegrees");
			ConeShape2D.NativeFieldInfoPtr__baseRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, "_baseRadius");
			ConeShape2D.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, "_height");
			ConeShape2D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668923);
			ConeShape2D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668924);
			ConeShape2D.NativeMethodInfoPtr_get_BaseLeft_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668925);
			ConeShape2D.NativeMethodInfoPtr_set_BaseLeft_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668926);
			ConeShape2D.NativeMethodInfoPtr_get_BaseRight_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668927);
			ConeShape2D.NativeMethodInfoPtr_set_BaseRight_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668928);
			ConeShape2D.NativeMethodInfoPtr_get_Tip_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668929);
			ConeShape2D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668930);
			ConeShape2D.NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668931);
			ConeShape2D.NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668932);
			ConeShape2D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668933);
			ConeShape2D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668934);
			ConeShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668935);
			ConeShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668936);
			ConeShape2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668937);
			ConeShape2D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668938);
			ConeShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668939);
			ConeShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668940);
			ConeShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668941);
			ConeShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668942);
			ConeShape2D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668943);
			ConeShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668948);
			ConeShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668944);
			ConeShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668945);
			ConeShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668946);
			ConeShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr, 100668947);
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000B5410 File Offset: 0x000B3610
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x000B5450 File Offset: 0x000B3650
		public unsafe Vector2 BaseCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89146, RefRangeEnd = 89148, XrefRangeStart = 89146, XrefRangeEnd = 89148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000B5494 File Offset: 0x000B3694
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x000B54D4 File Offset: 0x000B36D4
		public unsafe Vector2 BaseLeft
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89337, XrefRangeEnd = 89338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_BaseLeft_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89338, XrefRangeEnd = 89339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_BaseLeft_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x000B5518 File Offset: 0x000B3718
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x000B5558 File Offset: 0x000B3758
		public unsafe Vector2 BaseRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89339, XrefRangeEnd = 89340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_BaseRight_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89340, XrefRangeEnd = 89341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_BaseRight_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x000B559C File Offset: 0x000B379C
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x000B55DC File Offset: 0x000B37DC
		public unsafe Vector2 Tip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89341, XrefRangeEnd = 89342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_Tip_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89342, XrefRangeEnd = 89343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x000B5620 File Offset: 0x000B3820
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x000B565C File Offset: 0x000B385C
		public unsafe float BaseRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 88928, RefRangeEnd = 88946, XrefRangeStart = 88928, XrefRangeEnd = 88946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000B569C File Offset: 0x000B389C
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x000B56D8 File Offset: 0x000B38D8
		public unsafe float Height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88946, RefRangeEnd = 88960, XrefRangeStart = 88946, XrefRangeEnd = 88960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x000B5718 File Offset: 0x000B3918
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x000B5754 File Offset: 0x000B3954
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89344, RefRangeEnd = 89345, XrefRangeStart = 89343, XrefRangeEnd = 89344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000B5794 File Offset: 0x000B3994
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89345, XrefRangeEnd = 89348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000B57D4 File Offset: 0x000B39D4
		public unsafe Vector2 CentralAxis
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 89354, RefRangeEnd = 89360, XrefRangeStart = 89348, XrefRangeEnd = 89354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000B5814 File Offset: 0x000B3A14
		public unsafe Vector2 Right
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 89366, RefRangeEnd = 89378, XrefRangeStart = 89360, XrefRangeEnd = 89366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000B5854 File Offset: 0x000B3A54
		public unsafe Vector2 Up
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 89354, RefRangeEnd = 89360, XrefRangeStart = 89354, XrefRangeEnd = 89360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000B5894 File Offset: 0x000B3A94
		public unsafe static Vector2 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000B58C8 File Offset: 0x000B3AC8
		public unsafe static Vector2 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x000B58FC File Offset: 0x000B3AFC
		public unsafe static Vector2 ModelBaseCenter
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 89172, RefRangeEnd = 89203, XrefRangeStart = 89172, XrefRangeEnd = 89203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000B5930 File Offset: 0x000B3B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89381, RefRangeEnd = 89382, XrefRangeStart = 89378, XrefRangeEnd = 89381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConeShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConeShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000B596C File Offset: 0x000B3B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89382, XrefRangeEnd = 89398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000B59BC File Offset: 0x000B3BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89398, XrefRangeEnd = 89416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000B5A0C File Offset: 0x000B3C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89416, XrefRangeEnd = 89423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000B5A64 File Offset: 0x000B3C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89423, XrefRangeEnd = 89440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x0000F403 File Offset: 0x0000D603
		public ConeShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000B5AB0 File Offset: 0x000B3CB0
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0000F40C File Offset: 0x0000D60C
		public unsafe Vector2 _baseCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__baseCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__baseCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000B5AE0 File Offset: 0x000B3CE0
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0000F42B File Offset: 0x0000D62B
		public unsafe float _rotationDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__rotationDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__rotationDegrees)) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000B5B08 File Offset: 0x000B3D08
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0000F446 File Offset: 0x0000D646
		public unsafe float _baseRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__baseRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__baseRadius)) = value;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000B5B30 File Offset: 0x000B3D30
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0000F461 File Offset: 0x0000D661
		public unsafe float _height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape2D.NativeFieldInfoPtr__height)) = value;
			}
		}

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr__baseCenter;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr__rotationDegrees;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr__baseRadius;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr__height;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector2_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector2_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseLeft_Public_get_Vector2_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseLeft_Public_set_Void_Vector2_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseRight_Public_get_Vector2_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseRight_Public_set_Void_Vector2_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_get_Tip_Public_get_Vector2_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector2_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector2_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector2_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;
	}
}
