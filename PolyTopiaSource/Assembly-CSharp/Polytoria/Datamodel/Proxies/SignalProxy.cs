using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F5 RID: 757
	public class SignalProxy : InstanceProxy
	{
		// Token: 0x0600423D RID: 16957 RVA: 0x00129A60 File Offset: 0x00127C60
		// Note: this type is marked as 'beforefieldinit'.
		static SignalProxy()
		{
			Il2CppClassPointerStore<SignalProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SignalProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr);
			SignalProxy.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr, "signal");
			SignalProxy.NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr, 100673758);
			SignalProxy.NativeMethodInfoPtr__ctor_Public_Void_Signal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr, 100673757);
			SignalProxy.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr, 100673759);
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x00129AE0 File Offset: 0x00127CE0
		public unsafe LuaEvent Invoked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalProxy.NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x00129B20 File Offset: 0x00127D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalProxy(Signal target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalProxy.NativeMethodInfoPtr__ctor_Public_Void_Signal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00129B6C File Offset: 0x00127D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128988, XrefRangeEnd = 128990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke([Optional] Il2CppReferenceArray<Object> par)
		{
			if (par == null)
			{
				par = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalProxy.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00018A89 File Offset: 0x00016C89
		public SignalProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x00129BBC File Offset: 0x00127DBC
		// (set) Token: 0x06004243 RID: 16963 RVA: 0x00018A92 File Offset: 0x00016C92
		public unsafe Signal signal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalProxy.NativeFieldInfoPtr_signal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Signal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalProxy.NativeFieldInfoPtr_signal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeFieldInfoPtr_signal;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Signal_0;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0;
	}
}
