using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F7 RID: 247
	public class SphereTreeNodeRayHit<T> : global::Il2CppSystem.Object
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x0007FB94 File Offset: 0x0007DD94
		// Note: this type is marked as 'beforefieldinit'.
		static SphereTreeNodeRayHit()
		{
			Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereTreeNodeRayHit`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr);
			SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, "_hitNode");
			SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, "_hitPoint");
			SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, "_hitEnter");
			SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitNode_Public_get_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, 100666872);
			SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, 100666873);
			SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, 100666874);
			SphereTreeNodeRayHit<T>.NativeMethodInfoPtr__ctor_Public_Void_Ray_SphereTreeNode_1_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr, 100666875);
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0007FC8C File Offset: 0x0007DE8C
		public unsafe SphereTreeNode<T> HitNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitNode_Public_get_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0007FCCC File Offset: 0x0007DECC
		public unsafe Vector3 HitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0007FD0C File Offset: 0x0007DF0C
		public unsafe float HitEnter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNodeRayHit<T>.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0007FD48 File Offset: 0x0007DF48
		[CallerCount(0)]
		public unsafe SphereTreeNodeRayHit(Ray ray, SphereTreeNode<T> hitNode, float hitEnter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereTreeNodeRayHit<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitNode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNodeRayHit<T>.NativeMethodInfoPtr__ctor_Public_Void_Ray_SphereTreeNode_1_T_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0000AA49 File Offset: 0x00008C49
		public SphereTreeNodeRayHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0007FDB4 File Offset: 0x0007DFB4
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0000AA52 File Offset: 0x00008C52
		public unsafe SphereTreeNode<T> _hitNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0007FDE4 File Offset: 0x0007DFE4
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0000AA71 File Offset: 0x00008C71
		public unsafe Vector3 _hitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0007FE14 File Offset: 0x0007E014
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0000AA90 File Offset: 0x00008C90
		public unsafe float _hitEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNodeRayHit<T>.NativeFieldInfoPtr__hitEnter)) = value;
			}
		}

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr__hitNode;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr__hitPoint;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr__hitEnter;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_get_HitNode_Public_get_SphereTreeNode_1_T_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_SphereTreeNode_1_T_Single_0;
	}
}
