using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000047 RID: 71
	public sealed class MoonSharpHideMemberAttribute : Attribute
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x000365A8 File Offset: 0x000347A8
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpHideMemberAttribute()
		{
			Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpHideMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr);
			MoonSharpHideMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr, "<MemberName>k__BackingField");
			MoonSharpHideMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr, 100664888);
			MoonSharpHideMemberAttribute.NativeMethodInfoPtr_set_MemberName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr, 100664889);
			MoonSharpHideMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr, 100664890);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00036628 File Offset: 0x00034828
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00036660 File Offset: 0x00034860
		public unsafe string MemberName
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpHideMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpHideMemberAttribute.NativeMethodInfoPtr_set_MemberName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000366A4 File Offset: 0x000348A4
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 20486, RefRangeEnd = 20524, XrefRangeStart = 20486, XrefRangeEnd = 20524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpHideMemberAttribute(string memberName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpHideMemberAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpHideMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000041A1 File Offset: 0x000023A1
		public MoonSharpHideMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000366F0 File Offset: 0x000348F0
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000041AA File Offset: 0x000023AA
		public unsafe string _MemberName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpHideMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpHideMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr__MemberName_k__BackingField;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberName_Private_set_Void_String_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
