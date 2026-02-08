using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x0200031C RID: 796
	public class PropertyGridItemNumberRange : PropertyGridItem
	{
		// Token: 0x06004442 RID: 17474 RVA: 0x001322A0 File Offset: 0x001304A0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemNumberRange()
		{
			Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemNumberRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr);
			PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, "inputFieldMin");
			PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, "inputFieldMax");
			PropertyGridItemNumberRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, 100674100);
			PropertyGridItemNumberRange.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, 100674097);
			PropertyGridItemNumberRange.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, 100674098);
			PropertyGridItemNumberRange.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr, 100674099);
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00132348 File Offset: 0x00130548
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemNumberRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemNumberRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemNumberRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00132384 File Offset: 0x00130584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130173, XrefRangeEnd = 130207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemNumberRange.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x001323D4 File Offset: 0x001305D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130207, XrefRangeEnd = 130248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemNumberRange.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00132424 File Offset: 0x00130624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130248, XrefRangeEnd = 130253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemNumberRange.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00019204 File Offset: 0x00017404
		public PropertyGridItemNumberRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x00132468 File Offset: 0x00130668
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x0001920D File Offset: 0x0001740D
		public unsafe TMP_InputField inputFieldMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x00132498 File Offset: 0x00130698
		// (set) Token: 0x0600444B RID: 17483 RVA: 0x0001922C File Offset: 0x0001742C
		public unsafe TMP_InputField inputFieldMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemNumberRange.NativeFieldInfoPtr_inputFieldMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003521 RID: 13601
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldMin;

		// Token: 0x04003522 RID: 13602
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldMax;

		// Token: 0x04003523 RID: 13603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003524 RID: 13604
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x04003525 RID: 13605
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04003526 RID: 13606
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;
	}
}
