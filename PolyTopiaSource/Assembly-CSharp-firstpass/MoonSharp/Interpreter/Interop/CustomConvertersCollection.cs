using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009A RID: 154
	public class CustomConvertersCollection : Object
	{
		// Token: 0x06000C8B RID: 3211 RVA: 0x00046E0C File Offset: 0x0004500C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomConvertersCollection()
		{
			Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "CustomConvertersCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr);
			CustomConvertersCollection.NativeFieldInfoPtr_m_Script2Clr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "m_Script2Clr");
			CustomConvertersCollection.NativeFieldInfoPtr_m_Clr2Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "m_Clr2Script");
			CustomConvertersCollection.NativeFieldInfoPtr_m_conversionPredicates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "m_conversionPredicates");
			CustomConvertersCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665463);
			CustomConvertersCollection.NativeMethodInfoPtr_SetScriptToClrCustomConversion_Public_Void_DataType_Type_Func_2_DynValue_Object_Func_2_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665464);
			CustomConvertersCollection.NativeMethodInfoPtr_GetScriptToClrCustomConversion_Public_Func_2_DynValue_Object_DynValue_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665465);
			CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_3_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665466);
			CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_3_Script_T_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665467);
			CustomConvertersCollection.NativeMethodInfoPtr_GetClrToScriptCustomConversion_Public_Func_3_Script_Object_DynValue_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665468);
			CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_2_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665469);
			CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_2_T_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665470);
			CustomConvertersCollection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, 100665471);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00046F2C File Offset: 0x0004512C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32996, RefRangeEnd = 32997, XrefRangeStart = 32968, XrefRangeEnd = 32996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomConvertersCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00046F68 File Offset: 0x00045168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32997, XrefRangeEnd = 33006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, Func<DynValue, Object> converter = null, Func<DynValue, bool> canConvert = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptDataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrDataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canConvert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_SetScriptToClrCustomConversion_Public_Void_DataType_Type_Func_2_DynValue_Object_Func_2_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00046FE4 File Offset: 0x000451E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33012, RefRangeEnd = 33015, XrefRangeStart = 33006, XrefRangeEnd = 33012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<DynValue, Object> GetScriptToClrCustomConversion(DynValue scriptValue, Type clrDataType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrDataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_GetScriptToClrCustomConversion_Public_Func_2_DynValue_Object_DynValue_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr3) : null;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00047048 File Offset: 0x00045248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33015, XrefRangeEnd = 33020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClrToScriptCustomConversion(Type clrDataType, Func<Script, Object, DynValue> converter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clrDataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_3_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0004709C File Offset: 0x0004529C
		[CallerCount(0)]
		public unsafe void SetClrToScriptCustomConversion<T>(Func<Script, T, DynValue> converter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.MethodInfoStoreGeneric_SetClrToScriptCustomConversion_Public_Void_Func_3_Script_T_DynValue_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000470E0 File Offset: 0x000452E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33023, RefRangeEnd = 33024, XrefRangeStart = 33020, XrefRangeEnd = 33023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Script, Object, DynValue> GetClrToScriptCustomConversion(Type clrDataType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clrDataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_GetClrToScriptCustomConversion_Public_Func_3_Script_Object_DynValue_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Script, Object, DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00047130 File Offset: 0x00045330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33024, XrefRangeEnd = 33040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClrToScriptCustomConversion(Type clrDataType, Func<Object, DynValue> converter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clrDataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_2_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00047184 File Offset: 0x00045384
		[CallerCount(0)]
		public unsafe void SetClrToScriptCustomConversion<T>(Func<T, DynValue> converter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.MethodInfoStoreGeneric_SetClrToScriptCustomConversion_Public_Void_Func_2_T_DynValue_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000471C8 File Offset: 0x000453C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33040, XrefRangeEnd = 33047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00005B61 File Offset: 0x00003D61
		public CustomConvertersCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000471FC File Offset: 0x000453FC
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00005B6A File Offset: 0x00003D6A
		public unsafe Il2CppReferenceArray<ConcurrentDictionary<Type, Func<DynValue, Object>>> m_Script2Clr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_Script2Clr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<Type, Func<DynValue, Object>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_Script2Clr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0004722C File Offset: 0x0004542C
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00005B89 File Offset: 0x00003D89
		public unsafe ConcurrentDictionary<Type, Func<Script, Object, DynValue>> m_Clr2Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_Clr2Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, Func<Script, Object, DynValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_Clr2Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0004725C File Offset: 0x0004545C
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public unsafe ConcurrentDictionary<Type, Func<DynValue, bool>> m_conversionPredicates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_conversionPredicates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, Func<DynValue, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.NativeFieldInfoPtr_m_conversionPredicates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_m_Script2Clr;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_m_Clr2Script;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_m_conversionPredicates;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptToClrCustomConversion_Public_Void_DataType_Type_Func_2_DynValue_Object_Func_2_DynValue_Boolean_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptToClrCustomConversion_Public_Func_2_DynValue_Object_DynValue_Type_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_3_Script_Object_DynValue_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_3_Script_T_DynValue_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_GetClrToScriptCustomConversion_Public_Func_3_Script_Object_DynValue_Type_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Type_Func_2_Object_DynValue_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_2_T_DynValue_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x020001A9 RID: 425
		[ObfuscatedName("MoonSharp.Interpreter.Interop.CustomConvertersCollection+<>c__DisplayClass10_0`1")]
		public sealed class __c__DisplayClass10_0<T> : Object
		{
			// Token: 0x06001AC0 RID: 6848 RVA: 0x00082468 File Offset: 0x00080668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "<>c__DisplayClass10_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr);
				CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr, "converter");
				CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr, 100665472);
				CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr, 100665473);
			}

			// Token: 0x06001AC1 RID: 6849 RVA: 0x0008250C File Offset: 0x0008070C
			[CallerCount(0)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass10_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC2 RID: 6850 RVA: 0x00082548 File Offset: 0x00080748
			[CallerCount(0)]
			public unsafe DynValue _SetClrToScriptCustomConversion_b__0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001AC3 RID: 6851 RVA: 0x0000A948 File Offset: 0x00008B48
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00082598 File Offset: 0x00080798
			// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000A951 File Offset: 0x00008B51
			public unsafe Func<T, DynValue> converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeFieldInfoPtr_converter;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Object_0;
		}

		// Token: 0x020001AA RID: 426
		[ObfuscatedName("MoonSharp.Interpreter.Interop.CustomConvertersCollection+<>c__DisplayClass7_0`1")]
		public sealed class __c__DisplayClass7_0<T> : Object
		{
			// Token: 0x06001AC6 RID: 6854 RVA: 0x000825C8 File Offset: 0x000807C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "<>c__DisplayClass7_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr);
				CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr, "converter");
				CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr, 100665474);
				CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr, 100665475);
			}

			// Token: 0x06001AC7 RID: 6855 RVA: 0x0008266C File Offset: 0x0008086C
			[CallerCount(0)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass7_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x000826A8 File Offset: 0x000808A8
			[CallerCount(0)]
			public unsafe DynValue _SetClrToScriptCustomConversion_b__0(Script s, Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001AC9 RID: 6857 RVA: 0x0000A970 File Offset: 0x00008B70
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0008270C File Offset: 0x0008090C
			// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0000A979 File Offset: 0x00008B79
			public unsafe Func<Script, T, DynValue> converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Script, T, DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr_converter;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0;
		}

		// Token: 0x020001AB RID: 427
		[ObfuscatedName("MoonSharp.Interpreter.Interop.CustomConvertersCollection+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06001ACC RID: 6860 RVA: 0x0008273C File Offset: 0x0008093C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr);
				CustomConvertersCollection.__c__DisplayClass9_0.NativeFieldInfoPtr_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr, "converter");
				CustomConvertersCollection.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr, 100665476);
				CustomConvertersCollection.__c__DisplayClass9_0.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr, 100665477);
			}

			// Token: 0x06001ACD RID: 6861 RVA: 0x000827A4 File Offset: 0x000809A4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConvertersCollection.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ACE RID: 6862 RVA: 0x000827E0 File Offset: 0x000809E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32939, XrefRangeEnd = 32968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _SetClrToScriptCustomConversion_b__0(Script s, Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConvertersCollection.__c__DisplayClass9_0.NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001ACF RID: 6863 RVA: 0x0000A998 File Offset: 0x00008B98
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00082844 File Offset: 0x00080A44
			// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000A9A1 File Offset: 0x00008BA1
			public unsafe Func<Object, DynValue> converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass9_0.NativeFieldInfoPtr_converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomConvertersCollection.__c__DisplayClass9_0.NativeFieldInfoPtr_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeFieldInfoPtr_converter;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeMethodInfoPtr__SetClrToScriptCustomConversion_b__0_Internal_DynValue_Script_Object_0;
		}

		// Token: 0x020001AC RID: 428
		private sealed class MethodInfoStoreGeneric_SetClrToScriptCustomConversion_Public_Void_Func_3_Script_T_DynValue_0<T>
		{
			// Token: 0x040015E3 RID: 5603
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_3_Script_T_DynValue_0, Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AD RID: 429
		private sealed class MethodInfoStoreGeneric_SetClrToScriptCustomConversion_Public_Void_Func_2_T_DynValue_0<T>
		{
			// Token: 0x040015E4 RID: 5604
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomConvertersCollection.NativeMethodInfoPtr_SetClrToScriptCustomConversion_Public_Void_Func_2_T_DynValue_0, Il2CppClassPointerStore<CustomConvertersCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
