using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000264 RID: 612
	public class LuaColor3 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F46 RID: 12102 RVA: 0x000D9DE4 File Offset: 0x000D7FE4
		// Note: this type is marked as 'beforefieldinit'.
		static LuaColor3()
		{
			Il2CppClassPointerStore<LuaColor3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaColor3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr);
			LuaColor3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670400);
			LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670393);
			LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670394);
			LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670395);
			LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670396);
			LuaColor3.NativeMethodInfoPtr_Random_Public_Static_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670397);
			LuaColor3.NativeMethodInfoPtr_FromHex_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670398);
			LuaColor3.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr, 100670399);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000D9EB4 File Offset: 0x000D80B4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaColor3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaColor3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000D9EF0 File Offset: 0x000D80F0
		[CallerCount(0)]
		public unsafe static Color New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000D9F24 File Offset: 0x000D8124
		[CallerCount(0)]
		public unsafe static Color New(float d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000D9F64 File Offset: 0x000D8164
		[CallerCount(0)]
		public unsafe static Color New(float r, float g, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000D9FC0 File Offset: 0x000D81C0
		[CallerCount(0)]
		public unsafe static Color New(float r, float g, float b, float a)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000DA02C File Offset: 0x000D822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99996, XrefRangeEnd = 99999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color Random()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_Random_Public_Static_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000DA060 File Offset: 0x000D8260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100000, RefRangeEnd = 100001, XrefRangeStart = 99999, XrefRangeEnd = 100000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color FromHex(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_FromHex_Public_Static_Color_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000DA0A4 File Offset: 0x000D82A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100001, XrefRangeEnd = 100002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color Lerp(Color a, Color b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaColor3.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00012F56 File Offset: 0x00011156
		public LuaColor3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Color_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Color_Single_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Color_Single_Single_Single_Single_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_Random_Public_Static_Color_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Color_String_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0;
	}
}
