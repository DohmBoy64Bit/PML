using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000269 RID: 617
	public class LuaVector3 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F7A RID: 12154 RVA: 0x000DAE30 File Offset: 0x000D9030
		// Note: this type is marked as 'beforefieldinit'.
		static LuaVector3()
		{
			Il2CppClassPointerStore<LuaVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr);
			LuaVector3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670457);
			LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670433);
			LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670434);
			LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670435);
			LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670436);
			LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670437);
			LuaVector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670438);
			LuaVector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670439);
			LuaVector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670440);
			LuaVector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670441);
			LuaVector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670442);
			LuaVector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670443);
			LuaVector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670444);
			LuaVector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670445);
			LuaVector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670446);
			LuaVector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670447);
			LuaVector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670448);
			LuaVector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670449);
			LuaVector3.NativeMethodInfoPtr_Reflect_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670450);
			LuaVector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670451);
			LuaVector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670452);
			LuaVector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670453);
			LuaVector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670454);
			LuaVector3.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670455);
			LuaVector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr, 100670456);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000DB054 File Offset: 0x000D9254
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaVector3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaVector3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000DB090 File Offset: 0x000D9290
		[CallerCount(0)]
		public unsafe static Vector3 New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000DB0C4 File Offset: 0x000D92C4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 78030, RefRangeEnd = 78057, XrefRangeStart = 78030, XrefRangeEnd = 78057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 New(float d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000DB104 File Offset: 0x000D9304
		[CallerCount(0)]
		public unsafe static Vector3 New(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000DB154 File Offset: 0x000D9354
		[CallerCount(0)]
		public unsafe static Vector3 New(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000DB1B0 File Offset: 0x000D93B0
		[CallerCount(0)]
		public unsafe static Vector3 New(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_New_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000DB1F4 File Offset: 0x000D93F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100192, XrefRangeEnd = 100193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000DB248 File Offset: 0x000D9448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100193, XrefRangeEnd = 100199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000DB29C File Offset: 0x000D949C
		[CallerCount(0)]
		public unsafe static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x000DB2F4 File Offset: 0x000D94F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100199, XrefRangeEnd = 100204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x000DB348 File Offset: 0x000D9548
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 78011, RefRangeEnd = 78018, XrefRangeStart = 78011, XrefRangeEnd = 78018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Dot(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000DB39C File Offset: 0x000D959C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100204, XrefRangeEnd = 100205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Lerp(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000DB400 File Offset: 0x000D9600
		[CallerCount(0)]
		public unsafe static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000DB458 File Offset: 0x000D9658
		[CallerCount(0)]
		public unsafe static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000DB4B0 File Offset: 0x000D96B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100205, XrefRangeEnd = 100211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistanceDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000DB514 File Offset: 0x000D9714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100211, XrefRangeEnd = 100215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Normalize(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000DB558 File Offset: 0x000D9758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100215, XrefRangeEnd = 100220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onNormal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000DB5B0 File Offset: 0x000D97B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100220, XrefRangeEnd = 100223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeNormal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000DB608 File Offset: 0x000D9808
		[CallerCount(0)]
		public unsafe static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inNormal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Reflect_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000DB660 File Offset: 0x000D9860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100223, XrefRangeEnd = 100224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadiansDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxMagnitudeDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000DB6D4 File Offset: 0x000D98D4
		[CallerCount(0)]
		public unsafe static Vector3 Scale(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x000DB72C File Offset: 0x000D992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100224, XrefRangeEnd = 100226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000DB794 File Offset: 0x000D9994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100226, XrefRangeEnd = 100227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Slerp(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000DB7F8 File Offset: 0x000D99F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100227, XrefRangeEnd = 100228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000DB85C File Offset: 0x000D9A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100228, XrefRangeEnd = 100229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaVector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00012FA2 File Offset: 0x000111A2
		public LuaVector3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_0;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_Single_0;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_0;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_Single_Single_Single_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Vector3_Vector2_0;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_Reflect_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;
	}
}
