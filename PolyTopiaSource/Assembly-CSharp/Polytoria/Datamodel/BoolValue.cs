using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000270 RID: 624
	public class BoolValue : ValueBase
	{
		// Token: 0x06002FF7 RID: 12279 RVA: 0x000DD264 File Offset: 0x000DB464
		// Note: this type is marked as 'beforefieldinit'.
		static BoolValue()
		{
			Il2CppClassPointerStore<BoolValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "BoolValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolValue>.NativeClassPtr);
			BoolValue.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, "val");
			BoolValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_val");
			BoolValue.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670528);
			BoolValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670529);
			BoolValue.NativeMethodInfoPtr_get_Networkval_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670534);
			BoolValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670535);
			BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670532);
			BoolValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670530);
			BoolValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670531);
			BoolValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670533);
			BoolValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670536);
			BoolValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolValue>.NativeClassPtr, 100670537);
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000DD384 File Offset: 0x000DB584
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		public unsafe bool Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100641, RefRangeEnd = 100644, XrefRangeStart = 100637, XrefRangeEnd = 100641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000DD400 File Offset: 0x000DB600
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x000DD43C File Offset: 0x000DB63C
		public unsafe bool Networkval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr_get_Networkval_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100644, XrefRangeEnd = 100647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr_set_Networkval_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000DD47C File Offset: 0x000DB67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100647, XrefRangeEnd = 100655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000DD4B8 File Offset: 0x000DB6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100655, XrefRangeEnd = 100661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolValue.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000DD508 File Offset: 0x000DB708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100661, XrefRangeEnd = 100664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolValue.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000DD554 File Offset: 0x000DB754
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolValue.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x000DD59C File Offset: 0x000DB79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100664, XrefRangeEnd = 100667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolValue.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000DD5F8 File Offset: 0x000DB7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100667, XrefRangeEnd = 100673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolValue.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00013131 File Offset: 0x00011331
		public BoolValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000DD654 File Offset: 0x000DB854
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x0001313A File Offset: 0x0001133A
		public unsafe bool val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValue.NativeFieldInfoPtr_val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValue.NativeFieldInfoPtr_val)) = value;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x000DD67C File Offset: 0x000DB87C
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00013155 File Offset: 0x00011355
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolValue.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeFieldInfoPtr_val;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_val;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Boolean_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkval_Public_get_Boolean_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkval_Public_set_Void_Boolean_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
