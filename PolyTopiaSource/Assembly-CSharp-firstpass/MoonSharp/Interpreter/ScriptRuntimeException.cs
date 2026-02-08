using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class ScriptRuntimeException : InterpreterException
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x000343B0 File Offset: 0x000325B0
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptRuntimeException()
		{
			Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptRuntimeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr);
			ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664810);
			ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664811);
			ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664812);
			ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664813);
			ScriptRuntimeException.NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_ScriptRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664814);
			ScriptRuntimeException.NativeMethodInfoPtr_ConcatOnNonString_Public_Static_ScriptRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664815);
			ScriptRuntimeException.NativeMethodInfoPtr_LenOnInvalidType_Public_Static_ScriptRuntimeException_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664816);
			ScriptRuntimeException.NativeMethodInfoPtr_CompareInvalidType_Public_Static_ScriptRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664817);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664818);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentUserData_Public_Static_ScriptRuntimeException_Int32_String_Type_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664819);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_DataType_DataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664820);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664821);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_ScriptRuntimeException_Int32_String_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664822);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_ScriptRuntimeException_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664823);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_ScriptRuntimeException_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664824);
			ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_ScriptRuntimeException_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664825);
			ScriptRuntimeException.NativeMethodInfoPtr_IndexType_Public_Static_ScriptRuntimeException_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664826);
			ScriptRuntimeException.NativeMethodInfoPtr_LoopInIndex_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664827);
			ScriptRuntimeException.NativeMethodInfoPtr_LoopInNewIndex_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664828);
			ScriptRuntimeException.NativeMethodInfoPtr_LoopInCall_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664829);
			ScriptRuntimeException.NativeMethodInfoPtr_TableIndexIsNil_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664830);
			ScriptRuntimeException.NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664831);
			ScriptRuntimeException.NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_ScriptRuntimeException_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664832);
			ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664833);
			ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664834);
			ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664835);
			ScriptRuntimeException.NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_ScriptRuntimeException_DataType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664836);
			ScriptRuntimeException.NativeMethodInfoPtr_UserDataMissingField_Public_Static_ScriptRuntimeException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664837);
			ScriptRuntimeException.NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_ScriptRuntimeException_CoroutineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664838);
			ScriptRuntimeException.NativeMethodInfoPtr_CannotYield_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664839);
			ScriptRuntimeException.NativeMethodInfoPtr_CannotYieldMain_Public_Static_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664840);
			ScriptRuntimeException.NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_ScriptRuntimeException_DataType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664841);
			ScriptRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664842);
			ScriptRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IUserDataDescriptor_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664843);
			ScriptRuntimeException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr, 100664844);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0003469C File Offset: 0x0003289C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptRuntimeException(Exception ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000346E8 File Offset: 0x000328E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptRuntimeException(ScriptRuntimeException ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_ScriptRuntimeException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00034734 File Offset: 0x00032934
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 24653, RefRangeEnd = 24672, XrefRangeStart = 24653, XrefRangeEnd = 24672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptRuntimeException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00034780 File Offset: 0x00032980
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 24673, RefRangeEnd = 24691, XrefRangeStart = 24673, XrefRangeEnd = 24691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptRuntimeException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRuntimeException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000347EC File Offset: 0x000329EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25220, XrefRangeEnd = 25233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_ScriptRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00034844 File Offset: 0x00032A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25233, XrefRangeEnd = 25245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ConcatOnNonString_Public_Static_ScriptRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0003489C File Offset: 0x00032A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25245, XrefRangeEnd = 25257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException LenOnInvalidType(DynValue r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_LenOnInvalidType_Public_Static_ScriptRuntimeException_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000348E0 File Offset: 0x00032AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25257, XrefRangeEnd = 25276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_CompareInvalidType_Public_Static_ScriptRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00034938 File Offset: 0x00032B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25293, RefRangeEnd = 25295, XrefRangeStart = 25276, XrefRangeEnd = 25293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0003499C File Offset: 0x00032B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25295, XrefRangeEnd = 25329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, Object got, bool allowNil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(got);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentUserData_Public_Static_ScriptRuntimeException_Int32_String_Type_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00034A20 File Offset: 0x00032C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25329, XrefRangeEnd = 25332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(got);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_DataType_DataType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00034AA4 File Offset: 0x00032CA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25357, RefRangeEnd = 25359, XrefRangeStart = 25332, XrefRangeEnd = 25357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expected);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(got);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00034B28 File Offset: 0x00032D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25359, XrefRangeEnd = 25377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_ScriptRuntimeException_Int32_String_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00034B8C File Offset: 0x00032D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25392, RefRangeEnd = 25394, XrefRangeStart = 25377, XrefRangeEnd = 25392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_ScriptRuntimeException_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00034BE0 File Offset: 0x00032DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25394, XrefRangeEnd = 25409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_ScriptRuntimeException_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00034C34 File Offset: 0x00032E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25424, RefRangeEnd = 25425, XrefRangeStart = 25409, XrefRangeEnd = 25424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_ScriptRuntimeException_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00034C88 File Offset: 0x00032E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25425, XrefRangeEnd = 25437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException IndexType(DynValue obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_IndexType_Public_Static_ScriptRuntimeException_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00034CCC File Offset: 0x00032ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25437, XrefRangeEnd = 25446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException LoopInIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_LoopInIndex_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00034D00 File Offset: 0x00032F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25446, XrefRangeEnd = 25455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException LoopInNewIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_LoopInNewIndex_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00034D34 File Offset: 0x00032F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25455, XrefRangeEnd = 25464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException LoopInCall()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_LoopInCall_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00034D68 File Offset: 0x00032F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25473, RefRangeEnd = 25474, XrefRangeStart = 25464, XrefRangeEnd = 25473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException TableIndexIsNil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_TableIndexIsNil_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00034D9C File Offset: 0x00032F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25474, XrefRangeEnd = 25483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException TableIndexIsNaN()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00034DD0 File Offset: 0x00032FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25483, XrefRangeEnd = 25506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ConvertToNumberFailed(int stage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_ScriptRuntimeException_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00034E10 File Offset: 0x00033010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25506, XrefRangeEnd = 25518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ConvertObjectFailed(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00034E54 File Offset: 0x00033054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25518, XrefRangeEnd = 25533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ConvertObjectFailed(DataType t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00034E98 File Offset: 0x00033098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25533, XrefRangeEnd = 25550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00034EF0 File Offset: 0x000330F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25550, XrefRangeEnd = 25567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_ScriptRuntimeException_DataType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00034F48 File Offset: 0x00033148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25567, XrefRangeEnd = 25580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_UserDataMissingField_Public_Static_ScriptRuntimeException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00034FA0 File Offset: 0x000331A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25580, XrefRangeEnd = 25591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_ScriptRuntimeException_CoroutineState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00034FE4 File Offset: 0x000331E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25591, XrefRangeEnd = 25600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException CannotYield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_CannotYield_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00035018 File Offset: 0x00033218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25600, XrefRangeEnd = 25609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException CannotYieldMain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_CannotYieldMain_Public_Static_ScriptRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0003504C File Offset: 0x0003324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25609, XrefRangeEnd = 25622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_ScriptRuntimeException_DataType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000350A4 File Offset: 0x000332A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25622, XrefRangeEnd = 25636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000350E8 File Offset: 0x000332E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25636, XrefRangeEnd = 25655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeDescr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IUserDataDescriptor_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptRuntimeException>(intPtr3) : null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00035140 File Offset: 0x00033340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25655, XrefRangeEnd = 25662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Rethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptRuntimeException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00003F7B File Offset: 0x0000217B
		public ScriptRuntimeException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00003F8A File Offset: 0x0000218A
		public ScriptRuntimeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptRuntimeException_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_ScriptRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_ConcatOnNonString_Public_Static_ScriptRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_LenOnInvalidType_Public_Static_ScriptRuntimeException_DynValue_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_CompareInvalidType_Public_Static_ScriptRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentUserData_Public_Static_ScriptRuntimeException_Int32_String_Type_Object_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_DataType_DataType_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_ScriptRuntimeException_Int32_String_String_String_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_ScriptRuntimeException_Int32_String_DataType_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_ScriptRuntimeException_String_Int32_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_ScriptRuntimeException_Int32_String_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_ScriptRuntimeException_Int32_String_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_IndexType_Public_Static_ScriptRuntimeException_DynValue_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_LoopInIndex_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_LoopInNewIndex_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_LoopInCall_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_TableIndexIsNil_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_ScriptRuntimeException_Int32_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_Object_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_ScriptRuntimeException_DataType_Type_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_ScriptRuntimeException_DataType_Type_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_UserDataMissingField_Public_Static_ScriptRuntimeException_String_String_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_ScriptRuntimeException_CoroutineState_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_CannotYield_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_CannotYieldMain_Public_Static_ScriptRuntimeException_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_ScriptRuntimeException_DataType_String_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IMemberDescriptor_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_ScriptRuntimeException_IUserDataDescriptor_IMemberDescriptor_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0;
	}
}
