using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x0200031B RID: 795
	public class PropertyGridItemInteger : PropertyGridItem
	{
		// Token: 0x0600443A RID: 17466 RVA: 0x001320BC File Offset: 0x001302BC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemInteger()
		{
			Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr);
			PropertyGridItemInteger.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr, "inputField");
			PropertyGridItemInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr, 100674096);
			PropertyGridItemInteger.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr, 100674093);
			PropertyGridItemInteger.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr, 100674094);
			PropertyGridItemInteger.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr, 100674095);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00132150 File Offset: 0x00130350
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x0013218C File Offset: 0x0013038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130125, XrefRangeEnd = 130145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemInteger.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x001321DC File Offset: 0x001303DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130145, XrefRangeEnd = 130170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemInteger.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x0013222C File Offset: 0x0013042C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130170, XrefRangeEnd = 130173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemInteger.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000191DC File Offset: 0x000173DC
		public PropertyGridItemInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x00132270 File Offset: 0x00130470
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x000191E5 File Offset: 0x000173E5
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemInteger.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemInteger.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400351C RID: 13596
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x0400351D RID: 13597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400351E RID: 13598
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;
	}
}
