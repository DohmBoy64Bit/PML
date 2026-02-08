using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E8 RID: 744
	public class NumberValueProxy : ValueBaseProxy
	{
		// Token: 0x06004110 RID: 16656 RVA: 0x00124198 File Offset: 0x00122398
		// Note: this type is marked as 'beforefieldinit'.
		static NumberValueProxy()
		{
			Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "NumberValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr);
			NumberValueProxy.NativeFieldInfoPtr_numberValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr, "numberValue");
			NumberValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr, 100673509);
			NumberValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr, 100673510);
			NumberValueProxy.NativeMethodInfoPtr__ctor_Public_Void_NumberValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr, 100673508);
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x00124218 File Offset: 0x00122418
		// (set) Token: 0x06004112 RID: 16658 RVA: 0x00124254 File Offset: 0x00122454
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128723, XrefRangeEnd = 128725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00124294 File Offset: 0x00122494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberValueProxy(NumberValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValueProxy.NativeMethodInfoPtr__ctor_Public_Void_NumberValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00018881 File Offset: 0x00016A81
		public NumberValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x001242E0 File Offset: 0x001224E0
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x0001888A File Offset: 0x00016A8A
		public unsafe NumberValue numberValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValueProxy.NativeFieldInfoPtr_numberValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValueProxy.NativeFieldInfoPtr_numberValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeFieldInfoPtr_numberValue;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberValue_0;
	}
}
