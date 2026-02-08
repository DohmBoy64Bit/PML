using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000055 RID: 85
	public sealed class GizmoPreDragEndHandler : MulticastDelegate
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x000352B8 File Offset: 0x000334B8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPreDragEndHandler()
		{
			Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPreDragEndHandler");
			GizmoPreDragEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr, 100664053);
			GizmoPreDragEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr, 100664054);
			GizmoPreDragEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr, 100664055);
			GizmoPreDragEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr, 100664056);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00035330 File Offset: 0x00033530
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 59777, RefRangeEnd = 59837, XrefRangeStart = 59777, XrefRangeEnd = 59837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPreDragEndHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPreDragEndHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0003538C File Offset: 0x0003358C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000353DC File Offset: 0x000335DC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00035460 File Offset: 0x00033660
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00003D97 File Offset: 0x00001F97
		public GizmoPreDragEndHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public static implicit operator GizmoPreDragEndHandler(Action<Gizmo, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoPreDragEndHandler>(A_0);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public static GizmoPreDragEndHandler operator +(GizmoPreDragEndHandler A_0, GizmoPreDragEndHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoPreDragEndHandler>();
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00003DB6 File Offset: 0x00001FB6
		public static GizmoPreDragEndHandler operator -(GizmoPreDragEndHandler A_0, GizmoPreDragEndHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoPreDragEndHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
