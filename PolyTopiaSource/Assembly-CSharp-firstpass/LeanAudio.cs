using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class LeanAudio : global::Il2CppSystem.Object
{
	// Token: 0x06000024 RID: 36 RVA: 0x00010994 File Offset: 0x0000EB94
	// Note: this type is marked as 'beforefieldinit'.
	static LeanAudio()
	{
		Il2CppClassPointerStore<LeanAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudio");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr);
		LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "MIN_FREQEUNCY_PERIOD");
		LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "PROCESSING_ITERATIONS_MAX");
		LeanAudio.NativeFieldInfoPtr_generatedWaveDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "generatedWaveDistances");
		LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "generatedWaveDistancesCount");
		LeanAudio.NativeFieldInfoPtr_longList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "longList");
		LeanAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663325);
		LeanAudio.NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663312);
		LeanAudio.NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663313);
		LeanAudio.NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663314);
		LeanAudio.NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663315);
		LeanAudio.NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663316);
		LeanAudio.NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663317);
		LeanAudio.NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663318);
		LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663319);
		LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663320);
		LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663321);
		LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663322);
		LeanAudio.NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663323);
		LeanAudio.NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663324);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00010B40 File Offset: 0x0000ED40
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 6, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanAudio()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00010B7C File Offset: 0x0000ED7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2282, XrefRangeEnd = 2304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LeanAudioOptions options()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioOptions>(intPtr3) : null;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00010BB0 File Offset: 0x0000EDB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2304, XrefRangeEnd = 2313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeanAudioStream>(intPtr3) : null;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00010C18 File Offset: 0x0000EE18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2313, XrefRangeEnd = 2322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00010C80 File Offset: 0x0000EE80
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2359, RefRangeEnd = 2361, XrefRangeStart = 2322, XrefRangeEnd = 2359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00010CE8 File Offset: 0x0000EEE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2415, RefRangeEnd = 2417, XrefRangeStart = 2361, XrefRangeEnd = 2415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref waveLength;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00010D3C File Offset: 0x0000EF3C
	[CallerCount(7535)]
	[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 2417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnAudioSetPosition(int newPosition)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00010D70 File Offset: 0x0000EF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9952, XrefRangeEnd = 9964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequencyRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00010DC4 File Offset: 0x0000EFC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9964, XrefRangeEnd = 9971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00010E18 File Offset: 0x0000F018
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9971, XrefRangeEnd = 9977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00010E5C File Offset: 0x0000F05C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9977, XrefRangeEnd = 9981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, Vector3 pos)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00010EB4 File Offset: 0x0000F0B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9981, XrefRangeEnd = 9987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00010F18 File Offset: 0x0000F118
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 10003, RefRangeEnd = 10007, XrefRangeStart = 9987, XrefRangeEnd = 10003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00010F70 File Offset: 0x0000F170
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10007, XrefRangeEnd = 10026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(curve);
		ptr2 = &intPtr;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleX;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0, 0, (void**)ptr, ref intPtr3);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		curve = ((intPtr4 == 0) ? null : new AnimationCurve(intPtr4));
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000020C4 File Offset: 0x000002C4
	public LeanAudio(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000034 RID: 52 RVA: 0x00010FDC File Offset: 0x0000F1DC
	// (set) Token: 0x06000035 RID: 53 RVA: 0x000020CD File Offset: 0x000002CD
	public unsafe static float MIN_FREQEUNCY_PERIOD
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, (void*)(&value));
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00010FF8 File Offset: 0x0000F1F8
	// (set) Token: 0x06000037 RID: 55 RVA: 0x000020DB File Offset: 0x000002DB
	public unsafe static int PROCESSING_ITERATIONS_MAX
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000038 RID: 56 RVA: 0x00011014 File Offset: 0x0000F214
	// (set) Token: 0x06000039 RID: 57 RVA: 0x000020E9 File Offset: 0x000002E9
	public unsafe static Il2CppStructArray<float> generatedWaveDistances
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistances, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistances, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600003A RID: 58 RVA: 0x0001103C File Offset: 0x0000F23C
	// (set) Token: 0x0600003B RID: 59 RVA: 0x000020FB File Offset: 0x000002FB
	public unsafe static int generatedWaveDistancesCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount, (void*)(&value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600003C RID: 60 RVA: 0x00011058 File Offset: 0x0000F258
	// (set) Token: 0x0600003D RID: 61 RVA: 0x00002109 File Offset: 0x00000309
	public unsafe static Il2CppStructArray<float> longList
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_longList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_longList, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeFieldInfoPtr_generatedWaveDistances;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeFieldInfoPtr_generatedWaveDistancesCount;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr_longList;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0;
}
