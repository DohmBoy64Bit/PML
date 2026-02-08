using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028C RID: 652
	public class LocalScript : BaseScript
	{
		// Token: 0x060033FC RID: 13308 RVA: 0x000ED3F4 File Offset: 0x000EB5F4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalScript()
		{
			Il2CppClassPointerStore<LocalScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "LocalScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalScript>.NativeClassPtr);
			LocalScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalScript>.NativeClassPtr, 100671152);
			LocalScript.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalScript>.NativeClassPtr, 100671153);
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000ED44C File Offset: 0x000EB64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106241, XrefRangeEnd = 106245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000ED488 File Offset: 0x000EB688
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalScript.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00014846 File Offset: 0x00012A46
		public LocalScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
