using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E5 RID: 741
	public class ModuleScriptProxy : BaseScriptProxy
	{
		// Token: 0x060040D0 RID: 16592 RVA: 0x00122F24 File Offset: 0x00121124
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleScriptProxy()
		{
			Il2CppClassPointerStore<ModuleScriptProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ModuleScriptProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleScriptProxy>.NativeClassPtr);
			ModuleScriptProxy.NativeFieldInfoPtr_moduleScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleScriptProxy>.NativeClassPtr, "moduleScript");
			ModuleScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_ModuleScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleScriptProxy>.NativeClassPtr, 100673456);
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00122F7C File Offset: 0x0012117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModuleScriptProxy(ModuleScript target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuleScriptProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_ModuleScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00018809 File Offset: 0x00016A09
		public ModuleScriptProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00122FC8 File Offset: 0x001211C8
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x00018812 File Offset: 0x00016A12
		public unsafe ModuleScript moduleScript
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleScriptProxy.NativeFieldInfoPtr_moduleScript);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModuleScript>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleScriptProxy.NativeFieldInfoPtr_moduleScript), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeFieldInfoPtr_moduleScript;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModuleScript_0;
	}
}
