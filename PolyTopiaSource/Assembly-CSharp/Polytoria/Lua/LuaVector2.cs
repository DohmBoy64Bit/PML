using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000268 RID: 616
	public class LuaVector2 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F73 RID: 12147 RVA: 0x000DAC38 File Offset: 0x000D8E38
		// Note: this type is marked as 'beforefieldinit'.
		static LuaVector2()
		{
			Il2CppClassPointerStore<LuaVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr);
			LuaVector2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr, 100670432);
			LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr, 100670428);
			LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr, 100670429);
			LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr, 100670430);
			LuaVector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr, 100670431);
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000DACCC File Offset: 0x000D8ECC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaVector2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaVector2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000DAD08 File Offset: 0x000D8F08
		[CallerCount(0)]
		public unsafe static Vector2 New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x000DAD3C File Offset: 0x000D8F3C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77952, RefRangeEnd = 77961, XrefRangeStart = 77952, XrefRangeEnd = 77961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 New(float d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000DAD7C File Offset: 0x000D8F7C
		[CallerCount(0)]
		public unsafe static Vector2 New(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector2.NativeMethodInfoPtr_New_Public_Static_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000DADCC File Offset: 0x000D8FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100191, XrefRangeEnd = 100192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Lerp(Vector2 a, Vector2 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00012F99 File Offset: 0x00011199
		public LuaVector2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector2_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector2_Single_0;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector2_Single_Single_0;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0;
	}
}
