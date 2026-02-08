using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000103 RID: 259
	public class FastStackDynamic<T> : List<T>
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x00065794 File Offset: 0x00063994
		// Note: this type is marked as 'beforefieldinit'.
		static FastStackDynamic()
		{
			Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.DataStructs", "FastStackDynamic`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr);
			FastStackDynamic<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666715);
			FastStackDynamic<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666716);
			FastStackDynamic<T>.NativeMethodInfoPtr_Push_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666717);
			FastStackDynamic<T>.NativeMethodInfoPtr_Expand_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666718);
			FastStackDynamic<T>.NativeMethodInfoPtr_Zero_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666719);
			FastStackDynamic<T>.NativeMethodInfoPtr_Peek_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666720);
			FastStackDynamic<T>.NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666721);
			FastStackDynamic<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666722);
			FastStackDynamic<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr, 100666723);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000658B4 File Offset: 0x00063AB4
		[CallerCount(0)]
		public unsafe FastStackDynamic(int startingCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastStackDynamic<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000658FC File Offset: 0x00063AFC
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00065984 File Offset: 0x00063B84
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Push_Public_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00065A04 File Offset: 0x00063C04
		[CallerCount(0)]
		public unsafe void Expand(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Expand_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00065A44 File Offset: 0x00063C44
		[CallerCount(0)]
		public unsafe void Zero(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Zero_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00065A84 File Offset: 0x00063C84
		[CallerCount(0)]
		public unsafe T Peek(int idxofs = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxofs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Peek_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00065ACC File Offset: 0x00063CCC
		[CallerCount(0)]
		public unsafe void CropAtCount(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00065B0C File Offset: 0x00063D0C
		[CallerCount(0)]
		public unsafe void RemoveLast(int cnt = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cnt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00065B4C File Offset: 0x00063D4C
		[CallerCount(0)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastStackDynamic<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0000802C File Offset: 0x0000622C
		public FastStackDynamic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_T_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_T_T_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Void_Int32_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_Zero_Public_Void_Int32_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_Int32_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_CropAtCount_Public_Void_Int32_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Void_Int32_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;
	}
}
