using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000005 RID: 5
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	// Token: 0x06000019 RID: 25 RVA: 0x0002143C File Offset: 0x0001F63C
	// Note: this type is marked as 'beforefieldinit'.
	static OnlyOneEdgeModifier()
	{
		Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OnlyOneEdgeModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr);
		OnlyOneEdgeModifier.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, "radius");
		OnlyOneEdgeModifier.NativeFieldInfoPtr_side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, "side");
		OnlyOneEdgeModifier.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663307);
		OnlyOneEdgeModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663308);
		OnlyOneEdgeModifier.NativeMethodInfoPtr_get_Side_Public_get_ProceduralImageEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663309);
		OnlyOneEdgeModifier.NativeMethodInfoPtr_set_Side_Public_set_Void_ProceduralImageEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663310);
		OnlyOneEdgeModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663312);
		OnlyOneEdgeModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr, 100663311);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001A RID: 26 RVA: 0x0002150C File Offset: 0x0001F70C
	// (set) Token: 0x0600001B RID: 27 RVA: 0x00021548 File Offset: 0x0001F748
	public unsafe float Radius
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlyOneEdgeModifier.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55689, XrefRangeEnd = 55691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlyOneEdgeModifier.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001C RID: 28 RVA: 0x00021588 File Offset: 0x0001F788
	// (set) Token: 0x0600001D RID: 29 RVA: 0x000215C4 File Offset: 0x0001F7C4
	public unsafe OnlyOneEdgeModifier.ProceduralImageEdge Side
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28412, RefRangeEnd = 28413, XrefRangeStart = 28412, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlyOneEdgeModifier.NativeMethodInfoPtr_get_Side_Public_get_ProceduralImageEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28413, RefRangeEnd = 28414, XrefRangeStart = 28413, XrefRangeEnd = 28414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlyOneEdgeModifier.NativeMethodInfoPtr_set_Side_Public_set_Void_ProceduralImageEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00021604 File Offset: 0x0001F804
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55688, RefRangeEnd = 55689, XrefRangeStart = 55688, XrefRangeEnd = 55689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OnlyOneEdgeModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlyOneEdgeModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlyOneEdgeModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00021640 File Offset: 0x0001F840
	[CallerCount(0)]
	public unsafe override Vector4 CalculateRadius(Rect imageRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlyOneEdgeModifier.NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000020DA File Offset: 0x000002DA
	public OnlyOneEdgeModifier(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000021 RID: 33 RVA: 0x0002169C File Offset: 0x0001F89C
	// (set) Token: 0x06000022 RID: 34 RVA: 0x000020E3 File Offset: 0x000002E3
	public unsafe float radius
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlyOneEdgeModifier.NativeFieldInfoPtr_radius);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlyOneEdgeModifier.NativeFieldInfoPtr_radius)) = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000023 RID: 35 RVA: 0x000216C4 File Offset: 0x0001F8C4
	// (set) Token: 0x06000024 RID: 36 RVA: 0x000020FE File Offset: 0x000002FE
	public unsafe OnlyOneEdgeModifier.ProceduralImageEdge side
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlyOneEdgeModifier.NativeFieldInfoPtr_side);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlyOneEdgeModifier.NativeFieldInfoPtr_side)) = value;
		}
	}

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_radius;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_side;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_get_Side_Public_get_ProceduralImageEdge_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_set_Side_Public_set_Void_ProceduralImageEdge_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_CalculateRadius_Public_Virtual_Vector4_Rect_0;

	// Token: 0x02000348 RID: 840
	public enum ProceduralImageEdge
	{
		// Token: 0x040038A8 RID: 14504
		Top,
		// Token: 0x040038A9 RID: 14505
		Bottom,
		// Token: 0x040038AA RID: 14506
		Left,
		// Token: 0x040038AB RID: 14507
		Right
	}
}
