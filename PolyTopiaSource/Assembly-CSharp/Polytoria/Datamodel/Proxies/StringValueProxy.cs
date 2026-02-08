using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F9 RID: 761
	public class StringValueProxy : ValueBaseProxy
	{
		// Token: 0x06004278 RID: 17016 RVA: 0x0012AA44 File Offset: 0x00128C44
		// Note: this type is marked as 'beforefieldinit'.
		static StringValueProxy()
		{
			Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "StringValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr);
			StringValueProxy.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr, "stringValue");
			StringValueProxy.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr, 100673801);
			StringValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr, 100673802);
			StringValueProxy.NativeMethodInfoPtr__ctor_Public_Void_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr, 100673800);
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x0012AAC4 File Offset: 0x00128CC4
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x0012AAFC File Offset: 0x00128CFC
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringValueProxy.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129039, XrefRangeEnd = 129041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0012AB40 File Offset: 0x00128D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringValueProxy(StringValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringValueProxy.NativeMethodInfoPtr__ctor_Public_Void_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00018B29 File Offset: 0x00016D29
		public StringValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x0012AB8C File Offset: 0x00128D8C
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x00018B32 File Offset: 0x00016D32
		public unsafe StringValue stringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValueProxy.NativeFieldInfoPtr_stringValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValueProxy.NativeFieldInfoPtr_stringValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeFieldInfoPtr_stringValue;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringValue_0;
	}
}
