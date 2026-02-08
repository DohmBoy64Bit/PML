using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200026F RID: 623
	public class BodyPosition : Instance
	{
		// Token: 0x06002FDC RID: 12252 RVA: 0x000DCB08 File Offset: 0x000DAD08
		// Note: this type is marked as 'beforefieldinit'.
		static BodyPosition()
		{
			Il2CppClassPointerStore<BodyPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "BodyPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr);
			BodyPosition.NativeFieldInfoPtr_tPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, "tPos");
			BodyPosition.NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, "force");
			BodyPosition.NativeFieldInfoPtr_accDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, "accDist");
			BodyPosition.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670509);
			BodyPosition.NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670510);
			BodyPosition.NativeMethodInfoPtr_get_Force_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670511);
			BodyPosition.NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670512);
			BodyPosition.NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670513);
			BodyPosition.NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670514);
			BodyPosition.NativeMethodInfoPtr_get_NetworktPos_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670520);
			BodyPosition.NativeMethodInfoPtr_set_NetworktPos_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670521);
			BodyPosition.NativeMethodInfoPtr_get_Networkforce_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670522);
			BodyPosition.NativeMethodInfoPtr_set_Networkforce_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670523);
			BodyPosition.NativeMethodInfoPtr_get_NetworkaccDist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670524);
			BodyPosition.NativeMethodInfoPtr_set_NetworkaccDist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670525);
			BodyPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670518);
			BodyPosition.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670515);
			BodyPosition.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670516);
			BodyPosition.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670517);
			BodyPosition.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670519);
			BodyPosition.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670526);
			BodyPosition.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr, 100670527);
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x000DCCF0 File Offset: 0x000DAEF0
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x000DCD30 File Offset: 0x000DAF30
		public unsafe Vector3 TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100534, RefRangeEnd = 100537, XrefRangeStart = 100528, XrefRangeEnd = 100534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x000DCD74 File Offset: 0x000DAF74
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x000DCDB0 File Offset: 0x000DAFB0
		public unsafe float Force
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_Force_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 100538, RefRangeEnd = 100540, XrefRangeStart = 100537, XrefRangeEnd = 100538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000DCDF0 File Offset: 0x000DAFF0
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x000DCE2C File Offset: 0x000DB02C
		public unsafe float AcceptanceDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 100538, RefRangeEnd = 100540, XrefRangeStart = 100538, XrefRangeEnd = 100540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x000DCE6C File Offset: 0x000DB06C
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x000DCEAC File Offset: 0x000DB0AC
		public unsafe Vector3 NetworktPos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_NetworktPos_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100534, RefRangeEnd = 100537, XrefRangeStart = 100534, XrefRangeEnd = 100537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_NetworktPos_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x000DCEF0 File Offset: 0x000DB0F0
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x000DCF2C File Offset: 0x000DB12C
		public unsafe float Networkforce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_Networkforce_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 100546, RefRangeEnd = 100552, XrefRangeStart = 100540, XrefRangeEnd = 100546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_Networkforce_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x000DCF6C File Offset: 0x000DB16C
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x000DCFA8 File Offset: 0x000DB1A8
		public unsafe float NetworkaccDist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_get_NetworkaccDist_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100552, XrefRangeEnd = 100558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_set_NetworkaccDist_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000DCFE8 File Offset: 0x000DB1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100558, XrefRangeEnd = 100562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodyPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodyPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000DD024 File Offset: 0x000DB224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100562, XrefRangeEnd = 100567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodyPosition.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000DD060 File Offset: 0x000DB260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100567, XrefRangeEnd = 100601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPosition.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000DD094 File Offset: 0x000DB294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100601, XrefRangeEnd = 100609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodyPosition.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x000DD0E4 File Offset: 0x000DB2E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodyPosition.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x000DD12C File Offset: 0x000DB32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100609, XrefRangeEnd = 100617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodyPosition.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000DD188 File Offset: 0x000DB388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100617, XrefRangeEnd = 100637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodyPosition.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000130D3 File Offset: 0x000112D3
		public BodyPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x000DD1E4 File Offset: 0x000DB3E4
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x000130DC File Offset: 0x000112DC
		public unsafe Vector3 tPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_tPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_tPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x000DD214 File Offset: 0x000DB414
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x000130FB File Offset: 0x000112FB
		public unsafe float force
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_force);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_force)) = value;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x000DD23C File Offset: 0x000DB43C
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x00013116 File Offset: 0x00011316
		public unsafe float accDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_accDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPosition.NativeFieldInfoPtr_accDist)) = value;
			}
		}

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeFieldInfoPtr_tPos;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeFieldInfoPtr_force;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeFieldInfoPtr_accDist;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_get_Force_Public_get_Single_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktPos_Public_get_Vector3_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktPos_Public_set_Void_Vector3_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkforce_Public_get_Single_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkforce_Public_set_Void_Single_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkaccDist_Public_get_Single_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkaccDist_Public_set_Void_Single_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
