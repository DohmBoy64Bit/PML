using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000059 RID: 89
	public class ScriptOptions : Object
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x00039440 File Offset: 0x00037640
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptOptions()
		{
			Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr);
			ScriptOptions.NativeFieldInfoPtr__ScriptLoader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<ScriptLoader>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__DebugPrint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<DebugPrint>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__DebugInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<DebugInput>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__UseLuaErrorLocations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<UseLuaErrorLocations>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__ColonOperatorClrCallbackBehaviour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<ColonOperatorClrCallbackBehaviour>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__Stdin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<Stdin>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__Stdout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<Stdout>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__Stderr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<Stderr>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__TailCallOptimizationThreshold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<TailCallOptimizationThreshold>k__BackingField");
			ScriptOptions.NativeFieldInfoPtr__CheckThreadAccess_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, "<CheckThreadAccess>k__BackingField");
			ScriptOptions.NativeMethodInfoPtr_get_ScriptLoader_Public_get_IScriptLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665016);
			ScriptOptions.NativeMethodInfoPtr_set_ScriptLoader_Public_set_Void_IScriptLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665017);
			ScriptOptions.NativeMethodInfoPtr_get_DebugPrint_Public_get_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665018);
			ScriptOptions.NativeMethodInfoPtr_set_DebugPrint_Public_set_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665019);
			ScriptOptions.NativeMethodInfoPtr_get_DebugInput_Public_get_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665020);
			ScriptOptions.NativeMethodInfoPtr_set_DebugInput_Public_set_Void_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665021);
			ScriptOptions.NativeMethodInfoPtr_get_UseLuaErrorLocations_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665022);
			ScriptOptions.NativeMethodInfoPtr_set_UseLuaErrorLocations_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665023);
			ScriptOptions.NativeMethodInfoPtr_get_ColonOperatorClrCallbackBehaviour_Public_get_ColonOperatorBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665024);
			ScriptOptions.NativeMethodInfoPtr_set_ColonOperatorClrCallbackBehaviour_Public_set_Void_ColonOperatorBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665025);
			ScriptOptions.NativeMethodInfoPtr_get_Stdin_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665026);
			ScriptOptions.NativeMethodInfoPtr_set_Stdin_Public_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665027);
			ScriptOptions.NativeMethodInfoPtr_get_Stdout_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665028);
			ScriptOptions.NativeMethodInfoPtr_set_Stdout_Public_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665029);
			ScriptOptions.NativeMethodInfoPtr_get_Stderr_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665030);
			ScriptOptions.NativeMethodInfoPtr_set_Stderr_Public_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665031);
			ScriptOptions.NativeMethodInfoPtr_get_TailCallOptimizationThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665032);
			ScriptOptions.NativeMethodInfoPtr_set_TailCallOptimizationThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665033);
			ScriptOptions.NativeMethodInfoPtr_get_CheckThreadAccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665034);
			ScriptOptions.NativeMethodInfoPtr_set_CheckThreadAccess_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665035);
			ScriptOptions.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665014);
			ScriptOptions.NativeMethodInfoPtr__ctor_Internal_Void_ScriptOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr, 100665015);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000396F0 File Offset: 0x000378F0
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00039730 File Offset: 0x00037930
		public unsafe IScriptLoader ScriptLoader
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_ScriptLoader_Public_get_IScriptLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptLoader>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_ScriptLoader_Public_set_Void_IScriptLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00039774 File Offset: 0x00037974
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x000397B4 File Offset: 0x000379B4
		public unsafe Action<string> DebugPrint
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_DebugPrint_Public_get_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_DebugPrint_Public_set_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x000397F8 File Offset: 0x000379F8
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00039838 File Offset: 0x00037A38
		public unsafe Func<string, string> DebugInput
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_DebugInput_Public_get_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_DebugInput_Public_set_Void_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0003987C File Offset: 0x00037A7C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000398B8 File Offset: 0x00037AB8
		public unsafe bool UseLuaErrorLocations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_UseLuaErrorLocations_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_UseLuaErrorLocations_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x000398F8 File Offset: 0x00037AF8
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00039938 File Offset: 0x00037B38
		public unsafe ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28412, RefRangeEnd = 28413, XrefRangeStart = 28412, XrefRangeEnd = 28412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_ColonOperatorClrCallbackBehaviour_Public_get_ColonOperatorBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColonOperatorBehaviour>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28413, RefRangeEnd = 28414, XrefRangeStart = 28413, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_ColonOperatorClrCallbackBehaviour_Public_set_Void_ColonOperatorBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0003997C File Offset: 0x00037B7C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000399BC File Offset: 0x00037BBC
		public unsafe Stream Stdin
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_Stdin_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_Stdin_Public_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00039A00 File Offset: 0x00037C00
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00039A40 File Offset: 0x00037C40
		public unsafe Stream Stdout
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_Stdout_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28414, XrefRangeEnd = 28415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_Stdout_Public_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00039A84 File Offset: 0x00037C84
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00039AC4 File Offset: 0x00037CC4
		public unsafe Stream Stderr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_Stderr_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_Stderr_Public_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00039B08 File Offset: 0x00037D08
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00039B44 File Offset: 0x00037D44
		public unsafe int TailCallOptimizationThreshold
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_TailCallOptimizationThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_TailCallOptimizationThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00039B84 File Offset: 0x00037D84
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00039BC0 File Offset: 0x00037DC0
		public unsafe bool CheckThreadAccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_get_CheckThreadAccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr_set_CheckThreadAccess_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00039C00 File Offset: 0x00037E00
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00039C3C File Offset: 0x00037E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28418, XrefRangeEnd = 28425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptOptions(ScriptOptions defaults)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaults);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptOptions.NativeMethodInfoPtr__ctor_Internal_Void_ScriptOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000045B7 File Offset: 0x000027B7
		public ScriptOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00039C88 File Offset: 0x00037E88
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x000045C0 File Offset: 0x000027C0
		public unsafe IScriptLoader _ScriptLoader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__ScriptLoader_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScriptLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__ScriptLoader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00039CB8 File Offset: 0x00037EB8
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x000045DF File Offset: 0x000027DF
		public unsafe Action<string> _DebugPrint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__DebugPrint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__DebugPrint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00039CE8 File Offset: 0x00037EE8
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x000045FE File Offset: 0x000027FE
		public unsafe Func<string, string> _DebugInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__DebugInput_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__DebugInput_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00039D18 File Offset: 0x00037F18
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0000461D File Offset: 0x0000281D
		public unsafe bool _UseLuaErrorLocations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__UseLuaErrorLocations_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__UseLuaErrorLocations_k__BackingField)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00039D40 File Offset: 0x00037F40
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00004638 File Offset: 0x00002838
		public unsafe ColonOperatorBehaviour _ColonOperatorClrCallbackBehaviour_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__ColonOperatorClrCallbackBehaviour_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColonOperatorBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__ColonOperatorClrCallbackBehaviour_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00039D70 File Offset: 0x00037F70
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00004657 File Offset: 0x00002857
		public unsafe Stream _Stdin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stdin_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stdin_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00039DA0 File Offset: 0x00037FA0
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00004676 File Offset: 0x00002876
		public unsafe Stream _Stdout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stdout_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stdout_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00039DD0 File Offset: 0x00037FD0
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00004695 File Offset: 0x00002895
		public unsafe Stream _Stderr_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stderr_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__Stderr_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00039E00 File Offset: 0x00038000
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x000046B4 File Offset: 0x000028B4
		public unsafe int _TailCallOptimizationThreshold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__TailCallOptimizationThreshold_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__TailCallOptimizationThreshold_k__BackingField)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00039E28 File Offset: 0x00038028
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x000046CF File Offset: 0x000028CF
		public unsafe bool _CheckThreadAccess_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__CheckThreadAccess_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptOptions.NativeFieldInfoPtr__CheckThreadAccess_k__BackingField)) = value;
			}
		}

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr__ScriptLoader_k__BackingField;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr__DebugPrint_k__BackingField;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr__DebugInput_k__BackingField;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeFieldInfoPtr__UseLuaErrorLocations_k__BackingField;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeFieldInfoPtr__ColonOperatorClrCallbackBehaviour_k__BackingField;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeFieldInfoPtr__Stdin_k__BackingField;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr__Stdout_k__BackingField;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr__Stderr_k__BackingField;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr__TailCallOptimizationThreshold_k__BackingField;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr__CheckThreadAccess_k__BackingField;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_get_ScriptLoader_Public_get_IScriptLoader_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_set_ScriptLoader_Public_set_Void_IScriptLoader_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugPrint_Public_get_Action_1_String_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugPrint_Public_set_Void_Action_1_String_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugInput_Public_get_Func_2_String_String_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugInput_Public_set_Void_Func_2_String_String_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_get_UseLuaErrorLocations_Public_get_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_set_UseLuaErrorLocations_Public_set_Void_Boolean_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_ColonOperatorClrCallbackBehaviour_Public_get_ColonOperatorBehaviour_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_set_ColonOperatorClrCallbackBehaviour_Public_set_Void_ColonOperatorBehaviour_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_get_Stdin_Public_get_Stream_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_set_Stdin_Public_set_Void_Stream_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_get_Stdout_Public_get_Stream_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_set_Stdout_Public_set_Void_Stream_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_get_Stderr_Public_get_Stream_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_set_Stderr_Public_set_Void_Stream_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_get_TailCallOptimizationThreshold_Public_get_Int32_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_set_TailCallOptimizationThreshold_Public_set_Void_Int32_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckThreadAccess_Public_get_Boolean_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckThreadAccess_Public_set_Void_Boolean_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ScriptOptions_0;
	}
}
