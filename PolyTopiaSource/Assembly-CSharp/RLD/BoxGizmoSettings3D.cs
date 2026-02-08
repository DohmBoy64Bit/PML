using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x02000083 RID: 131
	[Serializable]
	public class BoxGizmoSettings3D : Settings
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x00048094 File Offset: 0x00046294
		// Note: this type is marked as 'beforefieldinit'.
		static BoxGizmoSettings3D()
		{
			Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxGizmoSettings3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr);
			BoxGizmoSettings3D.NativeFieldInfoPtr__xSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, "_xSnapStep");
			BoxGizmoSettings3D.NativeFieldInfoPtr__ySnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, "_ySnapStep");
			BoxGizmoSettings3D.NativeFieldInfoPtr__zSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, "_zSnapStep");
			BoxGizmoSettings3D.NativeFieldInfoPtr__dragSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, "_dragSensitivity");
			BoxGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664798);
			BoxGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664799);
			BoxGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664800);
			BoxGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664801);
			BoxGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664806);
			BoxGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664802);
			BoxGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664803);
			BoxGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664804);
			BoxGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr, 100664805);
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000481C8 File Offset: 0x000463C8
		public unsafe float XSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00048204 File Offset: 0x00046404
		public unsafe float YSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00048240 File Offset: 0x00046440
		public unsafe float ZSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0004827C File Offset: 0x0004647C
		public unsafe float DragSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000482B8 File Offset: 0x000464B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65036, RefRangeEnd = 65039, XrefRangeStart = 65035, XrefRangeEnd = 65036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmoSettings3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxGizmoSettings3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000482F4 File Offset: 0x000464F4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65070, XrefRangeStart = 65039, XrefRangeEnd = 65039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00048334 File Offset: 0x00046534
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 65070, RefRangeEnd = 65083, XrefRangeStart = 65070, XrefRangeEnd = 65070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00048374 File Offset: 0x00046574
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65083, RefRangeEnd = 65089, XrefRangeStart = 65083, XrefRangeEnd = 65083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000483B4 File Offset: 0x000465B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 65089, RefRangeEnd = 65093, XrefRangeStart = 65089, XrefRangeEnd = 65089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000056A1 File Offset: 0x000038A1
		public BoxGizmoSettings3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000483F4 File Offset: 0x000465F4
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x000056AA File Offset: 0x000038AA
		public unsafe float _xSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__xSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__xSnapStep)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0004841C File Offset: 0x0004661C
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000056C5 File Offset: 0x000038C5
		public unsafe float _ySnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__ySnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__ySnapStep)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00048444 File Offset: 0x00046644
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000056E0 File Offset: 0x000038E0
		public unsafe float _zSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__zSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__zSnapStep)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0004846C File Offset: 0x0004666C
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x000056FB File Offset: 0x000038FB
		public unsafe float _dragSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__dragSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoSettings3D.NativeFieldInfoPtr__dragSensitivity)) = value;
			}
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr__xSnapStep;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr__ySnapStep;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr__zSnapStep;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr__dragSensitivity;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0;
	}
}
