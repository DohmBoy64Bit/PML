using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x02000318 RID: 792
	public class PropertyGridItemColorRange : PropertyGridItem
	{
		// Token: 0x06004416 RID: 17430 RVA: 0x0013187C File Offset: 0x0012FA7C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItemColorRange()
		{
			Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid.Items", "PropertyGridItemColorRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr);
			PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, "colorDisplayerMin");
			PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, "colorDisplayerMax");
			PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, "colorDisplayerBtnMin");
			PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, "colorDisplayerBtnMax");
			PropertyGridItemColorRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674084);
			PropertyGridItemColorRange.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674075);
			PropertyGridItemColorRange.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674076);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnColorDisplayerBtnClickMin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674077);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnColorDisplayerBtnClickMax_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674078);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChangeMin_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674079);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChangeMax_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674080);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674081);
			PropertyGridItemColorRange.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674082);
			PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr, 100674083);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x001319C4 File Offset: 0x0012FBC4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridItemColorRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItemColorRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00131A00 File Offset: 0x0012FC00
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00131A34 File Offset: 0x0012FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129888, XrefRangeEnd = 129927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetProperty(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemColorRange.NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00131A84 File Offset: 0x0012FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129927, XrefRangeEnd = 129953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorDisplayerBtnClickMin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnColorDisplayerBtnClickMin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00131AB8 File Offset: 0x0012FCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129953, XrefRangeEnd = 129979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorDisplayerBtnClickMax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnColorDisplayerBtnClickMax_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00131AEC File Offset: 0x0012FCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129979, XrefRangeEnd = 129988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeMin(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChangeMin_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00131B30 File Offset: 0x0012FD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129988, XrefRangeEnd = 129997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeMax(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChangeMax_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00131B74 File Offset: 0x0012FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129997, XrefRangeEnd = 130004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00131BA8 File Offset: 0x0012FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130004, XrefRangeEnd = 130012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridItemColorRange.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00131BF8 File Offset: 0x0012FDF8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItemColorRange.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00019107 File Offset: 0x00017307
		public PropertyGridItemColorRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x00131C38 File Offset: 0x0012FE38
		// (set) Token: 0x06004423 RID: 17443 RVA: 0x00019110 File Offset: 0x00017310
		public unsafe ProceduralImage colorDisplayerMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x00131C68 File Offset: 0x0012FE68
		// (set) Token: 0x06004425 RID: 17445 RVA: 0x0001912F File Offset: 0x0001732F
		public unsafe ProceduralImage colorDisplayerMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x00131C98 File Offset: 0x0012FE98
		// (set) Token: 0x06004427 RID: 17447 RVA: 0x0001914E File Offset: 0x0001734E
		public unsafe Button colorDisplayerBtnMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x00131CC8 File Offset: 0x0012FEC8
		// (set) Token: 0x06004429 RID: 17449 RVA: 0x0001916D File Offset: 0x0001736D
		public unsafe Button colorDisplayerBtnMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridItemColorRange.NativeFieldInfoPtr_colorDisplayerBtnMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerMin;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerMax;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerBtnMin;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerBtnMax;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_Void_PropertyInfo_0;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeMethodInfoPtr_OnColorDisplayerBtnClickMin_Private_Void_0;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeMethodInfoPtr_OnColorDisplayerBtnClickMax_Private_Void_0;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeMin_Private_Void_Color_0;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeMax_Private_Void_Color_0;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0;
	}
}
