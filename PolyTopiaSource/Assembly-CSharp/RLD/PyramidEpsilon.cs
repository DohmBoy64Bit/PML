using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200015F RID: 351
	[StructLayout(2)]
	public struct PyramidEpsilon
	{
		// Token: 0x06001DA7 RID: 7591 RVA: 0x000968D4 File Offset: 0x00094AD4
		// Note: this type is marked as 'beforefieldinit'.
		static PyramidEpsilon()
		{
			Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PyramidEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr);
			PyramidEpsilon.NativeFieldInfoPtr__ptContainEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr, "_ptContainEps");
			PyramidEpsilon.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr, 100667796);
			PyramidEpsilon.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr, 100667797);
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00096940 File Offset: 0x00094B40
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x00096970 File Offset: 0x00094B70
		public unsafe float PtContainEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidEpsilon.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 80206, RefRangeEnd = 80227, XrefRangeStart = 80206, XrefRangeEnd = 80227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidEpsilon.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0000C4FD File Offset: 0x0000A6FD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PyramidEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr__ptContainEps;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0;

		// Token: 0x04001700 RID: 5888
		[FieldOffset(0)]
		public float _ptContainEps;
	}
}
