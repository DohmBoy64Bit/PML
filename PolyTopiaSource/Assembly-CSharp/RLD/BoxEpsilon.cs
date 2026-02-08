using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200015B RID: 347
	[StructLayout(2)]
	public struct BoxEpsilon
	{
		// Token: 0x06001D8D RID: 7565 RVA: 0x000962A8 File Offset: 0x000944A8
		// Note: this type is marked as 'beforefieldinit'.
		static BoxEpsilon()
		{
			Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr);
			BoxEpsilon.NativeFieldInfoPtr__sizeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, "_sizeEps");
			BoxEpsilon.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667778);
			BoxEpsilon.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667779);
			BoxEpsilon.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667780);
			BoxEpsilon.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667781);
			BoxEpsilon.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667782);
			BoxEpsilon.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667783);
			BoxEpsilon.NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667784);
			BoxEpsilon.NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, 100667785);
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0009638C File Offset: 0x0009458C
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000963C0 File Offset: 0x000945C0
		public unsafe Vector3 SizeEps
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80246, RefRangeEnd = 80247, XrefRangeStart = 80246, XrefRangeEnd = 80246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000963F8 File Offset: 0x000945F8
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00096428 File Offset: 0x00094628
		public unsafe float WidthEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x0009645C File Offset: 0x0009465C
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0009648C File Offset: 0x0009468C
		public unsafe float HeightEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x000964C0 File Offset: 0x000946C0
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x000964F0 File Offset: 0x000946F0
		public unsafe float DepthEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 80248, RefRangeEnd = 80257, XrefRangeStart = 80248, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxEpsilon.NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0000C4B5 File Offset: 0x0000A6B5
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoxEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr__sizeEps;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0;

		// Token: 0x040016E8 RID: 5864
		[FieldOffset(0)]
		public IntPtr _sizeEps;
	}
}
