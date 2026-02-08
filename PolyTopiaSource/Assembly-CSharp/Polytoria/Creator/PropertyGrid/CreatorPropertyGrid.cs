using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	// Token: 0x02000314 RID: 788
	public class CreatorPropertyGrid : MonoBehaviour
	{
		// Token: 0x060043DD RID: 17373 RVA: 0x00130C10 File Offset: 0x0012EE10
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorPropertyGrid()
		{
			Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Creator.PropertyGrid", "CreatorPropertyGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr);
			CreatorPropertyGrid.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, "scrollPosition");
			CreatorPropertyGrid.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, "content");
			CreatorPropertyGrid.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, "items");
			CreatorPropertyGrid.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, "instances");
			CreatorPropertyGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674053);
			CreatorPropertyGrid.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674048);
			CreatorPropertyGrid.NativeMethodInfoPtr_SetPropertyGridItems_Public_Void_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674049);
			CreatorPropertyGrid.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674050);
			CreatorPropertyGrid.NativeMethodInfoPtr_AddPropertyItem_Private_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674051);
			CreatorPropertyGrid.NativeMethodInfoPtr_OnValueChanged_Private_Void_PropertyInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, 100674052);
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00130D08 File Offset: 0x0012EF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129393, XrefRangeEnd = 129408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorPropertyGrid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00130D44 File Offset: 0x0012EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129408, XrefRangeEnd = 129413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x00130D78 File Offset: 0x0012EF78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129541, RefRangeEnd = 129544, XrefRangeStart = 129413, XrefRangeEnd = 129541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyGridItems(List<Instance> instances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instances);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr_SetPropertyGridItems_Public_Void_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00130DBC File Offset: 0x0012EFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129551, RefRangeEnd = 129553, XrefRangeStart = 129544, XrefRangeEnd = 129551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00130DF0 File Offset: 0x0012EFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129553, XrefRangeEnd = 129671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPropertyItem(PropertyInfo property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr_AddPropertyItem_Private_Void_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x00130E34 File Offset: 0x0012F034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129687, RefRangeEnd = 129688, XrefRangeStart = 129672, XrefRangeEnd = 129687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(PropertyInfo property, global::Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.NativeMethodInfoPtr_OnValueChanged_Private_Void_PropertyInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x00018F73 File Offset: 0x00017173
		public CreatorPropertyGrid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x00130E88 File Offset: 0x0012F088
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x00018F7C File Offset: 0x0001717C
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_scrollPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_scrollPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00130EB8 File Offset: 0x0012F0B8
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x00018F9B File Offset: 0x0001719B
		public unsafe RectTransform content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x00130EE8 File Offset: 0x0012F0E8
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x00018FBA File Offset: 0x000171BA
		public unsafe Dictionary<string, PropertyGridItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PropertyGridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00130F18 File Offset: 0x0012F118
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x00018FD9 File Offset: 0x000171D9
		public unsafe List<Instance> instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_instances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.NativeFieldInfoPtr_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyGridItems_Public_Void_List_1_Instance_0;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeMethodInfoPtr_AddPropertyItem_Private_Void_PropertyInfo_0;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_PropertyInfo_Object_0;

		// Token: 0x0200041E RID: 1054
		[ObfuscatedName("Polytoria.Creator.PropertyGrid.CreatorPropertyGrid+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005105 RID: 20741 RVA: 0x0015B02C File Offset: 0x0015922C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorPropertyGrid>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr);
				CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr, "property");
				CreatorPropertyGrid.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr, 100674054);
				CreatorPropertyGrid.__c__DisplayClass7_0.NativeMethodInfoPtr__AddPropertyItem_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr, 100674055);
			}

			// Token: 0x06005106 RID: 20742 RVA: 0x0015B0A8 File Offset: 0x001592A8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorPropertyGrid.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005107 RID: 20743 RVA: 0x0015B0E4 File Offset: 0x001592E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129391, XrefRangeEnd = 129393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddPropertyItem_b__0(global::Il2CppSystem.Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorPropertyGrid.__c__DisplayClass7_0.NativeMethodInfoPtr__AddPropertyItem_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005108 RID: 20744 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B4F RID: 6991
			// (get) Token: 0x06005109 RID: 20745 RVA: 0x0015B128 File Offset: 0x00159328
			// (set) Token: 0x0600510A RID: 20746 RVA: 0x0001F0C9 File Offset: 0x0001D2C9
			public unsafe CreatorPropertyGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorPropertyGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B50 RID: 6992
			// (get) Token: 0x0600510B RID: 20747 RVA: 0x0015B158 File Offset: 0x00159358
			// (set) Token: 0x0600510C RID: 20748 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
			public unsafe PropertyInfo property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr_property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorPropertyGrid.__c__DisplayClass7_0.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E4F RID: 15951
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E50 RID: 15952
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04003E51 RID: 15953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E52 RID: 15954
			private static readonly IntPtr NativeMethodInfoPtr__AddPropertyItem_b__0_Internal_Void_Object_0;
		}
	}
}
