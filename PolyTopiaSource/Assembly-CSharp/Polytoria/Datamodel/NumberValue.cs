using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000296 RID: 662
	public class NumberValue : ValueBase
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x000F289C File Offset: 0x000F0A9C
		// Note: this type is marked as 'beforefieldinit'.
		static NumberValue()
		{
			Il2CppClassPointerStore<NumberValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "NumberValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberValue>.NativeClassPtr);
			NumberValue.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, "val");
			NumberValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_val");
			NumberValue.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671354);
			NumberValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671355);
			NumberValue.NativeMethodInfoPtr_get_Networkval_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671360);
			NumberValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671361);
			NumberValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671358);
			NumberValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671356);
			NumberValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671357);
			NumberValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671359);
			NumberValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671362);
			NumberValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberValue>.NativeClassPtr, 100671363);
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x000F29BC File Offset: 0x000F0BBC
		// (set) Token: 0x06003548 RID: 13640 RVA: 0x000F29F8 File Offset: 0x000F0BF8
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 108640, RefRangeEnd = 108643, XrefRangeStart = 108636, XrefRangeEnd = 108640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x000F2A38 File Offset: 0x000F0C38
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x000F2A74 File Offset: 0x000F0C74
		public unsafe float Networkval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr_get_Networkval_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108643, XrefRangeEnd = 108646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000F2AB4 File Offset: 0x000F0CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108646, XrefRangeEnd = 108654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x000F2AF0 File Offset: 0x000F0CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108654, XrefRangeEnd = 108660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x000F2B40 File Offset: 0x000F0D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108660, XrefRangeEnd = 108663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000F2B8C File Offset: 0x000F0D8C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000F2BD4 File Offset: 0x000F0DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108663, XrefRangeEnd = 108666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000F2C30 File Offset: 0x000F0E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108666, XrefRangeEnd = 108672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00014F59 File Offset: 0x00013159
		public NumberValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x000F2C8C File Offset: 0x000F0E8C
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x00014F62 File Offset: 0x00013162
		public unsafe float val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValue.NativeFieldInfoPtr_val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValue.NativeFieldInfoPtr_val)) = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x000F2CB4 File Offset: 0x000F0EB4
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x00014F7D File Offset: 0x0001317D
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_val;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkval_Public_get_Single_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkval_Public_set_Void_Single_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Single_Single_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
