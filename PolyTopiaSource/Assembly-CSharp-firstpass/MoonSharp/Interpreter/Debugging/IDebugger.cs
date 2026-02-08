using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FC RID: 252
	public class IDebugger : Object
	{
		// Token: 0x06001300 RID: 4864 RVA: 0x00062CB0 File Offset: 0x00060EB0
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugger()
		{
			Il2CppClassPointerStore<IDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "IDebugger");
			IDebugger.NativeMethodInfoPtr_GetDebuggerCaps_Public_Abstract_Virtual_New_DebuggerCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666619);
			IDebugger.NativeMethodInfoPtr_SetDebugService_Public_Abstract_Virtual_New_Void_DebugService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666620);
			IDebugger.NativeMethodInfoPtr_SetSourceCode_Public_Abstract_Virtual_New_Void_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666621);
			IDebugger.NativeMethodInfoPtr_SetByteCode_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666622);
			IDebugger.NativeMethodInfoPtr_IsPauseRequested_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666623);
			IDebugger.NativeMethodInfoPtr_SignalRuntimeException_Public_Abstract_Virtual_New_Boolean_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666624);
			IDebugger.NativeMethodInfoPtr_GetAction_Public_Abstract_Virtual_New_DebuggerAction_Int32_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666625);
			IDebugger.NativeMethodInfoPtr_SignalExecutionEnded_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666626);
			IDebugger.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_WatchType_IEnumerable_1_WatchItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666627);
			IDebugger.NativeMethodInfoPtr_GetWatchItems_Public_Abstract_Virtual_New_List_1_DynamicExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666628);
			IDebugger.NativeMethodInfoPtr_RefreshBreakpoints_Public_Abstract_Virtual_New_Void_IEnumerable_1_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugger>.NativeClassPtr, 100666629);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00062DB4 File Offset: 0x00060FB4
		[CallerCount(0)]
		public unsafe virtual DebuggerCaps GetDebuggerCaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_GetDebuggerCaps_Public_Abstract_Virtual_New_DebuggerCaps_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebuggerCaps>(intPtr3) : null;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00062E00 File Offset: 0x00061000
		[CallerCount(0)]
		public unsafe virtual void SetDebugService(DebugService debugService)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugService);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_SetDebugService_Public_Abstract_Virtual_New_Void_DebugService_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00062E50 File Offset: 0x00061050
		[CallerCount(0)]
		public unsafe virtual void SetSourceCode(SourceCode sourceCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_SetSourceCode_Public_Abstract_Virtual_New_Void_SourceCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00062EA0 File Offset: 0x000610A0
		[CallerCount(0)]
		public unsafe virtual void SetByteCode(Il2CppStringArray byteCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_SetByteCode_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00062EF0 File Offset: 0x000610F0
		[CallerCount(0)]
		public unsafe virtual bool IsPauseRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_IsPauseRequested_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00062F38 File Offset: 0x00061138
		[CallerCount(0)]
		public unsafe virtual bool SignalRuntimeException(ScriptRuntimeException ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_SignalRuntimeException_Public_Abstract_Virtual_New_Boolean_ScriptRuntimeException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00062F90 File Offset: 0x00061190
		[CallerCount(0)]
		public unsafe virtual DebuggerAction GetAction(int ip, SourceRef sourceref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceref);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_GetAction_Public_Abstract_Virtual_New_DebuggerAction_Int32_SourceRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebuggerAction>(intPtr3) : null;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00062FFC File Offset: 0x000611FC
		[CallerCount(0)]
		public unsafe virtual void SignalExecutionEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_SignalExecutionEnded_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00063038 File Offset: 0x00061238
		[CallerCount(0)]
		public unsafe virtual void Update(WatchType watchType, IEnumerable<WatchItem> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(watchType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_WatchType_IEnumerable_1_WatchItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00063098 File Offset: 0x00061298
		[CallerCount(0)]
		public unsafe virtual List<DynamicExpression> GetWatchItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_GetWatchItems_Public_Abstract_Virtual_New_List_1_DynamicExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DynamicExpression>>(intPtr3) : null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000630E4 File Offset: 0x000612E4
		[CallerCount(0)]
		public unsafe virtual void RefreshBreakpoints(IEnumerable<SourceRef> refs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(refs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugger.NativeMethodInfoPtr_RefreshBreakpoints_Public_Abstract_Virtual_New_Void_IEnumerable_1_SourceRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00007D06 File Offset: 0x00005F06
		public IDebugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_GetDebuggerCaps_Public_Abstract_Virtual_New_DebuggerCaps_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugService_Public_Abstract_Virtual_New_Void_DebugService_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_SetSourceCode_Public_Abstract_Virtual_New_Void_SourceCode_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_SetByteCode_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_IsPauseRequested_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_SignalRuntimeException_Public_Abstract_Virtual_New_Boolean_ScriptRuntimeException_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Abstract_Virtual_New_DebuggerAction_Int32_SourceRef_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_SignalExecutionEnded_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_WatchType_IEnumerable_1_WatchItem_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_GetWatchItems_Public_Abstract_Virtual_New_List_1_DynamicExpression_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_RefreshBreakpoints_Public_Abstract_Virtual_New_Void_IEnumerable_1_SourceRef_0;
	}
}
