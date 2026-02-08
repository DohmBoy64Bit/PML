using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Polytoria.Datamodel
{
	// Token: 0x02000291 RID: 657
	public class ModuleScript : BaseScript
	{
		// Token: 0x06003459 RID: 13401 RVA: 0x000EEBC0 File Offset: 0x000ECDC0
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleScript()
		{
			Il2CppClassPointerStore<ModuleScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ModuleScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleScript>.NativeClassPtr);
			ModuleScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleScript>.NativeClassPtr, 100671212);
			ModuleScript.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleScript>.NativeClassPtr, 100671213);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000EEC18 File Offset: 0x000ECE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106915, XrefRangeEnd = 106919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModuleScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuleScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000EEC54 File Offset: 0x000ECE54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuleScript.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000149ED File Offset: 0x00012BED
		public ModuleScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
