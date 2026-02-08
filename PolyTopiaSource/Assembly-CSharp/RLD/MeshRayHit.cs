using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B4 RID: 436
	public class MeshRayHit : global::Il2CppSystem.Object
	{
		// Token: 0x060021C3 RID: 8643 RVA: 0x000A75B0 File Offset: 0x000A57B0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshRayHit()
		{
			Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshRayHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr);
			MeshRayHit.NativeFieldInfoPtr__hitTriangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, "_hitTriangleIndex");
			MeshRayHit.NativeFieldInfoPtr__hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, "_hitPoint");
			MeshRayHit.NativeFieldInfoPtr__hitEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, "_hitEnter");
			MeshRayHit.NativeFieldInfoPtr__hitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, "_hitNormal");
			MeshRayHit.NativeMethodInfoPtr_get_HitTriangleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, 100668415);
			MeshRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, 100668416);
			MeshRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, 100668417);
			MeshRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, 100668418);
			MeshRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_Int32_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr, 100668419);
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x000A7694 File Offset: 0x000A5894
		public unsafe int HitTriangleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRayHit.NativeMethodInfoPtr_get_HitTriangleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000A76D0 File Offset: 0x000A58D0
		public unsafe Vector3 HitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x000A7710 File Offset: 0x000A5910
		public unsafe float HitEnter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000A774C File Offset: 0x000A594C
		public unsafe Vector3 HitNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000A778C File Offset: 0x000A598C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86295, RefRangeEnd = 86296, XrefRangeStart = 86290, XrefRangeEnd = 86295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitTriangleIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitEnter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitNormal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_Int32_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public MeshRayHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x000A7808 File Offset: 0x000A5A08
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x0000DC59 File Offset: 0x0000BE59
		public unsafe int _hitTriangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitTriangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitTriangleIndex)) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x000A7830 File Offset: 0x000A5A30
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x0000DC74 File Offset: 0x0000BE74
		public unsafe Vector3 _hitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000A7860 File Offset: 0x000A5A60
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x0000DC93 File Offset: 0x0000BE93
		public unsafe float _hitEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitEnter)) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x000A7888 File Offset: 0x000A5A88
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0000DCAE File Offset: 0x0000BEAE
		public unsafe Vector3 _hitNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshRayHit.NativeFieldInfoPtr__hitNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeFieldInfoPtr__hitTriangleIndex;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeFieldInfoPtr__hitPoint;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeFieldInfoPtr__hitEnter;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeFieldInfoPtr__hitNormal;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_get_HitTriangleIndex_Public_get_Int32_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_Int32_Single_Vector3_0;
	}
}
