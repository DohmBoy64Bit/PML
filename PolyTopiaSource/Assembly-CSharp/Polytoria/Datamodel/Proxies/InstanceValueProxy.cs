using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DF RID: 735
	public class InstanceValueProxy : ValueBaseProxy
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x00122118 File Offset: 0x00120318
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceValueProxy()
		{
			Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "InstanceValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr);
			InstanceValueProxy.NativeFieldInfoPtr_instanceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr, "instanceValue");
			InstanceValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr, 100673424);
			InstanceValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr, 100673425);
			InstanceValueProxy.NativeMethodInfoPtr__ctor_Public_Void_InstanceValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr, 100673423);
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x00122198 File Offset: 0x00120398
		// (set) Token: 0x06004099 RID: 16537 RVA: 0x001221D8 File Offset: 0x001203D8
		public unsafe Instance Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128626, XrefRangeEnd = 128628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128628, XrefRangeEnd = 128630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0012221C File Offset: 0x0012041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceValueProxy(InstanceValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValueProxy.NativeMethodInfoPtr__ctor_Public_Void_InstanceValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00018719 File Offset: 0x00016919
		public InstanceValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x00122268 File Offset: 0x00120468
		// (set) Token: 0x0600409D RID: 16541 RVA: 0x00018722 File Offset: 0x00016922
		public unsafe InstanceValue instanceValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValueProxy.NativeFieldInfoPtr_instanceValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InstanceValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValueProxy.NativeFieldInfoPtr_instanceValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeFieldInfoPtr_instanceValue;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Instance_0;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InstanceValue_0;
	}
}
