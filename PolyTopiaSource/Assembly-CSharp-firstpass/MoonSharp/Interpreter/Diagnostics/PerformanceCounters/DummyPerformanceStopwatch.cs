using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F5 RID: 245
	public class DummyPerformanceStopwatch : Object
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x00061C30 File Offset: 0x0005FE30
		// Note: this type is marked as 'beforefieldinit'.
		static DummyPerformanceStopwatch()
		{
			Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics.PerformanceCounters", "DummyPerformanceStopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr);
			DummyPerformanceStopwatch.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, "Instance");
			DummyPerformanceStopwatch.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, "m_Result");
			DummyPerformanceStopwatch.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, 100666583);
			DummyPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, 100666584);
			DummyPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, 100666585);
			DummyPerformanceStopwatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr, 100666586);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00061CD8 File Offset: 0x0005FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46423, XrefRangeEnd = 46433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DummyPerformanceStopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DummyPerformanceStopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyPerformanceStopwatch.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00061D14 File Offset: 0x0005FF14
		[CallerCount(1334)]
		[CachedScanResults(RefRangeStart = 26463, RefRangeEnd = 27797, XrefRangeStart = 26463, XrefRangeEnd = 27797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDisposable Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00061D54 File Offset: 0x0005FF54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PerformanceResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr3) : null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00061D94 File Offset: 0x0005FF94
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyPerformanceStopwatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00007AEE File Offset: 0x00005CEE
		public DummyPerformanceStopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00061DC8 File Offset: 0x0005FFC8
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x00007AF7 File Offset: 0x00005CF7
		public unsafe static DummyPerformanceStopwatch Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DummyPerformanceStopwatch.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DummyPerformanceStopwatch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DummyPerformanceStopwatch.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00061DF0 File Offset: 0x0005FFF0
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x00007B09 File Offset: 0x00005D09
		public unsafe PerformanceResult m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DummyPerformanceStopwatch.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DummyPerformanceStopwatch.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_IDisposable_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_PerformanceResult_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
