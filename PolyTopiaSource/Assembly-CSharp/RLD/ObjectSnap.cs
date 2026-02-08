using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020B RID: 523
	public static class ObjectSnap : global::Il2CppSystem.Object
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x000C63A0 File Offset: 0x000C45A0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSnap()
		{
			Il2CppClassPointerStore<ObjectSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSnap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSnap>.NativeClassPtr);
			ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_Void_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSnap>.NativeClassPtr, 100669657);
			ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_Void_List_1_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSnap>.NativeClassPtr, 100669658);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000C63F8 File Offset: 0x000C45F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92322, RefRangeEnd = 92323, XrefRangeStart = 92319, XrefRangeEnd = 92322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Snap(GameObject root, Vector3 pivot, Vector3 dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_Void_GameObject_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000C6454 File Offset: 0x000C4654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92323, XrefRangeEnd = 92340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Snap(List<GameObject> roots, Vector3 pivot, Vector3 dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_Void_List_1_GameObject_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00010644 File Offset: 0x0000E844
		public ObjectSnap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_Snap_Public_Static_Void_GameObject_Vector3_Vector3_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_Snap_Public_Static_Void_List_1_GameObject_Vector3_Vector3_0;
	}
}
