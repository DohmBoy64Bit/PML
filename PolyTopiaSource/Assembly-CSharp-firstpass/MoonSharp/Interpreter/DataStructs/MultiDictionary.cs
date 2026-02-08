using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000105 RID: 261
	public class MultiDictionary<K, V> : Object
	{
		// Token: 0x060013B6 RID: 5046 RVA: 0x000660B4 File Offset: 0x000642B4
		// Note: this type is marked as 'beforefieldinit'.
		static MultiDictionary()
		{
			Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.DataStructs", "MultiDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr);
			MultiDictionary<K, V>.NativeFieldInfoPtr_m_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, "m_Map");
			MultiDictionary<K, V>.NativeFieldInfoPtr_m_DefaultRet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, "m_DefaultRet");
			MultiDictionary<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666736);
			MultiDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666731);
			MultiDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666732);
			MultiDictionary<K, V>.NativeMethodInfoPtr_Add_Public_Boolean_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666733);
			MultiDictionary<K, V>.NativeMethodInfoPtr_Find_Public_IEnumerable_1_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666734);
			MultiDictionary<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666735);
			MultiDictionary<K, V>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666737);
			MultiDictionary<K, V>.NativeMethodInfoPtr_Remove_Public_Void_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666738);
			MultiDictionary<K, V>.NativeMethodInfoPtr_RemoveValue_Public_Boolean_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr, 100666739);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00066210 File Offset: 0x00064410
		public unsafe IEnumerable<K> Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<K>>(intPtr3) : null;
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00066250 File Offset: 0x00064450
		[CallerCount(0)]
		public unsafe MultiDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0006628C File Offset: 0x0006448C
		[CallerCount(0)]
		public unsafe MultiDictionary(IEqualityComparer<K> eqComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiDictionary<K, V>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eqComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000662D8 File Offset: 0x000644D8
		[CallerCount(0)]
		public unsafe bool Add(K key, V value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				intPtr2 = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_Add_Public_Boolean_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000663A4 File Offset: 0x000645A4
		[CallerCount(0)]
		public unsafe IEnumerable<V> Find(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_Find_Public_IEnumerable_1_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<V>>(intPtr4) : null;
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0006642C File Offset: 0x0006462C
		[CallerCount(0)]
		public unsafe bool ContainsKey(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000664B0 File Offset: 0x000646B0
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000664E4 File Offset: 0x000646E4
		[CallerCount(0)]
		public unsafe void Remove(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_Remove_Public_Void_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0006655C File Offset: 0x0006475C
		[CallerCount(0)]
		public unsafe bool RemoveValue(K key, V value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				intPtr2 = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MultiDictionary<K, V>.NativeMethodInfoPtr_RemoveValue_Public_Boolean_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0000807C File Offset: 0x0000627C
		public MultiDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00066628 File Offset: 0x00064828
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00008085 File Offset: 0x00006285
		public unsafe Dictionary<K, List<V>> m_Map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiDictionary<K, V>.NativeFieldInfoPtr_m_Map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<K, List<V>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiDictionary<K, V>.NativeFieldInfoPtr_m_Map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00066658 File Offset: 0x00064858
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x000080A4 File Offset: 0x000062A4
		public unsafe Il2CppArrayBase<V> m_DefaultRet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiDictionary<K, V>.NativeFieldInfoPtr_m_DefaultRet);
				return Il2CppArrayBase<V>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiDictionary<K, V>.NativeFieldInfoPtr_m_DefaultRet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_m_Map;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultRet;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_IEnumerable_1_K_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_K_V_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_IEnumerable_1_V_K_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_K_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_K_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_RemoveValue_Public_Boolean_K_V_0;
	}
}
