using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000179 RID: 377
	[StructLayout(2)]
	public struct Sphere
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x00099E74 File Offset: 0x00098074
		// Note: this type is marked as 'beforefieldinit'.
		static Sphere()
		{
			Il2CppClassPointerStore<Sphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Sphere");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sphere>.NativeClassPtr);
			Sphere.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sphere>.NativeClassPtr, "_center");
			Sphere.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sphere>.NativeClassPtr, "_radius");
			Sphere.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667913);
			Sphere.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667914);
			Sphere.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667915);
			Sphere.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667916);
			Sphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667917);
			Sphere.NativeMethodInfoPtr__ctor_Public_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667918);
			Sphere.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667919);
			Sphere.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667920);
			Sphere.NativeMethodInfoPtr_GetRightUpExtents_Public_List_1_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667921);
			Sphere.NativeMethodInfoPtr_Encapsulate_Public_Void_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sphere>.NativeClassPtr, 100667922);
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00099F94 File Offset: 0x00098194
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00099FC8 File Offset: 0x000981C8
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0009A000 File Offset: 0x00098200
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0009A030 File Offset: 0x00098230
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0009A064 File Offset: 0x00098264
		[CallerCount(0)]
		public unsafe Sphere(Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0009A0A8 File Offset: 0x000982A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 81488, RefRangeEnd = 81493, XrefRangeStart = 81486, XrefRangeEnd = 81488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sphere(AABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr__ctor_Public_Void_AABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0009A0E0 File Offset: 0x000982E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81511, RefRangeEnd = 81512, XrefRangeStart = 81493, XrefRangeEnd = 81511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sphere(IEnumerable<Vector3> pointCloud)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointCloud);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0009A118 File Offset: 0x00098318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81512, RefRangeEnd = 81513, XrefRangeStart = 81512, XrefRangeEnd = 81512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0009A15C File Offset: 0x0009835C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81514, RefRangeEnd = 81515, XrefRangeStart = 81513, XrefRangeEnd = 81514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(right);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_GetRightUpExtents_Public_List_1_Vector3_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0009A1B4 File Offset: 0x000983B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81515, XrefRangeEnd = 81520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Sphere sphere)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sphere);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sphere.NativeMethodInfoPtr_Encapsulate_Public_Void_Sphere_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0000C614 File Offset: 0x0000A814
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sphere>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AABB_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_GetRightUpExtents_Public_List_1_Vector3_Vector3_Vector3_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Sphere_0;

		// Token: 0x040017D2 RID: 6098
		[FieldOffset(0)]
		public IntPtr _center;

		// Token: 0x040017D3 RID: 6099
		[FieldOffset(12)]
		public float _radius;
	}
}
