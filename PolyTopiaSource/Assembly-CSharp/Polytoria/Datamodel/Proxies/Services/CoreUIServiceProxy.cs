using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030B RID: 779
	public class CoreUIServiceProxy : Object
	{
		// Token: 0x06004365 RID: 17253 RVA: 0x0012E97C File Offset: 0x0012CB7C
		// Note: this type is marked as 'beforefieldinit'.
		static CoreUIServiceProxy()
		{
			Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "CoreUIServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr);
			CoreUIServiceProxy.NativeFieldInfoPtr_coreUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, "coreUI");
			CoreUIServiceProxy.NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673966);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673967);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673968);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673969);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673970);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673971);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673972);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673973);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673974);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673975);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673976);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673977);
			CoreUIServiceProxy.NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673978);
			CoreUIServiceProxy.NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673979);
			CoreUIServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_CoreUIService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr, 100673965);
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x0012EAEC File Offset: 0x0012CCEC
		// (set) Token: 0x06004367 RID: 17255 RVA: 0x0012EB28 File Offset: 0x0012CD28
		public unsafe bool UserCardEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129190, XrefRangeEnd = 129192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129192, XrefRangeEnd = 129194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x0012EB68 File Offset: 0x0012CD68
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x0012EBA4 File Offset: 0x0012CDA4
		public unsafe bool ChatEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129194, XrefRangeEnd = 129196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129196, XrefRangeEnd = 129198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x0012EBE4 File Offset: 0x0012CDE4
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x0012EC20 File Offset: 0x0012CE20
		public unsafe bool HealthBarEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129198, XrefRangeEnd = 129200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129200, XrefRangeEnd = 129202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x0012EC60 File Offset: 0x0012CE60
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x0012EC9C File Offset: 0x0012CE9C
		public unsafe bool LeaderboardEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129202, XrefRangeEnd = 129204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129204, XrefRangeEnd = 129206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x0012ECDC File Offset: 0x0012CEDC
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x0012ED18 File Offset: 0x0012CF18
		public unsafe bool HotbarEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129206, XrefRangeEnd = 129208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129208, XrefRangeEnd = 129210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x0012ED58 File Offset: 0x0012CF58
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x0012ED94 File Offset: 0x0012CF94
		public unsafe bool MenuButtonEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129210, XrefRangeEnd = 129212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129212, XrefRangeEnd = 129214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x0012EDD4 File Offset: 0x0012CFD4
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x0012EE10 File Offset: 0x0012D010
		public unsafe bool CanRespawn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129214, XrefRangeEnd = 129216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129216, XrefRangeEnd = 129218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x0012EE50 File Offset: 0x0012D050
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreUIServiceProxy(CoreUIService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreUIServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_CoreUIService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00018DF9 File Offset: 0x00016FF9
		public CoreUIServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x0012EE9C File Offset: 0x0012D09C
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x00018E02 File Offset: 0x00017002
		public unsafe CoreUIService coreUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIServiceProxy.NativeFieldInfoPtr_coreUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoreUIService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIServiceProxy.NativeFieldInfoPtr_coreUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeFieldInfoPtr_coreUI;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0;

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04003490 RID: 13456
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0;

		// Token: 0x04003491 RID: 13457
		private static readonly IntPtr NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0;

		// Token: 0x04003492 RID: 13458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CoreUIService_0;
	}
}
