using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002F RID: 47
	public class IScriptPrivateResource : Object
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x000039D3 File Offset: 0x00001BD3
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptPrivateResource()
		{
			Il2CppClassPointerStore<IScriptPrivateResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "IScriptPrivateResource");
			IScriptPrivateResource.NativeMethodInfoPtr_get_OwnerScript_Public_Abstract_Virtual_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptPrivateResource>.NativeClassPtr, 100664614);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0002F240 File Offset: 0x0002D440
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptPrivateResource.NativeMethodInfoPtr_get_OwnerScript_Public_Abstract_Virtual_New_get_Script_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00003A02 File Offset: 0x00001C02
		public IScriptPrivateResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Abstract_Virtual_New_get_Script_0;
	}
}
