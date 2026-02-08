using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.UI
{
	// Token: 0x02000253 RID: 595
	public class MenuButtonAnimation : MonoBehaviour
	{
		// Token: 0x06002E41 RID: 11841 RVA: 0x000D676C File Offset: 0x000D496C
		// Note: this type is marked as 'beforefieldinit'.
		static MenuButtonAnimation()
		{
			Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "MenuButtonAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr);
			MenuButtonAnimation.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr, "anim");
			MenuButtonAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr, 100670261);
			MenuButtonAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr, 100670259);
			MenuButtonAnimation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr, 100670260);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000D67EC File Offset: 0x000D49EC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MenuButtonAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuButtonAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuButtonAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000D6828 File Offset: 0x000D4A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98904, XrefRangeEnd = 98908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuButtonAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000D685C File Offset: 0x000D4A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98912, RefRangeEnd = 98913, XrefRangeStart = 98908, XrefRangeEnd = 98912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuButtonAnimation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00012795 File Offset: 0x00010995
		public MenuButtonAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000D689C File Offset: 0x000D4A9C
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x0001279E File Offset: 0x0001099E
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuButtonAnimation.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuButtonAnimation.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;
	}
}
