using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public class SerializableDictionary<SerializedKeyType, SerializedValueType> : Object
	{
		// Token: 0x0600228B RID: 8843 RVA: 0x000AA430 File Offset: 0x000A8630
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableDictionary()
		{
			Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SerializableDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializedKeyType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializedValueType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, "_dictionary");
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, "_serializedKeys");
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, "_serializedValues");
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_get_Dictionary_Public_get_Dictionary_2_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668511);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_get_Item_Public_get_SerializedValueType_SerializedKeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668512);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_set_Item_Public_set_Void_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668513);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668521);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668514);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668515);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668516);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Add_Public_Void_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668517);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_SerializedKeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668518);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Copy_Public_Void_SerializableDictionary_2_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668519);
			SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_RemoveNullKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, 100668520);
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000AA5C8 File Offset: 0x000A87C8
		public unsafe Dictionary<SerializedKeyType, SerializedValueType> Dictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_get_Dictionary_Public_get_Dictionary_2_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<SerializedKeyType, SerializedValueType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2E RID: 3118
		public unsafe SerializedValueType this[SerializedKeyType index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(SerializedKeyType).IsValueType)
					{
						SerializedKeyType serializedKeyType = index;
						intPtr = ((serializedKeyType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedKeyType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedKeyType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref index;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_get_Item_Public_get_SerializedValueType_SerializedKeyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<SerializedValueType>(intPtr2, false, true);
				}
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(SerializedKeyType).IsValueType)
					{
						SerializedKeyType serializedKeyType = index;
						intPtr = ((serializedKeyType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedKeyType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedKeyType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref index;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(SerializedValueType).IsValueType)
				{
					SerializedValueType serializedValueType = value;
					intPtr2 = ((serializedValueType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedValueType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedValueType as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_set_Item_Public_set_Void_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000AA748 File Offset: 0x000A8948
		[CallerCount(0)]
		public unsafe SerializableDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000AA784 File Offset: 0x000A8984
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000AA7B8 File Offset: 0x000A89B8
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000AA7EC File Offset: 0x000A89EC
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000AA820 File Offset: 0x000A8A20
		[CallerCount(0)]
		public unsafe void Add(SerializedKeyType key, SerializedValueType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(SerializedKeyType).IsValueType)
				{
					SerializedKeyType serializedKeyType = key;
					intPtr = ((serializedKeyType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedKeyType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedKeyType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(SerializedValueType).IsValueType)
			{
				SerializedValueType serializedValueType = value;
				intPtr2 = ((serializedValueType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedValueType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedValueType as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Add_Public_Void_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		[CallerCount(0)]
		public unsafe bool ContainsKey(SerializedKeyType key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(SerializedKeyType).IsValueType)
				{
					SerializedKeyType serializedKeyType = key;
					intPtr = ((serializedKeyType is string) ? IL2CPP.ManagedStringToIl2Cpp(serializedKeyType as string) : IL2CPP.Il2CppObjectBaseToPtr(serializedKeyType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_ContainsKey_Public_Boolean_SerializedKeyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000AA964 File Offset: 0x000A8B64
		[CallerCount(0)]
		public unsafe void Copy(SerializableDictionary<SerializedKeyType, SerializedValueType> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_Copy_Public_Void_SerializableDictionary_2_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000AA9A8 File Offset: 0x000A8BA8
		[CallerCount(0)]
		public unsafe void RemoveNullKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeMethodInfoPtr_RemoveNullKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0000E1BB File Offset: 0x0000C3BB
		public SerializableDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000AA9DC File Offset: 0x000A8BDC
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		public unsafe Dictionary<SerializedKeyType, SerializedValueType> _dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SerializedKeyType, SerializedValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000AAA0C File Offset: 0x000A8C0C
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0000E1E3 File Offset: 0x0000C3E3
		public unsafe List<SerializedKeyType> _serializedKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedKeyType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000AAA3C File Offset: 0x000A8C3C
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0000E202 File Offset: 0x0000C402
		public unsafe List<SerializedValueType> _serializedValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<SerializedKeyType, SerializedValueType>.NativeFieldInfoPtr__serializedValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeFieldInfoPtr__dictionary;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr__serializedKeys;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeFieldInfoPtr__serializedValues;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_get_Dictionary_Public_get_Dictionary_2_SerializedKeyType_SerializedValueType_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_SerializedValueType_SerializedKeyType_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_SerializedKeyType_SerializedValueType_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_SerializedKeyType_SerializedValueType_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_SerializedKeyType_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_SerializableDictionary_2_SerializedKeyType_SerializedValueType_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullKeys_Public_Void_0;

		// Token: 0x020003A6 RID: 934
		[ObfuscatedName("RLD.SerializableDictionary`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004BB8 RID: 19384 RVA: 0x0014B64C File Offset: 0x0014984C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializedKeyType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializedValueType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr);
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, "<>9");
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, "<>9__14_0");
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, "<>9__14_1");
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, "<>9__14_2");
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, 100668523);
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_0_Internal_Boolean_KeyValuePair_2_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, 100668524);
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_1_Internal_SerializedKeyType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, 100668525);
				SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_2_Internal_SerializedValueType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr, 100668526);
			}

			// Token: 0x06004BB9 RID: 19385 RVA: 0x0014B764 File Offset: 0x00149964
			[CallerCount(0)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x0014B7A0 File Offset: 0x001499A0
			[CallerCount(0)]
			public unsafe bool _RemoveNullKeys_b__14_0(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyValuePair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_0_Internal_Boolean_KeyValuePair_2_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BBB RID: 19387 RVA: 0x0014B7F0 File Offset: 0x001499F0
			[CallerCount(0)]
			public unsafe SerializedKeyType _RemoveNullKeys_b__14_1(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyValuePair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_1_Internal_SerializedKeyType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<SerializedKeyType>(intPtr, false, true);
				}
			}

			// Token: 0x06004BBC RID: 19388 RVA: 0x0014B83C File Offset: 0x00149A3C
			[CallerCount(0)]
			public unsafe SerializedValueType _RemoveNullKeys_b__14_2(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyValuePair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeMethodInfoPtr__RemoveNullKeys_b__14_2_Internal_SerializedValueType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<SerializedValueType>(intPtr, false, true);
				}
			}

			// Token: 0x06004BBD RID: 19389 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700197D RID: 6525
			// (get) Token: 0x06004BBE RID: 19390 RVA: 0x0014B888 File Offset: 0x00149A88
			// (set) Token: 0x06004BBF RID: 19391 RVA: 0x0001C5A9 File Offset: 0x0001A7A9
			public unsafe static SerializableDictionary<SerializedKeyType, SerializedValueType>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableDictionary<SerializedKeyType, SerializedValueType>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197E RID: 6526
			// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x0014B8B0 File Offset: 0x00149AB0
			// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x0001C5BB File Offset: 0x0001A7BB
			public unsafe static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<SerializedKeyType, SerializedValueType>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197F RID: 6527
			// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x0014B8D8 File Offset: 0x00149AD8
			// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x0001C5CD File Offset: 0x0001A7CD
			public unsafe static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedKeyType> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedKeyType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001980 RID: 6528
			// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x0014B900 File Offset: 0x00149B00
			// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x0001C5DF File Offset: 0x0001A7DF
			public unsafe static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedValueType> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedValueType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializableDictionary<SerializedKeyType, SerializedValueType>.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AAA RID: 15018
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003AAB RID: 15019
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04003AAC RID: 15020
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04003AAD RID: 15021
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x04003AAE RID: 15022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003AAF RID: 15023
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullKeys_b__14_0_Internal_Boolean_KeyValuePair_2_SerializedKeyType_SerializedValueType_0;

			// Token: 0x04003AB0 RID: 15024
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullKeys_b__14_1_Internal_SerializedKeyType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0;

			// Token: 0x04003AB1 RID: 15025
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullKeys_b__14_2_Internal_SerializedValueType_KeyValuePair_2_SerializedKeyType_SerializedValueType_0;
		}
	}
}
