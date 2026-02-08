using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000125 RID: 293
	public static class MathEx : Object
	{
		// Token: 0x06001B68 RID: 7016 RVA: 0x0008BDA4 File Offset: 0x00089FA4
		// Note: this type is marked as 'beforefieldinit'.
		static MathEx()
		{
			Il2CppClassPointerStore<MathEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MathEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathEx>.NativeClassPtr);
			MathEx.NativeMethodInfoPtr_AlmostEqual_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathEx>.NativeClassPtr, 100667396);
			MathEx.NativeMethodInfoPtr_GetNumDigits_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathEx>.NativeClassPtr, 100667397);
			MathEx.NativeMethodInfoPtr_SafeAcos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathEx>.NativeClassPtr, 100667398);
			MathEx.NativeMethodInfoPtr_SolveQuadratic_Public_Static_Boolean_Single_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathEx>.NativeClassPtr, 100667399);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0008BE24 File Offset: 0x0008A024
		[CallerCount(0)]
		public unsafe static bool AlmostEqual(float v1, float v2, float epsilon)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathEx.NativeMethodInfoPtr_AlmostEqual_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0008BE80 File Offset: 0x0008A080
		[CallerCount(0)]
		public unsafe static int GetNumDigits(int number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathEx.NativeMethodInfoPtr_GetNumDigits_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0008BEC0 File Offset: 0x0008A0C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77211, RefRangeEnd = 77215, XrefRangeStart = 77210, XrefRangeEnd = 77211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SafeAcos(float cosine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cosine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathEx.NativeMethodInfoPtr_SafeAcos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0008BF00 File Offset: 0x0008A100
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 77218, RefRangeEnd = 77223, XrefRangeStart = 77215, XrefRangeEnd = 77218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SolveQuadratic(float a, float b, float c, out float t1, out float t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathEx.NativeMethodInfoPtr_SolveQuadratic_Public_Static_Boolean_Single_Single_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0000BD43 File Offset: 0x00009F43
		public MathEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_AlmostEqual_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_GetNumDigits_Public_Static_Int32_Int32_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_SafeAcos_Public_Static_Single_Single_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_SolveQuadratic_Public_Static_Boolean_Single_Single_Single_byref_Single_byref_Single_0;
	}
}
