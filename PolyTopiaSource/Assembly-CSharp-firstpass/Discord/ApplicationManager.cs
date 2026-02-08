using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Discord
{
	// Token: 0x0200015B RID: 347
	public class ApplicationManager : Object
	{
		// Token: 0x0600172D RID: 5933 RVA: 0x00074C00 File Offset: 0x00072E00
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationManager()
		{
			Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ApplicationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr);
			ApplicationManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "MethodsPtr");
			ApplicationManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "MethodsStructure");
			ApplicationManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667470);
			ApplicationManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667471);
			ApplicationManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667472);
			ApplicationManager.NativeMethodInfoPtr_ValidateOrExitCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667473);
			ApplicationManager.NativeMethodInfoPtr_ValidateOrExit_Public_Void_ValidateOrExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667474);
			ApplicationManager.NativeMethodInfoPtr_GetCurrentLocale_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667475);
			ApplicationManager.NativeMethodInfoPtr_GetCurrentBranch_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667476);
			ApplicationManager.NativeMethodInfoPtr_GetOAuth2TokenCallbackImpl_Private_Static_Void_IntPtr_Result_byref_OAuth2Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667477);
			ApplicationManager.NativeMethodInfoPtr_GetOAuth2Token_Public_Void_GetOAuth2TokenHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667478);
			ApplicationManager.NativeMethodInfoPtr_GetTicketCallbackImpl_Private_Static_Void_IntPtr_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667479);
			ApplicationManager.NativeMethodInfoPtr_GetTicket_Public_Void_GetTicketHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, 100667480);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00074D34 File Offset: 0x00072F34
		public unsafe ApplicationManager.FFIMethods Methods
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 52662, RefRangeEnd = 52667, XrefRangeStart = 52649, XrefRangeEnd = 52662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ApplicationManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00074D6C File Offset: 0x00072F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52667, XrefRangeEnd = 52674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &events;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00074DD0 File Offset: 0x00072FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52674, XrefRangeEnd = 52680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &events;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00074E1C File Offset: 0x0007301C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52680, XrefRangeEnd = 52687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_ValidateOrExitCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00074E60 File Offset: 0x00073060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52687, XrefRangeEnd = 52698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateOrExit(ApplicationManager.ValidateOrExitHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_ValidateOrExit_Public_Void_ValidateOrExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00074EA4 File Offset: 0x000730A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52698, XrefRangeEnd = 52704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCurrentLocale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetCurrentLocale_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00074EDC File Offset: 0x000730DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52704, XrefRangeEnd = 52710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCurrentBranch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetCurrentBranch_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00074F14 File Offset: 0x00073114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52710, XrefRangeEnd = 52717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetOAuth2TokenCallbackImpl_Private_Static_Void_IntPtr_Result_byref_OAuth2Token_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00074F80 File Offset: 0x00073180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52717, XrefRangeEnd = 52728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOAuth2Token(ApplicationManager.GetOAuth2TokenHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetOAuth2Token_Public_Void_GetOAuth2TokenHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00074FC4 File Offset: 0x000731C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52728, XrefRangeEnd = 52735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetTicketCallbackImpl_Private_Static_Void_IntPtr_Result_byref_String_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			data = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00075028 File Offset: 0x00073228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52735, XrefRangeEnd = 52746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTicket(ApplicationManager.GetTicketHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.NativeMethodInfoPtr_GetTicket_Public_Void_GetTicketHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00009579 File Offset: 0x00007779
		public ApplicationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x0007506C File Offset: 0x0007326C
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00009582 File Offset: 0x00007782
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00075094 File Offset: 0x00073294
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x0000959D File Offset: 0x0000779D
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOrExitCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOrExit_Public_Void_ValidateOrExitHandler_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentLocale_Public_String_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBranch_Public_String_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_GetOAuth2TokenCallbackImpl_Private_Static_Void_IntPtr_Result_byref_OAuth2Token_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_GetOAuth2Token_Public_Void_GetOAuth2TokenHandler_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketCallbackImpl_Private_Static_Void_IntPtr_Result_byref_String_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_GetTicket_Public_Void_GetTicketHandler_0;

		// Token: 0x02000204 RID: 516
		[StructLayout(2)]
		public struct FFIEvents
		{
			// Token: 0x06001E94 RID: 7828 RVA: 0x0000C4CD File Offset: 0x0000A6CD
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<ApplicationManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationManager.FFIEvents>.NativeClassPtr);
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x0000C4ED File Offset: 0x0000A6ED
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplicationManager.FFIEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000205 RID: 517
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001E96 RID: 7830 RVA: 0x0008FE64 File Offset: 0x0008E064
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr);
				ApplicationManager.FFIMethods.NativeFieldInfoPtr_ValidateOrExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "ValidateOrExit");
				ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetCurrentLocale");
				ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentBranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetCurrentBranch");
				ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetOAuth2Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetOAuth2Token");
				ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetTicket");
			}

			// Token: 0x06001E97 RID: 7831 RVA: 0x0000C4FF File Offset: 0x0000A6FF
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E98 RID: 7832 RVA: 0x0000C508 File Offset: 0x0000A708
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
			// (set) Token: 0x06001E9A RID: 7834 RVA: 0x0000C51A File Offset: 0x0000A71A
			public unsafe ApplicationManager.FFIMethods.ValidateOrExitMethod ValidateOrExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_ValidateOrExit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager.FFIMethods.ValidateOrExitMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_ValidateOrExit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0008FF24 File Offset: 0x0008E124
			// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0000C539 File Offset: 0x0000A739
			public unsafe ApplicationManager.FFIMethods.GetCurrentLocaleMethod GetCurrentLocale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentLocale);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0008FF54 File Offset: 0x0008E154
			// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0000C558 File Offset: 0x0000A758
			public unsafe ApplicationManager.FFIMethods.GetCurrentBranchMethod GetCurrentBranch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentBranch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager.FFIMethods.GetCurrentBranchMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetCurrentBranch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0008FF84 File Offset: 0x0008E184
			// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x0000C577 File Offset: 0x0000A777
			public unsafe ApplicationManager.FFIMethods.GetOAuth2TokenMethod GetOAuth2Token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetOAuth2Token);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetOAuth2Token), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0008FFB4 File Offset: 0x0008E1B4
			// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x0000C596 File Offset: 0x0000A796
			public unsafe ApplicationManager.FFIMethods.GetTicketMethod GetTicket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetTicket);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager.FFIMethods.GetTicketMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationManager.FFIMethods.NativeFieldInfoPtr_GetTicket), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeFieldInfoPtr_ValidateOrExit;

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeFieldInfoPtr_GetCurrentLocale;

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeFieldInfoPtr_GetCurrentBranch;

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr_GetOAuth2Token;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr_GetTicket;

			// Token: 0x0200027D RID: 637
			public sealed class ValidateOrExitCallback : MulticastDelegate
			{
				// Token: 0x06002305 RID: 8965 RVA: 0x0009DCEC File Offset: 0x0009BEEC
				// Note: this type is marked as 'beforefieldinit'.
				static ValidateOrExitCallback()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "ValidateOrExitCallback");
					ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr, 100667481);
					ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr, 100667482);
					ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr, 100667483);
					ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr, 100667484);
				}

				// Token: 0x06002306 RID: 8966 RVA: 0x0009DD60 File Offset: 0x0009BF60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ValidateOrExitCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002307 RID: 8967 RVA: 0x0009DDBC File Offset: 0x0009BFBC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002308 RID: 8968 RVA: 0x0009DE0C File Offset: 0x0009C00C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52613, XrefRangeEnd = 52619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002309 RID: 8969 RVA: 0x0009DE90 File Offset: 0x0009C090
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600230A RID: 8970 RVA: 0x0000E804 File Offset: 0x0000CA04
				public ValidateOrExitCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600230B RID: 8971 RVA: 0x0000E80D File Offset: 0x0000CA0D
				public static implicit operator ApplicationManager.FFIMethods.ValidateOrExitCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.ValidateOrExitCallback>(A_0);
				}

				// Token: 0x0600230C RID: 8972 RVA: 0x0000E815 File Offset: 0x0000CA15
				public static ApplicationManager.FFIMethods.ValidateOrExitCallback operator +(ApplicationManager.FFIMethods.ValidateOrExitCallback A_0, ApplicationManager.FFIMethods.ValidateOrExitCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.ValidateOrExitCallback>();
				}

				// Token: 0x0600230D RID: 8973 RVA: 0x0000E823 File Offset: 0x0000CA23
				public static ApplicationManager.FFIMethods.ValidateOrExitCallback operator -(ApplicationManager.FFIMethods.ValidateOrExitCallback A_0, ApplicationManager.FFIMethods.ValidateOrExitCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.ValidateOrExitCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001A39 RID: 6713
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A3A RID: 6714
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001A3B RID: 6715
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001A3C RID: 6716
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200027E RID: 638
			public sealed class ValidateOrExitMethod : MulticastDelegate
			{
				// Token: 0x0600230E RID: 8974 RVA: 0x0009DED4 File Offset: 0x0009C0D4
				// Note: this type is marked as 'beforefieldinit'.
				static ValidateOrExitMethod()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "ValidateOrExitMethod");
					ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr, 100667485);
					ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ValidateOrExitCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr, 100667486);
					ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ValidateOrExitCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr, 100667487);
					ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr, 100667488);
				}

				// Token: 0x0600230F RID: 8975 RVA: 0x0009DF48 File Offset: 0x0009C148
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ValidateOrExitMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.ValidateOrExitMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002310 RID: 8976 RVA: 0x0009DFA4 File Offset: 0x0009C1A4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ValidateOrExitCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002311 RID: 8977 RVA: 0x0009E004 File Offset: 0x0009C204
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ValidateOrExitCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002312 RID: 8978 RVA: 0x0009E098 File Offset: 0x0009C298
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.ValidateOrExitMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002313 RID: 8979 RVA: 0x0000E834 File Offset: 0x0000CA34
				public ValidateOrExitMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002314 RID: 8980 RVA: 0x0000E83D File Offset: 0x0000CA3D
				public static implicit operator ApplicationManager.FFIMethods.ValidateOrExitMethod(Action<IntPtr, IntPtr, ApplicationManager.FFIMethods.ValidateOrExitCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.ValidateOrExitMethod>(A_0);
				}

				// Token: 0x06002315 RID: 8981 RVA: 0x0000E845 File Offset: 0x0000CA45
				public static ApplicationManager.FFIMethods.ValidateOrExitMethod operator +(ApplicationManager.FFIMethods.ValidateOrExitMethod A_0, ApplicationManager.FFIMethods.ValidateOrExitMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.ValidateOrExitMethod>();
				}

				// Token: 0x06002316 RID: 8982 RVA: 0x0000E853 File Offset: 0x0000CA53
				public static ApplicationManager.FFIMethods.ValidateOrExitMethod operator -(ApplicationManager.FFIMethods.ValidateOrExitMethod A_0, ApplicationManager.FFIMethods.ValidateOrExitMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.ValidateOrExitMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A3D RID: 6717
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A3E RID: 6718
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ValidateOrExitCallback_0;

				// Token: 0x04001A3F RID: 6719
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ValidateOrExitCallback_AsyncCallback_Object_0;

				// Token: 0x04001A40 RID: 6720
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200027F RID: 639
			public sealed class GetCurrentLocaleMethod : MulticastDelegate
			{
				// Token: 0x06002317 RID: 8983 RVA: 0x0009E0DC File Offset: 0x0009C2DC
				// Note: this type is marked as 'beforefieldinit'.
				static GetCurrentLocaleMethod()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetCurrentLocaleMethod");
					ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr, 100667489);
					ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr, 100667490);
					ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr, 100667491);
					ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr, 100667492);
				}

				// Token: 0x06002318 RID: 8984 RVA: 0x0009E150 File Offset: 0x0009C350
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetCurrentLocaleMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002319 RID: 8985 RVA: 0x0009E1AC File Offset: 0x0009C3AC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, StringBuilder locale)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600231A RID: 8986 RVA: 0x0009E1FC File Offset: 0x0009C3FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder locale, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600231B RID: 8987 RVA: 0x0009E280 File Offset: 0x0009C480
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentLocaleMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600231C RID: 8988 RVA: 0x0000E864 File Offset: 0x0000CA64
				public GetCurrentLocaleMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600231D RID: 8989 RVA: 0x0000E86D File Offset: 0x0000CA6D
				public static implicit operator ApplicationManager.FFIMethods.GetCurrentLocaleMethod(Action<IntPtr, StringBuilder> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>(A_0);
				}

				// Token: 0x0600231E RID: 8990 RVA: 0x0000E875 File Offset: 0x0000CA75
				public static ApplicationManager.FFIMethods.GetCurrentLocaleMethod operator +(ApplicationManager.FFIMethods.GetCurrentLocaleMethod A_0, ApplicationManager.FFIMethods.GetCurrentLocaleMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>();
				}

				// Token: 0x0600231F RID: 8991 RVA: 0x0000E883 File Offset: 0x0000CA83
				public static ApplicationManager.FFIMethods.GetCurrentLocaleMethod operator -(ApplicationManager.FFIMethods.GetCurrentLocaleMethod A_0, ApplicationManager.FFIMethods.GetCurrentLocaleMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.GetCurrentLocaleMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A41 RID: 6721
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A42 RID: 6722
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0;

				// Token: 0x04001A43 RID: 6723
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001A44 RID: 6724
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000280 RID: 640
			public sealed class GetCurrentBranchMethod : MulticastDelegate
			{
				// Token: 0x06002320 RID: 8992 RVA: 0x0009E2C4 File Offset: 0x0009C4C4
				// Note: this type is marked as 'beforefieldinit'.
				static GetCurrentBranchMethod()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetCurrentBranchMethod");
					ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr, 100667493);
					ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr, 100667494);
					ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr, 100667495);
					ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr, 100667496);
				}

				// Token: 0x06002321 RID: 8993 RVA: 0x0009E338 File Offset: 0x0009C538
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetCurrentBranchMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetCurrentBranchMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002322 RID: 8994 RVA: 0x0009E394 File Offset: 0x0009C594
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, StringBuilder branch)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(branch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002323 RID: 8995 RVA: 0x0009E3E4 File Offset: 0x0009C5E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder branch, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(branch);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002324 RID: 8996 RVA: 0x0009E468 File Offset: 0x0009C668
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetCurrentBranchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002325 RID: 8997 RVA: 0x0000E894 File Offset: 0x0000CA94
				public GetCurrentBranchMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002326 RID: 8998 RVA: 0x0000E89D File Offset: 0x0000CA9D
				public static implicit operator ApplicationManager.FFIMethods.GetCurrentBranchMethod(Action<IntPtr, StringBuilder> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.GetCurrentBranchMethod>(A_0);
				}

				// Token: 0x06002327 RID: 8999 RVA: 0x0000E8A5 File Offset: 0x0000CAA5
				public static ApplicationManager.FFIMethods.GetCurrentBranchMethod operator +(ApplicationManager.FFIMethods.GetCurrentBranchMethod A_0, ApplicationManager.FFIMethods.GetCurrentBranchMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.GetCurrentBranchMethod>();
				}

				// Token: 0x06002328 RID: 9000 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
				public static ApplicationManager.FFIMethods.GetCurrentBranchMethod operator -(ApplicationManager.FFIMethods.GetCurrentBranchMethod A_0, ApplicationManager.FFIMethods.GetCurrentBranchMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.GetCurrentBranchMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A45 RID: 6725
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A46 RID: 6726
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_StringBuilder_0;

				// Token: 0x04001A47 RID: 6727
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001A48 RID: 6728
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000281 RID: 641
			public sealed class GetOAuth2TokenCallback : MulticastDelegate
			{
				// Token: 0x06002329 RID: 9001 RVA: 0x0009E4AC File Offset: 0x0009C6AC
				// Note: this type is marked as 'beforefieldinit'.
				static GetOAuth2TokenCallback()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetOAuth2TokenCallback");
					ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr, 100667497);
					ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_OAuth2Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr, 100667498);
					ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_OAuth2Token_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr, 100667499);
					ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr, 100667500);
				}

				// Token: 0x0600232A RID: 9002 RVA: 0x0009E520 File Offset: 0x0009C720
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetOAuth2TokenCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600232B RID: 9003 RVA: 0x0009E57C File Offset: 0x0009C77C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_OAuth2Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
				}

				// Token: 0x0600232C RID: 9004 RVA: 0x0009E5F4 File Offset: 0x0009C7F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52619, XrefRangeEnd = 52628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_OAuth2Token_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x0600232D RID: 9005 RVA: 0x0009E6A4 File Offset: 0x0009C8A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
				}

				// Token: 0x0600232E RID: 9006 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
				public GetOAuth2TokenCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A49 RID: 6729
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A4A RID: 6730
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_OAuth2Token_0;

				// Token: 0x04001A4B RID: 6731
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_OAuth2Token_AsyncCallback_Object_0;

				// Token: 0x04001A4C RID: 6732
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0;
			}

			// Token: 0x02000282 RID: 642
			public sealed class GetOAuth2TokenMethod : MulticastDelegate
			{
				// Token: 0x0600232F RID: 9007 RVA: 0x0009E710 File Offset: 0x0009C910
				// Note: this type is marked as 'beforefieldinit'.
				static GetOAuth2TokenMethod()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetOAuth2TokenMethod");
					ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr, 100667501);
					ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetOAuth2TokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr, 100667502);
					ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetOAuth2TokenCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr, 100667503);
					ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr, 100667504);
				}

				// Token: 0x06002330 RID: 9008 RVA: 0x0009E784 File Offset: 0x0009C984
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetOAuth2TokenMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002331 RID: 9009 RVA: 0x0009E7E0 File Offset: 0x0009C9E0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetOAuth2TokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002332 RID: 9010 RVA: 0x0009E840 File Offset: 0x0009CA40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetOAuth2TokenCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002333 RID: 9011 RVA: 0x0009E8D4 File Offset: 0x0009CAD4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetOAuth2TokenMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002334 RID: 9012 RVA: 0x0000E8CD File Offset: 0x0000CACD
				public GetOAuth2TokenMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002335 RID: 9013 RVA: 0x0000E8D6 File Offset: 0x0000CAD6
				public static implicit operator ApplicationManager.FFIMethods.GetOAuth2TokenMethod(Action<IntPtr, IntPtr, ApplicationManager.FFIMethods.GetOAuth2TokenCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>(A_0);
				}

				// Token: 0x06002336 RID: 9014 RVA: 0x0000E8DE File Offset: 0x0000CADE
				public static ApplicationManager.FFIMethods.GetOAuth2TokenMethod operator +(ApplicationManager.FFIMethods.GetOAuth2TokenMethod A_0, ApplicationManager.FFIMethods.GetOAuth2TokenMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>();
				}

				// Token: 0x06002337 RID: 9015 RVA: 0x0000E8EC File Offset: 0x0000CAEC
				public static ApplicationManager.FFIMethods.GetOAuth2TokenMethod operator -(ApplicationManager.FFIMethods.GetOAuth2TokenMethod A_0, ApplicationManager.FFIMethods.GetOAuth2TokenMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.GetOAuth2TokenMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A4D RID: 6733
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A4E RID: 6734
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetOAuth2TokenCallback_0;

				// Token: 0x04001A4F RID: 6735
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetOAuth2TokenCallback_AsyncCallback_Object_0;

				// Token: 0x04001A50 RID: 6736
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000283 RID: 643
			public sealed class GetTicketCallback : MulticastDelegate
			{
				// Token: 0x06002338 RID: 9016 RVA: 0x0009E918 File Offset: 0x0009CB18
				// Note: this type is marked as 'beforefieldinit'.
				static GetTicketCallback()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetTicketCallback");
					ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr, 100667505);
					ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr, 100667506);
					ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr, 100667507);
					ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr, 100667508);
				}

				// Token: 0x06002339 RID: 9017 RVA: 0x0009E98C File Offset: 0x0009CB8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetTicketCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600233A RID: 9018 RVA: 0x0009E9E8 File Offset: 0x0009CBE8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref string data)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					data = IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0600233B RID: 9019 RVA: 0x0009EA58 File Offset: 0x0009CC58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52628, XrefRangeEnd = 52634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref string data, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					data = IL2CPP.Il2CppStringToManaged(intPtr);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
				}

				// Token: 0x0600233C RID: 9020 RVA: 0x0009EB00 File Offset: 0x0009CD00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref string data, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					data = IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0600233D RID: 9021 RVA: 0x0000E8FD File Offset: 0x0000CAFD
				public GetTicketCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A51 RID: 6737
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A52 RID: 6738
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_String_0;

				// Token: 0x04001A53 RID: 6739
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_String_AsyncCallback_Object_0;

				// Token: 0x04001A54 RID: 6740
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0;
			}

			// Token: 0x02000284 RID: 644
			public sealed class GetTicketMethod : MulticastDelegate
			{
				// Token: 0x0600233E RID: 9022 RVA: 0x0009EB64 File Offset: 0x0009CD64
				// Note: this type is marked as 'beforefieldinit'.
				static GetTicketMethod()
				{
					Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager.FFIMethods>.NativeClassPtr, "GetTicketMethod");
					ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr, 100667509);
					ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetTicketCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr, 100667510);
					ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetTicketCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr, 100667511);
					ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr, 100667512);
				}

				// Token: 0x0600233F RID: 9023 RVA: 0x0009EBD8 File Offset: 0x0009CDD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetTicketMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.FFIMethods.GetTicketMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002340 RID: 9024 RVA: 0x0009EC34 File Offset: 0x0009CE34
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetTicketCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002341 RID: 9025 RVA: 0x0009EC94 File Offset: 0x0009CE94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetTicketCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002342 RID: 9026 RVA: 0x0009ED28 File Offset: 0x0009CF28
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.FFIMethods.GetTicketMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002343 RID: 9027 RVA: 0x0000E906 File Offset: 0x0000CB06
				public GetTicketMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002344 RID: 9028 RVA: 0x0000E90F File Offset: 0x0000CB0F
				public static implicit operator ApplicationManager.FFIMethods.GetTicketMethod(Action<IntPtr, IntPtr, ApplicationManager.FFIMethods.GetTicketCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ApplicationManager.FFIMethods.GetTicketMethod>(A_0);
				}

				// Token: 0x06002345 RID: 9029 RVA: 0x0000E917 File Offset: 0x0000CB17
				public static ApplicationManager.FFIMethods.GetTicketMethod operator +(ApplicationManager.FFIMethods.GetTicketMethod A_0, ApplicationManager.FFIMethods.GetTicketMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.FFIMethods.GetTicketMethod>();
				}

				// Token: 0x06002346 RID: 9030 RVA: 0x0000E925 File Offset: 0x0000CB25
				public static ApplicationManager.FFIMethods.GetTicketMethod operator -(ApplicationManager.FFIMethods.GetTicketMethod A_0, ApplicationManager.FFIMethods.GetTicketMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ApplicationManager.FFIMethods.GetTicketMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A55 RID: 6741
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A56 RID: 6742
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_GetTicketCallback_0;

				// Token: 0x04001A57 RID: 6743
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_GetTicketCallback_AsyncCallback_Object_0;

				// Token: 0x04001A58 RID: 6744
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x02000206 RID: 518
		public sealed class ValidateOrExitHandler : MulticastDelegate
		{
			// Token: 0x06001EA3 RID: 7843 RVA: 0x0008FFE4 File Offset: 0x0008E1E4
			// Note: this type is marked as 'beforefieldinit'.
			static ValidateOrExitHandler()
			{
				Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "ValidateOrExitHandler");
				ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr, 100667513);
				ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr, 100667514);
				ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr, 100667515);
				ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr, 100667516);
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x00090058 File Offset: 0x0008E258
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidateOrExitHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.ValidateOrExitHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x000900B4 File Offset: 0x0008E2B4
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x000900F8 File Offset: 0x0008E2F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52634, XrefRangeEnd = 52638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x0009016C File Offset: 0x0008E36C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.ValidateOrExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0000C5B5 File Offset: 0x0000A7B5
			public ValidateOrExitHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0000C5BE File Offset: 0x0000A7BE
			public static implicit operator ApplicationManager.ValidateOrExitHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ApplicationManager.ValidateOrExitHandler>(A_0);
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x0000C5C6 File Offset: 0x0000A7C6
			public static ApplicationManager.ValidateOrExitHandler operator +(ApplicationManager.ValidateOrExitHandler A_0, ApplicationManager.ValidateOrExitHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ApplicationManager.ValidateOrExitHandler>();
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
			public static ApplicationManager.ValidateOrExitHandler operator -(ApplicationManager.ValidateOrExitHandler A_0, ApplicationManager.ValidateOrExitHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ApplicationManager.ValidateOrExitHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000207 RID: 519
		public sealed class GetOAuth2TokenHandler : MulticastDelegate
		{
			// Token: 0x06001EAC RID: 7852 RVA: 0x000901B0 File Offset: 0x0008E3B0
			// Note: this type is marked as 'beforefieldinit'.
			static GetOAuth2TokenHandler()
			{
				Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "GetOAuth2TokenHandler");
				ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr, 100667517);
				ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_OAuth2Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr, 100667518);
				ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_OAuth2Token_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr, 100667519);
				ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr, 100667520);
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x00090224 File Offset: 0x0008E424
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetOAuth2TokenHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.GetOAuth2TokenHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x00090280 File Offset: 0x0008E480
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref OAuth2Token oauth2Token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_OAuth2Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
			}

			// Token: 0x06001EAF RID: 7855 RVA: 0x000902EC File Offset: 0x0008E4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52638, XrefRangeEnd = 52645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_OAuth2Token_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001EB0 RID: 7856 RVA: 0x0009038C File Offset: 0x0008E58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(oauth2Token);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetOAuth2TokenHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oauth2Token = ((intPtr4 == 0) ? null : new OAuth2Token(intPtr4));
			}

			// Token: 0x06001EB1 RID: 7857 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
			public GetOAuth2TokenHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_OAuth2Token_0;

			// Token: 0x04001843 RID: 6211
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_OAuth2Token_AsyncCallback_Object_0;

			// Token: 0x04001844 RID: 6212
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OAuth2Token_IAsyncResult_0;
		}

		// Token: 0x02000208 RID: 520
		public sealed class GetTicketHandler : MulticastDelegate
		{
			// Token: 0x06001EB2 RID: 7858 RVA: 0x000903F8 File Offset: 0x0008E5F8
			// Note: this type is marked as 'beforefieldinit'.
			static GetTicketHandler()
			{
				Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplicationManager>.NativeClassPtr, "GetTicketHandler");
				ApplicationManager.GetTicketHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr, 100667521);
				ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr, 100667522);
				ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr, 100667523);
				ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr, 100667524);
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x0009046C File Offset: 0x0008E66C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetTicketHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationManager.GetTicketHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetTicketHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EB4 RID: 7860 RVA: 0x000904C8 File Offset: 0x0008E6C8
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref string data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				data = IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x0009052C File Offset: 0x0008E72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52645, XrefRangeEnd = 52649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref string data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				data = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x000905C4 File Offset: 0x0008E7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref string data, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.ManagedStringToIl2Cpp(data);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ApplicationManager.GetTicketHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				data = IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001EB7 RID: 7863 RVA: 0x0000C5EE File Offset: 0x0000A7EE
			public GetTicketHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001845 RID: 6213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001846 RID: 6214
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_String_0;

			// Token: 0x04001847 RID: 6215
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_String_AsyncCallback_Object_0;

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_IAsyncResult_0;
		}
	}
}
