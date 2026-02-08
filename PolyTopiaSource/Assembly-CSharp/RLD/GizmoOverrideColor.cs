using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200002C RID: 44
	public class GizmoOverrideColor : global::Il2CppSystem.Object
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0002B1B8 File Offset: 0x000293B8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoOverrideColor()
		{
			Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoOverrideColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr);
			GizmoOverrideColor.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, "_isActive");
			GizmoOverrideColor.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, "_color");
			GizmoOverrideColor.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, 100663679);
			GizmoOverrideColor.NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, 100663680);
			GizmoOverrideColor.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, 100663681);
			GizmoOverrideColor.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, 100663682);
			GizmoOverrideColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr, 100663683);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0002B274 File Offset: 0x00029474
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0002B2B0 File Offset: 0x000294B0
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoOverrideColor.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoOverrideColor.NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0002B2F0 File Offset: 0x000294F0
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0002B330 File Offset: 0x00029530
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoOverrideColor.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoOverrideColor.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0002B374 File Offset: 0x00029574
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoOverrideColor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoOverrideColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoOverrideColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002ECA File Offset: 0x000010CA
		public GizmoOverrideColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0002B3B0 File Offset: 0x000295B0
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002ED3 File Offset: 0x000010D3
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoOverrideColor.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoOverrideColor.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0002B3D8 File Offset: 0x000295D8
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002EEE File Offset: 0x000010EE
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoOverrideColor.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoOverrideColor.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
