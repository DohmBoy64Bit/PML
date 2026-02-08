using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000325 RID: 805
	public class ClipboardController : MonoBehaviour
	{
		// Token: 0x0600451F RID: 17695 RVA: 0x001352F4 File Offset: 0x001334F4
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardController()
		{
			Il2CppClassPointerStore<ClipboardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ClipboardController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr);
			ClipboardController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "singleton");
			ClipboardController.NativeFieldInfoPtr_CLIPBOARD_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "CLIPBOARD_PREFIX");
			ClipboardController.NativeFieldInfoPtr_GMEM_MOVEABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "GMEM_MOVEABLE");
			ClipboardController.NativeFieldInfoPtr_CF_UNICODETEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "CF_UNICODETEXT");
			ClipboardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674249);
			ClipboardController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674233);
			ClipboardController.NativeMethodInfoPtr_OpenClipboard_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674234);
			ClipboardController.NativeMethodInfoPtr_CloseClipboard_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674235);
			ClipboardController.NativeMethodInfoPtr_EmptyClipboard_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674236);
			ClipboardController.NativeMethodInfoPtr_SetClipboardData_Private_Static_IntPtr_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674237);
			ClipboardController.NativeMethodInfoPtr_GetClipboardData_Private_Static_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674238);
			ClipboardController.NativeMethodInfoPtr_GlobalAlloc_Private_Static_IntPtr_UInt32_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674239);
			ClipboardController.NativeMethodInfoPtr_GlobalLock_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674240);
			ClipboardController.NativeMethodInfoPtr_GlobalUnlock_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674241);
			ClipboardController.NativeMethodInfoPtr_GlobalFree_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674242);
			ClipboardController.NativeMethodInfoPtr_SetClipboardText_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674243);
			ClipboardController.NativeMethodInfoPtr_GetClipboardText_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674244);
			ClipboardController.NativeMethodInfoPtr_CopyInstancesToClipboard_Public_Void_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674245);
			ClipboardController.NativeMethodInfoPtr_PasteInstancesFromClipboard_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674246);
			ClipboardController.NativeMethodInfoPtr_CompressString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674247);
			ClipboardController.NativeMethodInfoPtr_DecompressString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, 100674248);
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001354C8 File Offset: 0x001336C8
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00135504 File Offset: 0x00133704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131766, XrefRangeEnd = 131770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00135538 File Offset: 0x00133738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131772, RefRangeEnd = 131775, XrefRangeStart = 131770, XrefRangeEnd = 131772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OpenClipboard(IntPtr hWndNewOwner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hWndNewOwner;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_OpenClipboard_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00135578 File Offset: 0x00133778
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131777, RefRangeEnd = 131782, XrefRangeStart = 131775, XrefRangeEnd = 131777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseClipboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_CloseClipboard_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001355A8 File Offset: 0x001337A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131782, XrefRangeEnd = 131784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EmptyClipboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_EmptyClipboard_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x001355D8 File Offset: 0x001337D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131784, XrefRangeEnd = 131786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SetClipboardData(uint uFormat, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uFormat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_SetClipboardData_Private_Static_IntPtr_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00135624 File Offset: 0x00133824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131786, XrefRangeEnd = 131788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetClipboardData(uint uFormat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GetClipboardData_Private_Static_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00135664 File Offset: 0x00133864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131788, XrefRangeEnd = 131790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GlobalAlloc(uint flags, UIntPtr size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GlobalAlloc_Private_Static_IntPtr_UInt32_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x001356B0 File Offset: 0x001338B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131792, RefRangeEnd = 131795, XrefRangeStart = 131790, XrefRangeEnd = 131792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GlobalLock(IntPtr hMem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hMem;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GlobalLock_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x001356F0 File Offset: 0x001338F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131797, RefRangeEnd = 131800, XrefRangeStart = 131795, XrefRangeEnd = 131797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GlobalUnlock(IntPtr hMem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hMem;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GlobalUnlock_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00135730 File Offset: 0x00133930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131800, XrefRangeEnd = 131802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GlobalFree(IntPtr hMem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hMem;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GlobalFree_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00135770 File Offset: 0x00133970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131833, RefRangeEnd = 131834, XrefRangeStart = 131802, XrefRangeEnd = 131833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetClipboardText(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_SetClipboardText_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x001357A8 File Offset: 0x001339A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131834, XrefRangeEnd = 131855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClipboardText()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_GetClipboardText_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x001357D4 File Offset: 0x001339D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131969, RefRangeEnd = 131973, XrefRangeStart = 131855, XrefRangeEnd = 131969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyInstancesToClipboard(List<Instance> instances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instances);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_CopyInstancesToClipboard_Public_Void_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00135818 File Offset: 0x00133A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132117, RefRangeEnd = 132119, XrefRangeStart = 131973, XrefRangeEnd = 132117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PasteInstancesFromClipboard(Instance targetParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_PasteInstancesFromClipboard_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x0013585C File Offset: 0x00133A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132143, RefRangeEnd = 132144, XrefRangeStart = 132119, XrefRangeEnd = 132143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CompressString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_CompressString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x001358A4 File Offset: 0x00133AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132168, RefRangeEnd = 132169, XrefRangeStart = 132144, XrefRangeEnd = 132168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DecompressString(string compressedText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(compressedText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.NativeMethodInfoPtr_DecompressString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x0001987E File Offset: 0x00017A7E
		public ClipboardController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x001358EC File Offset: 0x00133AEC
		// (set) Token: 0x06004533 RID: 17715 RVA: 0x00019887 File Offset: 0x00017A87
		public unsafe static ClipboardController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClipboardController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipboardController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x00135914 File Offset: 0x00133B14
		// (set) Token: 0x06004535 RID: 17717 RVA: 0x00019899 File Offset: 0x00017A99
		public unsafe static string CLIPBOARD_PREFIX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClipboardController.NativeFieldInfoPtr_CLIPBOARD_PREFIX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipboardController.NativeFieldInfoPtr_CLIPBOARD_PREFIX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x00135934 File Offset: 0x00133B34
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x000198AB File Offset: 0x00017AAB
		public unsafe static uint GMEM_MOVEABLE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ClipboardController.NativeFieldInfoPtr_GMEM_MOVEABLE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipboardController.NativeFieldInfoPtr_GMEM_MOVEABLE, (void*)(&value));
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x00135950 File Offset: 0x00133B50
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x000198B9 File Offset: 0x00017AB9
		public unsafe static uint CF_UNICODETEXT
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ClipboardController.NativeFieldInfoPtr_CF_UNICODETEXT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipboardController.NativeFieldInfoPtr_CF_UNICODETEXT, (void*)(&value));
			}
		}

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeFieldInfoPtr_CLIPBOARD_PREFIX;

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeFieldInfoPtr_GMEM_MOVEABLE;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeFieldInfoPtr_CF_UNICODETEXT;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeMethodInfoPtr_OpenClipboard_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeMethodInfoPtr_CloseClipboard_Private_Static_Boolean_0;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeMethodInfoPtr_EmptyClipboard_Private_Static_Boolean_0;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeMethodInfoPtr_SetClipboardData_Private_Static_IntPtr_UInt32_IntPtr_0;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeMethodInfoPtr_GetClipboardData_Private_Static_IntPtr_UInt32_0;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeMethodInfoPtr_GlobalAlloc_Private_Static_IntPtr_UInt32_UIntPtr_0;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeMethodInfoPtr_GlobalLock_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeMethodInfoPtr_GlobalUnlock_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeMethodInfoPtr_GlobalFree_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeMethodInfoPtr_SetClipboardText_Private_Static_Void_String_0;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeMethodInfoPtr_GetClipboardText_Private_Static_String_0;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeMethodInfoPtr_CopyInstancesToClipboard_Public_Void_List_1_Instance_0;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeMethodInfoPtr_PasteInstancesFromClipboard_Public_Void_Instance_0;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeMethodInfoPtr_CompressString_Private_String_String_0;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeMethodInfoPtr_DecompressString_Private_String_String_0;

		// Token: 0x02000425 RID: 1061
		[ObfuscatedName("Polytoria.Controllers.ClipboardController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06005199 RID: 20889 RVA: 0x0015CA60 File Offset: 0x0015AC60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr);
				ClipboardController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, "<>9");
				ClipboardController.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, "<>9__16_0");
				ClipboardController.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, "<>9__16_1");
				ClipboardController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, 100674251);
				ClipboardController.__c.NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_0_Internal_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, 100674252);
				ClipboardController.__c.NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_1_Internal_Int32_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr, 100674253);
			}

			// Token: 0x0600519A RID: 20890 RVA: 0x0015CB04 File Offset: 0x0015AD04
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600519B RID: 20891 RVA: 0x0015CB40 File Offset: 0x0015AD40
			[CallerCount(0)]
			public unsafe bool _CopyInstancesToClipboard_b__16_0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.__c.NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_0_Internal_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600519C RID: 20892 RVA: 0x0015CB90 File Offset: 0x0015AD90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131763, XrefRangeEnd = 131765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CopyInstancesToClipboard_b__16_1(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.__c.NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_1_Internal_Int32_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600519D RID: 20893 RVA: 0x0001F698 File Offset: 0x0001D898
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B88 RID: 7048
			// (get) Token: 0x0600519E RID: 20894 RVA: 0x0015CBE0 File Offset: 0x0015ADE0
			// (set) Token: 0x0600519F RID: 20895 RVA: 0x0001F6A1 File Offset: 0x0001D8A1
			public unsafe static ClipboardController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClipboardController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClipboardController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B89 RID: 7049
			// (get) Token: 0x060051A0 RID: 20896 RVA: 0x0015CC08 File Offset: 0x0015AE08
			// (set) Token: 0x060051A1 RID: 20897 RVA: 0x0001F6B3 File Offset: 0x0001D8B3
			public unsafe static Func<Instance, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClipboardController.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClipboardController.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B8A RID: 7050
			// (get) Token: 0x060051A2 RID: 20898 RVA: 0x0015CC30 File Offset: 0x0015AE30
			// (set) Token: 0x060051A3 RID: 20899 RVA: 0x0001F6C5 File Offset: 0x0001D8C5
			public unsafe static Func<Instance, int> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClipboardController.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instance, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClipboardController.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EA6 RID: 16038
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003EA7 RID: 16039
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04003EA8 RID: 16040
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04003EA9 RID: 16041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EAA RID: 16042
			private static readonly IntPtr NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_0_Internal_Boolean_Instance_0;

			// Token: 0x04003EAB RID: 16043
			private static readonly IntPtr NativeMethodInfoPtr__CopyInstancesToClipboard_b__16_1_Internal_Int32_Instance_0;
		}

		// Token: 0x02000426 RID: 1062
		[ObfuscatedName("Polytoria.Controllers.ClipboardController+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060051A4 RID: 20900 RVA: 0x0015CC58 File Offset: 0x0015AE58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardController>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr);
				ClipboardController.__c__DisplayClass16_0.NativeFieldInfoPtr_lowestLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr, "lowestLevel");
				ClipboardController.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr, 100674254);
				ClipboardController.__c__DisplayClass16_0.NativeMethodInfoPtr__CopyInstancesToClipboard_b__2_Internal_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr, 100674255);
			}

			// Token: 0x060051A5 RID: 20901 RVA: 0x0015CCC0 File Offset: 0x0015AEC0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardController.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A6 RID: 20902 RVA: 0x0015CCFC File Offset: 0x0015AEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131765, XrefRangeEnd = 131766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CopyInstancesToClipboard_b__2(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardController.__c__DisplayClass16_0.NativeMethodInfoPtr__CopyInstancesToClipboard_b__2_Internal_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051A7 RID: 20903 RVA: 0x0001F6D7 File Offset: 0x0001D8D7
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B8B RID: 7051
			// (get) Token: 0x060051A8 RID: 20904 RVA: 0x0015CD4C File Offset: 0x0015AF4C
			// (set) Token: 0x060051A9 RID: 20905 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
			public unsafe int lowestLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardController.__c__DisplayClass16_0.NativeFieldInfoPtr_lowestLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardController.__c__DisplayClass16_0.NativeFieldInfoPtr_lowestLevel)) = value;
				}
			}

			// Token: 0x04003EAC RID: 16044
			private static readonly IntPtr NativeFieldInfoPtr_lowestLevel;

			// Token: 0x04003EAD RID: 16045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EAE RID: 16046
			private static readonly IntPtr NativeMethodInfoPtr__CopyInstancesToClipboard_b__2_Internal_Boolean_Instance_0;
		}
	}
}
