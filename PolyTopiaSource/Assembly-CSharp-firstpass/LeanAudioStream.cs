using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class LeanAudioStream : global::Il2CppSystem.Object
{
	// Token: 0x06000019 RID: 25 RVA: 0x00010794 File Offset: 0x0000E994
	// Note: this type is marked as 'beforefieldinit'.
	static LeanAudioStream()
	{
		Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudioStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr);
		LeanAudioStream.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "position");
		LeanAudioStream.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "audioClip");
		LeanAudioStream.NativeFieldInfoPtr_audioArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "audioArr");
		LeanAudioStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663309);
		LeanAudioStream.NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663310);
		LeanAudioStream.NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663311);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0001083C File Offset: 0x0000EA3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 2, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanAudioStream(Il2CppStructArray<float> audioArr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioArr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00010888 File Offset: 0x0000EA88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2, XrefRangeEnd = 3, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAudioRead(Il2CppStructArray<float> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000108CC File Offset: 0x0000EACC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 3, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAudioSetPosition(int newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002062 File Offset: 0x00000262
	public LeanAudioStream(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001E RID: 30 RVA: 0x0001090C File Offset: 0x0000EB0C
	// (set) Token: 0x0600001F RID: 31 RVA: 0x0000206B File Offset: 0x0000026B
	public unsafe int position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_position)) = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00010934 File Offset: 0x0000EB34
	// (set) Token: 0x06000021 RID: 33 RVA: 0x00002086 File Offset: 0x00000286
	public unsafe AudioClip audioClip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioClip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00010964 File Offset: 0x0000EB64
	// (set) Token: 0x06000023 RID: 35 RVA: 0x000020A5 File Offset: 0x000002A5
	public unsafe Il2CppStructArray<float> audioArr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioArr);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioArr), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeFieldInfoPtr_position;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_audioClip;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_audioArr;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0;
}
