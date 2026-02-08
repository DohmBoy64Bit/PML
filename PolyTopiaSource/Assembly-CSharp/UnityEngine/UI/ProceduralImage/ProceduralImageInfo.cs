using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000344 RID: 836
	[StructLayout(2)]
	public struct ProceduralImageInfo
	{
		// Token: 0x0600489D RID: 18589 RVA: 0x00141670 File Offset: 0x0013F870
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralImageInfo()
		{
			Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.ProceduralImage", "ProceduralImageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr);
			ProceduralImageInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "width");
			ProceduralImageInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "height");
			ProceduralImageInfo.NativeFieldInfoPtr_fallOffDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "fallOffDistance");
			ProceduralImageInfo.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "radius");
			ProceduralImageInfo.NativeFieldInfoPtr_borderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "borderWidth");
			ProceduralImageInfo.NativeFieldInfoPtr_pixelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, "pixelSize");
			ProceduralImageInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, 100674899);
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x0014172C File Offset: 0x0013F92C
		[CallerCount(0)]
		public unsafe ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallOffDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(radius);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImageInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Vector4_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0001B001 File Offset: 0x00019201
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProceduralImageInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeFieldInfoPtr_fallOffDistance;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeFieldInfoPtr_borderWidth;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeFieldInfoPtr_pixelSize;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Vector4_Single_0;

		// Token: 0x04003838 RID: 14392
		[FieldOffset(0)]
		public float width;

		// Token: 0x04003839 RID: 14393
		[FieldOffset(4)]
		public float height;

		// Token: 0x0400383A RID: 14394
		[FieldOffset(8)]
		public float fallOffDistance;

		// Token: 0x0400383B RID: 14395
		[FieldOffset(12)]
		public IntPtr radius;

		// Token: 0x0400383C RID: 14396
		[FieldOffset(28)]
		public float borderWidth;

		// Token: 0x0400383D RID: 14397
		[FieldOffset(32)]
		public float pixelSize;
	}
}
