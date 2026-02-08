using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Polytoria.Datamodel;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033B RID: 827
	public class ToolboxController : MonoBehaviour
	{
		// Token: 0x060046CC RID: 18124 RVA: 0x0013AD70 File Offset: 0x00138F70
		// Note: this type is marked as 'beforefieldinit'.
		static ToolboxController()
		{
			Il2CppClassPointerStore<ToolboxController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ToolboxController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr);
			ToolboxController.NativeFieldInfoPtr_categorySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "categorySelector");
			ToolboxController.NativeFieldInfoPtr_toolboxContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "toolboxContainer");
			ToolboxController.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "entryPrefab");
			ToolboxController.NativeFieldInfoPtr_pageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "pageLabel");
			ToolboxController.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "page");
			ToolboxController.NativeFieldInfoPtr_pageLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "pageLimit");
			ToolboxController.NativeFieldInfoPtr_cat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "cat");
			ToolboxController.NativeFieldInfoPtr_searchQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "searchQuery");
			ToolboxController.NativeMethodInfoPtr_get_Page_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674502);
			ToolboxController.NativeMethodInfoPtr_set_Page_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674503);
			ToolboxController.NativeMethodInfoPtr_get_Category_Public_get_ToolboxCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674504);
			ToolboxController.NativeMethodInfoPtr_set_Category_Public_set_Void_ToolboxCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674505);
			ToolboxController.NativeMethodInfoPtr_get_SearchQuery_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674506);
			ToolboxController.NativeMethodInfoPtr_set_SearchQuery_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674507);
			ToolboxController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674517);
			ToolboxController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674508);
			ToolboxController.NativeMethodInfoPtr_SetSearchQuery_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674509);
			ToolboxController.NativeMethodInfoPtr_ReloadToolbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674510);
			ToolboxController.NativeMethodInfoPtr_PageUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674511);
			ToolboxController.NativeMethodInfoPtr_PageDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674512);
			ToolboxController.NativeMethodInfoPtr_DoReloadToolbox_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674513);
			ToolboxController.NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_JSONNode_RawImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674514);
			ToolboxController.NativeMethodInfoPtr_InsertModel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674515);
			ToolboxController.NativeMethodInfoPtr_SetCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, 100674516);
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x0013AF80 File Offset: 0x00139180
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x0013AFBC File Offset: 0x001391BC
		public unsafe int Page
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_get_Page_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137689, XrefRangeEnd = 137691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_set_Page_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x0013AFFC File Offset: 0x001391FC
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x0013B038 File Offset: 0x00139238
		public unsafe ToolboxController.ToolboxCategory Category
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_get_Category_Public_get_ToolboxCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137691, XrefRangeEnd = 137692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_set_Category_Public_set_Void_ToolboxCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x0013B078 File Offset: 0x00139278
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x0013B0B0 File Offset: 0x001392B0
		public unsafe string SearchQuery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_get_SearchQuery_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137692, XrefRangeEnd = 137694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_set_SearchQuery_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x0013B0F4 File Offset: 0x001392F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137694, XrefRangeEnd = 137695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToolboxController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x0013B130 File Offset: 0x00139330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137695, XrefRangeEnd = 137731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0013B164 File Offset: 0x00139364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSearchQuery(string q)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_SetSearchQuery_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x0013B1A8 File Offset: 0x001393A8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 137737, RefRangeEnd = 137747, XrefRangeStart = 137731, XrefRangeEnd = 137737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadToolbox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_ReloadToolbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x0013B1DC File Offset: 0x001393DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137747, XrefRangeEnd = 137749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PageUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_PageUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0013B210 File Offset: 0x00139410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137749, XrefRangeEnd = 137751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PageDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_PageDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x0013B244 File Offset: 0x00139444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137751, XrefRangeEnd = 137756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoReloadToolbox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_DoReloadToolbox_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x0013B284 File Offset: 0x00139484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137756, XrefRangeEnd = 137762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadThumbnail(JSONNode entry, RawImage image)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_JSONNode_RawImage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x0013B2E8 File Offset: 0x001394E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137785, RefRangeEnd = 137787, XrefRangeStart = 137762, XrefRangeEnd = 137785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertModel(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_InsertModel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x0013B328 File Offset: 0x00139528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137787, XrefRangeEnd = 137788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategory(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.NativeMethodInfoPtr_SetCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x0001A368 File Offset: 0x00018568
		public ToolboxController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x0013B368 File Offset: 0x00139568
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x0001A371 File Offset: 0x00018571
		public unsafe TMP_Dropdown categorySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_categorySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_categorySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0013B398 File Offset: 0x00139598
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x0001A390 File Offset: 0x00018590
		public unsafe RectTransform toolboxContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_toolboxContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_toolboxContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x0013B3C8 File Offset: 0x001395C8
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x0001A3AF File Offset: 0x000185AF
		public unsafe RectTransform entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x0013B3F8 File Offset: 0x001395F8
		// (set) Token: 0x060046E5 RID: 18149 RVA: 0x0001A3CE File Offset: 0x000185CE
		public unsafe TMP_Text pageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_pageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_pageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x0013B428 File Offset: 0x00139628
		// (set) Token: 0x060046E7 RID: 18151 RVA: 0x0001A3ED File Offset: 0x000185ED
		public unsafe int page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_page);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_page)) = value;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x0013B450 File Offset: 0x00139650
		// (set) Token: 0x060046E9 RID: 18153 RVA: 0x0001A408 File Offset: 0x00018608
		public unsafe int pageLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_pageLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_pageLimit)) = value;
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0013B478 File Offset: 0x00139678
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x0001A423 File Offset: 0x00018623
		public unsafe ToolboxController.ToolboxCategory cat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_cat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_cat)) = value;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x0013B4A0 File Offset: 0x001396A0
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x0001A43E File Offset: 0x0001863E
		public unsafe string searchQuery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_searchQuery);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.NativeFieldInfoPtr_searchQuery), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeFieldInfoPtr_categorySelector;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeFieldInfoPtr_toolboxContainer;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeFieldInfoPtr_pageLabel;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeFieldInfoPtr_pageLimit;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeFieldInfoPtr_cat;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeFieldInfoPtr_searchQuery;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeMethodInfoPtr_get_Page_Public_get_Int32_0;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeMethodInfoPtr_set_Page_Public_set_Void_Int32_0;

		// Token: 0x040036E9 RID: 14057
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_get_ToolboxCategory_0;

		// Token: 0x040036EA RID: 14058
		private static readonly IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_ToolboxCategory_0;

		// Token: 0x040036EB RID: 14059
		private static readonly IntPtr NativeMethodInfoPtr_get_SearchQuery_Public_get_String_0;

		// Token: 0x040036EC RID: 14060
		private static readonly IntPtr NativeMethodInfoPtr_set_SearchQuery_Public_set_Void_String_0;

		// Token: 0x040036ED RID: 14061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchQuery_Public_Void_String_0;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeMethodInfoPtr_ReloadToolbox_Public_Void_0;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeMethodInfoPtr_PageUp_Public_Void_0;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeMethodInfoPtr_PageDown_Public_Void_0;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeMethodInfoPtr_DoReloadToolbox_Private_IEnumerator_0;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_JSONNode_RawImage_0;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeMethodInfoPtr_InsertModel_Public_Void_Int32_0;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeMethodInfoPtr_SetCategory_Public_Void_Int32_0;

		// Token: 0x02000438 RID: 1080
		public enum ToolboxCategory
		{
			// Token: 0x04003F44 RID: 16196
			RecentlyUpdated,
			// Token: 0x04003F45 RID: 16197
			UploadedModels
		}

		// Token: 0x02000439 RID: 1081
		[ObfuscatedName("Polytoria.Controllers.ToolboxController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060052AE RID: 21166 RVA: 0x0015FA90 File Offset: 0x0015DC90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr);
				ToolboxController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr, "<>9");
				ToolboxController.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr, "<>9__24_0");
				ToolboxController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr, 100674519);
				ToolboxController.__c.NativeMethodInfoPtr__InsertModel_b__24_0_Internal_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr, 100674520);
			}

			// Token: 0x060052AF RID: 21167 RVA: 0x0015FB0C File Offset: 0x0015DD0C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B0 RID: 21168 RVA: 0x0015FB48 File Offset: 0x0015DD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137429, XrefRangeEnd = 137436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InsertModel_b__24_0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c.NativeMethodInfoPtr__InsertModel_b__24_0_Internal_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052B1 RID: 21169 RVA: 0x0002003C File Offset: 0x0001E23C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE8 RID: 7144
			// (get) Token: 0x060052B2 RID: 21170 RVA: 0x0015FB8C File Offset: 0x0015DD8C
			// (set) Token: 0x060052B3 RID: 21171 RVA: 0x00020045 File Offset: 0x0001E245
			public unsafe static ToolboxController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToolboxController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToolboxController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToolboxController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE9 RID: 7145
			// (get) Token: 0x060052B4 RID: 21172 RVA: 0x0015FBB4 File Offset: 0x0015DDB4
			// (set) Token: 0x060052B5 RID: 21173 RVA: 0x00020057 File Offset: 0x0001E257
			public unsafe static Action<Instance> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToolboxController.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Instance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToolboxController.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F46 RID: 16198
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003F47 RID: 16199
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04003F48 RID: 16200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F49 RID: 16201
			private static readonly IntPtr NativeMethodInfoPtr__InsertModel_b__24_0_Internal_Void_Instance_0;
		}

		// Token: 0x0200043A RID: 1082
		[ObfuscatedName("Polytoria.Controllers.ToolboxController+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060052B6 RID: 21174 RVA: 0x0015FBDC File Offset: 0x0015DDDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr);
				ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, "entry");
				ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, 100674521);
				ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, 100674522);
				ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, 100674523);
				ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr, 100674524);
			}

			// Token: 0x060052B7 RID: 21175 RVA: 0x0015FC80 File Offset: 0x0015DE80
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxController.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B8 RID: 21176 RVA: 0x0015FCBC File Offset: 0x0015DEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137436, XrefRangeEnd = 137441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DoReloadToolbox_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B9 RID: 21177 RVA: 0x0015FCF0 File Offset: 0x0015DEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137441, XrefRangeEnd = 137446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DoReloadToolbox_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052BA RID: 21178 RVA: 0x0015FD24 File Offset: 0x0015DF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137446, XrefRangeEnd = 137457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DoReloadToolbox_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController.__c__DisplayClass22_0.NativeMethodInfoPtr__DoReloadToolbox_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052BB RID: 21179 RVA: 0x00020069 File Offset: 0x0001E269
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BEA RID: 7146
			// (get) Token: 0x060052BC RID: 21180 RVA: 0x0015FD58 File Offset: 0x0015DF58
			// (set) Token: 0x060052BD RID: 21181 RVA: 0x00020072 File Offset: 0x0001E272
			public unsafe JSONNode entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BEB RID: 7147
			// (get) Token: 0x060052BE RID: 21182 RVA: 0x0015FD88 File Offset: 0x0015DF88
			// (set) Token: 0x060052BF RID: 21183 RVA: 0x00020091 File Offset: 0x0001E291
			public unsafe ToolboxController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToolboxController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F4A RID: 16202
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04003F4B RID: 16203
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F4C RID: 16204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F4D RID: 16205
			private static readonly IntPtr NativeMethodInfoPtr__DoReloadToolbox_b__0_Internal_Void_0;

			// Token: 0x04003F4E RID: 16206
			private static readonly IntPtr NativeMethodInfoPtr__DoReloadToolbox_b__1_Internal_Void_0;

			// Token: 0x04003F4F RID: 16207
			private static readonly IntPtr NativeMethodInfoPtr__DoReloadToolbox_b__2_Internal_Void_0;
		}

		// Token: 0x0200043B RID: 1083
		[ObfuscatedName("Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22")]
		public sealed class _DoReloadToolbox_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x060052C0 RID: 21184 RVA: 0x0015FDB8 File Offset: 0x0015DFB8
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReloadToolbox_d__22()
			{
				Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "<DoReloadToolbox>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr);
				ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, "<>1__state");
				ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, "<>2__current");
				ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, "<>4__this");
				ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, "<uwr>5__2");
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674529);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674531);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674525);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674526);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674527);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674528);
				ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr, 100674530);
			}

			// Token: 0x17001BF0 RID: 7152
			// (get) Token: 0x060052C1 RID: 21185 RVA: 0x0015FEC0 File Offset: 0x0015E0C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BF1 RID: 7153
			// (get) Token: 0x060052C2 RID: 21186 RVA: 0x0015FF00 File Offset: 0x0015E100
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052C3 RID: 21187 RVA: 0x0015FF40 File Offset: 0x0015E140
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoReloadToolbox_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxController._DoReloadToolbox_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052C4 RID: 21188 RVA: 0x0015FF88 File Offset: 0x0015E188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137457, XrefRangeEnd = 137462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C5 RID: 21189 RVA: 0x0015FFBC File Offset: 0x0015E1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137462, XrefRangeEnd = 137632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060052C6 RID: 21190 RVA: 0x0015FFF8 File Offset: 0x0015E1F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137632, XrefRangeEnd = 137635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C7 RID: 21191 RVA: 0x0016002C File Offset: 0x0015E22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137635, XrefRangeEnd = 137640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._DoReloadToolbox_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C8 RID: 21192 RVA: 0x000200B0 File Offset: 0x0001E2B0
			public _DoReloadToolbox_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BEC RID: 7148
			// (get) Token: 0x060052C9 RID: 21193 RVA: 0x00160060 File Offset: 0x0015E260
			// (set) Token: 0x060052CA RID: 21194 RVA: 0x000200B9 File Offset: 0x0001E2B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BED RID: 7149
			// (get) Token: 0x060052CB RID: 21195 RVA: 0x00160088 File Offset: 0x0015E288
			// (set) Token: 0x060052CC RID: 21196 RVA: 0x000200D4 File Offset: 0x0001E2D4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BEE RID: 7150
			// (get) Token: 0x060052CD RID: 21197 RVA: 0x001600B8 File Offset: 0x0015E2B8
			// (set) Token: 0x060052CE RID: 21198 RVA: 0x000200F3 File Offset: 0x0001E2F3
			public unsafe ToolboxController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToolboxController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BEF RID: 7151
			// (get) Token: 0x060052CF RID: 21199 RVA: 0x001600E8 File Offset: 0x0015E2E8
			// (set) Token: 0x060052D0 RID: 21200 RVA: 0x00020112 File Offset: 0x0001E312
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._DoReloadToolbox_d__22.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F50 RID: 16208
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F51 RID: 16209
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F52 RID: 16210
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F53 RID: 16211
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003F54 RID: 16212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F55 RID: 16213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F56 RID: 16214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F57 RID: 16215
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F58 RID: 16216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F59 RID: 16217
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F5A RID: 16218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200043C RID: 1084
		[ObfuscatedName("Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23")]
		public sealed class _LoadThumbnail_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x060052D1 RID: 21201 RVA: 0x00160118 File Offset: 0x0015E318
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadThumbnail_d__23()
			{
				Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToolboxController>.NativeClassPtr, "<LoadThumbnail>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr);
				ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, "<>1__state");
				ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, "<>2__current");
				ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, "entry");
				ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, "image");
				ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr__twr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, "<twr>5__2");
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674536);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674538);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674532);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674533);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674534);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674535);
				ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr, 100674537);
			}

			// Token: 0x17001BF7 RID: 7159
			// (get) Token: 0x060052D2 RID: 21202 RVA: 0x00160234 File Offset: 0x0015E434
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BF8 RID: 7160
			// (get) Token: 0x060052D3 RID: 21203 RVA: 0x00160274 File Offset: 0x0015E474
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052D4 RID: 21204 RVA: 0x001602B4 File Offset: 0x0015E4B4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadThumbnail_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxController._LoadThumbnail_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052D5 RID: 21205 RVA: 0x001602FC File Offset: 0x0015E4FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137640, XrefRangeEnd = 137645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052D6 RID: 21206 RVA: 0x00160330 File Offset: 0x0015E530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137645, XrefRangeEnd = 137679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060052D7 RID: 21207 RVA: 0x0016036C File Offset: 0x0015E56C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 137682, RefRangeEnd = 137684, XrefRangeStart = 137679, XrefRangeEnd = 137682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052D8 RID: 21208 RVA: 0x001603A0 File Offset: 0x0015E5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137684, XrefRangeEnd = 137689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxController._LoadThumbnail_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052D9 RID: 21209 RVA: 0x00020131 File Offset: 0x0001E331
			public _LoadThumbnail_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BF2 RID: 7154
			// (get) Token: 0x060052DA RID: 21210 RVA: 0x001603D4 File Offset: 0x0015E5D4
			// (set) Token: 0x060052DB RID: 21211 RVA: 0x0002013A File Offset: 0x0001E33A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BF3 RID: 7155
			// (get) Token: 0x060052DC RID: 21212 RVA: 0x001603FC File Offset: 0x0015E5FC
			// (set) Token: 0x060052DD RID: 21213 RVA: 0x00020155 File Offset: 0x0001E355
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF4 RID: 7156
			// (get) Token: 0x060052DE RID: 21214 RVA: 0x0016042C File Offset: 0x0015E62C
			// (set) Token: 0x060052DF RID: 21215 RVA: 0x00020174 File Offset: 0x0001E374
			public unsafe JSONNode entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF5 RID: 7157
			// (get) Token: 0x060052E0 RID: 21216 RVA: 0x0016045C File Offset: 0x0015E65C
			// (set) Token: 0x060052E1 RID: 21217 RVA: 0x00020193 File Offset: 0x0001E393
			public unsafe RawImage image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RawImage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF6 RID: 7158
			// (get) Token: 0x060052E2 RID: 21218 RVA: 0x0016048C File Offset: 0x0015E68C
			// (set) Token: 0x060052E3 RID: 21219 RVA: 0x000201B2 File Offset: 0x0001E3B2
			public unsafe UnityWebRequest _twr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr__twr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxController._LoadThumbnail_d__23.NativeFieldInfoPtr__twr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F5B RID: 16219
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F5C RID: 16220
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F5D RID: 16221
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04003F5E RID: 16222
			private static readonly IntPtr NativeFieldInfoPtr_image;

			// Token: 0x04003F5F RID: 16223
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__2;

			// Token: 0x04003F60 RID: 16224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F61 RID: 16225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F62 RID: 16226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F63 RID: 16227
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F64 RID: 16228
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F65 RID: 16229
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F66 RID: 16230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
