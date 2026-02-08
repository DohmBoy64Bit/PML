using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Discord
{
	// Token: 0x02000163 RID: 355
	public class StoreManager : Object
	{
		// Token: 0x06001832 RID: 6194 RVA: 0x00079C20 File Offset: 0x00077E20
		// Note: this type is marked as 'beforefieldinit'.
		static StoreManager()
		{
			Il2CppClassPointerStore<StoreManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "StoreManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreManager>.NativeClassPtr);
			StoreManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "MethodsPtr");
			StoreManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "MethodsStructure");
			StoreManager.NativeFieldInfoPtr_OnEntitlementCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "OnEntitlementCreate");
			StoreManager.NativeFieldInfoPtr_OnEntitlementDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "OnEntitlementDelete");
			StoreManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668323);
			StoreManager.NativeMethodInfoPtr_add_OnEntitlementCreate_Public_add_Void_EntitlementCreateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668324);
			StoreManager.NativeMethodInfoPtr_remove_OnEntitlementCreate_Public_rem_Void_EntitlementCreateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668325);
			StoreManager.NativeMethodInfoPtr_add_OnEntitlementDelete_Public_add_Void_EntitlementDeleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668326);
			StoreManager.NativeMethodInfoPtr_remove_OnEntitlementDelete_Public_rem_Void_EntitlementDeleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668327);
			StoreManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668328);
			StoreManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668329);
			StoreManager.NativeMethodInfoPtr_FetchSkusCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668330);
			StoreManager.NativeMethodInfoPtr_FetchSkus_Public_Void_FetchSkusHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668331);
			StoreManager.NativeMethodInfoPtr_CountSkus_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668332);
			StoreManager.NativeMethodInfoPtr_GetSku_Public_Sku_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668333);
			StoreManager.NativeMethodInfoPtr_GetSkuAt_Public_Sku_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668334);
			StoreManager.NativeMethodInfoPtr_FetchEntitlementsCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668335);
			StoreManager.NativeMethodInfoPtr_FetchEntitlements_Public_Void_FetchEntitlementsHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668336);
			StoreManager.NativeMethodInfoPtr_CountEntitlements_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668337);
			StoreManager.NativeMethodInfoPtr_GetEntitlement_Public_Entitlement_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668338);
			StoreManager.NativeMethodInfoPtr_GetEntitlementAt_Public_Entitlement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668339);
			StoreManager.NativeMethodInfoPtr_HasSkuEntitlement_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668340);
			StoreManager.NativeMethodInfoPtr_StartPurchaseCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668341);
			StoreManager.NativeMethodInfoPtr_StartPurchase_Public_Void_Int64_StartPurchaseHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668342);
			StoreManager.NativeMethodInfoPtr_OnEntitlementCreateImpl_Private_Static_Void_IntPtr_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668343);
			StoreManager.NativeMethodInfoPtr_OnEntitlementDeleteImpl_Private_Static_Void_IntPtr_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668344);
			StoreManager.NativeMethodInfoPtr_GetEntitlements_Public_IEnumerable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668345);
			StoreManager.NativeMethodInfoPtr_GetSkus_Public_IEnumerable_1_Sku_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, 100668346);
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00079E80 File Offset: 0x00078080
		public unsafe StoreManager.FFIMethods Methods
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 55120, RefRangeEnd = 55134, XrefRangeStart = 55107, XrefRangeEnd = 55120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StoreManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00079EB8 File Offset: 0x000780B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55134, XrefRangeEnd = 55138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_add_OnEntitlementCreate_Public_add_Void_EntitlementCreateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00079EFC File Offset: 0x000780FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55138, XrefRangeEnd = 55142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_remove_OnEntitlementCreate_Public_rem_Void_EntitlementCreateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00079F40 File Offset: 0x00078140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55142, XrefRangeEnd = 55146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_add_OnEntitlementDelete_Public_add_Void_EntitlementDeleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00079F84 File Offset: 0x00078184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55146, XrefRangeEnd = 55150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_remove_OnEntitlementDelete_Public_rem_Void_EntitlementDeleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00079FC8 File Offset: 0x000781C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55152, RefRangeEnd = 55153, XrefRangeStart = 55150, XrefRangeEnd = 55152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreManager(IntPtr ptr, IntPtr eventsPtr, ref StoreManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0007A030 File Offset: 0x00078230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55177, RefRangeEnd = 55178, XrefRangeStart = 55153, XrefRangeEnd = 55177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref StoreManager.FFIEvents events)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0007A084 File Offset: 0x00078284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55178, XrefRangeEnd = 55185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_FetchSkusCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0007A0C8 File Offset: 0x000782C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55185, XrefRangeEnd = 55196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchSkus(StoreManager.FetchSkusHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_FetchSkus_Public_Void_FetchSkusHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0007A10C File Offset: 0x0007830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55196, XrefRangeEnd = 55197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountSkus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_CountSkus_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0007A148 File Offset: 0x00078348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55197, XrefRangeEnd = 55198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sku GetSku(long skuId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skuId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetSku_Public_Sku_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sku>(intPtr3) : null;
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0007A194 File Offset: 0x00078394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55198, XrefRangeEnd = 55199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sku GetSkuAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetSkuAt_Public_Sku_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sku>(intPtr3) : null;
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0007A1E0 File Offset: 0x000783E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55199, XrefRangeEnd = 55206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_FetchEntitlementsCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0007A224 File Offset: 0x00078424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55206, XrefRangeEnd = 55217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchEntitlements(StoreManager.FetchEntitlementsHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_FetchEntitlements_Public_Void_FetchEntitlementsHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0007A268 File Offset: 0x00078468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55217, XrefRangeEnd = 55218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountEntitlements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_CountEntitlements_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0007A2A4 File Offset: 0x000784A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55218, XrefRangeEnd = 55219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entitlement GetEntitlement(long entitlementId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entitlementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetEntitlement_Public_Entitlement_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entitlement>(intPtr3) : null;
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0007A2F0 File Offset: 0x000784F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55219, XrefRangeEnd = 55220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entitlement GetEntitlementAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetEntitlementAt_Public_Entitlement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entitlement>(intPtr3) : null;
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0007A33C File Offset: 0x0007853C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55220, XrefRangeEnd = 55221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSkuEntitlement(long skuId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skuId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_HasSkuEntitlement_Public_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0007A388 File Offset: 0x00078588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55221, XrefRangeEnd = 55228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_StartPurchaseCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0007A3CC File Offset: 0x000785CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55228, XrefRangeEnd = 55239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPurchase(long skuId, StoreManager.StartPurchaseHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skuId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_StartPurchase_Public_Void_Int64_StartPurchaseHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0007A41C File Offset: 0x0007861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55239, XrefRangeEnd = 55245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_OnEntitlementCreateImpl_Private_Static_Void_IntPtr_byref_Entitlement_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0007A45C File Offset: 0x0007865C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55245, XrefRangeEnd = 55251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_OnEntitlementDeleteImpl_Private_Static_Void_IntPtr_byref_Entitlement_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0007A49C File Offset: 0x0007869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55251, XrefRangeEnd = 55263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entitlement> GetEntitlements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetEntitlements_Public_IEnumerable_1_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entitlement>>(intPtr3) : null;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0007A4DC File Offset: 0x000786DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55263, XrefRangeEnd = 55276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Sku> GetSkus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.NativeMethodInfoPtr_GetSkus_Public_IEnumerable_1_Sku_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sku>>(intPtr3) : null;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00009943 File Offset: 0x00007B43
		public StoreManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0007A51C File Offset: 0x0007871C
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000994C File Offset: 0x00007B4C
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0007A544 File Offset: 0x00078744
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x00009967 File Offset: 0x00007B67
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0007A574 File Offset: 0x00078774
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x00009986 File Offset: 0x00007B86
		public unsafe StoreManager.EntitlementCreateHandler OnEntitlementCreate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_OnEntitlementCreate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.EntitlementCreateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_OnEntitlementCreate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0007A5A4 File Offset: 0x000787A4
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x000099A5 File Offset: 0x00007BA5
		public unsafe StoreManager.EntitlementDeleteHandler OnEntitlementDelete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_OnEntitlementDelete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.EntitlementDeleteHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.NativeFieldInfoPtr_OnEntitlementDelete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_OnEntitlementCreate;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_OnEntitlementDelete;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_add_OnEntitlementCreate_Public_add_Void_EntitlementCreateHandler_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntitlementCreate_Public_rem_Void_EntitlementCreateHandler_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_add_OnEntitlementDelete_Public_add_Void_EntitlementDeleteHandler_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntitlementDelete_Public_rem_Void_EntitlementDeleteHandler_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_FetchSkusCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_FetchSkus_Public_Void_FetchSkusHandler_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_CountSkus_Public_Int32_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_GetSku_Public_Sku_Int64_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_GetSkuAt_Public_Sku_Int32_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_FetchEntitlementsCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_FetchEntitlements_Public_Void_FetchEntitlementsHandler_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_CountEntitlements_Public_Int32_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_GetEntitlement_Public_Entitlement_Int64_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_GetEntitlementAt_Public_Entitlement_Int32_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_HasSkuEntitlement_Public_Boolean_Int64_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchaseCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Public_Void_Int64_StartPurchaseHandler_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitlementCreateImpl_Private_Static_Void_IntPtr_byref_Entitlement_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitlementDeleteImpl_Private_Static_Void_IntPtr_byref_Entitlement_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_GetEntitlements_Public_IEnumerable_1_Entitlement_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_GetSkus_Public_IEnumerable_1_Sku_0;

		// Token: 0x0200023C RID: 572
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x060020D8 RID: 8408 RVA: 0x0009685C File Offset: 0x00094A5C
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr);
				StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, "OnEntitlementCreate");
				StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, "OnEntitlementDelete");
			}

			// Token: 0x060020D9 RID: 8409 RVA: 0x0000D986 File Offset: 0x0000BB86
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020DA RID: 8410 RVA: 0x0000D98F File Offset: 0x0000BB8F
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x060020DB RID: 8411 RVA: 0x000968B0 File Offset: 0x00094AB0
			// (set) Token: 0x060020DC RID: 8412 RVA: 0x0000D9A1 File Offset: 0x0000BBA1
			public unsafe StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementCreate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIEvents.EntitlementCreateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementCreate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x060020DD RID: 8413 RVA: 0x000968E0 File Offset: 0x00094AE0
			// (set) Token: 0x060020DE RID: 8414 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
			public unsafe StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementDelete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIEvents.EntitlementDeleteHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIEvents.NativeFieldInfoPtr_OnEntitlementDelete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400193D RID: 6461
			private static readonly IntPtr NativeFieldInfoPtr_OnEntitlementCreate;

			// Token: 0x0400193E RID: 6462
			private static readonly IntPtr NativeFieldInfoPtr_OnEntitlementDelete;

			// Token: 0x020002FC RID: 764
			public sealed class EntitlementCreateHandler : MulticastDelegate
			{
				// Token: 0x0600270D RID: 9997 RVA: 0x000AEACC File Offset: 0x000ACCCC
				// Note: this type is marked as 'beforefieldinit'.
				static EntitlementCreateHandler()
				{
					Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, "EntitlementCreateHandler");
					StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr, 100668347);
					StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr, 100668348);
					StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr, 100668349);
					StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr, 100668350);
				}

				// Token: 0x0600270E RID: 9998 RVA: 0x000AEB40 File Offset: 0x000ACD40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EntitlementCreateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementCreateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600270F RID: 9999 RVA: 0x000AEB9C File Offset: 0x000ACD9C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ref Entitlement entitlement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002710 RID: 10000 RVA: 0x000AEBE8 File Offset: 0x000ACDE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55018, XrefRangeEnd = 55024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002711 RID: 10001 RVA: 0x000AEC68 File Offset: 0x000ACE68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Entitlement entitlement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &entitlement;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementCreateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002712 RID: 10002 RVA: 0x0000FA31 File Offset: 0x0000DC31
				public EntitlementCreateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C35 RID: 7221
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C36 RID: 7222
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0;

				// Token: 0x04001C37 RID: 7223
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0;

				// Token: 0x04001C38 RID: 7224
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0;
			}

			// Token: 0x020002FD RID: 765
			public sealed class EntitlementDeleteHandler : MulticastDelegate
			{
				// Token: 0x06002713 RID: 10003 RVA: 0x000AECB8 File Offset: 0x000ACEB8
				// Note: this type is marked as 'beforefieldinit'.
				static EntitlementDeleteHandler()
				{
					Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, "EntitlementDeleteHandler");
					StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr, 100668351);
					StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr, 100668352);
					StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr, 100668353);
					StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr, 100668354);
				}

				// Token: 0x06002714 RID: 10004 RVA: 0x000AED2C File Offset: 0x000ACF2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EntitlementDeleteHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIEvents.EntitlementDeleteHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002715 RID: 10005 RVA: 0x000AED88 File Offset: 0x000ACF88
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ref Entitlement entitlement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002716 RID: 10006 RVA: 0x000AEDD4 File Offset: 0x000ACFD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55024, XrefRangeEnd = 55030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002717 RID: 10007 RVA: 0x000AEE54 File Offset: 0x000AD054
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Entitlement entitlement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &entitlement;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIEvents.EntitlementDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002718 RID: 10008 RVA: 0x0000FA3A File Offset: 0x0000DC3A
				public EntitlementDeleteHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C39 RID: 7225
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C3A RID: 7226
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Entitlement_0;

				// Token: 0x04001C3B RID: 7227
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Entitlement_AsyncCallback_Object_0;

				// Token: 0x04001C3C RID: 7228
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0;
			}
		}

		// Token: 0x0200023D RID: 573
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x060020DF RID: 8415 RVA: 0x00096910 File Offset: 0x00094B10
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr);
				StoreManager.FFIMethods.NativeFieldInfoPtr_FetchSkus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchSkus");
				StoreManager.FFIMethods.NativeFieldInfoPtr_CountSkus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "CountSkus");
				StoreManager.FFIMethods.NativeFieldInfoPtr_GetSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetSku");
				StoreManager.FFIMethods.NativeFieldInfoPtr_GetSkuAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetSkuAt");
				StoreManager.FFIMethods.NativeFieldInfoPtr_FetchEntitlements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchEntitlements");
				StoreManager.FFIMethods.NativeFieldInfoPtr_CountEntitlements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "CountEntitlements");
				StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetEntitlement");
				StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlementAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetEntitlementAt");
				StoreManager.FFIMethods.NativeFieldInfoPtr_HasSkuEntitlement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "HasSkuEntitlement");
				StoreManager.FFIMethods.NativeFieldInfoPtr_StartPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "StartPurchase");
			}

			// Token: 0x060020E0 RID: 8416 RVA: 0x0000D9DF File Offset: 0x0000BBDF
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00096A04 File Offset: 0x00094C04
			// (set) Token: 0x060020E3 RID: 8419 RVA: 0x0000D9FA File Offset: 0x0000BBFA
			public unsafe StoreManager.FFIMethods.FetchSkusMethod FetchSkus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_FetchSkus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.FetchSkusMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_FetchSkus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00096A34 File Offset: 0x00094C34
			// (set) Token: 0x060020E5 RID: 8421 RVA: 0x0000DA19 File Offset: 0x0000BC19
			public unsafe StoreManager.FFIMethods.CountSkusMethod CountSkus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_CountSkus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.CountSkusMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_CountSkus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00096A64 File Offset: 0x00094C64
			// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0000DA38 File Offset: 0x0000BC38
			public unsafe StoreManager.FFIMethods.GetSkuMethod GetSku
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetSku);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.GetSkuMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetSku), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00096A94 File Offset: 0x00094C94
			// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0000DA57 File Offset: 0x0000BC57
			public unsafe StoreManager.FFIMethods.GetSkuAtMethod GetSkuAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetSkuAt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.GetSkuAtMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetSkuAt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060020EA RID: 8426 RVA: 0x00096AC4 File Offset: 0x00094CC4
			// (set) Token: 0x060020EB RID: 8427 RVA: 0x0000DA76 File Offset: 0x0000BC76
			public unsafe StoreManager.FFIMethods.FetchEntitlementsMethod FetchEntitlements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_FetchEntitlements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.FetchEntitlementsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_FetchEntitlements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060020EC RID: 8428 RVA: 0x00096AF4 File Offset: 0x00094CF4
			// (set) Token: 0x060020ED RID: 8429 RVA: 0x0000DA95 File Offset: 0x0000BC95
			public unsafe StoreManager.FFIMethods.CountEntitlementsMethod CountEntitlements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_CountEntitlements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.CountEntitlementsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_CountEntitlements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060020EE RID: 8430 RVA: 0x00096B24 File Offset: 0x00094D24
			// (set) Token: 0x060020EF RID: 8431 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
			public unsafe StoreManager.FFIMethods.GetEntitlementMethod GetEntitlement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.GetEntitlementMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00096B54 File Offset: 0x00094D54
			// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0000DAD3 File Offset: 0x0000BCD3
			public unsafe StoreManager.FFIMethods.GetEntitlementAtMethod GetEntitlementAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlementAt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.GetEntitlementAtMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_GetEntitlementAt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x060020F2 RID: 8434 RVA: 0x00096B84 File Offset: 0x00094D84
			// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0000DAF2 File Offset: 0x0000BCF2
			public unsafe StoreManager.FFIMethods.HasSkuEntitlementMethod HasSkuEntitlement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_HasSkuEntitlement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.HasSkuEntitlementMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_HasSkuEntitlement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00096BB4 File Offset: 0x00094DB4
			// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0000DB11 File Offset: 0x0000BD11
			public unsafe StoreManager.FFIMethods.StartPurchaseMethod StartPurchase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_StartPurchase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager.FFIMethods.StartPurchaseMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreManager.FFIMethods.NativeFieldInfoPtr_StartPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400193F RID: 6463
			private static readonly IntPtr NativeFieldInfoPtr_FetchSkus;

			// Token: 0x04001940 RID: 6464
			private static readonly IntPtr NativeFieldInfoPtr_CountSkus;

			// Token: 0x04001941 RID: 6465
			private static readonly IntPtr NativeFieldInfoPtr_GetSku;

			// Token: 0x04001942 RID: 6466
			private static readonly IntPtr NativeFieldInfoPtr_GetSkuAt;

			// Token: 0x04001943 RID: 6467
			private static readonly IntPtr NativeFieldInfoPtr_FetchEntitlements;

			// Token: 0x04001944 RID: 6468
			private static readonly IntPtr NativeFieldInfoPtr_CountEntitlements;

			// Token: 0x04001945 RID: 6469
			private static readonly IntPtr NativeFieldInfoPtr_GetEntitlement;

			// Token: 0x04001946 RID: 6470
			private static readonly IntPtr NativeFieldInfoPtr_GetEntitlementAt;

			// Token: 0x04001947 RID: 6471
			private static readonly IntPtr NativeFieldInfoPtr_HasSkuEntitlement;

			// Token: 0x04001948 RID: 6472
			private static readonly IntPtr NativeFieldInfoPtr_StartPurchase;

			// Token: 0x020002FE RID: 766
			public sealed class FetchSkusCallback : MulticastDelegate
			{
				// Token: 0x06002719 RID: 10009 RVA: 0x000AEEA4 File Offset: 0x000AD0A4
				// Note: this type is marked as 'beforefieldinit'.
				static FetchSkusCallback()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchSkusCallback");
					StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr, 100668355);
					StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr, 100668356);
					StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr, 100668357);
					StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr, 100668358);
				}

				// Token: 0x0600271A RID: 10010 RVA: 0x000AEF18 File Offset: 0x000AD118
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchSkusCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600271B RID: 10011 RVA: 0x000AEF74 File Offset: 0x000AD174
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600271C RID: 10012 RVA: 0x000AEFC4 File Offset: 0x000AD1C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55030, XrefRangeEnd = 55036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600271D RID: 10013 RVA: 0x000AF048 File Offset: 0x000AD248
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600271E RID: 10014 RVA: 0x0000FA43 File Offset: 0x0000DC43
				public FetchSkusCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600271F RID: 10015 RVA: 0x0000FA4C File Offset: 0x0000DC4C
				public static implicit operator StoreManager.FFIMethods.FetchSkusCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.FetchSkusCallback>(A_0);
				}

				// Token: 0x06002720 RID: 10016 RVA: 0x0000FA54 File Offset: 0x0000DC54
				public static StoreManager.FFIMethods.FetchSkusCallback operator +(StoreManager.FFIMethods.FetchSkusCallback A_0, StoreManager.FFIMethods.FetchSkusCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.FetchSkusCallback>();
				}

				// Token: 0x06002721 RID: 10017 RVA: 0x0000FA62 File Offset: 0x0000DC62
				public static StoreManager.FFIMethods.FetchSkusCallback operator -(StoreManager.FFIMethods.FetchSkusCallback A_0, StoreManager.FFIMethods.FetchSkusCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.FetchSkusCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C3D RID: 7229
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C3E RID: 7230
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001C3F RID: 7231
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001C40 RID: 7232
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002FF RID: 767
			public sealed class FetchSkusMethod : MulticastDelegate
			{
				// Token: 0x06002722 RID: 10018 RVA: 0x000AF08C File Offset: 0x000AD28C
				// Note: this type is marked as 'beforefieldinit'.
				static FetchSkusMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchSkusMethod");
					StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr, 100668359);
					StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchSkusCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr, 100668360);
					StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchSkusCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr, 100668361);
					StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr, 100668362);
				}

				// Token: 0x06002723 RID: 10019 RVA: 0x000AF100 File Offset: 0x000AD300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchSkusMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchSkusMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002724 RID: 10020 RVA: 0x000AF15C File Offset: 0x000AD35C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchSkusCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002725 RID: 10021 RVA: 0x000AF1BC File Offset: 0x000AD3BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchSkusCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002726 RID: 10022 RVA: 0x000AF250 File Offset: 0x000AD450
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchSkusMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002727 RID: 10023 RVA: 0x0000FA73 File Offset: 0x0000DC73
				public FetchSkusMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002728 RID: 10024 RVA: 0x0000FA7C File Offset: 0x0000DC7C
				public static implicit operator StoreManager.FFIMethods.FetchSkusMethod(Action<IntPtr, IntPtr, StoreManager.FFIMethods.FetchSkusCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.FetchSkusMethod>(A_0);
				}

				// Token: 0x06002729 RID: 10025 RVA: 0x0000FA84 File Offset: 0x0000DC84
				public static StoreManager.FFIMethods.FetchSkusMethod operator +(StoreManager.FFIMethods.FetchSkusMethod A_0, StoreManager.FFIMethods.FetchSkusMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.FetchSkusMethod>();
				}

				// Token: 0x0600272A RID: 10026 RVA: 0x0000FA92 File Offset: 0x0000DC92
				public static StoreManager.FFIMethods.FetchSkusMethod operator -(StoreManager.FFIMethods.FetchSkusMethod A_0, StoreManager.FFIMethods.FetchSkusMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.FetchSkusMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C41 RID: 7233
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C42 RID: 7234
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchSkusCallback_0;

				// Token: 0x04001C43 RID: 7235
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchSkusCallback_AsyncCallback_Object_0;

				// Token: 0x04001C44 RID: 7236
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000300 RID: 768
			public sealed class CountSkusMethod : MulticastDelegate
			{
				// Token: 0x0600272B RID: 10027 RVA: 0x000AF294 File Offset: 0x000AD494
				// Note: this type is marked as 'beforefieldinit'.
				static CountSkusMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "CountSkusMethod");
					StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr, 100668363);
					StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr, 100668364);
					StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr, 100668365);
					StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr, 100668366);
				}

				// Token: 0x0600272C RID: 10028 RVA: 0x000AF308 File Offset: 0x000AD508
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CountSkusMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.CountSkusMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600272D RID: 10029 RVA: 0x000AF364 File Offset: 0x000AD564
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600272E RID: 10030 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600272F RID: 10031 RVA: 0x000AF430 File Offset: 0x000AD630
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountSkusMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002730 RID: 10032 RVA: 0x0000FAA3 File Offset: 0x0000DCA3
				public CountSkusMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C45 RID: 7237
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C46 RID: 7238
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0;

				// Token: 0x04001C47 RID: 7239
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C48 RID: 7240
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x02000301 RID: 769
			public sealed class GetSkuMethod : MulticastDelegate
			{
				// Token: 0x06002731 RID: 10033 RVA: 0x000AF480 File Offset: 0x000AD680
				// Note: this type is marked as 'beforefieldinit'.
				static GetSkuMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetSkuMethod");
					StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr, 100668367);
					StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Sku_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr, 100668368);
					StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Sku_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr, 100668369);
					StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr, 100668370);
				}

				// Token: 0x06002732 RID: 10034 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetSkuMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002733 RID: 10035 RVA: 0x000AF550 File Offset: 0x000AD750
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long skuId, ref Sku sku)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Sku_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002734 RID: 10036 RVA: 0x000AF5D4 File Offset: 0x000AD7D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55036, XrefRangeEnd = 55044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref Sku sku, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Sku_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002735 RID: 10037 RVA: 0x000AF680 File Offset: 0x000AD880
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Sku sku, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002736 RID: 10038 RVA: 0x0000FAAC File Offset: 0x0000DCAC
				public GetSkuMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C49 RID: 7241
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C4A RID: 7242
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Sku_0;

				// Token: 0x04001C4B RID: 7243
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Sku_AsyncCallback_Object_0;

				// Token: 0x04001C4C RID: 7244
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0;
			}

			// Token: 0x02000302 RID: 770
			public sealed class GetSkuAtMethod : MulticastDelegate
			{
				// Token: 0x06002737 RID: 10039 RVA: 0x000AF6FC File Offset: 0x000AD8FC
				// Note: this type is marked as 'beforefieldinit'.
				static GetSkuAtMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetSkuAtMethod");
					StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr, 100668371);
					StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Sku_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr, 100668372);
					StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Sku_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr, 100668373);
					StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr, 100668374);
				}

				// Token: 0x06002738 RID: 10040 RVA: 0x000AF770 File Offset: 0x000AD970
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetSkuAtMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.GetSkuAtMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002739 RID: 10041 RVA: 0x000AF7CC File Offset: 0x000AD9CC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, int index, ref Sku sku)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Sku_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x0600273A RID: 10042 RVA: 0x000AF850 File Offset: 0x000ADA50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55044, XrefRangeEnd = 55052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Sku sku, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Sku_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x0600273B RID: 10043 RVA: 0x000AF8FC File Offset: 0x000ADAFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Sku sku, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(sku);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetSkuAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					sku = ((intPtr4 == 0) ? null : new Sku(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x0600273C RID: 10044 RVA: 0x0000FAB5 File Offset: 0x0000DCB5
				public GetSkuAtMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C4D RID: 7245
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C4E RID: 7246
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Sku_0;

				// Token: 0x04001C4F RID: 7247
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Sku_AsyncCallback_Object_0;

				// Token: 0x04001C50 RID: 7248
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Sku_IAsyncResult_0;
			}

			// Token: 0x02000303 RID: 771
			public sealed class FetchEntitlementsCallback : MulticastDelegate
			{
				// Token: 0x0600273D RID: 10045 RVA: 0x000AF978 File Offset: 0x000ADB78
				// Note: this type is marked as 'beforefieldinit'.
				static FetchEntitlementsCallback()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchEntitlementsCallback");
					StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr, 100668375);
					StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr, 100668376);
					StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr, 100668377);
					StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr, 100668378);
				}

				// Token: 0x0600273E RID: 10046 RVA: 0x000AF9EC File Offset: 0x000ADBEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchEntitlementsCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600273F RID: 10047 RVA: 0x000AFA48 File Offset: 0x000ADC48
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002740 RID: 10048 RVA: 0x000AFA98 File Offset: 0x000ADC98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55052, XrefRangeEnd = 55058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002741 RID: 10049 RVA: 0x000AFB1C File Offset: 0x000ADD1C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002742 RID: 10050 RVA: 0x0000FABE File Offset: 0x0000DCBE
				public FetchEntitlementsCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002743 RID: 10051 RVA: 0x0000FAC7 File Offset: 0x0000DCC7
				public static implicit operator StoreManager.FFIMethods.FetchEntitlementsCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.FetchEntitlementsCallback>(A_0);
				}

				// Token: 0x06002744 RID: 10052 RVA: 0x0000FACF File Offset: 0x0000DCCF
				public static StoreManager.FFIMethods.FetchEntitlementsCallback operator +(StoreManager.FFIMethods.FetchEntitlementsCallback A_0, StoreManager.FFIMethods.FetchEntitlementsCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.FetchEntitlementsCallback>();
				}

				// Token: 0x06002745 RID: 10053 RVA: 0x0000FADD File Offset: 0x0000DCDD
				public static StoreManager.FFIMethods.FetchEntitlementsCallback operator -(StoreManager.FFIMethods.FetchEntitlementsCallback A_0, StoreManager.FFIMethods.FetchEntitlementsCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.FetchEntitlementsCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C51 RID: 7249
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C52 RID: 7250
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001C53 RID: 7251
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001C54 RID: 7252
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000304 RID: 772
			public sealed class FetchEntitlementsMethod : MulticastDelegate
			{
				// Token: 0x06002746 RID: 10054 RVA: 0x000AFB60 File Offset: 0x000ADD60
				// Note: this type is marked as 'beforefieldinit'.
				static FetchEntitlementsMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "FetchEntitlementsMethod");
					StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr, 100668379);
					StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchEntitlementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr, 100668380);
					StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchEntitlementsCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr, 100668381);
					StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr, 100668382);
				}

				// Token: 0x06002747 RID: 10055 RVA: 0x000AFBD4 File Offset: 0x000ADDD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchEntitlementsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.FetchEntitlementsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002748 RID: 10056 RVA: 0x000AFC30 File Offset: 0x000ADE30
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchEntitlementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002749 RID: 10057 RVA: 0x000AFC90 File Offset: 0x000ADE90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchEntitlementsCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600274A RID: 10058 RVA: 0x000AFD24 File Offset: 0x000ADF24
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.FetchEntitlementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600274B RID: 10059 RVA: 0x0000FAEE File Offset: 0x0000DCEE
				public FetchEntitlementsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600274C RID: 10060 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
				public static implicit operator StoreManager.FFIMethods.FetchEntitlementsMethod(Action<IntPtr, IntPtr, StoreManager.FFIMethods.FetchEntitlementsCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.FetchEntitlementsMethod>(A_0);
				}

				// Token: 0x0600274D RID: 10061 RVA: 0x0000FAFF File Offset: 0x0000DCFF
				public static StoreManager.FFIMethods.FetchEntitlementsMethod operator +(StoreManager.FFIMethods.FetchEntitlementsMethod A_0, StoreManager.FFIMethods.FetchEntitlementsMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.FetchEntitlementsMethod>();
				}

				// Token: 0x0600274E RID: 10062 RVA: 0x0000FB0D File Offset: 0x0000DD0D
				public static StoreManager.FFIMethods.FetchEntitlementsMethod operator -(StoreManager.FFIMethods.FetchEntitlementsMethod A_0, StoreManager.FFIMethods.FetchEntitlementsMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.FetchEntitlementsMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C55 RID: 7253
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C56 RID: 7254
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchEntitlementsCallback_0;

				// Token: 0x04001C57 RID: 7255
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchEntitlementsCallback_AsyncCallback_Object_0;

				// Token: 0x04001C58 RID: 7256
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000305 RID: 773
			public sealed class CountEntitlementsMethod : MulticastDelegate
			{
				// Token: 0x0600274F RID: 10063 RVA: 0x000AFD68 File Offset: 0x000ADF68
				// Note: this type is marked as 'beforefieldinit'.
				static CountEntitlementsMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "CountEntitlementsMethod");
					StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr, 100668383);
					StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr, 100668384);
					StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr, 100668385);
					StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr, 100668386);
				}

				// Token: 0x06002750 RID: 10064 RVA: 0x000AFDDC File Offset: 0x000ADFDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CountEntitlementsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.CountEntitlementsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002751 RID: 10065 RVA: 0x000AFE38 File Offset: 0x000AE038
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002752 RID: 10066 RVA: 0x000AFE84 File Offset: 0x000AE084
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002753 RID: 10067 RVA: 0x000AFF04 File Offset: 0x000AE104
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.CountEntitlementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002754 RID: 10068 RVA: 0x0000FB1E File Offset: 0x0000DD1E
				public CountEntitlementsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C59 RID: 7257
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C5A RID: 7258
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0;

				// Token: 0x04001C5B RID: 7259
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C5C RID: 7260
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x02000306 RID: 774
			public sealed class GetEntitlementMethod : MulticastDelegate
			{
				// Token: 0x06002755 RID: 10069 RVA: 0x000AFF54 File Offset: 0x000AE154
				// Note: this type is marked as 'beforefieldinit'.
				static GetEntitlementMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetEntitlementMethod");
					StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr, 100668387);
					StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr, 100668388);
					StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr, 100668389);
					StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr, 100668390);
				}

				// Token: 0x06002756 RID: 10070 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetEntitlementMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002757 RID: 10071 RVA: 0x000B0024 File Offset: 0x000AE224
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entitlementId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002758 RID: 10072 RVA: 0x000B008C File Offset: 0x000AE28C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55058, XrefRangeEnd = 55066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entitlementId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002759 RID: 10073 RVA: 0x000B011C File Offset: 0x000AE31C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Entitlement entitlement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &entitlement;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600275A RID: 10074 RVA: 0x0000FB27 File Offset: 0x0000DD27
				public GetEntitlementMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C5D RID: 7261
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C5E RID: 7262
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Entitlement_0;

				// Token: 0x04001C5F RID: 7263
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Entitlement_AsyncCallback_Object_0;

				// Token: 0x04001C60 RID: 7264
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0;
			}

			// Token: 0x02000307 RID: 775
			public sealed class GetEntitlementAtMethod : MulticastDelegate
			{
				// Token: 0x0600275B RID: 10075 RVA: 0x000B017C File Offset: 0x000AE37C
				// Note: this type is marked as 'beforefieldinit'.
				static GetEntitlementAtMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "GetEntitlementAtMethod");
					StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr, 100668391);
					StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr, 100668392);
					StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr, 100668393);
					StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr, 100668394);
				}

				// Token: 0x0600275C RID: 10076 RVA: 0x000B01F0 File Offset: 0x000AE3F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetEntitlementAtMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.GetEntitlementAtMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600275D RID: 10077 RVA: 0x000B024C File Offset: 0x000AE44C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, int index, ref Entitlement entitlement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600275E RID: 10078 RVA: 0x000B02B4 File Offset: 0x000AE4B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55066, XrefRangeEnd = 55074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Entitlement entitlement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entitlement;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600275F RID: 10079 RVA: 0x000B0344 File Offset: 0x000AE544
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Entitlement entitlement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &entitlement;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.GetEntitlementAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002760 RID: 10080 RVA: 0x0000FB30 File Offset: 0x0000DD30
				public GetEntitlementAtMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C61 RID: 7265
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C62 RID: 7266
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Entitlement_0;

				// Token: 0x04001C63 RID: 7267
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Entitlement_AsyncCallback_Object_0;

				// Token: 0x04001C64 RID: 7268
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Entitlement_IAsyncResult_0;
			}

			// Token: 0x02000308 RID: 776
			public sealed class HasSkuEntitlementMethod : MulticastDelegate
			{
				// Token: 0x06002761 RID: 10081 RVA: 0x000B03A4 File Offset: 0x000AE5A4
				// Note: this type is marked as 'beforefieldinit'.
				static HasSkuEntitlementMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "HasSkuEntitlementMethod");
					StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr, 100668395);
					StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr, 100668396);
					StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr, 100668397);
					StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr, 100668398);
				}

				// Token: 0x06002762 RID: 10082 RVA: 0x000B0418 File Offset: 0x000AE618
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe HasSkuEntitlementMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.HasSkuEntitlementMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002763 RID: 10083 RVA: 0x000B0474 File Offset: 0x000AE674
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasEntitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002764 RID: 10084 RVA: 0x000B04DC File Offset: 0x000AE6DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55074, XrefRangeEnd = 55081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasEntitlement;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002765 RID: 10085 RVA: 0x000B056C File Offset: 0x000AE76C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool hasEntitlement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &hasEntitlement;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.HasSkuEntitlementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002766 RID: 10086 RVA: 0x0000FB39 File Offset: 0x0000DD39
				public HasSkuEntitlementMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C65 RID: 7269
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C66 RID: 7270
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0;

				// Token: 0x04001C67 RID: 7271
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C68 RID: 7272
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000309 RID: 777
			public sealed class StartPurchaseCallback : MulticastDelegate
			{
				// Token: 0x06002767 RID: 10087 RVA: 0x000B05CC File Offset: 0x000AE7CC
				// Note: this type is marked as 'beforefieldinit'.
				static StartPurchaseCallback()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "StartPurchaseCallback");
					StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr, 100668399);
					StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr, 100668400);
					StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr, 100668401);
					StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr, 100668402);
				}

				// Token: 0x06002768 RID: 10088 RVA: 0x000B0640 File Offset: 0x000AE840
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe StartPurchaseCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002769 RID: 10089 RVA: 0x000B069C File Offset: 0x000AE89C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600276A RID: 10090 RVA: 0x000B06EC File Offset: 0x000AE8EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55081, XrefRangeEnd = 55087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600276B RID: 10091 RVA: 0x000B0770 File Offset: 0x000AE970
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600276C RID: 10092 RVA: 0x0000FB42 File Offset: 0x0000DD42
				public StartPurchaseCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600276D RID: 10093 RVA: 0x0000FB4B File Offset: 0x0000DD4B
				public static implicit operator StoreManager.FFIMethods.StartPurchaseCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.StartPurchaseCallback>(A_0);
				}

				// Token: 0x0600276E RID: 10094 RVA: 0x0000FB53 File Offset: 0x0000DD53
				public static StoreManager.FFIMethods.StartPurchaseCallback operator +(StoreManager.FFIMethods.StartPurchaseCallback A_0, StoreManager.FFIMethods.StartPurchaseCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.StartPurchaseCallback>();
				}

				// Token: 0x0600276F RID: 10095 RVA: 0x0000FB61 File Offset: 0x0000DD61
				public static StoreManager.FFIMethods.StartPurchaseCallback operator -(StoreManager.FFIMethods.StartPurchaseCallback A_0, StoreManager.FFIMethods.StartPurchaseCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.StartPurchaseCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C69 RID: 7273
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C6A RID: 7274
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001C6B RID: 7275
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001C6C RID: 7276
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200030A RID: 778
			public sealed class StartPurchaseMethod : MulticastDelegate
			{
				// Token: 0x06002770 RID: 10096 RVA: 0x000B07B4 File Offset: 0x000AE9B4
				// Note: this type is marked as 'beforefieldinit'.
				static StartPurchaseMethod()
				{
					Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager.FFIMethods>.NativeClassPtr, "StartPurchaseMethod");
					StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr, 100668403);
					StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_StartPurchaseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr, 100668404);
					StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_StartPurchaseCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr, 100668405);
					StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr, 100668406);
				}

				// Token: 0x06002771 RID: 10097 RVA: 0x000B0828 File Offset: 0x000AEA28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe StartPurchaseMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FFIMethods.StartPurchaseMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002772 RID: 10098 RVA: 0x000B0884 File Offset: 0x000AEA84
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_StartPurchaseCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002773 RID: 10099 RVA: 0x000B08F4 File Offset: 0x000AEAF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skuId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_StartPurchaseCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002774 RID: 10100 RVA: 0x000B0998 File Offset: 0x000AEB98
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FFIMethods.StartPurchaseMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002775 RID: 10101 RVA: 0x0000FB72 File Offset: 0x0000DD72
				public StartPurchaseMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002776 RID: 10102 RVA: 0x0000FB7B File Offset: 0x0000DD7B
				public static implicit operator StoreManager.FFIMethods.StartPurchaseMethod(Action<IntPtr, long, IntPtr, StoreManager.FFIMethods.StartPurchaseCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StoreManager.FFIMethods.StartPurchaseMethod>(A_0);
				}

				// Token: 0x06002777 RID: 10103 RVA: 0x0000FB83 File Offset: 0x0000DD83
				public static StoreManager.FFIMethods.StartPurchaseMethod operator +(StoreManager.FFIMethods.StartPurchaseMethod A_0, StoreManager.FFIMethods.StartPurchaseMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StoreManager.FFIMethods.StartPurchaseMethod>();
				}

				// Token: 0x06002778 RID: 10104 RVA: 0x0000FB91 File Offset: 0x0000DD91
				public static StoreManager.FFIMethods.StartPurchaseMethod operator -(StoreManager.FFIMethods.StartPurchaseMethod A_0, StoreManager.FFIMethods.StartPurchaseMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StoreManager.FFIMethods.StartPurchaseMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C6D RID: 7277
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C6E RID: 7278
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_StartPurchaseCallback_0;

				// Token: 0x04001C6F RID: 7279
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_StartPurchaseCallback_AsyncCallback_Object_0;

				// Token: 0x04001C70 RID: 7280
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x0200023E RID: 574
		public sealed class FetchSkusHandler : MulticastDelegate
		{
			// Token: 0x060020F6 RID: 8438 RVA: 0x00096BE4 File Offset: 0x00094DE4
			// Note: this type is marked as 'beforefieldinit'.
			static FetchSkusHandler()
			{
				Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "FetchSkusHandler");
				StoreManager.FetchSkusHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr, 100668407);
				StoreManager.FetchSkusHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr, 100668408);
				StoreManager.FetchSkusHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr, 100668409);
				StoreManager.FetchSkusHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr, 100668410);
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x00096C58 File Offset: 0x00094E58
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FetchSkusHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FetchSkusHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchSkusHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x00096CB4 File Offset: 0x00094EB4
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchSkusHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x00096CF8 File Offset: 0x00094EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55087, XrefRangeEnd = 55091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchSkusHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060020FA RID: 8442 RVA: 0x00096D6C File Offset: 0x00094F6C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchSkusHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x0000DB30 File Offset: 0x0000BD30
			public FetchSkusHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020FC RID: 8444 RVA: 0x0000DB39 File Offset: 0x0000BD39
			public static implicit operator StoreManager.FetchSkusHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<StoreManager.FetchSkusHandler>(A_0);
			}

			// Token: 0x060020FD RID: 8445 RVA: 0x0000DB41 File Offset: 0x0000BD41
			public static StoreManager.FetchSkusHandler operator +(StoreManager.FetchSkusHandler A_0, StoreManager.FetchSkusHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StoreManager.FetchSkusHandler>();
			}

			// Token: 0x060020FE RID: 8446 RVA: 0x0000DB4F File Offset: 0x0000BD4F
			public static StoreManager.FetchSkusHandler operator -(StoreManager.FetchSkusHandler A_0, StoreManager.FetchSkusHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StoreManager.FetchSkusHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001949 RID: 6473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400194A RID: 6474
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400194B RID: 6475
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400194C RID: 6476
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023F RID: 575
		public sealed class FetchEntitlementsHandler : MulticastDelegate
		{
			// Token: 0x060020FF RID: 8447 RVA: 0x00096DB0 File Offset: 0x00094FB0
			// Note: this type is marked as 'beforefieldinit'.
			static FetchEntitlementsHandler()
			{
				Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "FetchEntitlementsHandler");
				StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr, 100668411);
				StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr, 100668412);
				StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr, 100668413);
				StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr, 100668414);
			}

			// Token: 0x06002100 RID: 8448 RVA: 0x00096E24 File Offset: 0x00095024
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FetchEntitlementsHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.FetchEntitlementsHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002101 RID: 8449 RVA: 0x00096E80 File Offset: 0x00095080
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002102 RID: 8450 RVA: 0x00096EC4 File Offset: 0x000950C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55091, XrefRangeEnd = 55095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002103 RID: 8451 RVA: 0x00096F38 File Offset: 0x00095138
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.FetchEntitlementsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002104 RID: 8452 RVA: 0x0000DB60 File Offset: 0x0000BD60
			public FetchEntitlementsHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002105 RID: 8453 RVA: 0x0000DB69 File Offset: 0x0000BD69
			public static implicit operator StoreManager.FetchEntitlementsHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<StoreManager.FetchEntitlementsHandler>(A_0);
			}

			// Token: 0x06002106 RID: 8454 RVA: 0x0000DB71 File Offset: 0x0000BD71
			public static StoreManager.FetchEntitlementsHandler operator +(StoreManager.FetchEntitlementsHandler A_0, StoreManager.FetchEntitlementsHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StoreManager.FetchEntitlementsHandler>();
			}

			// Token: 0x06002107 RID: 8455 RVA: 0x0000DB7F File Offset: 0x0000BD7F
			public static StoreManager.FetchEntitlementsHandler operator -(StoreManager.FetchEntitlementsHandler A_0, StoreManager.FetchEntitlementsHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StoreManager.FetchEntitlementsHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400194D RID: 6477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400194E RID: 6478
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400194F RID: 6479
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001950 RID: 6480
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000240 RID: 576
		public sealed class StartPurchaseHandler : MulticastDelegate
		{
			// Token: 0x06002108 RID: 8456 RVA: 0x00096F7C File Offset: 0x0009517C
			// Note: this type is marked as 'beforefieldinit'.
			static StartPurchaseHandler()
			{
				Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "StartPurchaseHandler");
				StoreManager.StartPurchaseHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr, 100668415);
				StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr, 100668416);
				StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr, 100668417);
				StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr, 100668418);
			}

			// Token: 0x06002109 RID: 8457 RVA: 0x00096FF0 File Offset: 0x000951F0
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartPurchaseHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.StartPurchaseHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.StartPurchaseHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600210A RID: 8458 RVA: 0x0009704C File Offset: 0x0009524C
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600210B RID: 8459 RVA: 0x00097090 File Offset: 0x00095290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55095, XrefRangeEnd = 55099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600210C RID: 8460 RVA: 0x00097104 File Offset: 0x00095304
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.StartPurchaseHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600210D RID: 8461 RVA: 0x0000DB90 File Offset: 0x0000BD90
			public StartPurchaseHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600210E RID: 8462 RVA: 0x0000DB99 File Offset: 0x0000BD99
			public static implicit operator StoreManager.StartPurchaseHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<StoreManager.StartPurchaseHandler>(A_0);
			}

			// Token: 0x0600210F RID: 8463 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
			public static StoreManager.StartPurchaseHandler operator +(StoreManager.StartPurchaseHandler A_0, StoreManager.StartPurchaseHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StoreManager.StartPurchaseHandler>();
			}

			// Token: 0x06002110 RID: 8464 RVA: 0x0000DBAF File Offset: 0x0000BDAF
			public static StoreManager.StartPurchaseHandler operator -(StoreManager.StartPurchaseHandler A_0, StoreManager.StartPurchaseHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StoreManager.StartPurchaseHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001951 RID: 6481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001952 RID: 6482
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x04001953 RID: 6483
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001954 RID: 6484
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000241 RID: 577
		public sealed class EntitlementCreateHandler : MulticastDelegate
		{
			// Token: 0x06002111 RID: 8465 RVA: 0x00097148 File Offset: 0x00095348
			// Note: this type is marked as 'beforefieldinit'.
			static EntitlementCreateHandler()
			{
				Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "EntitlementCreateHandler");
				StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr, 100668419);
				StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr, 100668420);
				StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr, 100668421);
				StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr, 100668422);
			}

			// Token: 0x06002112 RID: 8466 RVA: 0x000971BC File Offset: 0x000953BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntitlementCreateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.EntitlementCreateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x00097218 File Offset: 0x00095418
			[CallerCount(0)]
			public unsafe void Invoke(ref Entitlement entitlement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002114 RID: 8468 RVA: 0x00097258 File Offset: 0x00095458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55099, XrefRangeEnd = 55103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x000972C8 File Offset: 0x000954C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Entitlement entitlement, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementCreateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002116 RID: 8470 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
			public EntitlementCreateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001955 RID: 6485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001956 RID: 6486
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0;

			// Token: 0x04001957 RID: 6487
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0;

			// Token: 0x04001958 RID: 6488
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0;
		}

		// Token: 0x02000242 RID: 578
		public sealed class EntitlementDeleteHandler : MulticastDelegate
		{
			// Token: 0x06002117 RID: 8471 RVA: 0x00097318 File Offset: 0x00095518
			// Note: this type is marked as 'beforefieldinit'.
			static EntitlementDeleteHandler()
			{
				Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreManager>.NativeClassPtr, "EntitlementDeleteHandler");
				StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr, 100668423);
				StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr, 100668424);
				StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr, 100668425);
				StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr, 100668426);
			}

			// Token: 0x06002118 RID: 8472 RVA: 0x0009738C File Offset: 0x0009558C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntitlementDeleteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreManager.EntitlementDeleteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002119 RID: 8473 RVA: 0x000973E8 File Offset: 0x000955E8
			[CallerCount(0)]
			public unsafe void Invoke(ref Entitlement entitlement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600211A RID: 8474 RVA: 0x00097428 File Offset: 0x00095628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55103, XrefRangeEnd = 55107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600211B RID: 8475 RVA: 0x00097498 File Offset: 0x00095698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Entitlement entitlement, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &entitlement;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreManager.EntitlementDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600211C RID: 8476 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
			public EntitlementDeleteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001959 RID: 6489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400195A RID: 6490
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Entitlement_0;

			// Token: 0x0400195B RID: 6491
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Entitlement_AsyncCallback_Object_0;

			// Token: 0x0400195C RID: 6492
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Entitlement_IAsyncResult_0;
		}
	}
}
