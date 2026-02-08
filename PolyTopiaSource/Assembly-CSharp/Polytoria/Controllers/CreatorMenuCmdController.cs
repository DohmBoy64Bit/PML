using System;
using Battlehub.UIControls.MenuControl;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200033F RID: 831
	public class CreatorMenuCmdController : MonoBehaviour
	{
		// Token: 0x06004854 RID: 18516 RVA: 0x001404B4 File Offset: 0x0013E6B4
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorMenuCmdController()
		{
			Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "CreatorMenuCmdController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr);
			CreatorMenuCmdController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr, 100674861);
			CreatorMenuCmdController.NativeMethodInfoPtr_OnValidateCmd_Public_Void_MenuItemValidationArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr, 100674858);
			CreatorMenuCmdController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr, 100674859);
			CreatorMenuCmdController.NativeMethodInfoPtr_OnCmd_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr, 100674860);
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00140534 File Offset: 0x0013E734
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorMenuCmdController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorMenuCmdController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorMenuCmdController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00140570 File Offset: 0x0013E770
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateCmd(MenuItemValidationArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorMenuCmdController.NativeMethodInfoPtr_OnValidateCmd_Public_Void_MenuItemValidationArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x001405B4 File Offset: 0x0013E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142942, XrefRangeEnd = 142994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorMenuCmdController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x001405E8 File Offset: 0x0013E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142994, XrefRangeEnd = 143298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCmd(string cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorMenuCmdController.NativeMethodInfoPtr_OnCmd_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x0001AEA0 File Offset: 0x000190A0
		public CreatorMenuCmdController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateCmd_Public_Void_MenuItemValidationArgs_0;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeMethodInfoPtr_OnCmd_Public_Void_String_0;
	}
}
