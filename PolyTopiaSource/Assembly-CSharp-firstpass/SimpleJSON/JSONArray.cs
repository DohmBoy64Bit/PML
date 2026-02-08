using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace SimpleJSON
{
	// Token: 0x0200001D RID: 29
	public class JSONArray : JSONNode
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x00028884 File Offset: 0x00026A84
		// Note: this type is marked as 'beforefieldinit'.
		static JSONArray()
		{
			Il2CppClassPointerStore<JSONArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SimpleJSON", "JSONArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONArray>.NativeClassPtr);
			JSONArray.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "m_List");
			JSONArray.NativeFieldInfoPtr_inline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "inline");
			JSONArray.NativeMethodInfoPtr_get_Inline_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664300);
			JSONArray.NativeMethodInfoPtr_set_Inline_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664301);
			JSONArray.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664302);
			JSONArray.NativeMethodInfoPtr_get_IsArray_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664303);
			JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664305);
			JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664306);
			JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664307);
			JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664308);
			JSONArray.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664309);
			JSONArray.NativeMethodInfoPtr_get_Children_Public_Virtual_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664313);
			JSONArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664315);
			JSONArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664304);
			JSONArray.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664310);
			JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664311);
			JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664312);
			JSONArray.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100664314);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00028A1C File Offset: 0x00026C1C
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00028A64 File Offset: 0x00026C64
		public unsafe override bool Inline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Inline_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_set_Inline_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00028AB0 File Offset: 0x00026CB0
		public unsafe override JSONNodeType Tag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNodeType>(intPtr3) : null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00028AFC File Offset: 0x00026CFC
		public unsafe override bool IsArray
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_IsArray_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		public unsafe override JSONNode this[int aIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20136, XrefRangeEnd = 20146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20146, XrefRangeEnd = 20161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011A RID: 282
		public unsafe override JSONNode this[string aKey]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20161, XrefRangeEnd = 20167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20167, XrefRangeEnd = 20178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20178, XrefRangeEnd = 20179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00028CFC File Offset: 0x00026EFC
		public unsafe override IEnumerable<JSONNode> Children
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20179, XrefRangeEnd = 20185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Children_Public_Virtual_get_IEnumerable_1_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00028D48 File Offset: 0x00026F48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20193, RefRangeEnd = 20197, XrefRangeStart = 20185, XrefRangeEnd = 20193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00028D84 File Offset: 0x00026F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20197, XrefRangeEnd = 20201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JSONNode.Enumerator(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00028DC8 File Offset: 0x00026FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20201, XrefRangeEnd = 20212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string aKey, JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00028E28 File Offset: 0x00027028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20212, XrefRangeEnd = 20219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(int aIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00028E80 File Offset: 0x00027080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20219, XrefRangeEnd = 20222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(JSONNode aNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00028EDC File Offset: 0x000270DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20222, XrefRangeEnd = 20235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aSB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aIndent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aIndentInc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000346C File Offset: 0x0000166C
		public JSONArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00028F58 File Offset: 0x00027158
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00003475 File Offset: 0x00001675
		public unsafe List<JSONNode> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JSONNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00028F88 File Offset: 0x00027188
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00003494 File Offset: 0x00001694
		public unsafe bool inline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_inline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_inline)) = value;
			}
		}

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_inline;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_get_Inline_Public_Virtual_get_Boolean_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_set_Inline_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArray_Public_Virtual_get_Boolean_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Virtual_get_IEnumerable_1_JSONNode_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0;

		// Token: 0x02000178 RID: 376
		[ObfuscatedName("SimpleJSON.JSONArray+<get_Children>d__22")]
		public sealed class _get_Children_d__22 : Object
		{
			// Token: 0x06001973 RID: 6515 RVA: 0x0007E1F4 File Offset: 0x0007C3F4
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Children_d__22()
			{
				Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "<get_Children>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr);
				JSONArray._get_Children_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, "<>1__state");
				JSONArray._get_Children_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, "<>2__current");
				JSONArray._get_Children_d__22.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, "<>l__initialThreadId");
				JSONArray._get_Children_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, "<>4__this");
				JSONArray._get_Children_d__22.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, "<>7__wrap1");
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664320);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664322);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664316);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664317);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664318);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664319);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664321);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664323);
				JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr, 100664324);
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x06001974 RID: 6516 RVA: 0x0007E338 File Offset: 0x0007C538
			public unsafe JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x06001975 RID: 6517 RVA: 0x0007E378 File Offset: 0x0007C578
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18122, XrefRangeEnd = 18124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Children_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONArray._get_Children_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001977 RID: 6519 RVA: 0x0007E400 File Offset: 0x0007C600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20089, XrefRangeEnd = 20094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001978 RID: 6520 RVA: 0x0007E434 File Offset: 0x0007C634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20094, XrefRangeEnd = 20110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001979 RID: 6521 RVA: 0x0007E470 File Offset: 0x0007C670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20110, XrefRangeEnd = 20113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197A RID: 6522 RVA: 0x0007E4A4 File Offset: 0x0007C6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20113, XrefRangeEnd = 20118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197B RID: 6523 RVA: 0x0007E4D8 File Offset: 0x0007C6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20118, XrefRangeEnd = 20120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x0600197C RID: 6524 RVA: 0x0007E518 File Offset: 0x0007C718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Children_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600197D RID: 6525 RVA: 0x0000A0DA File Offset: 0x000082DA
			public _get_Children_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x0600197E RID: 6526 RVA: 0x0007E558 File Offset: 0x0007C758
			// (set) Token: 0x0600197F RID: 6527 RVA: 0x0000A0E3 File Offset: 0x000082E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06001980 RID: 6528 RVA: 0x0007E580 File Offset: 0x0007C780
			// (set) Token: 0x06001981 RID: 6529 RVA: 0x0000A0FE File Offset: 0x000082FE
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06001982 RID: 6530 RVA: 0x0007E5B0 File Offset: 0x0007C7B0
			// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000A11D File Offset: 0x0000831D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x06001984 RID: 6532 RVA: 0x0007E5D8 File Offset: 0x0007C7D8
			// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000A138 File Offset: 0x00008338
			public unsafe JSONArray __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x06001986 RID: 6534 RVA: 0x0007E608 File Offset: 0x0007C808
			// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000A157 File Offset: 0x00008357
			public unsafe List<JSONNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JSONNode>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Children_d__22.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001502 RID: 5378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x04001503 RID: 5379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
