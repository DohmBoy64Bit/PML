using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x0200031A RID: 794
	public class PropertyGridItemFloat : PropertyGridItem
	{
		// Token: 0x06004432 RID: 17458 RVA: 0x00131ED8 File Offset: 0x001300D8
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemFloat()
		{
			Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr);
			PropertyGridItemFloat.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr, "inputField");
			PropertyGridItemFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr, 100674092);
			PropertyGridItemFloat.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr, 100674089);
			PropertyGridItemFloat.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr, 100674090);
			PropertyGridItemFloat.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr, 100674091);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00131F6C File Offset: 0x0013016C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemFloat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemFloat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00131FA8 File Offset: 0x001301A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130077, XrefRangeEnd = 130097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemFloat.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00131FF8 File Offset: 0x001301F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130097, XrefRangeEnd = 130122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemFloat.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00132048 File Offset: 0x00130248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130122, XrefRangeEnd = 130125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemFloat.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x000191B4 File Offset: 0x000173B4
		public PropertyGridItemFloat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x0013208C File Offset: 0x0013028C
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x000191BD File Offset: 0x000173BD
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemFloat.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemFloat.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x0400351A RID: 13594
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x0400351B RID: 13595
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;
	}
}
