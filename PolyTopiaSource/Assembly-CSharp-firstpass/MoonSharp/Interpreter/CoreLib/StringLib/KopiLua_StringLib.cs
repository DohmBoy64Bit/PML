using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.LuaStateInterop;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
	// Token: 0x0200011A RID: 282
	public class KopiLua_StringLib : LuaBase
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x0006C838 File Offset: 0x0006AA38
		// Note: this type is marked as 'beforefieldinit'.
		static KopiLua_StringLib()
		{
			Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.StringLib", "KopiLua_StringLib");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr);
			KopiLua_StringLib.NativeFieldInfoPtr_LUA_MAXCAPTURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "LUA_MAXCAPTURES");
			KopiLua_StringLib.NativeFieldInfoPtr_CAP_UNFINISHED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "CAP_UNFINISHED");
			KopiLua_StringLib.NativeFieldInfoPtr_CAP_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "CAP_POSITION");
			KopiLua_StringLib.NativeFieldInfoPtr_MAXCCALLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "MAXCCALLS");
			KopiLua_StringLib.NativeFieldInfoPtr_L_ESC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "L_ESC");
			KopiLua_StringLib.NativeFieldInfoPtr_SPECIALS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "SPECIALS");
			KopiLua_StringLib.NativeFieldInfoPtr_MAX_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "MAX_ITEM");
			KopiLua_StringLib.NativeFieldInfoPtr_FLAGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "FLAGS");
			KopiLua_StringLib.NativeFieldInfoPtr_MAX_FORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "MAX_FORMAT");
			KopiLua_StringLib.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667049);
			KopiLua_StringLib.NativeMethodInfoPtr_posrelat_Private_Static_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667017);
			KopiLua_StringLib.NativeMethodInfoPtr_check_capture_Private_Static_Int32_MatchState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667018);
			KopiLua_StringLib.NativeMethodInfoPtr_capture_to_close_Private_Static_Int32_MatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667019);
			KopiLua_StringLib.NativeMethodInfoPtr_classend_Private_Static_CharPtr_MatchState_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667020);
			KopiLua_StringLib.NativeMethodInfoPtr_match_class_Private_Static_Int32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667021);
			KopiLua_StringLib.NativeMethodInfoPtr_matchbracketclass_Private_Static_Int32_Int32_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667022);
			KopiLua_StringLib.NativeMethodInfoPtr_singlematch_Private_Static_Int32_Int32_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667023);
			KopiLua_StringLib.NativeMethodInfoPtr_matchbalance_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667024);
			KopiLua_StringLib.NativeMethodInfoPtr_max_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667025);
			KopiLua_StringLib.NativeMethodInfoPtr_min_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667026);
			KopiLua_StringLib.NativeMethodInfoPtr_start_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667027);
			KopiLua_StringLib.NativeMethodInfoPtr_end_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667028);
			KopiLua_StringLib.NativeMethodInfoPtr_match_capture_Private_Static_CharPtr_MatchState_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667029);
			KopiLua_StringLib.NativeMethodInfoPtr_match_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667030);
			KopiLua_StringLib.NativeMethodInfoPtr_lmemfind_Private_Static_CharPtr_CharPtr_UInt32_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667031);
			KopiLua_StringLib.NativeMethodInfoPtr_push_onecapture_Private_Static_Void_MatchState_Int32_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667032);
			KopiLua_StringLib.NativeMethodInfoPtr_push_captures_Private_Static_Int32_MatchState_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667033);
			KopiLua_StringLib.NativeMethodInfoPtr_str_find_aux_Private_Static_Int32_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667034);
			KopiLua_StringLib.NativeMethodInfoPtr_str_find_Public_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667035);
			KopiLua_StringLib.NativeMethodInfoPtr_str_match_Public_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667036);
			KopiLua_StringLib.NativeMethodInfoPtr_gmatch_aux_Private_Static_Int32_LuaState_GMatchAuxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667037);
			KopiLua_StringLib.NativeMethodInfoPtr_gmatch_aux_2_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667038);
			KopiLua_StringLib.NativeMethodInfoPtr_str_gmatch_Public_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667039);
			KopiLua_StringLib.NativeMethodInfoPtr_gfind_nodef_Private_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667040);
			KopiLua_StringLib.NativeMethodInfoPtr_add_s_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667041);
			KopiLua_StringLib.NativeMethodInfoPtr_add_value_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667042);
			KopiLua_StringLib.NativeMethodInfoPtr_str_gsub_Public_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667043);
			KopiLua_StringLib.NativeMethodInfoPtr_addquoted_Private_Static_Void_LuaState_LuaLBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667044);
			KopiLua_StringLib.NativeMethodInfoPtr_scanformat_Private_Static_CharPtr_LuaState_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667045);
			KopiLua_StringLib.NativeMethodInfoPtr_addintlen_Private_Static_Void_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667046);
			KopiLua_StringLib.NativeMethodInfoPtr_str_format_Public_Static_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667047);
			KopiLua_StringLib.NativeMethodInfoPtr_PatchPattern_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, 100667048);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006CBB0 File Offset: 0x0006ADB0
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KopiLua_StringLib()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0006CBEC File Offset: 0x0006ADEC
		[CallerCount(0)]
		public unsafe static int posrelat(int pos, uint len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_posrelat_Private_Static_Int32_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006CC38 File Offset: 0x0006AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50510, XrefRangeEnd = 50512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int check_capture(KopiLua_StringLib.MatchState ms, int l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_check_capture_Private_Static_Int32_MatchState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0006CC88 File Offset: 0x0006AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50512, XrefRangeEnd = 50518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int capture_to_close(KopiLua_StringLib.MatchState ms)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_capture_to_close_Private_Static_Int32_MatchState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0006CCCC File Offset: 0x0006AECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50540, RefRangeEnd = 50542, XrefRangeStart = 50518, XrefRangeEnd = 50540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr classend(KopiLua_StringLib.MatchState ms, CharPtr p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_classend_Private_Static_CharPtr_MatchState_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0006CD24 File Offset: 0x0006AF24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50564, RefRangeEnd = 50566, XrefRangeStart = 50542, XrefRangeEnd = 50564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int match_class(char c, char cl)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_match_class_Private_Static_Int32_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0006CD70 File Offset: 0x0006AF70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50586, RefRangeEnd = 50588, XrefRangeStart = 50566, XrefRangeEnd = 50586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int matchbracketclass(int c, CharPtr p, CharPtr ec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_matchbracketclass_Private_Static_Int32_Int32_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0006CDD4 File Offset: 0x0006AFD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 50594, RefRangeEnd = 50598, XrefRangeStart = 50588, XrefRangeEnd = 50594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int singlematch(int c, CharPtr p, CharPtr ep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ep);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_singlematch_Private_Static_Int32_Int32_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0006CE38 File Offset: 0x0006B038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50619, RefRangeEnd = 50620, XrefRangeStart = 50598, XrefRangeEnd = 50619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr matchbalance(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_matchbalance_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50635, RefRangeEnd = 50636, XrefRangeStart = 50620, XrefRangeEnd = 50635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr max_expand(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ep);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_max_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0006CF1C File Offset: 0x0006B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50636, XrefRangeEnd = 50650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr min_expand(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ep);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_min_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0006CF98 File Offset: 0x0006B198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50662, RefRangeEnd = 50664, XrefRangeStart = 50650, XrefRangeEnd = 50662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr start_capture(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, int what)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref what;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_start_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0006D010 File Offset: 0x0006B210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50676, RefRangeEnd = 50677, XrefRangeStart = 50664, XrefRangeEnd = 50676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr end_capture(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_end_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0006D078 File Offset: 0x0006B278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50694, RefRangeEnd = 50695, XrefRangeStart = 50677, XrefRangeEnd = 50694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr match_capture(KopiLua_StringLib.MatchState ms, CharPtr s, int l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_match_capture_Private_Static_CharPtr_MatchState_CharPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0006D0DC File Offset: 0x0006B2DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 50826, RefRangeEnd = 50834, XrefRangeStart = 50695, XrefRangeEnd = 50826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr match(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_match_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0006D144 File Offset: 0x0006B344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50834, XrefRangeEnd = 50841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr lmemfind(CharPtr s1, uint l1, CharPtr s2, uint l2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_lmemfind_Private_Static_CharPtr_CharPtr_UInt32_CharPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50850, RefRangeEnd = 50853, XrefRangeStart = 50841, XrefRangeEnd = 50850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void push_onecapture(KopiLua_StringLib.MatchState ms, int i, CharPtr s, CharPtr e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_push_onecapture_Private_Static_Void_MatchState_Int32_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0006D220 File Offset: 0x0006B420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50864, RefRangeEnd = 50866, XrefRangeStart = 50853, XrefRangeEnd = 50864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int push_captures(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_push_captures_Private_Static_Int32_MatchState_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0006D288 File Offset: 0x0006B488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50905, RefRangeEnd = 50907, XrefRangeStart = 50866, XrefRangeEnd = 50905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_find_aux(LuaState L, int find)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref find;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_find_aux_Private_Static_Int32_LuaState_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0006D2D8 File Offset: 0x0006B4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50907, XrefRangeEnd = 50911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_find(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_find_Public_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0006D31C File Offset: 0x0006B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50911, XrefRangeEnd = 50915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_match(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_match_Public_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0006D360 File Offset: 0x0006B560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50937, RefRangeEnd = 50938, XrefRangeStart = 50915, XrefRangeEnd = 50937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int gmatch_aux(LuaState L, KopiLua_StringLib.GMatchAuxData auxdata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(auxdata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_gmatch_aux_Private_Static_Int32_LuaState_GMatchAuxData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0006D3B4 File Offset: 0x0006B5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50938, XrefRangeEnd = 50952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue gmatch_aux_2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_gmatch_aux_2_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0006D40C File Offset: 0x0006B60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50952, XrefRangeEnd = 50995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_gmatch(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_gmatch_Public_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0006D450 File Offset: 0x0006B650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50995, XrefRangeEnd = 51008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int gfind_nodef(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_gfind_nodef_Private_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0006D494 File Offset: 0x0006B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51008, XrefRangeEnd = 51033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_s(KopiLua_StringLib.MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_add_s_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0006D500 File Offset: 0x0006B700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51061, RefRangeEnd = 51062, XrefRangeStart = 51033, XrefRangeEnd = 51061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_value(KopiLua_StringLib.MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_add_value_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0006D56C File Offset: 0x0006B76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51062, XrefRangeEnd = 51112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_gsub(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_gsub_Public_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0006D5B0 File Offset: 0x0006B7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51146, RefRangeEnd = 51147, XrefRangeStart = 51112, XrefRangeEnd = 51146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void addquoted(LuaState L, LuaLBuffer b, int arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_addquoted_Private_Static_Void_LuaState_LuaLBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0006D608 File Offset: 0x0006B808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51192, RefRangeEnd = 51193, XrefRangeStart = 51147, XrefRangeEnd = 51192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr scanformat(LuaState L, CharPtr strfrmt, CharPtr form)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strfrmt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(form);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_scanformat_Private_Static_CharPtr_LuaState_CharPtr_CharPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0006D670 File Offset: 0x0006B870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51206, RefRangeEnd = 51208, XrefRangeStart = 51193, XrefRangeEnd = 51206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void addintlen(CharPtr form)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(form);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_addintlen_Private_Static_Void_CharPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51208, XrefRangeEnd = 51308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int str_format(LuaState L)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_str_format_Public_Static_Int32_LuaState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51308, XrefRangeEnd = 51320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PatchPattern(string charPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charPtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.NativeMethodInfoPtr_PatchPattern_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00008282 File Offset: 0x00006482
		public KopiLua_StringLib(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0006D728 File Offset: 0x0006B928
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x0000828B File Offset: 0x0000648B
		public unsafe static int LUA_MAXCAPTURES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_LUA_MAXCAPTURES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_LUA_MAXCAPTURES, (void*)(&value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0006D744 File Offset: 0x0006B944
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00008299 File Offset: 0x00006499
		public unsafe static int CAP_UNFINISHED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_CAP_UNFINISHED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_CAP_UNFINISHED, (void*)(&value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0006D760 File Offset: 0x0006B960
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x000082A7 File Offset: 0x000064A7
		public unsafe static int CAP_POSITION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_CAP_POSITION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_CAP_POSITION, (void*)(&value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0006D77C File Offset: 0x0006B97C
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000082B5 File Offset: 0x000064B5
		public unsafe static int MAXCCALLS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_MAXCCALLS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_MAXCCALLS, (void*)(&value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0006D798 File Offset: 0x0006B998
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000082C3 File Offset: 0x000064C3
		public unsafe static char L_ESC
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_L_ESC, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_L_ESC, (void*)(&value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0006D7B4 File Offset: 0x0006B9B4
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x000082D1 File Offset: 0x000064D1
		public unsafe static string SPECIALS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_SPECIALS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_SPECIALS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0006D7D4 File Offset: 0x0006B9D4
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x000082E3 File Offset: 0x000064E3
		public unsafe static int MAX_ITEM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_MAX_ITEM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_MAX_ITEM, (void*)(&value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000082F1 File Offset: 0x000064F1
		public unsafe static string FLAGS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_FLAGS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_FLAGS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0006D810 File Offset: 0x0006BA10
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x00008303 File Offset: 0x00006503
		public unsafe static int MAX_FORMAT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(KopiLua_StringLib.NativeFieldInfoPtr_MAX_FORMAT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KopiLua_StringLib.NativeFieldInfoPtr_MAX_FORMAT, (void*)(&value));
			}
		}

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeFieldInfoPtr_LUA_MAXCAPTURES;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeFieldInfoPtr_CAP_UNFINISHED;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_CAP_POSITION;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_MAXCCALLS;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_L_ESC;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_SPECIALS;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ITEM;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_FLAGS;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_MAX_FORMAT;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_posrelat_Private_Static_Int32_Int32_UInt32_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_check_capture_Private_Static_Int32_MatchState_Int32_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_capture_to_close_Private_Static_Int32_MatchState_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_classend_Private_Static_CharPtr_MatchState_CharPtr_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_match_class_Private_Static_Int32_Char_Char_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_matchbracketclass_Private_Static_Int32_Int32_CharPtr_CharPtr_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_singlematch_Private_Static_Int32_Int32_CharPtr_CharPtr_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_matchbalance_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_max_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_min_expand_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_CharPtr_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_start_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_Int32_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_end_capture_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_match_capture_Private_Static_CharPtr_MatchState_CharPtr_Int32_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_match_Private_Static_CharPtr_MatchState_CharPtr_CharPtr_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_lmemfind_Private_Static_CharPtr_CharPtr_UInt32_CharPtr_UInt32_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_push_onecapture_Private_Static_Void_MatchState_Int32_CharPtr_CharPtr_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_push_captures_Private_Static_Int32_MatchState_CharPtr_CharPtr_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_str_find_aux_Private_Static_Int32_LuaState_Int32_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_str_find_Public_Static_Int32_LuaState_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_str_match_Public_Static_Int32_LuaState_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_gmatch_aux_Private_Static_Int32_LuaState_GMatchAuxData_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_gmatch_aux_2_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_str_gmatch_Public_Static_Int32_LuaState_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_gfind_nodef_Private_Static_Int32_LuaState_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_add_s_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_add_value_Private_Static_Void_MatchState_LuaLBuffer_CharPtr_CharPtr_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_str_gsub_Public_Static_Int32_LuaState_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_addquoted_Private_Static_Void_LuaState_LuaLBuffer_Int32_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_scanformat_Private_Static_CharPtr_LuaState_CharPtr_CharPtr_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_addintlen_Private_Static_Void_CharPtr_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_str_format_Public_Static_Int32_LuaState_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_PatchPattern_Private_Static_String_String_0;

		// Token: 0x020001EE RID: 494
		public class MatchState : Object
		{
			// Token: 0x06001DB6 RID: 7606 RVA: 0x0008D788 File Offset: 0x0008B988
			// Note: this type is marked as 'beforefieldinit'.
			static MatchState()
			{
				Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "MatchState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr);
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_matchdepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "matchdepth");
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "src_init");
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "src_end");
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "L");
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "level");
				KopiLua_StringLib.MatchState.NativeFieldInfoPtr_capture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "capture");
				KopiLua_StringLib.MatchState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, 100667051);
			}

			// Token: 0x06001DB7 RID: 7607 RVA: 0x0008D840 File Offset: 0x0008BA40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 50492, RefRangeEnd = 50494, XrefRangeStart = 50481, XrefRangeEnd = 50492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.MatchState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB8 RID: 7608 RVA: 0x0000BC2E File Offset: 0x00009E2E
			public MatchState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0008D87C File Offset: 0x0008BA7C
			// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0000BC37 File Offset: 0x00009E37
			public unsafe int matchdepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_matchdepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_matchdepth)) = value;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
			// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000BC52 File Offset: 0x00009E52
			public unsafe CharPtr src_init
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_init);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_init), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0008D8D4 File Offset: 0x0008BAD4
			// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0000BC71 File Offset: 0x00009E71
			public unsafe CharPtr src_end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_end);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_src_end), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0008D904 File Offset: 0x0008BB04
			// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0000BC90 File Offset: 0x00009E90
			public unsafe LuaState L
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_L);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_L), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0008D934 File Offset: 0x0008BB34
			// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0000BCAF File Offset: 0x00009EAF
			public unsafe int level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0008D95C File Offset: 0x0008BB5C
			// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0000BCCA File Offset: 0x00009ECA
			public unsafe Il2CppReferenceArray<KopiLua_StringLib.MatchState.capture_> capture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_capture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KopiLua_StringLib.MatchState.capture_>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.NativeFieldInfoPtr_capture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeFieldInfoPtr_matchdepth;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeFieldInfoPtr_src_init;

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeFieldInfoPtr_src_end;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeFieldInfoPtr_L;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeFieldInfoPtr_capture;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000250 RID: 592
			public class capture_ : Object
			{
				// Token: 0x0600217B RID: 8571 RVA: 0x000982CC File Offset: 0x000964CC
				// Note: this type is marked as 'beforefieldinit'.
				static capture_()
				{
					Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KopiLua_StringLib.MatchState>.NativeClassPtr, "capture_");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr);
					KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr, "init");
					KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr, "len");
					KopiLua_StringLib.MatchState.capture_.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr, 100667052);
				}

				// Token: 0x0600217C RID: 8572 RVA: 0x00098334 File Offset: 0x00096534
				[CallerCount(2275)]
				[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe capture_()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KopiLua_StringLib.MatchState.capture_>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.MatchState.capture_.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600217D RID: 8573 RVA: 0x0000DFF6 File Offset: 0x0000C1F6
				public capture_(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000791 RID: 1937
				// (get) Token: 0x0600217E RID: 8574 RVA: 0x00098370 File Offset: 0x00096570
				// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000DFFF File Offset: 0x0000C1FF
				public unsafe CharPtr init
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_init);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_init), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000792 RID: 1938
				// (get) Token: 0x06002180 RID: 8576 RVA: 0x000983A0 File Offset: 0x000965A0
				// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000E01E File Offset: 0x0000C21E
				public unsafe int len
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_len);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.MatchState.capture_.NativeFieldInfoPtr_len)) = value;
					}
				}

				// Token: 0x04001986 RID: 6534
				private static readonly IntPtr NativeFieldInfoPtr_init;

				// Token: 0x04001987 RID: 6535
				private static readonly IntPtr NativeFieldInfoPtr_len;

				// Token: 0x04001988 RID: 6536
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x020001EF RID: 495
		public class GMatchAuxData : Object
		{
			// Token: 0x06001DC5 RID: 7621 RVA: 0x0008D98C File Offset: 0x0008BB8C
			// Note: this type is marked as 'beforefieldinit'.
			static GMatchAuxData()
			{
				Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "GMatchAuxData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr);
				KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr, "S");
				KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr, "P");
				KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_LS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr, "LS");
				KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_POS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr, "POS");
				KopiLua_StringLib.GMatchAuxData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr, 100667053);
			}

			// Token: 0x06001DC6 RID: 7622 RVA: 0x0008DA1C File Offset: 0x0008BC1C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GMatchAuxData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KopiLua_StringLib.GMatchAuxData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.GMatchAuxData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DC7 RID: 7623 RVA: 0x0000BCE9 File Offset: 0x00009EE9
			public GMatchAuxData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0008DA58 File Offset: 0x0008BC58
			// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000BCF2 File Offset: 0x00009EF2
			public unsafe CharPtr S
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_S);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_S), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0008DA88 File Offset: 0x0008BC88
			// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0000BD11 File Offset: 0x00009F11
			public unsafe CharPtr P
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_P);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008DAB8 File Offset: 0x0008BCB8
			// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000BD30 File Offset: 0x00009F30
			public unsafe uint LS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_LS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_LS)) = value;
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0008DAE0 File Offset: 0x0008BCE0
			// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0000BD4B File Offset: 0x00009F4B
			public unsafe uint POS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_POS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.GMatchAuxData.NativeFieldInfoPtr_POS)) = value;
				}
			}

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeFieldInfoPtr_S;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr_P;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeFieldInfoPtr_LS;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeFieldInfoPtr_POS;

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F0 RID: 496
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x06001DD0 RID: 7632 RVA: 0x0008DB08 File Offset: 0x0008BD08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KopiLua_StringLib>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr);
				KopiLua_StringLib.__c__DisplayClass29_0.NativeFieldInfoPtr_executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr, "executionContext");
				KopiLua_StringLib.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr, 100667054);
				KopiLua_StringLib.__c__DisplayClass29_0.NativeMethodInfoPtr__gmatch_aux_2_b__0_Internal_Int32_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr, 100667055);
			}

			// Token: 0x06001DD1 RID: 7633 RVA: 0x0008DB70 File Offset: 0x0008BD70
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KopiLua_StringLib.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD2 RID: 7634 RVA: 0x0008DBAC File Offset: 0x0008BDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50494, XrefRangeEnd = 50510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _gmatch_aux_2_b__0(LuaState L)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(L);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KopiLua_StringLib.__c__DisplayClass29_0.NativeMethodInfoPtr__gmatch_aux_2_b__0_Internal_Int32_LuaState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DD3 RID: 7635 RVA: 0x0000BD66 File Offset: 0x00009F66
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0008DBFC File Offset: 0x0008BDFC
			// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000BD6F File Offset: 0x00009F6F
			public unsafe ScriptExecutionContext executionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.__c__DisplayClass29_0.NativeFieldInfoPtr_executionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KopiLua_StringLib.__c__DisplayClass29_0.NativeFieldInfoPtr_executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeFieldInfoPtr_executionContext;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr__gmatch_aux_2_b__0_Internal_Int32_LuaState_0;
		}
	}
}
