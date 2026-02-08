using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F6 RID: 758
	public class SkyBaseProxy : InstanceProxy
	{
		// Token: 0x06004244 RID: 16964 RVA: 0x00129BEC File Offset: 0x00127DEC
		// Note: this type is marked as 'beforefieldinit'.
		static SkyBaseProxy()
		{
			Il2CppClassPointerStore<SkyBaseProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SkyBaseProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyBaseProxy>.NativeClassPtr);
			SkyBaseProxy.NativeFieldInfoPtr_skyBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBaseProxy>.NativeClassPtr, "skyBase");
			SkyBaseProxy.NativeMethodInfoPtr__ctor_Public_Void_SkyBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBaseProxy>.NativeClassPtr, 100673760);
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00129C44 File Offset: 0x00127E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyBaseProxy(SkyBase target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyBaseProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBaseProxy.NativeMethodInfoPtr__ctor_Public_Void_SkyBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00018AB1 File Offset: 0x00016CB1
		public SkyBaseProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x00129C90 File Offset: 0x00127E90
		// (set) Token: 0x06004248 RID: 16968 RVA: 0x00018ABA File Offset: 0x00016CBA
		public unsafe SkyBase skyBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBaseProxy.NativeFieldInfoPtr_skyBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBaseProxy.NativeFieldInfoPtr_skyBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeFieldInfoPtr_skyBase;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SkyBase_0;
	}
}
