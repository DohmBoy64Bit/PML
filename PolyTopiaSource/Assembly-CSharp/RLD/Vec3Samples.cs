using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000117 RID: 279
	public class Vec3Samples : global::Il2CppSystem.Object
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x000888E0 File Offset: 0x00086AE0
		// Note: this type is marked as 'beforefieldinit'.
		static Vec3Samples()
		{
			Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Vec3Samples");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr);
			Vec3Samples.NativeFieldInfoPtr__maxNumSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, "_maxNumSamples");
			Vec3Samples.NativeFieldInfoPtr__samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, "_samples");
			Vec3Samples.NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667260);
			Vec3Samples.NativeMethodInfoPtr_get_MaxNumSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667261);
			Vec3Samples.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667265);
			Vec3Samples.NativeMethodInfoPtr_AddSample_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667262);
			Vec3Samples.NativeMethodInfoPtr_SetMaxNumSamples_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667263);
			Vec3Samples.NativeMethodInfoPtr_GetAverage_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr, 100667264);
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x000889B0 File Offset: 0x00086BB0
		public unsafe int NumSamples
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75862, XrefRangeEnd = 75863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x000889EC File Offset: 0x00086BEC
		public unsafe int MaxNumSamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr_get_MaxNumSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00088A28 File Offset: 0x00086C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75863, XrefRangeEnd = 75871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vec3Samples()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vec3Samples>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00088A64 File Offset: 0x00086C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75871, XrefRangeEnd = 75883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSample(Vector3 sample)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sample);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr_AddSample_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00088AA8 File Offset: 0x00086CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75883, XrefRangeEnd = 75889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxNumSamples(int maxNumSamples)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumSamples;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr_SetMaxNumSamples_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00088AE8 File Offset: 0x00086CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75889, XrefRangeEnd = 75909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vec3Samples.NativeMethodInfoPtr_GetAverage_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0000B999 File Offset: 0x00009B99
		public Vec3Samples(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00088B28 File Offset: 0x00086D28
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000B9A2 File Offset: 0x00009BA2
		public unsafe int _maxNumSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vec3Samples.NativeFieldInfoPtr__maxNumSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vec3Samples.NativeFieldInfoPtr__maxNumSamples)) = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00088B50 File Offset: 0x00086D50
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x0000B9BD File Offset: 0x00009BBD
		public unsafe List<Vector3> _samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vec3Samples.NativeFieldInfoPtr__samples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vec3Samples.NativeFieldInfoPtr__samples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr__maxNumSamples;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr__samples;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxNumSamples_Public_get_Int32_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_AddSample_Public_Void_Vector3_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxNumSamples_Public_Void_Int32_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_GetAverage_Public_Vector3_0;
	}
}
