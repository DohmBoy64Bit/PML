using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000039 RID: 57
	public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x06000385 RID: 901 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoDblAxisScaleDrag3D()
		{
			Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoDblAxisScaleDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr);
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_workData");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_accumSnapDrag0");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_accumSnapDrag1");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_scale0");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_scale1");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_relativeScale0");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_relativeScale1");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_totalScale0");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_totalScale1");
			GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "_scaleDragAxis");
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663815);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663816);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663817);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663818);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663819);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663820);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663821);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663826);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663822);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663823);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663824);
			GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, 100663825);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0002EE30 File Offset: 0x0002D030
		public unsafe int AxisIndex0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex0_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002EE6C File Offset: 0x0002D06C
		public unsafe int AxisIndex1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		public unsafe float RelativeScale0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale0_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		public unsafe float RelativeScale1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0002EF20 File Offset: 0x0002D120
		public unsafe float TotalScale0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale0_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0002EF5C File Offset: 0x0002D15C
		public unsafe float TotalScale1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0002EF98 File Offset: 0x0002D198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58971, RefRangeEnd = 58973, XrefRangeStart = 58970, XrefRangeEnd = 58971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoDblAxisScaleDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0002EFD4 File Offset: 0x0002D1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58977, RefRangeEnd = 58979, XrefRangeStart = 58973, XrefRangeEnd = 58977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkData(GizmoDblAxisScaleDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0002F014 File Offset: 0x0002D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58979, XrefRangeEnd = 58985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0002F060 File Offset: 0x0002D260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58985, XrefRangeEnd = 59000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0002F09C File Offset: 0x0002D29C
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000340B File Offset: 0x0000160B
		public GizmoDblAxisScaleDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00003414 File Offset: 0x00001614
		public unsafe GizmoDblAxisScaleDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0002F100 File Offset: 0x0002D300
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000342F File Offset: 0x0000162F
		public unsafe float _accumSnapDrag0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag0)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0002F128 File Offset: 0x0002D328
		// (set) Token: 0x06000398 RID: 920 RVA: 0x0000344A File Offset: 0x0000164A
		public unsafe float _accumSnapDrag1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag1)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0002F150 File Offset: 0x0002D350
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00003465 File Offset: 0x00001665
		public unsafe float _scale0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale0)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0002F178 File Offset: 0x0002D378
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003480 File Offset: 0x00001680
		public unsafe float _scale1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scale1)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0002F1A0 File Offset: 0x0002D3A0
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000349B File Offset: 0x0000169B
		public unsafe float _relativeScale0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale0)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0002F1C8 File Offset: 0x0002D3C8
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000034B6 File Offset: 0x000016B6
		public unsafe float _relativeScale1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale1)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000034D1 File Offset: 0x000016D1
		public unsafe float _totalScale0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale0)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0002F218 File Offset: 0x0002D418
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000034EC File Offset: 0x000016EC
		public unsafe float _totalScale1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__totalScale1)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0002F240 File Offset: 0x0002D440
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003507 File Offset: 0x00001707
		public unsafe Vector3 _scaleDragAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag1;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr__scale0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr__scale1;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr__relativeScale0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr__relativeScale1;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr__totalScale0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr__totalScale1;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxis;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisIndex0_Public_get_Int32_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisIndex1_Public_get_Int32_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeScale0_Public_get_Single_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeScale1_Public_get_Single_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalScale0_Public_get_Single_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalScale1_Public_get_Single_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000353 RID: 851
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x06004983 RID: 18819 RVA: 0x00144B84 File Offset: 0x00142D84
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr);
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_AxisIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "AxisIndex0");
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_AxisIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "AxisIndex1");
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "DragOrigin");
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_Axis0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "Axis0");
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_Axis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "Axis1");
				GizmoDblAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_SnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, "SnapStep");
			}

			// Token: 0x06004984 RID: 18820 RVA: 0x0001B537 File Offset: 0x00019737
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoDblAxisScaleDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x040038FE RID: 14590
			private static readonly IntPtr NativeFieldInfoPtr_AxisIndex0;

			// Token: 0x040038FF RID: 14591
			private static readonly IntPtr NativeFieldInfoPtr_AxisIndex1;

			// Token: 0x04003900 RID: 14592
			private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

			// Token: 0x04003901 RID: 14593
			private static readonly IntPtr NativeFieldInfoPtr_Axis0;

			// Token: 0x04003902 RID: 14594
			private static readonly IntPtr NativeFieldInfoPtr_Axis1;

			// Token: 0x04003903 RID: 14595
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep;

			// Token: 0x04003904 RID: 14596
			[FieldOffset(0)]
			public int AxisIndex0;

			// Token: 0x04003905 RID: 14597
			[FieldOffset(4)]
			public int AxisIndex1;

			// Token: 0x04003906 RID: 14598
			[FieldOffset(8)]
			public IntPtr DragOrigin;

			// Token: 0x04003907 RID: 14599
			[FieldOffset(20)]
			public IntPtr Axis0;

			// Token: 0x04003908 RID: 14600
			[FieldOffset(32)]
			public IntPtr Axis1;

			// Token: 0x04003909 RID: 14601
			[FieldOffset(44)]
			public float SnapStep;
		}
	}
}
