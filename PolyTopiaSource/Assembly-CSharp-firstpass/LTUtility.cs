using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class LTUtility : global::Il2CppSystem.Object
{
	// Token: 0x06000177 RID: 375 RVA: 0x0001761C File Offset: 0x0001581C
	// Note: this type is marked as 'beforefieldinit'.
	static LTUtility()
	{
		Il2CppClassPointerStore<LTUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTUtility>.NativeClassPtr);
		LTUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTUtility>.NativeClassPtr, 100663591);
		LTUtility.NativeMethodInfoPtr_reverse_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTUtility>.NativeClassPtr, 100663590);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00017674 File Offset: 0x00015874
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTUtility>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x000176B0 File Offset: 0x000158B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13299, RefRangeEnd = 13301, XrefRangeStart = 13299, XrefRangeEnd = 13299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> reverse(Il2CppStructArray<Vector3> arr)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTUtility.NativeMethodInfoPtr_reverse_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002479 File Offset: 0x00000679
	public LTUtility(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000192 RID: 402
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000193 RID: 403
	private static readonly IntPtr NativeMethodInfoPtr_reverse_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;
}
