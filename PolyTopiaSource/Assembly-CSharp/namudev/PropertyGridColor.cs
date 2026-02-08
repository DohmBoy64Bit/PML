using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace namudev
{
	// Token: 0x02000242 RID: 578
	public class PropertyGridColor : PropertyGridItem<Color>
	{
		// Token: 0x06002D38 RID: 11576 RVA: 0x000D3098 File Offset: 0x000D1298
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridColor()
		{
			Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr);
			PropertyGridColor.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "caption");
			PropertyGridColor.NativeFieldInfoPtr_inputFieldR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "inputFieldR");
			PropertyGridColor.NativeFieldInfoPtr_inputFieldG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "inputFieldG");
			PropertyGridColor.NativeFieldInfoPtr_inputFieldB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "inputFieldB");
			PropertyGridColor.NativeFieldInfoPtr_inputFieldA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "inputFieldA");
			PropertyGridColor.NativeFieldInfoPtr_inputFieldHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "inputFieldHex");
			PropertyGridColor.NativeFieldInfoPtr_colorDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "colorDisplayer");
			PropertyGridColor.NativeFieldInfoPtr_colorDisplayerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, "colorDisplayerBtn");
			PropertyGridColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670144);
			PropertyGridColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670129);
			PropertyGridColor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670130);
			PropertyGridColor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670131);
			PropertyGridColor.NativeMethodInfoPtr_OnColorBtnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670132);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670133);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChangeHex_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670134);
			PropertyGridColor.NativeMethodInfoPtr_OnEndEditHex_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670135);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChangeR_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670136);
			PropertyGridColor.NativeMethodInfoPtr_OnEndEditR_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670137);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChangeG_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670138);
			PropertyGridColor.NativeMethodInfoPtr_OnEndEditG_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670139);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChangeB_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670140);
			PropertyGridColor.NativeMethodInfoPtr_OnEndEditB_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670141);
			PropertyGridColor.NativeMethodInfoPtr_OnValueChangeA_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670142);
			PropertyGridColor.NativeMethodInfoPtr_OnEndEditA_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr, 100670143);
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000D32A8 File Offset: 0x000D14A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97221, XrefRangeEnd = 97224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridColor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000D32E4 File Offset: 0x000D14E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97224, XrefRangeEnd = 97252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000D3320 File Offset: 0x000D1520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97252, XrefRangeEnd = 97259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000D3354 File Offset: 0x000D1554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97259, XrefRangeEnd = 97301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000D3388 File Offset: 0x000D1588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97301, XrefRangeEnd = 97334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorBtnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnColorBtnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x000D33BC File Offset: 0x000D15BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97368, RefRangeEnd = 97369, XrefRangeStart = 97334, XrefRangeEnd = 97368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChange(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000D3400 File Offset: 0x000D1600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97369, XrefRangeEnd = 97377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeHex(string hexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hexColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChangeHex_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000D3444 File Offset: 0x000D1644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97377, XrefRangeEnd = 97404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditHex(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnEndEditHex_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x000D3488 File Offset: 0x000D1688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97404, XrefRangeEnd = 97411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeR(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChangeR_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000D34CC File Offset: 0x000D16CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97411, XrefRangeEnd = 97435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditR(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnEndEditR_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000D3510 File Offset: 0x000D1710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97435, XrefRangeEnd = 97442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeG(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChangeG_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x000D3554 File Offset: 0x000D1754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97442, XrefRangeEnd = 97466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditG(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnEndEditG_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000D3598 File Offset: 0x000D1798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97466, XrefRangeEnd = 97473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeB(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChangeB_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x000D35DC File Offset: 0x000D17DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97473, XrefRangeEnd = 97497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditB(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnEndEditB_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000D3620 File Offset: 0x000D1820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97497, XrefRangeEnd = 97504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeA(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnValueChangeA_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000D3664 File Offset: 0x000D1864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97504, XrefRangeEnd = 97528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditA(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridColor.NativeMethodInfoPtr_OnEndEditA_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00011FC8 File Offset: 0x000101C8
		public PropertyGridColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000D36A8 File Offset: 0x000D18A8
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x00011FD1 File Offset: 0x000101D1
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000D36D8 File Offset: 0x000D18D8
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x00011FF0 File Offset: 0x000101F0
		public unsafe GameObject inputFieldR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000D3708 File Offset: 0x000D1908
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x0001200F File Offset: 0x0001020F
		public unsafe GameObject inputFieldG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000D3738 File Offset: 0x000D1938
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x0001202E File Offset: 0x0001022E
		public unsafe GameObject inputFieldB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000D3768 File Offset: 0x000D1968
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x0001204D File Offset: 0x0001024D
		public unsafe GameObject inputFieldA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x000D3798 File Offset: 0x000D1998
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x0001206C File Offset: 0x0001026C
		public unsafe GameObject inputFieldHex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldHex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_inputFieldHex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000D37C8 File Offset: 0x000D19C8
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x0001208B File Offset: 0x0001028B
		public unsafe Image colorDisplayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_colorDisplayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_colorDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000D37F8 File Offset: 0x000D19F8
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000120AA File Offset: 0x000102AA
		public unsafe Button colorDisplayerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_colorDisplayerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridColor.NativeFieldInfoPtr_colorDisplayerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldR;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldG;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldB;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldA;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldHex;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayer;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplayerBtn;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_OnColorBtnClick_Private_Void_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_Color_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeHex_Private_Void_String_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditHex_Private_Void_String_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeR_Private_Void_String_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditR_Private_Void_String_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeG_Private_Void_String_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditG_Private_Void_String_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeB_Private_Void_String_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditB_Private_Void_String_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeA_Private_Void_String_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditA_Private_Void_String_0;
	}
}
