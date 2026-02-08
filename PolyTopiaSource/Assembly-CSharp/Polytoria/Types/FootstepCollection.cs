using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Types
{
	// Token: 0x0200025A RID: 602
	public class FootstepCollection : ScriptableObject
	{
		// Token: 0x06002EC4 RID: 11972 RVA: 0x000D7C7C File Offset: 0x000D5E7C
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepCollection()
		{
			Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Types", "FootstepCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr);
			FootstepCollection.NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr, "fallback");
			FootstepCollection.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr, "sounds");
			FootstepCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr, 100670288);
			FootstepCollection.NativeMethodInfoPtr_GetSounds_Public_FootstepSounds_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr, 100670287);
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000D7CFC File Offset: 0x000D5EFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99263, RefRangeEnd = 99267, XrefRangeStart = 99262, XrefRangeEnd = 99263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000D7D38 File Offset: 0x000D5F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99268, RefRangeEnd = 99269, XrefRangeStart = 99267, XrefRangeEnd = 99268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepSounds GetSounds(PartMaterial partMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepCollection.NativeMethodInfoPtr_GetSounds_Public_FootstepSounds_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootstepSounds>(intPtr3) : null;
			}
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00012C92 File Offset: 0x00010E92
		public FootstepCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000D7D88 File Offset: 0x000D5F88
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00012C9B File Offset: 0x00010E9B
		public unsafe FootstepSounds fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepCollection.NativeFieldInfoPtr_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepCollection.NativeFieldInfoPtr_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000D7DB8 File Offset: 0x000D5FB8
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00012CBA File Offset: 0x00010EBA
		public unsafe Il2CppReferenceArray<FootstepMaterial> sounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepCollection.NativeFieldInfoPtr_sounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FootstepMaterial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepCollection.NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeFieldInfoPtr_fallback;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeFieldInfoPtr_sounds;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeMethodInfoPtr_GetSounds_Public_FootstepSounds_PartMaterial_0;
	}
}
