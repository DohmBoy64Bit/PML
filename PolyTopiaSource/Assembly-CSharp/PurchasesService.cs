using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

// Token: 0x02000009 RID: 9
public class PurchasesService : NetworkBehaviour
{
	// Token: 0x06000038 RID: 56 RVA: 0x00021B00 File Offset: 0x0001FD00
	// Note: this type is marked as 'beforefieldinit'.
	static PurchasesService()
	{
		Il2CppClassPointerStore<PurchasesService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PurchasesService");
		PurchasesService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "<Instance>k__BackingField");
		PurchasesService.NativeFieldInfoPtr_purchaseModalPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "purchaseModalPrefab");
		PurchasesService.NativeFieldInfoPtr_purchaseResultPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "purchaseResultPrefab");
		PurchasesService.NativeFieldInfoPtr_currentRefId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "currentRefId");
		PurchasesService.NativeFieldInfoPtr_pendingPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "pendingPurchases");
		PurchasesService.NativeFieldInfoPtr_readyToPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "readyToPurchase");
		PurchasesService.NativeFieldInfoPtr_currentExpectedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "currentExpectedPrice");
		PurchasesService.NativeMethodInfoPtr_get_Instance_Public_Static_get_PurchasesService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663322);
		PurchasesService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_PurchasesService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663323);
		PurchasesService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663337);
		PurchasesService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663324);
		PurchasesService.NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663325);
		PurchasesService.NativeMethodInfoPtr_DispatchPurchase_Private_Void_NetworkConnection_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663326);
		PurchasesService.NativeMethodInfoPtr_ShowPurchaseModal_Private_IEnumerator_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663327);
		PurchasesService.NativeMethodInfoPtr_CancelButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663328);
		PurchasesService.NativeMethodInfoPtr_PurchaseButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663329);
		PurchasesService.NativeMethodInfoPtr_CmdProcessPurchase_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663330);
		PurchasesService.NativeMethodInfoPtr_CmdCancelPurchase_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663331);
		PurchasesService.NativeMethodInfoPtr_DoProcessPurchase_Private_IEnumerator_PurchaseRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663332);
		PurchasesService.NativeMethodInfoPtr_TargetPurchaseResult_Private_Void_NetworkConnection_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663333);
		PurchasesService.NativeMethodInfoPtr_ShowPurchaseResultUI_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663334);
		PurchasesService.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663335);
		PurchasesService.NativeMethodInfoPtr_CleanupExpiredPurchases_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663336);
		PurchasesService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663338);
		PurchasesService.NativeMethodInfoPtr_UserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Void_NetworkConnection_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663339);
		PurchasesService.NativeMethodInfoPtr_InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663340);
		PurchasesService.NativeMethodInfoPtr_UserCode_CmdProcessPurchase__String__Int32_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663341);
		PurchasesService.NativeMethodInfoPtr_InvokeUserCode_CmdProcessPurchase__String__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663342);
		PurchasesService.NativeMethodInfoPtr_UserCode_CmdCancelPurchase__String_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663343);
		PurchasesService.NativeMethodInfoPtr_InvokeUserCode_CmdCancelPurchase__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663344);
		PurchasesService.NativeMethodInfoPtr_UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Void_NetworkConnection_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663345);
		PurchasesService.NativeMethodInfoPtr_InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, 100663346);
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000039 RID: 57 RVA: 0x00021DA8 File Offset: 0x0001FFA8
	// (set) Token: 0x0600003A RID: 58 RVA: 0x00021DDC File Offset: 0x0001FFDC
	public unsafe static PurchasesService Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56025, XrefRangeEnd = 56029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_get_Instance_Public_Static_get_PurchasesService_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PurchasesService>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56029, XrefRangeEnd = 56035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_PurchasesService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00021E14 File Offset: 0x00020014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56035, XrefRangeEnd = 56043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PurchasesService()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00021E50 File Offset: 0x00020050
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56043, XrefRangeEnd = 56057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00021E84 File Offset: 0x00020084
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56093, RefRangeEnd = 56094, XrefRangeStart = 56057, XrefRangeEnd = 56093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prompt(Player player, int assetID, DynValue callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00021EE8 File Offset: 0x000200E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56094, XrefRangeEnd = 56116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchPurchase(NetworkConnection target, int assetID, string refId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_DispatchPurchase_Private_Void_NetworkConnection_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00021F4C File Offset: 0x0002014C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56116, XrefRangeEnd = 56122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ShowPurchaseModal(int assetID, string refId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref assetID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_ShowPurchaseModal_Private_IEnumerator_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00021FAC File Offset: 0x000201AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56122, XrefRangeEnd = 56146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_CancelButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00021FE0 File Offset: 0x000201E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56146, XrefRangeEnd = 56177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurchaseButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_PurchaseButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00022014 File Offset: 0x00020214
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56177, XrefRangeEnd = 56199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CmdProcessPurchase(string refId, int expectedPrice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(refId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectedPrice;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_CmdProcessPurchase_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00022064 File Offset: 0x00020264
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56199, XrefRangeEnd = 56220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CmdCancelPurchase(string refId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(refId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_CmdCancelPurchase_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000220A8 File Offset: 0x000202A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56220, XrefRangeEnd = 56226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DoProcessPurchase(PurchasesService.PurchaseRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(request));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_DoProcessPurchase_Private_IEnumerator_PurchaseRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00022100 File Offset: 0x00020300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56226, XrefRangeEnd = 56248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TargetPurchaseResult(NetworkConnection target, bool success, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_TargetPurchaseResult_Private_Void_NetworkConnection_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00022164 File Offset: 0x00020364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56248, XrefRangeEnd = 56262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowPurchaseResultUI(bool success, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref success;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_ShowPurchaseResultUI_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000221B4 File Offset: 0x000203B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56262, XrefRangeEnd = 56264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000221E8 File Offset: 0x000203E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56338, RefRangeEnd = 56339, XrefRangeStart = 56264, XrefRangeEnd = 56338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupExpiredPurchases()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_CleanupExpiredPurchases_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0002221C File Offset: 0x0002041C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Weaved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PurchasesService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00022264 File Offset: 0x00020464
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56339, XrefRangeEnd = 56347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkConnection target, int assetID, string refId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_UserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Void_NetworkConnection_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000222C8 File Offset: 0x000204C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56347, XrefRangeEnd = 56371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00022324 File Offset: 0x00020524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56371, XrefRangeEnd = 56386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserCode_CmdProcessPurchase__String__Int32(string refId, int expectedPrice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(refId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectedPrice;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_UserCode_CmdProcessPurchase__String__Int32_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00022374 File Offset: 0x00020574
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56386, XrefRangeEnd = 56414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUserCode_CmdProcessPurchase__String__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_InvokeUserCode_CmdProcessPurchase__String__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000223D0 File Offset: 0x000205D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56438, RefRangeEnd = 56439, XrefRangeStart = 56414, XrefRangeEnd = 56438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserCode_CmdCancelPurchase__String(string refId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(refId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_UserCode_CmdCancelPurchase__String_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00022414 File Offset: 0x00020614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56439, XrefRangeEnd = 56458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUserCode_CmdCancelPurchase__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_InvokeUserCode_CmdCancelPurchase__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00022470 File Offset: 0x00020670
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56458, XrefRangeEnd = 56519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkConnection target, bool success, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Void_NetworkConnection_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000224D4 File Offset: 0x000206D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56519, XrefRangeEnd = 56548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.NativeMethodInfoPtr_InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000216E File Offset: 0x0000036E
	public PurchasesService(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000053 RID: 83 RVA: 0x00022530 File Offset: 0x00020730
	// (set) Token: 0x06000054 RID: 84 RVA: 0x00002177 File Offset: 0x00000377
	public unsafe static PurchasesService _Instance_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PurchasesService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasesService>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PurchasesService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00022558 File Offset: 0x00020758
	// (set) Token: 0x06000056 RID: 86 RVA: 0x00002189 File Offset: 0x00000389
	public unsafe RectTransform purchaseModalPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_purchaseModalPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_purchaseModalPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00022588 File Offset: 0x00020788
	// (set) Token: 0x06000058 RID: 88 RVA: 0x000021A8 File Offset: 0x000003A8
	public unsafe RectTransform purchaseResultPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_purchaseResultPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_purchaseResultPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000059 RID: 89 RVA: 0x000225B8 File Offset: 0x000207B8
	// (set) Token: 0x0600005A RID: 90 RVA: 0x000021C7 File Offset: 0x000003C7
	public unsafe string currentRefId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_currentRefId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_currentRefId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600005B RID: 91 RVA: 0x000225E0 File Offset: 0x000207E0
	// (set) Token: 0x0600005C RID: 92 RVA: 0x000021E6 File Offset: 0x000003E6
	public unsafe Dictionary<string, PurchasesService.PurchaseRequest> pendingPurchases
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_pendingPurchases);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PurchasesService.PurchaseRequest>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_pendingPurchases), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600005D RID: 93 RVA: 0x00022610 File Offset: 0x00020810
	// (set) Token: 0x0600005E RID: 94 RVA: 0x00002205 File Offset: 0x00000405
	public unsafe bool readyToPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_readyToPurchase);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_readyToPurchase)) = value;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600005F RID: 95 RVA: 0x00022638 File Offset: 0x00020838
	// (set) Token: 0x06000060 RID: 96 RVA: 0x00002220 File Offset: 0x00000420
	public unsafe int currentExpectedPrice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_currentExpectedPrice);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.NativeFieldInfoPtr_currentExpectedPrice)) = value;
		}
	}

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeFieldInfoPtr_purchaseModalPrefab;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeFieldInfoPtr_purchaseResultPrefab;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeFieldInfoPtr_currentRefId;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_pendingPurchases;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr_readyToPurchase;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr_currentExpectedPrice;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_PurchasesService_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_PurchasesService_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_DispatchPurchase_Private_Void_NetworkConnection_Int32_String_0;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr_ShowPurchaseModal_Private_IEnumerator_Int32_String_0;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeMethodInfoPtr_CancelButton_Public_Void_0;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseButton_Public_Void_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr_CmdProcessPurchase_Private_Void_String_Int32_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr_CmdCancelPurchase_Private_Void_String_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_DoProcessPurchase_Private_IEnumerator_PurchaseRequest_0;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeMethodInfoPtr_TargetPurchaseResult_Private_Void_NetworkConnection_Boolean_String_0;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_ShowPurchaseResultUI_Private_Void_Boolean_String_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_CleanupExpiredPurchases_Private_Void_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_UserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Void_NetworkConnection_Int32_String_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdProcessPurchase__String__Int32_Protected_Void_String_Int32_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdProcessPurchase__String__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdCancelPurchase__String_Protected_Void_String_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdCancelPurchase__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Void_NetworkConnection_Boolean_String_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

	// Token: 0x02000349 RID: 841
	public sealed class PurchaseRequest : ValueType
	{
		// Token: 0x0600491D RID: 18717 RVA: 0x00143AC8 File Offset: 0x00141CC8
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseRequest()
		{
			Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "PurchaseRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr);
			PurchasesService.PurchaseRequest.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, "player");
			PurchasesService.PurchaseRequest.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, "assetID");
			PurchasesService.PurchaseRequest.NativeFieldInfoPtr_expectedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, "expectedPrice");
			PurchasesService.PurchaseRequest.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, "callback");
			PurchasesService.PurchaseRequest.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, "timestamp");
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x0001B103 File Offset: 0x00019303
		public PurchaseRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0001B10C File Offset: 0x0001930C
		public PurchaseRequest()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr))
		{
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00143B58 File Offset: 0x00141D58
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x0001B11E File Offset: 0x0001931E
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x00143B88 File Offset: 0x00141D88
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x0001B13D File Offset: 0x0001933D
		public unsafe int assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_assetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_assetID)) = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x00143BB0 File Offset: 0x00141DB0
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x0001B158 File Offset: 0x00019358
		public unsafe int expectedPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_expectedPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_expectedPrice)) = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x00143BD8 File Offset: 0x00141DD8
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x0001B173 File Offset: 0x00019373
		public unsafe DynValue callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x00143C08 File Offset: 0x00141E08
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x0001B192 File Offset: 0x00019392
		public unsafe DateTime timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_timestamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.PurchaseRequest.NativeFieldInfoPtr_timestamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeFieldInfoPtr_assetID;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeFieldInfoPtr_expectedPrice;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;
	}

	// Token: 0x0200034A RID: 842
	[ObfuscatedName("PurchasesService+<>c__DisplayClass13_0")]
	public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
	{
		// Token: 0x0600492A RID: 18730 RVA: 0x00143C38 File Offset: 0x00141E38
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass13_0()
		{
			Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "<>c__DisplayClass13_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr);
			PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr, "assetID");
			PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_refId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr, "refId");
			PurchasesService.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr, 100663348);
			PurchasesService.__c__DisplayClass13_0.NativeMethodInfoPtr__ShowPurchaseModal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr, 100663349);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00143CB4 File Offset: 0x00141EB4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass13_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesService.__c__DisplayClass13_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00143CF0 File Offset: 0x00141EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55708, XrefRangeEnd = 55717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowPurchaseModal_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService.__c__DisplayClass13_0.NativeMethodInfoPtr__ShowPurchaseModal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x0001B1B1 File Offset: 0x000193B1
		public __c__DisplayClass13_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x00143D24 File Offset: 0x00141F24
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x0001B1BA File Offset: 0x000193BA
		public unsafe int assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_assetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_assetID)) = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x00143D4C File Offset: 0x00141F4C
		// (set) Token: 0x06004931 RID: 18737 RVA: 0x0001B1D5 File Offset: 0x000193D5
		public unsafe string refId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_refId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService.__c__DisplayClass13_0.NativeFieldInfoPtr_refId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeFieldInfoPtr_assetID;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeFieldInfoPtr_refId;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeMethodInfoPtr__ShowPurchaseModal_b__0_Internal_Void_0;
	}

	// Token: 0x0200034B RID: 843
	[ObfuscatedName("PurchasesService+<DoProcessPurchase>d__18")]
	public sealed class _DoProcessPurchase_d__18 : global::Il2CppSystem.Object
	{
		// Token: 0x06004932 RID: 18738 RVA: 0x00143D74 File Offset: 0x00141F74
		// Note: this type is marked as 'beforefieldinit'.
		static _DoProcessPurchase_d__18()
		{
			Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "<DoProcessPurchase>d__18");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr);
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<>1__state");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<>2__current");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "request");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<>4__this");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__success_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<success>5__2");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__message_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<message>5__3");
			PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__uwr_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, "<uwr>5__4");
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663354);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663356);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663350);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663351);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663352);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663353);
			PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr, 100663355);
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x00143EB8 File Offset: 0x001420B8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x00143EF8 File Offset: 0x001420F8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00143F38 File Offset: 0x00142138
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DoProcessPurchase_d__18(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesService._DoProcessPurchase_d__18>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00143F80 File Offset: 0x00142180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55717, XrefRangeEnd = 55722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00143FB4 File Offset: 0x001421B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55722, XrefRangeEnd = 55852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00143FF0 File Offset: 0x001421F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55852, XrefRangeEnd = 55855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00144024 File Offset: 0x00142224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55855, XrefRangeEnd = 55860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._DoProcessPurchase_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x0001B1F4 File Offset: 0x000193F4
		public _DoProcessPurchase_d__18(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x00144058 File Offset: 0x00142258
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x0001B1FD File Offset: 0x000193FD
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x00144080 File Offset: 0x00142280
		// (set) Token: 0x0600493E RID: 18750 RVA: 0x0001B218 File Offset: 0x00019418
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x001440B0 File Offset: 0x001422B0
		// (set) Token: 0x06004940 RID: 18752 RVA: 0x0001B237 File Offset: 0x00019437
		public PurchasesService.PurchaseRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr_request);
				return new PurchasesService.PurchaseRequest(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr_request), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PurchasesService.PurchaseRequest>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x001440E0 File Offset: 0x001422E0
		// (set) Token: 0x06004942 RID: 18754 RVA: 0x0001B265 File Offset: 0x00019465
		public unsafe PurchasesService __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasesService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x00144110 File Offset: 0x00142310
		// (set) Token: 0x06004944 RID: 18756 RVA: 0x0001B284 File Offset: 0x00019484
		public unsafe bool _success_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__success_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__success_5__2)) = value;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00144138 File Offset: 0x00142338
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x0001B29F File Offset: 0x0001949F
		public unsafe string _message_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__message_5__3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__message_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00144160 File Offset: 0x00142360
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x0001B2BE File Offset: 0x000194BE
		public unsafe UnityWebRequest _uwr_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__uwr_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._DoProcessPurchase_d__18.NativeFieldInfoPtr__uwr_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeFieldInfoPtr__success_5__2;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeFieldInfoPtr__message_5__3;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeFieldInfoPtr__uwr_5__4;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
	}

	// Token: 0x0200034C RID: 844
	[ObfuscatedName("PurchasesService+<ShowPurchaseModal>d__13")]
	public sealed class _ShowPurchaseModal_d__13 : global::Il2CppSystem.Object
	{
		// Token: 0x06004949 RID: 18761 RVA: 0x00144190 File Offset: 0x00142390
		// Note: this type is marked as 'beforefieldinit'.
		static _ShowPurchaseModal_d__13()
		{
			Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasesService>.NativeClassPtr, "<ShowPurchaseModal>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr);
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<>1__state");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<>2__current");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "assetID");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_refId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "refId");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<>8__1");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<>4__this");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<www>5__2");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__assetName_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<assetName>5__3");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__price_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<price>5__4");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__thumbnailRequest_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<thumbnailRequest>5__5");
			PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__purchaseButton_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, "<purchaseButton>5__6");
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663362);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663364);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663357);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663358);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663359);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663360);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663361);
			PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr, 100663363);
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x00144338 File Offset: 0x00142538
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00144378 File Offset: 0x00142578
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x001443B8 File Offset: 0x001425B8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ShowPurchaseModal_d__13(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesService._ShowPurchaseModal_d__13>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00144400 File Offset: 0x00142600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55860, XrefRangeEnd = 55870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00144434 File Offset: 0x00142634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55870, XrefRangeEnd = 56014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00144470 File Offset: 0x00142670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56014, XrefRangeEnd = 56017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x001444A4 File Offset: 0x001426A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56017, XrefRangeEnd = 56020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001444D8 File Offset: 0x001426D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56020, XrefRangeEnd = 56025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesService._ShowPurchaseModal_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x0001B2DD File Offset: 0x000194DD
		public _ShowPurchaseModal_d__13(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x0014450C File Offset: 0x0014270C
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x0001B2E6 File Offset: 0x000194E6
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x00144534 File Offset: 0x00142734
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x0001B301 File Offset: 0x00019501
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x00144564 File Offset: 0x00142764
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x0001B320 File Offset: 0x00019520
		public unsafe int assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_assetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_assetID)) = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x0014458C File Offset: 0x0014278C
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x0001B33B File Offset: 0x0001953B
		public unsafe string refId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_refId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr_refId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x001445B4 File Offset: 0x001427B4
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x0001B35A File Offset: 0x0001955A
		public unsafe PurchasesService.__c__DisplayClass13_0 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasesService.__c__DisplayClass13_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x001445E4 File Offset: 0x001427E4
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x0001B379 File Offset: 0x00019579
		public unsafe PurchasesService __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasesService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00144614 File Offset: 0x00142814
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x0001B398 File Offset: 0x00019598
		public unsafe UnityWebRequest _www_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__www_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x00144644 File Offset: 0x00142844
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x0001B3B7 File Offset: 0x000195B7
		public unsafe string _assetName_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__assetName_5__3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__assetName_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x0014466C File Offset: 0x0014286C
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x0001B3D6 File Offset: 0x000195D6
		public unsafe int _price_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__price_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__price_5__4)) = value;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x00144694 File Offset: 0x00142894
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x0001B3F1 File Offset: 0x000195F1
		public unsafe UnityWebRequest _thumbnailRequest_5__5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__thumbnailRequest_5__5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__thumbnailRequest_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x001446C4 File Offset: 0x001428C4
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x0001B410 File Offset: 0x00019610
		public unsafe Button _purchaseButton_5__6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__purchaseButton_5__6);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesService._ShowPurchaseModal_d__13.NativeFieldInfoPtr__purchaseButton_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeFieldInfoPtr_assetID;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeFieldInfoPtr_refId;

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeFieldInfoPtr__assetName_5__3;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeFieldInfoPtr__price_5__4;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeFieldInfoPtr__thumbnailRequest_5__5;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeFieldInfoPtr__purchaseButton_5__6;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
	}
}
