using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200024B RID: 587
	public class PropertyGridTemplate : MonoBehaviour
	{
		// Token: 0x06002DB8 RID: 11704 RVA: 0x000D4B9C File Offset: 0x000D2D9C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridTemplate()
		{
			Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr);
			PropertyGridTemplate.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr, "type");
			PropertyGridTemplate.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr, 100670193);
			PropertyGridTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr, 100670194);
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x000D4C08 File Offset: 0x000D2E08
		public unsafe string Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridTemplate.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000D4C40 File Offset: 0x000D2E40
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridTemplate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridTemplate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00012373 File Offset: 0x00010573
		public PropertyGridTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x000D4C7C File Offset: 0x000D2E7C
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x0001237C File Offset: 0x0001057C
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridTemplate.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridTemplate.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
