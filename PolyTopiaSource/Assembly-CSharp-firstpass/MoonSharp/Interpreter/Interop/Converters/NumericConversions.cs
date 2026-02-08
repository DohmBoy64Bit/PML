using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D0 RID: 208
	public static class NumericConversions : Object
	{
		// Token: 0x06001015 RID: 4117 RVA: 0x00056EC4 File Offset: 0x000550C4
		// Note: this type is marked as 'beforefieldinit'.
		static NumericConversions()
		{
			Il2CppClassPointerStore<NumericConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.Converters", "NumericConversions");
			NumericConversions.NativeFieldInfoPtr_NumericTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericConversions>.NativeClassPtr, "NumericTypes");
			NumericConversions.NativeFieldInfoPtr_NumericTypesOrdered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericConversions>.NativeClassPtr, "NumericTypesOrdered");
			NumericConversions.NativeMethodInfoPtr_DoubleToType_Internal_Static_Object_Type_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConversions>.NativeClassPtr, 100666191);
			NumericConversions.NativeMethodInfoPtr_TypeToDouble_Internal_Static_Double_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConversions>.NativeClassPtr, 100666192);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00056F3C File Offset: 0x0005513C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41484, RefRangeEnd = 41486, XrefRangeStart = 41362, XrefRangeEnd = 41484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DoubleToType(Type type, double d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConversions.NativeMethodInfoPtr_DoubleToType_Internal_Static_Object_Type_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00056F90 File Offset: 0x00055190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41546, RefRangeEnd = 41548, XrefRangeStart = 41486, XrefRangeEnd = 41546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double TypeToDouble(Type type, Object d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConversions.NativeMethodInfoPtr_TypeToDouble_Internal_Static_Double_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00006C64 File Offset: 0x00004E64
		public NumericConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x00056FE4 File Offset: 0x000551E4
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x00006C6D File Offset: 0x00004E6D
		public unsafe static HashSet<Type> NumericTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumericConversions.NativeFieldInfoPtr_NumericTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumericConversions.NativeFieldInfoPtr_NumericTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0005700C File Offset: 0x0005520C
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00006C7F File Offset: 0x00004E7F
		public unsafe static Il2CppReferenceArray<Type> NumericTypesOrdered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumericConversions.NativeFieldInfoPtr_NumericTypesOrdered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumericConversions.NativeFieldInfoPtr_NumericTypesOrdered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_NumericTypes;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_NumericTypesOrdered;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToType_Internal_Static_Object_Type_Double_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_TypeToDouble_Internal_Static_Double_Type_Object_0;
	}
}
