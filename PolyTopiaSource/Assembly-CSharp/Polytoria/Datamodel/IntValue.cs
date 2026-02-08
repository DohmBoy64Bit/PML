using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000289 RID: 649
	public class IntValue : ValueBase
	{
		// Token: 0x060033CA RID: 13258 RVA: 0x000EC5A8 File Offset: 0x000EA7A8
		// Note: this type is marked as 'beforefieldinit'.
		static IntValue()
		{
			Il2CppClassPointerStore<IntValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "IntValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntValue>.NativeClassPtr);
			IntValue.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntValue>.NativeClassPtr, "val");
			IntValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntValue>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_val");
			IntValue.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671115);
			IntValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671116);
			IntValue.NativeMethodInfoPtr_get_Networkval_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671121);
			IntValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671122);
			IntValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671119);
			IntValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671117);
			IntValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671118);
			IntValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671120);
			IntValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671123);
			IntValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValue>.NativeClassPtr, 100671124);
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000EC6C8 File Offset: 0x000EA8C8
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x000EC704 File Offset: 0x000EA904
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105992, RefRangeEnd = 105995, XrefRangeStart = 105988, XrefRangeEnd = 105992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000EC744 File Offset: 0x000EA944
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x000EC780 File Offset: 0x000EA980
		public unsafe int Networkval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr_get_Networkval_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105995, XrefRangeEnd = 105998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x000EC7C0 File Offset: 0x000EA9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105998, XrefRangeEnd = 106006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x000EC7FC File Offset: 0x000EA9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106006, XrefRangeEnd = 106012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x000EC84C File Offset: 0x000EAA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106012, XrefRangeEnd = 106015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(int oldValue, int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x000EC898 File Offset: 0x000EAA98
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x000EC8E0 File Offset: 0x000EAAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106015, XrefRangeEnd = 106022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x000EC93C File Offset: 0x000EAB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106022, XrefRangeEnd = 106028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0001479D File Offset: 0x0001299D
		public IntValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x000EC998 File Offset: 0x000EAB98
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x000147A6 File Offset: 0x000129A6
		public unsafe int val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValue.NativeFieldInfoPtr_val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValue.NativeFieldInfoPtr_val)) = value;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000EC9C0 File Offset: 0x000EABC0
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x000147C1 File Offset: 0x000129C1
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeFieldInfoPtr_val;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkval_Public_get_Int32_0;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkval_Public_set_Void_Int32_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
