using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E2 RID: 738
	public class LocalScriptProxy : BaseScriptProxy
	{
		// Token: 0x060040B4 RID: 16564 RVA: 0x00122830 File Offset: 0x00120A30
		// Note: this type is marked as 'beforefieldinit'.
		static LocalScriptProxy()
		{
			Il2CppClassPointerStore<LocalScriptProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "LocalScriptProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalScriptProxy>.NativeClassPtr);
			LocalScriptProxy.NativeFieldInfoPtr_localScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalScriptProxy>.NativeClassPtr, "localScript");
			LocalScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_LocalScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalScriptProxy>.NativeClassPtr, 100673440);
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00122888 File Offset: 0x00120A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalScriptProxy(LocalScript target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalScriptProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_LocalScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00018791 File Offset: 0x00016991
		public LocalScriptProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x001228D4 File Offset: 0x00120AD4
		// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0001879A File Offset: 0x0001699A
		public unsafe LocalScript localScript
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalScriptProxy.NativeFieldInfoPtr_localScript);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalScript>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalScriptProxy.NativeFieldInfoPtr_localScript), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeFieldInfoPtr_localScript;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalScript_0;
	}
}
