using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AF RID: 431
	public class XZGridCell : global::Il2CppSystem.Object
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x000A64C8 File Offset: 0x000A46C8
		// Note: this type is marked as 'beforefieldinit'.
		static XZGridCell()
		{
			Il2CppClassPointerStore<XZGridCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "XZGridCell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr);
			XZGridCell.NativeFieldInfoPtr__parentGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, "_parentGrid");
			XZGridCell.NativeFieldInfoPtr__xIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, "_xIndex");
			XZGridCell.NativeFieldInfoPtr__zIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, "_zIndex");
			XZGridCell.NativeFieldInfoPtr__min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, "_min");
			XZGridCell.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, "_max");
			XZGridCell.NativeMethodInfoPtr_get_ParentGrid_Public_get_IXZGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668381);
			XZGridCell.NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668382);
			XZGridCell.NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668383);
			XZGridCell.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668384);
			XZGridCell.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668385);
			XZGridCell.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668386);
			XZGridCell.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Vector3_Vector3_IXZGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668387);
			XZGridCell.NativeMethodInfoPtr_FromPoint_Public_Static_XZGridCell_Vector3_Single_Single_IXZGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668388);
			XZGridCell.NativeMethodInfoPtr_GetCenterAndCorners_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr, 100668389);
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000A6610 File Offset: 0x000A4810
		public unsafe IXZGrid ParentGrid
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_ParentGrid_Public_get_IXZGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXZGrid>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000A6650 File Offset: 0x000A4850
		public unsafe int XIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x000A668C File Offset: 0x000A488C
		public unsafe int ZIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000A66C8 File Offset: 0x000A48C8
		public unsafe Vector3 Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x000A6708 File Offset: 0x000A4908
		public unsafe Vector3 Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000A6748 File Offset: 0x000A4948
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000A6788 File Offset: 0x000A4988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86223, XrefRangeEnd = 86225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XZGridCell>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(min);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(max);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Vector3_Vector3_IXZGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000A6818 File Offset: 0x000A4A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86250, RefRangeEnd = 86252, XrefRangeStart = 86225, XrefRangeEnd = 86250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XZGridCell FromPoint(Vector3 point, float cellSizeX, float cellSizeZ, IXZGrid parentGrid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellSizeX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellSizeZ;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_FromPoint_Public_Static_XZGridCell_Vector3_Single_Single_IXZGrid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridCell>(intPtr3) : null;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000A688C File Offset: 0x000A4A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86278, RefRangeEnd = 86280, XrefRangeStart = 86252, XrefRangeEnd = 86278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCenterAndCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridCell.NativeMethodInfoPtr_GetCenterAndCorners_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0000D9EA File Offset: 0x0000BBEA
		public XZGridCell(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x000A68CC File Offset: 0x000A4ACC
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000D9F3 File Offset: 0x0000BBF3
		public unsafe IXZGrid _parentGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__parentGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXZGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__parentGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x000A68FC File Offset: 0x000A4AFC
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000DA12 File Offset: 0x0000BC12
		public unsafe int _xIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__xIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__xIndex)) = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x000A6924 File Offset: 0x000A4B24
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0000DA2D File Offset: 0x0000BC2D
		public unsafe int _zIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__zIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__zIndex)) = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x000A694C File Offset: 0x000A4B4C
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x0000DA48 File Offset: 0x0000BC48
		public unsafe Vector3 _min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000A697C File Offset: 0x000A4B7C
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x0000DA67 File Offset: 0x0000BC67
		public unsafe Vector3 _max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridCell.NativeFieldInfoPtr__max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeFieldInfoPtr__parentGrid;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeFieldInfoPtr__xIndex;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr__zIndex;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr__min;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentGrid_Public_get_IXZGrid_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Vector3_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Vector3_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Vector3_Vector3_IXZGrid_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_FromPoint_Public_Static_XZGridCell_Vector3_Single_Single_IXZGrid_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_GetCenterAndCorners_Public_List_1_Vector3_0;
	}
}
