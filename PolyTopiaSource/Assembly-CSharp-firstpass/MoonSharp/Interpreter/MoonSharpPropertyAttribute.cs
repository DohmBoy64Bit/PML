using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000048 RID: 72
	public sealed class MoonSharpPropertyAttribute : Attribute
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x00036718 File Offset: 0x00034918
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpPropertyAttribute()
		{
			Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr);
			MoonSharpPropertyAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr, "<Name>k__BackingField");
			MoonSharpPropertyAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr, 100664891);
			MoonSharpPropertyAttribute.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr, 100664892);
			MoonSharpPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr, 100664893);
			MoonSharpPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr, 100664894);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000367AC File Offset: 0x000349AC
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000367E4 File Offset: 0x000349E4
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpPropertyAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpPropertyAttribute.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00036828 File Offset: 0x00034A28
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00036864 File Offset: 0x00034A64
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 20486, RefRangeEnd = 20524, XrefRangeStart = 20486, XrefRangeEnd = 20524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpPropertyAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000041C9 File Offset: 0x000023C9
		public MoonSharpPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000368B0 File Offset: 0x00034AB0
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000041D2 File Offset: 0x000023D2
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpPropertyAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpPropertyAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
