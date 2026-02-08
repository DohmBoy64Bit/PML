using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000207 RID: 519
	public static class ObjectAlign : global::Il2CppSystem.Object
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x000C58E4 File Offset: 0x000C3AE4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectAlign()
		{
			Il2CppClassPointerStore<ObjectAlign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectAlign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectAlign>.NativeClassPtr);
			ObjectAlign.NativeMethodInfoPtr_AlignToWorldAxis_Public_Static_Result_IEnumerable_1_GameObject_Axis_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAlign>.NativeClassPtr, 100669630);
			ObjectAlign.NativeMethodInfoPtr_AlignToWorldPlane_Public_Static_Result_IEnumerable_1_GameObject_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAlign>.NativeClassPtr, 100669631);
			ObjectAlign.NativeMethodInfoPtr_AlignRootsToPlane_Private_Static_Void_List_1_GameObject_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAlign>.NativeClassPtr, 100669632);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000C5950 File Offset: 0x000C3B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91856, XrefRangeEnd = 91871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectAlign.Result AlignToWorldAxis(IEnumerable<GameObject> gameObjects, Axis axis, Vector3 alignmentPlaneOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignmentPlaneOrigin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAlign.NativeMethodInfoPtr_AlignToWorldAxis_Public_Static_Result_IEnumerable_1_GameObject_Axis_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000C59B8 File Offset: 0x000C3BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91871, XrefRangeEnd = 91877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectAlign.Result AlignToWorldPlane(IEnumerable<GameObject> gameObjects, Plane alignmentPlane)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignmentPlane);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAlign.NativeMethodInfoPtr_AlignToWorldPlane_Public_Static_Result_IEnumerable_1_GameObject_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91915, RefRangeEnd = 91917, XrefRangeStart = 91877, XrefRangeEnd = 91915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignmentPlane);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAlign.NativeMethodInfoPtr_AlignRootsToPlane_Private_Static_Void_List_1_GameObject_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000105ED File Offset: 0x0000E7ED
		public ObjectAlign(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr_AlignToWorldAxis_Public_Static_Result_IEnumerable_1_GameObject_Axis_Vector3_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr_AlignToWorldPlane_Public_Static_Result_IEnumerable_1_GameObject_Plane_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_AlignRootsToPlane_Private_Static_Void_List_1_GameObject_Plane_0;

		// Token: 0x020003C7 RID: 967
		public enum Result
		{
			// Token: 0x04003B7E RID: 15230
			Err_NoObjects,
			// Token: 0x04003B7F RID: 15231
			Success
		}
	}
}
