using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.DataStructs;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000036 RID: 54
	public class Table : RefIdObject
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00030040 File Offset: 0x0002E240
		// Note: this type is marked as 'beforefieldinit'.
		static Table()
		{
			Il2CppClassPointerStore<Table>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "Table");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Table>.NativeClassPtr);
			Table.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_Values");
			Table.NativeFieldInfoPtr_m_ValueMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_ValueMap");
			Table.NativeFieldInfoPtr_m_StringMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_StringMap");
			Table.NativeFieldInfoPtr_m_ArrayMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_ArrayMap");
			Table.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_Owner");
			Table.NativeFieldInfoPtr_m_InitArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_InitArray");
			Table.NativeFieldInfoPtr_m_CachedLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_CachedLength");
			Table.NativeFieldInfoPtr_m_ContainsNilEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_ContainsNilEntries");
			Table.NativeFieldInfoPtr_m_MetaTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table>.NativeClassPtr, "m_MetaTable");
			Table.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664647);
			Table.NativeMethodInfoPtr_get_Item_Public_get_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664650);
			Table.NativeMethodInfoPtr_set_Item_Public_set_Void_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664651);
			Table.NativeMethodInfoPtr_get_Item_Public_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664652);
			Table.NativeMethodInfoPtr_set_Item_Public_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664653);
			Table.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664682);
			Table.NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664684);
			Table.NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664685);
			Table.NativeMethodInfoPtr_get_Pairs_Public_get_IEnumerable_1_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664686);
			Table.NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664687);
			Table.NativeMethodInfoPtr_get_Values_Public_get_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664688);
			Table.NativeMethodInfoPtr__ctor_Public_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664645);
			Table.NativeMethodInfoPtr__ctor_Public_Void_Script_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664646);
			Table.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664648);
			Table.NativeMethodInfoPtr_GetIntegralKey_Private_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664649);
			Table.NativeMethodInfoPtr_ResolveMultipleKeys_Private_Table_Il2CppReferenceArray_1_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664654);
			Table.NativeMethodInfoPtr_Append_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664655);
			Table.NativeMethodInfoPtr_PerformTableSet_Private_Void_LinkedListIndex_2_T_TablePair_T_DynValue_DynValue_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664656);
			Table.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664657);
			Table.NativeMethodInfoPtr_Set_Public_Void_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664658);
			Table.NativeMethodInfoPtr_Set_Public_Void_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664659);
			Table.NativeMethodInfoPtr_Set_Public_Void_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664660);
			Table.NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664661);
			Table.NativeMethodInfoPtr_Get_Public_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664662);
			Table.NativeMethodInfoPtr_Get_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664663);
			Table.NativeMethodInfoPtr_Get_Public_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664664);
			Table.NativeMethodInfoPtr_Get_Public_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664665);
			Table.NativeMethodInfoPtr_Get_Public_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664666);
			Table.NativeMethodInfoPtr_RawGetValue_Private_Static_DynValue_LinkedListNode_1_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664667);
			Table.NativeMethodInfoPtr_RawGet_Public_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664668);
			Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664669);
			Table.NativeMethodInfoPtr_RawGet_Public_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664670);
			Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664671);
			Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664672);
			Table.NativeMethodInfoPtr_PerformTableRemove_Private_Boolean_LinkedListIndex_2_T_TablePair_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664673);
			Table.NativeMethodInfoPtr_Remove_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664674);
			Table.NativeMethodInfoPtr_Remove_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664675);
			Table.NativeMethodInfoPtr_Remove_Public_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664676);
			Table.NativeMethodInfoPtr_Remove_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664677);
			Table.NativeMethodInfoPtr_Remove_Public_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664678);
			Table.NativeMethodInfoPtr_CollectDeadKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664679);
			Table.NativeMethodInfoPtr_NextKey_Public_Nullable_1_TablePair_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664680);
			Table.NativeMethodInfoPtr_GetNextOf_Private_Nullable_1_TablePair_LinkedListNode_1_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664681);
			Table.NativeMethodInfoPtr_InitNextArrayKeys_Internal_Void_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table>.NativeClassPtr, 100664683);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00030494 File Offset: 0x0002E694
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
		}

		// Token: 0x1700019A RID: 410
		public unsafe Object this[[Optional] Il2CppReferenceArray<Object> keys]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23535, XrefRangeEnd = 23538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				if (keys == null)
				{
					keys = new Il2CppReferenceArray<Object>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Item_Public_get_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23538, XrefRangeEnd = 23550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				if (keys == null)
				{
					keys = new Il2CppReferenceArray<Object>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_set_Item_Public_set_Void_Il2CppReferenceArray_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019B RID: 411
		public unsafe Object this[Object key]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23560, RefRangeEnd = 23561, XrefRangeStart = 23550, XrefRangeEnd = 23560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Item_Public_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 23566, RefRangeEnd = 23569, XrefRangeStart = 23561, XrefRangeEnd = 23566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_set_Item_Public_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0003063C File Offset: 0x0002E83C
		public unsafe int Length
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 23580, RefRangeEnd = 23590, XrefRangeStart = 23569, XrefRangeEnd = 23580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00030678 File Offset: 0x0002E878
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public unsafe Table MetaTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 23592, RefRangeEnd = 23595, XrefRangeStart = 23590, XrefRangeEnd = 23592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000306FC File Offset: 0x0002E8FC
		public unsafe IEnumerable<TablePair> Pairs
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 23613, RefRangeEnd = 23617, XrefRangeStart = 23595, XrefRangeEnd = 23613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Pairs_Public_get_IEnumerable_1_TablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TablePair>>(intPtr3) : null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0003073C File Offset: 0x0002E93C
		public unsafe IEnumerable<DynValue> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23617, XrefRangeEnd = 23635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0003077C File Offset: 0x0002E97C
		public unsafe IEnumerable<DynValue> Values
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 23653, RefRangeEnd = 23656, XrefRangeStart = 23635, XrefRangeEnd = 23653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_get_Values_Public_get_IEnumerable_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000307BC File Offset: 0x0002E9BC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 23688, RefRangeEnd = 23704, XrefRangeStart = 23656, XrefRangeEnd = 23688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table(Script owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Table>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr__ctor_Public_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00030808 File Offset: 0x0002EA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23704, XrefRangeEnd = 23711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table(Script owner, [Optional] Il2CppReferenceArray<DynValue> arrayValues)
		{
			if (arrayValues == null)
			{
				arrayValues = new Il2CppReferenceArray<DynValue>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Table>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr__ctor_Public_Void_Script_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00030874 File Offset: 0x0002EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23711, XrefRangeEnd = 23723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000308A8 File Offset: 0x0002EAA8
		[CallerCount(0)]
		public unsafe int GetIntegralKey(double d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_GetIntegralKey_Private_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000308F4 File Offset: 0x0002EAF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 23729, RefRangeEnd = 23734, XrefRangeStart = 23723, XrefRangeEnd = 23729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table ResolveMultipleKeys(Il2CppReferenceArray<Object> keys, out Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_ResolveMultipleKeys_Private_Table_Il2CppReferenceArray_1_Object_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			key = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Table>(intPtr5) : null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00030968 File Offset: 0x0002EB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23748, RefRangeEnd = 23750, XrefRangeStart = 23734, XrefRangeEnd = 23748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Append_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000309AC File Offset: 0x0002EBAC
		[CallerCount(0)]
		public unsafe void PerformTableSet<T>(LinkedListIndex<T, TablePair> listIndex, T key, DynValue keyDynValue, DynValue value, bool isNumber, int appendKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listIndex);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = key;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyDynValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNumber;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendKey;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Table.MethodInfoStoreGeneric_PerformTableSet_Private_Void_LinkedListIndex_2_T_TablePair_T_DynValue_DynValue_Boolean_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00030A78 File Offset: 0x0002EC78
		[CallerCount(110)]
		[CachedScanResults(RefRangeStart = 23761, RefRangeEnd = 23871, XrefRangeStart = 23750, XrefRangeEnd = 23761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string key, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00030ACC File Offset: 0x0002ECCC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 23882, RefRangeEnd = 23897, XrefRangeStart = 23871, XrefRangeEnd = 23882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int key, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Set_Public_Void_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00030B1C File Offset: 0x0002ED1C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 23909, RefRangeEnd = 23919, XrefRangeStart = 23897, XrefRangeEnd = 23909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(DynValue key, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Set_Public_Void_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00030B70 File Offset: 0x0002ED70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23934, RefRangeEnd = 23935, XrefRangeStart = 23919, XrefRangeEnd = 23934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Object key, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Set_Public_Void_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23935, XrefRangeEnd = 23943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Il2CppReferenceArray<Object> keys, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00030C18 File Offset: 0x0002EE18
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 23951, RefRangeEnd = 23964, XrefRangeStart = 23943, XrefRangeEnd = 23951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Get(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Get_Public_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00030C68 File Offset: 0x0002EE68
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 23972, RefRangeEnd = 23983, XrefRangeStart = 23964, XrefRangeEnd = 23972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Get(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Get_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00030CB4 File Offset: 0x0002EEB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 23991, RefRangeEnd = 23996, XrefRangeStart = 23983, XrefRangeEnd = 23991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Get(DynValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Get_Public_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00030D04 File Offset: 0x0002EF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23996, XrefRangeEnd = 24004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Get(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Get_Public_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00030D54 File Offset: 0x0002EF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24019, RefRangeEnd = 24020, XrefRangeStart = 24004, XrefRangeEnd = 24019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Get([Optional] Il2CppReferenceArray<Object> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Get_Public_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24020, XrefRangeEnd = 24024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linkedListNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGetValue_Private_Static_DynValue_LinkedListNode_1_TablePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 24031, RefRangeEnd = 24049, XrefRangeStart = 24024, XrefRangeEnd = 24031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGet_Public_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00030E48 File Offset: 0x0002F048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24056, RefRangeEnd = 24059, XrefRangeStart = 24049, XrefRangeEnd = 24056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00030E94 File Offset: 0x0002F094
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 24067, RefRangeEnd = 24071, XrefRangeStart = 24059, XrefRangeEnd = 24067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet(DynValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGet_Public_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24081, RefRangeEnd = 24084, XrefRangeStart = 24071, XrefRangeEnd = 24081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00030F34 File Offset: 0x0002F134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24084, XrefRangeEnd = 24092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet([Optional] Il2CppReferenceArray<Object> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_RawGet_Public_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00030F94 File Offset: 0x0002F194
		[CallerCount(0)]
		public unsafe bool PerformTableRemove<T>(LinkedListIndex<T, TablePair> listIndex, T key, bool isNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listIndex);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = key;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNumber;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Table.MethodInfoStoreGeneric_PerformTableRemove_Private_Boolean_LinkedListIndex_2_T_TablePair_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00031038 File Offset: 0x0002F238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24092, XrefRangeEnd = 24095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Remove_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00031088 File Offset: 0x0002F288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24098, RefRangeEnd = 24099, XrefRangeStart = 24095, XrefRangeEnd = 24098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Remove_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000310D4 File Offset: 0x0002F2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24103, RefRangeEnd = 24104, XrefRangeStart = 24099, XrefRangeEnd = 24103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(DynValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Remove_Public_Boolean_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00031124 File Offset: 0x0002F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24104, XrefRangeEnd = 24111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Remove_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00031174 File Offset: 0x0002F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24111, XrefRangeEnd = 24119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove([Optional] Il2CppReferenceArray<Object> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_Remove_Public_Boolean_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000311D0 File Offset: 0x0002F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24119, XrefRangeEnd = 24130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectDeadKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_CollectDeadKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00031204 File Offset: 0x0002F404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24146, RefRangeEnd = 24147, XrefRangeStart = 24130, XrefRangeEnd = 24146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<TablePair> NextKey(DynValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_NextKey_Public_Nullable_1_TablePair_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<TablePair>>(intPtr3) : null;
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00031254 File Offset: 0x0002F454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24159, RefRangeEnd = 24160, XrefRangeStart = 24147, XrefRangeEnd = 24159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<TablePair> GetNextOf(LinkedListNode<TablePair> linkedListNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linkedListNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_GetNextOf_Private_Nullable_1_TablePair_LinkedListNode_1_TablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<TablePair>>(intPtr3) : null;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000312A4 File Offset: 0x0002F4A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24167, RefRangeEnd = 24169, XrefRangeStart = 24160, XrefRangeEnd = 24167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNextArrayKeys(DynValue val, bool lastpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.NativeMethodInfoPtr_InitNextArrayKeys_Internal_Void_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00003B39 File Offset: 0x00001D39
		public Object get_Item(params Object[] keys)
		{
			return this[new Il2CppReferenceArray<Object>(keys)];
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00003B47 File Offset: 0x00001D47
		public void set_Item(params Object[] keys, Object value)
		{
			this[new Il2CppReferenceArray<Object>(keys)] = value;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00003B56 File Offset: 0x00001D56
		public Table(Script owner, params DynValue[] arrayValues)
			: this(owner, new Il2CppReferenceArray<DynValue>(arrayValues))
		{
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00003B65 File Offset: 0x00001D65
		public DynValue Get(params Object[] keys)
		{
			return this.Get(new Il2CppReferenceArray<Object>(keys));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00003B73 File Offset: 0x00001D73
		public DynValue RawGet(params Object[] keys)
		{
			return this.RawGet(new Il2CppReferenceArray<Object>(keys));
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00003B81 File Offset: 0x00001D81
		public bool Remove(params Object[] keys)
		{
			return this.Remove(new Il2CppReferenceArray<Object>(keys));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00003B8F File Offset: 0x00001D8F
		public Table(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000312F4 File Offset: 0x0002F4F4
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00003B98 File Offset: 0x00001D98
		public unsafe LinkedList<TablePair> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<TablePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00031324 File Offset: 0x0002F524
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public unsafe LinkedListIndex<DynValue, TablePair> m_ValueMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ValueMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListIndex<DynValue, TablePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ValueMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00031354 File Offset: 0x0002F554
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00003BD6 File Offset: 0x00001DD6
		public unsafe LinkedListIndex<string, TablePair> m_StringMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_StringMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListIndex<string, TablePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_StringMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00031384 File Offset: 0x0002F584
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public unsafe LinkedListIndex<int, TablePair> m_ArrayMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ArrayMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListIndex<int, TablePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ArrayMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x000313B4 File Offset: 0x0002F5B4
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00003C14 File Offset: 0x00001E14
		public unsafe Script m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_Owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_Owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000313E4 File Offset: 0x0002F5E4
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00003C33 File Offset: 0x00001E33
		public unsafe int m_InitArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_InitArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_InitArray)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0003140C File Offset: 0x0002F60C
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00003C4E File Offset: 0x00001E4E
		public unsafe int m_CachedLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_CachedLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_CachedLength)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00031434 File Offset: 0x0002F634
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00003C69 File Offset: 0x00001E69
		public unsafe bool m_ContainsNilEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ContainsNilEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_ContainsNilEntries)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0003145C File Offset: 0x0002F65C
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00003C84 File Offset: 0x00001E84
		public unsafe Table m_MetaTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_MetaTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Table.NativeFieldInfoPtr_m_MetaTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueMap;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_m_StringMap;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrayMap;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_m_InitArray;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLength;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainsNilEntries;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_m_MetaTable;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Object_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Object_Object_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_Pairs_Public_get_IEnumerable_1_TablePair_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_DynValue_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_IEnumerable_1_DynValue_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_GetIntegralKey_Private_Int32_Double_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_ResolveMultipleKeys_Private_Table_Il2CppReferenceArray_1_Object_byref_Object_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_DynValue_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_PerformTableSet_Private_Void_LinkedListIndex_2_T_TablePair_T_DynValue_DynValue_Boolean_Int32_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_DynValue_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_DynValue_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_DynValue_DynValue_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Object_DynValue_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_Object_DynValue_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DynValue_String_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DynValue_Int32_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DynValue_DynValue_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DynValue_Object_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_RawGetValue_Private_Static_DynValue_LinkedListNode_1_TablePair_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_String_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_DynValue_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_Object_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_PerformTableRemove_Private_Boolean_LinkedListIndex_2_T_TablePair_T_Boolean_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_String_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_Int32_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_DynValue_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_Object_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_CollectDeadKeys_Public_Void_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_NextKey_Public_Nullable_1_TablePair_DynValue_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_GetNextOf_Private_Nullable_1_TablePair_LinkedListNode_1_TablePair_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_InitNextArrayKeys_Internal_Void_DynValue_Boolean_0;

		// Token: 0x0200018A RID: 394
		[ObfuscatedName("MoonSharp.Interpreter.Table+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A0C RID: 6668 RVA: 0x00080290 File Offset: 0x0007E490
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Table.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Table>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Table.__c>.NativeClassPtr);
				Table.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, "<>9");
				Table.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, "<>9__56_0");
				Table.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, "<>9__58_0");
				Table.__c.NativeFieldInfoPtr___9__60_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, "<>9__60_0");
				Table.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, 100664690);
				Table.__c.NativeMethodInfoPtr__get_Pairs_b__56_0_Internal_TablePair_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, 100664691);
				Table.__c.NativeMethodInfoPtr__get_Keys_b__58_0_Internal_DynValue_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, 100664692);
				Table.__c.NativeMethodInfoPtr__get_Values_b__60_0_Internal_DynValue_TablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Table.__c>.NativeClassPtr, 100664693);
			}

			// Token: 0x06001A0D RID: 6669 RVA: 0x0008035C File Offset: 0x0007E55C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Table.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A0E RID: 6670 RVA: 0x00080398 File Offset: 0x0007E598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23510, XrefRangeEnd = 23515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TablePair _get_Pairs_b__56_0(TablePair n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.__c.NativeMethodInfoPtr__get_Pairs_b__56_0_Internal_TablePair_TablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TablePair>(intPtr3) : null;
				}
			}

			// Token: 0x06001A0F RID: 6671 RVA: 0x000803E8 File Offset: 0x0007E5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23515, XrefRangeEnd = 23518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _get_Keys_b__58_0(TablePair n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.__c.NativeMethodInfoPtr__get_Keys_b__58_0_Internal_DynValue_TablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001A10 RID: 6672 RVA: 0x00080438 File Offset: 0x0007E638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23518, XrefRangeEnd = 23521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _get_Values_b__60_0(TablePair n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Table.__c.NativeMethodInfoPtr__get_Values_b__60_0_Internal_DynValue_TablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001A11 RID: 6673 RVA: 0x0000A4C6 File Offset: 0x000086C6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00080488 File Offset: 0x0007E688
			// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0000A4CF File Offset: 0x000086CF
			public unsafe static Table.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Table.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Table.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000804B0 File Offset: 0x0007E6B0
			// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0000A4E1 File Offset: 0x000086E1
			public unsafe static Func<TablePair, TablePair> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Table.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TablePair, TablePair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Table.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06001A16 RID: 6678 RVA: 0x000804D8 File Offset: 0x0007E6D8
			// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000A4F3 File Offset: 0x000086F3
			public unsafe static Func<TablePair, DynValue> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Table.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TablePair, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Table.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00080500 File Offset: 0x0007E700
			// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000A505 File Offset: 0x00008705
			public unsafe static Func<TablePair, DynValue> __9__60_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Table.__c.NativeFieldInfoPtr___9__60_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TablePair, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Table.__c.NativeFieldInfoPtr___9__60_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeFieldInfoPtr___9__60_0;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeMethodInfoPtr__get_Pairs_b__56_0_Internal_TablePair_TablePair_0;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeMethodInfoPtr__get_Keys_b__58_0_Internal_DynValue_TablePair_0;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeMethodInfoPtr__get_Values_b__60_0_Internal_DynValue_TablePair_0;
		}

		// Token: 0x0200018B RID: 395
		private sealed class MethodInfoStoreGeneric_PerformTableSet_Private_Void_LinkedListIndex_2_T_TablePair_T_DynValue_DynValue_Boolean_Int32_0<T>
		{
			// Token: 0x0400156D RID: 5485
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Table.NativeMethodInfoPtr_PerformTableSet_Private_Void_LinkedListIndex_2_T_TablePair_T_DynValue_DynValue_Boolean_Int32_0, Il2CppClassPointerStore<Table>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018C RID: 396
		private sealed class MethodInfoStoreGeneric_PerformTableRemove_Private_Boolean_LinkedListIndex_2_T_TablePair_T_Boolean_0<T>
		{
			// Token: 0x0400156E RID: 5486
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Table.NativeMethodInfoPtr_PerformTableRemove_Private_Boolean_LinkedListIndex_2_T_TablePair_T_Boolean_0, Il2CppClassPointerStore<Table>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
