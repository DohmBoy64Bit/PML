using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F8 RID: 248
	public class PerformanceStopwatch : Object
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x00062154 File Offset: 0x00060354
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceStopwatch()
		{
			Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics.PerformanceCounters", "PerformanceStopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr);
			PerformanceStopwatch.NativeFieldInfoPtr_m_Stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, "m_Stopwatch");
			PerformanceStopwatch.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, "m_Count");
			PerformanceStopwatch.NativeFieldInfoPtr_m_Reentrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, "m_Reentrant");
			PerformanceStopwatch.NativeFieldInfoPtr_m_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, "m_Counter");
			PerformanceStopwatch.NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, 100666596);
			PerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, 100666597);
			PerformanceStopwatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, 100666598);
			PerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr, 100666599);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00062224 File Offset: 0x00060424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46468, RefRangeEnd = 46469, XrefRangeStart = 46462, XrefRangeEnd = 46468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceStopwatch(PerformanceCounter perfcounter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceStopwatch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(perfcounter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStopwatch.NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00062270 File Offset: 0x00060470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46469, XrefRangeEnd = 46470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDisposable Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000622B0 File Offset: 0x000604B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46470, XrefRangeEnd = 46471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStopwatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000622E4 File Offset: 0x000604E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46471, XrefRangeEnd = 46480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PerformanceResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr3) : null;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00007B8F File Offset: 0x00005D8F
		public PerformanceStopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00062324 File Offset: 0x00060524
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00007B98 File Offset: 0x00005D98
		public unsafe Stopwatch m_Stopwatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Stopwatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Stopwatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00062354 File Offset: 0x00060554
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00007BB7 File Offset: 0x00005DB7
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0006237C File Offset: 0x0006057C
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00007BD2 File Offset: 0x00005DD2
		public unsafe int m_Reentrant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Reentrant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Reentrant)) = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000623A4 File Offset: 0x000605A4
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00007BED File Offset: 0x00005DED
		public unsafe PerformanceCounter m_Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Counter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceCounter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceStopwatch.NativeFieldInfoPtr_m_Counter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeFieldInfoPtr_m_Stopwatch;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeFieldInfoPtr_m_Reentrant;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeFieldInfoPtr_m_Counter;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0;
	}
}
