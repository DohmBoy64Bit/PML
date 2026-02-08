using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace namudev
{
	// Token: 0x02000246 RID: 582
	public static class PropertyGridItem : Object
	{
		// Token: 0x06002D79 RID: 11641 RVA: 0x0001219E File Offset: 0x0001039E
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridItem()
		{
			Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridItem");
			PropertyGridItem.NativeFieldInfoPtr_TypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "TypeMap");
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000121CD File Offset: 0x000103CD
		public PropertyGridItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x000D3E68 File Offset: 0x000D2068
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x000121D6 File Offset: 0x000103D6
		public unsafe static Dictionary<Type, Type> TypeMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropertyGridItem.NativeFieldInfoPtr_TypeMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyGridItem.NativeFieldInfoPtr_TypeMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeFieldInfoPtr_TypeMap;

		// Token: 0x020003E1 RID: 993
		[ObfuscatedName("namudev.PropertyGridItem+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004D33 RID: 19763 RVA: 0x0014FA10 File Offset: 0x0014DC10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyGridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr);
				PropertyGridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr, "<>9");
				PropertyGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr, 100670162);
				PropertyGridItem.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr, 100670163);
				PropertyGridItem.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr, 100670164);
			}

			// Token: 0x06004D34 RID: 19764 RVA: 0x0014FA8C File Offset: 0x0014DC8C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D35 RID: 19765 RVA: 0x0014FAC8 File Offset: 0x0014DCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97838, XrefRangeEnd = 97842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D36 RID: 19766 RVA: 0x0014FB18 File Offset: 0x0014DD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97842, XrefRangeEnd = 97843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_1(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridItem.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D37 RID: 19767 RVA: 0x0001D21B File Offset: 0x0001B41B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A01 RID: 6657
			// (get) Token: 0x06004D38 RID: 19768 RVA: 0x0014FB68 File Offset: 0x0014DD68
			// (set) Token: 0x06004D39 RID: 19769 RVA: 0x0001D224 File Offset: 0x0001B424
			public unsafe static PropertyGridItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyGridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyGridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BF6 RID: 15350
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BF7 RID: 15351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BF8 RID: 15352
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0;

			// Token: 0x04003BF9 RID: 15353
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_1_Internal_Boolean_Type_0;
		}
	}
}
