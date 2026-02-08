using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000255 RID: 597
	public class UICommandList : MonoBehaviour
	{
		// Token: 0x06002E53 RID: 11859 RVA: 0x000D6A44 File Offset: 0x000D4C44
		// Note: this type is marked as 'beforefieldinit'.
		static UICommandList()
		{
			Il2CppClassPointerStore<UICommandList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "UICommandList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICommandList>.NativeClassPtr);
			UICommandList.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "IsActive");
			UICommandList.NativeFieldInfoPtr_ActiveCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "ActiveCommand");
			UICommandList.NativeFieldInfoPtr_ActiveCommandFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "ActiveCommandFilled");
			UICommandList.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "container");
			UICommandList.NativeFieldInfoPtr_listContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "listContainer");
			UICommandList.NativeFieldInfoPtr_emptyContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "emptyContainer");
			UICommandList.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "scrollRect");
			UICommandList.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "commands");
			UICommandList.NativeFieldInfoPtr_commandObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "commandObjects");
			UICommandList.NativeFieldInfoPtr_curActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, "curActive");
			UICommandList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670268);
			UICommandList.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670263);
			UICommandList.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670264);
			UICommandList.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670265);
			UICommandList.NativeMethodInfoPtr_AddObject_Public_Void_SlashCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670266);
			UICommandList.NativeMethodInfoPtr_Search_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICommandList>.NativeClassPtr, 100670267);
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000D6BB4 File Offset: 0x000D4DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98913, XrefRangeEnd = 98921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UICommandList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICommandList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000D6BF0 File Offset: 0x000D4DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98921, XrefRangeEnd = 98941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000D6C24 File Offset: 0x000D4E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98941, XrefRangeEnd = 98960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000D6C58 File Offset: 0x000D4E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98965, RefRangeEnd = 98967, XrefRangeStart = 98960, XrefRangeEnd = 98965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000D6C98 File Offset: 0x000D4E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98997, RefRangeEnd = 98999, XrefRangeStart = 98967, XrefRangeEnd = 98997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddObject(SlashCommand cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr_AddObject_Public_Void_SlashCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000D6CDC File Offset: 0x000D4EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99033, RefRangeEnd = 99034, XrefRangeStart = 98999, XrefRangeEnd = 99033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Search(string Text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICommandList.NativeMethodInfoPtr_Search_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0001283E File Offset: 0x00010A3E
		public UICommandList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000D6D20 File Offset: 0x000D4F20
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x00012847 File Offset: 0x00010A47
		public unsafe static bool IsActive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UICommandList.NativeFieldInfoPtr_IsActive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandList.NativeFieldInfoPtr_IsActive, (void*)(&value));
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x000D6D3C File Offset: 0x000D4F3C
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x00012855 File Offset: 0x00010A55
		public unsafe static SlashCommand ActiveCommand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UICommandList.NativeFieldInfoPtr_ActiveCommand, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlashCommand>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandList.NativeFieldInfoPtr_ActiveCommand, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x000D6D64 File Offset: 0x000D4F64
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x00012867 File Offset: 0x00010A67
		public unsafe static bool ActiveCommandFilled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UICommandList.NativeFieldInfoPtr_ActiveCommandFilled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UICommandList.NativeFieldInfoPtr_ActiveCommandFilled, (void*)(&value));
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x000D6D80 File Offset: 0x000D4F80
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x00012875 File Offset: 0x00010A75
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x000D6DB0 File Offset: 0x000D4FB0
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x00012894 File Offset: 0x00010A94
		public unsafe Transform listContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_listContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_listContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000D6DE0 File Offset: 0x000D4FE0
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x000128B3 File Offset: 0x00010AB3
		public unsafe Transform emptyContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_emptyContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_emptyContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000D6E10 File Offset: 0x000D5010
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x000128D2 File Offset: 0x00010AD2
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000D6E40 File Offset: 0x000D5040
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x000128F1 File Offset: 0x00010AF1
		public unsafe Il2CppReferenceArray<SlashCommand> commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlashCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x000D6E70 File Offset: 0x000D5070
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00012910 File Offset: 0x00010B10
		public unsafe List<Transform> commandObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_commandObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_commandObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x000D6EA0 File Offset: 0x000D50A0
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x0001292F File Offset: 0x00010B2F
		public unsafe int curActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_curActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICommandList.NativeFieldInfoPtr_curActive)) = value;
			}
		}

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeFieldInfoPtr_IsActive;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCommand;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCommandFilled;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeFieldInfoPtr_listContainer;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeFieldInfoPtr_emptyContainer;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeFieldInfoPtr_commandObjects;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeFieldInfoPtr_curActive;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_AddObject_Public_Void_SlashCommand_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_Search_Public_Void_String_0;
	}
}
