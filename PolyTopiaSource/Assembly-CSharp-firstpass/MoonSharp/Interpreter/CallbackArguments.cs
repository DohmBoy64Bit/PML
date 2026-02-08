using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000027 RID: 39
	public class CallbackArguments : Object
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x0002B788 File Offset: 0x00029988
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackArguments()
		{
			Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "CallbackArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr);
			CallbackArguments.NativeFieldInfoPtr_m_Args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, "m_Args");
			CallbackArguments.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, "m_Count");
			CallbackArguments.NativeFieldInfoPtr_m_LastIsTuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, "m_LastIsTuple");
			CallbackArguments.NativeFieldInfoPtr__IsMethodCall_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, "<IsMethodCall>k__BackingField");
			CallbackArguments.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664430);
			CallbackArguments.NativeMethodInfoPtr_get_IsMethodCall_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664431);
			CallbackArguments.NativeMethodInfoPtr_set_IsMethodCall_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664432);
			CallbackArguments.NativeMethodInfoPtr_get_Item_Public_get_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664433);
			CallbackArguments.NativeMethodInfoPtr__ctor_Public_Void_IList_1_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664429);
			CallbackArguments.NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664434);
			CallbackArguments.NativeMethodInfoPtr_GetArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664435);
			CallbackArguments.NativeMethodInfoPtr_AsType_Public_DynValue_Int32_String_DataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664436);
			CallbackArguments.NativeMethodInfoPtr_AsUserData_Public_T_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664437);
			CallbackArguments.NativeMethodInfoPtr_AsInt_Public_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664438);
			CallbackArguments.NativeMethodInfoPtr_AsLong_Public_Int64_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664439);
			CallbackArguments.NativeMethodInfoPtr_AsStringUsingMeta_Public_String_ScriptExecutionContext_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664440);
			CallbackArguments.NativeMethodInfoPtr_SkipMethodCall_Public_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr, 100664441);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0002B90C File Offset: 0x00029B0C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0002B948 File Offset: 0x00029B48
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0002B984 File Offset: 0x00029B84
		public unsafe bool IsMethodCall
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_get_IsMethodCall_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_set_IsMethodCall_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014B RID: 331
		public unsafe DynValue this[int index]
		{
			[CallerCount(113)]
			[CachedScanResults(RefRangeStart = 20863, RefRangeEnd = 20976, XrefRangeStart = 20855, XrefRangeEnd = 20863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_get_Item_Public_get_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0002BA10 File Offset: 0x00029C10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20997, RefRangeEnd = 21001, XrefRangeStart = 20976, XrefRangeEnd = 20997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackArguments(IList<DynValue> args, bool isMethodCall)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMethodCall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr__ctor_Public_Void_IList_1_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0002BA6C File Offset: 0x00029C6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 21031, RefRangeEnd = 21038, XrefRangeStart = 21001, XrefRangeEnd = 21031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RawGet(int index, bool translateVoids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translateVoids;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002BAC8 File Offset: 0x00029CC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 21043, RefRangeEnd = 21049, XrefRangeStart = 21038, XrefRangeEnd = 21043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DynValue> GetArray(int skip = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_GetArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002BB14 File Offset: 0x00029D14
		[CallerCount(145)]
		[CachedScanResults(RefRangeStart = 21052, RefRangeEnd = 21197, XrefRangeStart = 21049, XrefRangeEnd = 21052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_AsType_Public_DynValue_Int32_String_DataType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0002BB94 File Offset: 0x00029D94
		[CallerCount(0)]
		public unsafe T AsUserData<T>(int argNum, string funcName, bool allowNil = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.MethodInfoStoreGeneric_AsUserData_Public_T_Int32_String_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0002BBFC File Offset: 0x00029DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21199, RefRangeEnd = 21202, XrefRangeStart = 21197, XrefRangeEnd = 21199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AsInt(int argNum, string funcName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_AsInt_Public_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002BC58 File Offset: 0x00029E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21202, XrefRangeEnd = 21204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long AsLong(int argNum, string funcName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_AsLong_Public_Int64_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21265, RefRangeEnd = 21267, XrefRangeStart = 21204, XrefRangeEnd = 21265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_AsStringUsingMeta_Public_String_ScriptExecutionContext_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0002BD1C File Offset: 0x00029F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21271, RefRangeEnd = 21273, XrefRangeStart = 21267, XrefRangeEnd = 21271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackArguments SkipMethodCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackArguments.NativeMethodInfoPtr_SkipMethodCall_Public_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackArguments>(intPtr3) : null;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000361D File Offset: 0x0000181D
		public CallbackArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0002BD5C File Offset: 0x00029F5C
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00003626 File Offset: 0x00001826
		public unsafe IList<DynValue> m_Args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_Args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_Args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0002BD8C File Offset: 0x00029F8C
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003645 File Offset: 0x00001845
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003660 File Offset: 0x00001860
		public unsafe bool m_LastIsTuple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_LastIsTuple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr_m_LastIsTuple)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002BDDC File Offset: 0x00029FDC
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0000367B File Offset: 0x0000187B
		public unsafe bool _IsMethodCall_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr__IsMethodCall_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackArguments.NativeFieldInfoPtr__IsMethodCall_k__BackingField)) = value;
			}
		}

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_m_Args;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_m_LastIsTuple;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr__IsMethodCall_k__BackingField;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMethodCall_Public_get_Boolean_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMethodCall_Private_set_Void_Boolean_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DynValue_Int32_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_DynValue_Boolean_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_RawGet_Public_DynValue_Int32_Boolean_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_GetArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_AsType_Public_DynValue_Int32_String_DataType_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_AsUserData_Public_T_Int32_String_Boolean_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_AsInt_Public_Int32_Int32_String_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_AsLong_Public_Int64_Int32_String_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_AsStringUsingMeta_Public_String_ScriptExecutionContext_Int32_String_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_SkipMethodCall_Public_CallbackArguments_0;

		// Token: 0x0200017D RID: 381
		private sealed class MethodInfoStoreGeneric_AsUserData_Public_T_Int32_String_Boolean_0<T>
		{
			// Token: 0x04001517 RID: 5399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackArguments.NativeMethodInfoPtr_AsUserData_Public_T_Int32_String_Boolean_0, Il2CppClassPointerStore<CallbackArguments>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
