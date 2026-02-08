using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public class ObjectGridSnapLookAndFeel : Settings
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x000AF1B0 File Offset: 0x000AD3B0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGridSnapLookAndFeel()
		{
			Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGridSnapLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr);
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotShapeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_pivotShapeType");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_pivotPointFillColor");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_pivotPointBorderColor");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_pivotCircleRadius");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotSquareSideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_pivotSquareSideLength");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawPivotBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_drawPivotBorder");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__boxLineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_boxLineColor");
			ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, "_drawBoxes");
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotShapeType_Public_get_PivotPointShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668682);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotShapeType_Public_set_Void_PivotPointShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668683);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotPointFillColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668684);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotPointFillColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668685);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotPointBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668686);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotPointBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668687);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotCircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668688);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotCircleRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668689);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotSquareSideLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668690);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotSquareSideLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668691);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_DrawPivotBorder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668692);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_DrawPivotBorder_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668693);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_BoxLineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668694);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_BoxLineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668695);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_DrawBoxes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668696);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_DrawBoxes_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668697);
			ObjectGridSnapLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr, 100668698);
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000AF3D4 File Offset: 0x000AD5D4
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x000AF414 File Offset: 0x000AD614
		public unsafe PivotPointShapeType PivotShapeType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotShapeType_Public_get_PivotPointShapeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PivotPointShapeType>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotShapeType_Public_set_Void_PivotPointShapeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000AF458 File Offset: 0x000AD658
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x000AF498 File Offset: 0x000AD698
		public unsafe Color PivotPointFillColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotPointFillColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotPointFillColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000AF4DC File Offset: 0x000AD6DC
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x000AF51C File Offset: 0x000AD71C
		public unsafe Color PivotPointBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotPointBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotPointBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000AF560 File Offset: 0x000AD760
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000AF59C File Offset: 0x000AD79C
		public unsafe float PivotCircleRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotCircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotCircleRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000AF5DC File Offset: 0x000AD7DC
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x000AF618 File Offset: 0x000AD818
		public unsafe float PivotSquareSideLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_PivotSquareSideLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_PivotSquareSideLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000AF658 File Offset: 0x000AD858
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x000AF694 File Offset: 0x000AD894
		public unsafe bool DrawPivotBorder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_DrawPivotBorder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35813, RefRangeEnd = 35814, XrefRangeStart = 35813, XrefRangeEnd = 35814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_DrawPivotBorder_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000AF6D4 File Offset: 0x000AD8D4
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x000AF714 File Offset: 0x000AD914
		public unsafe Color BoxLineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_BoxLineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_BoxLineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000AF758 File Offset: 0x000AD958
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x000AF794 File Offset: 0x000AD994
		public unsafe bool DrawBoxes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_get_DrawBoxes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr_set_DrawBoxes_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88492, RefRangeEnd = 88493, XrefRangeStart = 88491, XrefRangeEnd = 88492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGridSnapLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGridSnapLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		public ObjectGridSnapLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000AF810 File Offset: 0x000ADA10
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		public unsafe PivotPointShapeType _pivotShapeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotShapeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PivotPointShapeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotShapeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000AF840 File Offset: 0x000ADA40
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0000EBE5 File Offset: 0x0000CDE5
		public unsafe Color _pivotPointFillColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointFillColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointFillColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000AF870 File Offset: 0x000ADA70
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0000EC04 File Offset: 0x0000CE04
		public unsafe Color _pivotPointBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotPointBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000AF8A0 File Offset: 0x000ADAA0
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0000EC23 File Offset: 0x0000CE23
		public unsafe float _pivotCircleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotCircleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotCircleRadius)) = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000AF8C8 File Offset: 0x000ADAC8
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0000EC3E File Offset: 0x0000CE3E
		public unsafe float _pivotSquareSideLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotSquareSideLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__pivotSquareSideLength)) = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000AF8F0 File Offset: 0x000ADAF0
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0000EC59 File Offset: 0x0000CE59
		public unsafe bool _drawPivotBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawPivotBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawPivotBorder)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000AF918 File Offset: 0x000ADB18
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0000EC74 File Offset: 0x0000CE74
		public unsafe Color _boxLineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__boxLineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__boxLineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000AF948 File Offset: 0x000ADB48
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0000EC93 File Offset: 0x0000CE93
		public unsafe bool _drawBoxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawBoxes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapLookAndFeel.NativeFieldInfoPtr__drawBoxes)) = value;
			}
		}

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr__pivotShapeType;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr__pivotPointFillColor;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeFieldInfoPtr__pivotPointBorderColor;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeFieldInfoPtr__pivotCircleRadius;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr__pivotSquareSideLength;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr__drawPivotBorder;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr__boxLineColor;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr__drawBoxes;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotShapeType_Public_get_PivotPointShapeType_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotShapeType_Public_set_Void_PivotPointShapeType_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotPointFillColor_Public_get_Color_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotPointFillColor_Public_set_Void_Color_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotPointBorderColor_Public_get_Color_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotPointBorderColor_Public_set_Void_Color_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotCircleRadius_Public_get_Single_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotCircleRadius_Public_set_Void_Single_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotSquareSideLength_Public_get_Single_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotSquareSideLength_Public_set_Void_Single_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawPivotBorder_Public_get_Boolean_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawPivotBorder_Public_set_Void_Boolean_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxLineColor_Public_get_Color_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxLineColor_Public_set_Void_Color_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawBoxes_Public_get_Boolean_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawBoxes_Public_set_Void_Boolean_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
