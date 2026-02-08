using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Diagnostics.PerformanceCounters;

namespace MoonSharp.Interpreter.Diagnostics
{
	// Token: 0x020000F3 RID: 243
	public class PerformanceStatistics : Object
	{
		// Token: 0x060012A0 RID: 4768 RVA: 0x000618E4 File Offset: 0x0005FAE4
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceStatistics()
		{
			Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics", "PerformanceStatistics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr);
			PerformanceStatistics.NativeFieldInfoPtr_m_Stopwatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, "m_Stopwatches");
			PerformanceStatistics.NativeFieldInfoPtr_m_GlobalStopwatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, "m_GlobalStopwatches");
			PerformanceStatistics.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, "m_Enabled");
			PerformanceStatistics.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666575);
			PerformanceStatistics.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666576);
			PerformanceStatistics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666581);
			PerformanceStatistics.NativeMethodInfoPtr_GetPerformanceCounterResult_Public_PerformanceResult_PerformanceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666577);
			PerformanceStatistics.NativeMethodInfoPtr_StartStopwatch_Internal_IDisposable_PerformanceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666578);
			PerformanceStatistics.NativeMethodInfoPtr_StartGlobalStopwatch_Internal_Static_IDisposable_PerformanceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666579);
			PerformanceStatistics.NativeMethodInfoPtr_GetPerformanceLog_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr, 100666580);
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000619DC File Offset: 0x0005FBDC
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00061A18 File Offset: 0x0005FC18
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46349, XrefRangeEnd = 46383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00061A58 File Offset: 0x0005FC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46388, RefRangeEnd = 46389, XrefRangeStart = 46383, XrefRangeEnd = 46388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceStatistics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceStatistics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00061A94 File Offset: 0x0005FC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46389, XrefRangeEnd = 46393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_GetPerformanceCounterResult_Public_PerformanceResult_PerformanceCounter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr3) : null;
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00061AE4 File Offset: 0x0005FCE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46396, RefRangeEnd = 46401, XrefRangeStart = 46393, XrefRangeEnd = 46396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDisposable StartStopwatch(PerformanceCounter pc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_StartStopwatch_Internal_IDisposable_PerformanceCounter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00061B34 File Offset: 0x0005FD34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 46408, RefRangeEnd = 46412, XrefRangeStart = 46401, XrefRangeEnd = 46408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable StartGlobalStopwatch(PerformanceCounter pc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_StartGlobalStopwatch_Internal_Static_IDisposable_PerformanceCounter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00061B78 File Offset: 0x0005FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46412, XrefRangeEnd = 46423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPerformanceLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStatistics.NativeMethodInfoPtr_GetPerformanceLog_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00007A6B File Offset: 0x00005C6B
		public PerformanceStatistics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00061BB0 File Offset: 0x0005FDB0
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x00007A74 File Offset: 0x00005C74
		public unsafe Il2CppReferenceArray<IPerformanceStopwatch> m_Stopwatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStatistics.NativeFieldInfoPtr_m_Stopwatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPerformanceStopwatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStatistics.NativeFieldInfoPtr_m_Stopwatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00061BE0 File Offset: 0x0005FDE0
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00007A93 File Offset: 0x00005C93
		public unsafe static Il2CppReferenceArray<IPerformanceStopwatch> m_GlobalStopwatches
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PerformanceStatistics.NativeFieldInfoPtr_m_GlobalStopwatches, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPerformanceStopwatch>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PerformanceStatistics.NativeFieldInfoPtr_m_GlobalStopwatches, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00061C08 File Offset: 0x0005FE08
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00007AA5 File Offset: 0x00005CA5
		public unsafe bool m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStatistics.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStatistics.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr_m_Stopwatches;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalStopwatches;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_GetPerformanceCounterResult_Public_PerformanceResult_PerformanceCounter_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_StartStopwatch_Internal_IDisposable_PerformanceCounter_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_StartGlobalStopwatch_Internal_Static_IDisposable_PerformanceCounter_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_GetPerformanceLog_Public_String_0;
	}
}
