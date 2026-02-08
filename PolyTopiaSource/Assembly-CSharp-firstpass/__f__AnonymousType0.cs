using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
[ObfuscatedName("<>f__AnonymousType0`2")]
public sealed class __f__AnonymousType0<_t_j__TPar, _attributes_j__TPar> : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000FE04 File Offset: 0x0000E004
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType0()
	{
		Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "<>f__AnonymousType0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_t_j__TPar>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_attributes_j__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__t_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, "<t>i__Field");
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__attributes_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, "<attributes>i__Field");
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_get_t_Public_get__t_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663297);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_get_attributes_Public_get__attributes_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663298);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__t_j__TPar__attributes_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663299);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663300);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663301);
		__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr, 100663302);
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000002 RID: 2 RVA: 0x0000FF24 File Offset: 0x0000E124
	public unsafe _t_j__TPar t
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_get_t_Public_get__t_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_t_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000003 RID: 3 RVA: 0x0000FF60 File Offset: 0x0000E160
	public unsafe _attributes_j__TPar attributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_get_attributes_Public_get__attributes_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_attributes_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000FF9C File Offset: 0x0000E19C
	[CallerCount(0)]
	public unsafe __f__AnonymousType0(_t_j__TPar t, _attributes_j__TPar attributes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(_t_j__TPar).IsValueType)
			{
				_t_j__TPar t_j__TPar = t;
				intPtr = ((t_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(t_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(t_j__TPar as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref t;
			}
			ptr2 = intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(_attributes_j__TPar).IsValueType)
		{
			_attributes_j__TPar attributes_j__TPar = attributes;
			intPtr2 = ((attributes_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(attributes_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(attributes_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref attributes;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__t_j__TPar__attributes_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00010068 File Offset: 0x0000E268
	[CallerCount(0)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000100B8 File Offset: 0x0000E2B8
	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000100F4 File Offset: 0x0000E2F4
	[CallerCount(0)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	public __f__AnonymousType0(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000009 RID: 9 RVA: 0x0001012C File Offset: 0x0000E32C
	// (set) Token: 0x0600000A RID: 10 RVA: 0x00010154 File Offset: 0x0000E354
	public unsafe _t_j__TPar _t_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__t_i__Field);
			return IL2CPP.PointerToValueGeneric<_t_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__t_i__Field);
			Type typeFromHandle = typeof(_t_j__TPar);
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

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000B RID: 11 RVA: 0x000101FC File Offset: 0x0000E3FC
	// (set) Token: 0x0600000C RID: 12 RVA: 0x00010224 File Offset: 0x0000E424
	public unsafe _attributes_j__TPar _attributes_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__attributes_i__Field);
			return IL2CPP.PointerToValueGeneric<_attributes_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_t_j__TPar, _attributes_j__TPar>.NativeFieldInfoPtr__attributes_i__Field);
			Type typeFromHandle = typeof(_attributes_j__TPar);
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

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr__t_i__Field;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr__attributes_i__Field;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_get_t_Public_get__t_j__TPar_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_get_attributes_Public_get__attributes_j__TPar_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__t_j__TPar__attributes_j__TPar_0;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
