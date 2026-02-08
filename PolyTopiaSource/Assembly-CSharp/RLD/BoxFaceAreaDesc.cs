using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200014D RID: 333
	[StructLayout(2)]
	public struct BoxFaceAreaDesc
	{
		// Token: 0x06001D3B RID: 7483 RVA: 0x00094508 File Offset: 0x00092708
		// Note: this type is marked as 'beforefieldinit'.
		static BoxFaceAreaDesc()
		{
			Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxFaceAreaDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr);
			BoxFaceAreaDesc.NativeFieldInfoPtr_AreaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr, "AreaType");
			BoxFaceAreaDesc.NativeFieldInfoPtr_Area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr, "Area");
			BoxFaceAreaDesc.NativeMethodInfoPtr__ctor_Public_Void_BoxFaceAreaType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr, 100667727);
			BoxFaceAreaDesc.NativeMethodInfoPtr_GetInvalid_Public_Static_BoxFaceAreaDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr, 100667728);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00094588 File Offset: 0x00092788
		[CallerCount(0)]
		public unsafe BoxFaceAreaDesc(BoxFaceAreaType areaType, float area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(areaType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref area;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxFaceAreaDesc.NativeMethodInfoPtr__ctor_Public_Void_BoxFaceAreaType_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x000945CC File Offset: 0x000927CC
		[CallerCount(0)]
		public unsafe static BoxFaceAreaDesc GetInvalid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxFaceAreaDesc.NativeMethodInfoPtr_GetInvalid_Public_Static_BoxFaceAreaDesc_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFaceAreaDesc>(intPtr3) : null;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0000C362 File Offset: 0x0000A562
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoxFaceAreaDesc>.NativeClassPtr, ref this));
		}

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_AreaType;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_Area;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoxFaceAreaType_Single_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalid_Public_Static_BoxFaceAreaDesc_0;

		// Token: 0x0400168D RID: 5773
		[FieldOffset(0)]
		public IntPtr AreaType;

		// Token: 0x0400168E RID: 5774
		[FieldOffset(4)]
		public float Area;
	}
}
