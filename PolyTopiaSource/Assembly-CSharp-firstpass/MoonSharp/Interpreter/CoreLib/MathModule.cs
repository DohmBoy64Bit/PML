using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000111 RID: 273
	public class MathModule : Object
	{
		// Token: 0x06001460 RID: 5216 RVA: 0x00069C00 File Offset: 0x00067E00
		// Note: this type is marked as 'beforefieldinit'.
		static MathModule()
		{
			Il2CppClassPointerStore<MathModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "MathModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathModule>.NativeClassPtr);
			MathModule.NativeFieldInfoPtr_pi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule>.NativeClassPtr, "pi");
			MathModule.NativeFieldInfoPtr_huge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule>.NativeClassPtr, "huge");
			MathModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666918);
			MathModule.NativeMethodInfoPtr_GetRandom_Private_Static_Random_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666884);
			MathModule.NativeMethodInfoPtr_SetRandom_Private_Static_Void_Script_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666885);
			MathModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666886);
			MathModule.NativeMethodInfoPtr_exec1_Private_Static_DynValue_CallbackArguments_String_Func_2_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666887);
			MathModule.NativeMethodInfoPtr_exec2_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666888);
			MathModule.NativeMethodInfoPtr_exec2n_Private_Static_DynValue_CallbackArguments_String_Double_Func_3_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666889);
			MathModule.NativeMethodInfoPtr_execaccum_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666890);
			MathModule.NativeMethodInfoPtr_abs_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666891);
			MathModule.NativeMethodInfoPtr_acos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666892);
			MathModule.NativeMethodInfoPtr_asin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666893);
			MathModule.NativeMethodInfoPtr_atan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666894);
			MathModule.NativeMethodInfoPtr_atan2_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666895);
			MathModule.NativeMethodInfoPtr_ceil_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666896);
			MathModule.NativeMethodInfoPtr_cos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666897);
			MathModule.NativeMethodInfoPtr_cosh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666898);
			MathModule.NativeMethodInfoPtr_deg_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666899);
			MathModule.NativeMethodInfoPtr_exp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666900);
			MathModule.NativeMethodInfoPtr_floor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666901);
			MathModule.NativeMethodInfoPtr_fmod_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666902);
			MathModule.NativeMethodInfoPtr_frexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666903);
			MathModule.NativeMethodInfoPtr_ldexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666904);
			MathModule.NativeMethodInfoPtr_log_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666905);
			MathModule.NativeMethodInfoPtr_max_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666906);
			MathModule.NativeMethodInfoPtr_min_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666907);
			MathModule.NativeMethodInfoPtr_modf_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666908);
			MathModule.NativeMethodInfoPtr_pow_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666909);
			MathModule.NativeMethodInfoPtr_rad_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666910);
			MathModule.NativeMethodInfoPtr_random_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666911);
			MathModule.NativeMethodInfoPtr_randomseed_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666912);
			MathModule.NativeMethodInfoPtr_sin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666913);
			MathModule.NativeMethodInfoPtr_sinh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666914);
			MathModule.NativeMethodInfoPtr_sqrt_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666915);
			MathModule.NativeMethodInfoPtr_tan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666916);
			MathModule.NativeMethodInfoPtr_tanh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule>.NativeClassPtr, 100666917);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00069F14 File Offset: 0x00068114
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MathModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MathModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00069F50 File Offset: 0x00068150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48507, XrefRangeEnd = 48514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Random GetRandom(Script s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_GetRandom_Private_Static_Random_Script_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Random>(intPtr3) : null;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00069F94 File Offset: 0x00068194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48528, RefRangeEnd = 48530, XrefRangeStart = 48514, XrefRangeEnd = 48528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRandom(Script s, Random random)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_SetRandom_Private_Static_Void_Script_Random_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00069FDC File Offset: 0x000681DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48530, XrefRangeEnd = 48536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoonSharpInit(Table globalTable, Table ioTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ioTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0006A024 File Offset: 0x00068224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48536, XrefRangeEnd = 48542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue exec1(CallbackArguments args, string funcName, Func<double, double> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_exec1_Private_Static_DynValue_CallbackArguments_String_Func_2_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0006A08C File Offset: 0x0006828C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 48549, RefRangeEnd = 48553, XrefRangeStart = 48542, XrefRangeEnd = 48549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue exec2(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_exec2_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0006A0F4 File Offset: 0x000682F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48553, XrefRangeEnd = 48561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue exec2n(CallbackArguments args, string funcName, double defVal, Func<double, double, double> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defVal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_exec2n_Private_Static_DynValue_CallbackArguments_String_Double_Func_3_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0006A16C File Offset: 0x0006836C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48580, RefRangeEnd = 48582, XrefRangeStart = 48561, XrefRangeEnd = 48580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue execaccum(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_execaccum_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0006A1D4 File Offset: 0x000683D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48582, XrefRangeEnd = 48605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue abs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_abs_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0006A22C File Offset: 0x0006842C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48605, XrefRangeEnd = 48628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue acos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_acos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0006A284 File Offset: 0x00068484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48628, XrefRangeEnd = 48651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue asin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_asin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0006A2DC File Offset: 0x000684DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48651, XrefRangeEnd = 48674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue atan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_atan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0006A334 File Offset: 0x00068534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48674, XrefRangeEnd = 48692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue atan2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_atan2_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0006A38C File Offset: 0x0006858C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48692, XrefRangeEnd = 48715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ceil(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_ceil_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0006A3E4 File Offset: 0x000685E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48715, XrefRangeEnd = 48738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue cos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_cos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0006A43C File Offset: 0x0006863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48738, XrefRangeEnd = 48761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue cosh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_cosh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0006A494 File Offset: 0x00068694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48761, XrefRangeEnd = 48784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue deg(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_deg_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0006A4EC File Offset: 0x000686EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48784, XrefRangeEnd = 48807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue exp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_exp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0006A544 File Offset: 0x00068744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48807, XrefRangeEnd = 48830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue floor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_floor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0006A59C File Offset: 0x0006879C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48830, XrefRangeEnd = 48848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue fmod(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_fmod_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0006A5F4 File Offset: 0x000687F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48848, XrefRangeEnd = 48871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue frexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_frexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0006A64C File Offset: 0x0006884C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48871, XrefRangeEnd = 48889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ldexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_ldexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0006A6A4 File Offset: 0x000688A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48889, XrefRangeEnd = 48915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue log(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_log_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006A6FC File Offset: 0x000688FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48915, XrefRangeEnd = 48933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue max(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_max_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0006A754 File Offset: 0x00068954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48933, XrefRangeEnd = 48951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue min(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_min_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0006A7AC File Offset: 0x000689AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48951, XrefRangeEnd = 48972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue modf(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_modf_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0006A804 File Offset: 0x00068A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48972, XrefRangeEnd = 48990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue pow(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_pow_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0006A85C File Offset: 0x00068A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48990, XrefRangeEnd = 49013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rad(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_rad_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0006A8B4 File Offset: 0x00068AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49013, XrefRangeEnd = 49036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue random(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_random_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0006A90C File Offset: 0x00068B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49036, XrefRangeEnd = 49052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue randomseed(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_randomseed_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0006A964 File Offset: 0x00068B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49052, XrefRangeEnd = 49075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue sin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_sin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0006A9BC File Offset: 0x00068BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49075, XrefRangeEnd = 49098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue sinh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_sinh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0006AA14 File Offset: 0x00068C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49098, XrefRangeEnd = 49121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue sqrt(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_sqrt_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0006AA6C File Offset: 0x00068C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49121, XrefRangeEnd = 49144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_tan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0006AAC4 File Offset: 0x00068CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49144, XrefRangeEnd = 49167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tanh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.NativeMethodInfoPtr_tanh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000081BA File Offset: 0x000063BA
		public MathModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0006AB1C File Offset: 0x00068D1C
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x000081C3 File Offset: 0x000063C3
		public unsafe static double pi
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(MathModule.NativeFieldInfoPtr_pi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathModule.NativeFieldInfoPtr_pi, (void*)(&value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0006AB38 File Offset: 0x00068D38
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x000081D1 File Offset: 0x000063D1
		public unsafe static double huge
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(MathModule.NativeFieldInfoPtr_huge, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathModule.NativeFieldInfoPtr_huge, (void*)(&value));
			}
		}

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_pi;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_huge;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Private_Static_Random_Script_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_SetRandom_Private_Static_Void_Script_Random_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_exec1_Private_Static_DynValue_CallbackArguments_String_Func_2_Double_Double_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_exec2_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_exec2n_Private_Static_DynValue_CallbackArguments_String_Double_Func_3_Double_Double_Double_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_execaccum_Private_Static_DynValue_CallbackArguments_String_Func_3_Double_Double_Double_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_abs_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_acos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_asin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_atan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_atan2_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_ceil_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_cos_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_cosh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_deg_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_exp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_floor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_fmod_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_frexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_ldexp_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_log_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_max_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_min_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_modf_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_pow_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_rad_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_random_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_randomseed_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_sin_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_sinh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_sqrt_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_tan_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_tanh_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x020001EB RID: 491
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.MathModule+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D59 RID: 7513 RVA: 0x0008C510 File Offset: 0x0008A710
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MathModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr);
				MathModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9");
				MathModule.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__9_0");
				MathModule.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__10_0");
				MathModule.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__11_0");
				MathModule.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__12_0");
				MathModule.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__13_0");
				MathModule.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__14_0");
				MathModule.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__15_0");
				MathModule.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__16_0");
				MathModule.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__17_0");
				MathModule.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__18_0");
				MathModule.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__19_0");
				MathModule.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__20_0");
				MathModule.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__22_0");
				MathModule.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__23_0");
				MathModule.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__24_0");
				MathModule.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__25_0");
				MathModule.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__27_0");
				MathModule.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__28_0");
				MathModule.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__31_0");
				MathModule.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__32_0");
				MathModule.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__33_0");
				MathModule.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__34_0");
				MathModule.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, "<>9__35_0");
				MathModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666920);
				MathModule.__c.NativeMethodInfoPtr__abs_b__9_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666921);
				MathModule.__c.NativeMethodInfoPtr__acos_b__10_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666922);
				MathModule.__c.NativeMethodInfoPtr__asin_b__11_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666923);
				MathModule.__c.NativeMethodInfoPtr__atan_b__12_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666924);
				MathModule.__c.NativeMethodInfoPtr__atan2_b__13_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666925);
				MathModule.__c.NativeMethodInfoPtr__ceil_b__14_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666926);
				MathModule.__c.NativeMethodInfoPtr__cos_b__15_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666927);
				MathModule.__c.NativeMethodInfoPtr__cosh_b__16_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666928);
				MathModule.__c.NativeMethodInfoPtr__deg_b__17_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666929);
				MathModule.__c.NativeMethodInfoPtr__exp_b__18_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666930);
				MathModule.__c.NativeMethodInfoPtr__floor_b__19_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666931);
				MathModule.__c.NativeMethodInfoPtr__fmod_b__20_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666932);
				MathModule.__c.NativeMethodInfoPtr__ldexp_b__22_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666933);
				MathModule.__c.NativeMethodInfoPtr__log_b__23_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666934);
				MathModule.__c.NativeMethodInfoPtr__max_b__24_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666935);
				MathModule.__c.NativeMethodInfoPtr__min_b__25_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666936);
				MathModule.__c.NativeMethodInfoPtr__pow_b__27_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666937);
				MathModule.__c.NativeMethodInfoPtr__rad_b__28_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666938);
				MathModule.__c.NativeMethodInfoPtr__sin_b__31_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666939);
				MathModule.__c.NativeMethodInfoPtr__sinh_b__32_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666940);
				MathModule.__c.NativeMethodInfoPtr__sqrt_b__33_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666941);
				MathModule.__c.NativeMethodInfoPtr__tan_b__34_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666942);
				MathModule.__c.NativeMethodInfoPtr__tanh_b__35_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr, 100666943);
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x0008C8FC File Offset: 0x0008AAFC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MathModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x0008C938 File Offset: 0x0008AB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48425, XrefRangeEnd = 48428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _abs_b__9_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__abs_b__9_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x0008C984 File Offset: 0x0008AB84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48428, XrefRangeEnd = 48432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _acos_b__10_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__acos_b__10_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48432, XrefRangeEnd = 48436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _asin_b__11_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__asin_b__11_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x0008CA1C File Offset: 0x0008AC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48436, XrefRangeEnd = 48440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _atan_b__12_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__atan_b__12_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D5F RID: 7519 RVA: 0x0008CA68 File Offset: 0x0008AC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48440, XrefRangeEnd = 48444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _atan2_b__13_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__atan2_b__13_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D60 RID: 7520 RVA: 0x0008CAC0 File Offset: 0x0008ACC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48444, XrefRangeEnd = 48448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _ceil_b__14_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__ceil_b__14_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x0008CB0C File Offset: 0x0008AD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48448, XrefRangeEnd = 48452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _cos_b__15_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__cos_b__15_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D62 RID: 7522 RVA: 0x0008CB58 File Offset: 0x0008AD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48452, XrefRangeEnd = 48456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _cosh_b__16_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__cosh_b__16_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D63 RID: 7523 RVA: 0x0008CBA4 File Offset: 0x0008ADA4
			[CallerCount(0)]
			public unsafe double _deg_b__17_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__deg_b__17_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D64 RID: 7524 RVA: 0x0008CBF0 File Offset: 0x0008ADF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48456, XrefRangeEnd = 48460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _exp_b__18_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__exp_b__18_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D65 RID: 7525 RVA: 0x0008CC3C File Offset: 0x0008AE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48460, XrefRangeEnd = 48464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _floor_b__19_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__floor_b__19_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D66 RID: 7526 RVA: 0x0008CC88 File Offset: 0x0008AE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48464, XrefRangeEnd = 48468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _fmod_b__20_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__fmod_b__20_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D67 RID: 7527 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48468, XrefRangeEnd = 48472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _ldexp_b__22_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__ldexp_b__22_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D68 RID: 7528 RVA: 0x0008CD38 File Offset: 0x0008AF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48472, XrefRangeEnd = 48476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _log_b__23_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__log_b__23_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D69 RID: 7529 RVA: 0x0008CD90 File Offset: 0x0008AF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48476, XrefRangeEnd = 48480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _max_b__24_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__max_b__24_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D6A RID: 7530 RVA: 0x0008CDE8 File Offset: 0x0008AFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48480, XrefRangeEnd = 48484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _min_b__25_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__min_b__25_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D6B RID: 7531 RVA: 0x0008CE40 File Offset: 0x0008B040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48484, XrefRangeEnd = 48488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _pow_b__27_0(double d1, double d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__pow_b__27_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D6C RID: 7532 RVA: 0x0008CE98 File Offset: 0x0008B098
			[CallerCount(0)]
			public unsafe double _rad_b__28_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__rad_b__28_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x0008CEE4 File Offset: 0x0008B0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48488, XrefRangeEnd = 48492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _sin_b__31_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__sin_b__31_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D6E RID: 7534 RVA: 0x0008CF30 File Offset: 0x0008B130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48492, XrefRangeEnd = 48496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _sinh_b__32_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__sinh_b__32_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D6F RID: 7535 RVA: 0x0008CF7C File Offset: 0x0008B17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48496, XrefRangeEnd = 48499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _sqrt_b__33_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__sqrt_b__33_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x0008CFC8 File Offset: 0x0008B1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48499, XrefRangeEnd = 48503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _tan_b__34_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__tan_b__34_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x0008D014 File Offset: 0x0008B214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48503, XrefRangeEnd = 48507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _tanh_b__35_0(double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathModule.__c.NativeMethodInfoPtr__tanh_b__35_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x0000B9EF File Offset: 0x00009BEF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0008D060 File Offset: 0x0008B260
			// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000B9F8 File Offset: 0x00009BF8
			public unsafe static MathModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MathModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0008D088 File Offset: 0x0008B288
			// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000BA0A File Offset: 0x00009C0A
			public unsafe static Func<double, double> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0008D0B0 File Offset: 0x0008B2B0
			// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0000BA1C File Offset: 0x00009C1C
			public unsafe static Func<double, double> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0008D0D8 File Offset: 0x0008B2D8
			// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0000BA2E File Offset: 0x00009C2E
			public unsafe static Func<double, double> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0008D100 File Offset: 0x0008B300
			// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0000BA40 File Offset: 0x00009C40
			public unsafe static Func<double, double> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0008D128 File Offset: 0x0008B328
			// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0000BA52 File Offset: 0x00009C52
			public unsafe static Func<double, double, double> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0008D150 File Offset: 0x0008B350
			// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0000BA64 File Offset: 0x00009C64
			public unsafe static Func<double, double> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0008D178 File Offset: 0x0008B378
			// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0000BA76 File Offset: 0x00009C76
			public unsafe static Func<double, double> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0008D1A0 File Offset: 0x0008B3A0
			// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0000BA88 File Offset: 0x00009C88
			public unsafe static Func<double, double> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0008D1C8 File Offset: 0x0008B3C8
			// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0000BA9A File Offset: 0x00009C9A
			public unsafe static Func<double, double> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0008D1F0 File Offset: 0x0008B3F0
			// (set) Token: 0x06001D88 RID: 7560 RVA: 0x0000BAAC File Offset: 0x00009CAC
			public unsafe static Func<double, double> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0008D218 File Offset: 0x0008B418
			// (set) Token: 0x06001D8A RID: 7562 RVA: 0x0000BABE File Offset: 0x00009CBE
			public unsafe static Func<double, double> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0008D240 File Offset: 0x0008B440
			// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0000BAD0 File Offset: 0x00009CD0
			public unsafe static Func<double, double, double> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0008D268 File Offset: 0x0008B468
			// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0000BAE2 File Offset: 0x00009CE2
			public unsafe static Func<double, double, double> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0008D290 File Offset: 0x0008B490
			// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0000BAF4 File Offset: 0x00009CF4
			public unsafe static Func<double, double, double> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
			// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0000BB06 File Offset: 0x00009D06
			public unsafe static Func<double, double, double> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
			// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000BB18 File Offset: 0x00009D18
			public unsafe static Func<double, double, double> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0008D308 File Offset: 0x0008B508
			// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000BB2A File Offset: 0x00009D2A
			public unsafe static Func<double, double, double> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0008D330 File Offset: 0x0008B530
			// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0000BB3C File Offset: 0x00009D3C
			public unsafe static Func<double, double> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0008D358 File Offset: 0x0008B558
			// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000BB4E File Offset: 0x00009D4E
			public unsafe static Func<double, double> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0008D380 File Offset: 0x0008B580
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000BB60 File Offset: 0x00009D60
			public unsafe static Func<double, double> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0008D3A8 File Offset: 0x0008B5A8
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000BB72 File Offset: 0x00009D72
			public unsafe static Func<double, double> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0008D3D0 File Offset: 0x0008B5D0
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000BB84 File Offset: 0x00009D84
			public unsafe static Func<double, double> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0008D3F8 File Offset: 0x0008B5F8
			// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0000BB96 File Offset: 0x00009D96
			public unsafe static Func<double, double> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MathModule.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MathModule.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400176A RID: 5994
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400176B RID: 5995
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400176C RID: 5996
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400176D RID: 5997
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04001771 RID: 6001
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04001772 RID: 6002
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04001773 RID: 6003
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04001774 RID: 6004
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04001779 RID: 6009
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeMethodInfoPtr__abs_b__9_0_Internal_Double_Double_0;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeMethodInfoPtr__acos_b__10_0_Internal_Double_Double_0;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeMethodInfoPtr__asin_b__11_0_Internal_Double_Double_0;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeMethodInfoPtr__atan_b__12_0_Internal_Double_Double_0;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeMethodInfoPtr__atan2_b__13_0_Internal_Double_Double_Double_0;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeMethodInfoPtr__ceil_b__14_0_Internal_Double_Double_0;

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeMethodInfoPtr__cos_b__15_0_Internal_Double_Double_0;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeMethodInfoPtr__cosh_b__16_0_Internal_Double_Double_0;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeMethodInfoPtr__deg_b__17_0_Internal_Double_Double_0;

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeMethodInfoPtr__exp_b__18_0_Internal_Double_Double_0;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeMethodInfoPtr__floor_b__19_0_Internal_Double_Double_0;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeMethodInfoPtr__fmod_b__20_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeMethodInfoPtr__ldexp_b__22_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeMethodInfoPtr__log_b__23_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeMethodInfoPtr__max_b__24_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeMethodInfoPtr__min_b__25_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeMethodInfoPtr__pow_b__27_0_Internal_Double_Double_Double_0;

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeMethodInfoPtr__rad_b__28_0_Internal_Double_Double_0;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeMethodInfoPtr__sin_b__31_0_Internal_Double_Double_0;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeMethodInfoPtr__sinh_b__32_0_Internal_Double_Double_0;

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeMethodInfoPtr__sqrt_b__33_0_Internal_Double_Double_0;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeMethodInfoPtr__tan_b__34_0_Internal_Double_Double_0;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeMethodInfoPtr__tanh_b__35_0_Internal_Double_Double_0;
		}
	}
}
