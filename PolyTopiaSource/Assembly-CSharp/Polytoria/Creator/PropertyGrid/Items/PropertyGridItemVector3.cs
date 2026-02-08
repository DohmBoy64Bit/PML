using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using TMPro;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x02000320 RID: 800
	public class PropertyGridItemVector3 : PropertyGridItem
	{
		// Token: 0x06004463 RID: 17507 RVA: 0x00132A1C File Offset: 0x00130C1C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemVector3()
		{
			Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr);
			PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, "inputFieldX");
			PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, "inputFieldY");
			PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, "inputFieldZ");
			PropertyGridItemVector3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, 100674115);
			PropertyGridItemVector3.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, 100674112);
			PropertyGridItemVector3.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, 100674113);
			PropertyGridItemVector3.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr, 100674114);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00132AD8 File Offset: 0x00130CD8
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemVector3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemVector3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemVector3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00132B14 File Offset: 0x00130D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130397, XrefRangeEnd = 130445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemVector3.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00132B64 File Offset: 0x00130D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130445, XrefRangeEnd = 130503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemVector3.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00132BB4 File Offset: 0x00130DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130503, XrefRangeEnd = 130509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemVector3.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x000192C3 File Offset: 0x000174C3
		public PropertyGridItemVector3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x00132BF8 File Offset: 0x00130DF8
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x000192CC File Offset: 0x000174CC
		public unsafe TMP_InputField inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x00132C28 File Offset: 0x00130E28
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x000192EB File Offset: 0x000174EB
		public unsafe TMP_InputField inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x00132C58 File Offset: 0x00130E58
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x0001930A File Offset: 0x0001750A
		public unsafe TMP_InputField inputFieldZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemVector3.NativeFieldInfoPtr_inputFieldZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldZ;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003539 RID: 13625
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x0400353A RID: 13626
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x0400353B RID: 13627
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;
	}
}
