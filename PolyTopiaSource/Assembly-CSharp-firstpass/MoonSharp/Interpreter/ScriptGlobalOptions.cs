using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000058 RID: 88
	public class ScriptGlobalOptions : Object
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x00038F20 File Offset: 0x00037120
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptGlobalOptions()
		{
			Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptGlobalOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr);
			ScriptGlobalOptions.NativeFieldInfoPtr__CustomConverters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<CustomConverters>k__BackingField");
			ScriptGlobalOptions.NativeFieldInfoPtr__Platform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<Platform>k__BackingField");
			ScriptGlobalOptions.NativeFieldInfoPtr__RethrowExceptionNested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<RethrowExceptionNested>k__BackingField");
			ScriptGlobalOptions.NativeFieldInfoPtr__FuzzySymbolMatching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<FuzzySymbolMatching>k__BackingField");
			ScriptGlobalOptions.NativeFieldInfoPtr__ShouldPCallCatchException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<ShouldPCallCatchException>k__BackingField");
			ScriptGlobalOptions.NativeMethodInfoPtr_get_CustomConverters_Public_get_CustomConvertersCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665001);
			ScriptGlobalOptions.NativeMethodInfoPtr_set_CustomConverters_Public_set_Void_CustomConvertersCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665002);
			ScriptGlobalOptions.NativeMethodInfoPtr_get_Platform_Public_get_IPlatformAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665003);
			ScriptGlobalOptions.NativeMethodInfoPtr_set_Platform_Public_set_Void_IPlatformAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665004);
			ScriptGlobalOptions.NativeMethodInfoPtr_get_RethrowExceptionNested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665005);
			ScriptGlobalOptions.NativeMethodInfoPtr_set_RethrowExceptionNested_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665006);
			ScriptGlobalOptions.NativeMethodInfoPtr_get_FuzzySymbolMatching_Public_get_FuzzySymbolMatchingBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665007);
			ScriptGlobalOptions.NativeMethodInfoPtr_set_FuzzySymbolMatching_Public_set_Void_FuzzySymbolMatchingBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665008);
			ScriptGlobalOptions.NativeMethodInfoPtr_get_ShouldPCallCatchException_Public_get_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665009);
			ScriptGlobalOptions.NativeMethodInfoPtr_set_ShouldPCallCatchException_Public_set_Void_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665010);
			ScriptGlobalOptions.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, 100665000);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00039090 File Offset: 0x00037290
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000390D0 File Offset: 0x000372D0
		public unsafe CustomConvertersCollection CustomConverters
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_get_CustomConverters_Public_get_CustomConvertersCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomConvertersCollection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_set_CustomConverters_Public_set_Void_CustomConvertersCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00039114 File Offset: 0x00037314
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00039154 File Offset: 0x00037354
		public unsafe IPlatformAccessor Platform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_get_Platform_Public_get_IPlatformAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlatformAccessor>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_set_Platform_Public_set_Void_IPlatformAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00039198 File Offset: 0x00037398
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x000391D4 File Offset: 0x000373D4
		public unsafe bool RethrowExceptionNested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_get_RethrowExceptionNested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_set_RethrowExceptionNested_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00039214 File Offset: 0x00037414
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00039254 File Offset: 0x00037454
		public unsafe FuzzySymbolMatchingBehavior FuzzySymbolMatching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_get_FuzzySymbolMatching_Public_get_FuzzySymbolMatchingBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FuzzySymbolMatchingBehavior>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_set_FuzzySymbolMatching_Public_set_Void_FuzzySymbolMatchingBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00039298 File Offset: 0x00037498
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000392D8 File Offset: 0x000374D8
		public unsafe Func<Exception, bool> ShouldPCallCatchException
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_get_ShouldPCallCatchException_Public_get_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr_set_ShouldPCallCatchException_Public_set_Void_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003931C File Offset: 0x0003751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28388, XrefRangeEnd = 28412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptGlobalOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00004517 File Offset: 0x00002717
		public ScriptGlobalOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00039358 File Offset: 0x00037558
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00004520 File Offset: 0x00002720
		public unsafe CustomConvertersCollection _CustomConverters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__CustomConverters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomConvertersCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__CustomConverters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00039388 File Offset: 0x00037588
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0000453F File Offset: 0x0000273F
		public unsafe IPlatformAccessor _Platform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__Platform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlatformAccessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__Platform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000393B8 File Offset: 0x000375B8
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0000455E File Offset: 0x0000275E
		public unsafe bool _RethrowExceptionNested_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__RethrowExceptionNested_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__RethrowExceptionNested_k__BackingField)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x000393E0 File Offset: 0x000375E0
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00004579 File Offset: 0x00002779
		public unsafe FuzzySymbolMatchingBehavior _FuzzySymbolMatching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__FuzzySymbolMatching_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FuzzySymbolMatchingBehavior>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__FuzzySymbolMatching_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00039410 File Offset: 0x00037610
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00004598 File Offset: 0x00002798
		public unsafe Func<Exception, bool> _ShouldPCallCatchException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__ShouldPCallCatchException_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGlobalOptions.NativeFieldInfoPtr__ShouldPCallCatchException_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr__CustomConverters_k__BackingField;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr__Platform_k__BackingField;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr__RethrowExceptionNested_k__BackingField;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr__FuzzySymbolMatching_k__BackingField;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr__ShouldPCallCatchException_k__BackingField;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomConverters_Public_get_CustomConvertersCollection_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_set_CustomConverters_Public_set_Void_CustomConvertersCollection_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Public_get_IPlatformAccessor_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_set_Platform_Public_set_Void_IPlatformAccessor_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_RethrowExceptionNested_Public_get_Boolean_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_RethrowExceptionNested_Public_set_Void_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_FuzzySymbolMatching_Public_get_FuzzySymbolMatchingBehavior_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_FuzzySymbolMatching_Public_set_Void_FuzzySymbolMatchingBehavior_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldPCallCatchException_Public_get_Func_2_Exception_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldPCallCatchException_Public_set_Void_Func_2_Exception_Boolean_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0200019F RID: 415
		[ObfuscatedName("MoonSharp.Interpreter.ScriptGlobalOptions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A6A RID: 6762 RVA: 0x00081618 File Offset: 0x0007F818
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptGlobalOptions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr);
				ScriptGlobalOptions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr, "<>9");
				ScriptGlobalOptions.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr, "<>9__0_0");
				ScriptGlobalOptions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr, 100665012);
				ScriptGlobalOptions.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr, 100665013);
			}

			// Token: 0x06001A6B RID: 6763 RVA: 0x00081694 File Offset: 0x0007F894
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptGlobalOptions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A6C RID: 6764 RVA: 0x000816D0 File Offset: 0x0007F8D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0_0(Exception _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGlobalOptions.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A6D RID: 6765 RVA: 0x0000A699 File Offset: 0x00008899
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00081720 File Offset: 0x0007F920
			// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0000A6A2 File Offset: 0x000088A2
			public unsafe static ScriptGlobalOptions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptGlobalOptions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptGlobalOptions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptGlobalOptions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00081748 File Offset: 0x0007F948
			// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000A6B4 File Offset: 0x000088B4
			public unsafe static Func<Exception, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptGlobalOptions.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptGlobalOptions.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Exception_0;
		}
	}
}
