using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	// Token: 0x02000315 RID: 789
	public class PropertyGridItem : MonoBehaviour
	{
		// Token: 0x060043ED RID: 17389 RVA: 0x00130F48 File Offset: 0x0012F148
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItem()
		{
			Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid", "PropertyGridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr);
			PropertyGridItem.NativeFieldInfoPtr_PropertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "PropertyChanged");
			PropertyGridItem.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "property");
			PropertyGridItem.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "currentValue");
			PropertyGridItem.NativeFieldInfoPtr_editingMultipleValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "editingMultipleValues");
			PropertyGridItem.NativeMethodInfoPtr_add_PropertyChanged_Public_add_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674056);
			PropertyGridItem.NativeMethodInfoPtr_remove_PropertyChanged_Public_rem_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674057);
			PropertyGridItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674061);
			PropertyGridItem.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674058);
			PropertyGridItem.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674059);
			PropertyGridItem.NativeMethodInfoPtr_InvokeValueChanged_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, 100674060);
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00131040 File Offset: 0x0012F240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129688, XrefRangeEnd = 129693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PropertyChanged(Action<global::Il2CppSystem.Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.NativeMethodInfoPtr_add_PropertyChanged_Public_add_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00131084 File Offset: 0x0012F284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129693, XrefRangeEnd = 129698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PropertyChanged(Action<global::Il2CppSystem.Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.NativeMethodInfoPtr_remove_PropertyChanged_Public_rem_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x001310C8 File Offset: 0x0012F2C8
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00131104 File Offset: 0x0012F304
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 129707, RefRangeEnd = 129718, XrefRangeStart = 129698, XrefRangeEnd = 129707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItem.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00131154 File Offset: 0x0012F354
		[CallerCount(0)]
		public unsafe virtual void SetValue(global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItem.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x001311A4 File Offset: 0x0012F3A4
		[CallerCount(0)]
		public unsafe virtual void InvokeValueChanged(global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItem.NativeMethodInfoPtr_InvokeValueChanged_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00018FF8 File Offset: 0x000171F8
		public PropertyGridItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x001311F4 File Offset: 0x0012F3F4
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x00019001 File Offset: 0x00017201
		public unsafe Action<global::Il2CppSystem.Object> PropertyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_PropertyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_PropertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x00131224 File Offset: 0x0012F424
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x00019020 File Offset: 0x00017220
		public unsafe PropertyInfo property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x00131254 File Offset: 0x0012F454
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x0001903F File Offset: 0x0001723F
		public unsafe global::Il2CppSystem.Object currentValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_currentValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x00131284 File Offset: 0x0012F484
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x0001905E File Offset: 0x0001725E
		public unsafe bool editingMultipleValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_editingMultipleValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItem.NativeFieldInfoPtr_editingMultipleValues)) = value;
			}
		}

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanged;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeFieldInfoPtr_property;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeFieldInfoPtr_currentValue;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeFieldInfoPtr_editingMultipleValues;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_add_PropertyChanged_Public_add_Void_Action_1_Object_0;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeMethodInfoPtr_remove_PropertyChanged_Public_rem_Void_Action_1_Object_0;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_PropertyInfo_0;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeMethodInfoPtr_InvokeValueChanged_Protected_Virtual_New_Void_Object_0;
	}
}
