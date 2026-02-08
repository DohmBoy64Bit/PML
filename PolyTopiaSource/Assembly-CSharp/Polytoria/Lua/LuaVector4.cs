using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x0200026A RID: 618
	public class LuaVector4 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F95 RID: 12181 RVA: 0x000DB8EC File Offset: 0x000D9AEC
		// Note: this type is marked as 'beforefieldinit'.
		static LuaVector4()
		{
			Il2CppClassPointerStore<LuaVector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaVector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr);
			LuaVector4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670463);
			LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670458);
			LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670459);
			LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670460);
			LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670461);
			LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr, 100670462);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000DB994 File Offset: 0x000D9B94
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaVector4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaVector4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000DB9D0 File Offset: 0x000D9BD0
		[CallerCount(0)]
		public unsafe static Vector4 New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x000DBA04 File Offset: 0x000D9C04
		[CallerCount(0)]
		public unsafe static Vector3 New(float d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000DBA44 File Offset: 0x000D9C44
		[CallerCount(0)]
		public unsafe static Vector4 New(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000DBA94 File Offset: 0x000D9C94
		[CallerCount(0)]
		public unsafe static Vector4 New(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000DBAF0 File Offset: 0x000D9CF0
		[CallerCount(0)]
		public unsafe static Vector4 New(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector4.NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00012FAB File Offset: 0x000111AB
		public LuaVector4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector4_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_0;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector4_Single_Single_Single_Single_0;
	}
}
