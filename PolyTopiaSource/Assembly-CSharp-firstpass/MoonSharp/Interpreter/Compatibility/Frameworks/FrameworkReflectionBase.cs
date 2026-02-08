using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000125 RID: 293
	public class FrameworkReflectionBase : FrameworkBase
	{
		// Token: 0x060015A7 RID: 5543 RVA: 0x00070900 File Offset: 0x0006EB00
		// Note: this type is marked as 'beforefieldinit'.
		static FrameworkReflectionBase()
		{
			Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Compatibility.Frameworks", "FrameworkReflectionBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr);
			FrameworkReflectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667179);
			FrameworkReflectionBase.NativeMethodInfoPtr_GetTypeInfoFromType_Public_Abstract_Virtual_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667167);
			FrameworkReflectionBase.NativeMethodInfoPtr_GetAssembly_Public_Virtual_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667168);
			FrameworkReflectionBase.NativeMethodInfoPtr_GetBaseType_Public_Virtual_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667169);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsValueType_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667170);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsInterface_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667171);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsNestedPublic_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667172);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsAbstract_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667173);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsEnum_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667174);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667175);
			FrameworkReflectionBase.NativeMethodInfoPtr_IsGenericType_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667176);
			FrameworkReflectionBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667177);
			FrameworkReflectionBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr, 100667178);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00070A34 File Offset: 0x0006EC34
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameworkReflectionBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameworkReflectionBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkReflectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00070A70 File Offset: 0x0006EC70
		[CallerCount(0)]
		public unsafe virtual Type GetTypeInfoFromType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_GetTypeInfoFromType_Public_Abstract_Virtual_New_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00070ACC File Offset: 0x0006ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51691, XrefRangeEnd = 51692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Assembly GetAssembly(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_GetAssembly_Public_Virtual_Assembly_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00070B28 File Offset: 0x0006ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51692, XrefRangeEnd = 51693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetBaseType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_GetBaseType_Public_Virtual_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00070B84 File Offset: 0x0006ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51693, XrefRangeEnd = 51703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsValueType_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00070BDC File Offset: 0x0006EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51703, XrefRangeEnd = 51705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInterface(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsInterface_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00070C34 File Offset: 0x0006EE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51705, XrefRangeEnd = 51707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsNestedPublic(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsNestedPublic_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00070C8C File Offset: 0x0006EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51707, XrefRangeEnd = 51709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAbstract(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsAbstract_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00070CE4 File Offset: 0x0006EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51709, XrefRangeEnd = 51710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnum(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsEnum_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00070D3C File Offset: 0x0006EF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51710, XrefRangeEnd = 51711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsGenericTypeDefinition(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00070D94 File Offset: 0x0006EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51711, XrefRangeEnd = 51712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsGenericType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_IsGenericType_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00070DEC File Offset: 0x0006EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51712, XrefRangeEnd = 51719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Attribute> GetCustomAttributes(Type t, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00070E58 File Offset: 0x0006F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51719, XrefRangeEnd = 51726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Attribute> GetCustomAttributes(Type t, Type at, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkReflectionBase.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000084C7 File Offset: 0x000066C7
		public FrameworkReflectionBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfoFromType_Public_Abstract_Virtual_New_Type_Type_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Public_Virtual_Assembly_Type_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Public_Virtual_Type_Type_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_IsInterface_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_IsNestedPublic_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_IsAbstract_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericType_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Boolean_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Attribute_Type_Type_Boolean_0;
	}
}
