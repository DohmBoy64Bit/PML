using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000123 RID: 291
	public class FrameworkBase : Object
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x0006F090 File Offset: 0x0006D290
		// Note: this type is marked as 'beforefieldinit'.
		static FrameworkBase()
		{
			Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Compatibility.Frameworks", "FrameworkBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr);
			FrameworkBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667147);
			FrameworkBase.NativeMethodInfoPtr_StringContainsChar_Public_Abstract_Virtual_New_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667115);
			FrameworkBase.NativeMethodInfoPtr_IsValueType_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667116);
			FrameworkBase.NativeMethodInfoPtr_GetAssembly_Public_Abstract_Virtual_New_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667117);
			FrameworkBase.NativeMethodInfoPtr_GetBaseType_Public_Abstract_Virtual_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667118);
			FrameworkBase.NativeMethodInfoPtr_IsGenericType_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667119);
			FrameworkBase.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667120);
			FrameworkBase.NativeMethodInfoPtr_IsEnum_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667121);
			FrameworkBase.NativeMethodInfoPtr_IsNestedPublic_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667122);
			FrameworkBase.NativeMethodInfoPtr_IsAbstract_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667123);
			FrameworkBase.NativeMethodInfoPtr_IsInterface_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667124);
			FrameworkBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667125);
			FrameworkBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667126);
			FrameworkBase.NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667127);
			FrameworkBase.NativeMethodInfoPtr_IsInstanceOfType_Public_Abstract_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667128);
			FrameworkBase.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667129);
			FrameworkBase.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667130);
			FrameworkBase.NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667131);
			FrameworkBase.NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667132);
			FrameworkBase.NativeMethodInfoPtr_GetInterface_Public_Abstract_Virtual_New_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667133);
			FrameworkBase.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667134);
			FrameworkBase.NativeMethodInfoPtr_GetProperty_Public_Abstract_Virtual_New_PropertyInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667135);
			FrameworkBase.NativeMethodInfoPtr_GetNestedTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667136);
			FrameworkBase.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EventInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667137);
			FrameworkBase.NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667138);
			FrameworkBase.NativeMethodInfoPtr_GetAssemblyTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667139);
			FrameworkBase.NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667140);
			FrameworkBase.NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667141);
			FrameworkBase.NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667142);
			FrameworkBase.NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667143);
			FrameworkBase.NativeMethodInfoPtr_IsAssignableFrom_Public_Abstract_Virtual_New_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667144);
			FrameworkBase.NativeMethodInfoPtr_IsDbNull_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667145);
			FrameworkBase.NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr, 100667146);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0006F354 File Offset: 0x0006D554
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameworkBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameworkBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0006F390 File Offset: 0x0006D590
		[CallerCount(0)]
		public unsafe virtual bool StringContainsChar(string str, char chr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_StringContainsChar_Public_Abstract_Virtual_New_Boolean_String_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0006F3F8 File Offset: 0x0006D5F8
		[CallerCount(0)]
		public unsafe virtual bool IsValueType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsValueType_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0006F450 File Offset: 0x0006D650
		[CallerCount(0)]
		public unsafe virtual Assembly GetAssembly(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetAssembly_Public_Abstract_Virtual_New_Assembly_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		[CallerCount(0)]
		public unsafe virtual Type GetBaseType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetBaseType_Public_Abstract_Virtual_New_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0006F508 File Offset: 0x0006D708
		[CallerCount(0)]
		public unsafe virtual bool IsGenericType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsGenericType_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0006F560 File Offset: 0x0006D760
		[CallerCount(0)]
		public unsafe virtual bool IsGenericTypeDefinition(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		[CallerCount(0)]
		public unsafe virtual bool IsEnum(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsEnum_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0006F610 File Offset: 0x0006D810
		[CallerCount(0)]
		public unsafe virtual bool IsNestedPublic(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsNestedPublic_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0006F668 File Offset: 0x0006D868
		[CallerCount(0)]
		public unsafe virtual bool IsAbstract(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsAbstract_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0006F6C0 File Offset: 0x0006D8C0
		[CallerCount(0)]
		public unsafe virtual bool IsInterface(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsInterface_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0006F718 File Offset: 0x0006D918
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Attribute> GetCustomAttributes(Type t, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0006F784 File Offset: 0x0006D984
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Attribute> GetCustomAttributes(Type t, Type at, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(at);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0006F800 File Offset: 0x0006DA00
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetInterfaces(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0006F85C File Offset: 0x0006DA5C
		[CallerCount(0)]
		public unsafe virtual bool IsInstanceOfType(Type t, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsInstanceOfType_Public_Abstract_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetAddMethod(EventInfo ei)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0006F924 File Offset: 0x0006DB24
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetRemoveMethod(EventInfo ei)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0006F980 File Offset: 0x0006DB80
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetGetMethod(PropertyInfo pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0006F9DC File Offset: 0x0006DBDC
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetSetMethod(PropertyInfo pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0006FA38 File Offset: 0x0006DC38
		[CallerCount(0)]
		public unsafe virtual Type GetInterface(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetInterface_Public_Abstract_Virtual_New_Type_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0006FAA8 File Offset: 0x0006DCA8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<PropertyInfo> GetProperties(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0006FB04 File Offset: 0x0006DD04
		[CallerCount(0)]
		public unsafe virtual PropertyInfo GetProperty(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetProperty_Public_Abstract_Virtual_New_PropertyInfo_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0006FB74 File Offset: 0x0006DD74
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetNestedTypes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetNestedTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0006FBD0 File Offset: 0x0006DDD0
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<EventInfo> GetEvents(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EventInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0006FC2C File Offset: 0x0006DE2C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ConstructorInfo> GetConstructors(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0006FC88 File Offset: 0x0006DE88
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetAssemblyTypes(Assembly asm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetAssemblyTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<MethodInfo> GetMethods(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0006FD40 File Offset: 0x0006DF40
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<FieldInfo> GetFields(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0006FD9C File Offset: 0x0006DF9C
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetMethod(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0006FE0C File Offset: 0x0006E00C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetGenericArguments(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0006FE68 File Offset: 0x0006E068
		[CallerCount(0)]
		public unsafe virtual bool IsAssignableFrom(Type current, Type toCompare)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toCompare);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsAssignableFrom_Public_Abstract_Virtual_New_Boolean_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0006FED4 File Offset: 0x0006E0D4
		[CallerCount(0)]
		public unsafe virtual bool IsDbNull(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_IsDbNull_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0006FF2C File Offset: 0x0006E12C
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetMethod(Type resourcesType, string v, Il2CppReferenceArray<Type> type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourcesType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkBase.NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00008477 File Offset: 0x00006677
		public FrameworkBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_StringContainsChar_Public_Abstract_Virtual_New_Boolean_String_Char_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Public_Abstract_Virtual_New_Assembly_Type_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Public_Abstract_Virtual_New_Type_Type_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericType_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_IsNestedPublic_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_IsAbstract_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_IsInterface_Public_Abstract_Virtual_New_Boolean_Type_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Boolean_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Abstract_Virtual_New_Boolean_Type_Object_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_EventInfo_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_PropertyInfo_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_GetInterface_Public_Abstract_Virtual_New_Type_Type_String_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_Type_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Abstract_Virtual_New_PropertyInfo_Type_String_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EventInfo_Type_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_Type_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Assembly_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Type_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_Type_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Abstract_Virtual_New_Boolean_Type_Type_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_IsDbNull_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Abstract_Virtual_New_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;
	}
}
