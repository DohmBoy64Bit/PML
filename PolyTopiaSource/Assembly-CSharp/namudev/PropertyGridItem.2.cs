using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000247 RID: 583
	public class PropertyGridItem<T> : MonoBehaviour
	{
		// Token: 0x06002D7D RID: 11645 RVA: 0x000D3E90 File Offset: 0x000D2090
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItem()
		{
			Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridItem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr);
			PropertyGridItem<T>.NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, "ValueChanged");
			PropertyGridItem<T>.NativeFieldInfoPtr_binding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, "binding");
			PropertyGridItem<T>.NativeMethodInfoPtr_get_Caption_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670167);
			PropertyGridItem<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670168);
			PropertyGridItem<T>.NativeMethodInfoPtr_set_Value_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670169);
			PropertyGridItem<T>.NativeMethodInfoPtr_get_ValueType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670170);
			PropertyGridItem<T>.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670165);
			PropertyGridItem<T>.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670166);
			PropertyGridItem<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670172);
			PropertyGridItem<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670171);
			PropertyGridItem<T>.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr, 100670173);
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000D3FD8 File Offset: 0x000D21D8
		public unsafe string Caption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_get_Caption_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000D4010 File Offset: 0x000D2210
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x000D404C File Offset: 0x000D224C
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_set_Value_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000D40C4 File Offset: 0x000D22C4
		public unsafe Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_get_ValueType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x000D4104 File Offset: 0x000D2304
		[CallerCount(0)]
		public unsafe void add_ValueChanged(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000D4148 File Offset: 0x000D2348
		[CallerCount(0)]
		public unsafe void remove_ValueChanged(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000D418C File Offset: 0x000D238C
		[CallerCount(0)]
		public unsafe PropertyGridItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItem<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x000D41C8 File Offset: 0x000D23C8
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItem<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000D4204 File Offset: 0x000D2404
		[CallerCount(0)]
		public unsafe void _Awake_b__11_0(global::Il2CppSystem.Object o, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem<T>.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000121E8 File Offset: 0x000103E8
		public PropertyGridItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000D4258 File Offset: 0x000D2458
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x000121F1 File Offset: 0x000103F1
		public unsafe EventHandler ValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem<T>.NativeFieldInfoPtr_ValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem<T>.NativeFieldInfoPtr_ValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000D4288 File Offset: 0x000D2488
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00012210 File Offset: 0x00010410
		public unsafe PropertyGridBinding binding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem<T>.NativeFieldInfoPtr_binding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGridBinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem<T>.NativeFieldInfoPtr_binding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeFieldInfoPtr_ValueChanged;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeFieldInfoPtr_binding;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_get_Caption_Public_get_String_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_T_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_get_Type_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_Object_EventArgs_0;
	}
}
