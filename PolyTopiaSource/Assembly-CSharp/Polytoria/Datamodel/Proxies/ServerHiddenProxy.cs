using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F4 RID: 756
	public class ServerHiddenProxy : InstanceProxy
	{
		// Token: 0x06004238 RID: 16952 RVA: 0x0012998C File Offset: 0x00127B8C
		// Note: this type is marked as 'beforefieldinit'.
		static ServerHiddenProxy()
		{
			Il2CppClassPointerStore<ServerHiddenProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ServerHiddenProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerHiddenProxy>.NativeClassPtr);
			ServerHiddenProxy.NativeFieldInfoPtr_serverHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHiddenProxy>.NativeClassPtr, "serverHidden");
			ServerHiddenProxy.NativeMethodInfoPtr__ctor_Public_Void_ServerHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHiddenProxy>.NativeClassPtr, 100673756);
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001299E4 File Offset: 0x00127BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerHiddenProxy(ServerHidden target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHiddenProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerHiddenProxy.NativeMethodInfoPtr__ctor_Public_Void_ServerHidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00018A61 File Offset: 0x00016C61
		public ServerHiddenProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x00129A30 File Offset: 0x00127C30
		// (set) Token: 0x0600423C RID: 16956 RVA: 0x00018A6A File Offset: 0x00016C6A
		public unsafe ServerHidden serverHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerHiddenProxy.NativeFieldInfoPtr_serverHidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerHidden>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerHiddenProxy.NativeFieldInfoPtr_serverHidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeFieldInfoPtr_serverHidden;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerHidden_0;
	}
}
