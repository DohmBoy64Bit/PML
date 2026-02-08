using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F5 RID: 245
	public class SphereTree<T> : global::Il2CppSystem.Object
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x0007ED1C File Offset: 0x0007CF1C
		// Note: this type is marked as 'beforefieldinit'.
		static SphereTree()
		{
			Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereTree`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr);
			SphereTree<T>.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, "_root");
			SphereTree<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666842);
			SphereTree<T>.NativeMethodInfoPtr_DebugDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666843);
			SphereTree<T>.NativeMethodInfoPtr_AddNode_Public_SphereTreeNode_1_T_T_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666844);
			SphereTree<T>.NativeMethodInfoPtr_RemoveNode_Public_Void_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666845);
			SphereTree<T>.NativeMethodInfoPtr_OnNodeSphereUpdated_Public_Void_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666846);
			SphereTree<T>.NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_List_1_SphereTreeNodeRayHit_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666847);
			SphereTree<T>.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666848);
			SphereTree<T>.NativeMethodInfoPtr_InsertNode_Private_Void_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr, 100666849);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0007EE3C File Offset: 0x0007D03C
		[CallerCount(0)]
		public unsafe SphereTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereTree<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0007EE78 File Offset: 0x0007D078
		[CallerCount(0)]
		public unsafe void DebugDraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_DebugDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0007EEAC File Offset: 0x0007D0AC
		[CallerCount(0)]
		public unsafe SphereTreeNode<T> AddNode(T nodeData, Sphere sphere)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = nodeData;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref nodeData;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphere);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_AddNode_Public_SphereTreeNode_1_T_T_Sphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr4) : null;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0007EF44 File Offset: 0x0007D144
		[CallerCount(0)]
		public unsafe void RemoveNode(SphereTreeNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_RemoveNode_Public_Void_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0007EF88 File Offset: 0x0007D188
		[CallerCount(0)]
		public unsafe void OnNodeSphereUpdated(SphereTreeNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_OnNodeSphereUpdated_Public_Void_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0007EFCC File Offset: 0x0007D1CC
		[CallerCount(0)]
		public unsafe bool RaycastAll(Ray ray, List<SphereTreeNodeRayHit<T>> hits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_List_1_SphereTreeNodeRayHit_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0007F02C File Offset: 0x0007D22C
		[CallerCount(0)]
		public unsafe bool OverlapBox(OBB box, List<SphereTreeNode<T>> nodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0007F08C File Offset: 0x0007D28C
		[CallerCount(0)]
		public unsafe void InsertNode(SphereTreeNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTree<T>.NativeMethodInfoPtr_InsertNode_Private_Void_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0000A962 File Offset: 0x00008B62
		public SphereTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0007F0D0 File Offset: 0x0007D2D0
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0000A96B File Offset: 0x00008B6B
		public unsafe SphereTreeNode<T> _root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTree<T>.NativeFieldInfoPtr__root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTree<T>.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Public_SphereTreeNode_1_T_T_Sphere_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNode_Public_Void_SphereTreeNode_1_T_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_OnNodeSphereUpdated_Public_Void_SphereTreeNode_1_T_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_List_1_SphereTreeNodeRayHit_1_T_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_SphereTreeNode_1_T_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_InsertNode_Private_Void_SphereTreeNode_1_T_0;
	}
}
