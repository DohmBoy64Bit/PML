using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033D RID: 829
	[Serializable]
	public sealed class MenuTabPair : ValueType
	{
		// Token: 0x060047A0 RID: 18336 RVA: 0x0013DA2C File Offset: 0x0013BC2C
		// Note: this type is marked as 'beforefieldinit'.
		static MenuTabPair()
		{
			Il2CppClassPointerStore<MenuTabPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "MenuTabPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuTabPair>.NativeClassPtr);
			MenuTabPair.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuTabPair>.NativeClassPtr, "button");
			MenuTabPair.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuTabPair>.NativeClassPtr, "container");
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0001AA66 File Offset: 0x00018C66
		public MenuTabPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0001AA6F File Offset: 0x00018C6F
		public MenuTabPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuTabPair>.NativeClassPtr))
		{
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x0013DA84 File Offset: 0x0013BC84
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x0001AA81 File Offset: 0x00018C81
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuTabPair.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuTabPair.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x0013DAB4 File Offset: 0x0013BCB4
		// (set) Token: 0x060047A6 RID: 18342 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuTabPair.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuTabPair.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_container;
	}
}
