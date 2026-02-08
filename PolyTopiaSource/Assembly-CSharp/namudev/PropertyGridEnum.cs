using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000243 RID: 579
	public class PropertyGridEnum : PropertyGridItem<Enum>
	{
		// Token: 0x06002D5A RID: 11610 RVA: 0x000D3828 File Offset: 0x000D1A28
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridEnum()
		{
			Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridEnum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr);
			PropertyGridEnum.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, "caption");
			PropertyGridEnum.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, "controls");
			PropertyGridEnum.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, 100670147);
			PropertyGridEnum.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, 100670145);
			PropertyGridEnum.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, 100670146);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000D38BC File Offset: 0x000D1ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97556, XrefRangeEnd = 97559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridEnum()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridEnum.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000D38F8 File Offset: 0x000D1AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97559, XrefRangeEnd = 97575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridEnum.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000D3934 File Offset: 0x000D1B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97575, XrefRangeEnd = 97666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridEnum.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000120C9 File Offset: 0x000102C9
		public PropertyGridEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000D3968 File Offset: 0x000D1B68
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x000120D2 File Offset: 0x000102D2
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000D3998 File Offset: 0x000D1B98
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x000120F1 File Offset: 0x000102F1
		public unsafe GameObject controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x020003E0 RID: 992
		[ObfuscatedName("namudev.PropertyGridEnum+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D2B RID: 19755 RVA: 0x0014F8B8 File Offset: 0x0014DAB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyGridEnum>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr);
				PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr, "values");
				PropertyGridEnum.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr, 100670148);
				PropertyGridEnum.__c__DisplayClass3_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr, 100670149);
			}

			// Token: 0x06004D2C RID: 19756 RVA: 0x0014F934 File Offset: 0x0014DB34
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridEnum.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridEnum.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D2D RID: 19757 RVA: 0x0014F970 File Offset: 0x0014DB70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97528, XrefRangeEnd = 97556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridEnum.__c__DisplayClass3_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D2E RID: 19758 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019FF RID: 6655
			// (get) Token: 0x06004D2F RID: 19759 RVA: 0x0014F9B0 File Offset: 0x0014DBB0
			// (set) Token: 0x06004D30 RID: 19760 RVA: 0x0001D1DD File Offset: 0x0001B3DD
			public unsafe PropertyGridEnum __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGridEnum>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A00 RID: 6656
			// (get) Token: 0x06004D31 RID: 19761 RVA: 0x0014F9E0 File Offset: 0x0014DBE0
			// (set) Token: 0x06004D32 RID: 19762 RVA: 0x0001D1FC File Offset: 0x0001B3FC
			public unsafe List<Enum> values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridEnum.__c__DisplayClass3_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BF2 RID: 15346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BF3 RID: 15347
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x04003BF4 RID: 15348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BF5 RID: 15349
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0;
		}
	}
}
