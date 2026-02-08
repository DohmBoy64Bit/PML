using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009D RID: 157
	public static class InteropRegistrationPolicy : Object
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x00047800 File Offset: 0x00045A00
		// Note: this type is marked as 'beforefieldinit'.
		static InteropRegistrationPolicy()
		{
			Il2CppClassPointerStore<InteropRegistrationPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "InteropRegistrationPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropRegistrationPolicy>.NativeClassPtr);
			InteropRegistrationPolicy.NativeMethodInfoPtr_get_Default_Public_Static_get_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropRegistrationPolicy>.NativeClassPtr, 100665505);
			InteropRegistrationPolicy.NativeMethodInfoPtr_get_Explicit_Public_Static_get_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropRegistrationPolicy>.NativeClassPtr, 100665506);
			InteropRegistrationPolicy.NativeMethodInfoPtr_get_Automatic_Public_Static_get_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropRegistrationPolicy>.NativeClassPtr, 100665507);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0004786C File Offset: 0x00045A6C
		public unsafe static IRegistrationPolicy Default
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33339, RefRangeEnd = 33340, XrefRangeStart = 33335, XrefRangeEnd = 33339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropRegistrationPolicy.NativeMethodInfoPtr_get_Default_Public_Static_get_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000478A0 File Offset: 0x00045AA0
		public unsafe static IRegistrationPolicy Explicit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33340, XrefRangeEnd = 33344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropRegistrationPolicy.NativeMethodInfoPtr_get_Explicit_Public_Static_get_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000478D4 File Offset: 0x00045AD4
		public unsafe static IRegistrationPolicy Automatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33344, XrefRangeEnd = 33348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropRegistrationPolicy.NativeMethodInfoPtr_get_Automatic_Public_Static_get_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00005C08 File Offset: 0x00003E08
		public InteropRegistrationPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_IRegistrationPolicy_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_get_Explicit_Public_Static_get_IRegistrationPolicy_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_get_Automatic_Public_Static_get_IRegistrationPolicy_0;
	}
}
