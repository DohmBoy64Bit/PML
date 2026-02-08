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
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class NetRuntimeException : InterpreterException
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x000335E4 File Offset: 0x000317E4
		// Note: this type is marked as 'beforefieldinit'.
		static NetRuntimeException()
		{
			Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "NetRuntimeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr);
			NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664775);
			NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664776);
			NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664777);
			NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664778);
			NetRuntimeException.NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_NetRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664779);
			NetRuntimeException.NativeMethodInfoPtr_ConcatOnNonString_Public_Static_NetRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664780);
			NetRuntimeException.NativeMethodInfoPtr_LenOnInvalidType_Public_Static_NetRuntimeException_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664781);
			NetRuntimeException.NativeMethodInfoPtr_CompareInvalidType_Public_Static_NetRuntimeException_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664782);
			NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664783);
			NetRuntimeException.NativeMethodInfoPtr_BadArgumentUserData_Public_Static_NetRuntimeException_Int32_String_Type_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664784);
			NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_DataType_DataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664785);
			NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664786);
			NetRuntimeException.NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_NetRuntimeException_Int32_String_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664787);
			NetRuntimeException.NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_NetRuntimeException_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664788);
			NetRuntimeException.NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_NetRuntimeException_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664789);
			NetRuntimeException.NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_NetRuntimeException_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664790);
			NetRuntimeException.NativeMethodInfoPtr_IndexType_Public_Static_NetRuntimeException_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664791);
			NetRuntimeException.NativeMethodInfoPtr_LoopInIndex_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664792);
			NetRuntimeException.NativeMethodInfoPtr_LoopInNewIndex_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664793);
			NetRuntimeException.NativeMethodInfoPtr_LoopInCall_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664794);
			NetRuntimeException.NativeMethodInfoPtr_TableIndexIsNil_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664795);
			NetRuntimeException.NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664796);
			NetRuntimeException.NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_NetRuntimeException_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664797);
			NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664798);
			NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664799);
			NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664800);
			NetRuntimeException.NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_NetRuntimeException_DataType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664801);
			NetRuntimeException.NativeMethodInfoPtr_UserDataMissingField_Public_Static_NetRuntimeException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664802);
			NetRuntimeException.NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_NetRuntimeException_CoroutineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664803);
			NetRuntimeException.NativeMethodInfoPtr_CannotYield_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664804);
			NetRuntimeException.NativeMethodInfoPtr_CannotYieldMain_Public_Static_NetRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664805);
			NetRuntimeException.NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_NetRuntimeException_DataType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664806);
			NetRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664807);
			NetRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IUserDataDescriptor_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664808);
			NetRuntimeException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr, 100664809);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000338D0 File Offset: 0x00031AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetRuntimeException(Exception ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003391C File Offset: 0x00031B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24780, XrefRangeEnd = 24785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetRuntimeException(NetRuntimeException ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_NetRuntimeException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00033968 File Offset: 0x00031B68
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 24653, RefRangeEnd = 24672, XrefRangeStart = 24653, XrefRangeEnd = 24672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetRuntimeException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000339B4 File Offset: 0x00031BB4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 24673, RefRangeEnd = 24691, XrefRangeStart = 24673, XrefRangeEnd = 24691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetRuntimeException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetRuntimeException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00033A20 File Offset: 0x00031C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24785, XrefRangeEnd = 24798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_NetRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00033A78 File Offset: 0x00031C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24798, XrefRangeEnd = 24810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ConcatOnNonString_Public_Static_NetRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00033AD0 File Offset: 0x00031CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24810, XrefRangeEnd = 24822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException LenOnInvalidType(DynValue r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_LenOnInvalidType_Public_Static_NetRuntimeException_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00033B14 File Offset: 0x00031D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24822, XrefRangeEnd = 24841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_CompareInvalidType_Public_Static_NetRuntimeException_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00033B6C File Offset: 0x00031D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24841, XrefRangeEnd = 24858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgument(int argNum, string funcName, string message)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00033BD0 File Offset: 0x00031DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24858, XrefRangeEnd = 24892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, Object got, bool allowNil)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgumentUserData_Public_Static_NetRuntimeException_Int32_String_Type_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00033C54 File Offset: 0x00031E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24892, XrefRangeEnd = 24895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_DataType_DataType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00033CD8 File Offset: 0x00031ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24920, RefRangeEnd = 24921, XrefRangeStart = 24895, XrefRangeEnd = 24920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00033D5C File Offset: 0x00031F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24921, XrefRangeEnd = 24939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_NetRuntimeException_Int32_String_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00033DC0 File Offset: 0x00031FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24939, XrefRangeEnd = 24954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_NetRuntimeException_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00033E14 File Offset: 0x00032014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24954, XrefRangeEnd = 24969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_NetRuntimeException_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00033E68 File Offset: 0x00032068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24969, XrefRangeEnd = 24984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_NetRuntimeException_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00033EBC File Offset: 0x000320BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24984, XrefRangeEnd = 24996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException IndexType(DynValue obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_IndexType_Public_Static_NetRuntimeException_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00033F00 File Offset: 0x00032100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24996, XrefRangeEnd = 25005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException LoopInIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_LoopInIndex_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00033F34 File Offset: 0x00032134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25005, XrefRangeEnd = 25014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException LoopInNewIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_LoopInNewIndex_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00033F68 File Offset: 0x00032168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25014, XrefRangeEnd = 25023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException LoopInCall()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_LoopInCall_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00033F9C File Offset: 0x0003219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25023, XrefRangeEnd = 25032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException TableIndexIsNil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_TableIndexIsNil_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00033FD0 File Offset: 0x000321D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25032, XrefRangeEnd = 25041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException TableIndexIsNaN()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00034004 File Offset: 0x00032204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25041, XrefRangeEnd = 25064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ConvertToNumberFailed(int stage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_NetRuntimeException_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00034044 File Offset: 0x00032244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25064, XrefRangeEnd = 25076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ConvertObjectFailed(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00034088 File Offset: 0x00032288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25076, XrefRangeEnd = 25091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ConvertObjectFailed(DataType t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000340CC File Offset: 0x000322CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25091, XrefRangeEnd = 25108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00034124 File Offset: 0x00032324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25108, XrefRangeEnd = 25125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_NetRuntimeException_DataType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0003417C File Offset: 0x0003237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25125, XrefRangeEnd = 25138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_UserDataMissingField_Public_Static_NetRuntimeException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000341D4 File Offset: 0x000323D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25138, XrefRangeEnd = 25149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_NetRuntimeException_CoroutineState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00034218 File Offset: 0x00032418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25149, XrefRangeEnd = 25158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException CannotYield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_CannotYield_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0003424C File Offset: 0x0003244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25158, XrefRangeEnd = 25167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException CannotYieldMain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_CannotYieldMain_Public_Static_NetRuntimeException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00034280 File Offset: 0x00032480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25167, XrefRangeEnd = 25180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_NetRuntimeException_DataType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000342D8 File Offset: 0x000324D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25180, XrefRangeEnd = 25194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0003431C File Offset: 0x0003251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25194, XrefRangeEnd = 25213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeDescr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRuntimeException.NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IUserDataDescriptor_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetRuntimeException>(intPtr3) : null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00034374 File Offset: 0x00032574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25213, XrefRangeEnd = 25220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Rethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetRuntimeException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00003F63 File Offset: 0x00002163
		public NetRuntimeException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00003F72 File Offset: 0x00002172
		public NetRuntimeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetRuntimeException_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_ArithmeticOnNonNumber_Public_Static_NetRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_ConcatOnNonString_Public_Static_NetRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_LenOnInvalidType_Public_Static_NetRuntimeException_DynValue_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_CompareInvalidType_Public_Static_NetRuntimeException_DynValue_DynValue_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentUserData_Public_Static_NetRuntimeException_Int32_String_Type_Object_Boolean_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_DataType_DataType_Boolean_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_BadArgument_Public_Static_NetRuntimeException_Int32_String_String_String_Boolean_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentNoValue_Public_Static_NetRuntimeException_Int32_String_DataType_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentIndexOutOfRange_Public_Static_NetRuntimeException_String_Int32_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentNoNegativeNumbers_Public_Static_NetRuntimeException_Int32_String_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_BadArgumentValueExpected_Public_Static_NetRuntimeException_Int32_String_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_IndexType_Public_Static_NetRuntimeException_DynValue_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_LoopInIndex_Public_Static_NetRuntimeException_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_LoopInNewIndex_Public_Static_NetRuntimeException_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_LoopInCall_Public_Static_NetRuntimeException_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_TableIndexIsNil_Public_Static_NetRuntimeException_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_TableIndexIsNaN_Public_Static_NetRuntimeException_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToNumberFailed_Public_Static_NetRuntimeException_Int32_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_Object_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectFailed_Public_Static_NetRuntimeException_DataType_Type_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_UserDataArgumentTypeMismatch_Public_Static_NetRuntimeException_DataType_Type_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_UserDataMissingField_Public_Static_NetRuntimeException_String_String_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_CannotResumeNotSuspended_Public_Static_NetRuntimeException_CoroutineState_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_CannotYield_Public_Static_NetRuntimeException_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_CannotYieldMain_Public_Static_NetRuntimeException_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_AttemptToCallNonFunc_Public_Static_NetRuntimeException_DataType_String_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IMemberDescriptor_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_AccessInstanceMemberOnStatics_Public_Static_NetRuntimeException_IUserDataDescriptor_IMemberDescriptor_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0;
	}
}
