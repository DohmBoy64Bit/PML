using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class GizmoRotationArc2DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x00060AE4 File Offset: 0x0005ECE4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRotationArc2DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRotationArc2DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr);
			GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__useShortestRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, "_useShortestRotation");
			GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__fillFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, "_fillFlags");
			GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, "_color");
			GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665614);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665615);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665616);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665617);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665618);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665619);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665620);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665621);
			GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr, 100665622);
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00060C18 File Offset: 0x0005EE18
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00060C54 File Offset: 0x0005EE54
		public unsafe bool UseShortestRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00060C94 File Offset: 0x0005EE94
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00060CD4 File Offset: 0x0005EED4
		public unsafe GizmoRotationArcFillFlags FillFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRotationArcFillFlags>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00060D18 File Offset: 0x0005EF18
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00060D58 File Offset: 0x0005EF58
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00060D9C File Offset: 0x0005EF9C
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00060DDC File Offset: 0x0005EFDC
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00060E20 File Offset: 0x0005F020
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 69374, RefRangeEnd = 69382, XrefRangeStart = 69371, XrefRangeEnd = 69374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRotationArc2DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRotationArc2DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00008A8F File Offset: 0x00006C8F
		public GizmoRotationArc2DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x00060E5C File Offset: 0x0005F05C
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00008A98 File Offset: 0x00006C98
		public unsafe bool _useShortestRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__useShortestRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__useShortestRotation)) = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00060E84 File Offset: 0x0005F084
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x00008AB3 File Offset: 0x00006CB3
		public unsafe GizmoRotationArcFillFlags _fillFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__fillFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArcFillFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__fillFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00060EB4 File Offset: 0x0005F0B4
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00008AD2 File Offset: 0x00006CD2
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00060EE4 File Offset: 0x0005F0E4
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x00008AF1 File Offset: 0x00006CF1
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc2DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeFieldInfoPtr__useShortestRotation;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr__fillFlags;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
