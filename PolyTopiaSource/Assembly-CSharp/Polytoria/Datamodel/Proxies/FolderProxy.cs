using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D8 RID: 728
	public class FolderProxy : InstanceProxy
	{
		// Token: 0x0600402C RID: 16428 RVA: 0x00120364 File Offset: 0x0011E564
		// Note: this type is marked as 'beforefieldinit'.
		static FolderProxy()
		{
			Il2CppClassPointerStore<FolderProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "FolderProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FolderProxy>.NativeClassPtr);
			FolderProxy.NativeFieldInfoPtr_folder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FolderProxy>.NativeClassPtr, "folder");
			FolderProxy.NativeMethodInfoPtr__ctor_Public_Void_Folder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FolderProxy>.NativeClassPtr, 100673344);
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x001203BC File Offset: 0x0011E5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FolderProxy(Folder target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FolderProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FolderProxy.NativeMethodInfoPtr__ctor_Public_Void_Folder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00018601 File Offset: 0x00016801
		public FolderProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x00120408 File Offset: 0x0011E608
		// (set) Token: 0x06004030 RID: 16432 RVA: 0x0001860A File Offset: 0x0001680A
		public unsafe Folder folder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FolderProxy.NativeFieldInfoPtr_folder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Folder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FolderProxy.NativeFieldInfoPtr_folder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeFieldInfoPtr_folder;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Folder_0;
	}
}
