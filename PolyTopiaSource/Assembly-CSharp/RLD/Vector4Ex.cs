using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000132 RID: 306
	public static class Vector4Ex : global::Il2CppSystem.Object
	{
		// Token: 0x06001BD8 RID: 7128 RVA: 0x0000BDAF File Offset: 0x00009FAF
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4Ex()
		{
			Il2CppClassPointerStore<Vector4Ex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Vector4Ex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Ex>.NativeClassPtr);
			Vector4Ex.NativeMethodInfoPtr_FromVector3_Public_Static_Vector4_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Ex>.NativeClassPtr, 100667484);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0008E28C File Offset: 0x0008C48C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 76359, RefRangeEnd = 76409, XrefRangeStart = 76359, XrefRangeEnd = 76409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 FromVector3(Vector3 vec, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Ex.NativeMethodInfoPtr_FromVector3_Public_Static_Vector4_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public Vector4Ex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_FromVector3_Public_Static_Vector4_Vector3_Single_0;
	}
}
