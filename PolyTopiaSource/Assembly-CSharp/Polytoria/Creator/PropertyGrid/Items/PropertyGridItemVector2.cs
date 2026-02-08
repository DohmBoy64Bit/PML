using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x0200031F RID: 799
	public class PropertyGridItemVector2 : PropertyGridItem
	{
		// Token: 0x06004459 RID: 17497 RVA: 0x001327F4 File Offset: 0x001309F4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemVector2()
		{
			Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr);
			PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, "inputFieldX");
			PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, "inputFieldY");
			PropertyGridItemVector2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, 100674111);
			PropertyGridItemVector2.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, 100674108);
			PropertyGridItemVector2.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, 100674109);
			PropertyGridItemVector2.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr, 100674110);
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x0013289C File Offset: 0x00130A9C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemVector2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemVector2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemVector2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x001328D8 File Offset: 0x00130AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130316, XrefRangeEnd = 130350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemVector2.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00132928 File Offset: 0x00130B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130350, XrefRangeEnd = 130392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemVector2.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00132978 File Offset: 0x00130B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130392, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemVector2.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x0001927C File Offset: 0x0001747C
		public PropertyGridItemVector2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x001329BC File Offset: 0x00130BBC
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x00019285 File Offset: 0x00017485
		public unsafe TMP_InputField inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x001329EC File Offset: 0x00130BEC
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x000192A4 File Offset: 0x000174A4
		public unsafe TMP_InputField inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector2.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400352F RID: 13615
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x04003530 RID: 13616
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x04003531 RID: 13617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003532 RID: 13618
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x04003533 RID: 13619
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04003534 RID: 13620
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;
	}
}
