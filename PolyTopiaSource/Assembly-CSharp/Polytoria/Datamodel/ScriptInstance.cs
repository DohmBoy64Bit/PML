using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A7 RID: 679
	public class ScriptInstance : BaseScript
	{
		// Token: 0x060039F6 RID: 14838 RVA: 0x00106648 File Offset: 0x00104848
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptInstance()
		{
			Il2CppClassPointerStore<ScriptInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ScriptInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptInstance>.NativeClassPtr);
			ScriptInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptInstance>.NativeClassPtr, 100672178);
			ScriptInstance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptInstance>.NativeClassPtr, 100672179);
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x001066A0 File Offset: 0x001048A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117717, XrefRangeEnd = 117721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptInstance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x001066DC File Offset: 0x001048DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptInstance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00016712 File Offset: 0x00014912
		public ScriptInstance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
