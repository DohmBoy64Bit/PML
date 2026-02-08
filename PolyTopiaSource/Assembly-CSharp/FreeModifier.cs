using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000004 RID: 4
public class FreeModifier : ProceduralImageModifier
{
	// Token: 0x06000010 RID: 16 RVA: 0x00021214 File Offset: 0x0001F414
	// Note: this type is marked as 'beforefieldinit'.
	static FreeModifier()
	{
		Il2CppClassPointerStore<FreeModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FreeModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr);
		FreeModifier.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, "radius");
		FreeModifier.NativeMethodInfoPtr_get_Radius_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, 100663302);
		FreeModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, 100663303);
		FreeModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, 100663306);
		FreeModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, 100663304);
		FreeModifier.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr, 100663305);
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000212BC File Offset: 0x0001F4BC
	// (set) Token: 0x06000012 RID: 18 RVA: 0x000212FC File Offset: 0x0001F4FC
	public unsafe Vector4 Radius
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeModifier.NativeMethodInfoPtr_get_Radius_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55685, XrefRangeEnd = 55687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00021340 File Offset: 0x0001F540
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55688, RefRangeEnd = 55689, XrefRangeStart = 55687, XrefRangeEnd = 55688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FreeModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0002137C File Offset: 0x0001F57C
	[CallerCount(0)]
	public unsafe override Vector4 CalculateRadius(Rect imageRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreeModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000213D8 File Offset: 0x0001F5D8
	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeModifier.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000020B2 File Offset: 0x000002B2
	public FreeModifier(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000017 RID: 23 RVA: 0x0002140C File Offset: 0x0001F60C
	// (set) Token: 0x06000018 RID: 24 RVA: 0x000020BB File Offset: 0x000002BB
	public unsafe Vector4 radius
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeModifier.NativeFieldInfoPtr_radius);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeModifier.NativeFieldInfoPtr_radius), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_radius;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Vector4_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Vector4_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;
}
