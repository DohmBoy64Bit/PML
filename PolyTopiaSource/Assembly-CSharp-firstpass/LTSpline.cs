using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Serializable]
public class LTSpline : global::Il2CppSystem.Object
{
	// Token: 0x060001AE RID: 430 RVA: 0x000181D8 File Offset: 0x000163D8
	// Note: this type is marked as 'beforefieldinit'.
	static LTSpline()
	{
		Il2CppClassPointerStore<LTSpline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTSpline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTSpline>.NativeClassPtr);
		LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "DISTANCE_COUNT");
		LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "SUBLINE_COUNT");
		LTSpline.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "distance");
		LTSpline.NativeFieldInfoPtr_constantSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "constantSpeed");
		LTSpline.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "pts");
		LTSpline.NativeFieldInfoPtr_ptsAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "ptsAdj");
		LTSpline.NativeFieldInfoPtr_ptsAdjLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "ptsAdjLength");
		LTSpline.NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "orientToPath");
		LTSpline.NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "orientToPath2d");
		LTSpline.NativeFieldInfoPtr_numSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "numSections");
		LTSpline.NativeFieldInfoPtr_currPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "currPt");
		LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663609);
		LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663610);
		LTSpline.NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663611);
		LTSpline.NativeMethodInfoPtr_map_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663612);
		LTSpline.NativeMethodInfoPtr_interp_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663613);
		LTSpline.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663614);
		LTSpline.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663615);
		LTSpline.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663616);
		LTSpline.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663617);
		LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663618);
		LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663619);
		LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663620);
		LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663621);
		LTSpline.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663622);
		LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663623);
		LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663624);
		LTSpline.NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663625);
		LTSpline.NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663626);
		LTSpline.NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100663627);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00018460 File Offset: 0x00016660
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13420, RefRangeEnd = 13421, XrefRangeStart = 13418, XrefRangeEnd = 13420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSpline(Il2CppStructArray<Vector3> pts)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x000184AC File Offset: 0x000166AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13421, XrefRangeEnd = 13423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSpline(Il2CppStructArray<Vector3> pts, bool constantSpeed)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constantSpeed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00018508 File Offset: 0x00016708
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 13451, RefRangeEnd = 13456, XrefRangeStart = 13423, XrefRangeEnd = 13451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(Il2CppStructArray<Vector3> pts, bool constantSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constantSpeed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00018558 File Offset: 0x00016758
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13456, XrefRangeEnd = 13458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 map(float u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref u;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_map_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x000185A4 File Offset: 0x000167A4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 13462, RefRangeEnd = 13466, XrefRangeStart = 13458, XrefRangeEnd = 13462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 interp(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_interp_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x000185F0 File Offset: 0x000167F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13466, XrefRangeEnd = 13471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ratioAtPoint(Vector3 pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00018640 File Offset: 0x00016840
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 13474, RefRangeEnd = 13488, XrefRangeStart = 13471, XrefRangeEnd = 13474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 point(float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ratio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0001868C File Offset: 0x0001688C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13488, XrefRangeEnd = 13494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x000186DC File Offset: 0x000168DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13494, XrefRangeEnd = 13505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0001872C File Offset: 0x0001692C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13505, XrefRangeEnd = 13511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0001877C File Offset: 0x0001697C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13511, XrefRangeEnd = 13515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000187E0 File Offset: 0x000169E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13515, XrefRangeEnd = 13523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00018830 File Offset: 0x00016A30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13523, XrefRangeEnd = 13529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00018894 File Offset: 0x00016A94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13529, XrefRangeEnd = 13530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gizmoDraw(float t = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000188D4 File Offset: 0x00016AD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13530, XrefRangeEnd = 13534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawGizmo(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00018918 File Offset: 0x00016B18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13534, XrefRangeEnd = 13549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawGizmo(Il2CppReferenceArray<Transform> arr, Color color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00018960 File Offset: 0x00016B60
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 13549, RefRangeEnd = 13553, XrefRangeStart = 13549, XrefRangeEnd = 13549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawLine(Il2CppReferenceArray<Transform> arr, float width, Color color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x000189B8 File Offset: 0x00016BB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13553, XrefRangeEnd = 13568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outlineMaterial);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00018A1C File Offset: 0x00016C1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13568, XrefRangeEnd = 13585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Vector3> generateVectors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002649 File Offset: 0x00000849
	public LTSpline(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060001C3 RID: 451 RVA: 0x00018A5C File Offset: 0x00016C5C
	// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002652 File Offset: 0x00000852
	public unsafe static int DISTANCE_COUNT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT, (void*)(&value));
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060001C5 RID: 453 RVA: 0x00018A78 File Offset: 0x00016C78
	// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002660 File Offset: 0x00000860
	public unsafe static int SUBLINE_COUNT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT, (void*)(&value));
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060001C7 RID: 455 RVA: 0x00018A94 File Offset: 0x00016C94
	// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000266E File Offset: 0x0000086E
	public unsafe float distance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_distance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_distance)) = value;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060001C9 RID: 457 RVA: 0x00018ABC File Offset: 0x00016CBC
	// (set) Token: 0x060001CA RID: 458 RVA: 0x00002689 File Offset: 0x00000889
	public unsafe bool constantSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_constantSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_constantSpeed)) = value;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060001CB RID: 459 RVA: 0x00018AE4 File Offset: 0x00016CE4
	// (set) Token: 0x060001CC RID: 460 RVA: 0x000026A4 File Offset: 0x000008A4
	public unsafe Il2CppStructArray<Vector3> pts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_pts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060001CD RID: 461 RVA: 0x00018B14 File Offset: 0x00016D14
	// (set) Token: 0x060001CE RID: 462 RVA: 0x000026C3 File Offset: 0x000008C3
	public unsafe Il2CppStructArray<Vector3> ptsAdj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060001CF RID: 463 RVA: 0x00018B44 File Offset: 0x00016D44
	// (set) Token: 0x060001D0 RID: 464 RVA: 0x000026E2 File Offset: 0x000008E2
	public unsafe int ptsAdjLength
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdjLength);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdjLength)) = value;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x00018B6C File Offset: 0x00016D6C
	// (set) Token: 0x060001D2 RID: 466 RVA: 0x000026FD File Offset: 0x000008FD
	public unsafe bool orientToPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath)) = value;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060001D3 RID: 467 RVA: 0x00018B94 File Offset: 0x00016D94
	// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002718 File Offset: 0x00000918
	public unsafe bool orientToPath2d
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath2d);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath2d)) = value;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x00018BBC File Offset: 0x00016DBC
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002733 File Offset: 0x00000933
	public unsafe int numSections
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_numSections);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_numSections)) = value;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x00018BE4 File Offset: 0x00016DE4
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000274E File Offset: 0x0000094E
	public unsafe int currPt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_currPt);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_currPt)) = value;
		}
	}

	// Token: 0x040001B4 RID: 436
	private static readonly IntPtr NativeFieldInfoPtr_DISTANCE_COUNT;

	// Token: 0x040001B5 RID: 437
	private static readonly IntPtr NativeFieldInfoPtr_SUBLINE_COUNT;

	// Token: 0x040001B6 RID: 438
	private static readonly IntPtr NativeFieldInfoPtr_distance;

	// Token: 0x040001B7 RID: 439
	private static readonly IntPtr NativeFieldInfoPtr_constantSpeed;

	// Token: 0x040001B8 RID: 440
	private static readonly IntPtr NativeFieldInfoPtr_pts;

	// Token: 0x040001B9 RID: 441
	private static readonly IntPtr NativeFieldInfoPtr_ptsAdj;

	// Token: 0x040001BA RID: 442
	private static readonly IntPtr NativeFieldInfoPtr_ptsAdjLength;

	// Token: 0x040001BB RID: 443
	private static readonly IntPtr NativeFieldInfoPtr_orientToPath;

	// Token: 0x040001BC RID: 444
	private static readonly IntPtr NativeFieldInfoPtr_orientToPath2d;

	// Token: 0x040001BD RID: 445
	private static readonly IntPtr NativeFieldInfoPtr_numSections;

	// Token: 0x040001BE RID: 446
	private static readonly IntPtr NativeFieldInfoPtr_currPt;

	// Token: 0x040001BF RID: 447
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;

	// Token: 0x040001C0 RID: 448
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0;

	// Token: 0x040001C1 RID: 449
	private static readonly IntPtr NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0;

	// Token: 0x040001C2 RID: 450
	private static readonly IntPtr NativeMethodInfoPtr_map_Public_Vector3_Single_0;

	// Token: 0x040001C3 RID: 451
	private static readonly IntPtr NativeMethodInfoPtr_interp_Public_Vector3_Single_0;

	// Token: 0x040001C4 RID: 452
	private static readonly IntPtr NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0;

	// Token: 0x040001C5 RID: 453
	private static readonly IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

	// Token: 0x040001C6 RID: 454
	private static readonly IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;

	// Token: 0x040001C7 RID: 455
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;

	// Token: 0x040001C8 RID: 456
	private static readonly IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;

	// Token: 0x040001C9 RID: 457
	private static readonly IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;

	// Token: 0x040001CA RID: 458
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;

	// Token: 0x040001CB RID: 459
	private static readonly IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;

	// Token: 0x040001CC RID: 460
	private static readonly IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;

	// Token: 0x040001CD RID: 461
	private static readonly IntPtr NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0;

	// Token: 0x040001CE RID: 462
	private static readonly IntPtr NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;

	// Token: 0x040001CF RID: 463
	private static readonly IntPtr NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0;

	// Token: 0x040001D0 RID: 464
	private static readonly IntPtr NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0;

	// Token: 0x040001D1 RID: 465
	private static readonly IntPtr NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0;
}
