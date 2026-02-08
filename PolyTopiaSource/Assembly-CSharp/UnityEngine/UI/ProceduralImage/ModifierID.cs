using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000342 RID: 834
	public class ModifierID : Attribute
	{
		// Token: 0x06004874 RID: 18548 RVA: 0x00140BD8 File Offset: 0x0013EDD8
		// Note: this type is marked as 'beforefieldinit'.
		static ModifierID()
		{
			Il2CppClassPointerStore<ModifierID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.ProceduralImage", "ModifierID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierID>.NativeClassPtr);
			ModifierID.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierID>.NativeClassPtr, "name");
			ModifierID.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierID>.NativeClassPtr, 100674873);
			ModifierID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierID>.NativeClassPtr, 100674872);
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x00140C44 File Offset: 0x0013EE44
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifierID.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00140C7C File Offset: 0x0013EE7C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 20486, RefRangeEnd = 20524, XrefRangeStart = 20486, XrefRangeEnd = 20524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifierID(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifierID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x0001AF69 File Offset: 0x00019169
		public ModifierID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x00140CC8 File Offset: 0x0013EEC8
		// (set) Token: 0x06004879 RID: 18553 RVA: 0x0001AF72 File Offset: 0x00019172
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifierID.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifierID.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
