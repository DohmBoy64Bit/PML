using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000256 RID: 598
	public class UICommandListItem : MonoBehaviour
	{
		// Token: 0x06002E6F RID: 11887 RVA: 0x000D6EC8 File Offset: 0x000D50C8
		// Note: this type is marked as 'beforefieldinit'.
		static UICommandListItem()
		{
			Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "UICommandListItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr);
			UICommandListItem.NativeFieldInfoPtr_commandIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "commandIcons");
			UICommandListItem.NativeFieldInfoPtr_commandIconsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "commandIconsActive");
			UICommandListItem.NativeFieldInfoPtr_contSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "contSprite");
			UICommandListItem.NativeFieldInfoPtr_contSpriteActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "contSpriteActive");
			UICommandListItem.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "loaded");
			UICommandListItem.NativeFieldInfoPtr_cont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "cont");
			UICommandListItem.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "icon");
			UICommandListItem.NativeFieldInfoPtr_nameT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "nameT");
			UICommandListItem.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "description");
			UICommandListItem.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "cmd");
			UICommandListItem.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, "active");
			UICommandListItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, 100670272);
			UICommandListItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, 100670269);
			UICommandListItem.NativeMethodInfoPtr_SetCommand_Public_Void_SlashCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, 100670270);
			UICommandListItem.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr, 100670271);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000D7024 File Offset: 0x000D5224
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UICommandListItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICommandListItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandListItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000D7060 File Offset: 0x000D5260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99034, XrefRangeEnd = 99112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandListItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000D7094 File Offset: 0x000D5294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99112, XrefRangeEnd = 99140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCommand(SlashCommand cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandListItem.NativeMethodInfoPtr_SetCommand_Public_Void_SlashCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000D70D8 File Offset: 0x000D52D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99163, RefRangeEnd = 99165, XrefRangeStart = 99140, XrefRangeEnd = 99163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandListItem.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0001294A File Offset: 0x00010B4A
		public UICommandListItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x000D7118 File Offset: 0x000D5318
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x00012953 File Offset: 0x00010B53
		public unsafe static List<Sprite> commandIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UICommandListItem.NativeFieldInfoPtr_commandIcons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandListItem.NativeFieldInfoPtr_commandIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000D7140 File Offset: 0x000D5340
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00012965 File Offset: 0x00010B65
		public unsafe static List<Sprite> commandIconsActive
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UICommandListItem.NativeFieldInfoPtr_commandIconsActive, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandListItem.NativeFieldInfoPtr_commandIconsActive, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x000D7168 File Offset: 0x000D5368
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00012977 File Offset: 0x00010B77
		public unsafe static Sprite contSprite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UICommandListItem.NativeFieldInfoPtr_contSprite, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandListItem.NativeFieldInfoPtr_contSprite, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000D7190 File Offset: 0x000D5390
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x00012989 File Offset: 0x00010B89
		public unsafe static Sprite contSpriteActive
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UICommandListItem.NativeFieldInfoPtr_contSpriteActive, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandListItem.NativeFieldInfoPtr_contSpriteActive, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000D71B8 File Offset: 0x000D53B8
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x0001299B File Offset: 0x00010B9B
		public unsafe static bool loaded
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UICommandListItem.NativeFieldInfoPtr_loaded, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandListItem.NativeFieldInfoPtr_loaded, (void*)(&value));
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000D71D4 File Offset: 0x000D53D4
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x000129A9 File Offset: 0x00010BA9
		public unsafe Image cont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_cont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_cont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000D7204 File Offset: 0x000D5404
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x000129C8 File Offset: 0x00010BC8
		public unsafe Image icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000D7234 File Offset: 0x000D5434
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x000129E7 File Offset: 0x00010BE7
		public unsafe TMP_Text nameT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_nameT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_nameT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000D7264 File Offset: 0x000D5464
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x00012A06 File Offset: 0x00010C06
		public unsafe TMP_Text description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x000D7294 File Offset: 0x000D5494
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x00012A25 File Offset: 0x00010C25
		public unsafe SlashCommand cmd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_cmd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlashCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x000D72C4 File Offset: 0x000D54C4
		// (set) Token: 0x06002E8A RID: 11914 RVA: 0x00012A44 File Offset: 0x00010C44
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandListItem.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeFieldInfoPtr_commandIcons;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_commandIconsActive;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_contSprite;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeFieldInfoPtr_contSpriteActive;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeFieldInfoPtr_loaded;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeFieldInfoPtr_cont;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeFieldInfoPtr_nameT;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeFieldInfoPtr_cmd;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_SetCommand_Public_Void_SlashCommand_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;
	}
}
