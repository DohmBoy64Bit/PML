using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200015A RID: 346
	[StructLayout(2)]
	public struct CylinderEpsilon
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x00096138 File Offset: 0x00094338
		// Note: this type is marked as 'beforefieldinit'.
		static CylinderEpsilon()
		{
			Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CylinderEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr);
			CylinderEpsilon.NativeFieldInfoPtr__hrzEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, "_hrzEps");
			CylinderEpsilon.NativeFieldInfoPtr__vertEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, "_vertEps");
			CylinderEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, 100667774);
			CylinderEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, 100667775);
			CylinderEpsilon.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, 100667776);
			CylinderEpsilon.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, 100667777);
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000961E0 File Offset: 0x000943E0
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00096210 File Offset: 0x00094410
		public unsafe float RadiusEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00096244 File Offset: 0x00094444
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00096274 File Offset: 0x00094474
		public unsafe float VertEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderEpsilon.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 80233, RefRangeEnd = 80246, XrefRangeStart = 80233, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderEpsilon.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0000C4A3 File Offset: 0x0000A6A3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CylinderEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeFieldInfoPtr__hrzEps;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeFieldInfoPtr__vertEps;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr_get_VertEps_Public_get_Single_0;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0;

		// Token: 0x040016DD RID: 5853
		[FieldOffset(0)]
		public float _hrzEps;

		// Token: 0x040016DE RID: 5854
		[FieldOffset(4)]
		public float _vertEps;
	}
}
