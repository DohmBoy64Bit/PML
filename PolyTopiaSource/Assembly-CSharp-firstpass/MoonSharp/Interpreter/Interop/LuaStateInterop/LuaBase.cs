using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CA RID: 202
	public class LuaBase : Object
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x0005425C File Offset: 0x0005245C
		// Note: this type is marked as 'beforefieldinit'.
		static LuaBase()
		{
			Il2CppClassPointerStore<LuaBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.LuaStateInterop", "LuaBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaBase>.NativeClassPtr);
			LuaBase.NativeFieldInfoPtr_LUA_TNONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TNONE");
			LuaBase.NativeFieldInfoPtr_LUA_TNIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TNIL");
			LuaBase.NativeFieldInfoPtr_LUA_TBOOLEAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TBOOLEAN");
			LuaBase.NativeFieldInfoPtr_LUA_TLIGHTUSERDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TLIGHTUSERDATA");
			LuaBase.NativeFieldInfoPtr_LUA_TNUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TNUMBER");
			LuaBase.NativeFieldInfoPtr_LUA_TSTRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TSTRING");
			LuaBase.NativeFieldInfoPtr_LUA_TTABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TTABLE");
			LuaBase.NativeFieldInfoPtr_LUA_TFUNCTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TFUNCTION");
			LuaBase.NativeFieldInfoPtr_LUA_TUSERDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TUSERDATA");
			LuaBase.NativeFieldInfoPtr_LUA_TTHREAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_TTHREAD");
			LuaBase.NativeFieldInfoPtr_LUA_MULTRET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_MULTRET");
			LuaBase.NativeFieldInfoPtr_LUA_INTFRMLEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, "LUA_INTFRMLEN");
			LuaBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666154);
			LuaBase.NativeMethodInfoPtr_GetArgument_Protected_Static_DynValue_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666085);
			LuaBase.NativeMethodInfoPtr_ArgAsType_Protected_Static_DynValue_LuaState_Int32_DataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666086);
			LuaBase.NativeMethodInfoPtr_LuaType_Protected_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666087);
			LuaBase.NativeMethodInfoPtr_LuaLCheckLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666088);
			LuaBase.NativeMethodInfoPtr_LuaPushInteger_Protected_Static_Void_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666089);
			LuaBase.NativeMethodInfoPtr_LuaToBoolean_Protected_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666090);
			LuaBase.NativeMethodInfoPtr_LuaToLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666091);
			LuaBase.NativeMethodInfoPtr_LuaToString_Protected_Static_String_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666092);
			LuaBase.NativeMethodInfoPtr_LuaLAddValue_Protected_Static_Void_LuaLBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666093);
			LuaBase.NativeMethodInfoPtr_LuaLAddLString_Protected_Static_Void_LuaLBuffer_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666094);
			LuaBase.NativeMethodInfoPtr_LuaLAddString_Protected_Static_Void_LuaLBuffer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666095);
			LuaBase.NativeMethodInfoPtr_LuaLOptInteger_Protected_Static_Int32_LuaState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666096);
			LuaBase.NativeMethodInfoPtr_LuaLCheckInteger_Protected_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666097);
			LuaBase.NativeMethodInfoPtr_LuaLArgCheck_Protected_Static_Void_LuaState_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666098);
			LuaBase.NativeMethodInfoPtr_LuaLCheckInt_Protected_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666099);
			LuaBase.NativeMethodInfoPtr_LuaGetTop_Protected_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666100);
			LuaBase.NativeMethodInfoPtr_LuaLError_Protected_Static_Int32_LuaState_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666101);
			LuaBase.NativeMethodInfoPtr_LuaLAddChar_Protected_Static_Void_LuaLBuffer_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666102);
			LuaBase.NativeMethodInfoPtr_LuaLBuffInit_Protected_Static_Void_LuaState_LuaLBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666103);
			LuaBase.NativeMethodInfoPtr_LuaPushLiteral_Protected_Static_Void_LuaState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666104);
			LuaBase.NativeMethodInfoPtr_LuaLPushResult_Protected_Static_Void_LuaLBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666105);
			LuaBase.NativeMethodInfoPtr_LuaPushLString_Protected_Static_Void_LuaState_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666106);
			LuaBase.NativeMethodInfoPtr_LuaLCheckStack_Protected_Static_Void_LuaState_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666107);
			LuaBase.NativeMethodInfoPtr_LUA_QL_Protected_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666108);
			LuaBase.NativeMethodInfoPtr_LuaPushNil_Protected_Static_Void_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666109);
			LuaBase.NativeMethodInfoPtr_LuaAssert_Protected_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666110);
			LuaBase.NativeMethodInfoPtr_LuaLTypeName_Protected_Static_String_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666111);
			LuaBase.NativeMethodInfoPtr_LuaIsString_Protected_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666112);
			LuaBase.NativeMethodInfoPtr_LuaPop_Protected_Static_Void_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666113);
			LuaBase.NativeMethodInfoPtr_LuaGetTable_Protected_Static_Void_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666114);
			LuaBase.NativeMethodInfoPtr_LuaLOptInt_Protected_Static_Int32_LuaState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666115);
			LuaBase.NativeMethodInfoPtr_LuaLCheckString_Protected_Static_CharPtr_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666116);
			LuaBase.NativeMethodInfoPtr_LuaLCheckStringStr_Protected_Static_String_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666117);
			LuaBase.NativeMethodInfoPtr_LuaLArgError_Protected_Static_Void_LuaState_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666118);
			LuaBase.NativeMethodInfoPtr_LuaLCheckNumber_Protected_Static_Double_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666119);
			LuaBase.NativeMethodInfoPtr_LuaPushValue_Protected_Static_Void_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666120);
			LuaBase.NativeMethodInfoPtr_LuaCall_Protected_Static_Void_LuaState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666121);
			LuaBase.NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666122);
			LuaBase.NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666123);
			LuaBase.NativeMethodInfoPtr_memchr_Protected_Static_CharPtr_CharPtr_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666124);
			LuaBase.NativeMethodInfoPtr_strpbrk_Protected_Static_CharPtr_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666125);
			LuaBase.NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666126);
			LuaBase.NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666127);
			LuaBase.NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666128);
			LuaBase.NativeMethodInfoPtr_islower_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666129);
			LuaBase.NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666130);
			LuaBase.NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666131);
			LuaBase.NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666132);
			LuaBase.NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666133);
			LuaBase.NativeMethodInfoPtr_isxdigit_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666134);
			LuaBase.NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666135);
			LuaBase.NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666136);
			LuaBase.NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666137);
			LuaBase.NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666138);
			LuaBase.NativeMethodInfoPtr_islower_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666139);
			LuaBase.NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666140);
			LuaBase.NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666141);
			LuaBase.NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666142);
			LuaBase.NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666143);
			LuaBase.NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666144);
			LuaBase.NativeMethodInfoPtr_tolower_Protected_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666145);
			LuaBase.NativeMethodInfoPtr_toupper_Protected_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666146);
			LuaBase.NativeMethodInfoPtr_tolower_Protected_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666147);
			LuaBase.NativeMethodInfoPtr_toupper_Protected_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666148);
			LuaBase.NativeMethodInfoPtr_strchr_Protected_Static_CharPtr_CharPtr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666149);
			LuaBase.NativeMethodInfoPtr_strcpy_Protected_Static_CharPtr_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666150);
			LuaBase.NativeMethodInfoPtr_strncpy_Protected_Static_CharPtr_CharPtr_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666151);
			LuaBase.NativeMethodInfoPtr_strlen_Protected_Static_Int32_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666152);
			LuaBase.NativeMethodInfoPtr_sprintf_Public_Static_Void_CharPtr_CharPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBase>.NativeClassPtr, 100666153);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000548F4 File Offset: 0x00052AF4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00054930 File Offset: 0x00052B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39979, XrefRangeEnd = 39981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue GetArgument(LuaState L, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_GetArgument_Protected_Static_DynValue_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00054984 File Offset: 0x00052B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39983, RefRangeEnd = 39985, XrefRangeStart = 39981, XrefRangeEnd = 39983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_ArgAsType_Protected_Static_DynValue_LuaState_Int32_DataType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000549F8 File Offset: 0x00052BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39986, RefRangeEnd = 39988, XrefRangeStart = 39985, XrefRangeEnd = 39986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaType(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaType_Protected_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00054A48 File Offset: 0x00052C48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 39991, RefRangeEnd = 39998, XrefRangeStart = 39988, XrefRangeEnd = 39991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LuaLCheckLString(LuaState L, int argNum, out uint l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00054AA0 File Offset: 0x00052CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40004, RefRangeEnd = 40007, XrefRangeStart = 39998, XrefRangeEnd = 40004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPushInteger(LuaState L, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPushInteger_Protected_Static_Void_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00054AE4 File Offset: 0x00052CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40009, RefRangeEnd = 40011, XrefRangeStart = 40007, XrefRangeEnd = 40009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaToBoolean(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaToBoolean_Protected_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00054B34 File Offset: 0x00052D34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 39991, RefRangeEnd = 39998, XrefRangeStart = 39991, XrefRangeEnd = 39998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LuaToLString(LuaState luaState, int p, out uint l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(luaState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaToLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00054B8C File Offset: 0x00052D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40014, RefRangeEnd = 40015, XrefRangeStart = 40011, XrefRangeEnd = 40014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LuaToString(LuaState luaState, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(luaState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaToString_Protected_Static_String_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00054BD8 File Offset: 0x00052DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40019, RefRangeEnd = 40022, XrefRangeStart = 40015, XrefRangeEnd = 40019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLAddValue(LuaLBuffer b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLAddValue_Protected_Static_Void_LuaLBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00054C10 File Offset: 0x00052E10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40025, RefRangeEnd = 40029, XrefRangeStart = 40022, XrefRangeEnd = 40025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLAddLString_Protected_Static_Void_LuaLBuffer_CharPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00054C68 File Offset: 0x00052E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40031, RefRangeEnd = 40032, XrefRangeStart = 40029, XrefRangeEnd = 40031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLAddString(LuaLBuffer b, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLAddString_Protected_Static_Void_LuaLBuffer_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00054CB0 File Offset: 0x00052EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40035, RefRangeEnd = 40036, XrefRangeStart = 40032, XrefRangeEnd = 40035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaLOptInteger(LuaState L, int pos, int def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref def;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLOptInteger_Protected_Static_Int32_LuaState_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00054D10 File Offset: 0x00052F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40036, XrefRangeEnd = 40038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaLCheckInteger(LuaState L, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckInteger_Protected_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00054D60 File Offset: 0x00052F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40038, RefRangeEnd = 40039, XrefRangeStart = 40038, XrefRangeEnd = 40038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref condition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLArgCheck_Protected_Static_Void_LuaState_Boolean_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00054DC4 File Offset: 0x00052FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaLCheckInt(LuaState L, int argNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckInt_Protected_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00054E14 File Offset: 0x00053014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40040, RefRangeEnd = 40041, XrefRangeStart = 40039, XrefRangeEnd = 40040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaGetTop(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaGetTop_Protected_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00054E58 File Offset: 0x00053058
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 40046, RefRangeEnd = 40060, XrefRangeStart = 40041, XrefRangeEnd = 40046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaLError(LuaState luaState, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(luaState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLError_Protected_Static_Int32_LuaState_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00054ECC File Offset: 0x000530CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 40062, RefRangeEnd = 40070, XrefRangeStart = 40060, XrefRangeEnd = 40062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLAddChar(LuaLBuffer b, char p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLAddChar_Protected_Static_Void_LuaLBuffer_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00054F10 File Offset: 0x00053110
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLBuffInit(LuaState L, LuaLBuffer b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLBuffInit_Protected_Static_Void_LuaState_LuaLBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00054F58 File Offset: 0x00053158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40070, XrefRangeEnd = 40076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPushLiteral(LuaState L, string literalString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(literalString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPushLiteral_Protected_Static_Void_LuaState_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00054FA0 File Offset: 0x000531A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40082, RefRangeEnd = 40084, XrefRangeStart = 40076, XrefRangeEnd = 40082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLPushResult(LuaLBuffer b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLPushResult_Protected_Static_Void_LuaLBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00054FD8 File Offset: 0x000531D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40091, RefRangeEnd = 40093, XrefRangeStart = 40084, XrefRangeEnd = 40091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPushLString(LuaState L, CharPtr s, uint len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPushLString_Protected_Static_Void_LuaState_CharPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00055030 File Offset: 0x00053230
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLCheckStack(LuaState L, int n, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckStack_Protected_Static_Void_LuaState_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00055088 File Offset: 0x00053288
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 40096, RefRangeEnd = 40101, XrefRangeStart = 40093, XrefRangeEnd = 40096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LUA_QL(string p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LUA_QL_Protected_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000550C4 File Offset: 0x000532C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40101, XrefRangeEnd = 40110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPushNil(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPushNil_Protected_Static_Void_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000550FC File Offset: 0x000532FC
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaAssert(bool p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaAssert_Protected_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00055130 File Offset: 0x00053330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40113, RefRangeEnd = 40114, XrefRangeStart = 40110, XrefRangeEnd = 40113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LuaLTypeName(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLTypeName_Protected_Static_String_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0005517C File Offset: 0x0005337C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40115, RefRangeEnd = 40116, XrefRangeStart = 40114, XrefRangeEnd = 40115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaIsString(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaIsString_Protected_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000551CC File Offset: 0x000533CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40124, RefRangeEnd = 40125, XrefRangeStart = 40116, XrefRangeEnd = 40124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPop(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPop_Protected_Static_Void_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00055210 File Offset: 0x00053410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40136, RefRangeEnd = 40137, XrefRangeStart = 40125, XrefRangeEnd = 40136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaGetTable(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaGetTable_Protected_Static_Void_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00055254 File Offset: 0x00053454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40140, RefRangeEnd = 40141, XrefRangeStart = 40137, XrefRangeEnd = 40140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaLOptInt(LuaState L, int pos, int def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref def;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLOptInt_Protected_Static_Int32_LuaState_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000552B4 File Offset: 0x000534B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40141, XrefRangeEnd = 40148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr LuaLCheckString(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckString_Protected_Static_CharPtr_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00055308 File Offset: 0x00053508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40014, RefRangeEnd = 40015, XrefRangeStart = 40014, XrefRangeEnd = 40015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LuaLCheckStringStr(LuaState L, int p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckStringStr_Protected_Static_String_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00055354 File Offset: 0x00053554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40154, RefRangeEnd = 40155, XrefRangeStart = 40148, XrefRangeEnd = 40154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaLArgError(LuaState L, int arg, string p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLArgError_Protected_Static_Void_LuaState_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000553AC File Offset: 0x000535AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40157, RefRangeEnd = 40161, XrefRangeStart = 40155, XrefRangeEnd = 40157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double LuaLCheckNumber(LuaState L, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaLCheckNumber_Protected_Static_Double_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000553FC File Offset: 0x000535FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40164, RefRangeEnd = 40166, XrefRangeStart = 40161, XrefRangeEnd = 40164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaPushValue(LuaState L, int arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaPushValue_Protected_Static_Void_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00055440 File Offset: 0x00053640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40193, RefRangeEnd = 40194, XrefRangeStart = 40166, XrefRangeEnd = 40193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LuaCall(LuaState L, int nargs, int nresults = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nargs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nresults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_LuaCall_Protected_Static_Void_LuaState_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00055494 File Offset: 0x00053694
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40194, RefRangeEnd = 40197, XrefRangeStart = 40194, XrefRangeEnd = 40194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			ptr3[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_UInt32_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000554F8 File Offset: 0x000536F8
		[CallerCount(0)]
		public unsafe static int memcmp(CharPtr ptr1, CharPtr ptr2, int size)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			ptr3[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_Int32_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0005555C File Offset: 0x0005375C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40199, RefRangeEnd = 40201, XrefRangeStart = 40197, XrefRangeEnd = 40199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr memchr(CharPtr ptr, char c, uint count)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_memchr_Protected_Static_CharPtr_CharPtr_Char_UInt32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000555BC File Offset: 0x000537BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40207, RefRangeEnd = 40208, XrefRangeStart = 40201, XrefRangeEnd = 40207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr strpbrk(CharPtr str, CharPtr charset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_strpbrk_Protected_Static_CharPtr_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00055614 File Offset: 0x00053814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40211, RefRangeEnd = 40212, XrefRangeStart = 40208, XrefRangeEnd = 40211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isalpha(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00055654 File Offset: 0x00053854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40215, RefRangeEnd = 40216, XrefRangeStart = 40212, XrefRangeEnd = 40215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool iscntrl(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00055694 File Offset: 0x00053894
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 40219, RefRangeEnd = 40227, XrefRangeStart = 40216, XrefRangeEnd = 40219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isdigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000556D4 File Offset: 0x000538D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40230, RefRangeEnd = 40232, XrefRangeStart = 40227, XrefRangeEnd = 40230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool islower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_islower_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00055714 File Offset: 0x00053914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40235, RefRangeEnd = 40236, XrefRangeStart = 40232, XrefRangeEnd = 40235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ispunct(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00055754 File Offset: 0x00053954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40236, RefRangeEnd = 40237, XrefRangeStart = 40236, XrefRangeEnd = 40236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isspace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00055794 File Offset: 0x00053994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40240, RefRangeEnd = 40241, XrefRangeStart = 40237, XrefRangeEnd = 40240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isupper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000557D4 File Offset: 0x000539D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40244, RefRangeEnd = 40245, XrefRangeStart = 40241, XrefRangeEnd = 40244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isalnum(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00055814 File Offset: 0x00053A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40248, RefRangeEnd = 40249, XrefRangeStart = 40245, XrefRangeEnd = 40248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isxdigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isxdigit_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00055854 File Offset: 0x00053A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40252, RefRangeEnd = 40253, XrefRangeStart = 40249, XrefRangeEnd = 40252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isgraph(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00055894 File Offset: 0x00053A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40253, XrefRangeEnd = 40256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isalpha(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000558D4 File Offset: 0x00053AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40256, XrefRangeEnd = 40259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool iscntrl(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00055914 File Offset: 0x00053B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40259, XrefRangeEnd = 40262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isdigit(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00055954 File Offset: 0x00053B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40262, XrefRangeEnd = 40265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool islower(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_islower_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00055994 File Offset: 0x00053B94
		[CallerCount(0)]
		public unsafe static bool ispunct(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000559D4 File Offset: 0x00053BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40236, RefRangeEnd = 40237, XrefRangeStart = 40236, XrefRangeEnd = 40237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isspace(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00055A14 File Offset: 0x00053C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40265, XrefRangeEnd = 40268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isupper(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00055A54 File Offset: 0x00053C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40268, XrefRangeEnd = 40271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isalnum(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00055A94 File Offset: 0x00053C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40271, XrefRangeEnd = 40274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isgraph(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00055AD4 File Offset: 0x00053CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40281, RefRangeEnd = 40282, XrefRangeStart = 40274, XrefRangeEnd = 40281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char tolower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_tolower_Protected_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00055B14 File Offset: 0x00053D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40282, XrefRangeEnd = 40289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char toupper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_toupper_Protected_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00055B54 File Offset: 0x00053D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40289, XrefRangeEnd = 40296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char tolower(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_tolower_Protected_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00055B94 File Offset: 0x00053D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40296, XrefRangeEnd = 40303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char toupper(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_toupper_Protected_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00055BD4 File Offset: 0x00053DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40308, RefRangeEnd = 40310, XrefRangeStart = 40303, XrefRangeEnd = 40308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr strchr(CharPtr str, char c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_strchr_Protected_Static_CharPtr_CharPtr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00055C28 File Offset: 0x00053E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40311, RefRangeEnd = 40312, XrefRangeStart = 40310, XrefRangeEnd = 40311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr strcpy(CharPtr dst, CharPtr src)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_strcpy_Protected_Static_CharPtr_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00055C80 File Offset: 0x00053E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40313, RefRangeEnd = 40314, XrefRangeStart = 40312, XrefRangeEnd = 40313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr strncpy(CharPtr dst, CharPtr src, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_strncpy_Protected_Static_CharPtr_CharPtr_CharPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00055CE4 File Offset: 0x00053EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40315, RefRangeEnd = 40317, XrefRangeStart = 40314, XrefRangeEnd = 40315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int strlen(CharPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_strlen_Protected_Static_Int32_CharPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00055D28 File Offset: 0x00053F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40326, RefRangeEnd = 40327, XrefRangeStart = 40317, XrefRangeEnd = 40326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void sprintf(CharPtr buffer, CharPtr str, [Optional] Il2CppReferenceArray<Object> argv)
		{
			if (argv == null)
			{
				argv = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBase.NativeMethodInfoPtr_sprintf_Public_Static_Void_CharPtr_CharPtr_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00006A75 File Offset: 0x00004C75
		public static int LuaLError(LuaState luaState, string message, params Object[] args)
		{
			return LuaBase.LuaLError(luaState, message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00006A84 File Offset: 0x00004C84
		public static void sprintf(CharPtr buffer, CharPtr str, params Object[] argv)
		{
			LuaBase.sprintf(buffer, str, new Il2CppReferenceArray<Object>(argv));
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00006A93 File Offset: 0x00004C93
		public LuaBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00055D90 File Offset: 0x00053F90
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x00006A9C File Offset: 0x00004C9C
		public unsafe static int LUA_TNONE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TNONE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TNONE, (void*)(&value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00055DAC File Offset: 0x00053FAC
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00006AAA File Offset: 0x00004CAA
		public unsafe static int LUA_TNIL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TNIL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TNIL, (void*)(&value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00055DC8 File Offset: 0x00053FC8
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public unsafe static int LUA_TBOOLEAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TBOOLEAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TBOOLEAN, (void*)(&value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00055DE4 File Offset: 0x00053FE4
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x00006AC6 File Offset: 0x00004CC6
		public unsafe static int LUA_TLIGHTUSERDATA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TLIGHTUSERDATA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TLIGHTUSERDATA, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00055E00 File Offset: 0x00054000
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public unsafe static int LUA_TNUMBER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TNUMBER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TNUMBER, (void*)(&value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00055E1C File Offset: 0x0005401C
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00006AE2 File Offset: 0x00004CE2
		public unsafe static int LUA_TSTRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TSTRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TSTRING, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00055E38 File Offset: 0x00054038
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public unsafe static int LUA_TTABLE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TTABLE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TTABLE, (void*)(&value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00055E54 File Offset: 0x00054054
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00006AFE File Offset: 0x00004CFE
		public unsafe static int LUA_TFUNCTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TFUNCTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TFUNCTION, (void*)(&value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00055E70 File Offset: 0x00054070
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00006B0C File Offset: 0x00004D0C
		public unsafe static int LUA_TUSERDATA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TUSERDATA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TUSERDATA, (void*)(&value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00055E8C File Offset: 0x0005408C
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00006B1A File Offset: 0x00004D1A
		public unsafe static int LUA_TTHREAD
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_TTHREAD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_TTHREAD, (void*)(&value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00055EA8 File Offset: 0x000540A8
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00006B28 File Offset: 0x00004D28
		public unsafe static int LUA_MULTRET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_MULTRET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_MULTRET, (void*)(&value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00055EC4 File Offset: 0x000540C4
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00006B36 File Offset: 0x00004D36
		public unsafe static string LUA_INTFRMLEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LuaBase.NativeFieldInfoPtr_LUA_INTFRMLEN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LuaBase.NativeFieldInfoPtr_LUA_INTFRMLEN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TNONE;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TNIL;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TBOOLEAN;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TLIGHTUSERDATA;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TNUMBER;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TSTRING;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TTABLE;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TFUNCTION;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TUSERDATA;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr_LUA_TTHREAD;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr_LUA_MULTRET;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeFieldInfoPtr_LUA_INTFRMLEN;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Protected_Static_DynValue_LuaState_Int32_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_ArgAsType_Protected_Static_DynValue_LuaState_Int32_DataType_Boolean_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_LuaType_Protected_Static_Int32_LuaState_Int32_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_LuaPushInteger_Protected_Static_Void_LuaState_Int32_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_LuaToBoolean_Protected_Static_Int32_LuaState_Int32_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_LuaToLString_Protected_Static_String_LuaState_Int32_byref_UInt32_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_LuaToString_Protected_Static_String_LuaState_Int32_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_LuaLAddValue_Protected_Static_Void_LuaLBuffer_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_LuaLAddLString_Protected_Static_Void_LuaLBuffer_CharPtr_UInt32_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_LuaLAddString_Protected_Static_Void_LuaLBuffer_String_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_LuaLOptInteger_Protected_Static_Int32_LuaState_Int32_Int32_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckInteger_Protected_Static_Int32_LuaState_Int32_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_LuaLArgCheck_Protected_Static_Void_LuaState_Boolean_Int32_String_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckInt_Protected_Static_Int32_LuaState_Int32_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_LuaGetTop_Protected_Static_Int32_LuaState_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_LuaLError_Protected_Static_Int32_LuaState_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_LuaLAddChar_Protected_Static_Void_LuaLBuffer_Char_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_LuaLBuffInit_Protected_Static_Void_LuaState_LuaLBuffer_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_LuaPushLiteral_Protected_Static_Void_LuaState_String_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_LuaLPushResult_Protected_Static_Void_LuaLBuffer_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_LuaPushLString_Protected_Static_Void_LuaState_CharPtr_UInt32_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckStack_Protected_Static_Void_LuaState_Int32_String_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_LUA_QL_Protected_Static_String_String_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_LuaPushNil_Protected_Static_Void_LuaState_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_LuaAssert_Protected_Static_Void_Boolean_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_LuaLTypeName_Protected_Static_String_LuaState_Int32_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_LuaIsString_Protected_Static_Int32_LuaState_Int32_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_LuaPop_Protected_Static_Void_LuaState_Int32_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_LuaGetTable_Protected_Static_Void_LuaState_Int32_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_LuaLOptInt_Protected_Static_Int32_LuaState_Int32_Int32_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckString_Protected_Static_CharPtr_LuaState_Int32_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckStringStr_Protected_Static_String_LuaState_Int32_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_LuaLArgError_Protected_Static_Void_LuaState_Int32_String_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_LuaLCheckNumber_Protected_Static_Double_LuaState_Int32_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_LuaPushValue_Protected_Static_Void_LuaState_Int32_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_LuaCall_Protected_Static_Void_LuaState_Int32_Int32_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_UInt32_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_memcmp_Protected_Static_Int32_CharPtr_CharPtr_Int32_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_memchr_Protected_Static_CharPtr_CharPtr_Char_UInt32_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_strpbrk_Protected_Static_CharPtr_CharPtr_CharPtr_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_islower_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_isxdigit_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Char_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_isalpha_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_iscntrl_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_isdigit_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_islower_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_ispunct_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_isspace_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_isupper_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_isalnum_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_isgraph_Protected_Static_Boolean_Int32_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_tolower_Protected_Static_Char_Char_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_toupper_Protected_Static_Char_Char_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_tolower_Protected_Static_Char_Int32_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_toupper_Protected_Static_Char_Int32_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_strchr_Protected_Static_CharPtr_CharPtr_Char_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_strcpy_Protected_Static_CharPtr_CharPtr_CharPtr_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_strncpy_Protected_Static_CharPtr_CharPtr_CharPtr_Int32_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_strlen_Protected_Static_Int32_CharPtr_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_sprintf_Public_Static_Void_CharPtr_CharPtr_Il2CppReferenceArray_1_Object_0;
	}
}
