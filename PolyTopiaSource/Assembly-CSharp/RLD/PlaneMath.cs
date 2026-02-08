using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000156 RID: 342
	public static class PlaneMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x0000C404 File Offset: 0x0000A604
		// Note: this type is marked as 'beforefieldinit'.
		static PlaneMath()
		{
			Il2CppClassPointerStore<PlaneMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PlaneMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneMath>.NativeClassPtr);
			PlaneMath.NativeMethodInfoPtr_Raycast2D_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneMath>.NativeClassPtr, 100667764);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00095BD0 File Offset: 0x00093DD0
		[CallerCount(0)]
		public unsafe static bool Raycast2D(Vector2 rayOrigin, Vector2 rayDir, Vector2 planeNormal, Vector2 ptOnPlane, out float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rayOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rayDir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeNormal);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptOnPlane);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneMath.NativeMethodInfoPtr_Raycast2D_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0000C43D File Offset: 0x0000A63D
		public PlaneMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_Raycast2D_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_0;
	}
}
