using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000126 RID: 294
	public class FrameworkCurrent : FrameworkClrBase
	{
		// Token: 0x060015B6 RID: 5558 RVA: 0x00070ED4 File Offset: 0x0006F0D4
		// Note: this type is marked as 'beforefieldinit'.
		static FrameworkCurrent()
		{
			Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Compatibility.Frameworks", "FrameworkCurrent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr);
			FrameworkCurrent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr, 100667184);
			FrameworkCurrent.NativeMethodInfoPtr_GetTypeInfoFromType_Public_Virtual_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr, 100667180);
			FrameworkCurrent.NativeMethodInfoPtr_IsDbNull_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr, 100667181);
			FrameworkCurrent.NativeMethodInfoPtr_StringContainsChar_Public_Virtual_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr, 100667182);
			FrameworkCurrent.NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr, 100667183);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00070F68 File Offset: 0x0006F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameworkCurrent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameworkCurrent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkCurrent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		[CallerCount(0)]
		public unsafe override Type GetTypeInfoFromType(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkCurrent.NativeMethodInfoPtr_GetTypeInfoFromType_Public_Virtual_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00071000 File Offset: 0x0006F200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51726, XrefRangeEnd = 51727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDbNull(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkCurrent.NativeMethodInfoPtr_IsDbNull_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00071058 File Offset: 0x0006F258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51727, XrefRangeEnd = 51729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StringContainsChar(string str, char chr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkCurrent.NativeMethodInfoPtr_StringContainsChar_Public_Virtual_Boolean_String_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000710C0 File Offset: 0x0006F2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51729, XrefRangeEnd = 51731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetInterface(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FrameworkCurrent.NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000084D0 File Offset: 0x000066D0
		public FrameworkCurrent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfoFromType_Public_Virtual_Type_Type_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_IsDbNull_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_StringContainsChar_Public_Virtual_Boolean_String_Char_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_Type_String_0;
	}
}
