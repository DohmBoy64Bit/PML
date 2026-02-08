using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x02000317 RID: 791
	public class PropertyGridItemColor : PropertyGridItem
	{
		// Token: 0x06004405 RID: 17413 RVA: 0x0013148C File Offset: 0x0012F68C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemColor()
		{
			Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr);
			PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, "colorDisplayer");
			PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, "colorDisplayerBtn");
			PropertyGridItemColor.NativeFieldInfoPtr_hexInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, "hexInput");
			PropertyGridItemColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674074);
			PropertyGridItemColor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674066);
			PropertyGridItemColor.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674067);
			PropertyGridItemColor.NativeMethodInfoPtr_OnColorDisplayerBtnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674068);
			PropertyGridItemColor.NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674069);
			PropertyGridItemColor.NativeMethodInfoPtr_OnHexInputValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674070);
			PropertyGridItemColor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674071);
			PropertyGridItemColor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674072);
			PropertyGridItemColor.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr, 100674073);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x001315AC File Offset: 0x0012F7AC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemColor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x001315E8 File Offset: 0x0012F7E8
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x0013161C File Offset: 0x0012F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129764, XrefRangeEnd = 129804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemColor.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x0013166C File Offset: 0x0012F86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129804, XrefRangeEnd = 129830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorDisplayerBtnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_OnColorDisplayerBtnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x001316A0 File Offset: 0x0012F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129830, XrefRangeEnd = 129837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChange(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x001316E4 File Offset: 0x0012F8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129837, XrefRangeEnd = 129847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHexInputValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_OnHexInputValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00131728 File Offset: 0x0012F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129847, XrefRangeEnd = 129854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x0013175C File Offset: 0x0012F95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129854, XrefRangeEnd = 129888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemColor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x001317AC File Offset: 0x0012F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColor.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x000190A1 File Offset: 0x000172A1
		public PropertyGridItemColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x001317EC File Offset: 0x0012F9EC
		// (set) Token: 0x06004411 RID: 17425 RVA: 0x000190AA File Offset: 0x000172AA
		public unsafe ProceduralImage colorDisplayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x0013181C File Offset: 0x0012FA1C
		// (set) Token: 0x06004413 RID: 17427 RVA: 0x000190C9 File Offset: 0x000172C9
		public unsafe Button colorDisplayerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_colorDisplayerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x0013184C File Offset: 0x0012FA4C
		// (set) Token: 0x06004415 RID: 17429 RVA: 0x000190E8 File Offset: 0x000172E8
		public unsafe TMP_InputField hexInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_hexInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColor.NativeFieldInfoPtr_hexInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayer;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerBtn;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeFieldInfoPtr_hexInput;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeMethodInfoPtr_OnColorDisplayerBtnClick_Private_Void_0;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeMethodInfoPtr_OnHexInputValueChanged_Private_Void_String_0;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0;
	}
}
