using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000147 RID: 327
	public static class PlaneIdHelper : Object
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x00093768 File Offset: 0x00091968
		// Note: this type is marked as 'beforefieldinit'.
		static PlaneIdHelper()
		{
			Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PlaneIdHelper");
			PlaneIdHelper.NativeFieldInfoPtr__planeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "_planeInfo");
			PlaneIdHelper.NativeFieldInfoPtr__allPlaneIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "_allPlaneIds");
			PlaneIdHelper.NativeMethodInfoPtr_get_AllPlaneIds_Public_Static_get_Il2CppStructArray_1_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667698);
			PlaneIdHelper.NativeMethodInfoPtr_GetFirstAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667699);
			PlaneIdHelper.NativeMethodInfoPtr_GetSecondAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667700);
			PlaneIdHelper.NativeMethodInfoPtr_GetFirstAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667701);
			PlaneIdHelper.NativeMethodInfoPtr_GetSecondAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667702);
			PlaneIdHelper.NativeMethodInfoPtr_GetQuadrantFromAxesSigns_Public_Static_PlaneQuadrantId_PlaneId_AxisSign_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667703);
			PlaneIdHelper.NativeMethodInfoPtr_PlaneIdToFirstAxisIndex_Public_Static_Int32_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667704);
			PlaneIdHelper.NativeMethodInfoPtr_PlaneIdToSecondAxisIndex_Public_Static_Int32_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667705);
			PlaneIdHelper.NativeMethodInfoPtr_NormalAxisIndexToPlaneId_Public_Static_PlaneId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, 100667706);
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0009386C File Offset: 0x00091A6C
		public unsafe static Il2CppStructArray<PlaneId> AllPlaneIds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79149, XrefRangeEnd = 79158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_get_AllPlaneIds_Public_Static_get_Il2CppStructArray_1_PlaneId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PlaneId>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000938A0 File Offset: 0x00091AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79188, RefRangeEnd = 79190, XrefRangeStart = 79158, XrefRangeEnd = 79188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisDescriptor GetFirstAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_GetFirstAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000938F8 File Offset: 0x00091AF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79221, RefRangeEnd = 79224, XrefRangeStart = 79190, XrefRangeEnd = 79221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisDescriptor GetSecondAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_GetSecondAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00093950 File Offset: 0x00091B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79224, XrefRangeEnd = 79247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_GetFirstAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000939A8 File Offset: 0x00091BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79247, XrefRangeEnd = 79270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_GetSecondAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00093A00 File Offset: 0x00091C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79293, RefRangeEnd = 79294, XrefRangeStart = 79270, XrefRangeEnd = 79293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlaneQuadrantId GetQuadrantFromAxesSigns(PlaneId planeId, AxisSign firstAxisSign, AxisSign secondAxisSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstAxisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondAxisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_GetQuadrantFromAxesSigns_Public_Static_PlaneQuadrantId_PlaneId_AxisSign_AxisSign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr3) : null;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00093A68 File Offset: 0x00091C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79294, RefRangeEnd = 79295, XrefRangeStart = 79294, XrefRangeEnd = 79294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlaneIdToFirstAxisIndex(PlaneId planeId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_PlaneIdToFirstAxisIndex_Public_Static_Int32_PlaneId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00093AAC File Offset: 0x00091CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79295, RefRangeEnd = 79296, XrefRangeStart = 79295, XrefRangeEnd = 79295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlaneIdToSecondAxisIndex(PlaneId planeId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_PlaneIdToSecondAxisIndex_Public_Static_Int32_PlaneId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00093AF0 File Offset: 0x00091CF0
		[CallerCount(0)]
		public unsafe static PlaneId NormalAxisIndexToPlaneId(int axisIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.NativeMethodInfoPtr_NormalAxisIndexToPlaneId_Public_Static_PlaneId_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaneId>(intPtr3) : null;
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0000C32C File Offset: 0x0000A52C
		public PlaneIdHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00093B30 File Offset: 0x00091D30
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000C335 File Offset: 0x0000A535
		public unsafe static List<PlaneIdHelper.PlaneInfo> _planeInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlaneIdHelper.NativeFieldInfoPtr__planeInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlaneIdHelper.PlaneInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaneIdHelper.NativeFieldInfoPtr__planeInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00093B58 File Offset: 0x00091D58
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000C347 File Offset: 0x0000A547
		public unsafe static Il2CppStructArray<PlaneId> _allPlaneIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlaneIdHelper.NativeFieldInfoPtr__allPlaneIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PlaneId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaneIdHelper.NativeFieldInfoPtr__allPlaneIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr__planeInfo;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr__allPlaneIds;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_get_AllPlaneIds_Public_Static_get_Il2CppStructArray_1_PlaneId_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondAxisDescriptor_Public_Static_AxisDescriptor_PlaneId_PlaneQuadrantId_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondAxisSign_Public_Static_AxisSign_PlaneId_PlaneQuadrantId_0;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_GetQuadrantFromAxesSigns_Public_Static_PlaneQuadrantId_PlaneId_AxisSign_AxisSign_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_PlaneIdToFirstAxisIndex_Public_Static_Int32_PlaneId_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_PlaneIdToSecondAxisIndex_Public_Static_Int32_PlaneId_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_NormalAxisIndexToPlaneId_Public_Static_PlaneId_Int32_0;

		// Token: 0x0200038D RID: 909
		[StructLayout(2)]
		public struct PlaneQuadrantInfo
		{
			// Token: 0x06004B1A RID: 19226 RVA: 0x0014991C File Offset: 0x00147B1C
			// Note: this type is marked as 'beforefieldinit'.
			static PlaneQuadrantInfo()
			{
				Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "PlaneQuadrantInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr);
				PlaneIdHelper.PlaneQuadrantInfo.NativeFieldInfoPtr_Quadrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr, "Quadrant");
				PlaneIdHelper.PlaneQuadrantInfo.NativeFieldInfoPtr_FirstAxisSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr, "FirstAxisSign");
				PlaneIdHelper.PlaneQuadrantInfo.NativeFieldInfoPtr_SecondAxisSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr, "SecondAxisSign");
			}

			// Token: 0x06004B1B RID: 19227 RVA: 0x0001C1C6 File Offset: 0x0001A3C6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaneIdHelper.PlaneQuadrantInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04003A49 RID: 14921
			private static readonly IntPtr NativeFieldInfoPtr_Quadrant;

			// Token: 0x04003A4A RID: 14922
			private static readonly IntPtr NativeFieldInfoPtr_FirstAxisSign;

			// Token: 0x04003A4B RID: 14923
			private static readonly IntPtr NativeFieldInfoPtr_SecondAxisSign;

			// Token: 0x04003A4C RID: 14924
			[FieldOffset(0)]
			public IntPtr Quadrant;

			// Token: 0x04003A4D RID: 14925
			[FieldOffset(4)]
			public IntPtr FirstAxisSign;

			// Token: 0x04003A4E RID: 14926
			[FieldOffset(8)]
			public IntPtr SecondAxisSign;
		}

		// Token: 0x0200038E RID: 910
		public sealed class PlaneInfo : ValueType
		{
			// Token: 0x06004B1C RID: 19228 RVA: 0x00149984 File Offset: 0x00147B84
			// Note: this type is marked as 'beforefieldinit'.
			static PlaneInfo()
			{
				Il2CppClassPointerStore<PlaneIdHelper.PlaneInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "PlaneInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneIdHelper.PlaneInfo>.NativeClassPtr);
				PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_PlaneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.PlaneInfo>.NativeClassPtr, "PlaneId");
				PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_QuadrantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.PlaneInfo>.NativeClassPtr, "QuadrantInfo");
			}

			// Token: 0x06004B1D RID: 19229 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
			public PlaneInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B1E RID: 19230 RVA: 0x0001C1E1 File Offset: 0x0001A3E1
			public PlaneInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneIdHelper.PlaneInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17001963 RID: 6499
			// (get) Token: 0x06004B1F RID: 19231 RVA: 0x001499D8 File Offset: 0x00147BD8
			// (set) Token: 0x06004B20 RID: 19232 RVA: 0x0001C1F3 File Offset: 0x0001A3F3
			public unsafe PlaneId PlaneId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_PlaneId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneId>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_PlaneId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001964 RID: 6500
			// (get) Token: 0x06004B21 RID: 19233 RVA: 0x00149A08 File Offset: 0x00147C08
			// (set) Token: 0x06004B22 RID: 19234 RVA: 0x0001C212 File Offset: 0x0001A412
			public unsafe List<PlaneIdHelper.PlaneQuadrantInfo> QuadrantInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_QuadrantInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlaneIdHelper.PlaneQuadrantInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.PlaneInfo.NativeFieldInfoPtr_QuadrantInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A4F RID: 14927
			private static readonly IntPtr NativeFieldInfoPtr_PlaneId;

			// Token: 0x04003A50 RID: 14928
			private static readonly IntPtr NativeFieldInfoPtr_QuadrantInfo;
		}

		// Token: 0x0200038F RID: 911
		[ObfuscatedName("RLD.PlaneIdHelper+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06004B23 RID: 19235 RVA: 0x00149A38 File Offset: 0x00147C38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr);
				PlaneIdHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_planeQuadrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr, "planeQuadrant");
				PlaneIdHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr, 100667707);
				PlaneIdHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSecondAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr, 100667708);
			}

			// Token: 0x06004B24 RID: 19236 RVA: 0x00149AA0 File Offset: 0x00147CA0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B25 RID: 19237 RVA: 0x00149ADC File Offset: 0x00147CDC
			[CallerCount(0)]
			public unsafe bool _GetSecondAxisSign_b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref item;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSecondAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B26 RID: 19238 RVA: 0x0001C231 File Offset: 0x0001A431
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001965 RID: 6501
			// (get) Token: 0x06004B27 RID: 19239 RVA: 0x00149B28 File Offset: 0x00147D28
			// (set) Token: 0x06004B28 RID: 19240 RVA: 0x0001C23A File Offset: 0x0001A43A
			public unsafe PlaneQuadrantId planeQuadrant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_planeQuadrant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_planeQuadrant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A51 RID: 14929
			private static readonly IntPtr NativeFieldInfoPtr_planeQuadrant;

			// Token: 0x04003A52 RID: 14930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A53 RID: 14931
			private static readonly IntPtr NativeMethodInfoPtr__GetSecondAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0;
		}

		// Token: 0x02000390 RID: 912
		[ObfuscatedName("RLD.PlaneIdHelper+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06004B29 RID: 19241 RVA: 0x00149B58 File Offset: 0x00147D58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr);
				PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_firstAxisSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr, "firstAxisSign");
				PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_secondAxisSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr, "secondAxisSign");
				PlaneIdHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr, 100667709);
				PlaneIdHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__GetQuadrantFromAxesSigns_b__0_Internal_Boolean_PlaneQuadrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr, 100667710);
			}

			// Token: 0x06004B2A RID: 19242 RVA: 0x00149BD4 File Offset: 0x00147DD4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B2B RID: 19243 RVA: 0x00149C10 File Offset: 0x00147E10
			[CallerCount(0)]
			public unsafe bool _GetQuadrantFromAxesSigns_b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref item;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__GetQuadrantFromAxesSigns_b__0_Internal_Boolean_PlaneQuadrantInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B2C RID: 19244 RVA: 0x0001C259 File Offset: 0x0001A459
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001966 RID: 6502
			// (get) Token: 0x06004B2D RID: 19245 RVA: 0x00149C5C File Offset: 0x00147E5C
			// (set) Token: 0x06004B2E RID: 19246 RVA: 0x0001C262 File Offset: 0x0001A462
			public unsafe AxisSign firstAxisSign
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_firstAxisSign);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_firstAxisSign), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001967 RID: 6503
			// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00149C8C File Offset: 0x00147E8C
			// (set) Token: 0x06004B30 RID: 19248 RVA: 0x0001C281 File Offset: 0x0001A481
			public unsafe AxisSign secondAxisSign
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_secondAxisSign);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_secondAxisSign), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A54 RID: 14932
			private static readonly IntPtr NativeFieldInfoPtr_firstAxisSign;

			// Token: 0x04003A55 RID: 14933
			private static readonly IntPtr NativeFieldInfoPtr_secondAxisSign;

			// Token: 0x04003A56 RID: 14934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A57 RID: 14935
			private static readonly IntPtr NativeMethodInfoPtr__GetQuadrantFromAxesSigns_b__0_Internal_Boolean_PlaneQuadrantInfo_0;
		}

		// Token: 0x02000391 RID: 913
		[ObfuscatedName("RLD.PlaneIdHelper+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06004B31 RID: 19249 RVA: 0x00149CBC File Offset: 0x00147EBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneIdHelper>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr);
				PlaneIdHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_planeQuadrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr, "planeQuadrant");
				PlaneIdHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr, 100667711);
				PlaneIdHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__GetFirstAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr, 100667712);
			}

			// Token: 0x06004B32 RID: 19250 RVA: 0x00149D24 File Offset: 0x00147F24
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneIdHelper.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B33 RID: 19251 RVA: 0x00149D60 File Offset: 0x00147F60
			[CallerCount(0)]
			public unsafe bool _GetFirstAxisSign_b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref item;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneIdHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__GetFirstAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B34 RID: 19252 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001968 RID: 6504
			// (get) Token: 0x06004B35 RID: 19253 RVA: 0x00149DAC File Offset: 0x00147FAC
			// (set) Token: 0x06004B36 RID: 19254 RVA: 0x0001C2A9 File Offset: 0x0001A4A9
			public unsafe PlaneQuadrantId planeQuadrant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_planeQuadrant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneIdHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_planeQuadrant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A58 RID: 14936
			private static readonly IntPtr NativeFieldInfoPtr_planeQuadrant;

			// Token: 0x04003A59 RID: 14937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A5A RID: 14938
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstAxisSign_b__0_Internal_Boolean_PlaneQuadrantInfo_0;
		}
	}
}
