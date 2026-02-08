using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020A RID: 522
	public static class ObjectPositionCalculator : global::Il2CppSystem.Object
	{
		// Token: 0x06002993 RID: 10643 RVA: 0x000C62B8 File Offset: 0x000C44B8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPositionCalculator()
		{
			Il2CppClassPointerStore<ObjectPositionCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectPositionCalculator");
			ObjectPositionCalculator.NativeFieldInfoPtr__boundsQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPositionCalculator>.NativeClassPtr, "_boundsQConfig");
			ObjectPositionCalculator.NativeMethodInfoPtr_CalculateRootPosition_Public_Static_Vector3_GameObject_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPositionCalculator>.NativeClassPtr, 100669656);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000C6308 File Offset: 0x000C4508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92299, XrefRangeEnd = 92319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalculateRootPosition(GameObject root, Vector3 desiredOBBCenter, Vector3 desiredWorldScale, Quaternion desiredWorldRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredOBBCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredWorldScale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredWorldRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPositionCalculator.NativeMethodInfoPtr_CalculateRootPosition_Public_Static_Vector3_GameObject_Vector3_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0001062D File Offset: 0x0000E82D
		public ObjectPositionCalculator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000C6384 File Offset: 0x000C4584
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x00010636 File Offset: 0x0000E836
		public unsafe static ObjectBounds.QueryConfig _boundsQConfig
		{
			get
			{
				ObjectBounds.QueryConfig queryConfig;
				IL2CPP.il2cpp_field_static_get_value(ObjectPositionCalculator.NativeFieldInfoPtr__boundsQConfig, (void*)(&queryConfig));
				return queryConfig;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectPositionCalculator.NativeFieldInfoPtr__boundsQConfig, (void*)(&value));
			}
		}

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr__boundsQConfig;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRootPosition_Public_Static_Vector3_GameObject_Vector3_Vector3_Quaternion_0;
	}
}
