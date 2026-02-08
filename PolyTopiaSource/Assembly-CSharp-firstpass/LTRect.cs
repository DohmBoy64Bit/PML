using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Serializable]
public class LTRect : global::Il2CppSystem.Object
{
	// Token: 0x060001D9 RID: 473 RVA: 0x00018C0C File Offset: 0x00016E0C
	// Note: this type is marked as 'beforefieldinit'.
	static LTRect()
	{
		Il2CppClassPointerStore<LTRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTRect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTRect>.NativeClassPtr);
		LTRect.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "_rect");
		LTRect.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "alpha");
		LTRect.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotation");
		LTRect.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "pivot");
		LTRect.NativeFieldInfoPtr_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "margin");
		LTRect.NativeFieldInfoPtr_relativeRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "relativeRect");
		LTRect.NativeFieldInfoPtr_rotateEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotateEnabled");
		LTRect.NativeFieldInfoPtr_rotateFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotateFinished");
		LTRect.NativeFieldInfoPtr_alphaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "alphaEnabled");
		LTRect.NativeFieldInfoPtr_labelStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "labelStr");
		LTRect.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "type");
		LTRect.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "style");
		LTRect.NativeFieldInfoPtr_useColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "useColor");
		LTRect.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "color");
		LTRect.NativeFieldInfoPtr_fontScaleToFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "fontScaleToFit");
		LTRect.NativeFieldInfoPtr_useSimpleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "useSimpleScale");
		LTRect.NativeFieldInfoPtr_sizeByHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "sizeByHeight");
		LTRect.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "texture");
		LTRect.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "_id");
		LTRect.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "counter");
		LTRect.NativeFieldInfoPtr_colorTouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "colorTouched");
		LTRect.NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663634);
		LTRect.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663635);
		LTRect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663639);
		LTRect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663640);
		LTRect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663641);
		LTRect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663642);
		LTRect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663643);
		LTRect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663644);
		LTRect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663645);
		LTRect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663646);
		LTRect.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663647);
		LTRect.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663648);
		LTRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663629);
		LTRect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663630);
		LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663631);
		LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663632);
		LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663633);
		LTRect.NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663636);
		LTRect.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663637);
		LTRect.NativeMethodInfoPtr_resetForRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663638);
		LTRect.NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663649);
		LTRect.NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663650);
		LTRect.NativeMethodInfoPtr_setColor_Public_LTRect_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663651);
		LTRect.NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663652);
		LTRect.NativeMethodInfoPtr_setLabel_Public_LTRect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663653);
		LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663654);
		LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663655);
		LTRect.NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663656);
		LTRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100663657);
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060001DA RID: 474 RVA: 0x00019024 File Offset: 0x00017224
	public unsafe bool hasInitiliazed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060001DB RID: 475 RVA: 0x00019060 File Offset: 0x00017260
	public unsafe int id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060001DC RID: 476 RVA: 0x0001909C File Offset: 0x0001729C
	// (set) Token: 0x060001DD RID: 477 RVA: 0x000190D8 File Offset: 0x000172D8
	public unsafe float x
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13585, XrefRangeEnd = 13588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_x_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13588, XrefRangeEnd = 13591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060001DE RID: 478 RVA: 0x00019118 File Offset: 0x00017318
	// (set) Token: 0x060001DF RID: 479 RVA: 0x00019154 File Offset: 0x00017354
	public unsafe float y
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13591, XrefRangeEnd = 13594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_y_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13594, XrefRangeEnd = 13597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060001E0 RID: 480 RVA: 0x00019194 File Offset: 0x00017394
	// (set) Token: 0x060001E1 RID: 481 RVA: 0x000191D0 File Offset: 0x000173D0
	public unsafe float width
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13597, XrefRangeEnd = 13600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13600, XrefRangeEnd = 13603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060001E2 RID: 482 RVA: 0x00019210 File Offset: 0x00017410
	// (set) Token: 0x060001E3 RID: 483 RVA: 0x0001924C File Offset: 0x0001744C
	public unsafe float height
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13603, XrefRangeEnd = 13606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13606, XrefRangeEnd = 13609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060001E4 RID: 484 RVA: 0x0001928C File Offset: 0x0001748C
	// (set) Token: 0x060001E5 RID: 485 RVA: 0x000192CC File Offset: 0x000174CC
	public unsafe Rect rect
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 13636, RefRangeEnd = 13659, XrefRangeStart = 13609, XrefRangeEnd = 13636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00019310 File Offset: 0x00017510
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13659, XrefRangeEnd = 13662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0001934C File Offset: 0x0001754C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13665, RefRangeEnd = 13666, XrefRangeStart = 13662, XrefRangeEnd = 13665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(Rect rect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00019398 File Offset: 0x00017598
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13666, XrefRangeEnd = 13667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(float x, float y, float width, float height)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0001940C File Offset: 0x0001760C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13667, XrefRangeEnd = 13668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(float x, float y, float width, float height, float alpha)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0001948C File Offset: 0x0001768C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13668, XrefRangeEnd = 13670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(float x, float y, float width, float height, float alpha, float rotation)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0001951C File Offset: 0x0001771C
	[CallerCount(0)]
	public unsafe void setId(int id, int counter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00019568 File Offset: 0x00017768
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13670, XrefRangeEnd = 13672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0001959C File Offset: 0x0001779C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13692, RefRangeEnd = 13694, XrefRangeStart = 13672, XrefRangeEnd = 13692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetForRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_resetForRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EE RID: 494 RVA: 0x000195D0 File Offset: 0x000177D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13694, XrefRangeEnd = 13695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect setStyle(GUIStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00019620 File Offset: 0x00017820
	[CallerCount(0)]
	public unsafe LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fontScaleToFit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0001966C File Offset: 0x0001786C
	[CallerCount(0)]
	public unsafe LTRect setColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setColor_Public_LTRect_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x000196BC File Offset: 0x000178BC
	[CallerCount(0)]
	public unsafe LTRect setAlpha(float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00019708 File Offset: 0x00017908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13695, XrefRangeEnd = 13696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect setLabel(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setLabel_Public_LTRect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00019758 File Offset: 0x00017958
	[CallerCount(0)]
	public unsafe LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useSimpleScale;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeRect);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x000197B8 File Offset: 0x000179B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13696, XrefRangeEnd = 13698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect setUseSimpleScale(bool useSimpleScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useSimpleScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00019804 File Offset: 0x00017A04
	[CallerCount(0)]
	public unsafe LTRect setSizeByHeight(bool sizeByHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sizeByHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00019850 File Offset: 0x00017A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13698, XrefRangeEnd = 13725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LTRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002769 File Offset: 0x00000969
	public LTRect(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00019894 File Offset: 0x00017A94
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002772 File Offset: 0x00000972
	public unsafe Rect _rect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__rect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__rect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060001FA RID: 506 RVA: 0x000198C4 File Offset: 0x00017AC4
	// (set) Token: 0x060001FB RID: 507 RVA: 0x00002791 File Offset: 0x00000991
	public unsafe float alpha
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alpha);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alpha)) = value;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060001FC RID: 508 RVA: 0x000198EC File Offset: 0x00017AEC
	// (set) Token: 0x060001FD RID: 509 RVA: 0x000027AC File Offset: 0x000009AC
	public unsafe float rotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotation)) = value;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060001FE RID: 510 RVA: 0x00019914 File Offset: 0x00017B14
	// (set) Token: 0x060001FF RID: 511 RVA: 0x000027C7 File Offset: 0x000009C7
	public unsafe Vector2 pivot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_pivot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_pivot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000200 RID: 512 RVA: 0x00019944 File Offset: 0x00017B44
	// (set) Token: 0x06000201 RID: 513 RVA: 0x000027E6 File Offset: 0x000009E6
	public unsafe Vector2 margin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_margin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_margin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000202 RID: 514 RVA: 0x00019974 File Offset: 0x00017B74
	// (set) Token: 0x06000203 RID: 515 RVA: 0x00002805 File Offset: 0x00000A05
	public unsafe Rect relativeRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_relativeRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_relativeRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000204 RID: 516 RVA: 0x000199A4 File Offset: 0x00017BA4
	// (set) Token: 0x06000205 RID: 517 RVA: 0x00002824 File Offset: 0x00000A24
	public unsafe bool rotateEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateEnabled)) = value;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000206 RID: 518 RVA: 0x000199CC File Offset: 0x00017BCC
	// (set) Token: 0x06000207 RID: 519 RVA: 0x0000283F File Offset: 0x00000A3F
	public unsafe bool rotateFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateFinished);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateFinished)) = value;
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000208 RID: 520 RVA: 0x000199F4 File Offset: 0x00017BF4
	// (set) Token: 0x06000209 RID: 521 RVA: 0x0000285A File Offset: 0x00000A5A
	public unsafe bool alphaEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alphaEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alphaEnabled)) = value;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600020A RID: 522 RVA: 0x00019A1C File Offset: 0x00017C1C
	// (set) Token: 0x0600020B RID: 523 RVA: 0x00002875 File Offset: 0x00000A75
	public unsafe string labelStr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_labelStr);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_labelStr), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x0600020C RID: 524 RVA: 0x00019A44 File Offset: 0x00017C44
	// (set) Token: 0x0600020D RID: 525 RVA: 0x00002894 File Offset: 0x00000A94
	public unsafe LTGUI.Element_Type type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_type)) = value;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00019A6C File Offset: 0x00017C6C
	// (set) Token: 0x0600020F RID: 527 RVA: 0x000028AF File Offset: 0x00000AAF
	public unsafe GUIStyle style
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_style);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000210 RID: 528 RVA: 0x00019A9C File Offset: 0x00017C9C
	// (set) Token: 0x06000211 RID: 529 RVA: 0x000028CE File Offset: 0x00000ACE
	public unsafe bool useColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useColor)) = value;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00019AC4 File Offset: 0x00017CC4
	// (set) Token: 0x06000213 RID: 531 RVA: 0x000028E9 File Offset: 0x00000AE9
	public unsafe Color color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_color);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000214 RID: 532 RVA: 0x00019AF4 File Offset: 0x00017CF4
	// (set) Token: 0x06000215 RID: 533 RVA: 0x00002908 File Offset: 0x00000B08
	public unsafe bool fontScaleToFit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_fontScaleToFit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_fontScaleToFit)) = value;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00019B1C File Offset: 0x00017D1C
	// (set) Token: 0x06000217 RID: 535 RVA: 0x00002923 File Offset: 0x00000B23
	public unsafe bool useSimpleScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useSimpleScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useSimpleScale)) = value;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000218 RID: 536 RVA: 0x00019B44 File Offset: 0x00017D44
	// (set) Token: 0x06000219 RID: 537 RVA: 0x0000293E File Offset: 0x00000B3E
	public unsafe bool sizeByHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_sizeByHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_sizeByHeight)) = value;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600021A RID: 538 RVA: 0x00019B6C File Offset: 0x00017D6C
	// (set) Token: 0x0600021B RID: 539 RVA: 0x00002959 File Offset: 0x00000B59
	public unsafe Texture texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600021C RID: 540 RVA: 0x00019B9C File Offset: 0x00017D9C
	// (set) Token: 0x0600021D RID: 541 RVA: 0x00002978 File Offset: 0x00000B78
	public unsafe int _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600021E RID: 542 RVA: 0x00019BC4 File Offset: 0x00017DC4
	// (set) Token: 0x0600021F RID: 543 RVA: 0x00002993 File Offset: 0x00000B93
	public unsafe int counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000220 RID: 544 RVA: 0x00019BEC File Offset: 0x00017DEC
	// (set) Token: 0x06000221 RID: 545 RVA: 0x000029AE File Offset: 0x00000BAE
	public unsafe static bool colorTouched
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(LTRect.NativeFieldInfoPtr_colorTouched, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTRect.NativeFieldInfoPtr_colorTouched, (void*)(&value));
		}
	}

	// Token: 0x040001D2 RID: 466
	private static readonly IntPtr NativeFieldInfoPtr__rect;

	// Token: 0x040001D3 RID: 467
	private static readonly IntPtr NativeFieldInfoPtr_alpha;

	// Token: 0x040001D4 RID: 468
	private static readonly IntPtr NativeFieldInfoPtr_rotation;

	// Token: 0x040001D5 RID: 469
	private static readonly IntPtr NativeFieldInfoPtr_pivot;

	// Token: 0x040001D6 RID: 470
	private static readonly IntPtr NativeFieldInfoPtr_margin;

	// Token: 0x040001D7 RID: 471
	private static readonly IntPtr NativeFieldInfoPtr_relativeRect;

	// Token: 0x040001D8 RID: 472
	private static readonly IntPtr NativeFieldInfoPtr_rotateEnabled;

	// Token: 0x040001D9 RID: 473
	private static readonly IntPtr NativeFieldInfoPtr_rotateFinished;

	// Token: 0x040001DA RID: 474
	private static readonly IntPtr NativeFieldInfoPtr_alphaEnabled;

	// Token: 0x040001DB RID: 475
	private static readonly IntPtr NativeFieldInfoPtr_labelStr;

	// Token: 0x040001DC RID: 476
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x040001DD RID: 477
	private static readonly IntPtr NativeFieldInfoPtr_style;

	// Token: 0x040001DE RID: 478
	private static readonly IntPtr NativeFieldInfoPtr_useColor;

	// Token: 0x040001DF RID: 479
	private static readonly IntPtr NativeFieldInfoPtr_color;

	// Token: 0x040001E0 RID: 480
	private static readonly IntPtr NativeFieldInfoPtr_fontScaleToFit;

	// Token: 0x040001E1 RID: 481
	private static readonly IntPtr NativeFieldInfoPtr_useSimpleScale;

	// Token: 0x040001E2 RID: 482
	private static readonly IntPtr NativeFieldInfoPtr_sizeByHeight;

	// Token: 0x040001E3 RID: 483
	private static readonly IntPtr NativeFieldInfoPtr_texture;

	// Token: 0x040001E4 RID: 484
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x040001E5 RID: 485
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x040001E6 RID: 486
	private static readonly IntPtr NativeFieldInfoPtr_colorTouched;

	// Token: 0x040001E7 RID: 487
	private static readonly IntPtr NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0;

	// Token: 0x040001E8 RID: 488
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	// Token: 0x040001E9 RID: 489
	private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

	// Token: 0x040001EA RID: 490
	private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

	// Token: 0x040001EB RID: 491
	private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

	// Token: 0x040001EC RID: 492
	private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

	// Token: 0x040001ED RID: 493
	private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

	// Token: 0x040001EE RID: 494
	private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

	// Token: 0x040001EF RID: 495
	private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

	// Token: 0x040001F0 RID: 496
	private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

	// Token: 0x040001F1 RID: 497
	private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	// Token: 0x040001F2 RID: 498
	private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

	// Token: 0x040001F3 RID: 499
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040001F4 RID: 500
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;

	// Token: 0x040001F5 RID: 501
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	// Token: 0x040001F6 RID: 502
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

	// Token: 0x040001F7 RID: 503
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x040001F8 RID: 504
	private static readonly IntPtr NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0;

	// Token: 0x040001F9 RID: 505
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	// Token: 0x040001FA RID: 506
	private static readonly IntPtr NativeMethodInfoPtr_resetForRotation_Public_Void_0;

	// Token: 0x040001FB RID: 507
	private static readonly IntPtr NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0;

	// Token: 0x040001FC RID: 508
	private static readonly IntPtr NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0;

	// Token: 0x040001FD RID: 509
	private static readonly IntPtr NativeMethodInfoPtr_setColor_Public_LTRect_Color_0;

	// Token: 0x040001FE RID: 510
	private static readonly IntPtr NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0;

	// Token: 0x040001FF RID: 511
	private static readonly IntPtr NativeMethodInfoPtr_setLabel_Public_LTRect_String_0;

	// Token: 0x04000200 RID: 512
	private static readonly IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0;

	// Token: 0x04000201 RID: 513
	private static readonly IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0;

	// Token: 0x04000202 RID: 514
	private static readonly IntPtr NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0;

	// Token: 0x04000203 RID: 515
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
