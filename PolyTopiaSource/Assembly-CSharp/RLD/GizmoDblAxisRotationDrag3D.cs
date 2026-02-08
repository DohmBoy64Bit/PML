using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000038 RID: 56
	public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0002E708 File Offset: 0x0002C908
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoDblAxisRotationDrag3D()
		{
			Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoDblAxisRotationDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr);
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_workData");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_adjustRotationForAbsSnap");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_accumSnapDrag0");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_accumSnapDrag1");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_relativeRotation0");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_relativeRotation1");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_totalRotation0");
			GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "_totalRotation1");
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663806);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663807);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663808);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663809);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663810);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663814);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663811);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663812);
			GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, 100663813);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0002E88C File Offset: 0x0002CA8C
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 20318, RefRangeEnd = 20320, XrefRangeStart = 20318, XrefRangeEnd = 20320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		public unsafe float RelativeRotation0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation0_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0002E914 File Offset: 0x0002CB14
		public unsafe float RelativeRotation1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0002E950 File Offset: 0x0002CB50
		public unsafe float TotalRotation0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation0_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0002E98C File Offset: 0x0002CB8C
		public unsafe float TotalRotation1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58933, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoDblAxisRotationDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0002EA04 File Offset: 0x0002CC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58958, RefRangeEnd = 58959, XrefRangeStart = 58958, XrefRangeEnd = 58958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkData(GizmoDblAxisRotationDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0002EA44 File Offset: 0x0002CC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58959, XrefRangeEnd = 58970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0002EA80 File Offset: 0x0002CC80
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000332A File Offset: 0x0000152A
		public GizmoDblAxisRotationDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0002EABC File Offset: 0x0002CCBC
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003333 File Offset: 0x00001533
		public unsafe GizmoDblAxisRotationDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000334E File Offset: 0x0000154E
		public unsafe bool _adjustRotationForAbsSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003369 File Offset: 0x00001569
		public unsafe float _accumSnapDrag0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag0)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0002EB34 File Offset: 0x0002CD34
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003384 File Offset: 0x00001584
		public unsafe float _accumSnapDrag1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag1)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0000339F File Offset: 0x0000159F
		public unsafe float _relativeRotation0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation0)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0002EB84 File Offset: 0x0002CD84
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000033BA File Offset: 0x000015BA
		public unsafe float _relativeRotation1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation1)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000033D5 File Offset: 0x000015D5
		public unsafe float _totalRotation0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation0)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0002EBD4 File Offset: 0x0002CDD4
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000033F0 File Offset: 0x000015F0
		public unsafe float _totalRotation1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation1)) = value;
			}
		}

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr__adjustRotationForAbsSnap;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag1;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr__relativeRotation0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr__relativeRotation1;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__totalRotation0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr__totalRotation1;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeRotation0_Public_get_Single_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeRotation1_Public_get_Single_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalRotation0_Public_get_Single_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalRotation1_Public_get_Single_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000352 RID: 850
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x06004981 RID: 18817 RVA: 0x00144ACC File Offset: 0x00142CCC
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr);
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_ScreenAxis0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "ScreenAxis0");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_ScreenAxis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "ScreenAxis1");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_Axis0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "Axis0");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_Axis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "Axis1");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_SnapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "SnapMode");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_SnapStep0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "SnapStep0");
				GizmoDblAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_SnapStep1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, "SnapStep1");
			}

			// Token: 0x06004982 RID: 18818 RVA: 0x0001B525 File Offset: 0x00019725
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoDblAxisRotationDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x040038F0 RID: 14576
			private static readonly IntPtr NativeFieldInfoPtr_ScreenAxis0;

			// Token: 0x040038F1 RID: 14577
			private static readonly IntPtr NativeFieldInfoPtr_ScreenAxis1;

			// Token: 0x040038F2 RID: 14578
			private static readonly IntPtr NativeFieldInfoPtr_Axis0;

			// Token: 0x040038F3 RID: 14579
			private static readonly IntPtr NativeFieldInfoPtr_Axis1;

			// Token: 0x040038F4 RID: 14580
			private static readonly IntPtr NativeFieldInfoPtr_SnapMode;

			// Token: 0x040038F5 RID: 14581
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep0;

			// Token: 0x040038F6 RID: 14582
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep1;

			// Token: 0x040038F7 RID: 14583
			[FieldOffset(0)]
			public IntPtr ScreenAxis0;

			// Token: 0x040038F8 RID: 14584
			[FieldOffset(8)]
			public IntPtr ScreenAxis1;

			// Token: 0x040038F9 RID: 14585
			[FieldOffset(16)]
			public IntPtr Axis0;

			// Token: 0x040038FA RID: 14586
			[FieldOffset(28)]
			public IntPtr Axis1;

			// Token: 0x040038FB RID: 14587
			[FieldOffset(40)]
			public IntPtr SnapMode;

			// Token: 0x040038FC RID: 14588
			[FieldOffset(44)]
			public float SnapStep0;

			// Token: 0x040038FD RID: 14589
			[FieldOffset(48)]
			public float SnapStep1;
		}
	}
}
