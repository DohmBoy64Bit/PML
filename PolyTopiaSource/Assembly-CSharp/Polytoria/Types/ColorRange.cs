using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Types
{
	// Token: 0x02000259 RID: 601
	[StructLayout(2)]
	public struct ColorRange
	{
		// Token: 0x06002EBF RID: 11967 RVA: 0x000D7B08 File Offset: 0x000D5D08
		// Note: this type is marked as 'beforefieldinit'.
		static ColorRange()
		{
			Il2CppClassPointerStore<ColorRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Types", "ColorRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorRange>.NativeClassPtr);
			ColorRange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, "min");
			ColorRange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, "max");
			ColorRange.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, 100670284);
			ColorRange.NativeMethodInfoPtr_Lerp_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, 100670285);
			ColorRange.NativeMethodInfoPtr_New_Public_Static_ColorRange_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, 100670286);
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000D7B9C File Offset: 0x000D5D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99257, RefRangeEnd = 99261, XrefRangeStart = 99257, XrefRangeEnd = 99257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorRange(Color min, Color max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(min);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(max);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRange.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000D7BE4 File Offset: 0x000D5DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99261, XrefRangeEnd = 99262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color Lerp(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRange.NativeMethodInfoPtr_Lerp_Public_Color_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000D7C24 File Offset: 0x000D5E24
		[CallerCount(0)]
		public unsafe static ColorRange New(Color min, Color max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(min);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(max);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRange.NativeMethodInfoPtr_New_Public_Static_ColorRange_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00012C80 File Offset: 0x00010E80
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorRange>.NativeClassPtr, ref this));
		}

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Color_Single_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_ColorRange_Color_Color_0;

		// Token: 0x040023BF RID: 9151
		[FieldOffset(0)]
		public IntPtr min;

		// Token: 0x040023C0 RID: 9152
		[FieldOffset(16)]
		public IntPtr max;
	}
}
