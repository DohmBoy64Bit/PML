using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000006 RID: 6
public class RoundModifier : ProceduralImageModifier
{
	// Token: 0x06000025 RID: 37 RVA: 0x000216EC File Offset: 0x0001F8EC
	// Note: this type is marked as 'beforefieldinit'.
	static RoundModifier()
	{
		Il2CppClassPointerStore<RoundModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoundModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundModifier>.NativeClassPtr);
		RoundModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundModifier>.NativeClassPtr, 100663314);
		RoundModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundModifier>.NativeClassPtr, 100663313);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00021744 File Offset: 0x0001F944
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55688, RefRangeEnd = 55689, XrefRangeStart = 55688, XrefRangeEnd = 55689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoundModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00021780 File Offset: 0x0001F980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55691, XrefRangeEnd = 55694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Vector4 CalculateRadius(Rect imageRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002119 File Offset: 0x00000319
	public RoundModifier(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0;
}
