using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F6 RID: 246
	public class SphereTreeNode<T> : global::Il2CppSystem.Object
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x0007F100 File Offset: 0x0007D300
		// Note: this type is marked as 'beforefieldinit'.
		static SphereTreeNode()
		{
			Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereTreeNode`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr);
			SphereTreeNode<T>.NativeFieldInfoPtr__stackTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_stackTop");
			SphereTreeNode<T>.NativeFieldInfoPtr__stackPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_stackPrevious");
			SphereTreeNode<T>.NativeFieldInfoPtr__sphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_sphere");
			SphereTreeNode<T>.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_data");
			SphereTreeNode<T>.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_parent");
			SphereTreeNode<T>.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_children");
			SphereTreeNode<T>.NativeFieldInfoPtr__numChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, "_numChildren");
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Children_Public_get_Il2CppReferenceArray_1_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666850);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666851);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666852);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Sphere_Public_get_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666855);
			SphereTreeNode<T>.NativeMethodInfoPtr_set_Sphere_Public_set_Void_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666856);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666857);
			SphereTreeNode<T>.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666858);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666859);
			SphereTreeNode<T>.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666860);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Parent_Public_get_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666861);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_Data_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666862);
			SphereTreeNode<T>.NativeMethodInfoPtr_set_Data_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666863);
			SphereTreeNode<T>.NativeMethodInfoPtr_get_StackTop_Public_get_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666864);
			SphereTreeNode<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666853);
			SphereTreeNode<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666854);
			SphereTreeNode<T>.NativeMethodInfoPtr_StackPush_Public_Void_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666865);
			SphereTreeNode<T>.NativeMethodInfoPtr_StackPop_Public_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666866);
			SphereTreeNode<T>.NativeMethodInfoPtr_IsOutsideParent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666867);
			SphereTreeNode<T>.NativeMethodInfoPtr_ClosestChild_Public_SphereTreeNode_1_T_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666868);
			SphereTreeNode<T>.NativeMethodInfoPtr_SetParent_Public_Void_SphereTreeNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666869);
			SphereTreeNode<T>.NativeMethodInfoPtr_EncapsulateChildrenBottomUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666870);
			SphereTreeNode<T>.NativeMethodInfoPtr_DebugDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr, 100666871);
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		public unsafe Il2CppReferenceArray<SphereTreeNode<T>> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Children_Public_get_Il2CppReferenceArray_1_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SphereTreeNode<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0007F3F0 File Offset: 0x0007D5F0
		public unsafe int NumChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x0007F42C File Offset: 0x0007D62C
		public unsafe bool IsLeaf
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0007F468 File Offset: 0x0007D668
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
		public unsafe Sphere Sphere
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Sphere_Public_get_Sphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sphere>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_set_Sphere_Public_set_Void_Sphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0007F4EC File Offset: 0x0007D6EC
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x0007F52C File Offset: 0x0007D72C
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0007F570 File Offset: 0x0007D770
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0007F5AC File Offset: 0x0007D7AC
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		public unsafe SphereTreeNode<T> Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Parent_Public_get_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x0007F62C File Offset: 0x0007D82C
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0007F668 File Offset: 0x0007D868
		public unsafe T Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_Data_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_set_Data_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x0007F6E0 File Offset: 0x0007D8E0
		public unsafe SphereTreeNode<T> StackTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_get_StackTop_Public_get_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0007F720 File Offset: 0x0007D920
		[CallerCount(0)]
		public unsafe SphereTreeNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0007F75C File Offset: 0x0007D95C
		[CallerCount(0)]
		public unsafe SphereTreeNode(T data, Sphere sphere)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereTreeNode<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = data;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref data;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphere);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Sphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0007F7F0 File Offset: 0x0007D9F0
		[CallerCount(0)]
		public unsafe void StackPush(SphereTreeNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_StackPush_Public_Void_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0007F834 File Offset: 0x0007DA34
		[CallerCount(0)]
		public unsafe SphereTreeNode<T> StackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_StackPop_Public_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr3) : null;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0007F874 File Offset: 0x0007DA74
		[CallerCount(0)]
		public unsafe bool IsOutsideParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_IsOutsideParent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
		[CallerCount(0)]
		public unsafe SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_ClosestChild_Public_SphereTreeNode_1_T_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0007F900 File Offset: 0x0007DB00
		[CallerCount(0)]
		public unsafe void SetParent(SphereTreeNode<T> newParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_SetParent_Public_Void_SphereTreeNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0007F944 File Offset: 0x0007DB44
		[CallerCount(0)]
		public unsafe void EncapsulateChildrenBottomUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_EncapsulateChildrenBottomUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0007F978 File Offset: 0x0007DB78
		[CallerCount(0)]
		public unsafe void DebugDraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereTreeNode<T>.NativeMethodInfoPtr_DebugDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000A98A File Offset: 0x00008B8A
		public SphereTreeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0007F9AC File Offset: 0x0007DBAC
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x0000A993 File Offset: 0x00008B93
		public unsafe SphereTreeNode<T> _stackTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__stackTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__stackTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0007F9DC File Offset: 0x0007DBDC
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public unsafe SphereTreeNode<T> _stackPrevious
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__stackPrevious);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__stackPrevious), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0007FA0C File Offset: 0x0007DC0C
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		public unsafe Sphere _sphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__sphere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sphere>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__sphere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x0007FA3C File Offset: 0x0007DC3C
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x0007FA64 File Offset: 0x0007DC64
		public unsafe T _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__data);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__data);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0007FB0C File Offset: 0x0007DD0C
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		public unsafe SphereTreeNode<T> _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTreeNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0007FB3C File Offset: 0x0007DD3C
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000AA0F File Offset: 0x00008C0F
		public unsafe Il2CppReferenceArray<SphereTreeNode<T>> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SphereTreeNode<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0007FB6C File Offset: 0x0007DD6C
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000AA2E File Offset: 0x00008C2E
		public unsafe int _numChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__numChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereTreeNode<T>.NativeFieldInfoPtr__numChildren)) = value;
			}
		}

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr__stackTop;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeFieldInfoPtr__stackPrevious;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeFieldInfoPtr__sphere;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeFieldInfoPtr__numChildren;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_Il2CppReferenceArray_1_SphereTreeNode_1_T_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_Sphere_Public_get_Sphere_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_set_Sphere_Public_set_Void_Sphere_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_SphereTreeNode_1_T_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_T_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_T_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTop_Public_get_SphereTreeNode_1_T_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Sphere_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Public_Void_SphereTreeNode_1_T_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Public_SphereTreeNode_1_T_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_IsOutsideParent_Public_Boolean_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_ClosestChild_Public_SphereTreeNode_1_T_SphereTreeNode_1_T_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_SphereTreeNode_1_T_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_EncapsulateChildrenBottomUp_Public_Void_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_0;
	}
}
