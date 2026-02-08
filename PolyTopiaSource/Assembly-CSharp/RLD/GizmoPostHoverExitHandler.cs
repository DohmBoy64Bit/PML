using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000050 RID: 80
	public sealed class GizmoPostHoverExitHandler : MulticastDelegate
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x0003491C File Offset: 0x00032B1C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPostHoverExitHandler()
		{
			Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPostHoverExitHandler");
			GizmoPostHoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr, 100664033);
			GizmoPostHoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr, 100664034);
			GizmoPostHoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr, 100664035);
			GizmoPostHoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr, 100664036);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00034994 File Offset: 0x00032B94
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 59777, RefRangeEnd = 59837, XrefRangeStart = 59777, XrefRangeEnd = 59837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPostHoverExitHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPostHoverExitHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostHoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000349F0 File Offset: 0x00032BF0
		[CallerCount(0)]
		public unsafe void Invoke(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostHoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00034A40 File Offset: 0x00032C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Gizmo gizmo, int handleId, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostHoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00034AC4 File Offset: 0x00032CC4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostHoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003CA7 File Offset: 0x00001EA7
		public GizmoPostHoverExitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public static implicit operator GizmoPostHoverExitHandler(Action<Gizmo, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoPostHoverExitHandler>(A_0);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public static GizmoPostHoverExitHandler operator +(GizmoPostHoverExitHandler A_0, GizmoPostHoverExitHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoPostHoverExitHandler>();
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00003CC6 File Offset: 0x00001EC6
		public static GizmoPostHoverExitHandler operator -(GizmoPostHoverExitHandler A_0, GizmoPostHoverExitHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoPostHoverExitHandler>();
			}
			return delegate2;
		}

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
