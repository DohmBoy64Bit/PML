using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011F RID: 287
	public static class ColorEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x0008AD18 File Offset: 0x00088F18
		// Note: this type is marked as 'beforefieldinit'.
		static ColorEx()
		{
			Il2CppClassPointerStore<ColorEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ColorEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorEx>.NativeClassPtr);
			ColorEx.NativeMethodInfoPtr_FromByteValues_Public_Static_Color_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorEx>.NativeClassPtr, 100667350);
			ColorEx.NativeMethodInfoPtr_GetFilledColorArray_Public_Static_Il2CppStructArray_1_Color_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorEx>.NativeClassPtr, 100667351);
			ColorEx.NativeMethodInfoPtr_KeepAllButAlpha_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorEx>.NativeClassPtr, 100667352);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0008AD84 File Offset: 0x00088F84
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 76327, RefRangeEnd = 76339, XrefRangeStart = 76327, XrefRangeEnd = 76327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color FromByteValues(byte r, byte g, byte b, byte a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorEx.NativeMethodInfoPtr_FromByteValues_Public_Static_Color_Byte_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0008ADF0 File Offset: 0x00088FF0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 76342, RefRangeEnd = 76359, XrefRangeStart = 76339, XrefRangeEnd = 76342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Color> GetFilledColorArray(int arrayLength, Color fillValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorEx.NativeMethodInfoPtr_GetFilledColorArray_Public_Static_Il2CppStructArray_1_Color_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0008AE44 File Offset: 0x00089044
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 76359, RefRangeEnd = 76409, XrefRangeStart = 76359, XrefRangeEnd = 76359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color KeepAllButAlpha(this Color color, float newAlpha)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorEx.NativeMethodInfoPtr_KeepAllButAlpha_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000BCE9 File Offset: 0x00009EE9
		public ColorEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_FromByteValues_Public_Static_Color_Byte_Byte_Byte_Byte_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_GetFilledColorArray_Public_Static_Il2CppStructArray_1_Color_Int32_Color_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_KeepAllButAlpha_Public_Static_Color_Color_Single_0;
	}
}
