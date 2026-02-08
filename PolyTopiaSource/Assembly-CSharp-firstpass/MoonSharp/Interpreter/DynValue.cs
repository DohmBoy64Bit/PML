using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002E RID: 46
	public sealed class DynValue : Object
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x0002D724 File Offset: 0x0002B924
		// Note: this type is marked as 'beforefieldinit'.
		static DynValue()
		{
			Il2CppClassPointerStore<DynValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "DynValue");
			DynValue.NativeFieldInfoPtr_s_RefIDCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "s_RefIDCounter");
			DynValue.NativeFieldInfoPtr_m_RefID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_RefID");
			DynValue.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_HashCode");
			DynValue.NativeFieldInfoPtr_m_ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_ReadOnly");
			DynValue.NativeFieldInfoPtr_m_Number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_Number");
			DynValue.NativeFieldInfoPtr_m_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_Object");
			DynValue.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "m_Type");
			DynValue.NativeFieldInfoPtr__Void_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "<Void>k__BackingField");
			DynValue.NativeFieldInfoPtr__Nil_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "<Nil>k__BackingField");
			DynValue.NativeFieldInfoPtr__True_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "<True>k__BackingField");
			DynValue.NativeFieldInfoPtr__False_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "<False>k__BackingField");
			DynValue.NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664534);
			DynValue.NativeMethodInfoPtr_get_Type_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664535);
			DynValue.NativeMethodInfoPtr_get_Function_Public_get_Closure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664536);
			DynValue.NativeMethodInfoPtr_get_Number_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664537);
			DynValue.NativeMethodInfoPtr_get_Tuple_Public_get_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664538);
			DynValue.NativeMethodInfoPtr_get_Coroutine_Public_get_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664539);
			DynValue.NativeMethodInfoPtr_get_Table_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664540);
			DynValue.NativeMethodInfoPtr_get_Boolean_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664541);
			DynValue.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664542);
			DynValue.NativeMethodInfoPtr_get_Callback_Public_get_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664543);
			DynValue.NativeMethodInfoPtr_get_TailCallData_Public_get_TailCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664544);
			DynValue.NativeMethodInfoPtr_get_YieldRequest_Public_get_YieldRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664545);
			DynValue.NativeMethodInfoPtr_get_UserData_Public_get_UserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664546);
			DynValue.NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664547);
			DynValue.NativeMethodInfoPtr_get_Void_Public_Static_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664573);
			DynValue.NativeMethodInfoPtr_set_Void_Private_Static_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664574);
			DynValue.NativeMethodInfoPtr_get_Nil_Public_Static_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664575);
			DynValue.NativeMethodInfoPtr_set_Nil_Private_Static_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664576);
			DynValue.NativeMethodInfoPtr_get_True_Public_Static_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664577);
			DynValue.NativeMethodInfoPtr_set_True_Private_Static_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664578);
			DynValue.NativeMethodInfoPtr_get_False_Public_Static_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664579);
			DynValue.NativeMethodInfoPtr_set_False_Private_Static_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664580);
			DynValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664606);
			DynValue.NativeMethodInfoPtr_NewNil_Public_Static_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664548);
			DynValue.NativeMethodInfoPtr_NewBoolean_Public_Static_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664549);
			DynValue.NativeMethodInfoPtr_NewNumber_Public_Static_DynValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664550);
			DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664551);
			DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664552);
			DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664553);
			DynValue.NativeMethodInfoPtr_NewCoroutine_Public_Static_DynValue_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664554);
			DynValue.NativeMethodInfoPtr_NewClosure_Public_Static_DynValue_Closure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664555);
			DynValue.NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664556);
			DynValue.NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664557);
			DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664558);
			DynValue.NativeMethodInfoPtr_NewPrimeTable_Public_Static_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664559);
			DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664560);
			DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664561);
			DynValue.NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664562);
			DynValue.NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_TailCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664563);
			DynValue.NativeMethodInfoPtr_NewYieldReq_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664564);
			DynValue.NativeMethodInfoPtr_NewForcedYieldReq_Internal_Static_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664565);
			DynValue.NativeMethodInfoPtr_NewTuple_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664566);
			DynValue.NativeMethodInfoPtr_NewTupleNested_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664567);
			DynValue.NativeMethodInfoPtr_NewUserData_Public_Static_DynValue_UserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664568);
			DynValue.NativeMethodInfoPtr_AsReadOnly_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664569);
			DynValue.NativeMethodInfoPtr_Clone_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664570);
			DynValue.NativeMethodInfoPtr_Clone_Public_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664571);
			DynValue.NativeMethodInfoPtr_CloneAsWritable_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664572);
			DynValue.NativeMethodInfoPtr_ToPrintString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664582);
			DynValue.NativeMethodInfoPtr_ToDebugPrintString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664583);
			DynValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664584);
			DynValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664585);
			DynValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664586);
			DynValue.NativeMethodInfoPtr_CastToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664587);
			DynValue.NativeMethodInfoPtr_CastToNumber_Public_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664588);
			DynValue.NativeMethodInfoPtr_CastToBool_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664589);
			DynValue.NativeMethodInfoPtr_GetAsPrivateResource_Public_IScriptPrivateResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664590);
			DynValue.NativeMethodInfoPtr_ToScalar_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664591);
			DynValue.NativeMethodInfoPtr_Assign_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664592);
			DynValue.NativeMethodInfoPtr_GetLength_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664593);
			DynValue.NativeMethodInfoPtr_IsNil_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664594);
			DynValue.NativeMethodInfoPtr_IsNotNil_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664595);
			DynValue.NativeMethodInfoPtr_IsVoid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664596);
			DynValue.NativeMethodInfoPtr_IsNotVoid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664597);
			DynValue.NativeMethodInfoPtr_IsNilOrNan_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664598);
			DynValue.NativeMethodInfoPtr_AssignNumber_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664599);
			DynValue.NativeMethodInfoPtr_FromObject_Public_Static_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664600);
			DynValue.NativeMethodInfoPtr_ToObject_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664601);
			DynValue.NativeMethodInfoPtr_ToObject_Public_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664602);
			DynValue.NativeMethodInfoPtr_ToObject_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664603);
			DynValue.NativeMethodInfoPtr_CheckType_Public_DynValue_String_DataType_Int32_TypeValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664604);
			DynValue.NativeMethodInfoPtr_CheckUserDataType_Public_T_String_Int32_TypeValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue>.NativeClassPtr, 100664605);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		public unsafe int ReferenceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0002DE04 File Offset: 0x0002C004
		public unsafe DataType Type
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Type_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002DE44 File Offset: 0x0002C044
		public unsafe Closure Function
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 21745, RefRangeEnd = 21763, XrefRangeStart = 21743, XrefRangeEnd = 21745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Function_Public_get_Closure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Closure>(intPtr3) : null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0002DE84 File Offset: 0x0002C084
		public unsafe double Number
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21763, RefRangeEnd = 21767, XrefRangeStart = 21763, XrefRangeEnd = 21763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Number_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		public unsafe Il2CppReferenceArray<DynValue> Tuple
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 21770, RefRangeEnd = 21797, XrefRangeStart = 21767, XrefRangeEnd = 21770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Tuple_Public_get_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002DF00 File Offset: 0x0002C100
		public unsafe Coroutine Coroutine
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21799, RefRangeEnd = 21810, XrefRangeStart = 21797, XrefRangeEnd = 21799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Coroutine_Public_get_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002DF40 File Offset: 0x0002C140
		public unsafe Table Table
		{
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 21812, RefRangeEnd = 21879, XrefRangeStart = 21810, XrefRangeEnd = 21812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Table_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002DF80 File Offset: 0x0002C180
		public unsafe bool Boolean
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21879, RefRangeEnd = 21882, XrefRangeStart = 21879, XrefRangeEnd = 21879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Boolean_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002DFBC File Offset: 0x0002C1BC
		public unsafe string String
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 21883, RefRangeEnd = 21958, XrefRangeStart = 21882, XrefRangeEnd = 21883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public unsafe CallbackFunction Callback
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21960, RefRangeEnd = 21964, XrefRangeStart = 21958, XrefRangeEnd = 21960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Callback_Public_get_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002E034 File Offset: 0x0002C234
		public unsafe TailCallData TailCallData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21966, RefRangeEnd = 21967, XrefRangeStart = 21964, XrefRangeEnd = 21966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_TailCallData_Public_get_TailCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TailCallData>(intPtr3) : null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002E074 File Offset: 0x0002C274
		public unsafe YieldRequest YieldRequest
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21969, RefRangeEnd = 21971, XrefRangeStart = 21967, XrefRangeEnd = 21969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_YieldRequest_Public_get_YieldRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldRequest>(intPtr3) : null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		public unsafe UserData UserData
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 21973, RefRangeEnd = 22018, XrefRangeStart = 21971, XrefRangeEnd = 21973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_UserData_Public_get_UserData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserData>(intPtr3) : null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002E0F4 File Offset: 0x0002C2F4
		public unsafe bool ReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0002E130 File Offset: 0x0002C330
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0002E164 File Offset: 0x0002C364
		public unsafe static DynValue Void
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22018, XrefRangeEnd = 22022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Void_Public_Static_get_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22022, XrefRangeEnd = 22028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_set_Void_Private_Static_set_Void_DynValue_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0002E19C File Offset: 0x0002C39C
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public unsafe static DynValue Nil
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22028, XrefRangeEnd = 22032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_Nil_Public_Static_get_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22032, XrefRangeEnd = 22038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_set_Nil_Private_Static_set_Void_DynValue_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0002E208 File Offset: 0x0002C408
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0002E23C File Offset: 0x0002C43C
		public unsafe static DynValue True
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22038, XrefRangeEnd = 22042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_True_Public_Static_get_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22042, XrefRangeEnd = 22048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_set_True_Private_Static_set_Void_DynValue_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002E274 File Offset: 0x0002C474
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		public unsafe static DynValue False
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22048, XrefRangeEnd = 22052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_get_False_Public_Static_get_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22052, XrefRangeEnd = 22058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_set_False_Private_Static_set_Void_DynValue_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002E2E0 File Offset: 0x0002C4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22063, RefRangeEnd = 22064, XrefRangeStart = 22058, XrefRangeEnd = 22063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002E31C File Offset: 0x0002C51C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 22072, RefRangeEnd = 22077, XrefRangeStart = 22064, XrefRangeEnd = 22072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewNil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewNil_Public_Static_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002E350 File Offset: 0x0002C550
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 22085, RefRangeEnd = 22139, XrefRangeStart = 22077, XrefRangeEnd = 22085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewBoolean(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewBoolean_Public_Static_DynValue_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0002E390 File Offset: 0x0002C590
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 22147, RefRangeEnd = 22230, XrefRangeStart = 22139, XrefRangeEnd = 22147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewNumber(double num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewNumber_Public_Static_DynValue_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		[CallerCount(103)]
		[CachedScanResults(RefRangeStart = 22239, RefRangeEnd = 22342, XrefRangeStart = 22230, XrefRangeEnd = 22239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0002E414 File Offset: 0x0002C614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22342, XrefRangeEnd = 22351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewString(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002E458 File Offset: 0x0002C658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22365, RefRangeEnd = 22367, XrefRangeStart = 22351, XrefRangeEnd = 22365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewString(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002E4BC File Offset: 0x0002C6BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 22376, RefRangeEnd = 22380, XrefRangeStart = 22367, XrefRangeEnd = 22376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewCoroutine(Coroutine coroutine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewCoroutine_Public_Static_DynValue_Coroutine_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002E500 File Offset: 0x0002C700
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 22389, RefRangeEnd = 22393, XrefRangeStart = 22380, XrefRangeEnd = 22389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewClosure(Closure function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewClosure_Public_Static_DynValue_Closure_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002E544 File Offset: 0x0002C744
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 22410, RefRangeEnd = 22426, XrefRangeStart = 22393, XrefRangeEnd = 22410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0002E59C File Offset: 0x0002C79C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 22435, RefRangeEnd = 22440, XrefRangeStart = 22426, XrefRangeEnd = 22435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewCallback(CallbackFunction function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_CallbackFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 22449, RefRangeEnd = 22468, XrefRangeStart = 22440, XrefRangeEnd = 22449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTable(Table table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002E624 File Offset: 0x0002C824
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 22476, RefRangeEnd = 22492, XrefRangeStart = 22468, XrefRangeEnd = 22476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewPrimeTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewPrimeTable_Public_Static_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002E658 File Offset: 0x0002C858
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 22500, RefRangeEnd = 22505, XrefRangeStart = 22492, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTable(Script script)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0002E69C File Offset: 0x0002C89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22505, XrefRangeEnd = 22520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTable(Script script, [Optional] Il2CppReferenceArray<DynValue> arrayValues)
		{
			if (arrayValues == null)
			{
				arrayValues = new Il2CppReferenceArray<DynValue>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0002E700 File Offset: 0x0002C900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22535, RefRangeEnd = 22536, XrefRangeStart = 22520, XrefRangeEnd = 22535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTailCallReq(DynValue tailFn, [Optional] Il2CppReferenceArray<DynValue> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<DynValue>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tailFn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002E764 File Offset: 0x0002C964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22545, RefRangeEnd = 22546, XrefRangeStart = 22536, XrefRangeEnd = 22545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTailCallReq(TailCallData tailCallData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tailCallData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_TailCallData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002E7A8 File Offset: 0x0002C9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22560, RefRangeEnd = 22561, XrefRangeStart = 22546, XrefRangeEnd = 22560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewYieldReq(Il2CppReferenceArray<DynValue> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewYieldReq_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0002E7EC File Offset: 0x0002C9EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22574, RefRangeEnd = 22575, XrefRangeStart = 22561, XrefRangeEnd = 22574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewForcedYieldReq()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewForcedYieldReq_Internal_Static_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0002E820 File Offset: 0x0002CA20
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 22580, RefRangeEnd = 22614, XrefRangeStart = 22575, XrefRangeEnd = 22580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTuple([Optional] Il2CppReferenceArray<DynValue> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<DynValue>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTuple_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002E874 File Offset: 0x0002CA74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 22659, RefRangeEnd = 22663, XrefRangeStart = 22614, XrefRangeEnd = 22659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewTupleNested([Optional] Il2CppReferenceArray<DynValue> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<DynValue>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewTupleNested_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 22672, RefRangeEnd = 22676, XrefRangeStart = 22663, XrefRangeEnd = 22672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue NewUserData(UserData userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_NewUserData_Public_Static_DynValue_UserData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002E90C File Offset: 0x0002CB0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 22677, RefRangeEnd = 22684, XrefRangeStart = 22676, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue AsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_AsReadOnly_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22684, XrefRangeEnd = 22685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_Clone_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0002E98C File Offset: 0x0002CB8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22694, RefRangeEnd = 22697, XrefRangeStart = 22685, XrefRangeEnd = 22694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Clone(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_Clone_Public_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22698, RefRangeEnd = 22701, XrefRangeStart = 22697, XrefRangeEnd = 22698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CloneAsWritable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_CloneAsWritable_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002EA18 File Offset: 0x0002CC18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 22719, RefRangeEnd = 22726, XrefRangeStart = 22701, XrefRangeEnd = 22719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToPrintString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToPrintString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002EA50 File Offset: 0x0002CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22726, XrefRangeEnd = 22765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToDebugPrintString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToDebugPrintString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002EA88 File Offset: 0x0002CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22765, XrefRangeEnd = 22868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002EAC0 File Offset: 0x0002CCC0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22868, XrefRangeEnd = 22872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002EB4C File Offset: 0x0002CD4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 22874, RefRangeEnd = 22883, XrefRangeStart = 22872, XrefRangeEnd = 22874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CastToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_CastToString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002EB84 File Offset: 0x0002CD84
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 22892, RefRangeEnd = 22910, XrefRangeStart = 22883, XrefRangeEnd = 22892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<double> CastToNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_CastToNumber_Public_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<double>>(intPtr3) : null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002EBC4 File Offset: 0x0002CDC4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 22911, RefRangeEnd = 22926, XrefRangeStart = 22910, XrefRangeEnd = 22911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CastToBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_CastToBool_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002EC00 File Offset: 0x0002CE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22926, XrefRangeEnd = 22929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IScriptPrivateResource GetAsPrivateResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_GetAsPrivateResource_Public_IScriptPrivateResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptPrivateResource>(intPtr3) : null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002EC40 File Offset: 0x0002CE40
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 22943, RefRangeEnd = 22995, XrefRangeStart = 22929, XrefRangeEnd = 22943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue ToScalar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToScalar_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002EC80 File Offset: 0x0002CE80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22996, RefRangeEnd = 22999, XrefRangeStart = 22995, XrefRangeEnd = 22996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Assign(DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_Assign_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23022, RefRangeEnd = 23023, XrefRangeStart = 22999, XrefRangeEnd = 23022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_GetLength_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002ED04 File Offset: 0x0002CF04
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 23023, RefRangeEnd = 23082, XrefRangeStart = 23023, XrefRangeEnd = 23023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_IsNil_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002ED40 File Offset: 0x0002CF40
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 23082, RefRangeEnd = 23092, XrefRangeStart = 23082, XrefRangeEnd = 23082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNotNil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_IsNotNil_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23092, RefRangeEnd = 23096, XrefRangeStart = 23092, XrefRangeEnd = 23092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_IsVoid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		[CallerCount(0)]
		public unsafe bool IsNotVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_IsNotVoid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 23096, RefRangeEnd = 23106, XrefRangeStart = 23096, XrefRangeEnd = 23096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNilOrNan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_IsNilOrNan_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002EE30 File Offset: 0x0002D030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23106, RefRangeEnd = 23107, XrefRangeStart = 23106, XrefRangeEnd = 23106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNumber(double num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_AssignNumber_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002EE70 File Offset: 0x0002D070
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23108, RefRangeEnd = 23112, XrefRangeStart = 23107, XrefRangeEnd = 23108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue FromObject(Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_FromObject_Public_Static_DynValue_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002EEC8 File Offset: 0x0002D0C8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 23113, RefRangeEnd = 23123, XrefRangeStart = 23112, XrefRangeEnd = 23113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ToObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToObject_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002EF08 File Offset: 0x0002D108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23123, XrefRangeEnd = 23124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ToObject(Type desiredType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_ToObject_Public_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002EF58 File Offset: 0x0002D158
		[CallerCount(0)]
		public unsafe T ToObject<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.MethodInfoStoreGeneric_ToObject_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002EF94 File Offset: 0x0002D194
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 23144, RefRangeEnd = 23158, XrefRangeStart = 23124, XrefRangeEnd = 23144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CheckType(string funcName, DataType desiredType, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.NativeMethodInfoPtr_CheckType_Public_DynValue_String_DataType_Int32_TypeValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002F018 File Offset: 0x0002D218
		[CallerCount(0)]
		public unsafe T CheckUserDataType<T>(string funcName, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.MethodInfoStoreGeneric_CheckUserDataType_Public_T_String_Int32_TypeValidationFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00003886 File Offset: 0x00001A86
		public static DynValue NewString(string format, params Object[] args)
		{
			return DynValue.NewString(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00003894 File Offset: 0x00001A94
		public static DynValue NewTable(Script script, params DynValue[] arrayValues)
		{
			return DynValue.NewTable(script, new Il2CppReferenceArray<DynValue>(arrayValues));
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000038A2 File Offset: 0x00001AA2
		public static DynValue NewTailCallReq(DynValue tailFn, params DynValue[] args)
		{
			return DynValue.NewTailCallReq(tailFn, new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000038B0 File Offset: 0x00001AB0
		public static DynValue NewTuple(params DynValue[] values)
		{
			return DynValue.NewTuple(new Il2CppReferenceArray<DynValue>(values));
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000038BD File Offset: 0x00001ABD
		public static DynValue NewTupleNested(params DynValue[] values)
		{
			return DynValue.NewTupleNested(new Il2CppReferenceArray<DynValue>(values));
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000038CA File Offset: 0x00001ACA
		public DynValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0002F084 File Offset: 0x0002D284
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x000038D3 File Offset: 0x00001AD3
		public unsafe static int s_RefIDCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DynValue.NativeFieldInfoPtr_s_RefIDCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynValue.NativeFieldInfoPtr_s_RefIDCounter, (void*)(&value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x000038E1 File Offset: 0x00001AE1
		public unsafe int m_RefID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_RefID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_RefID)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0002F0C8 File Offset: 0x0002D2C8
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x000038FC File Offset: 0x00001AFC
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00003917 File Offset: 0x00001B17
		public unsafe bool m_ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_ReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_ReadOnly)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0002F118 File Offset: 0x0002D318
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00003932 File Offset: 0x00001B32
		public unsafe double m_Number
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Number);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Number)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002F140 File Offset: 0x0002D340
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x0000394D File Offset: 0x00001B4D
		public unsafe Object m_Object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002F170 File Offset: 0x0002D370
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0000396C File Offset: 0x00001B6C
		public unsafe DataType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValue.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0002F1A0 File Offset: 0x0002D3A0
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0000398B File Offset: 0x00001B8B
		public unsafe static DynValue _Void_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynValue.NativeFieldInfoPtr__Void_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynValue.NativeFieldInfoPtr__Void_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002F1C8 File Offset: 0x0002D3C8
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0000399D File Offset: 0x00001B9D
		public unsafe static DynValue _Nil_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynValue.NativeFieldInfoPtr__Nil_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynValue.NativeFieldInfoPtr__Nil_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000039AF File Offset: 0x00001BAF
		public unsafe static DynValue _True_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynValue.NativeFieldInfoPtr__True_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynValue.NativeFieldInfoPtr__True_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0002F218 File Offset: 0x0002D418
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000039C1 File Offset: 0x00001BC1
		public unsafe static DynValue _False_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynValue.NativeFieldInfoPtr__False_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynValue.NativeFieldInfoPtr__False_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_s_RefIDCounter;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_m_RefID;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnly;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_m_Number;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_m_Object;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr__Void_k__BackingField;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr__Nil_k__BackingField;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr__True_k__BackingField;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr__False_k__BackingField;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_DataType_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_Function_Public_get_Closure_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_get_Number_Public_get_Double_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_get_Tuple_Public_get_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_get_Coroutine_Public_get_Coroutine_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_Table_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_get_Boolean_Public_get_Boolean_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_get_Callback_Public_get_CallbackFunction_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_get_TailCallData_Public_get_TailCallData_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_get_YieldRequest_Public_get_YieldRequest_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_UserData_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_get_Void_Public_Static_get_DynValue_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_set_Void_Private_Static_set_Void_DynValue_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_Nil_Public_Static_get_DynValue_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_set_Nil_Private_Static_set_Void_DynValue_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_get_True_Public_Static_get_DynValue_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_set_True_Private_Static_set_Void_DynValue_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_get_False_Public_Static_get_DynValue_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_set_False_Private_Static_set_Void_DynValue_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_NewNil_Public_Static_DynValue_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_NewBoolean_Public_Static_DynValue_Boolean_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_NewNumber_Public_Static_DynValue_Double_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_DynValue_StringBuilder_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_DynValue_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_NewCoroutine_Public_Static_DynValue_Coroutine_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_NewClosure_Public_Static_DynValue_Closure_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_NewCallback_Public_Static_DynValue_CallbackFunction_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Table_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_NewPrimeTable_Public_Static_DynValue_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_NewTable_Public_Static_DynValue_Script_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_NewTailCallReq_Public_Static_DynValue_TailCallData_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_NewYieldReq_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_NewForcedYieldReq_Internal_Static_DynValue_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_NewTuple_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_NewTupleNested_Public_Static_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_NewUserData_Public_Static_DynValue_UserData_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_DynValue_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_DynValue_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_DynValue_Boolean_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_CloneAsWritable_Public_DynValue_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_ToPrintString_Public_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_ToDebugPrintString_Public_String_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_CastToString_Public_String_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_CastToNumber_Public_Nullable_1_Double_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_CastToBool_Public_Boolean_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GetAsPrivateResource_Public_IScriptPrivateResource_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_ToScalar_Public_DynValue_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_DynValue_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_DynValue_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_IsNil_Public_Boolean_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNil_Public_Boolean_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_IsVoid_Public_Boolean_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_IsNotVoid_Public_Boolean_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_IsNilOrNan_Public_Boolean_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_AssignNumber_Internal_Void_Double_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_DynValue_Script_Object_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Object_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Object_Type_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_T_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_CheckType_Public_DynValue_String_DataType_Int32_TypeValidationFlags_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_CheckUserDataType_Public_T_String_Int32_TypeValidationFlags_0;

		// Token: 0x02000187 RID: 391
		[ObfuscatedName("MoonSharp.Interpreter.DynValue+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060019F6 RID: 6646 RVA: 0x0007FE30 File Offset: 0x0007E030
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynValue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr);
				DynValue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9");
				DynValue.__c.NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9__54_0");
				DynValue.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9__77_0");
				DynValue.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9__78_0");
				DynValue.__c.NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9__79_0");
				DynValue.__c.NativeFieldInfoPtr___9__79_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, "<>9__79_1");
				DynValue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664608);
				DynValue.__c.NativeMethodInfoPtr__NewTupleNested_b__54_0_Internal_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664609);
				DynValue.__c.NativeMethodInfoPtr__ToPrintString_b__77_0_Internal_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664610);
				DynValue.__c.NativeMethodInfoPtr__ToDebugPrintString_b__78_0_Internal_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664611);
				DynValue.__c.NativeMethodInfoPtr__ToString_b__79_0_Internal_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664612);
				DynValue.__c.NativeMethodInfoPtr__ToString_b__79_1_Internal_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr, 100664613);
			}

			// Token: 0x060019F7 RID: 6647 RVA: 0x0007FF4C File Offset: 0x0007E14C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynValue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019F8 RID: 6648 RVA: 0x0007FF88 File Offset: 0x0007E188
			[CallerCount(0)]
			public unsafe bool _NewTupleNested_b__54_0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__NewTupleNested_b__54_0_Internal_Boolean_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019F9 RID: 6649 RVA: 0x0007FFD8 File Offset: 0x0007E1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21734, XrefRangeEnd = 21736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToPrintString_b__77_0(DynValue t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__ToPrintString_b__77_0_Internal_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060019FA RID: 6650 RVA: 0x00080020 File Offset: 0x0007E220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToDebugPrintString_b__78_0(DynValue t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__ToDebugPrintString_b__78_0_Internal_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x00080068 File Offset: 0x0007E268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21736, XrefRangeEnd = 21737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__79_0(DynValue t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__ToString_b__79_0_Internal_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x000800B0 File Offset: 0x0007E2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__79_1(DynValue t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValue.__c.NativeMethodInfoPtr__ToString_b__79_1_Internal_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x0000A451 File Offset: 0x00008651
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x060019FE RID: 6654 RVA: 0x000800F8 File Offset: 0x0007E2F8
			// (set) Token: 0x060019FF RID: 6655 RVA: 0x0000A45A File Offset: 0x0000865A
			public unsafe static DynValue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00080120 File Offset: 0x0007E320
			// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0000A46C File Offset: 0x0000866C
			public unsafe static Func<DynValue, bool> __9__54_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9__54_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00080148 File Offset: 0x0007E348
			// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000A47E File Offset: 0x0000867E
			public unsafe static Func<DynValue, string> __9__77_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00080170 File Offset: 0x0007E370
			// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0000A490 File Offset: 0x00008690
			public unsafe static Func<DynValue, string> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00080198 File Offset: 0x0007E398
			// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0000A4A2 File Offset: 0x000086A2
			public unsafe static Func<DynValue, string> __9__79_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9__79_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9__79_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001A08 RID: 6664 RVA: 0x000801C0 File Offset: 0x0007E3C0
			// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0000A4B4 File Offset: 0x000086B4
			public unsafe static Func<DynValue, string> __9__79_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynValue.__c.NativeFieldInfoPtr___9__79_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynValue.__c.NativeFieldInfoPtr___9__79_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeFieldInfoPtr___9__54_0;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeFieldInfoPtr___9__79_0;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr___9__79_1;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeMethodInfoPtr__NewTupleNested_b__54_0_Internal_Boolean_DynValue_0;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeMethodInfoPtr__ToPrintString_b__77_0_Internal_String_DynValue_0;

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeMethodInfoPtr__ToDebugPrintString_b__78_0_Internal_String_DynValue_0;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__79_0_Internal_String_DynValue_0;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__79_1_Internal_String_DynValue_0;
		}

		// Token: 0x02000188 RID: 392
		private sealed class MethodInfoStoreGeneric_ToObject_Public_T_0<T>
		{
			// Token: 0x04001563 RID: 5475
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynValue.NativeMethodInfoPtr_ToObject_Public_T_0, Il2CppClassPointerStore<DynValue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000189 RID: 393
		private sealed class MethodInfoStoreGeneric_CheckUserDataType_Public_T_String_Int32_TypeValidationFlags_0<T>
		{
			// Token: 0x04001564 RID: 5476
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynValue.NativeMethodInfoPtr_CheckUserDataType_Public_T_String_Int32_TypeValidationFlags_0, Il2CppClassPointerStore<DynValue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
