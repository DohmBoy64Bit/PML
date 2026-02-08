using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class LeanSmooth : global::Il2CppSystem.Object
{
	// Token: 0x0600005A RID: 90 RVA: 0x0001162C File Offset: 0x0000F82C
	// Note: this type is marked as 'beforefieldinit'.
	static LeanSmooth()
	{
		Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanSmooth");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr);
		LeanSmooth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663349);
		LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663337);
		LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663338);
		LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663339);
		LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663340);
		LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663341);
		LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663342);
		LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663343);
		LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663344);
		LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663345);
		LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663346);
		LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663347);
		LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100663348);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00011760 File Offset: 0x0000F960
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanSmooth()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0001179C File Offset: 0x0000F99C
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 10031, RefRangeEnd = 10057, XrefRangeStart = 10028, XrefRangeEnd = 10031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float damp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref current;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00011820 File Offset: 0x0000FA20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10057, XrefRangeEnd = 10060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 damp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000118B0 File Offset: 0x0000FAB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10060, XrefRangeEnd = 10064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color damp(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00011940 File Offset: 0x0000FB40
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 10065, RefRangeEnd = 10082, XrefRangeStart = 10064, XrefRangeEnd = 10065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float spring(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref current;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000119E0 File Offset: 0x0000FBE0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 10085, RefRangeEnd = 10088, XrefRangeStart = 10082, XrefRangeEnd = 10085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 spring(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00011A8C File Offset: 0x0000FC8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10088, XrefRangeEnd = 10092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color spring(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00011B38 File Offset: 0x0000FD38
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 10095, RefRangeEnd = 10121, XrefRangeStart = 10092, XrefRangeEnd = 10095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float linear(float current, float target, float moveSpeed, float deltaTime = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref current;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00011BA0 File Offset: 0x0000FDA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10121, XrefRangeEnd = 10124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 linear(Vector3 current, Vector3 target, float moveSpeed, float deltaTime = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00011C14 File Offset: 0x0000FE14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10124, XrefRangeEnd = 10128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color linear(Color current, Color target, float moveSpeed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00011C78 File Offset: 0x0000FE78
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 10130, RefRangeEnd = 10147, XrefRangeStart = 10128, XrefRangeEnd = 10130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float bounceOut(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref current;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitDamping;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00011D28 File Offset: 0x0000FF28
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 10150, RefRangeEnd = 10153, XrefRangeStart = 10147, XrefRangeEnd = 10150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 bounceOut(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitDamping;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00011DE4 File Offset: 0x0000FFE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10153, XrefRangeEnd = 10157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color bounceOut(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitDamping;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002208 File Offset: 0x00000408
	public LeanSmooth(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0;
}
