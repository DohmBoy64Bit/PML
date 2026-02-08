using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014F RID: 335
	public sealed class FileStat : ValueType
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x00072C90 File Offset: 0x00070E90
		// Note: this type is marked as 'beforefieldinit'.
		static FileStat()
		{
			Il2CppClassPointerStore<FileStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "FileStat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStat>.NativeClassPtr);
			FileStat.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStat>.NativeClassPtr, "Filename");
			FileStat.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStat>.NativeClassPtr, "Size");
			FileStat.NativeFieldInfoPtr_LastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStat>.NativeClassPtr, "LastModified");
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00008C64 File Offset: 0x00006E64
		public FileStat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00008C6D File Offset: 0x00006E6D
		public FileStat()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStat>.NativeClassPtr))
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00072CFC File Offset: 0x00070EFC
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00008C7F File Offset: 0x00006E7F
		public unsafe string Filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_Filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_Filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00072D24 File Offset: 0x00070F24
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00008C9E File Offset: 0x00006E9E
		public unsafe ulong Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00072D4C File Offset: 0x00070F4C
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00008CB9 File Offset: 0x00006EB9
		public unsafe ulong LastModified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_LastModified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStat.NativeFieldInfoPtr_LastModified)) = value;
			}
		}

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_Filename;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_LastModified;
	}
}
