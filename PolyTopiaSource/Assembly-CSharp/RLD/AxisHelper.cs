using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000140 RID: 320
	public static class AxisHelper : global::Il2CppSystem.Object
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x000920F0 File Offset: 0x000902F0
		// Note: this type is marked as 'beforefieldinit'.
		static AxisHelper()
		{
			Il2CppClassPointerStore<AxisHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "AxisHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisHelper>.NativeClassPtr);
			AxisHelper.NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisHelper>.NativeClassPtr, 100667640);
			AxisHelper.NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisHelper>.NativeClassPtr, 100667641);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00092148 File Offset: 0x00090348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78931, XrefRangeEnd = 78933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetWorldAxis(Axis axis)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisHelper.NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0009218C File Offset: 0x0009038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78933, XrefRangeEnd = 78935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetWorldAxis(Axis axis, AxisSign axisSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisHelper.NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_AxisSign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		public AxisHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldAxis_Public_Static_Vector3_Axis_AxisSign_0;
	}
}
