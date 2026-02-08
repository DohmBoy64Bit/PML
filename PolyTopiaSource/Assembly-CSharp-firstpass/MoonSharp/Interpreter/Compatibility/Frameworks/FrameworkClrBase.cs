using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000124 RID: 292
	public class FrameworkClrBase : FrameworkReflectionBase
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x0006FFAC File Offset: 0x0006E1AC
		// Note: this type is marked as 'beforefieldinit'.
		static FrameworkClrBase()
		{
			Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Compatibility.Frameworks", "FrameworkClrBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr);
			FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_MEMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, "BINDINGFLAGS_MEMBER");
			FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_INNERCLASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, "BINDINGFLAGS_INNERCLASS");
			FrameworkClrBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667166);
			FrameworkClrBase.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667148);
			FrameworkClrBase.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667149);
			FrameworkClrBase.NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667150);
			FrameworkClrBase.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667151);
			FrameworkClrBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667152);
			FrameworkClrBase.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667153);
			FrameworkClrBase.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667154);
			FrameworkClrBase.NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667155);
			FrameworkClrBase.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667156);
			FrameworkClrBase.NativeMethodInfoPtr_GetNestedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667157);
			FrameworkClrBase.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667158);
			FrameworkClrBase.NativeMethodInfoPtr_GetProperty_Public_Virtual_PropertyInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667159);
			FrameworkClrBase.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667160);
			FrameworkClrBase.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667161);
			FrameworkClrBase.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667162);
			FrameworkClrBase.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667163);
			FrameworkClrBase.NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667164);
			FrameworkClrBase.NativeMethodInfoPtr_GetAssemblyTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr, 100667165);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00070180 File Offset: 0x0006E380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51669, XrefRangeEnd = 51670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameworkClrBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameworkClrBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkClrBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000701BC File Offset: 0x0006E3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51670, XrefRangeEnd = 51671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetAddMethod(EventInfo ei)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_EventInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00070218 File Offset: 0x0006E418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51671, XrefRangeEnd = 51672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00070274 File Offset: 0x0006E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51672, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<EventInfo> GetEvents(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000702D0 File Offset: 0x0006E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51673, XrefRangeEnd = 51674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0007032C File Offset: 0x0006E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51674, XrefRangeEnd = 51675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00070388 File Offset: 0x0006E588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51675, XrefRangeEnd = 51676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetGetMethod(PropertyInfo pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x000703E4 File Offset: 0x0006E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51676, XrefRangeEnd = 51677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00070440 File Offset: 0x0006E640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51677, XrefRangeEnd = 51679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethod(Type type, string name)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000704B0 File Offset: 0x0006E6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51679, XrefRangeEnd = 51680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0007050C File Offset: 0x0006E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51680, XrefRangeEnd = 51681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetNestedTypes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetNestedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00070568 File Offset: 0x0006E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51681, XrefRangeEnd = 51682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000705C4 File Offset: 0x0006E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51682, XrefRangeEnd = 51684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo GetProperty(Type type, string name)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetProperty_Public_Virtual_PropertyInfo_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00070634 File Offset: 0x0006E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51684, XrefRangeEnd = 51685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetRemoveMethod(EventInfo ei)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_EventInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00070690 File Offset: 0x0006E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51685, XrefRangeEnd = 51686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetSetMethod(PropertyInfo pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000706EC File Offset: 0x0006E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51686, XrefRangeEnd = 51687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAssignableFrom(Type current, Type toCompare)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00070758 File Offset: 0x0006E958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51687, XrefRangeEnd = 51688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInstanceOfType(Type t, Object o)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000707C4 File Offset: 0x0006E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51688, XrefRangeEnd = 51690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethod(Type resourcesType, string name, Il2CppReferenceArray<Type> types)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourcesType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00070844 File Offset: 0x0006EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51690, XrefRangeEnd = 51691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetAssemblyTypes(Assembly asm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkClrBase.NativeMethodInfoPtr_GetAssemblyTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00008480 File Offset: 0x00006680
		public FrameworkClrBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000708A0 File Offset: 0x0006EAA0
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x00008489 File Offset: 0x00006689
		public unsafe BindingFlags BINDINGFLAGS_MEMBER
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_MEMBER);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_MEMBER), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000708D0 File Offset: 0x0006EAD0
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x000084A8 File Offset: 0x000066A8
		public unsafe BindingFlags BINDINGFLAGS_INNERCLASS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_INNERCLASS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkClrBase.NativeFieldInfoPtr_BINDINGFLAGS_INNERCLASS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_BINDINGFLAGS_MEMBER;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_BINDINGFLAGS_INNERCLASS;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_EventInfo_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_Type_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_Type_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_Type_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_PropertyInfo_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Type_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_Type_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_PropertyInfo_Type_String_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_EventInfo_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_PropertyInfo_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_Type_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Type_Object_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyTypes_Public_Virtual_Il2CppReferenceArray_1_Type_Assembly_0;
	}
}
