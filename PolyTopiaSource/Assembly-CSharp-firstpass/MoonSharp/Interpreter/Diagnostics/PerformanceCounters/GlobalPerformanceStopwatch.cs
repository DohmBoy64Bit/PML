using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F6 RID: 246
	public class GlobalPerformanceStopwatch : Object
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x00061E20 File Offset: 0x00060020
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalPerformanceStopwatch()
		{
			Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics.PerformanceCounters", "GlobalPerformanceStopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr);
			GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, "m_Count");
			GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, "m_Elapsed");
			GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, "m_Counter");
			GlobalPerformanceStopwatch.NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, 100666588);
			GlobalPerformanceStopwatch.NativeMethodInfoPtr_SignalStopwatchTerminated_Private_Void_Stopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, 100666589);
			GlobalPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, 100666590);
			GlobalPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, 100666591);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00061EDC File Offset: 0x000600DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46442, XrefRangeEnd = 46443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalPerformanceStopwatch(PerformanceCounter perfcounter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(perfcounter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00061F28 File Offset: 0x00060128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46443, XrefRangeEnd = 46444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SignalStopwatchTerminated(Stopwatch sw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.NativeMethodInfoPtr_SignalStopwatchTerminated_Private_Void_Stopwatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00061F6C File Offset: 0x0006016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46444, XrefRangeEnd = 46454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDisposable Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00061FAC File Offset: 0x000601AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46454, XrefRangeEnd = 46462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PerformanceResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr3) : null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00007B28 File Offset: 0x00005D28
		public GlobalPerformanceStopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00061FEC File Offset: 0x000601EC
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00007B31 File Offset: 0x00005D31
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00062014 File Offset: 0x00060214
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00007B4C File Offset: 0x00005D4C
		public unsafe long m_Elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Elapsed)) = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0006203C File Offset: 0x0006023C
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00007B67 File Offset: 0x00005D67
		public unsafe PerformanceCounter m_Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Counter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceCounter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.NativeFieldInfoPtr_m_Counter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr_m_Elapsed;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeFieldInfoPtr_m_Counter;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PerformanceCounter_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_SignalStopwatchTerminated_Private_Void_Stopwatch_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0;

		// Token: 0x020001E4 RID: 484
		public class GlobalPerformanceStopwatch_StopwatchObject : Object
		{
			// Token: 0x06001D13 RID: 7443 RVA: 0x0008B710 File Offset: 0x00089910
			// Note: this type is marked as 'beforefieldinit'.
			static GlobalPerformanceStopwatch_StopwatchObject()
			{
				Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalPerformanceStopwatch>.NativeClassPtr, "GlobalPerformanceStopwatch_StopwatchObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr);
				GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr, "m_Stopwatch");
				GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr, "m_Parent");
				GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeMethodInfoPtr__ctor_Public_Void_GlobalPerformanceStopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr, 100666592);
				GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr, 100666593);
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x0008B78C File Offset: 0x0008998C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46433, XrefRangeEnd = 46440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeMethodInfoPtr__ctor_Public_Void_GlobalPerformanceStopwatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x0008B7D8 File Offset: 0x000899D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46440, XrefRangeEnd = 46442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0000B815 File Offset: 0x00009A15
			public GlobalPerformanceStopwatch_StopwatchObject(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0008B80C File Offset: 0x00089A0C
			// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000B81E File Offset: 0x00009A1E
			public unsafe Stopwatch m_Stopwatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Stopwatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Stopwatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0008B83C File Offset: 0x00089A3C
			// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000B83D File Offset: 0x00009A3D
			public unsafe GlobalPerformanceStopwatch m_Parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalPerformanceStopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalPerformanceStopwatch.GlobalPerformanceStopwatch_StopwatchObject.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeFieldInfoPtr_m_Stopwatch;

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GlobalPerformanceStopwatch_0;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}
