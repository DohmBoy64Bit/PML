using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000145 RID: 325
	public sealed class PlaneDescriptor : ValueType
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x000932F0 File Offset: 0x000914F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlaneDescriptor()
		{
			Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PlaneDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr);
			PlaneDescriptor.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, "_id");
			PlaneDescriptor.NativeFieldInfoPtr__quadrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, "_quadrant");
			PlaneDescriptor.NativeFieldInfoPtr__firstAxisDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, "_firstAxisDescriptor");
			PlaneDescriptor.NativeFieldInfoPtr__secondAxisDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, "_secondAxisDescriptor");
			PlaneDescriptor.NativeMethodInfoPtr_get_Id_Public_get_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667688);
			PlaneDescriptor.NativeMethodInfoPtr_get_Quadrant_Public_get_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667689);
			PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667690);
			PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667691);
			PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667692);
			PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667693);
			PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisDescriptor_Public_get_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667694);
			PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisDescriptor_Public_get_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667695);
			PlaneDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr, 100667696);
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00093424 File Offset: 0x00091624
		public unsafe PlaneId Id
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 33677, RefRangeEnd = 33740, XrefRangeStart = 33677, XrefRangeEnd = 33740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_Id_Public_get_PlaneId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaneId>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00093468 File Offset: 0x00091668
		public unsafe PlaneQuadrantId Quadrant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_Quadrant_Public_get_PlaneQuadrantId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000934AC File Offset: 0x000916AC
		public unsafe AxisSign FirstAxisSign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisSign_Public_get_AxisSign_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000934F0 File Offset: 0x000916F0
		public unsafe AxisSign SecondAxisSign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisSign_Public_get_AxisSign_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00093534 File Offset: 0x00091734
		public unsafe int FirstAxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00093578 File Offset: 0x00091778
		public unsafe int SecondAxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000935BC File Offset: 0x000917BC
		public unsafe AxisDescriptor FirstAxisDescriptor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_FirstAxisDescriptor_Public_get_AxisDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00093600 File Offset: 0x00091800
		public unsafe AxisDescriptor SecondAxisDescriptor
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr_get_SecondAxisDescriptor_Public_get_AxisDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00093644 File Offset: 0x00091844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79148, RefRangeEnd = 79149, XrefRangeStart = 79081, XrefRangeEnd = 79148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaneDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PlaneId_PlaneQuadrantId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0000C295 File Offset: 0x0000A495
		public PlaneDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000C29E File Offset: 0x0000A49E
		public PlaneDescriptor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneDescriptor>.NativeClassPtr))
		{
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x000936A8 File Offset: 0x000918A8
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public unsafe PlaneId _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneId>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000936D8 File Offset: 0x000918D8
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0000C2CF File Offset: 0x0000A4CF
		public unsafe PlaneQuadrantId _quadrant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__quadrant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__quadrant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00093708 File Offset: 0x00091908
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0000C2EE File Offset: 0x0000A4EE
		public unsafe AxisDescriptor _firstAxisDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__firstAxisDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__firstAxisDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00093738 File Offset: 0x00091938
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x0000C30D File Offset: 0x0000A50D
		public unsafe AxisDescriptor _secondAxisDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__secondAxisDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneDescriptor.NativeFieldInfoPtr__secondAxisDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr__quadrant;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeFieldInfoPtr__firstAxisDescriptor;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeFieldInfoPtr__secondAxisDescriptor;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_PlaneId_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_get_Quadrant_Public_get_PlaneQuadrantId_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstAxisSign_Public_get_AxisSign_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondAxisSign_Public_get_AxisSign_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstAxisIndex_Public_get_Int32_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondAxisIndex_Public_get_Int32_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstAxisDescriptor_Public_get_AxisDescriptor_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondAxisDescriptor_Public_get_AxisDescriptor_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlaneId_PlaneQuadrantId_0;
	}
}
