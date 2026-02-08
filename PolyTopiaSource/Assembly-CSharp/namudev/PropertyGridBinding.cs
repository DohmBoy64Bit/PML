using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000240 RID: 576
	public class PropertyGridBinding : MonoBehaviour
	{
		// Token: 0x06002D14 RID: 11540 RVA: 0x000D28AC File Offset: 0x000D0AAC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridBinding()
		{
			Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr);
			PropertyGridBinding.NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "ValueChanged");
			PropertyGridBinding.NativeFieldInfoPtr__Caption_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "<Caption>k__BackingField");
			PropertyGridBinding.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "<Value>k__BackingField");
			PropertyGridBinding.NativeFieldInfoPtr__ValueType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "<ValueType>k__BackingField");
			PropertyGridBinding.NativeFieldInfoPtr_targetObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "targetObject");
			PropertyGridBinding.NativeFieldInfoPtr_propertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, "propertyInfo");
			PropertyGridBinding.NativeMethodInfoPtr_get_Caption_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670115);
			PropertyGridBinding.NativeMethodInfoPtr_set_Caption_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670116);
			PropertyGridBinding.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670117);
			PropertyGridBinding.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670118);
			PropertyGridBinding.NativeMethodInfoPtr_get_ValueType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670119);
			PropertyGridBinding.NativeMethodInfoPtr_set_ValueType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670120);
			PropertyGridBinding.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670113);
			PropertyGridBinding.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670114);
			PropertyGridBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670124);
			PropertyGridBinding.NativeMethodInfoPtr_Initialize_Public_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670121);
			PropertyGridBinding.NativeMethodInfoPtr_Initialize_Public_Void_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670122);
			PropertyGridBinding.NativeMethodInfoPtr_SetValue_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr, 100670123);
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000D2A44 File Offset: 0x000D0C44
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000D2A7C File Offset: 0x000D0C7C
		public unsafe string Caption
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_get_Caption_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_set_Caption_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000D2AC0 File Offset: 0x000D0CC0
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x000D2B00 File Offset: 0x000D0D00
		public unsafe global::Il2CppSystem.Object Value
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000D2B44 File Offset: 0x000D0D44
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x000D2B84 File Offset: 0x000D0D84
		public unsafe Type ValueType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_get_ValueType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_set_ValueType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000D2BC8 File Offset: 0x000D0DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97154, RefRangeEnd = 97155, XrefRangeStart = 97150, XrefRangeEnd = 97154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChanged(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000D2C0C File Offset: 0x000D0E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97155, XrefRangeEnd = 97159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChanged(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000D2C50 File Offset: 0x000D0E50
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridBinding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridBinding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000D2C8C File Offset: 0x000D0E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97159, XrefRangeEnd = 97162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string caption, global::Il2CppSystem.Object value, Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_Initialize_Public_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000D2CF4 File Offset: 0x000D0EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97168, RefRangeEnd = 97169, XrefRangeStart = 97162, XrefRangeEnd = 97168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(global::Il2CppSystem.Object targetObject, PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_Initialize_Public_Void_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000D2D48 File Offset: 0x000D0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97169, XrefRangeEnd = 97176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBinding.NativeMethodInfoPtr_SetValue_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00011EBE File Offset: 0x000100BE
		public PropertyGridBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x000D2D8C File Offset: 0x000D0F8C
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x00011EC7 File Offset: 0x000100C7
		public unsafe EventHandler ValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_ValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_ValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000D2DBC File Offset: 0x000D0FBC
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x00011EE6 File Offset: 0x000100E6
		public unsafe string _Caption_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__Caption_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__Caption_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000D2DE4 File Offset: 0x000D0FE4
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x00011F05 File Offset: 0x00010105
		public unsafe global::Il2CppSystem.Object _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x000D2E14 File Offset: 0x000D1014
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x00011F24 File Offset: 0x00010124
		public unsafe Type _ValueType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__ValueType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr__ValueType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000D2E44 File Offset: 0x000D1044
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00011F43 File Offset: 0x00010143
		public unsafe global::Il2CppSystem.Object targetObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_targetObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_targetObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000D2E74 File Offset: 0x000D1074
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x00011F62 File Offset: 0x00010162
		public unsafe PropertyInfo propertyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_propertyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBinding.NativeFieldInfoPtr_propertyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeFieldInfoPtr_ValueChanged;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeFieldInfoPtr__Caption_k__BackingField;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeFieldInfoPtr__ValueType_k__BackingField;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeFieldInfoPtr_targetObject;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeFieldInfoPtr_propertyInfo;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_get_Caption_Public_get_String_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_set_Caption_Private_set_Void_String_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_get_Type_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueType_Private_set_Void_Type_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_EventHandler_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_EventHandler_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_Object_Type_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Object_PropertyInfo_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_0;
	}
}
