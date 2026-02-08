using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000078 RID: 120
	public class SceneGizmoAxisCap : SceneGizmoCap
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00043A30 File Offset: 0x00041C30
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoAxisCap()
		{
			Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoAxisCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr);
			SceneGizmoAxisCap.NativeFieldInfoPtr__axisDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_axisDesc");
			SceneGizmoAxisCap.NativeFieldInfoPtr__midAxisBoxFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_midAxisBoxFace");
			SceneGizmoAxisCap.NativeFieldInfoPtr__zoomFactorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_zoomFactorTransform");
			SceneGizmoAxisCap.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_color");
			SceneGizmoAxisCap.NativeFieldInfoPtr__colorTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_colorTransition");
			SceneGizmoAxisCap.NativeFieldInfoPtr__labelTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, "_labelTexture");
			SceneGizmoAxisCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664637);
			SceneGizmoAxisCap.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664638);
			SceneGizmoAxisCap.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664639);
			SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateHoverPermission_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664640);
			SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664641);
			SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateTransform_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664642);
			SceneGizmoAxisCap.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr, 100664643);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00043B64 File Offset: 0x00041D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63874, RefRangeEnd = 63875, XrefRangeStart = 63812, XrefRangeEnd = 63874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoAxisCap(SceneGizmo sceneGizmo, int id, AxisDescriptor gizmoAxisDesc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoAxisCap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmoAxisDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_AxisDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00043BD0 File Offset: 0x00041DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63875, XrefRangeEnd = 63935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneGizmoAxisCap.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00043C20 File Offset: 0x00041E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63935, XrefRangeEnd = 63944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00043C64 File Offset: 0x00041E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63944, XrefRangeEnd = 63947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHoverPermission()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateHoverPermission_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00043C98 File Offset: 0x00041E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63961, RefRangeEnd = 63962, XrefRangeStart = 63947, XrefRangeEnd = 63961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00043CCC File Offset: 0x00041ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63976, RefRangeEnd = 63977, XrefRangeStart = 63962, XrefRangeEnd = 63976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr_UpdateTransform_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00043D10 File Offset: 0x00041F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63977, XrefRangeEnd = 63989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoAxisCap.NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00004FB9 File Offset: 0x000031B9
		public SceneGizmoAxisCap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00043D60 File Offset: 0x00041F60
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00004FC2 File Offset: 0x000031C2
		public unsafe AxisDescriptor _axisDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__axisDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__axisDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00043D90 File Offset: 0x00041F90
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00004FE1 File Offset: 0x000031E1
		public unsafe BoxFace _midAxisBoxFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__midAxisBoxFace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxFace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__midAxisBoxFace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00043DC0 File Offset: 0x00041FC0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00005000 File Offset: 0x00003200
		public unsafe GizmoTransform _zoomFactorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__zoomFactorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__zoomFactorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00043DF0 File Offset: 0x00041FF0
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0000501F File Offset: 0x0000321F
		public unsafe ColorRef _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00043E20 File Offset: 0x00042020
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x0000503E File Offset: 0x0000323E
		public unsafe ColorTransition _colorTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__colorTransition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorTransition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__colorTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00043E50 File Offset: 0x00042050
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0000505D File Offset: 0x0000325D
		public unsafe Texture2D _labelTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__labelTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoAxisCap.NativeFieldInfoPtr__labelTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr__axisDesc;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr__midAxisBoxFace;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr__zoomFactorTransform;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr__colorTransition;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__labelTexture;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneGizmo_Int32_AxisDescriptor_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHoverPermission_Private_Void_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColor_Private_Void_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Private_Void_Camera_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandlePicked_Private_Void_Gizmo_Int32_0;
	}
}
