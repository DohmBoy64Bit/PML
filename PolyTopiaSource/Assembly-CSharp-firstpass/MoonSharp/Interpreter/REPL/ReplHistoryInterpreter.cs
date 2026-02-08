using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000085 RID: 133
	public class ReplHistoryInterpreter : ReplInterpreter
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00042458 File Offset: 0x00040658
		// Note: this type is marked as 'beforefieldinit'.
		static ReplHistoryInterpreter()
		{
			Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.REPL", "ReplHistoryInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr);
			ReplHistoryInterpreter.NativeFieldInfoPtr_m_History = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, "m_History");
			ReplHistoryInterpreter.NativeFieldInfoPtr_m_Last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, "m_Last");
			ReplHistoryInterpreter.NativeFieldInfoPtr_m_Navi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, "m_Navi");
			ReplHistoryInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Script_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, 100665289);
			ReplHistoryInterpreter.NativeMethodInfoPtr_Evaluate_Public_Virtual_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, 100665290);
			ReplHistoryInterpreter.NativeMethodInfoPtr_HistoryPrev_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, 100665291);
			ReplHistoryInterpreter.NativeMethodInfoPtr_HistoryNext_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr, 100665292);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00042514 File Offset: 0x00040714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32097, XrefRangeEnd = 32105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplHistoryInterpreter(Script script, int historySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplHistoryInterpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref historySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplHistoryInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Script_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00042570 File Offset: 0x00040770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32105, XrefRangeEnd = 32109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Evaluate(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplHistoryInterpreter.NativeMethodInfoPtr_Evaluate_Public_Virtual_DynValue_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000425CC File Offset: 0x000407CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32109, XrefRangeEnd = 32110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HistoryPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplHistoryInterpreter.NativeMethodInfoPtr_HistoryPrev_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00042604 File Offset: 0x00040804
		[CallerCount(0)]
		public unsafe string HistoryNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplHistoryInterpreter.NativeMethodInfoPtr_HistoryNext_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000057C7 File Offset: 0x000039C7
		public ReplHistoryInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0004263C File Offset: 0x0004083C
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000057D0 File Offset: 0x000039D0
		public unsafe Il2CppStringArray m_History
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_History);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_History), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0004266C File Offset: 0x0004086C
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000057EF File Offset: 0x000039EF
		public unsafe int m_Last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_Last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_Last)) = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00042694 File Offset: 0x00040894
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0000580A File Offset: 0x00003A0A
		public unsafe int m_Navi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_Navi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplHistoryInterpreter.NativeFieldInfoPtr_m_Navi)) = value;
			}
		}

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_m_History;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_m_Last;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_m_Navi;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_Int32_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_DynValue_String_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_HistoryPrev_Public_String_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_HistoryNext_Public_String_0;
	}
}
