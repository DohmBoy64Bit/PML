using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000113 RID: 275
	public sealed class CameraCanUseScrollWheelHandler : MulticastDelegate
	{
		// Token: 0x060019E7 RID: 6631 RVA: 0x00085D14 File Offset: 0x00083F14
		// Note: this type is marked as 'beforefieldinit'.
		static CameraCanUseScrollWheelHandler()
		{
			Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraCanUseScrollWheelHandler");
			CameraCanUseScrollWheelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr, 100667109);
			CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr, 100667110);
			CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr, 100667111);
			CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr, 100667112);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00085D8C File Offset: 0x00083F8C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraCanUseScrollWheelHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCanUseScrollWheelHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanUseScrollWheelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00085DE8 File Offset: 0x00083FE8
		[CallerCount(0)]
		public unsafe void Invoke(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00085E2C File Offset: 0x0008402C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(YesNoAnswer answer, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00085EA0 File Offset: 0x000840A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanUseScrollWheelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0000B5B2 File Offset: 0x000097B2
		public CameraCanUseScrollWheelHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0000B5BB File Offset: 0x000097BB
		public static implicit operator CameraCanUseScrollWheelHandler(Action<YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<CameraCanUseScrollWheelHandler>(A_0);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0000B5C3 File Offset: 0x000097C3
		public static CameraCanUseScrollWheelHandler operator +(CameraCanUseScrollWheelHandler A_0, CameraCanUseScrollWheelHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CameraCanUseScrollWheelHandler>();
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0000B5D1 File Offset: 0x000097D1
		public static CameraCanUseScrollWheelHandler operator -(CameraCanUseScrollWheelHandler A_0, CameraCanUseScrollWheelHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CameraCanUseScrollWheelHandler>();
			}
			return delegate2;
		}

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
