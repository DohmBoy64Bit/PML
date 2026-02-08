using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.UI
{
	// Token: 0x02000254 RID: 596
	[Serializable]
	public class SlashCommand : Object
	{
		// Token: 0x06002E48 RID: 11848 RVA: 0x000D68CC File Offset: 0x000D4ACC
		// Note: this type is marked as 'beforefieldinit'.
		static SlashCommand()
		{
			Il2CppClassPointerStore<SlashCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "SlashCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr);
			SlashCommand.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr, "Icon");
			SlashCommand.NativeFieldInfoPtr_CommandName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr, "CommandName");
			SlashCommand.NativeFieldInfoPtr_Args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr, "Args");
			SlashCommand.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr, "Description");
			SlashCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr, 100670262);
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x000D6960 File Offset: 0x000D4B60
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlashCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlashCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlashCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000127BD File Offset: 0x000109BD
		public SlashCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000D699C File Offset: 0x000D4B9C
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x000127C6 File Offset: 0x000109C6
		public unsafe int Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Icon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Icon)) = value;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000D69C4 File Offset: 0x000D4BC4
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000127E1 File Offset: 0x000109E1
		public unsafe string CommandName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_CommandName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_CommandName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000D69EC File Offset: 0x000D4BEC
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00012800 File Offset: 0x00010A00
		public unsafe Il2CppStringArray Args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000D6A1C File Offset: 0x000D4C1C
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x0001281F File Offset: 0x00010A1F
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlashCommand.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeFieldInfoPtr_CommandName;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeFieldInfoPtr_Args;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
