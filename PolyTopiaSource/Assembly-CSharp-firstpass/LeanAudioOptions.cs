using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class LeanAudioOptions : global::Il2CppSystem.Object
{
	// Token: 0x0600003E RID: 62 RVA: 0x00011080 File Offset: 0x0000F280
	// Note: this type is marked as 'beforefieldinit'.
	static LeanAudioOptions()
	{
		Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudioOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr);
		LeanAudioOptions.NativeFieldInfoPtr_waveStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveStyle");
		LeanAudioOptions.NativeFieldInfoPtr_vibrato = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "vibrato");
		LeanAudioOptions.NativeFieldInfoPtr_modulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "modulation");
		LeanAudioOptions.NativeFieldInfoPtr_frequencyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "frequencyRate");
		LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveNoiseScale");
		LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveNoiseInfluence");
		LeanAudioOptions.NativeFieldInfoPtr_useSetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "useSetData");
		LeanAudioOptions.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "stream");
		LeanAudioOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663327);
		LeanAudioOptions.NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663328);
		LeanAudioOptions.NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663329);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663330);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663331);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663332);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663333);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663334);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663335);
		LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663336);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00011218 File Offset: 0x0000F418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10026, XrefRangeEnd = 10027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanAudioOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00011254 File Offset: 0x0000F454
	[CallerCount(0)]
	public unsafe LeanAudioOptions setFrequency(int frequencyRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref frequencyRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000112A0 File Offset: 0x0000F4A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10027, XrefRangeEnd = 10028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanAudioOptions setVibrato(Il2CppStructArray<Vector3> vibrato)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vibrato);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
		}
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000112F0 File Offset: 0x0000F4F0
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00011330 File Offset: 0x0000F530
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSquare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00011370 File Offset: 0x0000F570
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSawtooth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000113B0 File Offset: 0x0000F5B0
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000113F0 File Offset: 0x0000F5F0
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveStyle(LeanAudioOptions.LeanAudioWaveStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0001143C File Offset: 0x0000F63C
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref waveScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00011488 File Offset: 0x0000F688
	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000211B File Offset: 0x0000031B
	public LeanAudioOptions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600004A RID: 74 RVA: 0x000114D4 File Offset: 0x0000F6D4
	// (set) Token: 0x0600004B RID: 75 RVA: 0x00002124 File Offset: 0x00000324
	public unsafe LeanAudioOptions.LeanAudioWaveStyle waveStyle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveStyle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveStyle)) = value;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600004C RID: 76 RVA: 0x000114FC File Offset: 0x0000F6FC
	// (set) Token: 0x0600004D RID: 77 RVA: 0x0000213F File Offset: 0x0000033F
	public unsafe Il2CppStructArray<Vector3> vibrato
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_vibrato);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_vibrato), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600004E RID: 78 RVA: 0x0001152C File Offset: 0x0000F72C
	// (set) Token: 0x0600004F RID: 79 RVA: 0x0000215E File Offset: 0x0000035E
	public unsafe Il2CppStructArray<Vector3> modulation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_modulation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_modulation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000050 RID: 80 RVA: 0x0001155C File Offset: 0x0000F75C
	// (set) Token: 0x06000051 RID: 81 RVA: 0x0000217D File Offset: 0x0000037D
	public unsafe int frequencyRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_frequencyRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_frequencyRate)) = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00011584 File Offset: 0x0000F784
	// (set) Token: 0x06000053 RID: 83 RVA: 0x00002198 File Offset: 0x00000398
	public unsafe float waveNoiseScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale)) = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000054 RID: 84 RVA: 0x000115AC File Offset: 0x0000F7AC
	// (set) Token: 0x06000055 RID: 85 RVA: 0x000021B3 File Offset: 0x000003B3
	public unsafe float waveNoiseInfluence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence)) = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000056 RID: 86 RVA: 0x000115D4 File Offset: 0x0000F7D4
	// (set) Token: 0x06000057 RID: 87 RVA: 0x000021CE File Offset: 0x000003CE
	public unsafe bool useSetData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_useSetData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_useSetData)) = value;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000058 RID: 88 RVA: 0x000115FC File Offset: 0x0000F7FC
	// (set) Token: 0x06000059 RID: 89 RVA: 0x000021E9 File Offset: 0x000003E9
	public unsafe LeanAudioStream stream
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_stream);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeanAudioStream>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeFieldInfoPtr_waveStyle;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeFieldInfoPtr_vibrato;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeFieldInfoPtr_modulation;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeFieldInfoPtr_frequencyRate;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeFieldInfoPtr_waveNoiseScale;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeFieldInfoPtr_waveNoiseInfluence;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr_useSetData;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeFieldInfoPtr_stream;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0;

	// Token: 0x02000167 RID: 359
	public enum LeanAudioWaveStyle
	{
		// Token: 0x0400145B RID: 5211
		Sine,
		// Token: 0x0400145C RID: 5212
		Square,
		// Token: 0x0400145D RID: 5213
		Sawtooth,
		// Token: 0x0400145E RID: 5214
		Noise
	}
}
