using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F7 RID: 247
	public class IPerformanceStopwatch : Object
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x0006206C File Offset: 0x0006026C
		// Note: this type is marked as 'beforefieldinit'.
		static IPerformanceStopwatch()
		{
			Il2CppClassPointerStore<IPerformanceStopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics.PerformanceCounters", "IPerformanceStopwatch");
			IPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPerformanceStopwatch>.NativeClassPtr, 100666594);
			IPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_PerformanceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPerformanceStopwatch>.NativeClassPtr, 100666595);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000620BC File Offset: 0x000602BC
		[CallerCount(0)]
		public unsafe virtual IDisposable Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPerformanceStopwatch.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_IDisposable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00062108 File Offset: 0x00060308
		[CallerCount(0)]
		public unsafe virtual PerformanceResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPerformanceStopwatch.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_PerformanceResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceResult>(intPtr3) : null;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00007B86 File Offset: 0x00005D86
		public IPerformanceStopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_IDisposable_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_PerformanceResult_0;
	}
}
