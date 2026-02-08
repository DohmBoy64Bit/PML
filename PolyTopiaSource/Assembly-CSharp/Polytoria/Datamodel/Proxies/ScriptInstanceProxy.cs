using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F2 RID: 754
	public class ScriptInstanceProxy : BaseScriptProxy
	{
		// Token: 0x0600422B RID: 16939 RVA: 0x001296E8 File Offset: 0x001278E8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptInstanceProxy()
		{
			Il2CppClassPointerStore<ScriptInstanceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ScriptInstanceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptInstanceProxy>.NativeClassPtr);
			ScriptInstanceProxy.NativeFieldInfoPtr_scriptInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptInstanceProxy>.NativeClassPtr, "scriptInstance");
			ScriptInstanceProxy.NativeMethodInfoPtr__ctor_Public_Void_ScriptInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptInstanceProxy>.NativeClassPtr, 100673751);
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00129740 File Offset: 0x00127940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptInstanceProxy(ScriptInstance target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptInstanceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptInstanceProxy.NativeMethodInfoPtr__ctor_Public_Void_ScriptInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00018A11 File Offset: 0x00016C11
		public ScriptInstanceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x0012978C File Offset: 0x0012798C
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x00018A1A File Offset: 0x00016C1A
		public unsafe ScriptInstance scriptInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptInstanceProxy.NativeFieldInfoPtr_scriptInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptInstanceProxy.NativeFieldInfoPtr_scriptInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeFieldInfoPtr_scriptInstance;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptInstance_0;
	}
}
