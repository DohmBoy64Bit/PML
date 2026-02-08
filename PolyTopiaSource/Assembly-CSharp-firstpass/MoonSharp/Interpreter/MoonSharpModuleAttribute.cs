using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000051 RID: 81
	public sealed class MoonSharpModuleAttribute : Attribute
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x0003756C File Offset: 0x0003576C
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpModuleAttribute()
		{
			Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpModuleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr);
			MoonSharpModuleAttribute.NativeFieldInfoPtr__Namespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr, "<Namespace>k__BackingField");
			MoonSharpModuleAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr, 100664939);
			MoonSharpModuleAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr, 100664940);
			MoonSharpModuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr, 100664941);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000375EC File Offset: 0x000357EC
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00037624 File Offset: 0x00035824
		public unsafe string Namespace
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00037668 File Offset: 0x00035868
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpModuleAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpModuleAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpModuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000042DC File Offset: 0x000024DC
		public MoonSharpModuleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x000376A4 File Offset: 0x000358A4
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x000042E5 File Offset: 0x000024E5
		public unsafe string _Namespace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpModuleAttribute.NativeFieldInfoPtr__Namespace_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpModuleAttribute.NativeFieldInfoPtr__Namespace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr__Namespace_k__BackingField;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
