using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CC RID: 204
	public class LuaState : Object
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x00056154 File Offset: 0x00054354
		// Note: this type is marked as 'beforefieldinit'.
		static LuaState()
		{
			Il2CppClassPointerStore<LuaState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.LuaStateInterop", "LuaState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaState>.NativeClassPtr);
			LuaState.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaState>.NativeClassPtr, "m_Stack");
			LuaState.NativeFieldInfoPtr__ExecutionContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaState>.NativeClassPtr, "<ExecutionContext>k__BackingField");
			LuaState.NativeFieldInfoPtr__FunctionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaState>.NativeClassPtr, "<FunctionName>k__BackingField");
			LuaState.NativeMethodInfoPtr_get_ExecutionContext_Public_get_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666160);
			LuaState.NativeMethodInfoPtr_set_ExecutionContext_Private_set_Void_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666161);
			LuaState.NativeMethodInfoPtr_get_FunctionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666162);
			LuaState.NativeMethodInfoPtr_set_FunctionName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666163);
			LuaState.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666167);
			LuaState.NativeMethodInfoPtr__ctor_Internal_Void_ScriptExecutionContext_CallbackArguments_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666164);
			LuaState.NativeMethodInfoPtr_Top_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666165);
			LuaState.NativeMethodInfoPtr_At_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666166);
			LuaState.NativeMethodInfoPtr_Push_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666168);
			LuaState.NativeMethodInfoPtr_Pop_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666169);
			LuaState.NativeMethodInfoPtr_GetTopArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666170);
			LuaState.NativeMethodInfoPtr_GetReturnValue_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666171);
			LuaState.NativeMethodInfoPtr_Discard_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaState>.NativeClassPtr, 100666172);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000562C4 File Offset: 0x000544C4
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00056304 File Offset: 0x00054504
		public unsafe ScriptExecutionContext ExecutionContext
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_get_ExecutionContext_Public_get_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_set_ExecutionContext_Private_set_Void_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00056348 File Offset: 0x00054548
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00056380 File Offset: 0x00054580
		public unsafe string FunctionName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_get_FunctionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_set_FunctionName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000563C4 File Offset: 0x000545C4
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40336, XrefRangeEnd = 40337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00056400 File Offset: 0x00054600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40356, RefRangeEnd = 40357, XrefRangeStart = 40337, XrefRangeEnd = 40356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaState(ScriptExecutionContext executionContext, CallbackArguments args, string functionName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr__ctor_Internal_Void_ScriptExecutionContext_CallbackArguments_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00056470 File Offset: 0x00054670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40362, RefRangeEnd = 40363, XrefRangeStart = 40357, XrefRangeEnd = 40362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Top(int pos = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_Top_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000564BC File Offset: 0x000546BC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 40375, RefRangeEnd = 40393, XrefRangeStart = 40363, XrefRangeEnd = 40375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue At(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_At_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00056508 File Offset: 0x00054708
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 40399, RefRangeEnd = 40409, XrefRangeStart = 40393, XrefRangeEnd = 40399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(DynValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_Push_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0005654C File Offset: 0x0005474C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40417, RefRangeEnd = 40420, XrefRangeStart = 40409, XrefRangeEnd = 40417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_Pop_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0005658C File Offset: 0x0005478C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40428, RefRangeEnd = 40430, XrefRangeStart = 40420, XrefRangeEnd = 40428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DynValue> GetTopArray(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_GetTopArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000565D8 File Offset: 0x000547D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40442, RefRangeEnd = 40443, XrefRangeStart = 40430, XrefRangeEnd = 40442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetReturnValue(int retvals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref retvals;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_GetReturnValue_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00056624 File Offset: 0x00054824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40443, XrefRangeEnd = 40447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Discard(int nargs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nargs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaState.NativeMethodInfoPtr_Discard_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00006B8F File Offset: 0x00004D8F
		public LuaState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00056664 File Offset: 0x00054864
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00006B98 File Offset: 0x00004D98
		public unsafe List<DynValue> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00056694 File Offset: 0x00054894
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00006BB7 File Offset: 0x00004DB7
		public unsafe ScriptExecutionContext _ExecutionContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr__ExecutionContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr__ExecutionContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000566C4 File Offset: 0x000548C4
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00006BD6 File Offset: 0x00004DD6
		public unsafe string _FunctionName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr__FunctionName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaState.NativeFieldInfoPtr__FunctionName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr__ExecutionContext_k__BackingField;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr__FunctionName_k__BackingField;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionContext_Public_get_ScriptExecutionContext_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutionContext_Private_set_Void_ScriptExecutionContext_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_FunctionName_Public_get_String_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_set_FunctionName_Private_set_Void_String_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ScriptExecutionContext_CallbackArguments_String_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Top_Public_DynValue_Int32_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_At_Public_DynValue_Int32_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_DynValue_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_DynValue_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_GetTopArray_Public_Il2CppReferenceArray_1_DynValue_Int32_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnValue_Public_DynValue_Int32_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_Discard_Public_Void_Int32_0;
	}
}
