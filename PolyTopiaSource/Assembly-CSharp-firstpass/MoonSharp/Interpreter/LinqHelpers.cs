using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004D RID: 77
	public static class LinqHelpers : Object
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00037014 File Offset: 0x00035214
		// Note: this type is marked as 'beforefieldinit'.
		static LinqHelpers()
		{
			Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "LinqHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr);
			LinqHelpers.NativeMethodInfoPtr_Convert_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, 100664909);
			LinqHelpers.NativeMethodInfoPtr_OfDataType_Public_Static_IEnumerable_1_DynValue_IEnumerable_1_DynValue_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, 100664910);
			LinqHelpers.NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_Object_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, 100664911);
			LinqHelpers.NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, 100664912);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00037094 File Offset: 0x00035294
		[CallerCount(0)]
		public unsafe static IEnumerable<T> Convert<T>(this IEnumerable<DynValue> enumerable, DataType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.MethodInfoStoreGeneric_Convert_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_DataType_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000370EC File Offset: 0x000352EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25934, XrefRangeEnd = 25948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<DynValue> OfDataType(this IEnumerable<DynValue> enumerable, DataType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.NativeMethodInfoPtr_OfDataType_Public_Static_IEnumerable_1_DynValue_IEnumerable_1_DynValue_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DynValue>>(intPtr3) : null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00037144 File Offset: 0x00035344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25948, XrefRangeEnd = 25966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Object> AsObjects(this IEnumerable<DynValue> enumerable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_Object_IEnumerable_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00037188 File Offset: 0x00035388
		[CallerCount(0)]
		public unsafe static IEnumerable<T> AsObjects<T>(this IEnumerable<DynValue> enumerable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.MethodInfoStoreGeneric_AsObjects_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00004288 File Offset: 0x00002488
		public LinqHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_DataType_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_OfDataType_Public_Static_IEnumerable_1_DynValue_IEnumerable_1_DynValue_DataType_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_Object_IEnumerable_1_DynValue_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_0;

		// Token: 0x02000195 RID: 405
		[ObfuscatedName("MoonSharp.Interpreter.LinqHelpers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A2B RID: 6699 RVA: 0x00080984 File Offset: 0x0007EB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr);
				LinqHelpers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr, "<>9");
				LinqHelpers.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr, "<>9__2_0");
				LinqHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr, 100664914);
				LinqHelpers.__c.NativeMethodInfoPtr__AsObjects_b__2_0_Internal_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr, 100664915);
			}

			// Token: 0x06001A2C RID: 6700 RVA: 0x00080A00 File Offset: 0x0007EC00
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinqHelpers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A2D RID: 6701 RVA: 0x00080A3C File Offset: 0x0007EC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25932, XrefRangeEnd = 25934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _AsObjects_b__2_0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c.NativeMethodInfoPtr__AsObjects_b__2_0_Internal_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A2E RID: 6702 RVA: 0x0000A544 File Offset: 0x00008744
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00080A8C File Offset: 0x0007EC8C
			// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0000A54D File Offset: 0x0000874D
			public unsafe static LinqHelpers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinqHelpers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00080AB4 File Offset: 0x0007ECB4
			// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000A55F File Offset: 0x0000875F
			public unsafe static Func<DynValue, Object> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeMethodInfoPtr__AsObjects_b__2_0_Internal_Object_DynValue_0;
		}

		// Token: 0x02000196 RID: 406
		[ObfuscatedName("MoonSharp.Interpreter.LinqHelpers+<>c__0`1")]
		[Serializable]
		public sealed class __c__0<T> : Object
		{
			// Token: 0x06001A33 RID: 6707 RVA: 0x00080ADC File Offset: 0x0007ECDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, "<>c__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr);
				LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr, "<>9");
				LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr, "<>9__0_1");
				LinqHelpers.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr, 100664917);
				LinqHelpers.__c__0<T>.NativeMethodInfoPtr__Convert_b__0_1_Internal_T_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr, 100664918);
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x00080B94 File Offset: 0x0007ED94
			[CallerCount(0)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinqHelpers.__c__0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A35 RID: 6709 RVA: 0x00080BD0 File Offset: 0x0007EDD0
			[CallerCount(0)]
			public unsafe T _Convert_b__0_1(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__0<T>.NativeMethodInfoPtr__Convert_b__0_1_Internal_T_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x0000A571 File Offset: 0x00008771
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00080C1C File Offset: 0x0007EE1C
			// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000A57A File Offset: 0x0000877A
			public unsafe static LinqHelpers.__c__0<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinqHelpers.__c__0<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00080C44 File Offset: 0x0007EE44
			// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000A58C File Offset: 0x0000878C
			public unsafe static Func<DynValue, T> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c__0<T>.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeMethodInfoPtr__Convert_b__0_1_Internal_T_DynValue_0;
		}

		// Token: 0x02000197 RID: 407
		[ObfuscatedName("MoonSharp.Interpreter.LinqHelpers+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<T> : Object
		{
			// Token: 0x06001A3B RID: 6715 RVA: 0x00080C6C File Offset: 0x0007EE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr);
				LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr, "<>9");
				LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr, "<>9__3_0");
				LinqHelpers.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr, 100664920);
				LinqHelpers.__c__3<T>.NativeMethodInfoPtr__AsObjects_b__3_0_Internal_T_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr, 100664921);
			}

			// Token: 0x06001A3C RID: 6716 RVA: 0x00080D24 File Offset: 0x0007EF24
			[CallerCount(0)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinqHelpers.__c__3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A3D RID: 6717 RVA: 0x00080D60 File Offset: 0x0007EF60
			[CallerCount(0)]
			public unsafe T _AsObjects_b__3_0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__3<T>.NativeMethodInfoPtr__AsObjects_b__3_0_Internal_T_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001A3E RID: 6718 RVA: 0x0000A59E File Offset: 0x0000879E
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00080DAC File Offset: 0x0007EFAC
			// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0000A5A7 File Offset: 0x000087A7
			public unsafe static LinqHelpers.__c__3<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinqHelpers.__c__3<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00080DD4 File Offset: 0x0007EFD4
			// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0000A5B9 File Offset: 0x000087B9
			public unsafe static Func<DynValue, T> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LinqHelpers.__c__3<T>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeMethodInfoPtr__AsObjects_b__3_0_Internal_T_DynValue_0;
		}

		// Token: 0x02000198 RID: 408
		[ObfuscatedName("MoonSharp.Interpreter.LinqHelpers+<>c__DisplayClass0_0`1")]
		public sealed class __c__DisplayClass0_0<T> : Object
		{
			// Token: 0x06001A43 RID: 6723 RVA: 0x00080DFC File Offset: 0x0007EFFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, "<>c__DisplayClass0_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr);
				LinqHelpers.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr, "type");
				LinqHelpers.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664922);
				LinqHelpers.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__Convert_b__0_Internal_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664923);
			}

			// Token: 0x06001A44 RID: 6724 RVA: 0x00080EA0 File Offset: 0x0007F0A0
			[CallerCount(0)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass0_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A45 RID: 6725 RVA: 0x00080EDC File Offset: 0x0007F0DC
			[CallerCount(0)]
			public unsafe bool _Convert_b__0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__Convert_b__0_Internal_Boolean_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A46 RID: 6726 RVA: 0x0000A5CB File Offset: 0x000087CB
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00080F2C File Offset: 0x0007F12C
			// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0000A5D4 File Offset: 0x000087D4
			public unsafe DataType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinqHelpers.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinqHelpers.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeMethodInfoPtr__Convert_b__0_Internal_Boolean_DynValue_0;
		}

		// Token: 0x02000199 RID: 409
		[ObfuscatedName("MoonSharp.Interpreter.LinqHelpers+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001A49 RID: 6729 RVA: 0x00080F5C File Offset: 0x0007F15C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr);
				LinqHelpers.__c__DisplayClass1_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr, "type");
				LinqHelpers.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr, 100664924);
				LinqHelpers.__c__DisplayClass1_0.NativeMethodInfoPtr__OfDataType_b__0_Internal_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr, 100664925);
			}

			// Token: 0x06001A4A RID: 6730 RVA: 0x00080FC4 File Offset: 0x0007F1C4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinqHelpers.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4B RID: 6731 RVA: 0x00081000 File Offset: 0x0007F200
			[CallerCount(0)]
			public unsafe bool _OfDataType_b__0(DynValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinqHelpers.__c__DisplayClass1_0.NativeMethodInfoPtr__OfDataType_b__0_Internal_Boolean_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A4C RID: 6732 RVA: 0x0000A5F3 File Offset: 0x000087F3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00081050 File Offset: 0x0007F250
			// (set) Token: 0x06001A4E RID: 6734 RVA: 0x0000A5FC File Offset: 0x000087FC
			public unsafe DataType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinqHelpers.__c__DisplayClass1_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinqHelpers.__c__DisplayClass1_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeMethodInfoPtr__OfDataType_b__0_Internal_Boolean_DynValue_0;
		}

		// Token: 0x0200019A RID: 410
		private sealed class MethodInfoStoreGeneric_Convert_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_DataType_0<T>
		{
			// Token: 0x0400158C RID: 5516
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LinqHelpers.NativeMethodInfoPtr_Convert_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_DataType_0, Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019B RID: 411
		private sealed class MethodInfoStoreGeneric_AsObjects_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_0<T>
		{
			// Token: 0x0400158D RID: 5517
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LinqHelpers.NativeMethodInfoPtr_AsObjects_Public_Static_IEnumerable_1_T_IEnumerable_1_DynValue_0, Il2CppClassPointerStore<LinqHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
