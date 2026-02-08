using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200023F RID: 575
	public class PropertyGrid : MonoBehaviour
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x000D22D0 File Offset: 0x000D04D0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGrid()
		{
			Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr);
			PropertyGrid.NativeFieldInfoPtr_targetObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "targetObject");
			PropertyGrid.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "logging");
			PropertyGrid.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "label");
			PropertyGrid.NativeFieldInfoPtr_scrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "scrollbar");
			PropertyGrid.NativeFieldInfoPtr_itemTemplateMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "itemTemplateMap");
			PropertyGrid.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "items");
			PropertyGrid.NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "ValueChanged");
			PropertyGrid.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_Action_2_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670097);
			PropertyGrid.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_Action_2_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670098);
			PropertyGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670107);
			PropertyGrid.NativeMethodInfoPtr_AppendLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670099);
			PropertyGrid.NativeMethodInfoPtr_AppendProperty_Public_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670100);
			PropertyGrid.NativeMethodInfoPtr_Populate_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670101);
			PropertyGrid.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670102);
			PropertyGrid.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670103);
			PropertyGrid.NativeMethodInfoPtr_AppendProperties_Private_Void_Object_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670104);
			PropertyGrid.NativeMethodInfoPtr_AppendProperty_Private_Void_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670105);
			PropertyGrid.NativeMethodInfoPtr_Log_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, 100670106);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000D2468 File Offset: 0x000D0668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96882, XrefRangeEnd = 96887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChanged(Action<global::Il2CppSystem.Object, PropertyInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_Action_2_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000D24AC File Offset: 0x000D06AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96887, XrefRangeEnd = 96892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChanged(Action<global::Il2CppSystem.Object, PropertyInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_Action_2_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000D24F0 File Offset: 0x000D06F0
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGrid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x000D252C File Offset: 0x000D072C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96914, RefRangeEnd = 96916, XrefRangeStart = 96892, XrefRangeEnd = 96914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLabel(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_AppendLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000D2570 File Offset: 0x000D0770
		[CallerCount(0)]
		public unsafe T AppendProperty<T>(string caption, global::Il2CppSystem.Object value) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.MethodInfoStoreGeneric_AppendProperty_Public_T_String_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000D25CC File Offset: 0x000D07CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96960, RefRangeEnd = 96962, XrefRangeStart = 96916, XrefRangeEnd = 96960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Populate(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_Populate_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000D2610 File Offset: 0x000D0810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96986, RefRangeEnd = 96987, XrefRangeStart = 96962, XrefRangeEnd = 96986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000D2644 File Offset: 0x000D0844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96987, XrefRangeEnd = 97063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000D2678 File Offset: 0x000D0878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97071, RefRangeEnd = 97073, XrefRangeStart = 97063, XrefRangeEnd = 97071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendProperties(global::Il2CppSystem.Object obj, List<string> exclude = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exclude);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_AppendProperties_Private_Void_Object_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000D26CC File Offset: 0x000D08CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97141, RefRangeEnd = 97142, XrefRangeStart = 97073, XrefRangeEnd = 97141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendProperty(global::Il2CppSystem.Object obj, PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_AppendProperty_Private_Void_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000D2720 File Offset: 0x000D0920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97149, RefRangeEnd = 97150, XrefRangeStart = 97142, XrefRangeEnd = 97149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.NativeMethodInfoPtr_Log_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public PropertyGrid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000D2764 File Offset: 0x000D0964
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00011DE9 File Offset: 0x0000FFE9
		public unsafe GameObject targetObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_targetObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_targetObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000D2794 File Offset: 0x000D0994
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x00011E08 File Offset: 0x00010008
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000D27BC File Offset: 0x000D09BC
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x00011E23 File Offset: 0x00010023
		public unsafe GameObject label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000D27EC File Offset: 0x000D09EC
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00011E42 File Offset: 0x00010042
		public unsafe GameObject scrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_scrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_scrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000D281C File Offset: 0x000D0A1C
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x00011E61 File Offset: 0x00010061
		public unsafe Dictionary<Type, GameObject> itemTemplateMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_itemTemplateMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_itemTemplateMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000D284C File Offset: 0x000D0A4C
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x00011E80 File Offset: 0x00010080
		public unsafe List<GameObject> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000D287C File Offset: 0x000D0A7C
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x00011E9F File Offset: 0x0001009F
		public unsafe Action<global::Il2CppSystem.Object, PropertyInfo> ValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_ValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<global::Il2CppSystem.Object, PropertyInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.NativeFieldInfoPtr_ValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeFieldInfoPtr_targetObject;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeFieldInfoPtr_scrollbar;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeFieldInfoPtr_itemTemplateMap;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeFieldInfoPtr_ValueChanged;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_add_Void_Action_2_Object_PropertyInfo_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_rem_Void_Action_2_Object_PropertyInfo_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_AppendLabel_Public_Void_String_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_AppendProperty_Public_T_String_Object_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Void_Object_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_AppendProperties_Private_Void_Object_List_1_String_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_AppendProperty_Private_Void_Object_PropertyInfo_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_Log_Private_Void_String_0;

		// Token: 0x020003DD RID: 989
		[ObfuscatedName("namudev.PropertyGrid+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : global::Il2CppSystem.Object where T : Component
		{
			// Token: 0x06004D18 RID: 19736 RVA: 0x0014F520 File Offset: 0x0014D720
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr);
				PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr, "<>9");
				PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				PropertyGrid.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr, 100670109);
				PropertyGrid.__c__10<T>.NativeMethodInfoPtr__AppendProperty_b__10_0_Internal_Boolean_KeyValuePair_2_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr, 100670110);
			}

			// Token: 0x06004D19 RID: 19737 RVA: 0x0014F5D8 File Offset: 0x0014D7D8
			[CallerCount(0)]
			public unsafe __c__10()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGrid.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D1A RID: 19738 RVA: 0x0014F614 File Offset: 0x0014D814
			[CallerCount(0)]
			public unsafe bool _AppendProperty_b__10_0(KeyValuePair<Type, Type> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.__c__10<T>.NativeMethodInfoPtr__AppendProperty_b__10_0_Internal_Boolean_KeyValuePair_2_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D1B RID: 19739 RVA: 0x0001D141 File Offset: 0x0001B341
			public __c__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019FA RID: 6650
			// (get) Token: 0x06004D1C RID: 19740 RVA: 0x0014F664 File Offset: 0x0014D864
			// (set) Token: 0x06004D1D RID: 19741 RVA: 0x0001D14A File Offset: 0x0001B34A
			public unsafe static PropertyGrid.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGrid.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FB RID: 6651
			// (get) Token: 0x06004D1E RID: 19742 RVA: 0x0014F68C File Offset: 0x0014D88C
			// (set) Token: 0x06004D1F RID: 19743 RVA: 0x0001D15C File Offset: 0x0001B35C
			public unsafe static Func<KeyValuePair<Type, Type>, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Type, Type>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyGrid.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BE8 RID: 15336
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BE9 RID: 15337
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04003BEA RID: 15338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BEB RID: 15339
			private static readonly IntPtr NativeMethodInfoPtr__AppendProperty_b__10_0_Internal_Boolean_KeyValuePair_2_Type_Type_0;
		}

		// Token: 0x020003DE RID: 990
		[ObfuscatedName("namudev.PropertyGrid+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D20 RID: 19744 RVA: 0x0014F6B4 File Offset: 0x0014D8B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr);
				PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr, "obj");
				PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_propertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr, "propertyInfo");
				PropertyGrid.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr, 100670111);
				PropertyGrid.__c__DisplayClass15_0.NativeMethodInfoPtr__AppendProperty_b__0_Internal_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr, 100670112);
			}

			// Token: 0x06004D21 RID: 19745 RVA: 0x0014F744 File Offset: 0x0014D944
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGrid.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D22 RID: 19746 RVA: 0x0014F780 File Offset: 0x0014D980
			[CallerCount(0)]
			public unsafe void _AppendProperty_b__0(global::Il2CppSystem.Object s, EventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGrid.__c__DisplayClass15_0.NativeMethodInfoPtr__AppendProperty_b__0_Internal_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D23 RID: 19747 RVA: 0x0001D16E File Offset: 0x0001B36E
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019FC RID: 6652
			// (get) Token: 0x06004D24 RID: 19748 RVA: 0x0014F7D4 File Offset: 0x0014D9D4
			// (set) Token: 0x06004D25 RID: 19749 RVA: 0x0001D177 File Offset: 0x0001B377
			public unsafe PropertyGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FD RID: 6653
			// (get) Token: 0x06004D26 RID: 19750 RVA: 0x0014F804 File Offset: 0x0014DA04
			// (set) Token: 0x06004D27 RID: 19751 RVA: 0x0001D196 File Offset: 0x0001B396
			public unsafe global::Il2CppSystem.Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FE RID: 6654
			// (get) Token: 0x06004D28 RID: 19752 RVA: 0x0014F834 File Offset: 0x0014DA34
			// (set) Token: 0x06004D29 RID: 19753 RVA: 0x0001D1B5 File Offset: 0x0001B3B5
			public unsafe PropertyInfo propertyInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_propertyInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGrid.__c__DisplayClass15_0.NativeFieldInfoPtr_propertyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BEC RID: 15340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BED RID: 15341
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04003BEE RID: 15342
			private static readonly IntPtr NativeFieldInfoPtr_propertyInfo;

			// Token: 0x04003BEF RID: 15343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BF0 RID: 15344
			private static readonly IntPtr NativeMethodInfoPtr__AppendProperty_b__0_Internal_Void_Object_EventArgs_0;
		}

		// Token: 0x020003DF RID: 991
		private sealed class MethodInfoStoreGeneric_AppendProperty_Public_T_String_Object_0<T>
		{
			// Token: 0x04003BF1 RID: 15345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyGrid.NativeMethodInfoPtr_AppendProperty_Public_T_String_Object_0, Il2CppClassPointerStore<PropertyGrid>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
