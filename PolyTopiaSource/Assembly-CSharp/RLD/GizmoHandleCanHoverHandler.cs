using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200005E RID: 94
	public sealed class GizmoHandleCanHoverHandler : MulticastDelegate
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x00038990 File Offset: 0x00036B90
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandleCanHoverHandler()
		{
			Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandleCanHoverHandler");
			GizmoHandleCanHoverHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr, 100664175);
			GizmoHandleCanHoverHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr, 100664176);
			GizmoHandleCanHoverHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr, 100664177);
			GizmoHandleCanHoverHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr, 100664178);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00038A08 File Offset: 0x00036C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60870, RefRangeEnd = 60871, XrefRangeStart = 60867, XrefRangeEnd = 60870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleCanHoverHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleCanHoverHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCanHoverHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00038A64 File Offset: 0x00036C64
		[CallerCount(0)]
		public unsafe void Invoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerGizmo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleHoverData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCanHoverHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00038ADC File Offset: 0x00036CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60871, XrefRangeEnd = 60874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerGizmo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleHoverData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCanHoverHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00038B88 File Offset: 0x00036D88
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCanHoverHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00004383 File Offset: 0x00002583
		public GizmoHandleCanHoverHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000438C File Offset: 0x0000258C
		public static implicit operator GizmoHandleCanHoverHandler(Action<int, Gizmo, GizmoHandleHoverData, YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoHandleCanHoverHandler>(A_0);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00004394 File Offset: 0x00002594
		public static GizmoHandleCanHoverHandler operator +(GizmoHandleCanHoverHandler A_0, GizmoHandleCanHoverHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoHandleCanHoverHandler>();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000043A2 File Offset: 0x000025A2
		public static GizmoHandleCanHoverHandler operator -(GizmoHandleCanHoverHandler A_0, GizmoHandleCanHoverHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoHandleCanHoverHandler>();
			}
			return delegate2;
		}

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
