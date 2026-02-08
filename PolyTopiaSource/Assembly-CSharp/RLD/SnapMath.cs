using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000178 RID: 376
	public static class SnapMath : Object
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x00099CC0 File Offset: 0x00097EC0
		// Note: this type is marked as 'beforefieldinit'.
		static SnapMath()
		{
			Il2CppClassPointerStore<SnapMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SnapMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnapMath>.NativeClassPtr);
			SnapMath.NativeMethodInfoPtr_CalculateNumSnapSteps_Public_Static_NumSnapSteps_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapMath>.NativeClassPtr, 100667909);
			SnapMath.NativeMethodInfoPtr_CanExtractSnap_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapMath>.NativeClassPtr, 100667910);
			SnapMath.NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapMath>.NativeClassPtr, 100667911);
			SnapMath.NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapMath>.NativeClassPtr, 100667912);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00099D40 File Offset: 0x00097F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81469, XrefRangeEnd = 81472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumSnapSteps CalculateNumSnapSteps(float snapStep, float total)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnapMath.NativeMethodInfoPtr_CalculateNumSnapSteps_Public_Static_NumSnapSteps_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumSnapSteps>(intPtr3) : null;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00099D90 File Offset: 0x00097F90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 81472, RefRangeEnd = 81479, XrefRangeStart = 81472, XrefRangeEnd = 81472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanExtractSnap(float snapStep, float accumulated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accumulated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnapMath.NativeMethodInfoPtr_CanExtractSnap_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00099DDC File Offset: 0x00097FDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 81479, RefRangeEnd = 81486, XrefRangeStart = 81479, XrefRangeEnd = 81479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ExtractSnap(float snapStep, ref float accumulated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &accumulated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnapMath.NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00099E28 File Offset: 0x00098028
		[CallerCount(0)]
		public unsafe static float ExtractSnap(float snapStep, float accumulated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accumulated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnapMath.NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0000C60B File Offset: 0x0000A80B
		public SnapMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_CalculateNumSnapSteps_Public_Static_NumSnapSteps_Single_Single_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_CanExtractSnap_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_byref_Single_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_ExtractSnap_Public_Static_Single_Single_Single_0;
	}
}
