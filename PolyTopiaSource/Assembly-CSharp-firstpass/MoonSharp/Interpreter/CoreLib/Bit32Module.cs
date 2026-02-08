using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000109 RID: 265
	public class Bit32Module : Object
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x000675E4 File Offset: 0x000657E4
		// Note: this type is marked as 'beforefieldinit'.
		static Bit32Module()
		{
			Il2CppClassPointerStore<Bit32Module>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "Bit32Module");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr);
			Bit32Module.NativeFieldInfoPtr_MASKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, "MASKS");
			Bit32Module.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666802);
			Bit32Module.NativeMethodInfoPtr_ToUInt32_Private_Static_UInt32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666785);
			Bit32Module.NativeMethodInfoPtr_ToInt32_Private_Static_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666786);
			Bit32Module.NativeMethodInfoPtr_NBitMask_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666787);
			Bit32Module.NativeMethodInfoPtr_Bitwise_Public_Static_UInt32_String_CallbackArguments_Func_3_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666788);
			Bit32Module.NativeMethodInfoPtr_extract_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666789);
			Bit32Module.NativeMethodInfoPtr_replace_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666790);
			Bit32Module.NativeMethodInfoPtr_ValidatePosWidth_Private_Static_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666791);
			Bit32Module.NativeMethodInfoPtr_arshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666792);
			Bit32Module.NativeMethodInfoPtr_rshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666793);
			Bit32Module.NativeMethodInfoPtr_lshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666794);
			Bit32Module.NativeMethodInfoPtr_band_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666795);
			Bit32Module.NativeMethodInfoPtr_btest_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666796);
			Bit32Module.NativeMethodInfoPtr_bor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666797);
			Bit32Module.NativeMethodInfoPtr_bnot_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666798);
			Bit32Module.NativeMethodInfoPtr_bxor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666799);
			Bit32Module.NativeMethodInfoPtr_lrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666800);
			Bit32Module.NativeMethodInfoPtr_rrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, 100666801);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00067790 File Offset: 0x00065990
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bit32Module()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x000677CC File Offset: 0x000659CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46939, XrefRangeEnd = 46944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(DynValue v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_ToUInt32_Private_Static_UInt32_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00067810 File Offset: 0x00065A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46944, XrefRangeEnd = 46949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(DynValue v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_ToInt32_Private_Static_Int32_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00067854 File Offset: 0x00065A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46953, RefRangeEnd = 46955, XrefRangeStart = 46949, XrefRangeEnd = 46953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint NBitMask(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_NBitMask_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00067894 File Offset: 0x00065A94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 46975, RefRangeEnd = 46979, XrefRangeStart = 46955, XrefRangeEnd = 46975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Bitwise(string funcName, CallbackArguments args, Func<uint, uint, uint> accumFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accumFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_Bitwise_Public_Static_UInt32_String_CallbackArguments_Func_3_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000678FC File Offset: 0x00065AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46979, XrefRangeEnd = 47006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_extract_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00067954 File Offset: 0x00065B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47006, XrefRangeEnd = 47041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_replace_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000679AC File Offset: 0x00065BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47041, RefRangeEnd = 47043, XrefRangeStart = 47041, XrefRangeEnd = 47041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidatePosWidth(string func, int argPos, int pos, int width)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_ValidatePosWidth_Private_Static_Void_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00067A0C File Offset: 0x00065C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47043, XrefRangeEnd = 47062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_arshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00067A64 File Offset: 0x00065C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47062, XrefRangeEnd = 47082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_rshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00067ABC File Offset: 0x00065CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47082, XrefRangeEnd = 47102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_lshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00067B14 File Offset: 0x00065D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47102, XrefRangeEnd = 47127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_band_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00067B6C File Offset: 0x00065D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47127, XrefRangeEnd = 47152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_btest_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00067BC4 File Offset: 0x00065DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47152, XrefRangeEnd = 47177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_bor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00067C1C File Offset: 0x00065E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47177, XrefRangeEnd = 47194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_bnot_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00067C74 File Offset: 0x00065E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47194, XrefRangeEnd = 47219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_bxor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00067CCC File Offset: 0x00065ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47219, XrefRangeEnd = 47238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_lrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00067D24 File Offset: 0x00065F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47238, XrefRangeEnd = 47257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.NativeMethodInfoPtr_rrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0000814E File Offset: 0x0000634E
		public Bit32Module(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00067D7C File Offset: 0x00065F7C
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00008157 File Offset: 0x00006357
		public unsafe static Il2CppStructArray<uint> MASKS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Bit32Module.NativeFieldInfoPtr_MASKS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bit32Module.NativeFieldInfoPtr_MASKS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeFieldInfoPtr_MASKS;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Private_Static_UInt32_DynValue_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Private_Static_Int32_DynValue_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_NBitMask_Private_Static_UInt32_Int32_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_Bitwise_Public_Static_UInt32_String_CallbackArguments_Func_3_UInt32_UInt32_UInt32_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_extract_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_replace_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePosWidth_Private_Static_Void_String_Int32_Int32_Int32_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_arshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_rshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_lshift_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_band_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_btest_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_bor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_bnot_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_bxor_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_lrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_rrotate_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x020001E8 RID: 488
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.Bit32Module+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D3B RID: 7483 RVA: 0x0008BFA0 File Offset: 0x0008A1A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bit32Module>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr);
				Bit32Module.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, "<>9");
				Bit32Module.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, "<>9__11_0");
				Bit32Module.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, "<>9__12_0");
				Bit32Module.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, "<>9__13_0");
				Bit32Module.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, "<>9__15_0");
				Bit32Module.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, 100666805);
				Bit32Module.__c.NativeMethodInfoPtr__band_b__11_0_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, 100666806);
				Bit32Module.__c.NativeMethodInfoPtr__btest_b__12_0_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, 100666807);
				Bit32Module.__c.NativeMethodInfoPtr__bor_b__13_0_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, 100666808);
				Bit32Module.__c.NativeMethodInfoPtr__bxor_b__15_0_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr, 100666809);
			}

			// Token: 0x06001D3C RID: 7484 RVA: 0x0008C094 File Offset: 0x0008A294
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bit32Module.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D3D RID: 7485 RVA: 0x0008C0D0 File Offset: 0x0008A2D0
			[CallerCount(0)]
			public unsafe uint _band_b__11_0(uint x, uint y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.__c.NativeMethodInfoPtr__band_b__11_0_Internal_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D3E RID: 7486 RVA: 0x0008C128 File Offset: 0x0008A328
			[CallerCount(0)]
			public unsafe uint _btest_b__12_0(uint x, uint y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.__c.NativeMethodInfoPtr__btest_b__12_0_Internal_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D3F RID: 7487 RVA: 0x0008C180 File Offset: 0x0008A380
			[CallerCount(0)]
			public unsafe uint _bor_b__13_0(uint x, uint y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.__c.NativeMethodInfoPtr__bor_b__13_0_Internal_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D40 RID: 7488 RVA: 0x0008C1D8 File Offset: 0x0008A3D8
			[CallerCount(0)]
			public unsafe uint _bxor_b__15_0(uint x, uint y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bit32Module.__c.NativeMethodInfoPtr__bxor_b__15_0_Internal_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001D41 RID: 7489 RVA: 0x0000B937 File Offset: 0x00009B37
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0008C230 File Offset: 0x0008A430
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0000B940 File Offset: 0x00009B40
			public unsafe static Bit32Module.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bit32Module.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bit32Module.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bit32Module.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0008C258 File Offset: 0x0008A458
			// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0000B952 File Offset: 0x00009B52
			public unsafe static Func<uint, uint, uint> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bit32Module.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint, uint, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bit32Module.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0008C280 File Offset: 0x0008A480
			// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0000B964 File Offset: 0x00009B64
			public unsafe static Func<uint, uint, uint> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bit32Module.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint, uint, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bit32Module.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0008C2A8 File Offset: 0x0008A4A8
			// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0000B976 File Offset: 0x00009B76
			public unsafe static Func<uint, uint, uint> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bit32Module.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint, uint, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bit32Module.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
			// (set) Token: 0x06001D4B RID: 7499 RVA: 0x0000B988 File Offset: 0x00009B88
			public unsafe static Func<uint, uint, uint> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bit32Module.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint, uint, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bit32Module.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeMethodInfoPtr__band_b__11_0_Internal_UInt32_UInt32_UInt32_0;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeMethodInfoPtr__btest_b__12_0_Internal_UInt32_UInt32_UInt32_0;

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeMethodInfoPtr__bor_b__13_0_Internal_UInt32_UInt32_UInt32_0;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeMethodInfoPtr__bxor_b__15_0_Internal_UInt32_UInt32_UInt32_0;
		}
	}
}
