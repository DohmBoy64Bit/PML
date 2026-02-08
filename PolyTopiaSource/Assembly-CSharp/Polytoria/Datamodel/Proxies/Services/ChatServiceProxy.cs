using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030A RID: 778
	public class ChatServiceProxy : Object
	{
		// Token: 0x0600435E RID: 17246 RVA: 0x0012E7E8 File Offset: 0x0012C9E8
		// Note: this type is marked as 'beforefieldinit'.
		static ChatServiceProxy()
		{
			Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "ChatServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr);
			ChatServiceProxy.NativeFieldInfoPtr_chatService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr, "chatService");
			ChatServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_ChatService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr, 100673962);
			ChatServiceProxy.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr, 100673963);
			ChatServiceProxy.NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr, 100673964);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x0012E868 File Offset: 0x0012CA68
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatServiceProxy(ChatService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_ChatService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0012E8B4 File Offset: 0x0012CAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129186, XrefRangeEnd = 129188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatServiceProxy.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x0012E8F8 File Offset: 0x0012CAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129188, XrefRangeEnd = 129190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnicastMessage(string message, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatServiceProxy.NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00018DD1 File Offset: 0x00016FD1
		public ChatServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x0012E94C File Offset: 0x0012CB4C
		// (set) Token: 0x06004364 RID: 17252 RVA: 0x00018DDA File Offset: 0x00016FDA
		public unsafe ChatService chatService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatServiceProxy.NativeFieldInfoPtr_chatService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatServiceProxy.NativeFieldInfoPtr_chatService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeFieldInfoPtr_chatService;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChatService_0;

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0;
	}
}
