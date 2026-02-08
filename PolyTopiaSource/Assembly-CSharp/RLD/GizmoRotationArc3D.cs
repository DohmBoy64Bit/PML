using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D4 RID: 212
	public class GizmoRotationArc3D : global::Il2CppSystem.Object
	{
		// Token: 0x06001119 RID: 4377 RVA: 0x00060F14 File Offset: 0x0005F114
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRotationArc3D()
		{
			Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRotationArc3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr);
			GizmoRotationArc3D.NativeFieldInfoPtr__arc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, "_arc");
			GizmoRotationArc3D.NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665623);
			GizmoRotationArc3D.NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665624);
			GizmoRotationArc3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665625);
			GizmoRotationArc3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665626);
			GizmoRotationArc3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665629);
			GizmoRotationArc3D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665627);
			GizmoRotationArc3D.NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr, 100665628);
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00060FE4 File Offset: 0x0005F1E4
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00061020 File Offset: 0x0005F220
		public unsafe float RotationAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69384, RefRangeEnd = 69386, XrefRangeStart = 69382, XrefRangeEnd = 69384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00061060 File Offset: 0x0005F260
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x0006109C File Offset: 0x0005F29C
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69388, RefRangeEnd = 69390, XrefRangeStart = 69386, XrefRangeEnd = 69388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000610DC File Offset: 0x0005F2DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69396, RefRangeEnd = 69398, XrefRangeStart = 69390, XrefRangeEnd = 69396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRotationArc3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRotationArc3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00061118 File Offset: 0x0005F318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69398, XrefRangeEnd = 69405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArcData(Vector3 rotationAxis, Vector3 arcOrigin, Vector3 arcStart, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotationAxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStart);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_SetArcData_Public_Void_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0006118C File Offset: 0x0005F38C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69427, RefRangeEnd = 69429, XrefRangeStart = 69405, XrefRangeEnd = 69427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(GizmoRotationArc3DLookAndFeel lookAndFeel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookAndFeel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRotationArc3D.NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00008B10 File Offset: 0x00006D10
		public GizmoRotationArc3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000611D0 File Offset: 0x0005F3D0
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00008B19 File Offset: 0x00006D19
		public unsafe ArcShape3D _arc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3D.NativeFieldInfoPtr__arc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArcShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRotationArc3D.NativeFieldInfoPtr__arc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr__arc;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationAngle_Public_get_Single_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationAngle_Public_set_Void_Single_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_SetArcData_Public_Void_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_GizmoRotationArc3DLookAndFeel_0;
	}
}
