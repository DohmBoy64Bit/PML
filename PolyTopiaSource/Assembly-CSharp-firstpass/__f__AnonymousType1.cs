using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000003 RID: 3
[ObfuscatedName("<>f__AnonymousType1`2")]
public sealed class __f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar> : Object
{
	// Token: 0x0600000D RID: 13 RVA: 0x000102CC File Offset: 0x0000E4CC
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType1()
	{
		Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "<>f__AnonymousType1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Attributes_j__TPar>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_DataType_j__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__Attributes_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, "<Attributes>i__Field");
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__DataType_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, "<DataType>i__Field");
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_get_Attributes_Public_get__Attributes_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663303);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_get_DataType_Public_get__DataType_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663304);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__Attributes_j__TPar__DataType_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663305);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663306);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663307);
		__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr, 100663308);
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000103EC File Offset: 0x0000E5EC
	public unsafe _Attributes_j__TPar Attributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_get_Attributes_Public_get__Attributes_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_Attributes_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600000F RID: 15 RVA: 0x00010428 File Offset: 0x0000E628
	public unsafe _DataType_j__TPar DataType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_get_DataType_Public_get__DataType_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_DataType_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00010464 File Offset: 0x0000E664
	[CallerCount(0)]
	public unsafe __f__AnonymousType1(_Attributes_j__TPar Attributes, _DataType_j__TPar DataType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(_Attributes_j__TPar).IsValueType)
			{
				_Attributes_j__TPar attributes_j__TPar = Attributes;
				intPtr = ((attributes_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(attributes_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(attributes_j__TPar as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref Attributes;
			}
			ptr2 = intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(_DataType_j__TPar).IsValueType)
		{
			_DataType_j__TPar dataType_j__TPar = DataType;
			intPtr2 = ((dataType_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(dataType_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(dataType_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref DataType;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__Attributes_j__TPar__DataType_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00010530 File Offset: 0x0000E730
	[CallerCount(0)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00010580 File Offset: 0x0000E780
	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000105BC File Offset: 0x0000E7BC
	[CallerCount(0)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002059 File Offset: 0x00000259
	public __f__AnonymousType1(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000105F4 File Offset: 0x0000E7F4
	// (set) Token: 0x06000016 RID: 22 RVA: 0x0001061C File Offset: 0x0000E81C
	public unsafe _Attributes_j__TPar _Attributes_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__Attributes_i__Field);
			return IL2CPP.PointerToValueGeneric<_Attributes_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__Attributes_i__Field);
			Type typeFromHandle = typeof(_Attributes_j__TPar);
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

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000017 RID: 23 RVA: 0x000106C4 File Offset: 0x0000E8C4
	// (set) Token: 0x06000018 RID: 24 RVA: 0x000106EC File Offset: 0x0000E8EC
	public unsafe _DataType_j__TPar _DataType_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__DataType_i__Field);
			return IL2CPP.PointerToValueGeneric<_DataType_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_Attributes_j__TPar, _DataType_j__TPar>.NativeFieldInfoPtr__DataType_i__Field);
			Type typeFromHandle = typeof(_DataType_j__TPar);
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

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr__Attributes_i__Field;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr__DataType_i__Field;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get__Attributes_j__TPar_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get__DataType_j__TPar_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__Attributes_j__TPar__DataType_j__TPar_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
