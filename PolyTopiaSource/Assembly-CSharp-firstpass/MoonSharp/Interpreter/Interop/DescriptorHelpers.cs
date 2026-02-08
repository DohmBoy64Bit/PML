using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009B RID: 155
	public static class DescriptorHelpers : Object
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x0004728C File Offset: 0x0004548C
		// Note: this type is marked as 'beforefieldinit'.
		static DescriptorHelpers()
		{
			Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "DescriptorHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr);
			DescriptorHelpers.NativeMethodInfoPtr_GetVisibilityFromAttributes_Public_Static_Nullable_1_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665478);
			DescriptorHelpers.NativeMethodInfoPtr_IsDelegateType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665479);
			DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665480);
			DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665481);
			DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665482);
			DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665483);
			DescriptorHelpers.NativeMethodInfoPtr_IsPropertyInfoPublic_Public_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665484);
			DescriptorHelpers.NativeMethodInfoPtr_GetMetaNamesFromAttributes_Public_Static_List_1_String_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665485);
			DescriptorHelpers.NativeMethodInfoPtr_SafeGetTypes_Public_Static_Il2CppReferenceArray_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665486);
			DescriptorHelpers.NativeMethodInfoPtr_GetConversionMethodName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665487);
			DescriptorHelpers.NativeMethodInfoPtr_GetAllImplementedTypes_Public_Static_IEnumerable_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665488);
			DescriptorHelpers.NativeMethodInfoPtr_IsValidSimpleIdentifier_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665489);
			DescriptorHelpers.NativeMethodInfoPtr_ToValidSimpleIdentifier_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665490);
			DescriptorHelpers.NativeMethodInfoPtr_Camelify_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665491);
			DescriptorHelpers.NativeMethodInfoPtr_UpperFirstLetter_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, 100665492);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000473E8 File Offset: 0x000455E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 33088, RefRangeEnd = 33095, XrefRangeStart = 33074, XrefRangeEnd = 33088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<bool> GetVisibilityFromAttributes(this MemberInfo mi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetVisibilityFromAttributes_Public_Static_Nullable_1_Boolean_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0004742C File Offset: 0x0004562C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33108, RefRangeEnd = 33109, XrefRangeStart = 33095, XrefRangeEnd = 33108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDelegateType(this Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_IsDelegateType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00047470 File Offset: 0x00045670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33126, RefRangeEnd = 33128, XrefRangeStart = 33109, XrefRangeEnd = 33126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrVisibility(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000474AC File Offset: 0x000456AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33142, RefRangeEnd = 33143, XrefRangeStart = 33128, XrefRangeEnd = 33142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrVisibility(this FieldInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000474E8 File Offset: 0x000456E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33173, RefRangeEnd = 33174, XrefRangeStart = 33143, XrefRangeEnd = 33173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrVisibility(this PropertyInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00047524 File Offset: 0x00045724
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 33188, RefRangeEnd = 33192, XrefRangeStart = 33174, XrefRangeEnd = 33188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrVisibility(this MethodBase info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00047560 File Offset: 0x00045760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33192, XrefRangeEnd = 33205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPropertyInfoPublic(this PropertyInfo pi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_IsPropertyInfoPublic_Public_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000475A4 File Offset: 0x000457A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33235, RefRangeEnd = 33237, XrefRangeStart = 33205, XrefRangeEnd = 33235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetMetaNamesFromAttributes(this MethodInfo mi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetMetaNamesFromAttributes_Public_Static_List_1_String_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000475E8 File Offset: 0x000457E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33247, RefRangeEnd = 33250, XrefRangeStart = 33237, XrefRangeEnd = 33247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> SafeGetTypes(this Assembly asm)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_SafeGetTypes_Public_Static_Il2CppReferenceArray_1_Type_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0004762C File Offset: 0x0004582C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 33265, RefRangeEnd = 33270, XrefRangeStart = 33250, XrefRangeEnd = 33265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetConversionMethodName(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetConversionMethodName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00047668 File Offset: 0x00045868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33276, RefRangeEnd = 33277, XrefRangeStart = 33270, XrefRangeEnd = 33276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllImplementedTypes(this Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_GetAllImplementedTypes_Public_Static_IEnumerable_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000476AC File Offset: 0x000458AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33277, XrefRangeEnd = 33289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidSimpleIdentifier(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_IsValidSimpleIdentifier_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000476F0 File Offset: 0x000458F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33289, XrefRangeEnd = 33311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToValidSimpleIdentifier(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_ToValidSimpleIdentifier_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0004772C File Offset: 0x0004592C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 33324, RefRangeEnd = 33329, XrefRangeStart = 33311, XrefRangeEnd = 33324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Camelify(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_Camelify_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00047768 File Offset: 0x00045968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 33330, RefRangeEnd = 33335, XrefRangeStart = 33329, XrefRangeEnd = 33330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UpperFirstLetter(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.NativeMethodInfoPtr_UpperFirstLetter_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00005BC7 File Offset: 0x00003DC7
		public DescriptorHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibilityFromAttributes_Public_Static_Nullable_1_Boolean_MemberInfo_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_IsDelegateType_Public_Static_Boolean_Type_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_Type_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_FieldInfo_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_PropertyInfo_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_GetClrVisibility_Public_Static_String_MethodBase_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyInfoPublic_Public_Static_Boolean_PropertyInfo_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaNamesFromAttributes_Public_Static_List_1_String_MethodInfo_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_SafeGetTypes_Public_Static_Il2CppReferenceArray_1_Type_Assembly_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_GetConversionMethodName_Public_Static_String_Type_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_GetAllImplementedTypes_Public_Static_IEnumerable_1_Type_Type_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_IsValidSimpleIdentifier_Public_Static_Boolean_String_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_ToValidSimpleIdentifier_Public_Static_String_String_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_Camelify_Public_Static_String_String_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_UpperFirstLetter_Public_Static_String_String_0;

		// Token: 0x020001AE RID: 430
		[ObfuscatedName("MoonSharp.Interpreter.Interop.DescriptorHelpers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AD4 RID: 6868 RVA: 0x0008291C File Offset: 0x00080B1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr);
				DescriptorHelpers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr, "<>9");
				DescriptorHelpers.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr, "<>9__7_0");
				DescriptorHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr, 100665494);
				DescriptorHelpers.__c.NativeMethodInfoPtr__GetMetaNamesFromAttributes_b__7_0_Internal_String_MoonSharpUserDataMetamethodAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr, 100665495);
			}

			// Token: 0x06001AD5 RID: 6869 RVA: 0x00082998 File Offset: 0x00080B98
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriptorHelpers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD6 RID: 6870 RVA: 0x000829D4 File Offset: 0x00080BD4
			[CallerCount(0)]
			public unsafe string _GetMetaNamesFromAttributes_b__7_0(MoonSharpUserDataMetamethodAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers.__c.NativeMethodInfoPtr__GetMetaNamesFromAttributes_b__7_0_Internal_String_MoonSharpUserDataMetamethodAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001AD7 RID: 6871 RVA: 0x0000A9C0 File Offset: 0x00008BC0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00082A1C File Offset: 0x00080C1C
			// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000A9C9 File Offset: 0x00008BC9
			public unsafe static DescriptorHelpers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DescriptorHelpers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriptorHelpers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DescriptorHelpers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00082A44 File Offset: 0x00080C44
			// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000A9DB File Offset: 0x00008BDB
			public unsafe static Func<MoonSharpUserDataMetamethodAttribute, string> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DescriptorHelpers.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MoonSharpUserDataMetamethodAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DescriptorHelpers.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeMethodInfoPtr__GetMetaNamesFromAttributes_b__7_0_Internal_String_MoonSharpUserDataMetamethodAttribute_0;
		}

		// Token: 0x020001AF RID: 431
		[ObfuscatedName("MoonSharp.Interpreter.Interop.DescriptorHelpers+<GetAllImplementedTypes>d__10")]
		public sealed class _GetAllImplementedTypes_d__10 : Object
		{
			// Token: 0x06001ADC RID: 6876 RVA: 0x00082A6C File Offset: 0x00080C6C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllImplementedTypes_d__10()
			{
				Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriptorHelpers>.NativeClassPtr, "<GetAllImplementedTypes>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>1__state");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>2__current");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>l__initialThreadId");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "t");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___3__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>3__t");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr__ot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<ot>5__2");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>7__wrap2");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, "<>7__wrap3");
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665499);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665501);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665496);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665497);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665498);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665500);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665502);
				DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr, 100665503);
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001ADD RID: 6877 RVA: 0x00082BD8 File Offset: 0x00080DD8
			public unsafe Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00082C18 File Offset: 0x00080E18
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001ADF RID: 6879 RVA: 0x00082C58 File Offset: 0x00080E58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18122, XrefRangeEnd = 18124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllImplementedTypes_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriptorHelpers._GetAllImplementedTypes_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AE0 RID: 6880 RVA: 0x00082CA0 File Offset: 0x00080EA0
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE1 RID: 6881 RVA: 0x00082CD4 File Offset: 0x00080ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33047, XrefRangeEnd = 33061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AE2 RID: 6882 RVA: 0x00082D10 File Offset: 0x00080F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33061, XrefRangeEnd = 33066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE3 RID: 6883 RVA: 0x00082D44 File Offset: 0x00080F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33066, XrefRangeEnd = 33074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Type> System_Collections_Generic_IEnumerable_System_Type__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr3) : null;
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x00082D84 File Offset: 0x00080F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x0000A9ED File Offset: 0x00008BED
			public _GetAllImplementedTypes_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00082DC4 File Offset: 0x00080FC4
			// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000A9F6 File Offset: 0x00008BF6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00082DEC File Offset: 0x00080FEC
			// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0000AA11 File Offset: 0x00008C11
			public unsafe Type __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00082E1C File Offset: 0x0008101C
			// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0000AA30 File Offset: 0x00008C30
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00082E44 File Offset: 0x00081044
			// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000AA4B File Offset: 0x00008C4B
			public unsafe Type t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00082E74 File Offset: 0x00081074
			// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000AA6A File Offset: 0x00008C6A
			public unsafe Type __3__t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___3__t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___3__t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00082EA4 File Offset: 0x000810A4
			// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0000AA89 File Offset: 0x00008C89
			public unsafe Type _ot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr__ot_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr__ot_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00082ED4 File Offset: 0x000810D4
			// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000AAA8 File Offset: 0x00008CA8
			public unsafe Il2CppReferenceArray<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00082F04 File Offset: 0x00081104
			// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0000AAC7 File Offset: 0x00008CC7
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptorHelpers._GetAllImplementedTypes_d__10.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr___3__t;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeFieldInfoPtr__ot_5__2;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
