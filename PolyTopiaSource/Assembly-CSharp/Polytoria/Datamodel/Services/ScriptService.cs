using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Proxies;
using Polytoria.Datamodel.Proxies.Services;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CC RID: 716
	public class ScriptService : Instance
	{
		// Token: 0x06003F36 RID: 16182 RVA: 0x0011BA78 File Offset: 0x00119C78
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptService()
		{
			Il2CppClassPointerStore<ScriptService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "ScriptService");
			ScriptService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "<Instance>k__BackingField");
			ScriptService.NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "payload");
			ScriptService.NativeFieldInfoPtr_scripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "scripts");
			ScriptService.NativeFieldInfoPtr_scriptsLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "scriptsLocal");
			ScriptService.NativeFieldInfoPtr_allowList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "allowList");
			ScriptService.NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "rsa");
			ScriptService.NativeFieldInfoPtr_receivedAllowlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "receivedAllowlist");
			ScriptService.NativeFieldInfoPtr__hashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "_hashes");
			ScriptService.NativeFieldInfoPtr__signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "_signature");
			ScriptService.NativeFieldInfoPtr__pubKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "_pubKey");
			ScriptService.NativeMethodInfoPtr_get_Instance_Public_Static_get_ScriptService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673058);
			ScriptService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ScriptService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673059);
			ScriptService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673083);
			ScriptService.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673060);
			ScriptService.NativeMethodInfoPtr_RunScripts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673061);
			ScriptService.NativeMethodInfoPtr_RunLocalScripts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673062);
			ScriptService.NativeMethodInfoPtr_GenerateAllowList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673063);
			ScriptService.NativeMethodInfoPtr_SendAllowList_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673064);
			ScriptService.NativeMethodInfoPtr_TargetReceiveAllowList_Public_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673065);
			ScriptService.NativeMethodInfoPtr_GetLocalScripts_Private_Void_Instance_List_1_LocalScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673066);
			ScriptService.NativeMethodInfoPtr_RpcReceiveAllowlist_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673067);
			ScriptService.NativeMethodInfoPtr_ReceivedAllowList_Private_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673068);
			ScriptService.NativeMethodInfoPtr_CheckForLocalScripts_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673069);
			ScriptService.NativeMethodInfoPtr_CheckForScripts_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673070);
			ScriptService.NativeMethodInfoPtr_RunScript_Public_Void_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673071);
			ScriptService.NativeMethodInfoPtr_RunScriptInstance_Private_IEnumerator_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673072);
			ScriptService.NativeMethodInfoPtr_LuaSpawn_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673073);
			ScriptService.NativeMethodInfoPtr_LuaRequire_Public_DynValue_ModuleScript_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673074);
			ScriptService.NativeMethodInfoPtr_LuaPrint_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673075);
			ScriptService.NativeMethodInfoPtr_RpcOnLuaPrintReceive_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673076);
			ScriptService.NativeMethodInfoPtr_ResumeScriptCoroutine_Private_DynValue_DynValue_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673077);
			ScriptService.NativeMethodInfoPtr_ExecuteScriptInstance_Private_DynValue_Script_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673078);
			ScriptService.NativeMethodInfoPtr_CallFunc_Public_Void_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673079);
			ScriptService.NativeMethodInfoPtr_InvokeEvent_Public_IEnumerator_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673080);
			ScriptService.NativeMethodInfoPtr_Tick_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673081);
			ScriptService.NativeMethodInfoPtr_GameTime_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673082);
			ScriptService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673084);
			ScriptService.NativeMethodInfoPtr_Method_Protected_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673085);
			ScriptService.NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673086);
			ScriptService.NativeMethodInfoPtr_Method_Protected_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673087);
			ScriptService.NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673088);
			ScriptService.NativeMethodInfoPtr_UserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673089);
			ScriptService.NativeMethodInfoPtr_InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, 100673090);
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x0011BDFC File Offset: 0x00119FFC
		// (set) Token: 0x06003F38 RID: 16184 RVA: 0x0011BE30 File Offset: 0x0011A030
		public unsafe static ScriptService Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125964, XrefRangeEnd = 125968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_get_Instance_Public_Static_get_ScriptService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125968, XrefRangeEnd = 125974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ScriptService_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0011BE68 File Offset: 0x0011A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125974, XrefRangeEnd = 125997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0011BEA4 File Offset: 0x0011A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125997, XrefRangeEnd = 127511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptService.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0011BEE0 File Offset: 0x0011A0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127542, RefRangeEnd = 127543, XrefRangeStart = 127511, XrefRangeEnd = 127542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunScripts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RunScripts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0011BF14 File Offset: 0x0011A114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127572, RefRangeEnd = 127573, XrefRangeStart = 127543, XrefRangeEnd = 127572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunLocalScripts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RunLocalScripts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0011BF48 File Offset: 0x0011A148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127665, RefRangeEnd = 127667, XrefRangeStart = 127573, XrefRangeEnd = 127665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateAllowList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_GenerateAllowList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0011BF7C File Offset: 0x0011A17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127686, RefRangeEnd = 127687, XrefRangeStart = 127667, XrefRangeEnd = 127686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAllowList(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_SendAllowList_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0011BFC0 File Offset: 0x0011A1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127687, XrefRangeEnd = 127710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TargetReceiveAllowList(NetworkConnection target, Il2CppStringArray hashes, Il2CppStructArray<byte> sig, string pubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sig);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_TargetReceiveAllowList_Public_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0011C03C File Offset: 0x0011A23C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127718, RefRangeEnd = 127720, XrefRangeStart = 127710, XrefRangeEnd = 127718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalScripts(Instance parent, List<LocalScript> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_GetLocalScripts_Private_Void_Instance_List_1_LocalScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0011C090 File Offset: 0x0011A290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127720, XrefRangeEnd = 127743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReceiveAllowlist(Il2CppStringArray hashes, Il2CppStructArray<byte> sig, string pubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sig);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RpcReceiveAllowlist_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x0011C0F8 File Offset: 0x0011A2F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 127798, RefRangeEnd = 127802, XrefRangeStart = 127743, XrefRangeEnd = 127798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedAllowList(Il2CppStringArray hashes, Il2CppStructArray<byte> sig, string pubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sig);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_ReceivedAllowList_Private_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0011C160 File Offset: 0x0011A360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127810, RefRangeEnd = 127812, XrefRangeStart = 127802, XrefRangeEnd = 127810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForLocalScripts(Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_CheckForLocalScripts_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0011C1A4 File Offset: 0x0011A3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127820, RefRangeEnd = 127822, XrefRangeStart = 127812, XrefRangeEnd = 127820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForScripts(Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_CheckForScripts_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x0011C1E8 File Offset: 0x0011A3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127833, RefRangeEnd = 127834, XrefRangeStart = 127822, XrefRangeEnd = 127833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunScript(BaseScript s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RunScript_Public_Void_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0011C22C File Offset: 0x0011A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127834, XrefRangeEnd = 127840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RunScriptInstance(BaseScript scriptInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RunScriptInstance_Private_IEnumerator_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0011C27C File Offset: 0x0011A47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127840, XrefRangeEnd = 127844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LuaSpawn(DynValue func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_LuaSpawn_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0011C2C0 File Offset: 0x0011A4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127846, RefRangeEnd = 127847, XrefRangeStart = 127844, XrefRangeEnd = 127846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LuaRequire(ModuleScript moduleScript, Script script)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleScript);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_LuaRequire_Public_DynValue_ModuleScript_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0011C324 File Offset: 0x0011A524
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 127890, RefRangeEnd = 127895, XrefRangeStart = 127847, XrefRangeEnd = 127890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LuaPrint(string message, bool error = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_LuaPrint_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0011C374 File Offset: 0x0011A574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127895, XrefRangeEnd = 127917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcOnLuaPrintReceive(string message, bool error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_RpcOnLuaPrintReceive_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0011C3C4 File Offset: 0x0011A5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127942, RefRangeEnd = 127943, XrefRangeStart = 127917, XrefRangeEnd = 127942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, [Optional] Il2CppReferenceArray<Object> par)
		{
			if (par == null)
			{
				par = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_ResumeScriptCoroutine_Private_DynValue_DynValue_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0011C448 File Offset: 0x0011A648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127943, XrefRangeEnd = 127968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue ExecuteScriptInstance(Script script, BaseScript s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_ExecuteScriptInstance_Private_DynValue_Script_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x0011C4AC File Offset: 0x0011A6AC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 127977, RefRangeEnd = 128007, XrefRangeStart = 127968, XrefRangeEnd = 127977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallFunc(DynValue func, [Optional] Il2CppReferenceArray<Object> par)
		{
			if (par == null)
			{
				par = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_CallFunc_Public_Void_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x0011C510 File Offset: 0x0011A710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128007, XrefRangeEnd = 128014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InvokeEvent(DynValue func, [Optional] Il2CppReferenceArray<Object> par)
		{
			if (par == null)
			{
				par = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_InvokeEvent_Public_IEnumerator_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0011C580 File Offset: 0x0011A780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128014, XrefRangeEnd = 128024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_Tick_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0011C5BC File Offset: 0x0011A7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128024, XrefRangeEnd = 128025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GameTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_GameTime_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0011C5F8 File Offset: 0x0011A7F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0011C640 File Offset: 0x0011A840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128025, XrefRangeEnd = 128026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Protected_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0(NetworkConnection target, Il2CppStringArray hashes, Il2CppStructArray<byte> sig, string pubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sig);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_Method_Protected_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0011C6BC File Offset: 0x0011A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128026, XrefRangeEnd = 128038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_0(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0011C718 File Offset: 0x0011A918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128038, XrefRangeEnd = 128039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Protected_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0(Il2CppStringArray hashes, Il2CppStructArray<byte> sig, string pubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sig);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_Method_Protected_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0011C780 File Offset: 0x0011A980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128039, XrefRangeEnd = 128051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_1(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0011C7DC File Offset: 0x0011A9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128051, XrefRangeEnd = 128057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcOnLuaPrintReceive__String__Boolean(string message, bool error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_UserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0011C82C File Offset: 0x0011AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128057, XrefRangeEnd = 128078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.NativeMethodInfoPtr_InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0001830A File Offset: 0x0001650A
		public DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, params Object[] par)
		{
			return this.ResumeScriptCoroutine(coroutine, identifier, new Il2CppReferenceArray<Object>(par));
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0001831A File Offset: 0x0001651A
		public void CallFunc(DynValue func, params Object[] par)
		{
			this.CallFunc(func, new Il2CppReferenceArray<Object>(par));
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00018329 File Offset: 0x00016529
		public IEnumerator InvokeEvent(DynValue func, params Object[] par)
		{
			return this.InvokeEvent(func, new Il2CppReferenceArray<Object>(par));
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00018338 File Offset: 0x00016538
		public ScriptService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x0011C888 File Offset: 0x0011AA88
		// (set) Token: 0x06003F5D RID: 16221 RVA: 0x00018341 File Offset: 0x00016541
		public unsafe static ScriptService _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x0011C8B0 File Offset: 0x0011AAB0
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x00018353 File Offset: 0x00016553
		public unsafe static string payload
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptService.NativeFieldInfoPtr_payload, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptService.NativeFieldInfoPtr_payload, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x0011C8D0 File Offset: 0x0011AAD0
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x00018365 File Offset: 0x00016565
		public unsafe List<BaseScript> scripts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_scripts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseScript>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_scripts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x0011C900 File Offset: 0x0011AB00
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x00018384 File Offset: 0x00016584
		public unsafe List<BaseScript> scriptsLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_scriptsLocal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseScript>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_scriptsLocal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x0011C930 File Offset: 0x0011AB30
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x000183A3 File Offset: 0x000165A3
		public unsafe HashSet<string> allowList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_allowList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_allowList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x0011C960 File Offset: 0x0011AB60
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x000183C2 File Offset: 0x000165C2
		public unsafe RSACryptoServiceProvider rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x0011C990 File Offset: 0x0011AB90
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x000183E1 File Offset: 0x000165E1
		public unsafe bool receivedAllowlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_receivedAllowlist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr_receivedAllowlist)) = value;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x0011C9B8 File Offset: 0x0011ABB8
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x000183FC File Offset: 0x000165FC
		public unsafe Il2CppStringArray _hashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__hashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__hashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x0011C9E8 File Offset: 0x0011ABE8
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x0001841B File Offset: 0x0001661B
		public unsafe Il2CppStructArray<byte> _signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x0011CA18 File Offset: 0x0011AC18
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x0001843A File Offset: 0x0001663A
		public unsafe string _pubKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__pubKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.NativeFieldInfoPtr__pubKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeFieldInfoPtr_payload;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeFieldInfoPtr_scripts;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeFieldInfoPtr_scriptsLocal;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeFieldInfoPtr_allowList;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeFieldInfoPtr_rsa;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeFieldInfoPtr_receivedAllowlist;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeFieldInfoPtr__hashes;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeFieldInfoPtr__signature;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeFieldInfoPtr__pubKey;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ScriptService_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ScriptService_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr_RunScripts_Public_Void_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_RunLocalScripts_Public_Void_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAllowList_Private_Void_0;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeMethodInfoPtr_SendAllowList_Public_Void_Player_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr_TargetReceiveAllowList_Public_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalScripts_Private_Void_Instance_List_1_LocalScript_0;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeMethodInfoPtr_RpcReceiveAllowlist_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedAllowList_Private_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeMethodInfoPtr_CheckForLocalScripts_Private_Void_Instance_0;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr_CheckForScripts_Private_Void_Instance_0;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeMethodInfoPtr_RunScript_Public_Void_BaseScript_0;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeMethodInfoPtr_RunScriptInstance_Private_IEnumerator_BaseScript_0;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeMethodInfoPtr_LuaSpawn_Public_Void_DynValue_0;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeMethodInfoPtr_LuaRequire_Public_DynValue_ModuleScript_Script_0;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeMethodInfoPtr_LuaPrint_Public_Void_String_Boolean_0;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeMethodInfoPtr_RpcOnLuaPrintReceive_Private_Void_String_Boolean_0;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeMethodInfoPtr_ResumeScriptCoroutine_Private_DynValue_DynValue_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteScriptInstance_Private_DynValue_Script_BaseScript_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_CallFunc_Public_Void_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEvent_Public_IEnumerator_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Private_Single_0;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr_GameTime_Private_Single_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Void_NetworkConnection_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_0;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Void_Il2CppStringArray_Il2CppStructArray_1_Byte_String_PDM_0;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_PDM_1;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Void_String_Boolean_0;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x02000413 RID: 1043
		[ObfuscatedName("Polytoria.Datamodel.Services.ScriptService+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004FAB RID: 20395 RVA: 0x00156D04 File Offset: 0x00154F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr);
				ScriptService.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9");
				ScriptService.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_0");
				ScriptService.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_1");
				ScriptService.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_2");
				ScriptService.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_3");
				ScriptService.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_4");
				ScriptService.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_5");
				ScriptService.__c.NativeFieldInfoPtr___9__5_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_6");
				ScriptService.__c.NativeFieldInfoPtr___9__5_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_7");
				ScriptService.__c.NativeFieldInfoPtr___9__5_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_8");
				ScriptService.__c.NativeFieldInfoPtr___9__5_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_9");
				ScriptService.__c.NativeFieldInfoPtr___9__5_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_10");
				ScriptService.__c.NativeFieldInfoPtr___9__5_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_11");
				ScriptService.__c.NativeFieldInfoPtr___9__5_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_12");
				ScriptService.__c.NativeFieldInfoPtr___9__5_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_13");
				ScriptService.__c.NativeFieldInfoPtr___9__5_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_14");
				ScriptService.__c.NativeFieldInfoPtr___9__5_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_15");
				ScriptService.__c.NativeFieldInfoPtr___9__5_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_16");
				ScriptService.__c.NativeFieldInfoPtr___9__5_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_17");
				ScriptService.__c.NativeFieldInfoPtr___9__5_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_18");
				ScriptService.__c.NativeFieldInfoPtr___9__5_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_19");
				ScriptService.__c.NativeFieldInfoPtr___9__5_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_20");
				ScriptService.__c.NativeFieldInfoPtr___9__5_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_21");
				ScriptService.__c.NativeFieldInfoPtr___9__5_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_22");
				ScriptService.__c.NativeFieldInfoPtr___9__5_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_23");
				ScriptService.__c.NativeFieldInfoPtr___9__5_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_24");
				ScriptService.__c.NativeFieldInfoPtr___9__5_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_25");
				ScriptService.__c.NativeFieldInfoPtr___9__5_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_26");
				ScriptService.__c.NativeFieldInfoPtr___9__5_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_27");
				ScriptService.__c.NativeFieldInfoPtr___9__5_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_28");
				ScriptService.__c.NativeFieldInfoPtr___9__5_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_29");
				ScriptService.__c.NativeFieldInfoPtr___9__5_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_30");
				ScriptService.__c.NativeFieldInfoPtr___9__5_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_31");
				ScriptService.__c.NativeFieldInfoPtr___9__5_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_32");
				ScriptService.__c.NativeFieldInfoPtr___9__5_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_33");
				ScriptService.__c.NativeFieldInfoPtr___9__5_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_34");
				ScriptService.__c.NativeFieldInfoPtr___9__5_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_35");
				ScriptService.__c.NativeFieldInfoPtr___9__5_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_36");
				ScriptService.__c.NativeFieldInfoPtr___9__5_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_37");
				ScriptService.__c.NativeFieldInfoPtr___9__5_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_38");
				ScriptService.__c.NativeFieldInfoPtr___9__5_39 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_39");
				ScriptService.__c.NativeFieldInfoPtr___9__5_40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_40");
				ScriptService.__c.NativeFieldInfoPtr___9__5_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_41");
				ScriptService.__c.NativeFieldInfoPtr___9__5_42 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_42");
				ScriptService.__c.NativeFieldInfoPtr___9__5_43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_43");
				ScriptService.__c.NativeFieldInfoPtr___9__5_44 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_44");
				ScriptService.__c.NativeFieldInfoPtr___9__5_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_45");
				ScriptService.__c.NativeFieldInfoPtr___9__5_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_46");
				ScriptService.__c.NativeFieldInfoPtr___9__5_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_47");
				ScriptService.__c.NativeFieldInfoPtr___9__5_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_48");
				ScriptService.__c.NativeFieldInfoPtr___9__5_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_49");
				ScriptService.__c.NativeFieldInfoPtr___9__5_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_50");
				ScriptService.__c.NativeFieldInfoPtr___9__5_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_51");
				ScriptService.__c.NativeFieldInfoPtr___9__5_52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_52");
				ScriptService.__c.NativeFieldInfoPtr___9__5_53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_53");
				ScriptService.__c.NativeFieldInfoPtr___9__5_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_54");
				ScriptService.__c.NativeFieldInfoPtr___9__5_55 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_55");
				ScriptService.__c.NativeFieldInfoPtr___9__5_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_56");
				ScriptService.__c.NativeFieldInfoPtr___9__5_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_57");
				ScriptService.__c.NativeFieldInfoPtr___9__5_58 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_58");
				ScriptService.__c.NativeFieldInfoPtr___9__5_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_59");
				ScriptService.__c.NativeFieldInfoPtr___9__5_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_60");
				ScriptService.__c.NativeFieldInfoPtr___9__5_61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_61");
				ScriptService.__c.NativeFieldInfoPtr___9__5_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_62");
				ScriptService.__c.NativeFieldInfoPtr___9__5_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_63");
				ScriptService.__c.NativeFieldInfoPtr___9__5_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_64");
				ScriptService.__c.NativeFieldInfoPtr___9__5_65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_65");
				ScriptService.__c.NativeFieldInfoPtr___9__5_66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_66");
				ScriptService.__c.NativeFieldInfoPtr___9__5_67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_67");
				ScriptService.__c.NativeFieldInfoPtr___9__5_68 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_68");
				ScriptService.__c.NativeFieldInfoPtr___9__5_69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__5_69");
				ScriptService.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__14_0");
				ScriptService.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, "<>9__15_0");
				ScriptService.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673093);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_0_Internal_InstanceProxy_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673094);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_1_Internal_DynamicInstanceProxy_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673095);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_2_Internal_PartProxy_Part_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673096);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_3_Internal_GameProxy_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673097);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_4_Internal_BaseScriptProxy_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673098);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_5_Internal_ScriptInstanceProxy_ScriptInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673099);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_6_Internal_LocalScriptProxy_LocalScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673100);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_7_Internal_ModuleScriptProxy_ModuleScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673101);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_8_Internal_RemoveEventProxy_RemoteEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673102);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_9_Internal_EnvironmentProxy_Environment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673103);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_10_Internal_PlayerProxy_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673104);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_11_Internal_PlayersProxy_Players_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673105);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_12_Internal_Text3DProxy_Text3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673106);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_13_Internal_SoundProxy_Sound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673107);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_14_Internal_ToolProxy_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673108);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_15_Internal_NPCProxy_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673109);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_16_Internal_SpotlightProxy_Spotlight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673110);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_17_Internal_ValueBaseProxy_ValueBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673111);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_18_Internal_BoolValueProxy_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673112);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_19_Internal_ColorValueProxy_ColorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673113);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_20_Internal_StringValueProxy_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673114);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_21_Internal_InstanceValueProxy_InstanceValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673115);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_22_Internal_IntValueProxy_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673116);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_23_Internal_NumberValueProxy_NumberValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673117);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_24_Internal_Vector3ValueProxy_Vector3Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673118);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_25_Internal_MeshPartProxy_MeshPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673119);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_26_Internal_BodyPositionProxy_BodyPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673120);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_27_Internal_BackpackProxy_Backpack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673121);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_28_Internal_LightingProxy_Lighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673122);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_29_Internal_SunLightProxy_SunLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673123);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_30_Internal_ClimbableProxy_Climbable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673124);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_31_Internal_DecalProxy_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673125);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_32_Internal_ParticlesProxy_Particles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673126);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_33_Internal_HiddenProxy_Hidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673127);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_34_Internal_ServerHiddenProxy_ServerHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673128);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_35_Internal_ModelProxy_Model_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673129);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_36_Internal_PointLightProxy_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673130);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_37_Internal_TrussProxy_Truss_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673131);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_38_Internal_SeatProxy_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673132);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_39_Internal_SkyBaseProxy_SkyBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673133);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_40_Internal_ImageSkyProxy_ImageSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673134);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_41_Internal_GradientSkyProxy_GradientSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673135);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_42_Internal_ProceduralSkyProxy_ProceduralSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673136);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_43_Internal_NetworkEventProxy_NetworkEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673137);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_44_Internal_SignalProxy_Signal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673138);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_45_Internal_PlayerDefaultsProxy_PlayerDefaults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673139);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_46_Internal_GUIProxy_GUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673140);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_47_Internal_UIButtonProxy_UIButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673141);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_48_Internal_UIFieldProxy_UIField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673142);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_49_Internal_UILabelProxy_UILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673143);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_50_Internal_UITextInputProxy_UITextInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673144);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_51_Internal_UIViewProxy_UIView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673145);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_52_Internal_UIImageProxy_UIImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673146);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_53_Internal_UIHVLayoutProxy_UIHVLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673147);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_54_Internal_UIVerticalLayoutProxy_UIVerticalLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673148);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_55_Internal_UIHorizontalLayoutProxy_UIHorizontalLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673149);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_56_Internal_PlayerGUIProxy_PlayerGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673150);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_57_Internal_CameraProxy_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673151);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_58_Internal_DatastoreProxy_Datastore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673152);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_59_Internal_AchievementServiceProxy_AchievementService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673153);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_60_Internal_PurchasesServiceProxy_PurchasesService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673154);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_61_Internal_ChatServiceProxy_ChatService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673155);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_62_Internal_CoreUIServiceProxy_CoreUIService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673156);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_63_Internal_DatastoreProxy_Datastore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673157);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_64_Internal_DataStoreServiceProxy_DataStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673158);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_65_Internal_FilterServiceProxy_FilterService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673159);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_66_Internal_HttpServiceProxy_HttpService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673160);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_67_Internal_InputServiceProxy_InputService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673161);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_68_Internal_InsertServiceProxy_InsertService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673162);
				ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_69_Internal_TweenServiceProxy_TweenService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673163);
				ScriptService.__c.NativeMethodInfoPtr__RunScripts_b__14_0_Internal_Void_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673164);
				ScriptService.__c.NativeMethodInfoPtr__RunLocalScripts_b__15_0_Internal_Void_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr, 100673165);
			}

			// Token: 0x06004FAC RID: 20396 RVA: 0x00157898 File Offset: 0x00155A98
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptService.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FAD RID: 20397 RVA: 0x001578D4 File Offset: 0x00155AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125327, XrefRangeEnd = 125332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceProxy _Awake_b__5_0(Instance r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_0_Internal_InstanceProxy_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InstanceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAE RID: 20398 RVA: 0x00157924 File Offset: 0x00155B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125332, XrefRangeEnd = 125338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicInstanceProxy _Awake_b__5_1(DynamicInstance r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_1_Internal_DynamicInstanceProxy_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicInstanceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAF RID: 20399 RVA: 0x00157974 File Offset: 0x00155B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125338, XrefRangeEnd = 125345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PartProxy _Awake_b__5_2(Part r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_2_Internal_PartProxy_Part_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB0 RID: 20400 RVA: 0x001579C4 File Offset: 0x00155BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125345, XrefRangeEnd = 125351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameProxy _Awake_b__5_3(Game r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_3_Internal_GameProxy_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB1 RID: 20401 RVA: 0x00157A14 File Offset: 0x00155C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125351, XrefRangeEnd = 125357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseScriptProxy _Awake_b__5_4(BaseScript r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_4_Internal_BaseScriptProxy_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseScriptProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB2 RID: 20402 RVA: 0x00157A64 File Offset: 0x00155C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125357, XrefRangeEnd = 125364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScriptInstanceProxy _Awake_b__5_5(ScriptInstance r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_5_Internal_ScriptInstanceProxy_ScriptInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptInstanceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB3 RID: 20403 RVA: 0x00157AB4 File Offset: 0x00155CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125364, XrefRangeEnd = 125371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LocalScriptProxy _Awake_b__5_6(LocalScript r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_6_Internal_LocalScriptProxy_LocalScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalScriptProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB4 RID: 20404 RVA: 0x00157B04 File Offset: 0x00155D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125371, XrefRangeEnd = 125378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuleScriptProxy _Awake_b__5_7(ModuleScript r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_7_Internal_ModuleScriptProxy_ModuleScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ModuleScriptProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB5 RID: 20405 RVA: 0x00157B54 File Offset: 0x00155D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125378, XrefRangeEnd = 125384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RemoveEventProxy _Awake_b__5_8(RemoteEvent r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_8_Internal_RemoveEventProxy_RemoteEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoveEventProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB6 RID: 20406 RVA: 0x00157BA4 File Offset: 0x00155DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125384, XrefRangeEnd = 125390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnvironmentProxy _Awake_b__5_9(Environment r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_9_Internal_EnvironmentProxy_Environment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnvironmentProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB7 RID: 20407 RVA: 0x00157BF4 File Offset: 0x00155DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125390, XrefRangeEnd = 125396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerProxy _Awake_b__5_10(Player r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_10_Internal_PlayerProxy_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB8 RID: 20408 RVA: 0x00157C44 File Offset: 0x00155E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125396, XrefRangeEnd = 125402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayersProxy _Awake_b__5_11(Players r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_11_Internal_PlayersProxy_Players_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayersProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB9 RID: 20409 RVA: 0x00157C94 File Offset: 0x00155E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125402, XrefRangeEnd = 125409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Text3DProxy _Awake_b__5_12(Text3D r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_12_Internal_Text3DProxy_Text3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text3DProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBA RID: 20410 RVA: 0x00157CE4 File Offset: 0x00155EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125409, XrefRangeEnd = 125416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SoundProxy _Awake_b__5_13(Sound r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_13_Internal_SoundProxy_Sound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SoundProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBB RID: 20411 RVA: 0x00157D34 File Offset: 0x00155F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125416, XrefRangeEnd = 125423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToolProxy _Awake_b__5_14(Tool r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_14_Internal_ToolProxy_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ToolProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBC RID: 20412 RVA: 0x00157D84 File Offset: 0x00155F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125423, XrefRangeEnd = 125430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NPCProxy _Awake_b__5_15(NPC r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_15_Internal_NPCProxy_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBD RID: 20413 RVA: 0x00157DD4 File Offset: 0x00155FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125430, XrefRangeEnd = 125437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpotlightProxy _Awake_b__5_16(Spotlight r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_16_Internal_SpotlightProxy_Spotlight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpotlightProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBE RID: 20414 RVA: 0x00157E24 File Offset: 0x00156024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125437, XrefRangeEnd = 125443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueBaseProxy _Awake_b__5_17(ValueBase r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_17_Internal_ValueBaseProxy_ValueBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueBaseProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBF RID: 20415 RVA: 0x00157E74 File Offset: 0x00156074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125443, XrefRangeEnd = 125450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolValueProxy _Awake_b__5_18(BoolValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_18_Internal_BoolValueProxy_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC0 RID: 20416 RVA: 0x00157EC4 File Offset: 0x001560C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125450, XrefRangeEnd = 125457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorValueProxy _Awake_b__5_19(ColorValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_19_Internal_ColorValueProxy_ColorValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC1 RID: 20417 RVA: 0x00157F14 File Offset: 0x00156114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125457, XrefRangeEnd = 125464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringValueProxy _Awake_b__5_20(StringValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_20_Internal_StringValueProxy_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC2 RID: 20418 RVA: 0x00157F64 File Offset: 0x00156164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125464, XrefRangeEnd = 125471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceValueProxy _Awake_b__5_21(InstanceValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_21_Internal_InstanceValueProxy_InstanceValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InstanceValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC3 RID: 20419 RVA: 0x00157FB4 File Offset: 0x001561B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125471, XrefRangeEnd = 125478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntValueProxy _Awake_b__5_22(IntValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_22_Internal_IntValueProxy_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x00158004 File Offset: 0x00156204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125478, XrefRangeEnd = 125485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NumberValueProxy _Awake_b__5_23(NumberValue r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_23_Internal_NumberValueProxy_NumberValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC5 RID: 20421 RVA: 0x00158054 File Offset: 0x00156254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125485, XrefRangeEnd = 125492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3ValueProxy _Awake_b__5_24(Vector3Value r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_24_Internal_Vector3ValueProxy_Vector3Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3ValueProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x001580A4 File Offset: 0x001562A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125492, XrefRangeEnd = 125500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshPartProxy _Awake_b__5_25(MeshPart r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_25_Internal_MeshPartProxy_MeshPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshPartProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x001580F4 File Offset: 0x001562F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125500, XrefRangeEnd = 125506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BodyPositionProxy _Awake_b__5_26(BodyPosition r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_26_Internal_BodyPositionProxy_BodyPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BodyPositionProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC8 RID: 20424 RVA: 0x00158144 File Offset: 0x00156344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125506, XrefRangeEnd = 125512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BackpackProxy _Awake_b__5_27(Backpack r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_27_Internal_BackpackProxy_Backpack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BackpackProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC9 RID: 20425 RVA: 0x00158194 File Offset: 0x00156394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125512, XrefRangeEnd = 125518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LightingProxy _Awake_b__5_28(Lighting r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_28_Internal_LightingProxy_Lighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightingProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCA RID: 20426 RVA: 0x001581E4 File Offset: 0x001563E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125518, XrefRangeEnd = 125525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SunLightProxy _Awake_b__5_29(SunLight r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_29_Internal_SunLightProxy_SunLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SunLightProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCB RID: 20427 RVA: 0x00158234 File Offset: 0x00156434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125525, XrefRangeEnd = 125533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClimbableProxy _Awake_b__5_30(Climbable r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_30_Internal_ClimbableProxy_Climbable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClimbableProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCC RID: 20428 RVA: 0x00158284 File Offset: 0x00156484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125533, XrefRangeEnd = 125540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecalProxy _Awake_b__5_31(Decal r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_31_Internal_DecalProxy_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecalProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x001582D4 File Offset: 0x001564D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125540, XrefRangeEnd = 125547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParticlesProxy _Awake_b__5_32(Particles r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_32_Internal_ParticlesProxy_Particles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticlesProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCE RID: 20430 RVA: 0x00158324 File Offset: 0x00156524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125547, XrefRangeEnd = 125553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HiddenProxy _Awake_b__5_33(Hidden r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_33_Internal_HiddenProxy_Hidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HiddenProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FCF RID: 20431 RVA: 0x00158374 File Offset: 0x00156574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125553, XrefRangeEnd = 125559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerHiddenProxy _Awake_b__5_34(ServerHidden r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_34_Internal_ServerHiddenProxy_ServerHidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerHiddenProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD0 RID: 20432 RVA: 0x001583C4 File Offset: 0x001565C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125559, XrefRangeEnd = 125566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModelProxy _Awake_b__5_35(Model r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_35_Internal_ModelProxy_Model_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ModelProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD1 RID: 20433 RVA: 0x00158414 File Offset: 0x00156614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125566, XrefRangeEnd = 125573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointLightProxy _Awake_b__5_36(PointLight r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_36_Internal_PointLightProxy_PointLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointLightProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD2 RID: 20434 RVA: 0x00158464 File Offset: 0x00156664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125573, XrefRangeEnd = 125582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrussProxy _Awake_b__5_37(Truss r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_37_Internal_TrussProxy_Truss_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrussProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD3 RID: 20435 RVA: 0x001584B4 File Offset: 0x001566B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125582, XrefRangeEnd = 125590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SeatProxy _Awake_b__5_38(Seat r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_38_Internal_SeatProxy_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SeatProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD4 RID: 20436 RVA: 0x00158504 File Offset: 0x00156704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125590, XrefRangeEnd = 125596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkyBaseProxy _Awake_b__5_39(SkyBase r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_39_Internal_SkyBaseProxy_SkyBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyBaseProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD5 RID: 20437 RVA: 0x00158554 File Offset: 0x00156754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125596, XrefRangeEnd = 125603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImageSkyProxy _Awake_b__5_40(ImageSky r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_40_Internal_ImageSkyProxy_ImageSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageSkyProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD6 RID: 20438 RVA: 0x001585A4 File Offset: 0x001567A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125603, XrefRangeEnd = 125610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GradientSkyProxy _Awake_b__5_41(GradientSky r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_41_Internal_GradientSkyProxy_GradientSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GradientSkyProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD7 RID: 20439 RVA: 0x001585F4 File Offset: 0x001567F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125610, XrefRangeEnd = 125617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProceduralSkyProxy _Awake_b__5_42(ProceduralSky r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_42_Internal_ProceduralSkyProxy_ProceduralSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralSkyProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD8 RID: 20440 RVA: 0x00158644 File Offset: 0x00156844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125617, XrefRangeEnd = 125623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NetworkEventProxy _Awake_b__5_43(NetworkEvent r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_43_Internal_NetworkEventProxy_NetworkEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkEventProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD9 RID: 20441 RVA: 0x00158694 File Offset: 0x00156894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125623, XrefRangeEnd = 125629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SignalProxy _Awake_b__5_44(Signal r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_44_Internal_SignalProxy_Signal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignalProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDA RID: 20442 RVA: 0x001586E4 File Offset: 0x001568E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125629, XrefRangeEnd = 125635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerDefaultsProxy _Awake_b__5_45(PlayerDefaults r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_45_Internal_PlayerDefaultsProxy_PlayerDefaults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerDefaultsProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDB RID: 20443 RVA: 0x00158734 File Offset: 0x00156934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125635, XrefRangeEnd = 125641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GUIProxy _Awake_b__5_46(GUI r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_46_Internal_GUIProxy_GUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDC RID: 20444 RVA: 0x00158784 File Offset: 0x00156984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125641, XrefRangeEnd = 125650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIButtonProxy _Awake_b__5_47(UIButton r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_47_Internal_UIButtonProxy_UIButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDD RID: 20445 RVA: 0x001587D4 File Offset: 0x001569D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125650, XrefRangeEnd = 125656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIFieldProxy _Awake_b__5_48(UIField r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_48_Internal_UIFieldProxy_UIField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIFieldProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDE RID: 20446 RVA: 0x00158824 File Offset: 0x00156A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125656, XrefRangeEnd = 125664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UILabelProxy _Awake_b__5_49(UILabel r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_49_Internal_UILabelProxy_UILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UILabelProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDF RID: 20447 RVA: 0x00158874 File Offset: 0x00156A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125664, XrefRangeEnd = 125672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UITextInputProxy _Awake_b__5_50(UITextInput r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_50_Internal_UITextInputProxy_UITextInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UITextInputProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE0 RID: 20448 RVA: 0x001588C4 File Offset: 0x00156AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125672, XrefRangeEnd = 125679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIViewProxy _Awake_b__5_51(UIView r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_51_Internal_UIViewProxy_UIView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIViewProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE1 RID: 20449 RVA: 0x00158914 File Offset: 0x00156B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125679, XrefRangeEnd = 125686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIImageProxy _Awake_b__5_52(UIImage r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_52_Internal_UIImageProxy_UIImage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIImageProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE2 RID: 20450 RVA: 0x00158964 File Offset: 0x00156B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125686, XrefRangeEnd = 125693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIHVLayoutProxy _Awake_b__5_53(UIHVLayout r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_53_Internal_UIHVLayoutProxy_UIHVLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIHVLayoutProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE3 RID: 20451 RVA: 0x001589B4 File Offset: 0x00156BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125693, XrefRangeEnd = 125701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIVerticalLayoutProxy _Awake_b__5_54(UIVerticalLayout r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_54_Internal_UIVerticalLayoutProxy_UIVerticalLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIVerticalLayoutProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE4 RID: 20452 RVA: 0x00158A04 File Offset: 0x00156C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125701, XrefRangeEnd = 125709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIHorizontalLayoutProxy _Awake_b__5_55(UIHorizontalLayout r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_55_Internal_UIHorizontalLayoutProxy_UIHorizontalLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIHorizontalLayoutProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE5 RID: 20453 RVA: 0x00158A54 File Offset: 0x00156C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125709, XrefRangeEnd = 125715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerGUIProxy _Awake_b__5_56(PlayerGUI r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_56_Internal_PlayerGUIProxy_PlayerGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerGUIProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE6 RID: 20454 RVA: 0x00158AA4 File Offset: 0x00156CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125715, XrefRangeEnd = 125722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraProxy _Awake_b__5_57(Camera r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_57_Internal_CameraProxy_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE7 RID: 20455 RVA: 0x00158AF4 File Offset: 0x00156CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125722, XrefRangeEnd = 125727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DatastoreProxy _Awake_b__5_58(Datastore r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_58_Internal_DatastoreProxy_Datastore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatastoreProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE8 RID: 20456 RVA: 0x00158B44 File Offset: 0x00156D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125727, XrefRangeEnd = 125732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementServiceProxy _Awake_b__5_59(AchievementService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_59_Internal_AchievementServiceProxy_AchievementService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE9 RID: 20457 RVA: 0x00158B94 File Offset: 0x00156D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125732, XrefRangeEnd = 125737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PurchasesServiceProxy _Awake_b__5_60(PurchasesService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_60_Internal_PurchasesServiceProxy_PurchasesService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PurchasesServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEA RID: 20458 RVA: 0x00158BE4 File Offset: 0x00156DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125737, XrefRangeEnd = 125742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChatServiceProxy _Awake_b__5_61(ChatService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_61_Internal_ChatServiceProxy_ChatService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChatServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEB RID: 20459 RVA: 0x00158C34 File Offset: 0x00156E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125742, XrefRangeEnd = 125747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CoreUIServiceProxy _Awake_b__5_62(CoreUIService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_62_Internal_CoreUIServiceProxy_CoreUIService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreUIServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEC RID: 20460 RVA: 0x00158C84 File Offset: 0x00156E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125747, XrefRangeEnd = 125752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DatastoreProxy _Awake_b__5_63(Datastore r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_63_Internal_DatastoreProxy_Datastore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatastoreProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FED RID: 20461 RVA: 0x00158CD4 File Offset: 0x00156ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125752, XrefRangeEnd = 125757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataStoreServiceProxy _Awake_b__5_64(DataStoreService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_64_Internal_DataStoreServiceProxy_DataStoreService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataStoreServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEE RID: 20462 RVA: 0x00158D24 File Offset: 0x00156F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125757, XrefRangeEnd = 125762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterServiceProxy _Awake_b__5_65(FilterService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_65_Internal_FilterServiceProxy_FilterService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FilterServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEF RID: 20463 RVA: 0x00158D74 File Offset: 0x00156F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125762, XrefRangeEnd = 125767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HttpServiceProxy _Awake_b__5_66(HttpService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_66_Internal_HttpServiceProxy_HttpService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF0 RID: 20464 RVA: 0x00158DC4 File Offset: 0x00156FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125767, XrefRangeEnd = 125772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputServiceProxy _Awake_b__5_67(InputService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_67_Internal_InputServiceProxy_InputService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF1 RID: 20465 RVA: 0x00158E14 File Offset: 0x00157014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125772, XrefRangeEnd = 125777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InsertServiceProxy _Awake_b__5_68(InsertService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_68_Internal_InsertServiceProxy_InsertService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InsertServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF2 RID: 20466 RVA: 0x00158E64 File Offset: 0x00157064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125777, XrefRangeEnd = 125782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TweenServiceProxy _Awake_b__5_69(TweenService r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__Awake_b__5_69_Internal_TweenServiceProxy_TweenService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenServiceProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF3 RID: 20467 RVA: 0x00158EB4 File Offset: 0x001570B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125782, XrefRangeEnd = 125784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunScripts_b__14_0(BaseScript s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__RunScripts_b__14_0_Internal_Void_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FF4 RID: 20468 RVA: 0x00158EF8 File Offset: 0x001570F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunLocalScripts_b__15_0(BaseScript s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c.NativeMethodInfoPtr__RunLocalScripts_b__15_0_Internal_Void_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FF5 RID: 20469 RVA: 0x0001E6EB File Offset: 0x0001C8EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ADE RID: 6878
			// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x00158F3C File Offset: 0x0015713C
			// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
			public unsafe static ScriptService.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADF RID: 6879
			// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x00158F64 File Offset: 0x00157164
			// (set) Token: 0x06004FF9 RID: 20473 RVA: 0x0001E706 File Offset: 0x0001C906
			public unsafe static Func<Instance, InstanceProxy> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instance, InstanceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE0 RID: 6880
			// (get) Token: 0x06004FFA RID: 20474 RVA: 0x00158F8C File Offset: 0x0015718C
			// (set) Token: 0x06004FFB RID: 20475 RVA: 0x0001E718 File Offset: 0x0001C918
			public unsafe static Func<DynamicInstance, DynamicInstanceProxy> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynamicInstance, DynamicInstanceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE1 RID: 6881
			// (get) Token: 0x06004FFC RID: 20476 RVA: 0x00158FB4 File Offset: 0x001571B4
			// (set) Token: 0x06004FFD RID: 20477 RVA: 0x0001E72A File Offset: 0x0001C92A
			public unsafe static Func<Part, PartProxy> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Part, PartProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE2 RID: 6882
			// (get) Token: 0x06004FFE RID: 20478 RVA: 0x00158FDC File Offset: 0x001571DC
			// (set) Token: 0x06004FFF RID: 20479 RVA: 0x0001E73C File Offset: 0x0001C93C
			public unsafe static Func<Game, GameProxy> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Game, GameProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE3 RID: 6883
			// (get) Token: 0x06005000 RID: 20480 RVA: 0x00159004 File Offset: 0x00157204
			// (set) Token: 0x06005001 RID: 20481 RVA: 0x0001E74E File Offset: 0x0001C94E
			public unsafe static Func<BaseScript, BaseScriptProxy> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BaseScript, BaseScriptProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE4 RID: 6884
			// (get) Token: 0x06005002 RID: 20482 RVA: 0x0015902C File Offset: 0x0015722C
			// (set) Token: 0x06005003 RID: 20483 RVA: 0x0001E760 File Offset: 0x0001C960
			public unsafe static Func<ScriptInstance, ScriptInstanceProxy> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ScriptInstance, ScriptInstanceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE5 RID: 6885
			// (get) Token: 0x06005004 RID: 20484 RVA: 0x00159054 File Offset: 0x00157254
			// (set) Token: 0x06005005 RID: 20485 RVA: 0x0001E772 File Offset: 0x0001C972
			public unsafe static Func<LocalScript, LocalScriptProxy> __9__5_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LocalScript, LocalScriptProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE6 RID: 6886
			// (get) Token: 0x06005006 RID: 20486 RVA: 0x0015907C File Offset: 0x0015727C
			// (set) Token: 0x06005007 RID: 20487 RVA: 0x0001E784 File Offset: 0x0001C984
			public unsafe static Func<ModuleScript, ModuleScriptProxy> __9__5_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ModuleScript, ModuleScriptProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE7 RID: 6887
			// (get) Token: 0x06005008 RID: 20488 RVA: 0x001590A4 File Offset: 0x001572A4
			// (set) Token: 0x06005009 RID: 20489 RVA: 0x0001E796 File Offset: 0x0001C996
			public unsafe static Func<RemoteEvent, RemoveEventProxy> __9__5_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RemoteEvent, RemoveEventProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE8 RID: 6888
			// (get) Token: 0x0600500A RID: 20490 RVA: 0x001590CC File Offset: 0x001572CC
			// (set) Token: 0x0600500B RID: 20491 RVA: 0x0001E7A8 File Offset: 0x0001C9A8
			public unsafe static Func<Environment, EnvironmentProxy> __9__5_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Environment, EnvironmentProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE9 RID: 6889
			// (get) Token: 0x0600500C RID: 20492 RVA: 0x001590F4 File Offset: 0x001572F4
			// (set) Token: 0x0600500D RID: 20493 RVA: 0x0001E7BA File Offset: 0x0001C9BA
			public unsafe static Func<Player, PlayerProxy> __9__5_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Player, PlayerProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEA RID: 6890
			// (get) Token: 0x0600500E RID: 20494 RVA: 0x0015911C File Offset: 0x0015731C
			// (set) Token: 0x0600500F RID: 20495 RVA: 0x0001E7CC File Offset: 0x0001C9CC
			public unsafe static Func<Players, PlayersProxy> __9__5_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Players, PlayersProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEB RID: 6891
			// (get) Token: 0x06005010 RID: 20496 RVA: 0x00159144 File Offset: 0x00157344
			// (set) Token: 0x06005011 RID: 20497 RVA: 0x0001E7DE File Offset: 0x0001C9DE
			public unsafe static Func<Text3D, Text3DProxy> __9__5_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Text3D, Text3DProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEC RID: 6892
			// (get) Token: 0x06005012 RID: 20498 RVA: 0x0015916C File Offset: 0x0015736C
			// (set) Token: 0x06005013 RID: 20499 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
			public unsafe static Func<Sound, SoundProxy> __9__5_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sound, SoundProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AED RID: 6893
			// (get) Token: 0x06005014 RID: 20500 RVA: 0x00159194 File Offset: 0x00157394
			// (set) Token: 0x06005015 RID: 20501 RVA: 0x0001E802 File Offset: 0x0001CA02
			public unsafe static Func<Tool, ToolProxy> __9__5_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tool, ToolProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEE RID: 6894
			// (get) Token: 0x06005016 RID: 20502 RVA: 0x001591BC File Offset: 0x001573BC
			// (set) Token: 0x06005017 RID: 20503 RVA: 0x0001E814 File Offset: 0x0001CA14
			public unsafe static Func<NPC, NPCProxy> __9__5_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, NPCProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEF RID: 6895
			// (get) Token: 0x06005018 RID: 20504 RVA: 0x001591E4 File Offset: 0x001573E4
			// (set) Token: 0x06005019 RID: 20505 RVA: 0x0001E826 File Offset: 0x0001CA26
			public unsafe static Func<Spotlight, SpotlightProxy> __9__5_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spotlight, SpotlightProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF0 RID: 6896
			// (get) Token: 0x0600501A RID: 20506 RVA: 0x0015920C File Offset: 0x0015740C
			// (set) Token: 0x0600501B RID: 20507 RVA: 0x0001E838 File Offset: 0x0001CA38
			public unsafe static Func<ValueBase, ValueBaseProxy> __9__5_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueBase, ValueBaseProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF1 RID: 6897
			// (get) Token: 0x0600501C RID: 20508 RVA: 0x00159234 File Offset: 0x00157434
			// (set) Token: 0x0600501D RID: 20509 RVA: 0x0001E84A File Offset: 0x0001CA4A
			public unsafe static Func<BoolValue, BoolValueProxy> __9__5_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BoolValue, BoolValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF2 RID: 6898
			// (get) Token: 0x0600501E RID: 20510 RVA: 0x0015925C File Offset: 0x0015745C
			// (set) Token: 0x0600501F RID: 20511 RVA: 0x0001E85C File Offset: 0x0001CA5C
			public unsafe static Func<ColorValue, ColorValueProxy> __9__5_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ColorValue, ColorValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF3 RID: 6899
			// (get) Token: 0x06005020 RID: 20512 RVA: 0x00159284 File Offset: 0x00157484
			// (set) Token: 0x06005021 RID: 20513 RVA: 0x0001E86E File Offset: 0x0001CA6E
			public unsafe static Func<StringValue, StringValueProxy> __9__5_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StringValue, StringValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF4 RID: 6900
			// (get) Token: 0x06005022 RID: 20514 RVA: 0x001592AC File Offset: 0x001574AC
			// (set) Token: 0x06005023 RID: 20515 RVA: 0x0001E880 File Offset: 0x0001CA80
			public unsafe static Func<InstanceValue, InstanceValueProxy> __9__5_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InstanceValue, InstanceValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF5 RID: 6901
			// (get) Token: 0x06005024 RID: 20516 RVA: 0x001592D4 File Offset: 0x001574D4
			// (set) Token: 0x06005025 RID: 20517 RVA: 0x0001E892 File Offset: 0x0001CA92
			public unsafe static Func<IntValue, IntValueProxy> __9__5_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IntValue, IntValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF6 RID: 6902
			// (get) Token: 0x06005026 RID: 20518 RVA: 0x001592FC File Offset: 0x001574FC
			// (set) Token: 0x06005027 RID: 20519 RVA: 0x0001E8A4 File Offset: 0x0001CAA4
			public unsafe static Func<NumberValue, NumberValueProxy> __9__5_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NumberValue, NumberValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF7 RID: 6903
			// (get) Token: 0x06005028 RID: 20520 RVA: 0x00159324 File Offset: 0x00157524
			// (set) Token: 0x06005029 RID: 20521 RVA: 0x0001E8B6 File Offset: 0x0001CAB6
			public unsafe static Func<Vector3Value, Vector3ValueProxy> __9__5_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Value, Vector3ValueProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF8 RID: 6904
			// (get) Token: 0x0600502A RID: 20522 RVA: 0x0015934C File Offset: 0x0015754C
			// (set) Token: 0x0600502B RID: 20523 RVA: 0x0001E8C8 File Offset: 0x0001CAC8
			public unsafe static Func<MeshPart, MeshPartProxy> __9__5_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MeshPart, MeshPartProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF9 RID: 6905
			// (get) Token: 0x0600502C RID: 20524 RVA: 0x00159374 File Offset: 0x00157574
			// (set) Token: 0x0600502D RID: 20525 RVA: 0x0001E8DA File Offset: 0x0001CADA
			public unsafe static Func<BodyPosition, BodyPositionProxy> __9__5_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BodyPosition, BodyPositionProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFA RID: 6906
			// (get) Token: 0x0600502E RID: 20526 RVA: 0x0015939C File Offset: 0x0015759C
			// (set) Token: 0x0600502F RID: 20527 RVA: 0x0001E8EC File Offset: 0x0001CAEC
			public unsafe static Func<Backpack, BackpackProxy> __9__5_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Backpack, BackpackProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFB RID: 6907
			// (get) Token: 0x06005030 RID: 20528 RVA: 0x001593C4 File Offset: 0x001575C4
			// (set) Token: 0x06005031 RID: 20529 RVA: 0x0001E8FE File Offset: 0x0001CAFE
			public unsafe static Func<Lighting, LightingProxy> __9__5_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Lighting, LightingProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFC RID: 6908
			// (get) Token: 0x06005032 RID: 20530 RVA: 0x001593EC File Offset: 0x001575EC
			// (set) Token: 0x06005033 RID: 20531 RVA: 0x0001E910 File Offset: 0x0001CB10
			public unsafe static Func<SunLight, SunLightProxy> __9__5_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SunLight, SunLightProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFD RID: 6909
			// (get) Token: 0x06005034 RID: 20532 RVA: 0x00159414 File Offset: 0x00157614
			// (set) Token: 0x06005035 RID: 20533 RVA: 0x0001E922 File Offset: 0x0001CB22
			public unsafe static Func<Climbable, ClimbableProxy> __9__5_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Climbable, ClimbableProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFE RID: 6910
			// (get) Token: 0x06005036 RID: 20534 RVA: 0x0015943C File Offset: 0x0015763C
			// (set) Token: 0x06005037 RID: 20535 RVA: 0x0001E934 File Offset: 0x0001CB34
			public unsafe static Func<Decal, DecalProxy> __9__5_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decal, DecalProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFF RID: 6911
			// (get) Token: 0x06005038 RID: 20536 RVA: 0x00159464 File Offset: 0x00157664
			// (set) Token: 0x06005039 RID: 20537 RVA: 0x0001E946 File Offset: 0x0001CB46
			public unsafe static Func<Particles, ParticlesProxy> __9__5_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Particles, ParticlesProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B00 RID: 6912
			// (get) Token: 0x0600503A RID: 20538 RVA: 0x0015948C File Offset: 0x0015768C
			// (set) Token: 0x0600503B RID: 20539 RVA: 0x0001E958 File Offset: 0x0001CB58
			public unsafe static Func<Hidden, HiddenProxy> __9__5_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Hidden, HiddenProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B01 RID: 6913
			// (get) Token: 0x0600503C RID: 20540 RVA: 0x001594B4 File Offset: 0x001576B4
			// (set) Token: 0x0600503D RID: 20541 RVA: 0x0001E96A File Offset: 0x0001CB6A
			public unsafe static Func<ServerHidden, ServerHiddenProxy> __9__5_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServerHidden, ServerHiddenProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B02 RID: 6914
			// (get) Token: 0x0600503E RID: 20542 RVA: 0x001594DC File Offset: 0x001576DC
			// (set) Token: 0x0600503F RID: 20543 RVA: 0x0001E97C File Offset: 0x0001CB7C
			public unsafe static Func<Model, ModelProxy> __9__5_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Model, ModelProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B03 RID: 6915
			// (get) Token: 0x06005040 RID: 20544 RVA: 0x00159504 File Offset: 0x00157704
			// (set) Token: 0x06005041 RID: 20545 RVA: 0x0001E98E File Offset: 0x0001CB8E
			public unsafe static Func<PointLight, PointLightProxy> __9__5_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PointLight, PointLightProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B04 RID: 6916
			// (get) Token: 0x06005042 RID: 20546 RVA: 0x0015952C File Offset: 0x0015772C
			// (set) Token: 0x06005043 RID: 20547 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
			public unsafe static Func<Truss, TrussProxy> __9__5_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Truss, TrussProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B05 RID: 6917
			// (get) Token: 0x06005044 RID: 20548 RVA: 0x00159554 File Offset: 0x00157754
			// (set) Token: 0x06005045 RID: 20549 RVA: 0x0001E9B2 File Offset: 0x0001CBB2
			public unsafe static Func<Seat, SeatProxy> __9__5_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Seat, SeatProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B06 RID: 6918
			// (get) Token: 0x06005046 RID: 20550 RVA: 0x0015957C File Offset: 0x0015777C
			// (set) Token: 0x06005047 RID: 20551 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
			public unsafe static Func<SkyBase, SkyBaseProxy> __9__5_39
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_39, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SkyBase, SkyBaseProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_39, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B07 RID: 6919
			// (get) Token: 0x06005048 RID: 20552 RVA: 0x001595A4 File Offset: 0x001577A4
			// (set) Token: 0x06005049 RID: 20553 RVA: 0x0001E9D6 File Offset: 0x0001CBD6
			public unsafe static Func<ImageSky, ImageSkyProxy> __9__5_40
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_40, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ImageSky, ImageSkyProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_40, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B08 RID: 6920
			// (get) Token: 0x0600504A RID: 20554 RVA: 0x001595CC File Offset: 0x001577CC
			// (set) Token: 0x0600504B RID: 20555 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
			public unsafe static Func<GradientSky, GradientSkyProxy> __9__5_41
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_41, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GradientSky, GradientSkyProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_41, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B09 RID: 6921
			// (get) Token: 0x0600504C RID: 20556 RVA: 0x001595F4 File Offset: 0x001577F4
			// (set) Token: 0x0600504D RID: 20557 RVA: 0x0001E9FA File Offset: 0x0001CBFA
			public unsafe static Func<ProceduralSky, ProceduralSkyProxy> __9__5_42
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_42, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProceduralSky, ProceduralSkyProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_42, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0A RID: 6922
			// (get) Token: 0x0600504E RID: 20558 RVA: 0x0015961C File Offset: 0x0015781C
			// (set) Token: 0x0600504F RID: 20559 RVA: 0x0001EA0C File Offset: 0x0001CC0C
			public unsafe static Func<NetworkEvent, NetworkEventProxy> __9__5_43
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_43, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkEvent, NetworkEventProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_43, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0B RID: 6923
			// (get) Token: 0x06005050 RID: 20560 RVA: 0x00159644 File Offset: 0x00157844
			// (set) Token: 0x06005051 RID: 20561 RVA: 0x0001EA1E File Offset: 0x0001CC1E
			public unsafe static Func<Signal, SignalProxy> __9__5_44
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_44, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Signal, SignalProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_44, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0C RID: 6924
			// (get) Token: 0x06005052 RID: 20562 RVA: 0x0015966C File Offset: 0x0015786C
			// (set) Token: 0x06005053 RID: 20563 RVA: 0x0001EA30 File Offset: 0x0001CC30
			public unsafe static Func<PlayerDefaults, PlayerDefaultsProxy> __9__5_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerDefaults, PlayerDefaultsProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0D RID: 6925
			// (get) Token: 0x06005054 RID: 20564 RVA: 0x00159694 File Offset: 0x00157894
			// (set) Token: 0x06005055 RID: 20565 RVA: 0x0001EA42 File Offset: 0x0001CC42
			public unsafe static Func<GUI, GUIProxy> __9__5_46
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_46, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GUI, GUIProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_46, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0E RID: 6926
			// (get) Token: 0x06005056 RID: 20566 RVA: 0x001596BC File Offset: 0x001578BC
			// (set) Token: 0x06005057 RID: 20567 RVA: 0x0001EA54 File Offset: 0x0001CC54
			public unsafe static Func<UIButton, UIButtonProxy> __9__5_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIButton, UIButtonProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0F RID: 6927
			// (get) Token: 0x06005058 RID: 20568 RVA: 0x001596E4 File Offset: 0x001578E4
			// (set) Token: 0x06005059 RID: 20569 RVA: 0x0001EA66 File Offset: 0x0001CC66
			public unsafe static Func<UIField, UIFieldProxy> __9__5_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIField, UIFieldProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B10 RID: 6928
			// (get) Token: 0x0600505A RID: 20570 RVA: 0x0015970C File Offset: 0x0015790C
			// (set) Token: 0x0600505B RID: 20571 RVA: 0x0001EA78 File Offset: 0x0001CC78
			public unsafe static Func<UILabel, UILabelProxy> __9__5_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UILabel, UILabelProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B11 RID: 6929
			// (get) Token: 0x0600505C RID: 20572 RVA: 0x00159734 File Offset: 0x00157934
			// (set) Token: 0x0600505D RID: 20573 RVA: 0x0001EA8A File Offset: 0x0001CC8A
			public unsafe static Func<UITextInput, UITextInputProxy> __9__5_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UITextInput, UITextInputProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B12 RID: 6930
			// (get) Token: 0x0600505E RID: 20574 RVA: 0x0015975C File Offset: 0x0015795C
			// (set) Token: 0x0600505F RID: 20575 RVA: 0x0001EA9C File Offset: 0x0001CC9C
			public unsafe static Func<UIView, UIViewProxy> __9__5_51
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_51, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIView, UIViewProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_51, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B13 RID: 6931
			// (get) Token: 0x06005060 RID: 20576 RVA: 0x00159784 File Offset: 0x00157984
			// (set) Token: 0x06005061 RID: 20577 RVA: 0x0001EAAE File Offset: 0x0001CCAE
			public unsafe static Func<UIImage, UIImageProxy> __9__5_52
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_52, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIImage, UIImageProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_52, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B14 RID: 6932
			// (get) Token: 0x06005062 RID: 20578 RVA: 0x001597AC File Offset: 0x001579AC
			// (set) Token: 0x06005063 RID: 20579 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
			public unsafe static Func<UIHVLayout, UIHVLayoutProxy> __9__5_53
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_53, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIHVLayout, UIHVLayoutProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_53, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B15 RID: 6933
			// (get) Token: 0x06005064 RID: 20580 RVA: 0x001597D4 File Offset: 0x001579D4
			// (set) Token: 0x06005065 RID: 20581 RVA: 0x0001EAD2 File Offset: 0x0001CCD2
			public unsafe static Func<UIVerticalLayout, UIVerticalLayoutProxy> __9__5_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIVerticalLayout, UIVerticalLayoutProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B16 RID: 6934
			// (get) Token: 0x06005066 RID: 20582 RVA: 0x001597FC File Offset: 0x001579FC
			// (set) Token: 0x06005067 RID: 20583 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
			public unsafe static Func<UIHorizontalLayout, UIHorizontalLayoutProxy> __9__5_55
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_55, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIHorizontalLayout, UIHorizontalLayoutProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_55, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B17 RID: 6935
			// (get) Token: 0x06005068 RID: 20584 RVA: 0x00159824 File Offset: 0x00157A24
			// (set) Token: 0x06005069 RID: 20585 RVA: 0x0001EAF6 File Offset: 0x0001CCF6
			public unsafe static Func<PlayerGUI, PlayerGUIProxy> __9__5_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerGUI, PlayerGUIProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B18 RID: 6936
			// (get) Token: 0x0600506A RID: 20586 RVA: 0x0015984C File Offset: 0x00157A4C
			// (set) Token: 0x0600506B RID: 20587 RVA: 0x0001EB08 File Offset: 0x0001CD08
			public unsafe static Func<Camera, CameraProxy> __9__5_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Camera, CameraProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B19 RID: 6937
			// (get) Token: 0x0600506C RID: 20588 RVA: 0x00159874 File Offset: 0x00157A74
			// (set) Token: 0x0600506D RID: 20589 RVA: 0x0001EB1A File Offset: 0x0001CD1A
			public unsafe static Func<Datastore, DatastoreProxy> __9__5_58
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_58, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Datastore, DatastoreProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_58, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1A RID: 6938
			// (get) Token: 0x0600506E RID: 20590 RVA: 0x0015989C File Offset: 0x00157A9C
			// (set) Token: 0x0600506F RID: 20591 RVA: 0x0001EB2C File Offset: 0x0001CD2C
			public unsafe static Func<AchievementService, AchievementServiceProxy> __9__5_59
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_59, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AchievementService, AchievementServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_59, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1B RID: 6939
			// (get) Token: 0x06005070 RID: 20592 RVA: 0x001598C4 File Offset: 0x00157AC4
			// (set) Token: 0x06005071 RID: 20593 RVA: 0x0001EB3E File Offset: 0x0001CD3E
			public unsafe static Func<PurchasesService, PurchasesServiceProxy> __9__5_60
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_60, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PurchasesService, PurchasesServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_60, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1C RID: 6940
			// (get) Token: 0x06005072 RID: 20594 RVA: 0x001598EC File Offset: 0x00157AEC
			// (set) Token: 0x06005073 RID: 20595 RVA: 0x0001EB50 File Offset: 0x0001CD50
			public unsafe static Func<ChatService, ChatServiceProxy> __9__5_61
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_61, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChatService, ChatServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_61, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1D RID: 6941
			// (get) Token: 0x06005074 RID: 20596 RVA: 0x00159914 File Offset: 0x00157B14
			// (set) Token: 0x06005075 RID: 20597 RVA: 0x0001EB62 File Offset: 0x0001CD62
			public unsafe static Func<CoreUIService, CoreUIServiceProxy> __9__5_62
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_62, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoreUIService, CoreUIServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_62, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1E RID: 6942
			// (get) Token: 0x06005076 RID: 20598 RVA: 0x0015993C File Offset: 0x00157B3C
			// (set) Token: 0x06005077 RID: 20599 RVA: 0x0001EB74 File Offset: 0x0001CD74
			public unsafe static Func<Datastore, DatastoreProxy> __9__5_63
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_63, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Datastore, DatastoreProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_63, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1F RID: 6943
			// (get) Token: 0x06005078 RID: 20600 RVA: 0x00159964 File Offset: 0x00157B64
			// (set) Token: 0x06005079 RID: 20601 RVA: 0x0001EB86 File Offset: 0x0001CD86
			public unsafe static Func<DataStoreService, DataStoreServiceProxy> __9__5_64
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_64, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataStoreService, DataStoreServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_64, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B20 RID: 6944
			// (get) Token: 0x0600507A RID: 20602 RVA: 0x0015998C File Offset: 0x00157B8C
			// (set) Token: 0x0600507B RID: 20603 RVA: 0x0001EB98 File Offset: 0x0001CD98
			public unsafe static Func<FilterService, FilterServiceProxy> __9__5_65
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_65, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FilterService, FilterServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_65, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B21 RID: 6945
			// (get) Token: 0x0600507C RID: 20604 RVA: 0x001599B4 File Offset: 0x00157BB4
			// (set) Token: 0x0600507D RID: 20605 RVA: 0x0001EBAA File Offset: 0x0001CDAA
			public unsafe static Func<HttpService, HttpServiceProxy> __9__5_66
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_66, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpService, HttpServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_66, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B22 RID: 6946
			// (get) Token: 0x0600507E RID: 20606 RVA: 0x001599DC File Offset: 0x00157BDC
			// (set) Token: 0x0600507F RID: 20607 RVA: 0x0001EBBC File Offset: 0x0001CDBC
			public unsafe static Func<InputService, InputServiceProxy> __9__5_67
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_67, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InputService, InputServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_67, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B23 RID: 6947
			// (get) Token: 0x06005080 RID: 20608 RVA: 0x00159A04 File Offset: 0x00157C04
			// (set) Token: 0x06005081 RID: 20609 RVA: 0x0001EBCE File Offset: 0x0001CDCE
			public unsafe static Func<InsertService, InsertServiceProxy> __9__5_68
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_68, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InsertService, InsertServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_68, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B24 RID: 6948
			// (get) Token: 0x06005082 RID: 20610 RVA: 0x00159A2C File Offset: 0x00157C2C
			// (set) Token: 0x06005083 RID: 20611 RVA: 0x0001EBE0 File Offset: 0x0001CDE0
			public unsafe static Func<TweenService, TweenServiceProxy> __9__5_69
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__5_69, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TweenService, TweenServiceProxy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__5_69, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B25 RID: 6949
			// (get) Token: 0x06005084 RID: 20612 RVA: 0x00159A54 File Offset: 0x00157C54
			// (set) Token: 0x06005085 RID: 20613 RVA: 0x0001EBF2 File Offset: 0x0001CDF2
			public unsafe static Action<BaseScript> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseScript>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B26 RID: 6950
			// (get) Token: 0x06005086 RID: 20614 RVA: 0x00159A7C File Offset: 0x00157C7C
			// (set) Token: 0x06005087 RID: 20615 RVA: 0x0001EC04 File Offset: 0x0001CE04
			public unsafe static Action<BaseScript> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptService.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseScript>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptService.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D78 RID: 15736
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003D79 RID: 15737
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003D7A RID: 15738
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04003D7B RID: 15739
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04003D7C RID: 15740
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x04003D7D RID: 15741
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x04003D7E RID: 15742
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x04003D7F RID: 15743
			private static readonly IntPtr NativeFieldInfoPtr___9__5_6;

			// Token: 0x04003D80 RID: 15744
			private static readonly IntPtr NativeFieldInfoPtr___9__5_7;

			// Token: 0x04003D81 RID: 15745
			private static readonly IntPtr NativeFieldInfoPtr___9__5_8;

			// Token: 0x04003D82 RID: 15746
			private static readonly IntPtr NativeFieldInfoPtr___9__5_9;

			// Token: 0x04003D83 RID: 15747
			private static readonly IntPtr NativeFieldInfoPtr___9__5_10;

			// Token: 0x04003D84 RID: 15748
			private static readonly IntPtr NativeFieldInfoPtr___9__5_11;

			// Token: 0x04003D85 RID: 15749
			private static readonly IntPtr NativeFieldInfoPtr___9__5_12;

			// Token: 0x04003D86 RID: 15750
			private static readonly IntPtr NativeFieldInfoPtr___9__5_13;

			// Token: 0x04003D87 RID: 15751
			private static readonly IntPtr NativeFieldInfoPtr___9__5_14;

			// Token: 0x04003D88 RID: 15752
			private static readonly IntPtr NativeFieldInfoPtr___9__5_15;

			// Token: 0x04003D89 RID: 15753
			private static readonly IntPtr NativeFieldInfoPtr___9__5_16;

			// Token: 0x04003D8A RID: 15754
			private static readonly IntPtr NativeFieldInfoPtr___9__5_17;

			// Token: 0x04003D8B RID: 15755
			private static readonly IntPtr NativeFieldInfoPtr___9__5_18;

			// Token: 0x04003D8C RID: 15756
			private static readonly IntPtr NativeFieldInfoPtr___9__5_19;

			// Token: 0x04003D8D RID: 15757
			private static readonly IntPtr NativeFieldInfoPtr___9__5_20;

			// Token: 0x04003D8E RID: 15758
			private static readonly IntPtr NativeFieldInfoPtr___9__5_21;

			// Token: 0x04003D8F RID: 15759
			private static readonly IntPtr NativeFieldInfoPtr___9__5_22;

			// Token: 0x04003D90 RID: 15760
			private static readonly IntPtr NativeFieldInfoPtr___9__5_23;

			// Token: 0x04003D91 RID: 15761
			private static readonly IntPtr NativeFieldInfoPtr___9__5_24;

			// Token: 0x04003D92 RID: 15762
			private static readonly IntPtr NativeFieldInfoPtr___9__5_25;

			// Token: 0x04003D93 RID: 15763
			private static readonly IntPtr NativeFieldInfoPtr___9__5_26;

			// Token: 0x04003D94 RID: 15764
			private static readonly IntPtr NativeFieldInfoPtr___9__5_27;

			// Token: 0x04003D95 RID: 15765
			private static readonly IntPtr NativeFieldInfoPtr___9__5_28;

			// Token: 0x04003D96 RID: 15766
			private static readonly IntPtr NativeFieldInfoPtr___9__5_29;

			// Token: 0x04003D97 RID: 15767
			private static readonly IntPtr NativeFieldInfoPtr___9__5_30;

			// Token: 0x04003D98 RID: 15768
			private static readonly IntPtr NativeFieldInfoPtr___9__5_31;

			// Token: 0x04003D99 RID: 15769
			private static readonly IntPtr NativeFieldInfoPtr___9__5_32;

			// Token: 0x04003D9A RID: 15770
			private static readonly IntPtr NativeFieldInfoPtr___9__5_33;

			// Token: 0x04003D9B RID: 15771
			private static readonly IntPtr NativeFieldInfoPtr___9__5_34;

			// Token: 0x04003D9C RID: 15772
			private static readonly IntPtr NativeFieldInfoPtr___9__5_35;

			// Token: 0x04003D9D RID: 15773
			private static readonly IntPtr NativeFieldInfoPtr___9__5_36;

			// Token: 0x04003D9E RID: 15774
			private static readonly IntPtr NativeFieldInfoPtr___9__5_37;

			// Token: 0x04003D9F RID: 15775
			private static readonly IntPtr NativeFieldInfoPtr___9__5_38;

			// Token: 0x04003DA0 RID: 15776
			private static readonly IntPtr NativeFieldInfoPtr___9__5_39;

			// Token: 0x04003DA1 RID: 15777
			private static readonly IntPtr NativeFieldInfoPtr___9__5_40;

			// Token: 0x04003DA2 RID: 15778
			private static readonly IntPtr NativeFieldInfoPtr___9__5_41;

			// Token: 0x04003DA3 RID: 15779
			private static readonly IntPtr NativeFieldInfoPtr___9__5_42;

			// Token: 0x04003DA4 RID: 15780
			private static readonly IntPtr NativeFieldInfoPtr___9__5_43;

			// Token: 0x04003DA5 RID: 15781
			private static readonly IntPtr NativeFieldInfoPtr___9__5_44;

			// Token: 0x04003DA6 RID: 15782
			private static readonly IntPtr NativeFieldInfoPtr___9__5_45;

			// Token: 0x04003DA7 RID: 15783
			private static readonly IntPtr NativeFieldInfoPtr___9__5_46;

			// Token: 0x04003DA8 RID: 15784
			private static readonly IntPtr NativeFieldInfoPtr___9__5_47;

			// Token: 0x04003DA9 RID: 15785
			private static readonly IntPtr NativeFieldInfoPtr___9__5_48;

			// Token: 0x04003DAA RID: 15786
			private static readonly IntPtr NativeFieldInfoPtr___9__5_49;

			// Token: 0x04003DAB RID: 15787
			private static readonly IntPtr NativeFieldInfoPtr___9__5_50;

			// Token: 0x04003DAC RID: 15788
			private static readonly IntPtr NativeFieldInfoPtr___9__5_51;

			// Token: 0x04003DAD RID: 15789
			private static readonly IntPtr NativeFieldInfoPtr___9__5_52;

			// Token: 0x04003DAE RID: 15790
			private static readonly IntPtr NativeFieldInfoPtr___9__5_53;

			// Token: 0x04003DAF RID: 15791
			private static readonly IntPtr NativeFieldInfoPtr___9__5_54;

			// Token: 0x04003DB0 RID: 15792
			private static readonly IntPtr NativeFieldInfoPtr___9__5_55;

			// Token: 0x04003DB1 RID: 15793
			private static readonly IntPtr NativeFieldInfoPtr___9__5_56;

			// Token: 0x04003DB2 RID: 15794
			private static readonly IntPtr NativeFieldInfoPtr___9__5_57;

			// Token: 0x04003DB3 RID: 15795
			private static readonly IntPtr NativeFieldInfoPtr___9__5_58;

			// Token: 0x04003DB4 RID: 15796
			private static readonly IntPtr NativeFieldInfoPtr___9__5_59;

			// Token: 0x04003DB5 RID: 15797
			private static readonly IntPtr NativeFieldInfoPtr___9__5_60;

			// Token: 0x04003DB6 RID: 15798
			private static readonly IntPtr NativeFieldInfoPtr___9__5_61;

			// Token: 0x04003DB7 RID: 15799
			private static readonly IntPtr NativeFieldInfoPtr___9__5_62;

			// Token: 0x04003DB8 RID: 15800
			private static readonly IntPtr NativeFieldInfoPtr___9__5_63;

			// Token: 0x04003DB9 RID: 15801
			private static readonly IntPtr NativeFieldInfoPtr___9__5_64;

			// Token: 0x04003DBA RID: 15802
			private static readonly IntPtr NativeFieldInfoPtr___9__5_65;

			// Token: 0x04003DBB RID: 15803
			private static readonly IntPtr NativeFieldInfoPtr___9__5_66;

			// Token: 0x04003DBC RID: 15804
			private static readonly IntPtr NativeFieldInfoPtr___9__5_67;

			// Token: 0x04003DBD RID: 15805
			private static readonly IntPtr NativeFieldInfoPtr___9__5_68;

			// Token: 0x04003DBE RID: 15806
			private static readonly IntPtr NativeFieldInfoPtr___9__5_69;

			// Token: 0x04003DBF RID: 15807
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04003DC0 RID: 15808
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04003DC1 RID: 15809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003DC2 RID: 15810
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Internal_InstanceProxy_Instance_0;

			// Token: 0x04003DC3 RID: 15811
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_1_Internal_DynamicInstanceProxy_DynamicInstance_0;

			// Token: 0x04003DC4 RID: 15812
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_2_Internal_PartProxy_Part_0;

			// Token: 0x04003DC5 RID: 15813
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_3_Internal_GameProxy_Game_0;

			// Token: 0x04003DC6 RID: 15814
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_4_Internal_BaseScriptProxy_BaseScript_0;

			// Token: 0x04003DC7 RID: 15815
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_5_Internal_ScriptInstanceProxy_ScriptInstance_0;

			// Token: 0x04003DC8 RID: 15816
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_6_Internal_LocalScriptProxy_LocalScript_0;

			// Token: 0x04003DC9 RID: 15817
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_7_Internal_ModuleScriptProxy_ModuleScript_0;

			// Token: 0x04003DCA RID: 15818
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_8_Internal_RemoveEventProxy_RemoteEvent_0;

			// Token: 0x04003DCB RID: 15819
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_9_Internal_EnvironmentProxy_Environment_0;

			// Token: 0x04003DCC RID: 15820
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_10_Internal_PlayerProxy_Player_0;

			// Token: 0x04003DCD RID: 15821
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_11_Internal_PlayersProxy_Players_0;

			// Token: 0x04003DCE RID: 15822
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_12_Internal_Text3DProxy_Text3D_0;

			// Token: 0x04003DCF RID: 15823
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_13_Internal_SoundProxy_Sound_0;

			// Token: 0x04003DD0 RID: 15824
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_14_Internal_ToolProxy_Tool_0;

			// Token: 0x04003DD1 RID: 15825
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_15_Internal_NPCProxy_NPC_0;

			// Token: 0x04003DD2 RID: 15826
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_16_Internal_SpotlightProxy_Spotlight_0;

			// Token: 0x04003DD3 RID: 15827
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_17_Internal_ValueBaseProxy_ValueBase_0;

			// Token: 0x04003DD4 RID: 15828
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_18_Internal_BoolValueProxy_BoolValue_0;

			// Token: 0x04003DD5 RID: 15829
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_19_Internal_ColorValueProxy_ColorValue_0;

			// Token: 0x04003DD6 RID: 15830
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_20_Internal_StringValueProxy_StringValue_0;

			// Token: 0x04003DD7 RID: 15831
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_21_Internal_InstanceValueProxy_InstanceValue_0;

			// Token: 0x04003DD8 RID: 15832
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_22_Internal_IntValueProxy_IntValue_0;

			// Token: 0x04003DD9 RID: 15833
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_23_Internal_NumberValueProxy_NumberValue_0;

			// Token: 0x04003DDA RID: 15834
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_24_Internal_Vector3ValueProxy_Vector3Value_0;

			// Token: 0x04003DDB RID: 15835
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_25_Internal_MeshPartProxy_MeshPart_0;

			// Token: 0x04003DDC RID: 15836
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_26_Internal_BodyPositionProxy_BodyPosition_0;

			// Token: 0x04003DDD RID: 15837
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_27_Internal_BackpackProxy_Backpack_0;

			// Token: 0x04003DDE RID: 15838
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_28_Internal_LightingProxy_Lighting_0;

			// Token: 0x04003DDF RID: 15839
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_29_Internal_SunLightProxy_SunLight_0;

			// Token: 0x04003DE0 RID: 15840
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_30_Internal_ClimbableProxy_Climbable_0;

			// Token: 0x04003DE1 RID: 15841
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_31_Internal_DecalProxy_Decal_0;

			// Token: 0x04003DE2 RID: 15842
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_32_Internal_ParticlesProxy_Particles_0;

			// Token: 0x04003DE3 RID: 15843
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_33_Internal_HiddenProxy_Hidden_0;

			// Token: 0x04003DE4 RID: 15844
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_34_Internal_ServerHiddenProxy_ServerHidden_0;

			// Token: 0x04003DE5 RID: 15845
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_35_Internal_ModelProxy_Model_0;

			// Token: 0x04003DE6 RID: 15846
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_36_Internal_PointLightProxy_PointLight_0;

			// Token: 0x04003DE7 RID: 15847
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_37_Internal_TrussProxy_Truss_0;

			// Token: 0x04003DE8 RID: 15848
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_38_Internal_SeatProxy_Seat_0;

			// Token: 0x04003DE9 RID: 15849
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_39_Internal_SkyBaseProxy_SkyBase_0;

			// Token: 0x04003DEA RID: 15850
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_40_Internal_ImageSkyProxy_ImageSky_0;

			// Token: 0x04003DEB RID: 15851
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_41_Internal_GradientSkyProxy_GradientSky_0;

			// Token: 0x04003DEC RID: 15852
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_42_Internal_ProceduralSkyProxy_ProceduralSky_0;

			// Token: 0x04003DED RID: 15853
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_43_Internal_NetworkEventProxy_NetworkEvent_0;

			// Token: 0x04003DEE RID: 15854
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_44_Internal_SignalProxy_Signal_0;

			// Token: 0x04003DEF RID: 15855
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_45_Internal_PlayerDefaultsProxy_PlayerDefaults_0;

			// Token: 0x04003DF0 RID: 15856
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_46_Internal_GUIProxy_GUI_0;

			// Token: 0x04003DF1 RID: 15857
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_47_Internal_UIButtonProxy_UIButton_0;

			// Token: 0x04003DF2 RID: 15858
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_48_Internal_UIFieldProxy_UIField_0;

			// Token: 0x04003DF3 RID: 15859
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_49_Internal_UILabelProxy_UILabel_0;

			// Token: 0x04003DF4 RID: 15860
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_50_Internal_UITextInputProxy_UITextInput_0;

			// Token: 0x04003DF5 RID: 15861
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_51_Internal_UIViewProxy_UIView_0;

			// Token: 0x04003DF6 RID: 15862
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_52_Internal_UIImageProxy_UIImage_0;

			// Token: 0x04003DF7 RID: 15863
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_53_Internal_UIHVLayoutProxy_UIHVLayout_0;

			// Token: 0x04003DF8 RID: 15864
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_54_Internal_UIVerticalLayoutProxy_UIVerticalLayout_0;

			// Token: 0x04003DF9 RID: 15865
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_55_Internal_UIHorizontalLayoutProxy_UIHorizontalLayout_0;

			// Token: 0x04003DFA RID: 15866
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_56_Internal_PlayerGUIProxy_PlayerGUI_0;

			// Token: 0x04003DFB RID: 15867
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_57_Internal_CameraProxy_Camera_0;

			// Token: 0x04003DFC RID: 15868
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_58_Internal_DatastoreProxy_Datastore_0;

			// Token: 0x04003DFD RID: 15869
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_59_Internal_AchievementServiceProxy_AchievementService_0;

			// Token: 0x04003DFE RID: 15870
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_60_Internal_PurchasesServiceProxy_PurchasesService_0;

			// Token: 0x04003DFF RID: 15871
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_61_Internal_ChatServiceProxy_ChatService_0;

			// Token: 0x04003E00 RID: 15872
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_62_Internal_CoreUIServiceProxy_CoreUIService_0;

			// Token: 0x04003E01 RID: 15873
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_63_Internal_DatastoreProxy_Datastore_0;

			// Token: 0x04003E02 RID: 15874
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_64_Internal_DataStoreServiceProxy_DataStoreService_0;

			// Token: 0x04003E03 RID: 15875
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_65_Internal_FilterServiceProxy_FilterService_0;

			// Token: 0x04003E04 RID: 15876
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_66_Internal_HttpServiceProxy_HttpService_0;

			// Token: 0x04003E05 RID: 15877
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_67_Internal_InputServiceProxy_InputService_0;

			// Token: 0x04003E06 RID: 15878
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_68_Internal_InsertServiceProxy_InsertService_0;

			// Token: 0x04003E07 RID: 15879
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_69_Internal_TweenServiceProxy_TweenService_0;

			// Token: 0x04003E08 RID: 15880
			private static readonly IntPtr NativeMethodInfoPtr__RunScripts_b__14_0_Internal_Void_BaseScript_0;

			// Token: 0x04003E09 RID: 15881
			private static readonly IntPtr NativeMethodInfoPtr__RunLocalScripts_b__15_0_Internal_Void_BaseScript_0;
		}

		// Token: 0x02000414 RID: 1044
		[ObfuscatedName("Polytoria.Datamodel.Services.ScriptService+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06005088 RID: 20616 RVA: 0x00159AA4 File Offset: 0x00157CA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr);
				ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr, "script");
				ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr, 100673166);
				ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__RunScriptInstance_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr, 100673167);
				ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__RunScriptInstance_b__1_Internal_DynValue_ModuleScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr, 100673168);
			}

			// Token: 0x06005089 RID: 20617 RVA: 0x00159B34 File Offset: 0x00157D34
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptService.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600508A RID: 20618 RVA: 0x00159B70 File Offset: 0x00157D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125784, XrefRangeEnd = 125786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunScriptInstance_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__RunScriptInstance_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x00159BB4 File Offset: 0x00157DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125786, XrefRangeEnd = 125788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _RunScriptInstance_b__1(ModuleScript ms)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService.__c__DisplayClass25_0.NativeMethodInfoPtr__RunScriptInstance_b__1_Internal_DynValue_ModuleScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x0001EC16 File Offset: 0x0001CE16
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B27 RID: 6951
			// (get) Token: 0x0600508D RID: 20621 RVA: 0x00159C04 File Offset: 0x00157E04
			// (set) Token: 0x0600508E RID: 20622 RVA: 0x0001EC1F File Offset: 0x0001CE1F
			public unsafe ScriptService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B28 RID: 6952
			// (get) Token: 0x0600508F RID: 20623 RVA: 0x00159C34 File Offset: 0x00157E34
			// (set) Token: 0x06005090 RID: 20624 RVA: 0x0001EC3E File Offset: 0x0001CE3E
			public unsafe Script script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr_script);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService.__c__DisplayClass25_0.NativeFieldInfoPtr_script), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E0A RID: 15882
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E0B RID: 15883
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x04003E0C RID: 15884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E0D RID: 15885
			private static readonly IntPtr NativeMethodInfoPtr__RunScriptInstance_b__0_Internal_Void_String_0;

			// Token: 0x04003E0E RID: 15886
			private static readonly IntPtr NativeMethodInfoPtr__RunScriptInstance_b__1_Internal_DynValue_ModuleScript_0;
		}

		// Token: 0x02000415 RID: 1045
		[ObfuscatedName("Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__33")]
		public sealed class _InvokeEvent_d__33 : Object
		{
			// Token: 0x06005091 RID: 20625 RVA: 0x00159C64 File Offset: 0x00157E64
			// Note: this type is marked as 'beforefieldinit'.
			static _InvokeEvent_d__33()
			{
				Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "<InvokeEvent>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr);
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "<>1__state");
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "<>2__current");
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "func");
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "<>4__this");
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_par = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "par");
				ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr__coroutine_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, "<coroutine>5__2");
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673172);
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673174);
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673169);
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673170);
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673171);
				ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr, 100673173);
			}

			// Token: 0x17001B2F RID: 6959
			// (get) Token: 0x06005092 RID: 20626 RVA: 0x00159D80 File Offset: 0x00157F80
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B30 RID: 6960
			// (get) Token: 0x06005093 RID: 20627 RVA: 0x00159DC0 File Offset: 0x00157FC0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005094 RID: 20628 RVA: 0x00159E00 File Offset: 0x00158000
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InvokeEvent_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptService._InvokeEvent_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005095 RID: 20629 RVA: 0x00159E48 File Offset: 0x00158048
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005096 RID: 20630 RVA: 0x00159E7C File Offset: 0x0015807C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125788, XrefRangeEnd = 125806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005097 RID: 20631 RVA: 0x00159EB8 File Offset: 0x001580B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125806, XrefRangeEnd = 125811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._InvokeEvent_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005098 RID: 20632 RVA: 0x0001EC5D File Offset: 0x0001CE5D
			public _InvokeEvent_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B29 RID: 6953
			// (get) Token: 0x06005099 RID: 20633 RVA: 0x00159EEC File Offset: 0x001580EC
			// (set) Token: 0x0600509A RID: 20634 RVA: 0x0001EC66 File Offset: 0x0001CE66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B2A RID: 6954
			// (get) Token: 0x0600509B RID: 20635 RVA: 0x00159F14 File Offset: 0x00158114
			// (set) Token: 0x0600509C RID: 20636 RVA: 0x0001EC81 File Offset: 0x0001CE81
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2B RID: 6955
			// (get) Token: 0x0600509D RID: 20637 RVA: 0x00159F44 File Offset: 0x00158144
			// (set) Token: 0x0600509E RID: 20638 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
			public unsafe DynValue func
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_func);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_func), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2C RID: 6956
			// (get) Token: 0x0600509F RID: 20639 RVA: 0x00159F74 File Offset: 0x00158174
			// (set) Token: 0x060050A0 RID: 20640 RVA: 0x0001ECBF File Offset: 0x0001CEBF
			public unsafe ScriptService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2D RID: 6957
			// (get) Token: 0x060050A1 RID: 20641 RVA: 0x00159FA4 File Offset: 0x001581A4
			// (set) Token: 0x060050A2 RID: 20642 RVA: 0x0001ECDE File Offset: 0x0001CEDE
			public unsafe Il2CppReferenceArray<Object> par
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_par);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr_par), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2E RID: 6958
			// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00159FD4 File Offset: 0x001581D4
			// (set) Token: 0x060050A4 RID: 20644 RVA: 0x0001ECFD File Offset: 0x0001CEFD
			public unsafe DynValue _coroutine_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr__coroutine_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._InvokeEvent_d__33.NativeFieldInfoPtr__coroutine_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E0F RID: 15887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E10 RID: 15888
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E11 RID: 15889
			private static readonly IntPtr NativeFieldInfoPtr_func;

			// Token: 0x04003E12 RID: 15890
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E13 RID: 15891
			private static readonly IntPtr NativeFieldInfoPtr_par;

			// Token: 0x04003E14 RID: 15892
			private static readonly IntPtr NativeFieldInfoPtr__coroutine_5__2;

			// Token: 0x04003E15 RID: 15893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E16 RID: 15894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E17 RID: 15895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E18 RID: 15896
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E19 RID: 15897
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E1A RID: 15898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000416 RID: 1046
		[ObfuscatedName("Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__25")]
		public sealed class _RunScriptInstance_d__25 : Object
		{
			// Token: 0x060050A5 RID: 20645 RVA: 0x0015A004 File Offset: 0x00158204
			// Note: this type is marked as 'beforefieldinit'.
			static _RunScriptInstance_d__25()
			{
				Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptService>.NativeClassPtr, "<RunScriptInstance>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr);
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<>1__state");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<>2__current");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<>4__this");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr_scriptInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "scriptInstance");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<>8__1");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__coroutine_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<coroutine>5__2");
				ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__timeout_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, "<timeout>5__3");
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673178);
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673180);
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673175);
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673176);
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673177);
				ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr, 100673179);
			}

			// Token: 0x17001B38 RID: 6968
			// (get) Token: 0x060050A6 RID: 20646 RVA: 0x0015A134 File Offset: 0x00158334
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B39 RID: 6969
			// (get) Token: 0x060050A7 RID: 20647 RVA: 0x0015A174 File Offset: 0x00158374
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050A8 RID: 20648 RVA: 0x0015A1B4 File Offset: 0x001583B4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunScriptInstance_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptService._RunScriptInstance_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A9 RID: 20649 RVA: 0x0015A1FC File Offset: 0x001583FC
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050AA RID: 20650 RVA: 0x0015A230 File Offset: 0x00158430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125811, XrefRangeEnd = 125959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050AB RID: 20651 RVA: 0x0015A26C File Offset: 0x0015846C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125959, XrefRangeEnd = 125964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptService._RunScriptInstance_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050AC RID: 20652 RVA: 0x0001ED1C File Offset: 0x0001CF1C
			public _RunScriptInstance_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B31 RID: 6961
			// (get) Token: 0x060050AD RID: 20653 RVA: 0x0015A2A0 File Offset: 0x001584A0
			// (set) Token: 0x060050AE RID: 20654 RVA: 0x0001ED25 File Offset: 0x0001CF25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B32 RID: 6962
			// (get) Token: 0x060050AF RID: 20655 RVA: 0x0015A2C8 File Offset: 0x001584C8
			// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0001ED40 File Offset: 0x0001CF40
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B33 RID: 6963
			// (get) Token: 0x060050B1 RID: 20657 RVA: 0x0015A2F8 File Offset: 0x001584F8
			// (set) Token: 0x060050B2 RID: 20658 RVA: 0x0001ED5F File Offset: 0x0001CF5F
			public unsafe ScriptService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B34 RID: 6964
			// (get) Token: 0x060050B3 RID: 20659 RVA: 0x0015A328 File Offset: 0x00158528
			// (set) Token: 0x060050B4 RID: 20660 RVA: 0x0001ED7E File Offset: 0x0001CF7E
			public unsafe BaseScript scriptInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr_scriptInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr_scriptInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B35 RID: 6965
			// (get) Token: 0x060050B5 RID: 20661 RVA: 0x0015A358 File Offset: 0x00158558
			// (set) Token: 0x060050B6 RID: 20662 RVA: 0x0001ED9D File Offset: 0x0001CF9D
			public unsafe ScriptService.__c__DisplayClass25_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B36 RID: 6966
			// (get) Token: 0x060050B7 RID: 20663 RVA: 0x0015A388 File Offset: 0x00158588
			// (set) Token: 0x060050B8 RID: 20664 RVA: 0x0001EDBC File Offset: 0x0001CFBC
			public unsafe DynValue _coroutine_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__coroutine_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__coroutine_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B37 RID: 6967
			// (get) Token: 0x060050B9 RID: 20665 RVA: 0x0015A3B8 File Offset: 0x001585B8
			// (set) Token: 0x060050BA RID: 20666 RVA: 0x0001EDDB File Offset: 0x0001CFDB
			public unsafe float _timeout_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__timeout_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptService._RunScriptInstance_d__25.NativeFieldInfoPtr__timeout_5__3)) = value;
				}
			}

			// Token: 0x04003E1B RID: 15899
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E1C RID: 15900
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E1D RID: 15901
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E1E RID: 15902
			private static readonly IntPtr NativeFieldInfoPtr_scriptInstance;

			// Token: 0x04003E1F RID: 15903
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003E20 RID: 15904
			private static readonly IntPtr NativeFieldInfoPtr__coroutine_5__2;

			// Token: 0x04003E21 RID: 15905
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__3;

			// Token: 0x04003E22 RID: 15906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E23 RID: 15907
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E24 RID: 15908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E25 RID: 15909
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E26 RID: 15910
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E27 RID: 15911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
