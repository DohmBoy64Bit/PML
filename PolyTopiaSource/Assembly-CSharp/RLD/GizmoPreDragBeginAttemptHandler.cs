using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000059 RID: 89
	public sealed class GizmoPreDragBeginAttemptHandler : MulticastDelegate
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00035A68 File Offset: 0x00033C68
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPreDragBeginAttemptHandler()
		{
			Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPreDragBeginAttemptHandler");
			GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr, 100664069);
			GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr, 100664070);
			GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr, 100664071);
			GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr, 100664072);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00035AE0 File Offset: 0x00033CE0
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 59777, RefRangeEnd = 59837, XrefRangeStart = 59777, XrefRangeEnd = 59837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPreDragBeginAttemptHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPreDragBeginAttemptHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00035B3C File Offset: 0x00033D3C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00035B8C File Offset: 0x00033D8C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00035C10 File Offset: 0x00033E10
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginAttemptHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00003E57 File Offset: 0x00002057
		public GizmoPreDragBeginAttemptHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00003E60 File Offset: 0x00002060
		public static implicit operator GizmoPreDragBeginAttemptHandler(Action<Gizmo, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoPreDragBeginAttemptHandler>(A_0);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00003E68 File Offset: 0x00002068
		public static GizmoPreDragBeginAttemptHandler operator +(GizmoPreDragBeginAttemptHandler A_0, GizmoPreDragBeginAttemptHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoPreDragBeginAttemptHandler>();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00003E76 File Offset: 0x00002076
		public static GizmoPreDragBeginAttemptHandler operator -(GizmoPreDragBeginAttemptHandler A_0, GizmoPreDragBeginAttemptHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoPreDragBeginAttemptHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
