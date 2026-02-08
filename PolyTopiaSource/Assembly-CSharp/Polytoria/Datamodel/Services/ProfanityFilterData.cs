using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C7 RID: 711
	[Serializable]
	public class ProfanityFilterData : Object
	{
		// Token: 0x06003ED5 RID: 16085 RVA: 0x0011A328 File Offset: 0x00118528
		// Note: this type is marked as 'beforefieldinit'.
		static ProfanityFilterData()
		{
			Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "ProfanityFilterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr);
			ProfanityFilterData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr, "id");
			ProfanityFilterData.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr, "content");
			ProfanityFilterData.NativeFieldInfoPtr_isRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr, "isRegex");
			ProfanityFilterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr, 100672978);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0011A3A8 File Offset: 0x001185A8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfanityFilterData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfanityFilterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfanityFilterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x000181C0 File Offset: 0x000163C0
		public ProfanityFilterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x0011A3E4 File Offset: 0x001185E4
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x000181C9 File Offset: 0x000163C9
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x0011A40C File Offset: 0x0011860C
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x000181E4 File Offset: 0x000163E4
		public unsafe string content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_content);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0011A434 File Offset: 0x00118634
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x00018203 File Offset: 0x00016403
		public unsafe bool isRegex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_isRegex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfanityFilterData.NativeFieldInfoPtr_isRegex)) = value;
			}
		}

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeFieldInfoPtr_isRegex;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
