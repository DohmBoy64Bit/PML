using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B1 RID: 433
	public class XZGridRayHit : global::Il2CppSystem.Object
	{
		// Token: 0x06002193 RID: 8595 RVA: 0x000A6BFC File Offset: 0x000A4DFC
		// Note: this type is marked as 'beforefieldinit'.
		static XZGridRayHit()
		{
			Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "XZGridRayHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr);
			XZGridRayHit.NativeFieldInfoPtr__hitCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, "_hitCell");
			XZGridRayHit.NativeFieldInfoPtr__hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, "_hitPoint");
			XZGridRayHit.NativeFieldInfoPtr__hitEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, "_hitEnter");
			XZGridRayHit.NativeFieldInfoPtr__hitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, "_hitNormal");
			XZGridRayHit.NativeFieldInfoPtr__hitPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, "_hitPlane");
			XZGridRayHit.NativeMethodInfoPtr_get_HitCell_Public_get_XZGridCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668395);
			XZGridRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668396);
			XZGridRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668397);
			XZGridRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668398);
			XZGridRayHit.NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668399);
			XZGridRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_XZGridCell_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr, 100668400);
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x000A6D08 File Offset: 0x000A4F08
		public unsafe XZGridCell HitCell
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr_get_HitCell_Public_get_XZGridCell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridCell>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000A6D48 File Offset: 0x000A4F48
		public unsafe Vector3 HitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x000A6D88 File Offset: 0x000A4F88
		public unsafe float HitEnter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000A6DC4 File Offset: 0x000A4FC4
		public unsafe Vector3 HitNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x000A6E04 File Offset: 0x000A5004
		public unsafe Plane HitPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000A6E44 File Offset: 0x000A5044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86282, XrefRangeEnd = 86287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XZGridRayHit(Ray ray, XZGridCell hitCell, float hitEnter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XZGridRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCell);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_XZGridCell_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0000DAC9 File Offset: 0x0000BCC9
		public XZGridRayHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000A6EB0 File Offset: 0x000A50B0
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x0000DAD2 File Offset: 0x0000BCD2
		public unsafe XZGridCell _hitCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitCell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XZGridCell>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitCell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000A6EE0 File Offset: 0x000A50E0
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x0000DAF1 File Offset: 0x0000BCF1
		public unsafe Vector3 _hitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x000A6F10 File Offset: 0x000A5110
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0000DB10 File Offset: 0x0000BD10
		public unsafe float _hitEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitEnter)) = value;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x000A6F38 File Offset: 0x000A5138
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x0000DB2B File Offset: 0x0000BD2B
		public unsafe Vector3 _hitNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000A6F68 File Offset: 0x000A5168
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x0000DB4A File Offset: 0x0000BD4A
		public unsafe Plane _hitPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridRayHit.NativeFieldInfoPtr__hitPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeFieldInfoPtr__hitCell;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeFieldInfoPtr__hitPoint;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeFieldInfoPtr__hitEnter;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeFieldInfoPtr__hitNormal;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeFieldInfoPtr__hitPlane;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_get_HitCell_Public_get_XZGridCell_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_XZGridCell_Single_0;
	}
}
