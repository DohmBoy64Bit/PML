using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000028 RID: 40
	public sealed class CallbackFunction : RefIdObject
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0002BE04 File Offset: 0x0002A004
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackFunction()
		{
			Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "CallbackFunction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr);
			CallbackFunction.NativeFieldInfoPtr_m_DefaultAccessMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, "m_DefaultAccessMode");
			CallbackFunction.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, "<Name>k__BackingField");
			CallbackFunction.NativeFieldInfoPtr__ClrCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, "<ClrCallback>k__BackingField");
			CallbackFunction.NativeFieldInfoPtr__AdditionalData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, "<AdditionalData>k__BackingField");
			CallbackFunction.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664442);
			CallbackFunction.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664443);
			CallbackFunction.NativeMethodInfoPtr_get_ClrCallback_Public_get_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664444);
			CallbackFunction.NativeMethodInfoPtr_set_ClrCallback_Private_set_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664445);
			CallbackFunction.NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664448);
			CallbackFunction.NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664449);
			CallbackFunction.NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664452);
			CallbackFunction.NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664453);
			CallbackFunction.NativeMethodInfoPtr__ctor_Public_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664446);
			CallbackFunction.NativeMethodInfoPtr_Invoke_Public_DynValue_ScriptExecutionContext_IList_1_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664447);
			CallbackFunction.NativeMethodInfoPtr_FromDelegate_Public_Static_CallbackFunction_Script_Delegate_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664450);
			CallbackFunction.NativeMethodInfoPtr_FromMethodInfo_Public_Static_CallbackFunction_Script_MethodInfo_Object_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664451);
			CallbackFunction.NativeMethodInfoPtr_CheckCallbackSignature_Public_Static_Boolean_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr, 100664454);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0002BF88 File Offset: 0x0002A188
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0002BFC0 File Offset: 0x0002A1C0
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21273, XrefRangeEnd = 21274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0002C004 File Offset: 0x0002A204
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0002C044 File Offset: 0x0002A244
		public unsafe Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_get_ClrCallback_Public_get_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21289, XrefRangeEnd = 21290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_set_ClrCallback_Private_set_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0002C088 File Offset: 0x0002A288
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		public unsafe static InteropAccessMode DefaultAccessMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21298, XrefRangeEnd = 21302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21302, XrefRangeEnd = 21306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0002C134 File Offset: 0x0002A334
		public unsafe Object AdditionalData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21309, XrefRangeEnd = 21310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0002C178 File Offset: 0x0002A378
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 21315, RefRangeEnd = 21324, XrefRangeStart = 21310, XrefRangeEnd = 21315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackFunction(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr__ctor_Public_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21339, RefRangeEnd = 21341, XrefRangeStart = 21324, XrefRangeEnd = 21339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMethodCall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_Invoke_Public_DynValue_ScriptExecutionContext_IList_1_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0002C248 File Offset: 0x0002A448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21352, RefRangeEnd = 21353, XrefRangeStart = 21341, XrefRangeEnd = 21352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(del);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_FromDelegate_Public_Static_CallbackFunction_Script_Delegate_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21363, RefRangeEnd = 21364, XrefRangeStart = 21353, XrefRangeEnd = 21363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, Object obj = null, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_FromMethodInfo_Public_Static_CallbackFunction_Script_MethodInfo_Object_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0002C32C File Offset: 0x0002A52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21382, RefRangeEnd = 21383, XrefRangeStart = 21364, XrefRangeEnd = 21382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requirePublicVisibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackFunction.NativeMethodInfoPtr_CheckCallbackSignature_Public_Static_Boolean_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00003696 File Offset: 0x00001896
		public CallbackFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0002C37C File Offset: 0x0002A57C
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0000369F File Offset: 0x0000189F
		public unsafe static InteropAccessMode m_DefaultAccessMode
		{
			get
			{
				InteropAccessMode interopAccessMode;
				IL2CPP.il2cpp_field_static_get_value(CallbackFunction.NativeFieldInfoPtr_m_DefaultAccessMode, (void*)(&interopAccessMode));
				return interopAccessMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackFunction.NativeFieldInfoPtr_m_DefaultAccessMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0002C398 File Offset: 0x0002A598
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000036B1 File Offset: 0x000018B1
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x000036D0 File Offset: 0x000018D0
		public unsafe Func<ScriptExecutionContext, CallbackArguments, DynValue> _ClrCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__ClrCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__ClrCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x000036EF File Offset: 0x000018EF
		public unsafe Object _AdditionalData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__AdditionalData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackFunction.NativeFieldInfoPtr__AdditionalData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultAccessMode;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr__ClrCallback_k__BackingField;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalData_k__BackingField;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_get_ClrCallback_Public_get_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_set_ClrCallback_Private_set_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_String_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_DynValue_ScriptExecutionContext_IList_1_DynValue_Boolean_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_FromDelegate_Public_Static_CallbackFunction_Script_Delegate_InteropAccessMode_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_FromMethodInfo_Public_Static_CallbackFunction_Script_MethodInfo_Object_InteropAccessMode_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_CheckCallbackSignature_Public_Static_Boolean_MethodInfo_Boolean_0;
	}
}
