using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000165 RID: 357
	[StructLayout(2)]
	public struct TorusEpsilon
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x000975B4 File Offset: 0x000957B4
		// Note: this type is marked as 'beforefieldinit'.
		static TorusEpsilon()
		{
			Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TorusEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr);
			TorusEpsilon.NativeFieldInfoPtr__tubeRadiusEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, "_tubeRadiusEps");
			TorusEpsilon.NativeFieldInfoPtr__cylHrzRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, "_cylHrzRadius");
			TorusEpsilon.NativeFieldInfoPtr__cylVertRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, "_cylVertRadius");
			TorusEpsilon.NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667834);
			TorusEpsilon.NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667835);
			TorusEpsilon.NativeMethodInfoPtr_get_CylHrzRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667836);
			TorusEpsilon.NativeMethodInfoPtr_set_CylHrzRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667837);
			TorusEpsilon.NativeMethodInfoPtr_get_CylVertRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667838);
			TorusEpsilon.NativeMethodInfoPtr_set_CylVertRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, 100667839);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00097698 File Offset: 0x00095898
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x000976C8 File Offset: 0x000958C8
		public unsafe float TubeRadiusEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000976FC File Offset: 0x000958FC
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0009772C File Offset: 0x0009592C
		public unsafe float CylHrzRadius
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_get_CylHrzRadius_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_set_CylHrzRadius_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00097760 File Offset: 0x00095960
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00097790 File Offset: 0x00095990
		public unsafe float CylVertRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_get_CylVertRadius_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 80248, RefRangeEnd = 80257, XrefRangeStart = 80248, XrefRangeEnd = 80257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusEpsilon.NativeMethodInfoPtr_set_CylVertRadius_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000C569 File Offset: 0x0000A769
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TorusEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeFieldInfoPtr__tubeRadiusEps;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr__cylHrzRadius;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeFieldInfoPtr__cylVertRadius;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_get_CylHrzRadius_Public_get_Single_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_set_CylHrzRadius_Public_set_Void_Single_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_get_CylVertRadius_Public_get_Single_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_set_CylVertRadius_Public_set_Void_Single_0;

		// Token: 0x0400174E RID: 5966
		[FieldOffset(0)]
		public float _tubeRadiusEps;

		// Token: 0x0400174F RID: 5967
		[FieldOffset(4)]
		public float _cylHrzRadius;

		// Token: 0x04001750 RID: 5968
		[FieldOffset(8)]
		public float _cylVertRadius;
	}
}
