using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AC RID: 428
	public class IXZGrid : global::Il2CppSystem.Object
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x000A56A0 File Offset: 0x000A38A0
		// Note: this type is marked as 'beforefieldinit'.
		static IXZGrid()
		{
			Il2CppClassPointerStore<IXZGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IXZGrid");
			IXZGrid.NativeMethodInfoPtr_get_WorldPlane_Public_Abstract_Virtual_New_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXZGrid>.NativeClassPtr, 100668347);
			IXZGrid.NativeMethodInfoPtr_get_WorldMatrix_Public_Abstract_Virtual_New_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXZGrid>.NativeClassPtr, 100668348);
			IXZGrid.NativeMethodInfoPtr_CellFromWorldPoint_Public_Abstract_Virtual_New_XZGridCell_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXZGrid>.NativeClassPtr, 100668349);
			IXZGrid.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXZGrid>.NativeClassPtr, 100668350);
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x000A5718 File Offset: 0x000A3918
		public unsafe virtual Plane WorldPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXZGrid.NativeMethodInfoPtr_get_WorldPlane_Public_Abstract_Virtual_New_get_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000A5764 File Offset: 0x000A3964
		public unsafe virtual Matrix4x4 WorldMatrix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXZGrid.NativeMethodInfoPtr_get_WorldMatrix_Public_Abstract_Virtual_New_get_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
			}
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000A57B0 File Offset: 0x000A39B0
		[CallerCount(0)]
		public unsafe virtual XZGridCell CellFromWorldPoint(Vector3 worldPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(worldPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXZGrid.NativeMethodInfoPtr_CellFromWorldPoint_Public_Abstract_Virtual_New_XZGridCell_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridCell>(intPtr3) : null;
			}
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000A580C File Offset: 0x000A3A0C
		[CallerCount(0)]
		public unsafe virtual bool Raycast(Ray ray, out float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXZGrid.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0000D8F6 File Offset: 0x0000BAF6
		public IXZGrid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldPlane_Public_Abstract_Virtual_New_get_Plane_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldMatrix_Public_Abstract_Virtual_New_get_Matrix4x4_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_CellFromWorldPoint_Public_Abstract_Virtual_New_XZGridCell_Vector3_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0;
	}
}
