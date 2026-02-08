using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D3 RID: 211
	public static class TableConversions : Object
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x000577B8 File Offset: 0x000559B8
		// Note: this type is marked as 'beforefieldinit'.
		static TableConversions()
		{
			Il2CppClassPointerStore<TableConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.Converters", "TableConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableConversions>.NativeClassPtr);
			TableConversions.NativeMethodInfoPtr_ConvertIListToTable_Internal_Static_Table_Script_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666200);
			TableConversions.NativeMethodInfoPtr_ConvertIDictionaryToTable_Internal_Static_Table_Script_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666201);
			TableConversions.NativeMethodInfoPtr_CanConvertTableToType_Internal_Static_Boolean_Table_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666202);
			TableConversions.NativeMethodInfoPtr_ConvertTableToType_Internal_Static_Object_Table_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666203);
			TableConversions.NativeMethodInfoPtr_ConvertTableToDictionaryOfGenericType_Internal_Static_Object_Type_Type_Type_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666204);
			TableConversions.NativeMethodInfoPtr_ConvertTableToArrayOfGenericType_Internal_Static_Object_Type_Type_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666205);
			TableConversions.NativeMethodInfoPtr_ConvertTableToListOfGenericType_Internal_Static_Object_Type_Type_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666206);
			TableConversions.NativeMethodInfoPtr_TableToList_Internal_Static_List_1_T_Table_Func_2_DynValue_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666207);
			TableConversions.NativeMethodInfoPtr_TableToDictionary_Internal_Static_Dictionary_2_TK_TV_Table_Func_2_DynValue_TK_Func_2_DynValue_TV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, 100666208);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0005789C File Offset: 0x00055A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41717, XrefRangeEnd = 41734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table ConvertIListToTable(Script script, IList list)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertIListToTable_Internal_Static_Table_Script_IList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x000578F4 File Offset: 0x00055AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41734, XrefRangeEnd = 41761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table ConvertIDictionaryToTable(Script script, IDictionary dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertIDictionaryToTable_Internal_Static_Table_Script_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0005794C File Offset: 0x00055B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41761, XrefRangeEnd = 41859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertTableToType(Table table, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_CanConvertTableToType_Internal_Static_Boolean_Table_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000579A0 File Offset: 0x00055BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41859, XrefRangeEnd = 42081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertTableToType(Table table, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertTableToType_Internal_Static_Object_Table_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000579F8 File Offset: 0x00055BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42129, RefRangeEnd = 42130, XrefRangeStart = 42081, XrefRangeEnd = 42129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionaryType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertTableToDictionaryOfGenericType_Internal_Static_Object_Type_Type_Type_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00057A74 File Offset: 0x00055C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42167, RefRangeEnd = 42168, XrefRangeStart = 42130, XrefRangeEnd = 42167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertTableToArrayOfGenericType_Internal_Static_Object_Type_Type_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00057ADC File Offset: 0x00055CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42193, RefRangeEnd = 42194, XrefRangeStart = 42168, XrefRangeEnd = 42193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertTableToListOfGenericType(Type listType, Type itemType, Table table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.NativeMethodInfoPtr_ConvertTableToListOfGenericType_Internal_Static_Object_Type_Type_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00057B44 File Offset: 0x00055D44
		[CallerCount(0)]
		public unsafe static List<T> TableToList<T>(Table table, Func<DynValue, T> converter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.MethodInfoStoreGeneric_TableToList_Internal_Static_List_1_T_Table_Func_2_DynValue_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00057B9C File Offset: 0x00055D9C
		[CallerCount(0)]
		public unsafe static Dictionary<TK, TV> TableToDictionary<TK, TV>(Table table, Func<DynValue, TK> keyconverter, Func<DynValue, TV> valconverter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyconverter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valconverter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.MethodInfoStoreGeneric_TableToDictionary_Internal_Static_Dictionary_2_TK_TV_Table_Func_2_DynValue_TK_Func_2_DynValue_TV_0<TK, TV>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TK, TV>>(intPtr3) : null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00006DD7 File Offset: 0x00004FD7
		public TableConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIListToTable_Internal_Static_Table_Script_IList_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIDictionaryToTable_Internal_Static_Table_Script_IDictionary_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTableToType_Internal_Static_Boolean_Table_Type_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTableToType_Internal_Static_Object_Table_Type_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTableToDictionaryOfGenericType_Internal_Static_Object_Type_Type_Type_Table_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTableToArrayOfGenericType_Internal_Static_Object_Type_Type_Table_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTableToListOfGenericType_Internal_Static_Object_Type_Type_Table_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_TableToList_Internal_Static_List_1_T_Table_Func_2_DynValue_T_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_TableToDictionary_Internal_Static_Dictionary_2_TK_TV_Table_Func_2_DynValue_TK_Func_2_DynValue_TV_0;

		// Token: 0x020001D7 RID: 471
		[ObfuscatedName("MoonSharp.Interpreter.Interop.Converters.TableConversions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C99 RID: 7321 RVA: 0x0008A16C File Offset: 0x0008836C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TableConversions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr);
				TableConversions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9");
				TableConversions.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_0");
				TableConversions.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_1");
				TableConversions.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_2");
				TableConversions.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_3");
				TableConversions.__c.NativeFieldInfoPtr___9__3_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_4");
				TableConversions.__c.NativeFieldInfoPtr___9__3_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_5");
				TableConversions.__c.NativeFieldInfoPtr___9__3_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_6");
				TableConversions.__c.NativeFieldInfoPtr___9__3_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, "<>9__3_7");
				TableConversions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666210);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_0_Internal_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666211);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_1_Internal_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666212);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_2_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666213);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_3_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666214);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_4_Internal_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666215);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_5_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666216);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_6_Internal_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666217);
				TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_7_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr, 100666218);
			}

			// Token: 0x06001C9A RID: 7322 RVA: 0x0008A300 File Offset: 0x00088500
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableConversions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9B RID: 7323 RVA: 0x0008A33C File Offset: 0x0008853C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41715, XrefRangeEnd = 41717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _ConvertTableToType_b__3_0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_0_Internal_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9C RID: 7324 RVA: 0x0008A38C File Offset: 0x0008858C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _ConvertTableToType_b__3_1(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_1_Internal_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9D RID: 7325 RVA: 0x0008A3DC File Offset: 0x000885DC
			[CallerCount(0)]
			public unsafe DynValue _ConvertTableToType_b__3_2(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_2_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9E RID: 7326 RVA: 0x0008A42C File Offset: 0x0008862C
			[CallerCount(0)]
			public unsafe DynValue _ConvertTableToType_b__3_3(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_3_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9F RID: 7327 RVA: 0x0008A47C File Offset: 0x0008867C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _ConvertTableToType_b__3_4(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_4_Internal_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA0 RID: 7328 RVA: 0x0008A4CC File Offset: 0x000886CC
			[CallerCount(0)]
			public unsafe DynValue _ConvertTableToType_b__3_5(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_5_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA1 RID: 7329 RVA: 0x0008A51C File Offset: 0x0008871C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _ConvertTableToType_b__3_6(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_6_Internal_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA2 RID: 7330 RVA: 0x0008A56C File Offset: 0x0008876C
			[CallerCount(0)]
			public unsafe DynValue _ConvertTableToType_b__3_7(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConversions.__c.NativeMethodInfoPtr__ConvertTableToType_b__3_7_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA3 RID: 7331 RVA: 0x0000B44C File Offset: 0x0000964C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0008A5BC File Offset: 0x000887BC
			// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000B455 File Offset: 0x00009655
			public unsafe static TableConversions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TableConversions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0008A5E4 File Offset: 0x000887E4
			// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000B467 File Offset: 0x00009667
			public unsafe static Func<DynValue, Object> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0008A60C File Offset: 0x0008880C
			// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0000B479 File Offset: 0x00009679
			public unsafe static Func<DynValue, Object> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0008A634 File Offset: 0x00088834
			// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000B48B File Offset: 0x0000968B
			public unsafe static Func<DynValue, DynValue> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0008A65C File Offset: 0x0008885C
			// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000B49D File Offset: 0x0000969D
			public unsafe static Func<DynValue, DynValue> __9__3_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0008A684 File Offset: 0x00088884
			// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000B4AF File Offset: 0x000096AF
			public unsafe static Func<DynValue, Object> __9__3_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0008A6AC File Offset: 0x000888AC
			// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000B4C1 File Offset: 0x000096C1
			public unsafe static Func<DynValue, DynValue> __9__3_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0008A6D4 File Offset: 0x000888D4
			// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000B4D3 File Offset: 0x000096D3
			public unsafe static Func<DynValue, Object> __9__3_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0008A6FC File Offset: 0x000888FC
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000B4E5 File Offset: 0x000096E5
			public unsafe static Func<DynValue, DynValue> __9__3_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TableConversions.__c.NativeFieldInfoPtr___9__3_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TableConversions.__c.NativeFieldInfoPtr___9__3_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeFieldInfoPtr___9__3_4;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeFieldInfoPtr___9__3_5;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeFieldInfoPtr___9__3_6;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeFieldInfoPtr___9__3_7;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_0_Internal_Object_DynValue_0;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_1_Internal_Object_DynValue_0;

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_2_Internal_DynValue_DynValue_0;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_3_Internal_DynValue_DynValue_0;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_4_Internal_Object_DynValue_0;

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_5_Internal_DynValue_DynValue_0;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_6_Internal_Object_DynValue_0;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTableToType_b__3_7_Internal_DynValue_DynValue_0;
		}

		// Token: 0x020001D8 RID: 472
		private sealed class MethodInfoStoreGeneric_TableToList_Internal_Static_List_1_T_Table_Func_2_DynValue_T_0<T>
		{
			// Token: 0x040016FF RID: 5887
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableConversions.NativeMethodInfoPtr_TableToList_Internal_Static_List_1_T_Table_Func_2_DynValue_T_0, Il2CppClassPointerStore<TableConversions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D9 RID: 473
		private sealed class MethodInfoStoreGeneric_TableToDictionary_Internal_Static_Dictionary_2_TK_TV_Table_Func_2_DynValue_TK_Func_2_DynValue_TV_0<TK, TV>
		{
			// Token: 0x04001700 RID: 5888
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableConversions.NativeMethodInfoPtr_TableToDictionary_Internal_Static_Dictionary_2_TK_TV_Table_Func_2_DynValue_TK_Func_2_DynValue_TV_0, Il2CppClassPointerStore<TableConversions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TK>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TV>.NativeClassPtr))
			}))));
		}
	}
}
