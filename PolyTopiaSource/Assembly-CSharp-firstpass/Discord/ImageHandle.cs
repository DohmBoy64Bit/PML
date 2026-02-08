using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000142 RID: 322
	[StructLayout(2)]
	public struct ImageHandle
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x00072054 File Offset: 0x00070254
		// Note: this type is marked as 'beforefieldinit'.
		static ImageHandle()
		{
			Il2CppClassPointerStore<ImageHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ImageHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr);
			ImageHandle.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, "Type");
			ImageHandle.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, "Id");
			ImageHandle.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, "Size");
			ImageHandle.NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, 100667315);
			ImageHandle.NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, 100667316);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000720E8 File Offset: 0x000702E8
		[CallerCount(0)]
		public unsafe static ImageHandle User(long id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageHandle.NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00072128 File Offset: 0x00070328
		[CallerCount(0)]
		public unsafe static ImageHandle User(long id, uint size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageHandle.NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageHandle>(intPtr3) : null;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00008792 File Offset: 0x00006992
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImageHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_User_Public_Static_ImageHandle_Int64_UInt32_0;

		// Token: 0x04001294 RID: 4756
		[FieldOffset(0)]
		public IntPtr Type;

		// Token: 0x04001295 RID: 4757
		[FieldOffset(8)]
		public long Id;

		// Token: 0x04001296 RID: 4758
		[FieldOffset(16)]
		public uint Size;
	}
}
