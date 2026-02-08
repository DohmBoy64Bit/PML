using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200015C RID: 348
	[StructLayout(2)]
	public struct ConeEpsilon
	{
		// Token: 0x06001D97 RID: 7575 RVA: 0x00096524 File Offset: 0x00094724
		// Note: this type is marked as 'beforefieldinit'.
		static ConeEpsilon()
		{
			Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ConeEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr);
			ConeEpsilon.NativeFieldInfoPtr__hrzEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, "_hrzEps");
			ConeEpsilon.NativeFieldInfoPtr__vertEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, "_vertEps");
			ConeEpsilon.NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, 100667786);
			ConeEpsilon.NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, 100667787);
			ConeEpsilon.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, 100667788);
			ConeEpsilon.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, 100667789);
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000965CC File Offset: 0x000947CC
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x000965FC File Offset: 0x000947FC
		public unsafe float HrzEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeEpsilon.NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeEpsilon.NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00096630 File Offset: 0x00094830
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00096660 File Offset: 0x00094860
		public unsafe float VertEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeEpsilon.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 80233, RefRangeEnd = 80246, XrefRangeStart = 80233, XrefRangeEnd = 80246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeEpsilon.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConeEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr__hrzEps;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr__vertEps;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_get_VertEps_Public_get_Single_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0;

		// Token: 0x040016EF RID: 5871
		[FieldOffset(0)]
		public float _hrzEps;

		// Token: 0x040016F0 RID: 5872
		[FieldOffset(4)]
		public float _vertEps;
	}
}
