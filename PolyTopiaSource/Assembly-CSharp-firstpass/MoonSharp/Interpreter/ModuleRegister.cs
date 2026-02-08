using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000050 RID: 80
	public static class ModuleRegister : Object
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00037220 File Offset: 0x00035420
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleRegister()
		{
			Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ModuleRegister");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr);
			ModuleRegister.NativeMethodInfoPtr_RegisterCoreModules_Public_Static_Table_Table_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664927);
			ModuleRegister.NativeMethodInfoPtr_RegisterConstants_Public_Static_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664928);
			ModuleRegister.NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664929);
			ModuleRegister.NativeMethodInfoPtr_RegisterScriptFieldAsConst_Private_Static_Void_FieldInfo_Object_Table_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664930);
			ModuleRegister.NativeMethodInfoPtr_RegisterScriptField_Private_Static_Void_FieldInfo_Object_Table_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664931);
			ModuleRegister.NativeMethodInfoPtr_CreateModuleNamespace_Private_Static_Table_Table_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664932);
			ModuleRegister.NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, 100664933);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000372DC File Offset: 0x000354DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26036, RefRangeEnd = 26037, XrefRangeStart = 25974, XrefRangeEnd = 26036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table RegisterCoreModules(this Table table, CoreModules modules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_RegisterCoreModules_Public_Static_Table_Table_CoreModules_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00037334 File Offset: 0x00035534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26120, RefRangeEnd = 26121, XrefRangeStart = 26037, XrefRangeEnd = 26120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table RegisterConstants(this Table table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_RegisterConstants_Public_Static_Table_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00037378 File Offset: 0x00035578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26121, XrefRangeEnd = 26312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table RegisterModuleType(this Table gtable, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gtable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000373D0 File Offset: 0x000355D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26344, RefRangeEnd = 26345, XrefRangeStart = 26312, XrefRangeEnd = 26344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterScriptFieldAsConst(FieldInfo fi, Object o, Table table, Type t, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_RegisterScriptFieldAsConst_Private_Static_Void_FieldInfo_Object_Table_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00037450 File Offset: 0x00035650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26362, RefRangeEnd = 26363, XrefRangeStart = 26345, XrefRangeEnd = 26362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterScriptField(FieldInfo fi, Object o, Table table, Type t, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_RegisterScriptField_Private_Static_Void_FieldInfo_Object_Table_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000374D0 File Offset: 0x000356D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26423, RefRangeEnd = 26424, XrefRangeStart = 26363, XrefRangeEnd = 26423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table CreateModuleNamespace(Table gtable, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gtable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.NativeMethodInfoPtr_CreateModuleNamespace_Private_Static_Table_Table_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00037528 File Offset: 0x00035728
		[CallerCount(0)]
		public unsafe static Table RegisterModuleType<T>(this Table table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.MethodInfoStoreGeneric_RegisterModuleType_Public_Static_Table_Table_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000042D3 File Offset: 0x000024D3
		public ModuleRegister(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCoreModules_Public_Static_Table_Table_CoreModules_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConstants_Public_Static_Table_Table_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_Type_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_RegisterScriptFieldAsConst_Private_Static_Void_FieldInfo_Object_Table_Type_String_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_RegisterScriptField_Private_Static_Void_FieldInfo_Object_Table_Type_String_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_CreateModuleNamespace_Private_Static_Table_Table_Type_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_0;

		// Token: 0x0200019C RID: 412
		[ObfuscatedName("MoonSharp.Interpreter.ModuleRegister+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A51 RID: 6737 RVA: 0x00081128 File Offset: 0x0007F328
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr);
				ModuleRegister.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, "<>9");
				ModuleRegister.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, "<>9__2_0");
				ModuleRegister.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, "<>9__2_1");
				ModuleRegister.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, "<>9__2_2");
				ModuleRegister.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, 100664935);
				ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, 100664936);
				ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_1_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, 100664937);
				ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_2_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr, 100664938);
			}

			// Token: 0x06001A52 RID: 6738 RVA: 0x000811F4 File Offset: 0x0007F3F4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuleRegister.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A53 RID: 6739 RVA: 0x00081230 File Offset: 0x0007F430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25966, XrefRangeEnd = 25968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterModuleType_b__2_0(MethodInfo __mi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(__mi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A54 RID: 6740 RVA: 0x00081280 File Offset: 0x0007F480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25968, XrefRangeEnd = 25971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterModuleType_b__2_1(FieldInfo _mi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_mi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_1_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A55 RID: 6741 RVA: 0x000812D0 File Offset: 0x0007F4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25971, XrefRangeEnd = 25974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterModuleType_b__2_2(FieldInfo _mi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_mi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleRegister.__c.NativeMethodInfoPtr__RegisterModuleType_b__2_2_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A56 RID: 6742 RVA: 0x0000A61B File Offset: 0x0000881B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00081320 File Offset: 0x0007F520
			// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0000A624 File Offset: 0x00008824
			public unsafe static ModuleRegister.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ModuleRegister.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModuleRegister.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ModuleRegister.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00081348 File Offset: 0x0007F548
			// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000A636 File Offset: 0x00008836
			public unsafe static Func<MethodInfo, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00081370 File Offset: 0x0007F570
			// (set) Token: 0x06001A5C RID: 6748 RVA: 0x0000A648 File Offset: 0x00008848
			public unsafe static Func<FieldInfo, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00081398 File Offset: 0x0007F598
			// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0000A65A File Offset: 0x0000885A
			public unsafe static Func<FieldInfo, bool> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ModuleRegister.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeMethodInfoPtr__RegisterModuleType_b__2_0_Internal_Boolean_MethodInfo_0;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeMethodInfoPtr__RegisterModuleType_b__2_1_Internal_Boolean_FieldInfo_0;

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeMethodInfoPtr__RegisterModuleType_b__2_2_Internal_Boolean_FieldInfo_0;
		}

		// Token: 0x0200019D RID: 413
		private sealed class MethodInfoStoreGeneric_RegisterModuleType_Public_Static_Table_Table_0<T>
		{
			// Token: 0x04001596 RID: 5526
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleRegister.NativeMethodInfoPtr_RegisterModuleType_Public_Static_Table_Table_0, Il2CppClassPointerStore<ModuleRegister>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
