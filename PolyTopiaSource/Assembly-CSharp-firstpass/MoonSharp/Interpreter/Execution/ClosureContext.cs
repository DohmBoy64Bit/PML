using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DF RID: 223
	public class ClosureContext : List<DynValue>
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x0005A990 File Offset: 0x00058B90
		// Note: this type is marked as 'beforefieldinit'.
		static ClosureContext()
		{
			Il2CppClassPointerStore<ClosureContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "ClosureContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr);
			ClosureContext.NativeFieldInfoPtr__Symbols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, "<Symbols>k__BackingField");
			ClosureContext.NativeMethodInfoPtr_get_Symbols_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, 100666326);
			ClosureContext.NativeMethodInfoPtr_set_Symbols_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, 100666327);
			ClosureContext.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, 100666328);
			ClosureContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, 100666329);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0005AA24 File Offset: 0x00058C24
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0005AA64 File Offset: 0x00058C64
		public unsafe Il2CppStringArray Symbols
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.NativeMethodInfoPtr_get_Symbols_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.NativeMethodInfoPtr_set_Symbols_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0005AAA8 File Offset: 0x00058CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43049, RefRangeEnd = 43050, XrefRangeStart = 43015, XrefRangeEnd = 43049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClosureContext(Il2CppReferenceArray<SymbolRef> symbols, IEnumerable<DynValue> values)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0005AB08 File Offset: 0x00058D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43060, RefRangeEnd = 43061, XrefRangeStart = 43050, XrefRangeEnd = 43060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClosureContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000070EC File Offset: 0x000052EC
		public ClosureContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0005AB44 File Offset: 0x00058D44
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x000070F5 File Offset: 0x000052F5
		public unsafe Il2CppStringArray _Symbols_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClosureContext.NativeFieldInfoPtr__Symbols_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClosureContext.NativeFieldInfoPtr__Symbols_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeFieldInfoPtr__Symbols_k__BackingField;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_get_Symbols_Public_get_Il2CppStringArray_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_set_Symbols_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x020001DE RID: 478
		[ObfuscatedName("MoonSharp.Interpreter.Execution.ClosureContext+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001CDA RID: 7386 RVA: 0x0008AE10 File Offset: 0x00089010
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClosureContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr);
				ClosureContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr, "<>9");
				ClosureContext.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr, "<>9__4_0");
				ClosureContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr, 100666331);
				ClosureContext.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_String_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr, 100666332);
			}

			// Token: 0x06001CDB RID: 7387 RVA: 0x0008AE8C File Offset: 0x0008908C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClosureContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CDC RID: 7388 RVA: 0x0008AEC8 File Offset: 0x000890C8
			[CallerCount(0)]
			public unsafe string __ctor_b__4_0(SymbolRef s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClosureContext.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_String_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001CDD RID: 7389 RVA: 0x0000B632 File Offset: 0x00009832
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0008AF10 File Offset: 0x00089110
			// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0000B63B File Offset: 0x0000983B
			public unsafe static ClosureContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClosureContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClosureContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClosureContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0008AF38 File Offset: 0x00089138
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000B64D File Offset: 0x0000984D
			public unsafe static Func<SymbolRef, string> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClosureContext.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SymbolRef, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClosureContext.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001713 RID: 5907
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_String_SymbolRef_0;
		}
	}
}
