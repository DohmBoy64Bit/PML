using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000267 RID: 615
	public class LuaQuaternion : global::Il2CppSystem.Object
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x000DA410 File Offset: 0x000D8610
		// Note: this type is marked as 'beforefieldinit'.
		static LuaQuaternion()
		{
			Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaQuaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr);
			LuaQuaternion.NativeMethodInfoPtr_get_Identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670426);
			LuaQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670427);
			LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670408);
			LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670409);
			LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670410);
			LuaQuaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670411);
			LuaQuaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670412);
			LuaQuaternion.NativeMethodInfoPtr_Dot_Public_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670413);
			LuaQuaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670414);
			LuaQuaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670415);
			LuaQuaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670416);
			LuaQuaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670417);
			LuaQuaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670418);
			LuaQuaternion.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670419);
			LuaQuaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670420);
			LuaQuaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670421);
			LuaQuaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670422);
			LuaQuaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670423);
			LuaQuaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670424);
			LuaQuaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr, 100670425);
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000DA5D0 File Offset: 0x000D87D0
		public unsafe static Quaternion Identity
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100165, RefRangeEnd = 100168, XrefRangeStart = 100163, XrefRangeEnd = 100165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_get_Identity_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x000DA604 File Offset: 0x000D8804
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaQuaternion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaQuaternion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x000DA640 File Offset: 0x000D8840
		[CallerCount(0)]
		public unsafe static Quaternion New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000DA674 File Offset: 0x000D8874
		[CallerCount(0)]
		public unsafe static Quaternion New(float d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000DA6B4 File Offset: 0x000D88B4
		[CallerCount(0)]
		public unsafe static Quaternion New(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000DA720 File Offset: 0x000D8920
		[CallerCount(0)]
		public unsafe static float Angle(Quaternion a, Quaternion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000DA774 File Offset: 0x000D8974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100168, XrefRangeEnd = 100169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000DA7C8 File Offset: 0x000D89C8
		[CallerCount(0)]
		public unsafe float Dot(Quaternion a, Quaternion b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Dot_Public_Single_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x000DA828 File Offset: 0x000D8A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100169, XrefRangeEnd = 100170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000DA884 File Offset: 0x000D8A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100170, XrefRangeEnd = 100171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(euler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000DA8C8 File Offset: 0x000D8AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100171, XrefRangeEnd = 100172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toDirection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000DA920 File Offset: 0x000D8B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100172, XrefRangeEnd = 100173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Inverse(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000DA964 File Offset: 0x000D8B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100173, XrefRangeEnd = 100174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000DA9C8 File Offset: 0x000D8BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100174, XrefRangeEnd = 100175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000DAA2C File Offset: 0x000D8C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100175, XrefRangeEnd = 100178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forward);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000DAA70 File Offset: 0x000D8C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100178, XrefRangeEnd = 100179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forward);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upwards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000DAAC8 File Offset: 0x000D8CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100179, XrefRangeEnd = 100186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Normalize(Quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000DAB0C File Offset: 0x000D8D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100186, XrefRangeEnd = 100189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDegreesDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000DAB70 File Offset: 0x000D8D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100189, XrefRangeEnd = 100190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000DABD4 File Offset: 0x000D8DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100190, XrefRangeEnd = 100191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaQuaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00012F90 File Offset: 0x00011190
		public LuaQuaternion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeMethodInfoPtr_get_Identity_Public_Static_get_Quaternion_0;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Quaternion_0;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Quaternion_Single_Single_Single_Single_0;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Single_Quaternion_Quaternion_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;
	}
}
