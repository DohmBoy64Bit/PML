using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000053 RID: 83
	public sealed class MoonSharpModuleMethodAttribute : Attribute
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x0003782C File Offset: 0x00035A2C
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpModuleMethodAttribute()
		{
			Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpModuleMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr);
			MoonSharpModuleMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr, "<Name>k__BackingField");
			MoonSharpModuleMethodAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr, 100664945);
			MoonSharpModuleMethodAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr, 100664946);
			MoonSharpModuleMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr, 100664947);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000378AC File Offset: 0x00035AAC
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000378E4 File Offset: 0x00035AE4
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleMethodAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleMethodAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00037928 File Offset: 0x00035B28
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpModuleMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpModuleMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0000432C File Offset: 0x0000252C
		public MoonSharpModuleMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00037964 File Offset: 0x00035B64
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004335 File Offset: 0x00002535
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpModuleMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpModuleMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
