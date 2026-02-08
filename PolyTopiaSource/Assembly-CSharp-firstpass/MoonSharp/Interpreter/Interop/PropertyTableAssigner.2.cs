using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A5 RID: 165
	public class PropertyTableAssigner : Object
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x00048E8C File Offset: 0x0004708C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyTableAssigner()
		{
			Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "PropertyTableAssigner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr);
			PropertyTableAssigner.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, "m_Type");
			PropertyTableAssigner.NativeFieldInfoPtr_m_PropertyMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, "m_PropertyMap");
			PropertyTableAssigner.NativeFieldInfoPtr_m_SubAssigners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, "m_SubAssigners");
			PropertyTableAssigner.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665548);
			PropertyTableAssigner.NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665549);
			PropertyTableAssigner.NativeMethodInfoPtr_TryAssignProperty_Private_Boolean_Object_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665550);
			PropertyTableAssigner.NativeMethodInfoPtr_AssignProperty_Private_Void_Object_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665551);
			PropertyTableAssigner.NativeMethodInfoPtr_AssignObject_Public_Void_Object_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665552);
			PropertyTableAssigner.NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665553);
			PropertyTableAssigner.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr, 100665554);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00048F84 File Offset: 0x00047184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33507, XrefRangeEnd = 33566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTableAssigner(Type type, [Optional] Il2CppStringArray expectedMissingProperties)
		{
			if (expectedMissingProperties == null)
			{
				expectedMissingProperties = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyTableAssigner>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expectedMissingProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00048FF0 File Offset: 0x000471F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33566, XrefRangeEnd = 33570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExpectedMissingProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00049034 File Offset: 0x00047234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 33579, RefRangeEnd = 33583, XrefRangeStart = 33570, XrefRangeEnd = 33579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAssignProperty(Object obj, string name, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_TryAssignProperty_Private_Boolean_Object_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000490A8 File Offset: 0x000472A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33610, RefRangeEnd = 33611, XrefRangeStart = 33583, XrefRangeEnd = 33610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignProperty(Object obj, string name, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_AssignProperty_Private_Void_Object_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00049110 File Offset: 0x00047310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33643, RefRangeEnd = 33644, XrefRangeStart = 33611, XrefRangeEnd = 33643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignObject(Object obj, Table data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_AssignObject_Public_Void_Object_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00049164 File Offset: 0x00047364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33644, XrefRangeEnd = 33676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000491B8 File Offset: 0x000473B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33676, XrefRangeEnd = 33677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked(Object obj, Table data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTableAssigner.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00005D2E File Offset: 0x00003F2E
		public PropertyTableAssigner(Type type, params string[] expectedMissingProperties)
			: this(type, new Il2CppStringArray(expectedMissingProperties))
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00005D3D File Offset: 0x00003F3D
		public PropertyTableAssigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0004920C File Offset: 0x0004740C
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00005D46 File Offset: 0x00003F46
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0004923C File Offset: 0x0004743C
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00005D65 File Offset: 0x00003F65
		public unsafe Dictionary<string, PropertyInfo> m_PropertyMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_PropertyMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PropertyInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_PropertyMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0004926C File Offset: 0x0004746C
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00005D84 File Offset: 0x00003F84
		public unsafe Dictionary<Type, IPropertyTableAssigner> m_SubAssigners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_SubAssigners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IPropertyTableAssigner>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTableAssigner.NativeFieldInfoPtr_m_SubAssigners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyMap;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_m_SubAssigners;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppStringArray_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_AddExpectedMissingProperty_Public_Void_String_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_TryAssignProperty_Private_Boolean_Object_String_DynValue_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Private_Void_Object_String_DynValue_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_AssignObject_Public_Void_Object_Table_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_SetSubassignerForType_Public_Void_Type_IPropertyTableAssigner_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_IPropertyTableAssigner_AssignObjectUnchecked_Private_Virtual_Final_New_Void_Object_Table_0;
	}
}
