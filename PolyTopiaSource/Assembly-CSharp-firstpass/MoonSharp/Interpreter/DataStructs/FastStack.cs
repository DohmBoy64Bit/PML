using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000102 RID: 258
	public class FastStack<T> : Object
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x00064B14 File Offset: 0x00062D14
		// Note: this type is marked as 'beforefieldinit'.
		static FastStack()
		{
			Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.DataStructs", "FastStack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr);
			FastStack<T>.NativeFieldInfoPtr_m_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, "m_Storage");
			FastStack<T>.NativeFieldInfoPtr_m_HeadIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, "m_HeadIdx");
			FastStack<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666688);
			FastStack<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666689);
			FastStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666700);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666704);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666705);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666710);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666711);
			FastStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666687);
			FastStack<T>.NativeMethodInfoPtr_Push_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666690);
			FastStack<T>.NativeMethodInfoPtr_Zero_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666691);
			FastStack<T>.NativeMethodInfoPtr_Zero_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666692);
			FastStack<T>.NativeMethodInfoPtr_Peek_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666693);
			FastStack<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666694);
			FastStack<T>.NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666695);
			FastStack<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666696);
			FastStack<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666697);
			FastStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666698);
			FastStack<T>.NativeMethodInfoPtr_ClearUsed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666699);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666701);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666702);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666703);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666706);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666707);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666708);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666709);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666712);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666713);
			FastStack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr, 100666714);
		}

		// Token: 0x170004BD RID: 1213
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00064EA8 File Offset: 0x000630A8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00064EE4 File Offset: 0x000630E4
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x00064F2C File Offset: 0x0006312C
		public unsafe virtual T System.Collections.Generic.IList<T>.Item
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00064FB4 File Offset: 0x000631B4
		public unsafe virtual int System.Collections.Generic.ICollection<T>.Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00064FF0 File Offset: 0x000631F0
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0006502C File Offset: 0x0006322C
		[CallerCount(0)]
		public unsafe FastStack(int maxCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastStack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00065074 File Offset: 0x00063274
		[CallerCount(0)]
		public unsafe T Push(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Push_Public_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000650F4 File Offset: 0x000632F4
		[CallerCount(0)]
		public unsafe void Zero(int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Zero_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00065140 File Offset: 0x00063340
		[CallerCount(0)]
		public unsafe void Zero(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Zero_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00065180 File Offset: 0x00063380
		[CallerCount(0)]
		public unsafe T Peek(int idxofs = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxofs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Peek_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000651C8 File Offset: 0x000633C8
		[CallerCount(0)]
		public unsafe void Set(int idxofs, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxofs;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00065250 File Offset: 0x00063450
		[CallerCount(0)]
		public unsafe void CropAtCount(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00065290 File Offset: 0x00063490
		[CallerCount(0)]
		public unsafe void RemoveLast(int cnt = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cnt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000652D0 File Offset: 0x000634D0
		[CallerCount(0)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0006530C File Offset: 0x0006350C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00065340 File Offset: 0x00063540
		[CallerCount(0)]
		public unsafe void ClearUsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_ClearUsed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00065374 File Offset: 0x00063574
		[CallerCount(0)]
		public unsafe virtual int System_Collections_Generic_IList_T__IndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x000653F8 File Offset: 0x000635F8
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_IList_T__Insert(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00065480 File Offset: 0x00063680
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_IList_T__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000654C0 File Offset: 0x000636C0
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00065538 File Offset: 0x00063738
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0006556C File Offset: 0x0006376C
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_Generic_ICollection_T__Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000655F0 File Offset: 0x000637F0
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00065640 File Offset: 0x00063840
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_Generic_ICollection_T__Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x000656C4 File Offset: 0x000638C4
		[CallerCount(0)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00065704 File Offset: 0x00063904
		[CallerCount(0)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00007FE9 File Offset: 0x000061E9
		public FastStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00065744 File Offset: 0x00063944
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00007FF2 File Offset: 0x000061F2
		public unsafe Il2CppArrayBase<T> m_Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastStack<T>.NativeFieldInfoPtr_m_Storage);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastStack<T>.NativeFieldInfoPtr_m_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0006576C File Offset: 0x0006396C
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00008011 File Offset: 0x00006211
		public unsafe int m_HeadIdx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastStack<T>.NativeFieldInfoPtr_m_HeadIdx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastStack<T>.NativeFieldInfoPtr_m_HeadIdx)) = value;
			}
		}

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_m_Storage;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr_m_HeadIdx;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_T_T_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_Zero_Private_Void_Int32_Int32_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_Zero_Private_Void_Int32_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_Int32_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_T_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_ClearUsed_Public_Void_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}
