using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Types
{
	// Token: 0x0200025C RID: 604
	public class FootstepSounds : ScriptableObject
	{
		// Token: 0x06002ED3 RID: 11987 RVA: 0x000D7EA0 File Offset: 0x000D60A0
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepSounds()
		{
			Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Types", "FootstepSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr);
			FootstepSounds.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "sounds");
			FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100670289);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000D7EF8 File Offset: 0x000D60F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99263, RefRangeEnd = 99267, XrefRangeStart = 99263, XrefRangeEnd = 99267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepSounds()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00012D32 File Offset: 0x00010F32
		public FootstepSounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x000D7F34 File Offset: 0x000D6134
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x00012D3B File Offset: 0x00010F3B
		public unsafe Il2CppReferenceArray<AudioClip> sounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeFieldInfoPtr_sounds;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
