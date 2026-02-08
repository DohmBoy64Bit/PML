using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public class GizmoRotationArc3DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x00061200 File Offset: 0x0005F400
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRotationArc3DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRotationArc3DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr);
			GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__useShortestRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, "_useShortestRotation");
			GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__fillFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, "_fillFlags");
			GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, "_color");
			GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665630);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665631);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665632);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665633);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665634);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665635);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665636);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665637);
			GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr, 100665638);
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00061334 File Offset: 0x0005F534
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00061370 File Offset: 0x0005F570
		public unsafe bool UseShortestRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000613B0 File Offset: 0x0005F5B0
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x000613F0 File Offset: 0x0005F5F0
		public unsafe GizmoRotationArcFillFlags FillFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00061434 File Offset: 0x0005F634
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00061474 File Offset: 0x0005F674
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x000614B8 File Offset: 0x0005F6B8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x000614F8 File Offset: 0x0005F6F8
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0006153C File Offset: 0x0005F73C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 69374, RefRangeEnd = 69382, XrefRangeStart = 69374, XrefRangeEnd = 69382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRotationArc3DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRotationArc3DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00008B38 File Offset: 0x00006D38
		public GizmoRotationArc3DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00061578 File Offset: 0x0005F778
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x00008B41 File Offset: 0x00006D41
		public unsafe bool _useShortestRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__useShortestRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__useShortestRotation)) = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000615A0 File Offset: 0x0005F7A0
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x00008B5C File Offset: 0x00006D5C
		public unsafe GizmoRotationArcFillFlags _fillFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__fillFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArcFillFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__fillFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000615D0 File Offset: 0x0005F7D0
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x00008B7B File Offset: 0x00006D7B
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x00061600 File Offset: 0x0005F800
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00008B9A File Offset: 0x00006D9A
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeFieldInfoPtr__useShortestRotation;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeFieldInfoPtr__fillFlags;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_get_UseShortestRotation_Public_get_Boolean_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_set_UseShortestRotation_Public_set_Void_Boolean_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_FillFlags_Public_get_GizmoRotationArcFillFlags_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_set_FillFlags_Public_set_Void_GizmoRotationArcFillFlags_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
