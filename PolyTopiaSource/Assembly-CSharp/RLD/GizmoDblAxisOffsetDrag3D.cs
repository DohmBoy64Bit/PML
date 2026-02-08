using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000037 RID: 55
	public class GizmoDblAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0002E420 File Offset: 0x0002C620
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoDblAxisOffsetDrag3D()
		{
			Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoDblAxisOffsetDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr);
			GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, "_accumSnapDrag0");
			GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, "_accumSnapDrag1");
			GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, "_workData");
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663800);
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663805);
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663801);
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663802);
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663803);
			GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, 100663804);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0002E504 File Offset: 0x0002C704
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0002E550 File Offset: 0x0002C750
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58932, XrefRangeEnd = 58933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoDblAxisOffsetDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0002E58C File Offset: 0x0002C78C
		[CallerCount(0)]
		public unsafe void SetWorkData(GizmoDblAxisOffsetDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58943, XrefRangeEnd = 58949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0002E618 File Offset: 0x0002C818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58949, XrefRangeEnd = 58958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0002E654 File Offset: 0x0002C854
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDblAxisOffsetDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000032D0 File Offset: 0x000014D0
		public GizmoDblAxisOffsetDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0002E690 File Offset: 0x0002C890
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000032D9 File Offset: 0x000014D9
		public unsafe float _accumSnapDrag0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag0)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000032F4 File Offset: 0x000014F4
		public unsafe float _accumSnapDrag1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag1)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000330F File Offset: 0x0000150F
		public unsafe GizmoDblAxisOffsetDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDblAxisOffsetDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag1;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000351 RID: 849
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x0600497F RID: 18815 RVA: 0x00144A3C File Offset: 0x00142C3C
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr);
				GizmoDblAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, "DragOrigin");
				GizmoDblAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_Axis0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, "Axis0");
				GizmoDblAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_Axis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, "Axis1");
				GizmoDblAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_SnapStep0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, "SnapStep0");
				GizmoDblAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_SnapStep1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, "SnapStep1");
			}

			// Token: 0x06004980 RID: 18816 RVA: 0x0001B513 File Offset: 0x00019713
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoDblAxisOffsetDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x040038E6 RID: 14566
			private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

			// Token: 0x040038E7 RID: 14567
			private static readonly IntPtr NativeFieldInfoPtr_Axis0;

			// Token: 0x040038E8 RID: 14568
			private static readonly IntPtr NativeFieldInfoPtr_Axis1;

			// Token: 0x040038E9 RID: 14569
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep0;

			// Token: 0x040038EA RID: 14570
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep1;

			// Token: 0x040038EB RID: 14571
			[FieldOffset(0)]
			public IntPtr DragOrigin;

			// Token: 0x040038EC RID: 14572
			[FieldOffset(12)]
			public IntPtr Axis0;

			// Token: 0x040038ED RID: 14573
			[FieldOffset(24)]
			public IntPtr Axis1;

			// Token: 0x040038EE RID: 14574
			[FieldOffset(36)]
			public float SnapStep0;

			// Token: 0x040038EF RID: 14575
			[FieldOffset(40)]
			public float SnapStep1;
		}
	}
}
