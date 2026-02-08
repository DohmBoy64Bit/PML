using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000241 RID: 577
	public class PropertyGridBool : PropertyGridItem<bool>
	{
		// Token: 0x06002D2E RID: 11566 RVA: 0x000D2EA4 File Offset: 0x000D10A4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridBool()
		{
			Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridBool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr);
			PropertyGridBool.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, "caption");
			PropertyGridBool.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, "controls");
			PropertyGridBool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, 100670127);
			PropertyGridBool.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, 100670125);
			PropertyGridBool.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, 100670126);
			PropertyGridBool.NativeMethodInfoPtr__Start_b__3_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr, 100670128);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000D2F4C File Offset: 0x000D114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97176, XrefRangeEnd = 97179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridBool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridBool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000D2F88 File Offset: 0x000D1188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97179, XrefRangeEnd = 97195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridBool.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000D2FC4 File Offset: 0x000D11C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97195, XrefRangeEnd = 97218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBool.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000D2FF8 File Offset: 0x000D11F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97218, XrefRangeEnd = 97221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__3_0(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridBool.NativeMethodInfoPtr__Start_b__3_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00011F81 File Offset: 0x00010181
		public PropertyGridBool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000D3038 File Offset: 0x000D1238
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x00011F8A File Offset: 0x0001018A
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBool.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBool.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000D3068 File Offset: 0x000D1268
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x00011FA9 File Offset: 0x000101A9
		public unsafe GameObject controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBool.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridBool.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Private_Void_Boolean_0;
	}
}
