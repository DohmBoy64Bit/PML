using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000329 RID: 809
	public class HotbarController : MonoBehaviour
	{
		// Token: 0x0600457F RID: 17791 RVA: 0x00136E2C File Offset: 0x0013502C
		// Note: this type is marked as 'beforefieldinit'.
		static HotbarController()
		{
			Il2CppClassPointerStore<HotbarController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "HotbarController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotbarController>.NativeClassPtr);
			HotbarController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, "singleton");
			HotbarController.NativeFieldInfoPtr_hotbarItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, "hotbarItem");
			HotbarController.NativeFieldInfoPtr_tools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, "tools");
			HotbarController.NativeFieldInfoPtr_toolIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, "toolIndex");
			HotbarController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674332);
			HotbarController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674327);
			HotbarController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674328);
			HotbarController.NativeMethodInfoPtr_ToolLinked_Public_Void_Tool_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674329);
			HotbarController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674330);
			HotbarController.NativeMethodInfoPtr_EquipTool_Private_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarController>.NativeClassPtr, 100674331);
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00136F24 File Offset: 0x00135124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134370, XrefRangeEnd = 134378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00136F60 File Offset: 0x00135160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134378, XrefRangeEnd = 134382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00136F94 File Offset: 0x00135194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134382, XrefRangeEnd = 134388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00136FC8 File Offset: 0x001351C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134440, RefRangeEnd = 134441, XrefRangeStart = 134388, XrefRangeEnd = 134440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToolLinked(Tool tool, Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr_ToolLinked_Public_Void_Tool_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x0013701C File Offset: 0x0013521C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134441, XrefRangeEnd = 134565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00137050 File Offset: 0x00135250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134572, RefRangeEnd = 134574, XrefRangeStart = 134565, XrefRangeEnd = 134572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquipTool(Tool tool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarController.NativeMethodInfoPtr_EquipTool_Private_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x000199C1 File Offset: 0x00017BC1
		public HotbarController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x00137094 File Offset: 0x00135294
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x000199CA File Offset: 0x00017BCA
		public unsafe static HotbarController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HotbarController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HotbarController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x001370BC File Offset: 0x001352BC
		// (set) Token: 0x0600458A RID: 17802 RVA: 0x000199DC File Offset: 0x00017BDC
		public unsafe RectTransform hotbarItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_hotbarItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_hotbarItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x001370EC File Offset: 0x001352EC
		// (set) Token: 0x0600458C RID: 17804 RVA: 0x000199FB File Offset: 0x00017BFB
		public unsafe Dictionary<Tool, RectTransform> tools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_tools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Tool, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_tools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x0013711C File Offset: 0x0013531C
		// (set) Token: 0x0600458E RID: 17806 RVA: 0x00019A1A File Offset: 0x00017C1A
		public unsafe int toolIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_toolIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarController.NativeFieldInfoPtr_toolIndex)) = value;
			}
		}

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeFieldInfoPtr_hotbarItem;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeFieldInfoPtr_tools;

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeFieldInfoPtr_toolIndex;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeMethodInfoPtr_ToolLinked_Public_Void_Tool_Instance_0;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeMethodInfoPtr_EquipTool_Private_Void_Tool_0;
	}
}
