using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000160 RID: 352
	public class NetworkManager : Object
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x00078024 File Offset: 0x00076224
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkManager()
		{
			Il2CppClassPointerStore<NetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "NetworkManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr);
			NetworkManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "MethodsPtr");
			NetworkManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "MethodsStructure");
			NetworkManager.NativeFieldInfoPtr_OnMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "OnMessage");
			NetworkManager.NativeFieldInfoPtr_OnRouteUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "OnRouteUpdate");
			NetworkManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668009);
			NetworkManager.NativeMethodInfoPtr_add_OnMessage_Public_add_Void_MessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668010);
			NetworkManager.NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_MessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668011);
			NetworkManager.NativeMethodInfoPtr_add_OnRouteUpdate_Public_add_Void_RouteUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668012);
			NetworkManager.NativeMethodInfoPtr_remove_OnRouteUpdate_Public_rem_Void_RouteUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668013);
			NetworkManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668014);
			NetworkManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668015);
			NetworkManager.NativeMethodInfoPtr_GetPeerId_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668016);
			NetworkManager.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668017);
			NetworkManager.NativeMethodInfoPtr_OpenPeer_Public_Void_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668018);
			NetworkManager.NativeMethodInfoPtr_UpdatePeer_Public_Void_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668019);
			NetworkManager.NativeMethodInfoPtr_ClosePeer_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668020);
			NetworkManager.NativeMethodInfoPtr_OpenChannel_Public_Void_UInt64_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668021);
			NetworkManager.NativeMethodInfoPtr_CloseChannel_Public_Void_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668022);
			NetworkManager.NativeMethodInfoPtr_SendMessage_Public_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668023);
			NetworkManager.NativeMethodInfoPtr_OnMessageImpl_Private_Static_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668024);
			NetworkManager.NativeMethodInfoPtr_OnRouteUpdateImpl_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, 100668025);
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000781F8 File Offset: 0x000763F8
		public unsafe NetworkManager.FFIMethods Methods
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 54295, RefRangeEnd = 54303, XrefRangeStart = 54282, XrefRangeEnd = 54295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NetworkManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00078230 File Offset: 0x00076430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54303, XrefRangeEnd = 54307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMessage(NetworkManager.MessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_add_OnMessage_Public_add_Void_MessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00078274 File Offset: 0x00076474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54307, XrefRangeEnd = 54311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMessage(NetworkManager.MessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_MessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x000782B8 File Offset: 0x000764B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54311, XrefRangeEnd = 54315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRouteUpdate(NetworkManager.RouteUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_add_OnRouteUpdate_Public_add_Void_RouteUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x000782FC File Offset: 0x000764FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54315, XrefRangeEnd = 54319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRouteUpdate(NetworkManager.RouteUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_remove_OnRouteUpdate_Public_rem_Void_RouteUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00078340 File Offset: 0x00076540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54321, RefRangeEnd = 54322, XrefRangeStart = 54319, XrefRangeEnd = 54321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000783A8 File Offset: 0x000765A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54346, RefRangeEnd = 54347, XrefRangeStart = 54322, XrefRangeEnd = 54346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000783FC File Offset: 0x000765FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54347, XrefRangeEnd = 54348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetPeerId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_GetPeerId_Public_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00078438 File Offset: 0x00076638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54348, XrefRangeEnd = 54349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0007846C File Offset: 0x0007666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54349, XrefRangeEnd = 54350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPeer(ulong peerId, string routeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_OpenPeer_Public_Void_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000784BC File Offset: 0x000766BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54350, XrefRangeEnd = 54351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePeer(ulong peerId, string routeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_UpdatePeer_Public_Void_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0007850C File Offset: 0x0007670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54351, XrefRangeEnd = 54352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePeer(ulong peerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_ClosePeer_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0007854C File Offset: 0x0007674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54352, XrefRangeEnd = 54353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_OpenChannel_Public_Void_UInt64_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000785A8 File Offset: 0x000767A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54353, XrefRangeEnd = 54354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseChannel(ulong peerId, byte channelId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_CloseChannel_Public_Void_UInt64_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000785F4 File Offset: 0x000767F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54354, XrefRangeEnd = 54355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(ulong peerId, byte channelId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref peerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_SendMessage_Public_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00078654 File Offset: 0x00076854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54355, XrefRangeEnd = 54368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_OnMessageImpl_Private_Static_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x000786C0 File Offset: 0x000768C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54368, XrefRangeEnd = 54374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.NativeMethodInfoPtr_OnRouteUpdateImpl_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0000981D File Offset: 0x00007A1D
		public NetworkManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00078704 File Offset: 0x00076904
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x00009826 File Offset: 0x00007A26
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0007872C File Offset: 0x0007692C
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00009841 File Offset: 0x00007A41
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0007875C File Offset: 0x0007695C
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00009860 File Offset: 0x00007A60
		public unsafe NetworkManager.MessageHandler OnMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_OnMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.MessageHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_OnMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0007878C File Offset: 0x0007698C
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0000987F File Offset: 0x00007A7F
		public unsafe NetworkManager.RouteUpdateHandler OnRouteUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_OnRouteUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.RouteUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.NativeFieldInfoPtr_OnRouteUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_OnMessage;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_OnRouteUpdate;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMessage_Public_add_Void_MessageHandler_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_MessageHandler_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRouteUpdate_Public_add_Void_RouteUpdateHandler_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRouteUpdate_Public_rem_Void_RouteUpdateHandler_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_GetPeerId_Public_UInt64_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_OpenPeer_Public_Void_UInt64_String_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePeer_Public_Void_UInt64_String_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_ClosePeer_Public_Void_UInt64_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_OpenChannel_Public_Void_UInt64_Byte_Boolean_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_CloseChannel_Public_Void_UInt64_Byte_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_OnMessageImpl_Private_Static_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_OnRouteUpdateImpl_Private_Static_Void_IntPtr_String_0;

		// Token: 0x0200022A RID: 554
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x0600200C RID: 8204 RVA: 0x0009464C File Offset: 0x0009284C
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr);
				NetworkManager.FFIEvents.NativeFieldInfoPtr_OnMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, "OnMessage");
				NetworkManager.FFIEvents.NativeFieldInfoPtr_OnRouteUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, "OnRouteUpdate");
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x0000D189 File Offset: 0x0000B389
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600200E RID: 8206 RVA: 0x0000D192 File Offset: 0x0000B392
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x000946A0 File Offset: 0x000928A0
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
			public unsafe NetworkManager.FFIEvents.MessageHandler OnMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIEvents.NativeFieldInfoPtr_OnMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIEvents.MessageHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIEvents.NativeFieldInfoPtr_OnMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x000946D0 File Offset: 0x000928D0
			// (set) Token: 0x06002012 RID: 8210 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
			public unsafe NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIEvents.NativeFieldInfoPtr_OnRouteUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIEvents.RouteUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIEvents.NativeFieldInfoPtr_OnRouteUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018E4 RID: 6372
			private static readonly IntPtr NativeFieldInfoPtr_OnMessage;

			// Token: 0x040018E5 RID: 6373
			private static readonly IntPtr NativeFieldInfoPtr_OnRouteUpdate;

			// Token: 0x020002CA RID: 714
			public sealed class MessageHandler : MulticastDelegate
			{
				// Token: 0x06002569 RID: 9577 RVA: 0x000A8264 File Offset: 0x000A6464
				// Note: this type is marked as 'beforefieldinit'.
				static MessageHandler()
				{
					Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, "MessageHandler");
					NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr, 100668026);
					NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr, 100668027);
					NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr, 100668028);
					NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr, 100668029);
				}

				// Token: 0x0600256A RID: 9578 RVA: 0x000A82D8 File Offset: 0x000A64D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54214, XrefRangeEnd = 54217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MessageHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIEvents.MessageHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600256B RID: 9579 RVA: 0x000A8334 File Offset: 0x000A6534
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600256C RID: 9580 RVA: 0x000A83AC File Offset: 0x000A65AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54217, XrefRangeEnd = 54228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600256D RID: 9581 RVA: 0x000A8458 File Offset: 0x000A6658
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.MessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600256E RID: 9582 RVA: 0x0000F257 File Offset: 0x0000D457
				public MessageHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600256F RID: 9583 RVA: 0x0000F260 File Offset: 0x0000D460
				public static implicit operator NetworkManager.FFIEvents.MessageHandler(Action<IntPtr, ulong, byte, IntPtr, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIEvents.MessageHandler>(A_0);
				}

				// Token: 0x06002570 RID: 9584 RVA: 0x0000F268 File Offset: 0x0000D468
				public static NetworkManager.FFIEvents.MessageHandler operator +(NetworkManager.FFIEvents.MessageHandler A_0, NetworkManager.FFIEvents.MessageHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIEvents.MessageHandler>();
				}

				// Token: 0x06002571 RID: 9585 RVA: 0x0000F276 File Offset: 0x0000D476
				public static NetworkManager.FFIEvents.MessageHandler operator -(NetworkManager.FFIEvents.MessageHandler A_0, NetworkManager.FFIEvents.MessageHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIEvents.MessageHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001B6D RID: 7021
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B6E RID: 7022
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_UInt64_Byte_IntPtr_Int32_0;

				// Token: 0x04001B6F RID: 7023
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_IntPtr_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B70 RID: 7024
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002CB RID: 715
			public sealed class RouteUpdateHandler : MulticastDelegate
			{
				// Token: 0x06002572 RID: 9586 RVA: 0x000A849C File Offset: 0x000A669C
				// Note: this type is marked as 'beforefieldinit'.
				static RouteUpdateHandler()
				{
					Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, "RouteUpdateHandler");
					NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr, 100668030);
					NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr, 100668031);
					NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr, 100668032);
					NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr, 100668033);
				}

				// Token: 0x06002573 RID: 9587 RVA: 0x000A8510 File Offset: 0x000A6710
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RouteUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIEvents.RouteUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002574 RID: 9588 RVA: 0x000A856C File Offset: 0x000A676C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, string routeData)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002575 RID: 9589 RVA: 0x000A85BC File Offset: 0x000A67BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, string routeData, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002576 RID: 9590 RVA: 0x000A8640 File Offset: 0x000A6840
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIEvents.RouteUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002577 RID: 9591 RVA: 0x0000F287 File Offset: 0x0000D487
				public RouteUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002578 RID: 9592 RVA: 0x0000F290 File Offset: 0x0000D490
				public static implicit operator NetworkManager.FFIEvents.RouteUpdateHandler(Action<IntPtr, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIEvents.RouteUpdateHandler>(A_0);
				}

				// Token: 0x06002579 RID: 9593 RVA: 0x0000F298 File Offset: 0x0000D498
				public static NetworkManager.FFIEvents.RouteUpdateHandler operator +(NetworkManager.FFIEvents.RouteUpdateHandler A_0, NetworkManager.FFIEvents.RouteUpdateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIEvents.RouteUpdateHandler>();
				}

				// Token: 0x0600257A RID: 9594 RVA: 0x0000F2A6 File Offset: 0x0000D4A6
				public static NetworkManager.FFIEvents.RouteUpdateHandler operator -(NetworkManager.FFIEvents.RouteUpdateHandler A_0, NetworkManager.FFIEvents.RouteUpdateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIEvents.RouteUpdateHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001B71 RID: 7025
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B72 RID: 7026
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0;

				// Token: 0x04001B73 RID: 7027
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x04001B74 RID: 7028
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x0200022B RID: 555
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06002013 RID: 8211 RVA: 0x00094700 File Offset: 0x00092900
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr);
				NetworkManager.FFIMethods.NativeFieldInfoPtr_GetPeerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "GetPeerId");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_Flush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "Flush");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "OpenPeer");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_UpdatePeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "UpdatePeer");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_ClosePeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "ClosePeer");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "OpenChannel");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_CloseChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "CloseChannel");
				NetworkManager.FFIMethods.NativeFieldInfoPtr_SendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "SendMessage");
			}

			// Token: 0x06002014 RID: 8212 RVA: 0x0000D1E2 File Offset: 0x0000B3E2
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002015 RID: 8213 RVA: 0x0000D1EB File Offset: 0x0000B3EB
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06002016 RID: 8214 RVA: 0x000947CC File Offset: 0x000929CC
			// (set) Token: 0x06002017 RID: 8215 RVA: 0x0000D1FD File Offset: 0x0000B3FD
			public unsafe NetworkManager.FFIMethods.GetPeerIdMethod GetPeerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_GetPeerId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.GetPeerIdMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_GetPeerId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06002018 RID: 8216 RVA: 0x000947FC File Offset: 0x000929FC
			// (set) Token: 0x06002019 RID: 8217 RVA: 0x0000D21C File Offset: 0x0000B41C
			public unsafe NetworkManager.FFIMethods.FlushMethod Flush
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_Flush);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.FlushMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_Flush), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x0600201A RID: 8218 RVA: 0x0009482C File Offset: 0x00092A2C
			// (set) Token: 0x0600201B RID: 8219 RVA: 0x0000D23B File Offset: 0x0000B43B
			public unsafe NetworkManager.FFIMethods.OpenPeerMethod OpenPeer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenPeer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.OpenPeerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenPeer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x0600201C RID: 8220 RVA: 0x0009485C File Offset: 0x00092A5C
			// (set) Token: 0x0600201D RID: 8221 RVA: 0x0000D25A File Offset: 0x0000B45A
			public unsafe NetworkManager.FFIMethods.UpdatePeerMethod UpdatePeer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_UpdatePeer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.UpdatePeerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_UpdatePeer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x0600201E RID: 8222 RVA: 0x0009488C File Offset: 0x00092A8C
			// (set) Token: 0x0600201F RID: 8223 RVA: 0x0000D279 File Offset: 0x0000B479
			public unsafe NetworkManager.FFIMethods.ClosePeerMethod ClosePeer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_ClosePeer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.ClosePeerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_ClosePeer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x06002020 RID: 8224 RVA: 0x000948BC File Offset: 0x00092ABC
			// (set) Token: 0x06002021 RID: 8225 RVA: 0x0000D298 File Offset: 0x0000B498
			public unsafe NetworkManager.FFIMethods.OpenChannelMethod OpenChannel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenChannel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.OpenChannelMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_OpenChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06002022 RID: 8226 RVA: 0x000948EC File Offset: 0x00092AEC
			// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000D2B7 File Offset: 0x0000B4B7
			public unsafe NetworkManager.FFIMethods.CloseChannelMethod CloseChannel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_CloseChannel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.CloseChannelMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_CloseChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06002024 RID: 8228 RVA: 0x0009491C File Offset: 0x00092B1C
			// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000D2D6 File Offset: 0x0000B4D6
			public unsafe NetworkManager.FFIMethods.SendMessageMethod SendMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_SendMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager.FFIMethods.SendMessageMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkManager.FFIMethods.NativeFieldInfoPtr_SendMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018E6 RID: 6374
			private static readonly IntPtr NativeFieldInfoPtr_GetPeerId;

			// Token: 0x040018E7 RID: 6375
			private static readonly IntPtr NativeFieldInfoPtr_Flush;

			// Token: 0x040018E8 RID: 6376
			private static readonly IntPtr NativeFieldInfoPtr_OpenPeer;

			// Token: 0x040018E9 RID: 6377
			private static readonly IntPtr NativeFieldInfoPtr_UpdatePeer;

			// Token: 0x040018EA RID: 6378
			private static readonly IntPtr NativeFieldInfoPtr_ClosePeer;

			// Token: 0x040018EB RID: 6379
			private static readonly IntPtr NativeFieldInfoPtr_OpenChannel;

			// Token: 0x040018EC RID: 6380
			private static readonly IntPtr NativeFieldInfoPtr_CloseChannel;

			// Token: 0x040018ED RID: 6381
			private static readonly IntPtr NativeFieldInfoPtr_SendMessage;

			// Token: 0x020002CC RID: 716
			public sealed class GetPeerIdMethod : MulticastDelegate
			{
				// Token: 0x0600257B RID: 9595 RVA: 0x000A8684 File Offset: 0x000A6884
				// Note: this type is marked as 'beforefieldinit'.
				static GetPeerIdMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "GetPeerIdMethod");
					NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr, 100668034);
					NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr, 100668035);
					NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UInt64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr, 100668036);
					NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr, 100668037);
				}

				// Token: 0x0600257C RID: 9596 RVA: 0x000A86F8 File Offset: 0x000A68F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetPeerIdMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.GetPeerIdMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600257D RID: 9597 RVA: 0x000A8754 File Offset: 0x000A6954
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref ulong peerId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600257E RID: 9598 RVA: 0x000A87A0 File Offset: 0x000A69A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54228, XrefRangeEnd = 54233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref ulong peerId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UInt64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600257F RID: 9599 RVA: 0x000A8820 File Offset: 0x000A6A20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref ulong peerId, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &peerId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.GetPeerIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002580 RID: 9600 RVA: 0x0000F2B7 File Offset: 0x0000D4B7
				public GetPeerIdMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B75 RID: 7029
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B76 RID: 7030
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UInt64_0;

				// Token: 0x04001B77 RID: 7031
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UInt64_AsyncCallback_Object_0;

				// Token: 0x04001B78 RID: 7032
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0;
			}

			// Token: 0x020002CD RID: 717
			public sealed class FlushMethod : MulticastDelegate
			{
				// Token: 0x06002581 RID: 9601 RVA: 0x000A8870 File Offset: 0x000A6A70
				// Note: this type is marked as 'beforefieldinit'.
				static FlushMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "FlushMethod");
					NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr, 100668038);
					NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr, 100668039);
					NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr, 100668040);
					NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr, 100668041);
				}

				// Token: 0x06002582 RID: 9602 RVA: 0x000A88E4 File Offset: 0x000A6AE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FlushMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.FlushMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002583 RID: 9603 RVA: 0x000A8940 File Offset: 0x000A6B40
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002584 RID: 9604 RVA: 0x000A898C File Offset: 0x000A6B8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002585 RID: 9605 RVA: 0x000A89FC File Offset: 0x000A6BFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.FlushMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002586 RID: 9606 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
				public FlushMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002587 RID: 9607 RVA: 0x0000F2C9 File Offset: 0x0000D4C9
				public static implicit operator NetworkManager.FFIMethods.FlushMethod(Func<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.FlushMethod>(A_0);
				}

				// Token: 0x06002588 RID: 9608 RVA: 0x0000F2D1 File Offset: 0x0000D4D1
				public static NetworkManager.FFIMethods.FlushMethod operator +(NetworkManager.FFIMethods.FlushMethod A_0, NetworkManager.FFIMethods.FlushMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.FlushMethod>();
				}

				// Token: 0x06002589 RID: 9609 RVA: 0x0000F2DF File Offset: 0x0000D4DF
				public static NetworkManager.FFIMethods.FlushMethod operator -(NetworkManager.FFIMethods.FlushMethod A_0, NetworkManager.FFIMethods.FlushMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.FlushMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B79 RID: 7033
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B7A RID: 7034
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0;

				// Token: 0x04001B7B RID: 7035
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001B7C RID: 7036
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002CE RID: 718
			public sealed class OpenPeerMethod : MulticastDelegate
			{
				// Token: 0x0600258A RID: 9610 RVA: 0x000A8A4C File Offset: 0x000A6C4C
				// Note: this type is marked as 'beforefieldinit'.
				static OpenPeerMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "OpenPeerMethod");
					NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr, 100668042);
					NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr, 100668043);
					NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr, 100668044);
					NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr, 100668045);
				}

				// Token: 0x0600258B RID: 9611 RVA: 0x000A8AC0 File Offset: 0x000A6CC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenPeerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenPeerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600258C RID: 9612 RVA: 0x000A8B1C File Offset: 0x000A6D1C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600258D RID: 9613 RVA: 0x000A8B88 File Offset: 0x000A6D88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54233, XrefRangeEnd = 54238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600258E RID: 9614 RVA: 0x000A8C1C File Offset: 0x000A6E1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenPeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600258F RID: 9615 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
				public OpenPeerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002590 RID: 9616 RVA: 0x0000F2F9 File Offset: 0x0000D4F9
				public static implicit operator NetworkManager.FFIMethods.OpenPeerMethod(Func<IntPtr, ulong, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.OpenPeerMethod>(A_0);
				}

				// Token: 0x06002591 RID: 9617 RVA: 0x0000F301 File Offset: 0x0000D501
				public static NetworkManager.FFIMethods.OpenPeerMethod operator +(NetworkManager.FFIMethods.OpenPeerMethod A_0, NetworkManager.FFIMethods.OpenPeerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.OpenPeerMethod>();
				}

				// Token: 0x06002592 RID: 9618 RVA: 0x0000F30F File Offset: 0x0000D50F
				public static NetworkManager.FFIMethods.OpenPeerMethod operator -(NetworkManager.FFIMethods.OpenPeerMethod A_0, NetworkManager.FFIMethods.OpenPeerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.OpenPeerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B7D RID: 7037
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B7E RID: 7038
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0;

				// Token: 0x04001B7F RID: 7039
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0;

				// Token: 0x04001B80 RID: 7040
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002CF RID: 719
			public sealed class UpdatePeerMethod : MulticastDelegate
			{
				// Token: 0x06002593 RID: 9619 RVA: 0x000A8C6C File Offset: 0x000A6E6C
				// Note: this type is marked as 'beforefieldinit'.
				static UpdatePeerMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "UpdatePeerMethod");
					NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr, 100668046);
					NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr, 100668047);
					NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr, 100668048);
					NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr, 100668049);
				}

				// Token: 0x06002594 RID: 9620 RVA: 0x000A8CE0 File Offset: 0x000A6EE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdatePeerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.UpdatePeerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002595 RID: 9621 RVA: 0x000A8D3C File Offset: 0x000A6F3C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002596 RID: 9622 RVA: 0x000A8DA8 File Offset: 0x000A6FA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(routeData);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002597 RID: 9623 RVA: 0x000A8E3C File Offset: 0x000A703C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.UpdatePeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002598 RID: 9624 RVA: 0x0000F320 File Offset: 0x0000D520
				public UpdatePeerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002599 RID: 9625 RVA: 0x0000F329 File Offset: 0x0000D529
				public static implicit operator NetworkManager.FFIMethods.UpdatePeerMethod(Func<IntPtr, ulong, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.UpdatePeerMethod>(A_0);
				}

				// Token: 0x0600259A RID: 9626 RVA: 0x0000F331 File Offset: 0x0000D531
				public static NetworkManager.FFIMethods.UpdatePeerMethod operator +(NetworkManager.FFIMethods.UpdatePeerMethod A_0, NetworkManager.FFIMethods.UpdatePeerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.UpdatePeerMethod>();
				}

				// Token: 0x0600259B RID: 9627 RVA: 0x0000F33F File Offset: 0x0000D53F
				public static NetworkManager.FFIMethods.UpdatePeerMethod operator -(NetworkManager.FFIMethods.UpdatePeerMethod A_0, NetworkManager.FFIMethods.UpdatePeerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.UpdatePeerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B81 RID: 7041
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B82 RID: 7042
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_String_0;

				// Token: 0x04001B83 RID: 7043
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_String_AsyncCallback_Object_0;

				// Token: 0x04001B84 RID: 7044
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002D0 RID: 720
			public sealed class ClosePeerMethod : MulticastDelegate
			{
				// Token: 0x0600259C RID: 9628 RVA: 0x000A8E8C File Offset: 0x000A708C
				// Note: this type is marked as 'beforefieldinit'.
				static ClosePeerMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "ClosePeerMethod");
					NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr, 100668050);
					NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr, 100668051);
					NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr, 100668052);
					NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr, 100668053);
				}

				// Token: 0x0600259D RID: 9629 RVA: 0x000A8F00 File Offset: 0x000A7100
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ClosePeerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.ClosePeerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600259E RID: 9630 RVA: 0x000A8F5C File Offset: 0x000A715C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600259F RID: 9631 RVA: 0x000A8FB8 File Offset: 0x000A71B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54238, XrefRangeEnd = 54243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025A0 RID: 9632 RVA: 0x000A9038 File Offset: 0x000A7238
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.ClosePeerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060025A1 RID: 9633 RVA: 0x0000F350 File Offset: 0x0000D550
				public ClosePeerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025A2 RID: 9634 RVA: 0x0000F359 File Offset: 0x0000D559
				public static implicit operator NetworkManager.FFIMethods.ClosePeerMethod(Func<IntPtr, ulong, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.ClosePeerMethod>(A_0);
				}

				// Token: 0x060025A3 RID: 9635 RVA: 0x0000F361 File Offset: 0x0000D561
				public static NetworkManager.FFIMethods.ClosePeerMethod operator +(NetworkManager.FFIMethods.ClosePeerMethod A_0, NetworkManager.FFIMethods.ClosePeerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.ClosePeerMethod>();
				}

				// Token: 0x060025A4 RID: 9636 RVA: 0x0000F36F File Offset: 0x0000D56F
				public static NetworkManager.FFIMethods.ClosePeerMethod operator -(NetworkManager.FFIMethods.ClosePeerMethod A_0, NetworkManager.FFIMethods.ClosePeerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.ClosePeerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B85 RID: 7045
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B86 RID: 7046
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_0;

				// Token: 0x04001B87 RID: 7047
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_AsyncCallback_Object_0;

				// Token: 0x04001B88 RID: 7048
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002D1 RID: 721
			public sealed class OpenChannelMethod : MulticastDelegate
			{
				// Token: 0x060025A5 RID: 9637 RVA: 0x000A9088 File Offset: 0x000A7288
				// Note: this type is marked as 'beforefieldinit'.
				static OpenChannelMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "OpenChannelMethod");
					NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr, 100668054);
					NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr, 100668055);
					NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr, 100668056);
					NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr, 100668057);
				}

				// Token: 0x060025A6 RID: 9638 RVA: 0x000A90FC File Offset: 0x000A72FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenChannelMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.OpenChannelMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025A7 RID: 9639 RVA: 0x000A9158 File Offset: 0x000A7358
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060025A8 RID: 9640 RVA: 0x000A91D0 File Offset: 0x000A73D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54243, XrefRangeEnd = 54252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025A9 RID: 9641 RVA: 0x000A926C File Offset: 0x000A746C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.OpenChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060025AA RID: 9642 RVA: 0x0000F380 File Offset: 0x0000D580
				public OpenChannelMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025AB RID: 9643 RVA: 0x0000F389 File Offset: 0x0000D589
				public static implicit operator NetworkManager.FFIMethods.OpenChannelMethod(Func<IntPtr, ulong, byte, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.OpenChannelMethod>(A_0);
				}

				// Token: 0x060025AC RID: 9644 RVA: 0x0000F391 File Offset: 0x0000D591
				public static NetworkManager.FFIMethods.OpenChannelMethod operator +(NetworkManager.FFIMethods.OpenChannelMethod A_0, NetworkManager.FFIMethods.OpenChannelMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.OpenChannelMethod>();
				}

				// Token: 0x060025AD RID: 9645 RVA: 0x0000F39F File Offset: 0x0000D59F
				public static NetworkManager.FFIMethods.OpenChannelMethod operator -(NetworkManager.FFIMethods.OpenChannelMethod A_0, NetworkManager.FFIMethods.OpenChannelMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.OpenChannelMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B89 RID: 7049
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B8A RID: 7050
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Boolean_0;

				// Token: 0x04001B8B RID: 7051
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001B8C RID: 7052
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002D2 RID: 722
			public sealed class CloseChannelMethod : MulticastDelegate
			{
				// Token: 0x060025AE RID: 9646 RVA: 0x000A92BC File Offset: 0x000A74BC
				// Note: this type is marked as 'beforefieldinit'.
				static CloseChannelMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "CloseChannelMethod");
					NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr, 100668058);
					NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr, 100668059);
					NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr, 100668060);
					NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr, 100668061);
				}

				// Token: 0x060025AF RID: 9647 RVA: 0x000A9330 File Offset: 0x000A7530
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54252, XrefRangeEnd = 54255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CloseChannelMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.CloseChannelMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025B0 RID: 9648 RVA: 0x000A938C File Offset: 0x000A758C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060025B1 RID: 9649 RVA: 0x000A93F4 File Offset: 0x000A75F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54255, XrefRangeEnd = 54262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025B2 RID: 9650 RVA: 0x000A9484 File Offset: 0x000A7684
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.CloseChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060025B3 RID: 9651 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
				public CloseChannelMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025B4 RID: 9652 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
				public static implicit operator NetworkManager.FFIMethods.CloseChannelMethod(Func<IntPtr, ulong, byte, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.CloseChannelMethod>(A_0);
				}

				// Token: 0x060025B5 RID: 9653 RVA: 0x0000F3C1 File Offset: 0x0000D5C1
				public static NetworkManager.FFIMethods.CloseChannelMethod operator +(NetworkManager.FFIMethods.CloseChannelMethod A_0, NetworkManager.FFIMethods.CloseChannelMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.CloseChannelMethod>();
				}

				// Token: 0x060025B6 RID: 9654 RVA: 0x0000F3CF File Offset: 0x0000D5CF
				public static NetworkManager.FFIMethods.CloseChannelMethod operator -(NetworkManager.FFIMethods.CloseChannelMethod A_0, NetworkManager.FFIMethods.CloseChannelMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.CloseChannelMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B8D RID: 7053
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B8E RID: 7054
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_0;

				// Token: 0x04001B8F RID: 7055
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_AsyncCallback_Object_0;

				// Token: 0x04001B90 RID: 7056
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002D3 RID: 723
			public sealed class SendMessageMethod : MulticastDelegate
			{
				// Token: 0x060025B7 RID: 9655 RVA: 0x000A94D4 File Offset: 0x000A76D4
				// Note: this type is marked as 'beforefieldinit'.
				static SendMessageMethod()
				{
					Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager.FFIMethods>.NativeClassPtr, "SendMessageMethod");
					NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr, 100668062);
					NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr, 100668063);
					NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr, 100668064);
					NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr, 100668065);
				}

				// Token: 0x060025B8 RID: 9656 RVA: 0x000A9548 File Offset: 0x000A7748
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54262, XrefRangeEnd = 54265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendMessageMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.FFIMethods.SendMessageMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025B9 RID: 9657 RVA: 0x000A95A4 File Offset: 0x000A77A4
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, Il2CppStructArray<byte> data, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060025BA RID: 9658 RVA: 0x000A9630 File Offset: 0x000A7830
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54265, XrefRangeEnd = 54274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, Il2CppStructArray<byte> data, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025BB RID: 9659 RVA: 0x000A96E0 File Offset: 0x000A78E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.FFIMethods.SendMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060025BC RID: 9660 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
				public SendMessageMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025BD RID: 9661 RVA: 0x0000F3E9 File Offset: 0x0000D5E9
				public static implicit operator NetworkManager.FFIMethods.SendMessageMethod(Func<IntPtr, ulong, byte, Il2CppStructArray<byte>, int, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<NetworkManager.FFIMethods.SendMessageMethod>(A_0);
				}

				// Token: 0x060025BE RID: 9662 RVA: 0x0000F3F1 File Offset: 0x0000D5F1
				public static NetworkManager.FFIMethods.SendMessageMethod operator +(NetworkManager.FFIMethods.SendMessageMethod A_0, NetworkManager.FFIMethods.SendMessageMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<NetworkManager.FFIMethods.SendMessageMethod>();
				}

				// Token: 0x060025BF RID: 9663 RVA: 0x0000F3FF File Offset: 0x0000D5FF
				public static NetworkManager.FFIMethods.SendMessageMethod operator -(NetworkManager.FFIMethods.SendMessageMethod A_0, NetworkManager.FFIMethods.SendMessageMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<NetworkManager.FFIMethods.SendMessageMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B91 RID: 7057
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B92 RID: 7058
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_0;

				// Token: 0x04001B93 RID: 7059
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B94 RID: 7060
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}

		// Token: 0x0200022C RID: 556
		public sealed class MessageHandler : MulticastDelegate
		{
			// Token: 0x06002026 RID: 8230 RVA: 0x0009494C File Offset: 0x00092B4C
			// Note: this type is marked as 'beforefieldinit'.
			static MessageHandler()
			{
				Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "MessageHandler");
				NetworkManager.MessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr, 100668066);
				NetworkManager.MessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr, 100668067);
				NetworkManager.MessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr, 100668068);
				NetworkManager.MessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr, 100668069);
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x000949C0 File Offset: 0x00092BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54274, XrefRangeEnd = 54277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.MessageHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.MessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x00094A1C File Offset: 0x00092C1C
			[CallerCount(0)]
			public unsafe void Invoke(ulong peerId, byte channelId, Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref peerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.MessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x00094A7C File Offset: 0x00092C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54277, XrefRangeEnd = 54282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ulong peerId, byte channelId, Il2CppStructArray<byte> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref peerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.MessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600202A RID: 8234 RVA: 0x00094B10 File Offset: 0x00092D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.MessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600202B RID: 8235 RVA: 0x0000D2F5 File Offset: 0x0000B4F5
			public MessageHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600202C RID: 8236 RVA: 0x0000D2FE File Offset: 0x0000B4FE
			public static implicit operator NetworkManager.MessageHandler(Action<ulong, byte, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<NetworkManager.MessageHandler>(A_0);
			}

			// Token: 0x0600202D RID: 8237 RVA: 0x0000D306 File Offset: 0x0000B506
			public static NetworkManager.MessageHandler operator +(NetworkManager.MessageHandler A_0, NetworkManager.MessageHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NetworkManager.MessageHandler>();
			}

			// Token: 0x0600202E RID: 8238 RVA: 0x0000D314 File Offset: 0x0000B514
			public static NetworkManager.MessageHandler operator -(NetworkManager.MessageHandler A_0, NetworkManager.MessageHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<NetworkManager.MessageHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018EE RID: 6382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018EF RID: 6383
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x040018F0 RID: 6384
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;

			// Token: 0x040018F1 RID: 6385
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022D RID: 557
		public sealed class RouteUpdateHandler : MulticastDelegate
		{
			// Token: 0x0600202F RID: 8239 RVA: 0x00094B54 File Offset: 0x00092D54
			// Note: this type is marked as 'beforefieldinit'.
			static RouteUpdateHandler()
			{
				Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkManager>.NativeClassPtr, "RouteUpdateHandler");
				NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr, 100668070);
				NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr, 100668071);
				NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr, 100668072);
				NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr, 100668073);
			}

			// Token: 0x06002030 RID: 8240 RVA: 0x00094BC8 File Offset: 0x00092DC8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 51910, RefRangeEnd = 51916, XrefRangeStart = 51910, XrefRangeEnd = 51916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RouteUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkManager.RouteUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002031 RID: 8241 RVA: 0x00094C24 File Offset: 0x00092E24
			[CallerCount(0)]
			public unsafe void Invoke(string routeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(routeData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002032 RID: 8242 RVA: 0x00094C68 File Offset: 0x00092E68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string routeData, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(routeData);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002033 RID: 8243 RVA: 0x00094CDC File Offset: 0x00092EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkManager.RouteUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002034 RID: 8244 RVA: 0x0000D325 File Offset: 0x0000B525
			public RouteUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x0000D32E File Offset: 0x0000B52E
			public static implicit operator NetworkManager.RouteUpdateHandler(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<NetworkManager.RouteUpdateHandler>(A_0);
			}

			// Token: 0x06002036 RID: 8246 RVA: 0x0000D336 File Offset: 0x0000B536
			public static NetworkManager.RouteUpdateHandler operator +(NetworkManager.RouteUpdateHandler A_0, NetworkManager.RouteUpdateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NetworkManager.RouteUpdateHandler>();
			}

			// Token: 0x06002037 RID: 8247 RVA: 0x0000D344 File Offset: 0x0000B544
			public static NetworkManager.RouteUpdateHandler operator -(NetworkManager.RouteUpdateHandler A_0, NetworkManager.RouteUpdateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<NetworkManager.RouteUpdateHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018F2 RID: 6386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018F3 RID: 6387
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040018F4 RID: 6388
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040018F5 RID: 6389
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
