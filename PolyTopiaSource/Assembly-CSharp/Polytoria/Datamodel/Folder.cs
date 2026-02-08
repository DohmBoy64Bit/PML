using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027C RID: 636
	public class Folder : Instance
	{
		// Token: 0x06003229 RID: 12841 RVA: 0x000E5E94 File Offset: 0x000E4094
		// Note: this type is marked as 'beforefieldinit'.
		static Folder()
		{
			Il2CppClassPointerStore<Folder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Folder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Folder>.NativeClassPtr);
			Folder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Folder>.NativeClassPtr, 100670852);
			Folder.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Folder>.NativeClassPtr, 100670853);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000E5EEC File Offset: 0x000E40EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103325, XrefRangeEnd = 103329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Folder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Folder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Folder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000E5F28 File Offset: 0x000E4128
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Folder.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00013E4A File Offset: 0x0001204A
		public Folder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
