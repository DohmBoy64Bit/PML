using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A4 RID: 164
	public class PropertyTableAssigner<T> : Object
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x00048AFC File Offset: 0x00046CFC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyTableAssigner()
		{
			Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "PropertyTableAssigner`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr);
			PropertyTableAssigner<T>.NativeFieldInfoPtr_m_InternalAssigner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, "m_InternalAssigner");
			PropertyTableAssigner<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665541);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665542);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_AssignObject_Public_Void_T_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665543);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_GetTypeUnsafeAssigner_Public_PropertyTableAssigner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665544);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665545);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_SetSubassigner_Public_Void_PropertyTableAssigner_1_SubassignerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665546);
			PropertyTableAssigner<T>.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr, 100665547);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00048C08 File Offset: 0x00046E08
		[CallerCount(0)]
		public unsafe PropertyTableAssigner([Optional] Il2CppStringArray expectedMissingProperties)
		{
			if (expectedMissingProperties == null)
			{
				expectedMissingProperties = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyTableAssigner<T>>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expectedMissingProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00048C60 File Offset: 0x00046E60
		[CallerCount(0)]
		public unsafe void AddExpectedMissingProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00048CA4 File Offset: 0x00046EA4
		[CallerCount(0)]
		public unsafe void AssignObject(T obj, Table data)
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
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr_AssignObject_Public_Void_T_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00048D30 File Offset: 0x00046F30
		[CallerCount(0)]
		public unsafe PropertyTableAssigner GetTypeUnsafeAssigner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr_GetTypeUnsafeAssigner_Public_PropertyTableAssigner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTableAssigner>(intPtr3) : null;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00048D70 File Offset: 0x00046F70
		[CallerCount(0)]
		public unsafe void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assigner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00048DC4 File Offset: 0x00046FC4
		[CallerCount(0)]
		public unsafe void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assigner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<SubassignerType>.MethodInfoStoreGeneric_SetSubassigner_Public_Void_PropertyTableAssigner_1_SubassignerType_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00048E08 File Offset: 0x00047008
		[CallerCount(0)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked(Object o, Table data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner<T>.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public PropertyTableAssigner(params string[] expectedMissingProperties)
			: this(new Il2CppStringArray(expectedMissingProperties))
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00005D06 File Offset: 0x00003F06
		public PropertyTableAssigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00048E5C File Offset: 0x0004705C
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00005D0F File Offset: 0x00003F0F
		public unsafe PropertyTableAssigner m_InternalAssigner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner<T>.NativeFieldInfoPtr_m_InternalAssigner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyTableAssigner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner<T>.NativeFieldInfoPtr_m_InternalAssigner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalAssigner;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_AssignObject_Public_Void_T_Table_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeUnsafeAssigner_Public_PropertyTableAssigner_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_SetSubassigner_Public_Void_PropertyTableAssigner_1_SubassignerType_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0;

		// Token: 0x020001B0 RID: 432
		private sealed class MethodInfoStoreGeneric_SetSubassigner_Public_Void_PropertyTableAssigner_1_SubassignerType_0
		{
			// Token: 0x040015F9 RID: 5625
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyTableAssigner<SubassignerType>.NativeMethodInfoPtr_SetSubassigner_Public_Void_PropertyTableAssigner_1_SubassignerType_0, Il2CppClassPointerStore<PropertyTableAssigner<SubassignerType>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SubassignerType>.NativeClassPtr)) }))));
		}
	}
}
