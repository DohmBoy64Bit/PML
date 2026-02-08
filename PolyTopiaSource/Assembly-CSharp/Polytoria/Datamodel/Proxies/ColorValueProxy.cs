using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D4 RID: 724
	public class ColorValueProxy : ValueBaseProxy
	{
		// Token: 0x06003FD4 RID: 16340 RVA: 0x0011E784 File Offset: 0x0011C984
		// Note: this type is marked as 'beforefieldinit'.
		static ColorValueProxy()
		{
			Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ColorValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr);
			ColorValueProxy.NativeFieldInfoPtr_colorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr, "colorValue");
			ColorValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr, 100673273);
			ColorValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr, 100673274);
			ColorValueProxy.NativeMethodInfoPtr__ctor_Public_Void_ColorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr, 100673272);
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x0011E804 File Offset: 0x0011CA04
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x0011E844 File Offset: 0x0011CA44
		public unsafe Color Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128492, XrefRangeEnd = 128493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0011E888 File Offset: 0x0011CA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorValueProxy(ColorValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorValueProxy.NativeMethodInfoPtr__ctor_Public_Void_ColorValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00018561 File Offset: 0x00016761
		public ColorValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x0011E8D4 File Offset: 0x0011CAD4
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x0001856A File Offset: 0x0001676A
		public unsafe ColorValue colorValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorValueProxy.NativeFieldInfoPtr_colorValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorValueProxy.NativeFieldInfoPtr_colorValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeFieldInfoPtr_colorValue;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Color_0;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorValue_0;
	}
}
