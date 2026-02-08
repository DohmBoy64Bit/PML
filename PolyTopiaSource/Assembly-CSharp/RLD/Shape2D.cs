using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E8 RID: 488
	public class Shape2D : global::Il2CppSystem.Object
	{
		// Token: 0x060027F0 RID: 10224 RVA: 0x000BFD84 File Offset: 0x000BDF84
		// Note: this type is marked as 'beforefieldinit'.
		static Shape2D()
		{
			Il2CppClassPointerStore<Shape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Shape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shape2D>.NativeClassPtr);
			Shape2D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape2D>.NativeClassPtr, 100669390);
			Shape2D.NativeMethodInfoPtr_RenderArea_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape2D>.NativeClassPtr, 100669386);
			Shape2D.NativeMethodInfoPtr_RenderBorder_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape2D>.NativeClassPtr, 100669387);
			Shape2D.NativeMethodInfoPtr_ContainsPoint_Public_Abstract_Virtual_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape2D>.NativeClassPtr, 100669388);
			Shape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Abstract_Virtual_New_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape2D>.NativeClassPtr, 100669389);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000BFE18 File Offset: 0x000BE018
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shape2D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000BFE54 File Offset: 0x000BE054
		[CallerCount(0)]
		public unsafe virtual void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape2D.NativeMethodInfoPtr_RenderArea_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000BFEA4 File Offset: 0x000BE0A4
		[CallerCount(0)]
		public unsafe virtual void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape2D.NativeMethodInfoPtr_RenderBorder_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000BFEF4 File Offset: 0x000BE0F4
		[CallerCount(0)]
		public unsafe virtual bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape2D.NativeMethodInfoPtr_ContainsPoint_Public_Abstract_Virtual_New_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000BFF4C File Offset: 0x000BE14C
		[CallerCount(0)]
		public unsafe virtual Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Abstract_Virtual_New_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0000FDFB File Offset: 0x0000DFFB
		public Shape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Abstract_Virtual_New_Boolean_Vector2_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Abstract_Virtual_New_Rect_0;
	}
}
