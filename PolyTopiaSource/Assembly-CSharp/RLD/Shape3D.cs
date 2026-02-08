using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001ED RID: 493
	public class Shape3D : global::Il2CppSystem.Object
	{
		// Token: 0x060027F7 RID: 10231 RVA: 0x000BFF98 File Offset: 0x000BE198
		// Note: this type is marked as 'beforefieldinit'.
		static Shape3D()
		{
			Il2CppClassPointerStore<Shape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Shape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shape3D>.NativeClassPtr);
			Shape3D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669398);
			Shape3D.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669391);
			Shape3D.NativeMethodInfoPtr_RaycastWire_Public_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669392);
			Shape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_New_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669393);
			Shape3D.NativeMethodInfoPtr_RenderSolid_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669394);
			Shape3D.NativeMethodInfoPtr_RenderWire_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669395);
			Shape3D.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669396);
			Shape3D.NativeMethodInfoPtr_GetAABB_Public_Abstract_Virtual_New_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shape3D>.NativeClassPtr, 100669397);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000C0068 File Offset: 0x000BE268
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shape3D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000C00A4 File Offset: 0x000BE2A4
		[CallerCount(0)]
		public unsafe bool Raycast(Ray ray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shape3D.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000C00F4 File Offset: 0x000BE2F4
		[CallerCount(0)]
		public unsafe bool RaycastWire(Ray ray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shape3D.NativeMethodInfoPtr_RaycastWire_Public_Boolean_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000C0144 File Offset: 0x000BE344
		[CallerCount(0)]
		public unsafe virtual bool RaycastWire(Ray ray, out float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_New_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000C01AC File Offset: 0x000BE3AC
		[CallerCount(0)]
		public unsafe virtual void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape3D.NativeMethodInfoPtr_RenderSolid_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000C01E8 File Offset: 0x000BE3E8
		[CallerCount(0)]
		public unsafe virtual void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape3D.NativeMethodInfoPtr_RenderWire_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000C0224 File Offset: 0x000BE424
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape3D.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000C028C File Offset: 0x000BE48C
		[CallerCount(0)]
		public unsafe virtual AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shape3D.NativeMethodInfoPtr_GetAABB_Public_Abstract_Virtual_New_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x0000FE04 File Offset: 0x0000E004
		public Shape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Boolean_Ray_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_New_Boolean_Ray_byref_Single_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Boolean_Ray_byref_Single_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Abstract_Virtual_New_AABB_0;
	}
}
