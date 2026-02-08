using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000104 RID: 260
	public class LinkedListIndex<TKey, TValue> : Object
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x00065B88 File Offset: 0x00063D88
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedListIndex()
		{
			Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.DataStructs", "LinkedListIndex`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr);
			LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_LinkedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, "m_LinkedList");
			LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, "m_Map");
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_LinkedList_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666724);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Find_Public_LinkedListNode_1_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666725);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Set_Public_TValue_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666726);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666727);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666728);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666729);
			LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr, 100666730);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00065CBC File Offset: 0x00063EBC
		[CallerCount(0)]
		public unsafe LinkedListIndex(LinkedList<TValue> linkedList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedListIndex<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linkedList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_LinkedList_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00065D08 File Offset: 0x00063F08
		[CallerCount(0)]
		public unsafe LinkedListNode<TValue> Find(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Find_Public_LinkedListNode_1_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<TValue>>(intPtr4) : null;
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00065D90 File Offset: 0x00063F90
		[CallerCount(0)]
		public unsafe TValue Set(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Set_Public_TValue_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr3, false, true);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00065E58 File Offset: 0x00064058
		[CallerCount(0)]
		public unsafe void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00065F18 File Offset: 0x00064118
		[CallerCount(0)]
		public unsafe bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00065F9C File Offset: 0x0006419C
		[CallerCount(0)]
		public unsafe bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00066020 File Offset: 0x00064220
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListIndex<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00008035 File Offset: 0x00006235
		public LinkedListIndex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00066054 File Offset: 0x00064254
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0000803E File Offset: 0x0000623E
		public unsafe LinkedList<TValue> m_LinkedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_LinkedList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_LinkedList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00066084 File Offset: 0x00064284
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000805D File Offset: 0x0000625D
		public unsafe Dictionary<TKey, LinkedListNode<TValue>> m_Map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_Map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, LinkedListNode<TValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListIndex<TKey, TValue>.NativeFieldInfoPtr_m_Map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_m_LinkedList;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_m_Map;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LinkedList_1_TValue_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_LinkedListNode_1_TValue_TKey_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_TValue_TKey_TValue_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
