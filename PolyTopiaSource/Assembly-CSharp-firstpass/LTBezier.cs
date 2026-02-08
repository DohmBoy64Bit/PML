using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class LTBezier : global::Il2CppSystem.Object
{
	// Token: 0x0600017B RID: 379 RVA: 0x000176F4 File Offset: 0x000158F4
	// Note: this type is marked as 'beforefieldinit'.
	static LTBezier()
	{
		Il2CppClassPointerStore<LTBezier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTBezier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezier>.NativeClassPtr);
		LTBezier.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "length");
		LTBezier.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "a");
		LTBezier.NativeFieldInfoPtr_aa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "aa");
		LTBezier.NativeFieldInfoPtr_bb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "bb");
		LTBezier.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "cc");
		LTBezier.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "len");
		LTBezier.NativeFieldInfoPtr_arcLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "arcLengths");
		LTBezier.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100663592);
		LTBezier.NativeMethodInfoPtr_map_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100663593);
		LTBezier.NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100663594);
		LTBezier.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100663595);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00017800 File Offset: 0x00015A00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13311, RefRangeEnd = 13312, XrefRangeStart = 13301, XrefRangeEnd = 13311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezier>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00017890 File Offset: 0x00015A90
	[CallerCount(0)]
	public unsafe float map(float u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref u;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_map_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000178DC File Offset: 0x00015ADC
	[CallerCount(0)]
	public unsafe Vector3 bezierPoint(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00017928 File Offset: 0x00015B28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13312, RefRangeEnd = 13313, XrefRangeStart = 13312, XrefRangeEnd = 13312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 point(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002482 File Offset: 0x00000682
	public LTBezier(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000181 RID: 385 RVA: 0x00017974 File Offset: 0x00015B74
	// (set) Token: 0x06000182 RID: 386 RVA: 0x0000248B File Offset: 0x0000068B
	public unsafe float length
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_length);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_length)) = value;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000183 RID: 387 RVA: 0x0001799C File Offset: 0x00015B9C
	// (set) Token: 0x06000184 RID: 388 RVA: 0x000024A6 File Offset: 0x000006A6
	public unsafe Vector3 a
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_a);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000185 RID: 389 RVA: 0x000179CC File Offset: 0x00015BCC
	// (set) Token: 0x06000186 RID: 390 RVA: 0x000024C5 File Offset: 0x000006C5
	public unsafe Vector3 aa
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_aa);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_aa), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000187 RID: 391 RVA: 0x000179FC File Offset: 0x00015BFC
	// (set) Token: 0x06000188 RID: 392 RVA: 0x000024E4 File Offset: 0x000006E4
	public unsafe Vector3 bb
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_bb);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_bb), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000189 RID: 393 RVA: 0x00017A2C File Offset: 0x00015C2C
	// (set) Token: 0x0600018A RID: 394 RVA: 0x00002503 File Offset: 0x00000703
	public unsafe Vector3 cc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_cc);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600018B RID: 395 RVA: 0x00017A5C File Offset: 0x00015C5C
	// (set) Token: 0x0600018C RID: 396 RVA: 0x00002522 File Offset: 0x00000722
	public unsafe float len
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_len);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_len)) = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600018D RID: 397 RVA: 0x00017A84 File Offset: 0x00015C84
	// (set) Token: 0x0600018E RID: 398 RVA: 0x0000253D File Offset: 0x0000073D
	public unsafe Il2CppStructArray<float> arcLengths
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_arcLengths);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_arcLengths), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000194 RID: 404
	private static readonly IntPtr NativeFieldInfoPtr_length;

	// Token: 0x04000195 RID: 405
	private static readonly IntPtr NativeFieldInfoPtr_a;

	// Token: 0x04000196 RID: 406
	private static readonly IntPtr NativeFieldInfoPtr_aa;

	// Token: 0x04000197 RID: 407
	private static readonly IntPtr NativeFieldInfoPtr_bb;

	// Token: 0x04000198 RID: 408
	private static readonly IntPtr NativeFieldInfoPtr_cc;

	// Token: 0x04000199 RID: 409
	private static readonly IntPtr NativeFieldInfoPtr_len;

	// Token: 0x0400019A RID: 410
	private static readonly IntPtr NativeFieldInfoPtr_arcLengths;

	// Token: 0x0400019B RID: 411
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0;

	// Token: 0x0400019C RID: 412
	private static readonly IntPtr NativeMethodInfoPtr_map_Private_Single_Single_0;

	// Token: 0x0400019D RID: 413
	private static readonly IntPtr NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0;

	// Token: 0x0400019E RID: 414
	private static readonly IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;
}
