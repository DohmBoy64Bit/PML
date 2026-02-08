using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Mirror;
using SimpleJSON;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	// Token: 0x0200025E RID: 606
	public class PTAuthenticator : NetworkAuthenticator
	{
		// Token: 0x06002EDD RID: 11997 RVA: 0x000D80C8 File Offset: 0x000D62C8
		// Note: this type is marked as 'beforefieldinit'.
		static PTAuthenticator()
		{
			Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Networking", "PTAuthenticator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr);
			PTAuthenticator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670301);
			PTAuthenticator.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670293);
			PTAuthenticator.NativeMethodInfoPtr_OnServerAuthenticate_Public_Virtual_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670294);
			PTAuthenticator.NativeMethodInfoPtr_OnAuthRequestMessage_Public_Void_NetworkConnectionToClient_AuthRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670295);
			PTAuthenticator.NativeMethodInfoPtr_ValidateToken_Public_IEnumerator_NetworkConnectionToClient_AuthRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670296);
			PTAuthenticator.NativeMethodInfoPtr_DelayedDisconnect_Public_IEnumerator_NetworkConnectionToClient_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670297);
			PTAuthenticator.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670298);
			PTAuthenticator.NativeMethodInfoPtr_OnClientAuthenticate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670299);
			PTAuthenticator.NativeMethodInfoPtr_OnAuthResponseMessage_Public_Void_AuthResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, 100670300);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000D81AC File Offset: 0x000D63AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99442, XrefRangeEnd = 99443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PTAuthenticator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000D81E8 File Offset: 0x000D63E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99443, XrefRangeEnd = 99455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTAuthenticator.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000D8224 File Offset: 0x000D6424
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerAuthenticate(NetworkConnectionToClient conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTAuthenticator.NativeMethodInfoPtr_OnServerAuthenticate_Public_Virtual_Void_NetworkConnectionToClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000D8274 File Offset: 0x000D6474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99455, XrefRangeEnd = 99463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAuthRequestMessage(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator.NativeMethodInfoPtr_OnAuthRequestMessage_Public_Void_NetworkConnectionToClient_AuthRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000D82D0 File Offset: 0x000D64D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99463, XrefRangeEnd = 99470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ValidateToken(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator.NativeMethodInfoPtr_ValidateToken_Public_IEnumerator_NetworkConnectionToClient_AuthRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000D8338 File Offset: 0x000D6538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99470, XrefRangeEnd = 99475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator.NativeMethodInfoPtr_DelayedDisconnect_Public_IEnumerator_NetworkConnectionToClient_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000D8398 File Offset: 0x000D6598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99475, XrefRangeEnd = 99487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTAuthenticator.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000D83D4 File Offset: 0x000D65D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99487, XrefRangeEnd = 99504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientAuthenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTAuthenticator.NativeMethodInfoPtr_OnClientAuthenticate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000D8410 File Offset: 0x000D6610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99504, XrefRangeEnd = 99520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAuthResponseMessage(PTAuthenticator.AuthResponseMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator.NativeMethodInfoPtr_OnAuthResponseMessage_Public_Void_AuthResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00012D6C File Offset: 0x00010F6C
		public PTAuthenticator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr_OnServerAuthenticate_Public_Virtual_Void_NetworkConnectionToClient_0;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_OnAuthRequestMessage_Public_Void_NetworkConnectionToClient_AuthRequestMessage_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToken_Public_IEnumerator_NetworkConnectionToClient_AuthRequestMessage_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDisconnect_Public_IEnumerator_NetworkConnectionToClient_Single_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_OnClientAuthenticate_Public_Virtual_Void_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_OnAuthResponseMessage_Public_Void_AuthResponseMessage_0;

		// Token: 0x020003E5 RID: 997
		public sealed class AuthRequestMessage : ValueType
		{
			// Token: 0x06004D58 RID: 19800 RVA: 0x001500F8 File Offset: 0x0014E2F8
			// Note: this type is marked as 'beforefieldinit'.
			static AuthRequestMessage()
			{
				Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, "AuthRequestMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr);
				PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_clientToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr, "clientToken");
				PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_localUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr, "localUserId");
			}

			// Token: 0x06004D59 RID: 19801 RVA: 0x0001D30C File Offset: 0x0001B50C
			public AuthRequestMessage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004D5A RID: 19802 RVA: 0x0001D315 File Offset: 0x0001B515
			public AuthRequestMessage()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr))
			{
			}

			// Token: 0x17001A0B RID: 6667
			// (get) Token: 0x06004D5B RID: 19803 RVA: 0x0015014C File Offset: 0x0014E34C
			// (set) Token: 0x06004D5C RID: 19804 RVA: 0x0001D327 File Offset: 0x0001B527
			public unsafe string clientToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_clientToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_clientToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001A0C RID: 6668
			// (get) Token: 0x06004D5D RID: 19805 RVA: 0x00150174 File Offset: 0x0014E374
			// (set) Token: 0x06004D5E RID: 19806 RVA: 0x0001D346 File Offset: 0x0001B546
			public unsafe int localUserId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_localUserId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthRequestMessage.NativeFieldInfoPtr_localUserId)) = value;
				}
			}

			// Token: 0x04003C0B RID: 15371
			private static readonly IntPtr NativeFieldInfoPtr_clientToken;

			// Token: 0x04003C0C RID: 15372
			private static readonly IntPtr NativeFieldInfoPtr_localUserId;
		}

		// Token: 0x020003E6 RID: 998
		public sealed class AuthResponseMessage : ValueType
		{
			// Token: 0x06004D5F RID: 19807 RVA: 0x0015019C File Offset: 0x0014E39C
			// Note: this type is marked as 'beforefieldinit'.
			static AuthResponseMessage()
			{
				Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, "AuthResponseMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr);
				PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr, "code");
				PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr, "message");
				PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr, "instanceCount");
			}

			// Token: 0x06004D60 RID: 19808 RVA: 0x0001D361 File Offset: 0x0001B561
			public AuthResponseMessage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004D61 RID: 19809 RVA: 0x0001D36A File Offset: 0x0001B56A
			public AuthResponseMessage()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr))
			{
			}

			// Token: 0x17001A0D RID: 6669
			// (get) Token: 0x06004D62 RID: 19810 RVA: 0x00150204 File Offset: 0x0014E404
			// (set) Token: 0x06004D63 RID: 19811 RVA: 0x0001D37C File Offset: 0x0001B57C
			public unsafe byte code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_code);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_code)) = value;
				}
			}

			// Token: 0x17001A0E RID: 6670
			// (get) Token: 0x06004D64 RID: 19812 RVA: 0x0015022C File Offset: 0x0014E42C
			// (set) Token: 0x06004D65 RID: 19813 RVA: 0x0001D397 File Offset: 0x0001B597
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001A0F RID: 6671
			// (get) Token: 0x06004D66 RID: 19814 RVA: 0x00150254 File Offset: 0x0014E454
			// (set) Token: 0x06004D67 RID: 19815 RVA: 0x0001D3B6 File Offset: 0x0001B5B6
			public unsafe int instanceCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_instanceCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator.AuthResponseMessage.NativeFieldInfoPtr_instanceCount)) = value;
				}
			}

			// Token: 0x04003C0D RID: 15373
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x04003C0E RID: 15374
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04003C0F RID: 15375
			private static readonly IntPtr NativeFieldInfoPtr_instanceCount;
		}

		// Token: 0x020003E7 RID: 999
		[ObfuscatedName("Polytoria.Networking.PTAuthenticator+<DelayedDisconnect>d__6")]
		public sealed class _DelayedDisconnect_d__6 : Object
		{
			// Token: 0x06004D68 RID: 19816 RVA: 0x0015027C File Offset: 0x0014E47C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDisconnect_d__6()
			{
				Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, "<DelayedDisconnect>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr);
				PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, "<>1__state");
				PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, "<>2__current");
				PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, "waitTime");
				PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, "conn");
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670305);
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670307);
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670302);
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670303);
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670304);
				PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr, 100670306);
			}

			// Token: 0x17001A14 RID: 6676
			// (get) Token: 0x06004D69 RID: 19817 RVA: 0x00150370 File Offset: 0x0014E570
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A15 RID: 6677
			// (get) Token: 0x06004D6A RID: 19818 RVA: 0x001503B0 File Offset: 0x0014E5B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D6B RID: 19819 RVA: 0x001503F0 File Offset: 0x0014E5F0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDisconnect_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTAuthenticator._DelayedDisconnect_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x00150438 File Offset: 0x0014E638
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x0015046C File Offset: 0x0014E66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99278, XrefRangeEnd = 99283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x001504A8 File Offset: 0x0014E6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99283, XrefRangeEnd = 99288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._DelayedDisconnect_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6F RID: 19823 RVA: 0x0001D3D1 File Offset: 0x0001B5D1
			public _DelayedDisconnect_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A10 RID: 6672
			// (get) Token: 0x06004D70 RID: 19824 RVA: 0x001504DC File Offset: 0x0014E6DC
			// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0001D3DA File Offset: 0x0001B5DA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A11 RID: 6673
			// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00150504 File Offset: 0x0014E704
			// (set) Token: 0x06004D73 RID: 19827 RVA: 0x0001D3F5 File Offset: 0x0001B5F5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A12 RID: 6674
			// (get) Token: 0x06004D74 RID: 19828 RVA: 0x00150534 File Offset: 0x0014E734
			// (set) Token: 0x06004D75 RID: 19829 RVA: 0x0001D414 File Offset: 0x0001B614
			public unsafe float waitTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_waitTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_waitTime)) = value;
				}
			}

			// Token: 0x17001A13 RID: 6675
			// (get) Token: 0x06004D76 RID: 19830 RVA: 0x0015055C File Offset: 0x0014E75C
			// (set) Token: 0x06004D77 RID: 19831 RVA: 0x0001D42F File Offset: 0x0001B62F
			public unsafe NetworkConnectionToClient conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnectionToClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._DelayedDisconnect_d__6.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C10 RID: 15376
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C11 RID: 15377
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C12 RID: 15378
			private static readonly IntPtr NativeFieldInfoPtr_waitTime;

			// Token: 0x04003C13 RID: 15379
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04003C14 RID: 15380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C15 RID: 15381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C16 RID: 15382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C17 RID: 15383
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C18 RID: 15384
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C19 RID: 15385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003E8 RID: 1000
		[ObfuscatedName("Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5")]
		public sealed class _ValidateToken_d__5 : Object
		{
			// Token: 0x06004D78 RID: 19832 RVA: 0x0015058C File Offset: 0x0014E78C
			// Note: this type is marked as 'beforefieldinit'.
			static _ValidateToken_d__5()
			{
				Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTAuthenticator>.NativeClassPtr, "<ValidateToken>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr);
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<>1__state");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<>2__current");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "msg");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "conn");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<>4__this");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__authResponseMessage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<authResponseMessage>5__2");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__approve_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<approve>5__3");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__tokenData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<tokenData>5__4");
				PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__uwr_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, "<uwr>5__5");
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670313);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670315);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670308);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670309);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670310);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670311);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670312);
				PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr, 100670314);
			}

			// Token: 0x17001A1F RID: 6687
			// (get) Token: 0x06004D79 RID: 19833 RVA: 0x0015070C File Offset: 0x0014E90C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A20 RID: 6688
			// (get) Token: 0x06004D7A RID: 19834 RVA: 0x0015074C File Offset: 0x0014E94C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D7B RID: 19835 RVA: 0x0015078C File Offset: 0x0014E98C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ValidateToken_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTAuthenticator._ValidateToken_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D7C RID: 19836 RVA: 0x001507D4 File Offset: 0x0014E9D4
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D7D RID: 19837 RVA: 0x00150808 File Offset: 0x0014EA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99288, XrefRangeEnd = 99431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004D7E RID: 19838 RVA: 0x00150844 File Offset: 0x0014EA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99431, XrefRangeEnd = 99434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D7F RID: 19839 RVA: 0x00150878 File Offset: 0x0014EA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99434, XrefRangeEnd = 99437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x001508AC File Offset: 0x0014EAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99437, XrefRangeEnd = 99442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTAuthenticator._ValidateToken_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D81 RID: 19841 RVA: 0x0001D44E File Offset: 0x0001B64E
			public _ValidateToken_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A16 RID: 6678
			// (get) Token: 0x06004D82 RID: 19842 RVA: 0x001508E0 File Offset: 0x0014EAE0
			// (set) Token: 0x06004D83 RID: 19843 RVA: 0x0001D457 File Offset: 0x0001B657
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A17 RID: 6679
			// (get) Token: 0x06004D84 RID: 19844 RVA: 0x00150908 File Offset: 0x0014EB08
			// (set) Token: 0x06004D85 RID: 19845 RVA: 0x0001D472 File Offset: 0x0001B672
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A18 RID: 6680
			// (get) Token: 0x06004D86 RID: 19846 RVA: 0x00150938 File Offset: 0x0014EB38
			// (set) Token: 0x06004D87 RID: 19847 RVA: 0x0001D491 File Offset: 0x0001B691
			public PTAuthenticator.AuthRequestMessage msg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_msg);
					return new PTAuthenticator.AuthRequestMessage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_msg), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PTAuthenticator.AuthRequestMessage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001A19 RID: 6681
			// (get) Token: 0x06004D88 RID: 19848 RVA: 0x00150968 File Offset: 0x0014EB68
			// (set) Token: 0x06004D89 RID: 19849 RVA: 0x0001D4BF File Offset: 0x0001B6BF
			public unsafe NetworkConnectionToClient conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnectionToClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A1A RID: 6682
			// (get) Token: 0x06004D8A RID: 19850 RVA: 0x00150998 File Offset: 0x0014EB98
			// (set) Token: 0x06004D8B RID: 19851 RVA: 0x0001D4DE File Offset: 0x0001B6DE
			public unsafe PTAuthenticator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PTAuthenticator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A1B RID: 6683
			// (get) Token: 0x06004D8C RID: 19852 RVA: 0x001509C8 File Offset: 0x0014EBC8
			// (set) Token: 0x06004D8D RID: 19853 RVA: 0x0001D4FD File Offset: 0x0001B6FD
			public PTAuthenticator.AuthResponseMessage _authResponseMessage_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__authResponseMessage_5__2);
					return new PTAuthenticator.AuthResponseMessage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__authResponseMessage_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PTAuthenticator.AuthResponseMessage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001A1C RID: 6684
			// (get) Token: 0x06004D8E RID: 19854 RVA: 0x001509F8 File Offset: 0x0014EBF8
			// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0001D52B File Offset: 0x0001B72B
			public unsafe bool _approve_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__approve_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__approve_5__3)) = value;
				}
			}

			// Token: 0x17001A1D RID: 6685
			// (get) Token: 0x06004D90 RID: 19856 RVA: 0x00150A20 File Offset: 0x0014EC20
			// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0001D546 File Offset: 0x0001B746
			public unsafe JSONNode _tokenData_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__tokenData_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__tokenData_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A1E RID: 6686
			// (get) Token: 0x06004D92 RID: 19858 RVA: 0x00150A50 File Offset: 0x0014EC50
			// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0001D565 File Offset: 0x0001B765
			public unsafe UnityWebRequest _uwr_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__uwr_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTAuthenticator._ValidateToken_d__5.NativeFieldInfoPtr__uwr_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C1A RID: 15386
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C1B RID: 15387
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C1C RID: 15388
			private static readonly IntPtr NativeFieldInfoPtr_msg;

			// Token: 0x04003C1D RID: 15389
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04003C1E RID: 15390
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C1F RID: 15391
			private static readonly IntPtr NativeFieldInfoPtr__authResponseMessage_5__2;

			// Token: 0x04003C20 RID: 15392
			private static readonly IntPtr NativeFieldInfoPtr__approve_5__3;

			// Token: 0x04003C21 RID: 15393
			private static readonly IntPtr NativeFieldInfoPtr__tokenData_5__4;

			// Token: 0x04003C22 RID: 15394
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__5;

			// Token: 0x04003C23 RID: 15395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C24 RID: 15396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C25 RID: 15397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C26 RID: 15398
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C27 RID: 15399
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C28 RID: 15400
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003C29 RID: 15401
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003C2A RID: 15402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
