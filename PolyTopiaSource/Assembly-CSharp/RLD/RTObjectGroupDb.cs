using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000194 RID: 404
	public class RTObjectGroupDb : MonoSingleton<RTObjectGroupDb>
	{
		// Token: 0x06001F41 RID: 8001 RVA: 0x0009DFBC File Offset: 0x0009C1BC
		// Note: this type is marked as 'beforefieldinit'.
		static RTObjectGroupDb()
		{
			Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTObjectGroupDb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr);
			RTObjectGroupDb.NativeFieldInfoPtr__objectGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, "_objectGroups");
			RTObjectGroupDb.NativeMethodInfoPtr_get_NumGroups_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668052);
			RTObjectGroupDb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668062);
			RTObjectGroupDb.NativeMethodInfoPtr_Add_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668053);
			RTObjectGroupDb.NativeMethodInfoPtr_Remove_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668054);
			RTObjectGroupDb.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668055);
			RTObjectGroupDb.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668056);
			RTObjectGroupDb.NativeMethodInfoPtr_IsGroup_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668057);
			RTObjectGroupDb.NativeMethodInfoPtr_GetGroupByIndex_Public_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668058);
			RTObjectGroupDb.NativeMethodInfoPtr_GetGroupByName_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668059);
			RTObjectGroupDb.NativeMethodInfoPtr_GetAll_Public_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668060);
			RTObjectGroupDb.NativeMethodInfoPtr_RemoveNullRefs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, 100668061);
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0009E0DC File Offset: 0x0009C2DC
		public unsafe int NumGroups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83289, XrefRangeEnd = 83290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_get_NumGroups_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0009E118 File Offset: 0x0009C318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83290, XrefRangeEnd = 83303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTObjectGroupDb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0009E154 File Offset: 0x0009C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83303, XrefRangeEnd = 83309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_Add_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0009E198 File Offset: 0x0009C398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83309, XrefRangeEnd = 83313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_Remove_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0009E1DC File Offset: 0x0009C3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83313, XrefRangeEnd = 83317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0009E21C File Offset: 0x0009C41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83317, XrefRangeEnd = 83319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0009E250 File Offset: 0x0009C450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83323, RefRangeEnd = 83326, XrefRangeStart = 83319, XrefRangeEnd = 83323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroup(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_IsGroup_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0009E2A0 File Offset: 0x0009C4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83326, XrefRangeEnd = 83330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetGroupByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_GetGroupByIndex_Public_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0009E2EC File Offset: 0x0009C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83330, XrefRangeEnd = 83348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetGroupByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_GetGroupByName_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0009E33C File Offset: 0x0009C53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83348, XrefRangeEnd = 83354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GameObject> GetAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_GetAll_Public_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0009E37C File Offset: 0x0009C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83354, XrefRangeEnd = 83373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.NativeMethodInfoPtr_RemoveNullRefs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		public RTObjectGroupDb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0009E3B0 File Offset: 0x0009C5B0
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000CBDE File Offset: 0x0000ADDE
		public unsafe List<GameObject> _objectGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectGroupDb.NativeFieldInfoPtr__objectGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectGroupDb.NativeFieldInfoPtr__objectGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeFieldInfoPtr__objectGroups;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_get_NumGroups_Public_get_Int32_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GameObject_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GameObject_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_IsGroup_Public_Boolean_GameObject_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupByIndex_Public_GameObject_Int32_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupByName_Public_GameObject_String_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_List_1_GameObject_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullRefs_Public_Void_0;

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("RLD.RTObjectGroupDb+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004B4D RID: 19277 RVA: 0x0014A234 File Offset: 0x00148434
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr);
				RTObjectGroupDb.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr, "<>9");
				RTObjectGroupDb.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr, "<>9__11_0");
				RTObjectGroupDb.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr, 100668064);
				RTObjectGroupDb.__c.NativeMethodInfoPtr__RemoveNullRefs_b__11_0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr, 100668065);
			}

			// Token: 0x06004B4E RID: 19278 RVA: 0x0014A2B0 File Offset: 0x001484B0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectGroupDb.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B4F RID: 19279 RVA: 0x0014A2EC File Offset: 0x001484EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83254, XrefRangeEnd = 83258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNullRefs_b__11_0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.__c.NativeMethodInfoPtr__RemoveNullRefs_b__11_0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B50 RID: 19280 RVA: 0x0001C334 File Offset: 0x0001A534
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001970 RID: 6512
			// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0014A33C File Offset: 0x0014853C
			// (set) Token: 0x06004B52 RID: 19282 RVA: 0x0001C33D File Offset: 0x0001A53D
			public unsafe static RTObjectGroupDb.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTObjectGroupDb.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTObjectGroupDb.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTObjectGroupDb.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001971 RID: 6513
			// (get) Token: 0x06004B53 RID: 19283 RVA: 0x0014A364 File Offset: 0x00148564
			// (set) Token: 0x06004B54 RID: 19284 RVA: 0x0001C34F File Offset: 0x0001A54F
			public unsafe static Predicate<GameObject> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTObjectGroupDb.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTObjectGroupDb.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A74 RID: 14964
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003A75 RID: 14965
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04003A76 RID: 14966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A77 RID: 14967
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullRefs_b__11_0_Internal_Boolean_GameObject_0;
		}

		// Token: 0x02000398 RID: 920
		[ObfuscatedName("RLD.RTObjectGroupDb+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004B55 RID: 19285 RVA: 0x0014A38C File Offset: 0x0014858C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectGroupDb>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr);
				RTObjectGroupDb.__c__DisplayClass9_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr, "name");
				RTObjectGroupDb.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr, 100668066);
				RTObjectGroupDb.__c__DisplayClass9_0.NativeMethodInfoPtr__GetGroupByName_b__0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr, 100668067);
			}

			// Token: 0x06004B56 RID: 19286 RVA: 0x0014A3F4 File Offset: 0x001485F4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectGroupDb.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B57 RID: 19287 RVA: 0x0014A430 File Offset: 0x00148630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83258, XrefRangeEnd = 83289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGroupByName_b__0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectGroupDb.__c__DisplayClass9_0.NativeMethodInfoPtr__GetGroupByName_b__0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B58 RID: 19288 RVA: 0x0001C361 File Offset: 0x0001A561
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001972 RID: 6514
			// (get) Token: 0x06004B59 RID: 19289 RVA: 0x0014A480 File Offset: 0x00148680
			// (set) Token: 0x06004B5A RID: 19290 RVA: 0x0001C36A File Offset: 0x0001A56A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectGroupDb.__c__DisplayClass9_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectGroupDb.__c__DisplayClass9_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003A78 RID: 14968
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04003A79 RID: 14969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A7A RID: 14970
			private static readonly IntPtr NativeMethodInfoPtr__GetGroupByName_b__0_Internal_Boolean_GameObject_0;
		}
	}
}
