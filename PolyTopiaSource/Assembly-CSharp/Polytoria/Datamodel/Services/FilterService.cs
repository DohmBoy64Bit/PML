using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C8 RID: 712
	public class FilterService : MonoBehaviour
	{
		// Token: 0x06003EDE RID: 16094 RVA: 0x0011A45C File Offset: 0x0011865C
		// Note: this type is marked as 'beforefieldinit'.
		static FilterService()
		{
			Il2CppClassPointerStore<FilterService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "FilterService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterService>.NativeClassPtr);
			FilterService.NativeFieldInfoPtr__FailedToLoad_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "<FailedToLoad>k__BackingField");
			FilterService.NativeFieldInfoPtr_filtersCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "filtersCache");
			FilterService.NativeFieldInfoPtr_regexCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "regexCache");
			FilterService.NativeFieldInfoPtr_literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "literals");
			FilterService.NativeFieldInfoPtr_combinedRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "combinedRegex");
			FilterService.NativeMethodInfoPtr_get_FailedToLoad_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672979);
			FilterService.NativeMethodInfoPtr_set_FailedToLoad_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672980);
			FilterService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672987);
			FilterService.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672981);
			FilterService.NativeMethodInfoPtr_LoadFilter_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672982);
			FilterService.NativeMethodInfoPtr_ParseFilters_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672983);
			FilterService.NativeMethodInfoPtr_GetCompiledRegex_Private_Static_Regex_ProfanityFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672984);
			FilterService.NativeMethodInfoPtr_RebuildHelpers_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672985);
			FilterService.NativeMethodInfoPtr_Filter_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService>.NativeClassPtr, 100672986);
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x0011A5A4 File Offset: 0x001187A4
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x0011A5D4 File Offset: 0x001187D4
		public unsafe static bool FailedToLoad
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124630, XrefRangeEnd = 124634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_get_FailedToLoad_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124634, XrefRangeEnd = 124638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_set_FailedToLoad_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0011A608 File Offset: 0x00118808
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0011A644 File Offset: 0x00118844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124638, XrefRangeEnd = 124674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0011A678 File Offset: 0x00118878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124674, XrefRangeEnd = 124678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_LoadFilter_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0011A6B8 File Offset: 0x001188B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124711, RefRangeEnd = 124712, XrefRangeStart = 124678, XrefRangeEnd = 124711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseFilters(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_ParseFilters_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0011A6F0 File Offset: 0x001188F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124743, RefRangeEnd = 124744, XrefRangeStart = 124712, XrefRangeEnd = 124743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Regex GetCompiledRegex(ProfanityFilterData filter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_GetCompiledRegex_Private_Static_Regex_ProfanityFilterData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr3) : null;
			}
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0011A734 File Offset: 0x00118934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124800, RefRangeEnd = 124801, XrefRangeStart = 124744, XrefRangeEnd = 124800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildHelpers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_RebuildHelpers_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0011A75C File Offset: 0x0011895C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124848, RefRangeEnd = 124850, XrefRangeStart = 124801, XrefRangeEnd = 124848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Filter(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.NativeMethodInfoPtr_Filter_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0001821E File Offset: 0x0001641E
		public FilterService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x0011A798 File Offset: 0x00118998
		// (set) Token: 0x06003EEA RID: 16106 RVA: 0x00018227 File Offset: 0x00016427
		public unsafe static bool _FailedToLoad_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FilterService.NativeFieldInfoPtr__FailedToLoad_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterService.NativeFieldInfoPtr__FailedToLoad_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x0011A7B4 File Offset: 0x001189B4
		// (set) Token: 0x06003EEC RID: 16108 RVA: 0x00018235 File Offset: 0x00016435
		public unsafe static List<ProfanityFilterData> filtersCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterService.NativeFieldInfoPtr_filtersCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProfanityFilterData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterService.NativeFieldInfoPtr_filtersCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06003EED RID: 16109 RVA: 0x0011A7DC File Offset: 0x001189DC
		// (set) Token: 0x06003EEE RID: 16110 RVA: 0x00018247 File Offset: 0x00016447
		public unsafe static Dictionary<string, Regex> regexCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterService.NativeFieldInfoPtr_regexCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Regex>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterService.NativeFieldInfoPtr_regexCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x0011A804 File Offset: 0x00118A04
		// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x00018259 File Offset: 0x00016459
		public unsafe static HashSet<string> literals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterService.NativeFieldInfoPtr_literals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterService.NativeFieldInfoPtr_literals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x0011A82C File Offset: 0x00118A2C
		// (set) Token: 0x06003EF2 RID: 16114 RVA: 0x0001826B File Offset: 0x0001646B
		public unsafe static Regex combinedRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterService.NativeFieldInfoPtr_combinedRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterService.NativeFieldInfoPtr_combinedRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeFieldInfoPtr__FailedToLoad_k__BackingField;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeFieldInfoPtr_filtersCache;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeFieldInfoPtr_regexCache;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeFieldInfoPtr_literals;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeFieldInfoPtr_combinedRegex;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr_get_FailedToLoad_Public_Static_get_Boolean_0;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeMethodInfoPtr_set_FailedToLoad_Private_Static_set_Void_Boolean_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeMethodInfoPtr_LoadFilter_Private_IEnumerator_0;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr_ParseFilters_Private_Static_Void_String_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr_GetCompiledRegex_Private_Static_Regex_ProfanityFilterData_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr_RebuildHelpers_Private_Static_Void_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Static_String_String_0;

		// Token: 0x0200040F RID: 1039
		[ObfuscatedName("Polytoria.Datamodel.Services.FilterService+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004F70 RID: 20336 RVA: 0x0015624C File Offset: 0x0015444C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr);
				FilterService.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, "<>9");
				FilterService.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, "<>9__13_0");
				FilterService.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, "<>9__13_1");
				FilterService.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, 100672990);
				FilterService.__c.NativeMethodInfoPtr__Filter_b__13_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, 100672991);
				FilterService.__c.NativeMethodInfoPtr__Filter_b__13_1_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr, 100672992);
			}

			// Token: 0x06004F71 RID: 20337 RVA: 0x001562F0 File Offset: 0x001544F0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterService.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F72 RID: 20338 RVA: 0x0015632C File Offset: 0x0015452C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124556, XrefRangeEnd = 124568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Filter_b__13_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.__c.NativeMethodInfoPtr__Filter_b__13_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F73 RID: 20339 RVA: 0x00156374 File Offset: 0x00154574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124568, XrefRangeEnd = 124570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Filter_b__13_1(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService.__c.NativeMethodInfoPtr__Filter_b__13_1_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F74 RID: 20340 RVA: 0x0001E506 File Offset: 0x0001C706
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ACA RID: 6858
			// (get) Token: 0x06004F75 RID: 20341 RVA: 0x001563BC File Offset: 0x001545BC
			// (set) Token: 0x06004F76 RID: 20342 RVA: 0x0001E50F File Offset: 0x0001C70F
			public unsafe static FilterService.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterService.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterService.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterService.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ACB RID: 6859
			// (get) Token: 0x06004F77 RID: 20343 RVA: 0x001563E4 File Offset: 0x001545E4
			// (set) Token: 0x06004F78 RID: 20344 RVA: 0x0001E521 File Offset: 0x0001C721
			public unsafe static MatchEvaluator __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterService.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterService.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ACC RID: 6860
			// (get) Token: 0x06004F79 RID: 20345 RVA: 0x0015640C File Offset: 0x0015460C
			// (set) Token: 0x06004F7A RID: 20346 RVA: 0x0001E533 File Offset: 0x0001C733
			public unsafe static MatchEvaluator __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterService.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterService.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D55 RID: 15701
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003D56 RID: 15702
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04003D57 RID: 15703
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04003D58 RID: 15704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D59 RID: 15705
			private static readonly IntPtr NativeMethodInfoPtr__Filter_b__13_0_Internal_String_Match_0;

			// Token: 0x04003D5A RID: 15706
			private static readonly IntPtr NativeMethodInfoPtr__Filter_b__13_1_Internal_String_Match_0;
		}

		// Token: 0x02000410 RID: 1040
		[ObfuscatedName("Polytoria.Datamodel.Services.FilterService+<LoadFilter>d__9")]
		public sealed class _LoadFilter_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F7B RID: 20347 RVA: 0x00156434 File Offset: 0x00154634
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadFilter_d__9()
			{
				Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterService>.NativeClassPtr, "<LoadFilter>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr);
				FilterService._LoadFilter_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, "<>1__state");
				FilterService._LoadFilter_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, "<>2__current");
				FilterService._LoadFilter_d__9.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, "<uwr>5__2");
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672997);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672999);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672993);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672994);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672995);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672996);
				FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr, 100672998);
			}

			// Token: 0x17001AD0 RID: 6864
			// (get) Token: 0x06004F7C RID: 20348 RVA: 0x00156528 File Offset: 0x00154728
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001AD1 RID: 6865
			// (get) Token: 0x06004F7D RID: 20349 RVA: 0x00156568 File Offset: 0x00154768
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F7E RID: 20350 RVA: 0x001565A8 File Offset: 0x001547A8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadFilter_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterService._LoadFilter_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F7F RID: 20351 RVA: 0x001565F0 File Offset: 0x001547F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124570, XrefRangeEnd = 124575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F80 RID: 20352 RVA: 0x00156624 File Offset: 0x00154824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124575, XrefRangeEnd = 124622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F81 RID: 20353 RVA: 0x00156660 File Offset: 0x00154860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124622, XrefRangeEnd = 124625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F82 RID: 20354 RVA: 0x00156694 File Offset: 0x00154894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124625, XrefRangeEnd = 124630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterService._LoadFilter_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F83 RID: 20355 RVA: 0x0001E545 File Offset: 0x0001C745
			public _LoadFilter_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ACD RID: 6861
			// (get) Token: 0x06004F84 RID: 20356 RVA: 0x001566C8 File Offset: 0x001548C8
			// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0001E54E File Offset: 0x0001C74E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ACE RID: 6862
			// (get) Token: 0x06004F86 RID: 20358 RVA: 0x001566F0 File Offset: 0x001548F0
			// (set) Token: 0x06004F87 RID: 20359 RVA: 0x0001E569 File Offset: 0x0001C769
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ACF RID: 6863
			// (get) Token: 0x06004F88 RID: 20360 RVA: 0x00156720 File Offset: 0x00154920
			// (set) Token: 0x06004F89 RID: 20361 RVA: 0x0001E588 File Offset: 0x0001C788
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterService._LoadFilter_d__9.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D5B RID: 15707
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D5C RID: 15708
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D5D RID: 15709
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D5E RID: 15710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D5F RID: 15711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D60 RID: 15712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D61 RID: 15713
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D62 RID: 15714
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D63 RID: 15715
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D64 RID: 15716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
