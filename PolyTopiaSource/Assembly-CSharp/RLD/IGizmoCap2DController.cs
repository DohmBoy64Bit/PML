using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000015 RID: 21
	public class IGizmoCap2DController : global::Il2CppSystem.Object
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00025780 File Offset: 0x00023980
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoCap2DController()
		{
			Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoCap2DController");
			IGizmoCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr, 100663471);
			IGizmoCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr, 100663472);
			IGizmoCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr, 100663473);
			IGizmoCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr, 100663474);
			IGizmoCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap2DController>.NativeClassPtr, 100663475);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0002580C File Offset: 0x00023A0C
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00025848 File Offset: 0x00023A48
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00025884 File Offset: 0x00023A84
		[CallerCount(0)]
		public unsafe virtual void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000258E4 File Offset: 0x00023AE4
		[CallerCount(0)]
		public unsafe virtual void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00025944 File Offset: 0x00023B44
		[CallerCount(0)]
		public unsafe virtual float GetSliderAlignedRealLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002792 File Offset: 0x00000992
		public IGizmoCap2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2D_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2DInvert_Public_Abstract_Virtual_New_Void_Vector2_Vector2_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Abstract_Virtual_New_Single_0;
	}
}
