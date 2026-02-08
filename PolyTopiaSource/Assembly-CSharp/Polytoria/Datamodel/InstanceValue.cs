using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000287 RID: 647
	public class InstanceValue : ValueBase
	{
		// Token: 0x060033B3 RID: 13235 RVA: 0x000EBFAC File Offset: 0x000EA1AC
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceValue()
		{
			Il2CppClassPointerStore<InstanceValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "InstanceValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr);
			InstanceValue.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, "val");
			InstanceValue.NativeFieldInfoPtr____valNetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, "___valNetId");
			InstanceValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_val");
			InstanceValue.NativeMethodInfoPtr_get_Value_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671102);
			InstanceValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671103);
			InstanceValue.NativeMethodInfoPtr_get_Networkval_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671108);
			InstanceValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671109);
			InstanceValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671106);
			InstanceValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671104);
			InstanceValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Instance_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671105);
			InstanceValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671107);
			InstanceValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671110);
			InstanceValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr, 100671111);
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000EC0E0 File Offset: 0x000EA2E0
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x000EC120 File Offset: 0x000EA320
		public unsafe Instance Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 105913, RefRangeEnd = 105914, XrefRangeStart = 105910, XrefRangeEnd = 105913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr_get_Value_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105934, RefRangeEnd = 105937, XrefRangeStart = 105914, XrefRangeEnd = 105934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x000EC164 File Offset: 0x000EA364
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x000EC1A4 File Offset: 0x000EA3A4
		public unsafe Instance Networkval
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 105913, RefRangeEnd = 105914, XrefRangeStart = 105913, XrefRangeEnd = 105914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr_get_Networkval_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105937, XrefRangeEnd = 105949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000EC1E8 File Offset: 0x000EA3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105949, XrefRangeEnd = 105957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x000EC224 File Offset: 0x000EA424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105957, XrefRangeEnd = 105966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstanceValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000EC274 File Offset: 0x000EA474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105966, XrefRangeEnd = 105973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(Instance oldValue, Instance newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Instance_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x000EC2C8 File Offset: 0x000EA4C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstanceValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000EC310 File Offset: 0x000EA510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105973, XrefRangeEnd = 105983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstanceValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000EC36C File Offset: 0x000EA56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105983, XrefRangeEnd = 105988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstanceValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x0001472E File Offset: 0x0001292E
		public InstanceValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000EC3C8 File Offset: 0x000EA5C8
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x00014737 File Offset: 0x00012937
		public unsafe Instance val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr_val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr_val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000EC3F8 File Offset: 0x000EA5F8
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x00014756 File Offset: 0x00012956
		public unsafe NetworkBehaviourSyncVar ___valNetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr____valNetId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkBehaviourSyncVar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr____valNetId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000EC428 File Offset: 0x000EA628
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x00014775 File Offset: 0x00012975
		public unsafe Action<Instance, Instance> _Mirror_SyncVarHookDelegate_val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Instance, Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeFieldInfoPtr_val;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeFieldInfoPtr____valNetId;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Instance_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Instance_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkval_Public_get_Instance_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkval_Public_set_Void_Instance_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Instance_Instance_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
