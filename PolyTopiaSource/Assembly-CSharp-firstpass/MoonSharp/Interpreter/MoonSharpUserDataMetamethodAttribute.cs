using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004A RID: 74
	public sealed class MoonSharpUserDataMetamethodAttribute : Attribute
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00036A48 File Offset: 0x00034C48
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpUserDataMetamethodAttribute()
		{
			Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpUserDataMetamethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr);
			MoonSharpUserDataMetamethodAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr, "<Name>k__BackingField");
			MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr, 100664898);
			MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr, 100664899);
			MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr, 100664900);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00036AC8 File Offset: 0x00034CC8
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00036B00 File Offset: 0x00034D00
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00036B44 File Offset: 0x00034D44
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 20486, RefRangeEnd = 20524, XrefRangeStart = 20486, XrefRangeEnd = 20524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpUserDataMetamethodAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpUserDataMetamethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataMetamethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00004219 File Offset: 0x00002419
		public MoonSharpUserDataMetamethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00036B90 File Offset: 0x00034D90
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00004222 File Offset: 0x00002422
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpUserDataMetamethodAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpUserDataMetamethodAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
