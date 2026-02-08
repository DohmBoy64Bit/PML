using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C4 RID: 708
	public class Datastore : Object
	{
		// Token: 0x06003E93 RID: 16019 RVA: 0x001195C4 File Offset: 0x001177C4
		// Note: this type is marked as 'beforefieldinit'.
		static Datastore()
		{
			Il2CppClassPointerStore<Datastore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "Datastore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datastore>.NativeClassPtr);
			Datastore.NativeFieldInfoPtr_CACHE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "CACHE_TIME");
			Datastore.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "key");
			Datastore.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "loading");
			Datastore.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "data");
			Datastore.NativeFieldInfoPtr_scriptService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "scriptService");
			Datastore.NativeFieldInfoPtr_Loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "Loaded");
			Datastore.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672935);
			Datastore.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672936);
			Datastore.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672937);
			Datastore.NativeMethodInfoPtr_Deserialize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672938);
			Datastore.NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672939);
			Datastore.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672940);
			Datastore.NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672941);
			Datastore.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore>.NativeClassPtr, 100672943);
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x0011970C File Offset: 0x0011790C
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x00119748 File Offset: 0x00117948
		public unsafe string Key
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00119780 File Offset: 0x00117980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124205, RefRangeEnd = 124206, XrefRangeStart = 124173, XrefRangeEnd = 124205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datastore(string key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datastore>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x001197CC File Offset: 0x001179CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124222, RefRangeEnd = 124223, XrefRangeStart = 124206, XrefRangeEnd = 124222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(string jsonData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_Deserialize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x00119810 File Offset: 0x00117A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124255, RefRangeEnd = 124256, XrefRangeStart = 124223, XrefRangeEnd = 124255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Get(string key, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x00119864 File Offset: 0x00117A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124279, RefRangeEnd = 124280, XrefRangeStart = 124256, XrefRangeEnd = 124279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string key, DynValue value, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001198CC File Offset: 0x00117ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124308, RefRangeEnd = 124309, XrefRangeStart = 124280, XrefRangeEnd = 124308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string key, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00119920 File Offset: 0x00117B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124309, XrefRangeEnd = 124316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x00017F9A File Offset: 0x0001619A
		public Datastore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x00119960 File Offset: 0x00117B60
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x00017FA3 File Offset: 0x000161A3
		public unsafe static float CACHE_TIME
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Datastore.NativeFieldInfoPtr_CACHE_TIME, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datastore.NativeFieldInfoPtr_CACHE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x0011997C File Offset: 0x00117B7C
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x00017FB1 File Offset: 0x000161B1
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x001199A4 File Offset: 0x00117BA4
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x00017FD0 File Offset: 0x000161D0
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x001199CC File Offset: 0x00117BCC
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x00017FEB File Offset: 0x000161EB
		public unsafe Dictionary<string, Datastore.DatastoreEntry> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Datastore.DatastoreEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x001199FC File Offset: 0x00117BFC
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x0001800A File Offset: 0x0001620A
		public unsafe ScriptService scriptService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_scriptService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_scriptService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x00119A2C File Offset: 0x00117C2C
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x00018029 File Offset: 0x00016229
		public unsafe LuaEvent Loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_Loaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.NativeFieldInfoPtr_Loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeFieldInfoPtr_CACHE_TIME;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeFieldInfoPtr_scriptService;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeFieldInfoPtr_Loaded;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_String_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Private_Void_Boolean_0;

		// Token: 0x02000409 RID: 1033
		public sealed class DatastoreEntry : ValueType
		{
			// Token: 0x06004F21 RID: 20257 RVA: 0x0015550C File Offset: 0x0015370C
			// Note: this type is marked as 'beforefieldinit'.
			static DatastoreEntry()
			{
				Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "DatastoreEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr);
				Datastore.DatastoreEntry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr, "value");
				Datastore.DatastoreEntry.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr, "timestamp");
			}

			// Token: 0x06004F22 RID: 20258 RVA: 0x0001E1F2 File Offset: 0x0001C3F2
			public DatastoreEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x0001E1FB File Offset: 0x0001C3FB
			public DatastoreEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001AAF RID: 6831
			// (get) Token: 0x06004F24 RID: 20260 RVA: 0x00155560 File Offset: 0x00153760
			// (set) Token: 0x06004F25 RID: 20261 RVA: 0x0001E20D File Offset: 0x0001C40D
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.DatastoreEntry.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.DatastoreEntry.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB0 RID: 6832
			// (get) Token: 0x06004F26 RID: 20262 RVA: 0x00155590 File Offset: 0x00153790
			// (set) Token: 0x06004F27 RID: 20263 RVA: 0x0001E22C File Offset: 0x0001C42C
			public unsafe float timestamp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.DatastoreEntry.NativeFieldInfoPtr_timestamp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.DatastoreEntry.NativeFieldInfoPtr_timestamp)) = value;
				}
			}

			// Token: 0x04003D2A RID: 15658
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04003D2B RID: 15659
			private static readonly IntPtr NativeFieldInfoPtr_timestamp;
		}

		// Token: 0x0200040A RID: 1034
		[ObfuscatedName("Polytoria.Datamodel.Services.Datastore+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06004F28 RID: 20264 RVA: 0x001555B8 File Offset: 0x001537B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr);
				Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, "key");
				Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, "callback");
				Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, "entry");
				Datastore.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, 100672944);
				Datastore.__c__DisplayClass12_0.NativeMethodInfoPtr__Get_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr, 100672945);
			}

			// Token: 0x06004F29 RID: 20265 RVA: 0x0015565C File Offset: 0x0015385C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datastore.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2A RID: 20266 RVA: 0x00155698 File Offset: 0x00153898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124126, XrefRangeEnd = 124141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Get_b__0(bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass12_0.NativeMethodInfoPtr__Get_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F2B RID: 20267 RVA: 0x0001E247 File Offset: 0x0001C447
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AB1 RID: 6833
			// (get) Token: 0x06004F2C RID: 20268 RVA: 0x001556D8 File Offset: 0x001538D8
			// (set) Token: 0x06004F2D RID: 20269 RVA: 0x0001E250 File Offset: 0x0001C450
			public unsafe Datastore __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB2 RID: 6834
			// (get) Token: 0x06004F2E RID: 20270 RVA: 0x00155708 File Offset: 0x00153908
			// (set) Token: 0x06004F2F RID: 20271 RVA: 0x0001E26F File Offset: 0x0001C46F
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AB3 RID: 6835
			// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00155730 File Offset: 0x00153930
			// (set) Token: 0x06004F31 RID: 20273 RVA: 0x0001E28E File Offset: 0x0001C48E
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB4 RID: 6836
			// (get) Token: 0x06004F32 RID: 20274 RVA: 0x00155760 File Offset: 0x00153960
			// (set) Token: 0x06004F33 RID: 20275 RVA: 0x0001E2AD File Offset: 0x0001C4AD
			public Datastore.DatastoreEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_entry);
					return new Datastore.DatastoreEntry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass12_0.NativeFieldInfoPtr_entry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Datastore.DatastoreEntry>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003D2C RID: 15660
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D2D RID: 15661
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04003D2E RID: 15662
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D2F RID: 15663
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04003D30 RID: 15664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D31 RID: 15665
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x0200040B RID: 1035
		[ObfuscatedName("Polytoria.Datamodel.Services.Datastore+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06004F34 RID: 20276 RVA: 0x00155790 File Offset: 0x00153990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr);
				Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr, "callback");
				Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				Datastore.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr, 100672946);
				Datastore.__c__DisplayClass13_0.NativeMethodInfoPtr__Set_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr, 100672947);
			}

			// Token: 0x06004F35 RID: 20277 RVA: 0x0015580C File Offset: 0x00153A0C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datastore.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x00155848 File Offset: 0x00153A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124141, XrefRangeEnd = 124159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Set_b__0(bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass13_0.NativeMethodInfoPtr__Set_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F37 RID: 20279 RVA: 0x0001E2DB File Offset: 0x0001C4DB
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AB5 RID: 6837
			// (get) Token: 0x06004F38 RID: 20280 RVA: 0x00155888 File Offset: 0x00153A88
			// (set) Token: 0x06004F39 RID: 20281 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB6 RID: 6838
			// (get) Token: 0x06004F3A RID: 20282 RVA: 0x001558B8 File Offset: 0x00153AB8
			// (set) Token: 0x06004F3B RID: 20283 RVA: 0x0001E303 File Offset: 0x0001C503
			public unsafe Datastore __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D32 RID: 15666
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D33 RID: 15667
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D34 RID: 15668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D35 RID: 15669
			private static readonly IntPtr NativeMethodInfoPtr__Set_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x0200040C RID: 1036
		[ObfuscatedName("Polytoria.Datamodel.Services.Datastore+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06004F3C RID: 20284 RVA: 0x001558E8 File Offset: 0x00153AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Datastore>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr);
				Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr, "callback");
				Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				Datastore.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr, 100672948);
				Datastore.__c__DisplayClass14_0.NativeMethodInfoPtr__Remove_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr, 100672949);
			}

			// Token: 0x06004F3D RID: 20285 RVA: 0x00155964 File Offset: 0x00153B64
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datastore.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F3E RID: 20286 RVA: 0x001559A0 File Offset: 0x00153BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124159, XrefRangeEnd = 124173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Remove_b__0(bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datastore.__c__DisplayClass14_0.NativeMethodInfoPtr__Remove_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F3F RID: 20287 RVA: 0x0001E322 File Offset: 0x0001C522
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AB7 RID: 6839
			// (get) Token: 0x06004F40 RID: 20288 RVA: 0x001559E0 File Offset: 0x00153BE0
			// (set) Token: 0x06004F41 RID: 20289 RVA: 0x0001E32B File Offset: 0x0001C52B
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB8 RID: 6840
			// (get) Token: 0x06004F42 RID: 20290 RVA: 0x00155A10 File Offset: 0x00153C10
			// (set) Token: 0x06004F43 RID: 20291 RVA: 0x0001E34A File Offset: 0x0001C54A
			public unsafe Datastore __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datastore.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D36 RID: 15670
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D37 RID: 15671
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D38 RID: 15672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D39 RID: 15673
			private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Void_Boolean_0;
		}
	}
}
