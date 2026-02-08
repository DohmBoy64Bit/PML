using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A8 RID: 680
	public class Seat : Part
	{
		// Token: 0x060039FA RID: 14842 RVA: 0x00106724 File Offset: 0x00104924
		// Note: this type is marked as 'beforefieldinit'.
		static Seat()
		{
			Il2CppClassPointerStore<Seat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Seat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seat>.NativeClassPtr);
			Seat.NativeFieldInfoPtr_occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "occupant");
			Seat.NativeFieldInfoPtr_timeUntilCanSitAgain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "timeUntilCanSitAgain");
			Seat.NativeFieldInfoPtr__Sat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "_Sat");
			Seat.NativeFieldInfoPtr_Sat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "Sat");
			Seat.NativeFieldInfoPtr__Vacated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "_Vacated");
			Seat.NativeFieldInfoPtr_Vacated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "Vacated");
			Seat.NativeFieldInfoPtr____occupantNetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seat>.NativeClassPtr, "___occupantNetId");
			Seat.NativeMethodInfoPtr_get_Occupant_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672180);
			Seat.NativeMethodInfoPtr_get_Networkoccupant_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672192);
			Seat.NativeMethodInfoPtr_set_Networkoccupant_Public_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672193);
			Seat.NativeMethodInfoPtr_add__Sat_Public_add_Void_Action_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672181);
			Seat.NativeMethodInfoPtr_remove__Sat_Public_rem_Void_Action_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672182);
			Seat.NativeMethodInfoPtr_add__Vacated_Public_add_Void_Action_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672183);
			Seat.NativeMethodInfoPtr_remove__Vacated_Public_rem_Void_Action_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672184);
			Seat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672190);
			Seat.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672185);
			Seat.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672186);
			Seat.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672187);
			Seat.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672188);
			Seat.NativeMethodInfoPtr_SetOccupant_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672189);
			Seat.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672191);
			Seat.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672194);
			Seat.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seat>.NativeClassPtr, 100672195);
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x00106920 File Offset: 0x00104B20
		public unsafe Player Occupant
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 117724, RefRangeEnd = 117726, XrefRangeStart = 117721, XrefRangeEnd = 117724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_get_Occupant_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x00106960 File Offset: 0x00104B60
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x001069A0 File Offset: 0x00104BA0
		public unsafe Player Networkoccupant
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 117724, RefRangeEnd = 117726, XrefRangeStart = 117724, XrefRangeEnd = 117726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_get_Networkoccupant_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117726, XrefRangeEnd = 117732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_set_Networkoccupant_Public_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x001069E4 File Offset: 0x00104BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117732, XrefRangeEnd = 117737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__Sat(Action<Player> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_add__Sat_Public_add_Void_Action_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00106A28 File Offset: 0x00104C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117737, XrefRangeEnd = 117742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__Sat(Action<Player> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_remove__Sat_Public_rem_Void_Action_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x00106A6C File Offset: 0x00104C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117742, XrefRangeEnd = 117747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__Vacated(Action<Player> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_add__Vacated_Public_add_Void_Action_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00106AB0 File Offset: 0x00104CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117747, XrefRangeEnd = 117752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__Vacated(Action<Player> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_remove__Vacated_Public_rem_Void_Action_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00106AF4 File Offset: 0x00104CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117752, XrefRangeEnd = 117765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Seat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00106B30 File Offset: 0x00104D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117765, XrefRangeEnd = 117781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00106B6C File Offset: 0x00104D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117781, XrefRangeEnd = 117783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00106BA8 File Offset: 0x00104DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117783, XrefRangeEnd = 117794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x00106BF8 File Offset: 0x00104DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117794, XrefRangeEnd = 117805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00106C48 File Offset: 0x00104E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117805, XrefRangeEnd = 117821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seat.NativeMethodInfoPtr_SetOccupant_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00106C8C File Offset: 0x00104E8C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x00106CD4 File Offset: 0x00104ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117821, XrefRangeEnd = 117827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00106D30 File Offset: 0x00104F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117827, XrefRangeEnd = 117832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seat.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0001671B File Offset: 0x0001491B
		public Seat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x00106D8C File Offset: 0x00104F8C
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x00016724 File Offset: 0x00014924
		public unsafe Player occupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_occupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00106DBC File Offset: 0x00104FBC
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x00016743 File Offset: 0x00014943
		public unsafe float timeUntilCanSitAgain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_timeUntilCanSitAgain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_timeUntilCanSitAgain)) = value;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00106DE4 File Offset: 0x00104FE4
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x0001675E File Offset: 0x0001495E
		public unsafe Action<Player> _Sat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr__Sat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr__Sat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00106E14 File Offset: 0x00105014
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x0001677D File Offset: 0x0001497D
		public unsafe LuaEvent Sat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_Sat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_Sat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00106E44 File Offset: 0x00105044
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x0001679C File Offset: 0x0001499C
		public unsafe Action<Player> _Vacated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr__Vacated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr__Vacated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00106E74 File Offset: 0x00105074
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x000167BB File Offset: 0x000149BB
		public unsafe LuaEvent Vacated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_Vacated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr_Vacated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00106EA4 File Offset: 0x001050A4
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x000167DA File Offset: 0x000149DA
		public unsafe NetworkBehaviourSyncVar ___occupantNetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr____occupantNetId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkBehaviourSyncVar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seat.NativeFieldInfoPtr____occupantNetId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeFieldInfoPtr_occupant;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilCanSitAgain;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeFieldInfoPtr__Sat;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeFieldInfoPtr_Sat;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeFieldInfoPtr__Vacated;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeFieldInfoPtr_Vacated;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeFieldInfoPtr____occupantNetId;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_Player_0;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkoccupant_Public_get_Player_0;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkoccupant_Public_set_Void_Player_0;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeMethodInfoPtr_add__Sat_Public_add_Void_Action_1_Player_0;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr_remove__Sat_Public_rem_Void_Action_1_Player_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr_add__Vacated_Public_add_Void_Action_1_Player_0;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeMethodInfoPtr_remove__Vacated_Public_rem_Void_Action_1_Player_0;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_Player_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
