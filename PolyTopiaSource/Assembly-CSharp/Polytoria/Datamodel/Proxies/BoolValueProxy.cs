using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D1 RID: 721
	public class BoolValueProxy : ValueBaseProxy
	{
		// Token: 0x06003F98 RID: 16280 RVA: 0x0011D680 File Offset: 0x0011B880
		// Note: this type is marked as 'beforefieldinit'.
		static BoolValueProxy()
		{
			Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "BoolValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr);
			BoolValueProxy.NativeFieldInfoPtr_boolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr, "boolValue");
			BoolValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr, 100673225);
			BoolValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr, 100673226);
			BoolValueProxy.NativeMethodInfoPtr__ctor_Public_Void_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr, 100673224);
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x0011D700 File Offset: 0x0011B900
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x0011D73C File Offset: 0x0011B93C
		public unsafe bool Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128463, XrefRangeEnd = 128465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0011D77C File Offset: 0x0011B97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128465, XrefRangeEnd = 128469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolValueProxy(BoolValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValueProxy.NativeMethodInfoPtr__ctor_Public_Void_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000184E9 File Offset: 0x000166E9
		public BoolValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x0011D7C8 File Offset: 0x0011B9C8
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x000184F2 File Offset: 0x000166F2
		public unsafe BoolValue boolValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValueProxy.NativeFieldInfoPtr_boolValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValueProxy.NativeFieldInfoPtr_boolValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeFieldInfoPtr_boolValue;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Boolean_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoolValue_0;
	}
}
