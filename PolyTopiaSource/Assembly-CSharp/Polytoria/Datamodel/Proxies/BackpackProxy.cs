using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002CE RID: 718
	public class BackpackProxy : InstanceProxy
	{
		// Token: 0x06003F7F RID: 16255 RVA: 0x0011D0CC File Offset: 0x0011B2CC
		// Note: this type is marked as 'beforefieldinit'.
		static BackpackProxy()
		{
			Il2CppClassPointerStore<BackpackProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "BackpackProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackpackProxy>.NativeClassPtr);
			BackpackProxy.NativeFieldInfoPtr_backpack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackpackProxy>.NativeClassPtr, "backpack");
			BackpackProxy.NativeMethodInfoPtr__ctor_Public_Void_Backpack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackpackProxy>.NativeClassPtr, 100673212);
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x0011D124 File Offset: 0x0011B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128451, XrefRangeEnd = 128454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackpackProxy(Backpack target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackpackProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackpackProxy.NativeMethodInfoPtr__ctor_Public_Void_Backpack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00018462 File Offset: 0x00016662
		public BackpackProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x0011D170 File Offset: 0x0011B370
		// (set) Token: 0x06003F83 RID: 16259 RVA: 0x0001846B File Offset: 0x0001666B
		public unsafe Backpack backpack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackpackProxy.NativeFieldInfoPtr_backpack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Backpack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackpackProxy.NativeFieldInfoPtr_backpack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeFieldInfoPtr_backpack;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Backpack_0;
	}
}
