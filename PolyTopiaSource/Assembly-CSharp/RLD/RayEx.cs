using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000129 RID: 297
	public static class RayEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x0008C9EC File Offset: 0x0008ABEC
		// Note: this type is marked as 'beforefieldinit'.
		static RayEx()
		{
			Il2CppClassPointerStore<RayEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RayEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayEx>.NativeClassPtr);
			RayEx.NativeMethodInfoPtr_InverseTransform_Public_Static_Ray_Ray_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayEx>.NativeClassPtr, 100667425);
			RayEx.NativeMethodInfoPtr_Mirror_Public_Static_Ray_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayEx>.NativeClassPtr, 100667426);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0008CA44 File Offset: 0x0008AC44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 77534, RefRangeEnd = 77539, XrefRangeStart = 77527, XrefRangeEnd = 77534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ray InverseTransform(this Ray ray, Matrix4x4 transformMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformMatrix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayEx.NativeMethodInfoPtr_InverseTransform_Public_Static_Ray_Ray_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0008CA9C File Offset: 0x0008AC9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77542, RefRangeEnd = 77544, XrefRangeStart = 77539, XrefRangeEnd = 77542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ray Mirror(this Ray ray, Vector3 mirrorPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mirrorPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayEx.NativeMethodInfoPtr_Mirror_Public_Static_Ray_Ray_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0000BD67 File Offset: 0x00009F67
		public RayEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransform_Public_Static_Ray_Ray_Matrix4x4_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_Mirror_Public_Static_Ray_Ray_Vector3_0;
	}
}
