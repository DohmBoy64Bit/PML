using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200032E RID: 814
	public class LaunchController : MonoBehaviour
	{
		// Token: 0x060045B7 RID: 17847 RVA: 0x00137860 File Offset: 0x00135A60
		// Note: this type is marked as 'beforefieldinit'.
		static LaunchController()
		{
			Il2CppClassPointerStore<LaunchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "LaunchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunchController>.NativeClassPtr);
			LaunchController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "singleton");
			LaunchController.NativeFieldInfoPtr_launchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "launchType");
			LaunchController.NativeFieldInfoPtr_clientToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "clientToken");
			LaunchController.NativeFieldInfoPtr_serverToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "serverToken");
			LaunchController.NativeFieldInfoPtr_isSolo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "isSolo");
			LaunchController.NativeFieldInfoPtr_soloMapPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "soloMapPath");
			LaunchController.NativeFieldInfoPtr_soloUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "soloUserName");
			LaunchController.NativeFieldInfoPtr_soloUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "soloUserID");
			LaunchController.NativeFieldInfoPtr_soloID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "soloID");
			LaunchController.NativeFieldInfoPtr_isLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "isLocal");
			LaunchController.NativeFieldInfoPtr_localGameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "localGameId");
			LaunchController.NativeFieldInfoPtr_localUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "localUserId");
			LaunchController.NativeFieldInfoPtr_localMapPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "localMapPath");
			LaunchController.NativeFieldInfoPtr_editorLaunchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "editorLaunchType");
			LaunchController.NativeFieldInfoPtr_testToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "testToken");
			LaunchController.NativeFieldInfoPtr_doPlaySolo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "doPlaySolo");
			LaunchController.NativeFieldInfoPtr_playSoloTestMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "playSoloTestMap");
			LaunchController.NativeFieldInfoPtr_playSoloTestUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "playSoloTestUserName");
			LaunchController.NativeFieldInfoPtr_playSoloTestUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "playSoloTestUserID");
			LaunchController.NativeFieldInfoPtr_doLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "doLocal");
			LaunchController.NativeFieldInfoPtr_testLocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "testLocalUserId");
			LaunchController.NativeFieldInfoPtr_testLocalGameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "testLocalGameId");
			LaunchController.NativeFieldInfoPtr_testLocalMapPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "testLocalMapPath");
			LaunchController.NativeFieldInfoPtr_testMobileLaunchURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, "testMobileLaunchURI");
			LaunchController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674367);
			LaunchController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674362);
			LaunchController.NativeMethodInfoPtr_LaunchAs_Public_Void_NetworkType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674363);
			LaunchController.NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674364);
			LaunchController.NativeMethodInfoPtr_OnDeepLinkActivated_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674365);
			LaunchController.NativeMethodInfoPtr_GetActiveToken_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchController>.NativeClassPtr, 100674366);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00137AE8 File Offset: 0x00135CE8
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunchController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunchController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00137B24 File Offset: 0x00135D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134888, XrefRangeEnd = 135109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00137B58 File Offset: 0x00135D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135109, XrefRangeEnd = 135125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LaunchAs(NetworkType netType, string token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(netType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr_LaunchAs_Public_Void_NetworkType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00137BAC File Offset: 0x00135DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135125, XrefRangeEnd = 135141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> GetCommandLineArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00137BEC File Offset: 0x00135DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135177, RefRangeEnd = 135178, XrefRangeStart = 135141, XrefRangeEnd = 135177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeepLinkActivated(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr_OnDeepLinkActivated_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00137C30 File Offset: 0x00135E30
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 135197, RefRangeEnd = 135231, XrefRangeStart = 135178, XrefRangeEnd = 135197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetActiveToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchController.NativeMethodInfoPtr_GetActiveToken_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00019B91 File Offset: 0x00017D91
		public LaunchController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x00137C5C File Offset: 0x00135E5C
		// (set) Token: 0x060045C0 RID: 17856 RVA: 0x00019B9A File Offset: 0x00017D9A
		public unsafe static LaunchController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunchController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x00137C84 File Offset: 0x00135E84
		// (set) Token: 0x060045C2 RID: 17858 RVA: 0x00019BAC File Offset: 0x00017DAC
		public unsafe static NetworkType launchType
		{
			get
			{
				NetworkType networkType;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_launchType, (void*)(&networkType));
				return networkType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_launchType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x00137CA0 File Offset: 0x00135EA0
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x00019BBE File Offset: 0x00017DBE
		public unsafe static string clientToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_clientToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_clientToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x00137CC0 File Offset: 0x00135EC0
		// (set) Token: 0x060045C6 RID: 17862 RVA: 0x00019BD0 File Offset: 0x00017DD0
		public unsafe static string serverToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_serverToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_serverToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x00137CE0 File Offset: 0x00135EE0
		// (set) Token: 0x060045C8 RID: 17864 RVA: 0x00019BE2 File Offset: 0x00017DE2
		public unsafe static bool isSolo
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_isSolo, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_isSolo, (void*)(&value));
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x00137CFC File Offset: 0x00135EFC
		// (set) Token: 0x060045CA RID: 17866 RVA: 0x00019BF0 File Offset: 0x00017DF0
		public unsafe static string soloMapPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_soloMapPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_soloMapPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x00137D1C File Offset: 0x00135F1C
		// (set) Token: 0x060045CC RID: 17868 RVA: 0x00019C02 File Offset: 0x00017E02
		public unsafe static string soloUserName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_soloUserName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_soloUserName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x00137D3C File Offset: 0x00135F3C
		// (set) Token: 0x060045CE RID: 17870 RVA: 0x00019C14 File Offset: 0x00017E14
		public unsafe static int soloUserID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_soloUserID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_soloUserID, (void*)(&value));
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x00137D58 File Offset: 0x00135F58
		// (set) Token: 0x060045D0 RID: 17872 RVA: 0x00019C22 File Offset: 0x00017E22
		public unsafe static int soloID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_soloID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_soloID, (void*)(&value));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x00137D74 File Offset: 0x00135F74
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x00019C30 File Offset: 0x00017E30
		public unsafe static bool isLocal
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_isLocal, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_isLocal, (void*)(&value));
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x00137D90 File Offset: 0x00135F90
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x00019C3E File Offset: 0x00017E3E
		public unsafe static int localGameId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_localGameId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_localGameId, (void*)(&value));
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x00137DAC File Offset: 0x00135FAC
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x00019C4C File Offset: 0x00017E4C
		public unsafe static int localUserId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_localUserId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_localUserId, (void*)(&value));
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x00137DC8 File Offset: 0x00135FC8
		// (set) Token: 0x060045D8 RID: 17880 RVA: 0x00019C5A File Offset: 0x00017E5A
		public unsafe static string localMapPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaunchController.NativeFieldInfoPtr_localMapPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunchController.NativeFieldInfoPtr_localMapPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x00137DE8 File Offset: 0x00135FE8
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x00019C6C File Offset: 0x00017E6C
		public unsafe NetworkType editorLaunchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_editorLaunchType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_editorLaunchType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x00137E18 File Offset: 0x00136018
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x00019C8B File Offset: 0x00017E8B
		public unsafe string testToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x00137E40 File Offset: 0x00136040
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00019CAA File Offset: 0x00017EAA
		public unsafe bool doPlaySolo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_doPlaySolo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_doPlaySolo)) = value;
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x00137E68 File Offset: 0x00136068
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00019CC5 File Offset: 0x00017EC5
		public unsafe string playSoloTestMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestMap);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestMap), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00137E90 File Offset: 0x00136090
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00019CE4 File Offset: 0x00017EE4
		public unsafe string playSoloTestUserName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestUserName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestUserName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00137EB8 File Offset: 0x001360B8
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00019D03 File Offset: 0x00017F03
		public unsafe int playSoloTestUserID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestUserID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_playSoloTestUserID)) = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00137EE0 File Offset: 0x001360E0
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x00019D1E File Offset: 0x00017F1E
		public unsafe bool doLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_doLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_doLocal)) = value;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x00137F08 File Offset: 0x00136108
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x00019D39 File Offset: 0x00017F39
		public unsafe int testLocalUserId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalUserId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalUserId)) = value;
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x00137F30 File Offset: 0x00136130
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x00019D54 File Offset: 0x00017F54
		public unsafe int testLocalGameId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalGameId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalGameId)) = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x00137F58 File Offset: 0x00136158
		// (set) Token: 0x060045EC RID: 17900 RVA: 0x00019D6F File Offset: 0x00017F6F
		public unsafe string testLocalMapPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalMapPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testLocalMapPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x00137F80 File Offset: 0x00136180
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x00019D8E File Offset: 0x00017F8E
		public unsafe string testMobileLaunchURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testMobileLaunchURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchController.NativeFieldInfoPtr_testMobileLaunchURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeFieldInfoPtr_launchType;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeFieldInfoPtr_clientToken;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeFieldInfoPtr_serverToken;

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeFieldInfoPtr_isSolo;

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeFieldInfoPtr_soloMapPath;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeFieldInfoPtr_soloUserName;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeFieldInfoPtr_soloUserID;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeFieldInfoPtr_soloID;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeFieldInfoPtr_isLocal;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeFieldInfoPtr_localGameId;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeFieldInfoPtr_localUserId;

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeFieldInfoPtr_localMapPath;

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeFieldInfoPtr_editorLaunchType;

		// Token: 0x04003637 RID: 13879
		private static readonly IntPtr NativeFieldInfoPtr_testToken;

		// Token: 0x04003638 RID: 13880
		private static readonly IntPtr NativeFieldInfoPtr_doPlaySolo;

		// Token: 0x04003639 RID: 13881
		private static readonly IntPtr NativeFieldInfoPtr_playSoloTestMap;

		// Token: 0x0400363A RID: 13882
		private static readonly IntPtr NativeFieldInfoPtr_playSoloTestUserName;

		// Token: 0x0400363B RID: 13883
		private static readonly IntPtr NativeFieldInfoPtr_playSoloTestUserID;

		// Token: 0x0400363C RID: 13884
		private static readonly IntPtr NativeFieldInfoPtr_doLocal;

		// Token: 0x0400363D RID: 13885
		private static readonly IntPtr NativeFieldInfoPtr_testLocalUserId;

		// Token: 0x0400363E RID: 13886
		private static readonly IntPtr NativeFieldInfoPtr_testLocalGameId;

		// Token: 0x0400363F RID: 13887
		private static readonly IntPtr NativeFieldInfoPtr_testLocalMapPath;

		// Token: 0x04003640 RID: 13888
		private static readonly IntPtr NativeFieldInfoPtr_testMobileLaunchURI;

		// Token: 0x04003641 RID: 13889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003642 RID: 13890
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003643 RID: 13891
		private static readonly IntPtr NativeMethodInfoPtr_LaunchAs_Public_Void_NetworkType_String_0;

		// Token: 0x04003644 RID: 13892
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0;

		// Token: 0x04003645 RID: 13893
		private static readonly IntPtr NativeMethodInfoPtr_OnDeepLinkActivated_Private_Void_String_0;

		// Token: 0x04003646 RID: 13894
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveToken_Public_Static_String_0;
	}
}
