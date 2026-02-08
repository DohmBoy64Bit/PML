using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000007 RID: 7
public class UniformModifier : ProceduralImageModifier
{
	// Token: 0x06000029 RID: 41 RVA: 0x000217DC File Offset: 0x0001F9DC
	// Note: this type is marked as 'beforefieldinit'.
	static UniformModifier()
	{
		Il2CppClassPointerStore<UniformModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UniformModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr);
		UniformModifier.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr, "radius");
		UniformModifier.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr, 100663315);
		UniformModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr, 100663316);
		UniformModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr, 100663318);
		UniformModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr, 100663317);
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00021870 File Offset: 0x0001FA70
	// (set) Token: 0x0600002B RID: 43 RVA: 0x000218AC File Offset: 0x0001FAAC
	public unsafe float Radius
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniformModifier.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniformModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000218EC File Offset: 0x0001FAEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55688, RefRangeEnd = 55689, XrefRangeStart = 55688, XrefRangeEnd = 55689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniformModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniformModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniformModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00021928 File Offset: 0x0001FB28
	[CallerCount(0)]
	public unsafe override Vector4 CalculateRadius(Rect imageRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniformModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002122 File Offset: 0x00000322
	public UniformModifier(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600002F RID: 47 RVA: 0x00021984 File Offset: 0x0001FB84
	// (set) Token: 0x06000030 RID: 48 RVA: 0x0000212B File Offset: 0x0000032B
	public unsafe float radius
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniformModifier.NativeFieldInfoPtr_radius);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniformModifier.NativeFieldInfoPtr_radius)) = value;
		}
	}

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeFieldInfoPtr_radius;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0;
}
