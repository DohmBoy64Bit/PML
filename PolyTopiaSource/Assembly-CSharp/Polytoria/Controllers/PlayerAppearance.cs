using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000336 RID: 822
	public class PlayerAppearance : AppearanceLoaderBase
	{
		// Token: 0x06004658 RID: 18008 RVA: 0x001395F4 File Offset: 0x001377F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerAppearance()
		{
			Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "PlayerAppearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr);
			PlayerAppearance.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, "player");
			PlayerAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674439);
			PlayerAppearance.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674434);
			PlayerAppearance.NativeMethodInfoPtr_ClearAppearance_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674435);
			PlayerAppearance.NativeMethodInfoPtr_UpdateColors_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674436);
			PlayerAppearance.NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674437);
			PlayerAppearance.NativeMethodInfoPtr_HatLoaded_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674438);
			PlayerAppearance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr, 100674440);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001396C4 File Offset: 0x001378C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136324, XrefRangeEnd = 136328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAppearance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerAppearance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00139700 File Offset: 0x00137900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136328, XrefRangeEnd = 136349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0013973C File Offset: 0x0013793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136349, XrefRangeEnd = 136360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_ClearAppearance_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00139778 File Offset: 0x00137978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136360, XrefRangeEnd = 136367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_UpdateColors_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x001397B4 File Offset: 0x001379B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136367, XrefRangeEnd = 136372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateClothing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x001397F0 File Offset: 0x001379F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136372, XrefRangeEnd = 136387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HatLoaded(GameObject hat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_HatLoaded_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00139840 File Offset: 0x00137A40
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerAppearance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x0001A07A File Offset: 0x0001827A
		public PlayerAppearance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004661 RID: 18017 RVA: 0x00139888 File Offset: 0x00137A88
		// (set) Token: 0x06004662 RID: 18018 RVA: 0x0001A083 File Offset: 0x00018283
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAppearance.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAppearance.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Virtual_Void_0;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Protected_Virtual_Void_0;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_Void_0;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeMethodInfoPtr_HatLoaded_Protected_Virtual_Void_GameObject_0;

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
