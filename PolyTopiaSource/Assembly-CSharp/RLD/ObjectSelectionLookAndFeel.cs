using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class ObjectSelectionLookAndFeel : Settings
	{
		// Token: 0x06002A6D RID: 10861 RVA: 0x000C9244 File Offset: 0x000C7444
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionLookAndFeel()
		{
			Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr);
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__drawHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_drawHighlight");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionBoxBorderStyle");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__wireCornerLinePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_wireCornerLinePercentage");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionBoxRenderMode");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionBoxBorderColor");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxInflateAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionBoxInflateAmount");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionRectBorderColor");
			ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, "_selectionRectFillColor");
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_DrawHighlight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669763);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_DrawHighlight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669764);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelBoxBorderStyle_Public_get_SelectionBoxBorderStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669765);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelBoxBorderStyle_Public_set_Void_SelectionBoxBorderStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669766);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_WireCornerLinePercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669767);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_WireCornerLinePercentage_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669768);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelBoxRenderMode_Public_get_SelectionBoxRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669769);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelBoxRenderMode_Public_set_Void_SelectionBoxRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669770);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionBoxBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669771);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionBoxBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669772);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionBoxInflateAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669773);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionBoxInflateAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669774);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionRectBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669775);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionRectBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669776);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionRectFillColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669777);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionRectFillColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669778);
			ObjectSelectionLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr, 100669779);
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000C9468 File Offset: 0x000C7668
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x000C94A4 File Offset: 0x000C76A4
		public unsafe bool DrawHighlight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_DrawHighlight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_DrawHighlight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000C94E4 File Offset: 0x000C76E4
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x000C9524 File Offset: 0x000C7724
		public unsafe SelectionBoxBorderStyle SelBoxBorderStyle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28412, RefRangeEnd = 28413, XrefRangeStart = 28412, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelBoxBorderStyle_Public_get_SelectionBoxBorderStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionBoxBorderStyle>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28413, RefRangeEnd = 28414, XrefRangeStart = 28413, XrefRangeEnd = 28414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelBoxBorderStyle_Public_set_Void_SelectionBoxBorderStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000C9568 File Offset: 0x000C7768
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x000C95A4 File Offset: 0x000C77A4
		public unsafe float WireCornerLinePercentage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_WireCornerLinePercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_WireCornerLinePercentage_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000C95E4 File Offset: 0x000C77E4
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x000C9624 File Offset: 0x000C7824
		public unsafe SelectionBoxRenderMode SelBoxRenderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelBoxRenderMode_Public_get_SelectionBoxRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionBoxRenderMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelBoxRenderMode_Public_set_Void_SelectionBoxRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000C9668 File Offset: 0x000C7868
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x000C96A8 File Offset: 0x000C78A8
		public unsafe Color SelectionBoxBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionBoxBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionBoxBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000C96EC File Offset: 0x000C78EC
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x000C9728 File Offset: 0x000C7928
		public unsafe float SelectionBoxInflateAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionBoxInflateAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionBoxInflateAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x000C9768 File Offset: 0x000C7968
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x000C97A8 File Offset: 0x000C79A8
		public unsafe Color SelectionRectBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionRectBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionRectBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000C97EC File Offset: 0x000C79EC
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x000C982C File Offset: 0x000C7A2C
		public unsafe Color SelectionRectFillColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_get_SelectionRectFillColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr_set_SelectionRectFillColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000C9870 File Offset: 0x000C7A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93542, XrefRangeEnd = 93544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00010C10 File Offset: 0x0000EE10
		public ObjectSelectionLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x000C98AC File Offset: 0x000C7AAC
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x00010C19 File Offset: 0x0000EE19
		public unsafe bool _drawHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__drawHighlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__drawHighlight)) = value;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000C98D4 File Offset: 0x000C7AD4
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x00010C34 File Offset: 0x0000EE34
		public unsafe SelectionBoxBorderStyle _selectionBoxBorderStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionBoxBorderStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000C9904 File Offset: 0x000C7B04
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x00010C53 File Offset: 0x0000EE53
		public unsafe float _wireCornerLinePercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__wireCornerLinePercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__wireCornerLinePercentage)) = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000C992C File Offset: 0x000C7B2C
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00010C6E File Offset: 0x0000EE6E
		public unsafe SelectionBoxRenderMode _selectionBoxRenderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxRenderMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionBoxRenderMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxRenderMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000C995C File Offset: 0x000C7B5C
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x00010C8D File Offset: 0x0000EE8D
		public unsafe Color _selectionBoxBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000C998C File Offset: 0x000C7B8C
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x00010CAC File Offset: 0x0000EEAC
		public unsafe float _selectionBoxInflateAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxInflateAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionBoxInflateAmount)) = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000C99B4 File Offset: 0x000C7BB4
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x00010CC7 File Offset: 0x0000EEC7
		public unsafe Color _selectionRectBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000C99E4 File Offset: 0x000C7BE4
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x00010CE6 File Offset: 0x0000EEE6
		public unsafe Color _selectionRectFillColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectFillColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionLookAndFeel.NativeFieldInfoPtr__selectionRectFillColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr__drawHighlight;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeFieldInfoPtr__selectionBoxBorderStyle;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeFieldInfoPtr__wireCornerLinePercentage;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeFieldInfoPtr__selectionBoxRenderMode;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeFieldInfoPtr__selectionBoxBorderColor;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr__selectionBoxInflateAmount;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr__selectionRectBorderColor;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeFieldInfoPtr__selectionRectFillColor;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawHighlight_Public_get_Boolean_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawHighlight_Public_set_Void_Boolean_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_get_SelBoxBorderStyle_Public_get_SelectionBoxBorderStyle_0;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr_set_SelBoxBorderStyle_Public_set_Void_SelectionBoxBorderStyle_0;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeMethodInfoPtr_get_WireCornerLinePercentage_Public_get_Single_0;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeMethodInfoPtr_set_WireCornerLinePercentage_Public_set_Void_Single_0;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeMethodInfoPtr_get_SelBoxRenderMode_Public_get_SelectionBoxRenderMode_0;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeMethodInfoPtr_set_SelBoxRenderMode_Public_set_Void_SelectionBoxRenderMode_0;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionBoxBorderColor_Public_get_Color_0;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionBoxBorderColor_Public_set_Void_Color_0;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionBoxInflateAmount_Public_get_Single_0;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionBoxInflateAmount_Public_set_Void_Single_0;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionRectBorderColor_Public_get_Color_0;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionRectBorderColor_Public_set_Void_Color_0;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionRectFillColor_Public_get_Color_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionRectFillColor_Public_set_Void_Color_0;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
