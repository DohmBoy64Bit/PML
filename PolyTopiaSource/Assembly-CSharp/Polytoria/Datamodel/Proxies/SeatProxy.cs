using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F3 RID: 755
	public class SeatProxy : PartProxy
	{
		// Token: 0x06004230 RID: 16944 RVA: 0x001297BC File Offset: 0x001279BC
		// Note: this type is marked as 'beforefieldinit'.
		static SeatProxy()
		{
			Il2CppClassPointerStore<SeatProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SeatProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr);
			SeatProxy.NativeFieldInfoPtr_seat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr, "seat");
			SeatProxy.NativeMethodInfoPtr_get_Occupant_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr, 100673753);
			SeatProxy.NativeMethodInfoPtr_get_Sat_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr, 100673754);
			SeatProxy.NativeMethodInfoPtr_get_Vacated_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr, 100673755);
			SeatProxy.NativeMethodInfoPtr__ctor_Public_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr, 100673752);
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x00129850 File Offset: 0x00127A50
		public unsafe Player Occupant
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128986, XrefRangeEnd = 128988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeatProxy.NativeMethodInfoPtr_get_Occupant_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x00129890 File Offset: 0x00127A90
		public unsafe LuaEvent Sat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeatProxy.NativeMethodInfoPtr_get_Sat_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x001298D0 File Offset: 0x00127AD0
		public unsafe LuaEvent Vacated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeatProxy.NativeMethodInfoPtr_get_Vacated_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x00129910 File Offset: 0x00127B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeatProxy(Seat target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeatProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeatProxy.NativeMethodInfoPtr__ctor_Public_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x00018A39 File Offset: 0x00016C39
		public SeatProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x0012995C File Offset: 0x00127B5C
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x00018A42 File Offset: 0x00016C42
		public unsafe Seat seat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeatProxy.NativeFieldInfoPtr_seat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeatProxy.NativeFieldInfoPtr_seat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeFieldInfoPtr_seat;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_Player_0;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr_get_Sat_Public_get_LuaEvent_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_get_Vacated_Public_get_LuaEvent_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Seat_0;
	}
}
