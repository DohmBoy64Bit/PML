using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class LTBezierPath : global::Il2CppSystem.Object
{
	// Token: 0x0600018F RID: 399 RVA: 0x00017AB4 File Offset: 0x00015CB4
	// Note: this type is marked as 'beforefieldinit'.
	static LTBezierPath()
	{
		Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTBezierPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr);
		LTBezierPath.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "pts");
		LTBezierPath.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "length");
		LTBezierPath.NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "orientToPath");
		LTBezierPath.NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "orientToPath2d");
		LTBezierPath.NativeFieldInfoPtr_beziers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "beziers");
		LTBezierPath.NativeFieldInfoPtr_lengthRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "lengthRatio");
		LTBezierPath.NativeFieldInfoPtr_currentBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "currentBezier");
		LTBezierPath.NativeFieldInfoPtr_previousBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "previousBezier");
		LTBezierPath.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663599);
		LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663596);
		LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663597);
		LTBezierPath.NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663598);
		LTBezierPath.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663600);
		LTBezierPath.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663601);
		LTBezierPath.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663602);
		LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663603);
		LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663604);
		LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663605);
		LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663606);
		LTBezierPath.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663607);
		LTBezierPath.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100663608);
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000190 RID: 400 RVA: 0x00017C88 File Offset: 0x00015E88
	public unsafe float distance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_get_distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00017CC4 File Offset: 0x00015EC4
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTBezierPath()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00017D00 File Offset: 0x00015F00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13315, RefRangeEnd = 13316, XrefRangeStart = 13313, XrefRangeEnd = 13315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTBezierPath(Il2CppStructArray<Vector3> pts_)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00017D4C File Offset: 0x00015F4C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 13344, RefRangeEnd = 13349, XrefRangeStart = 13316, XrefRangeEnd = 13344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPoints(Il2CppStructArray<Vector3> pts_)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00017D90 File Offset: 0x00015F90
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 13351, RefRangeEnd = 13366, XrefRangeStart = 13349, XrefRangeEnd = 13351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 point(float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ratio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00017DDC File Offset: 0x00015FDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13366, XrefRangeEnd = 13372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place2d(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00017E2C File Offset: 0x0001602C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13372, XrefRangeEnd = 13378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal2d(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00017E7C File Offset: 0x0001607C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13378, XrefRangeEnd = 13384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00017ECC File Offset: 0x000160CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13384, XrefRangeEnd = 13388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place(Transform transform, float ratio, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldUp);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00017F30 File Offset: 0x00016130
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13388, XrefRangeEnd = 13393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00017F80 File Offset: 0x00016180
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13393, XrefRangeEnd = 13396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldUp);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00017FE4 File Offset: 0x000161E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13396, XrefRangeEnd = 13402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gizmoDraw(float t = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00018024 File Offset: 0x00016224
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13402, XrefRangeEnd = 13418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ratioAtPoint(Vector3 pt, float precision = 0.01f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000255C File Offset: 0x0000075C
	public LTBezierPath(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600019E RID: 414 RVA: 0x00018080 File Offset: 0x00016280
	// (set) Token: 0x0600019F RID: 415 RVA: 0x00002565 File Offset: 0x00000765
	public unsafe Il2CppStructArray<Vector3> pts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_pts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x000180B0 File Offset: 0x000162B0
	// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002584 File Offset: 0x00000784
	public unsafe float length
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_length);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_length)) = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x000180D8 File Offset: 0x000162D8
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000259F File Offset: 0x0000079F
	public unsafe bool orientToPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath)) = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x00018100 File Offset: 0x00016300
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x000025BA File Offset: 0x000007BA
	public unsafe bool orientToPath2d
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath2d);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath2d)) = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x00018128 File Offset: 0x00016328
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x000025D5 File Offset: 0x000007D5
	public unsafe Il2CppReferenceArray<LTBezier> beziers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_beziers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LTBezier>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_beziers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x00018158 File Offset: 0x00016358
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x000025F4 File Offset: 0x000007F4
	public unsafe Il2CppStructArray<float> lengthRatio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_lengthRatio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_lengthRatio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00018188 File Offset: 0x00016388
	// (set) Token: 0x060001AB RID: 427 RVA: 0x00002613 File Offset: 0x00000813
	public unsafe int currentBezier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_currentBezier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_currentBezier)) = value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060001AC RID: 428 RVA: 0x000181B0 File Offset: 0x000163B0
	// (set) Token: 0x060001AD RID: 429 RVA: 0x0000262E File Offset: 0x0000082E
	public unsafe int previousBezier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_previousBezier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_previousBezier)) = value;
		}
	}

	// Token: 0x0400019F RID: 415
	private static readonly IntPtr NativeFieldInfoPtr_pts;

	// Token: 0x040001A0 RID: 416
	private static readonly IntPtr NativeFieldInfoPtr_length;

	// Token: 0x040001A1 RID: 417
	private static readonly IntPtr NativeFieldInfoPtr_orientToPath;

	// Token: 0x040001A2 RID: 418
	private static readonly IntPtr NativeFieldInfoPtr_orientToPath2d;

	// Token: 0x040001A3 RID: 419
	private static readonly IntPtr NativeFieldInfoPtr_beziers;

	// Token: 0x040001A4 RID: 420
	private static readonly IntPtr NativeFieldInfoPtr_lengthRatio;

	// Token: 0x040001A5 RID: 421
	private static readonly IntPtr NativeFieldInfoPtr_currentBezier;

	// Token: 0x040001A6 RID: 422
	private static readonly IntPtr NativeFieldInfoPtr_previousBezier;

	// Token: 0x040001A7 RID: 423
	private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

	// Token: 0x040001A8 RID: 424
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040001A9 RID: 425
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;

	// Token: 0x040001AA RID: 426
	private static readonly IntPtr NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0;

	// Token: 0x040001AB RID: 427
	private static readonly IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

	// Token: 0x040001AC RID: 428
	private static readonly IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;

	// Token: 0x040001AD RID: 429
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;

	// Token: 0x040001AE RID: 430
	private static readonly IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;

	// Token: 0x040001AF RID: 431
	private static readonly IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;

	// Token: 0x040001B0 RID: 432
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;

	// Token: 0x040001B1 RID: 433
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;

	// Token: 0x040001B2 RID: 434
	private static readonly IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;

	// Token: 0x040001B3 RID: 435
	private static readonly IntPtr NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0;
}
