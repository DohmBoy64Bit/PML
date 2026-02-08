using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000051 RID: 81
	public sealed class GizmoPreDragBeginHandler : MulticastDelegate
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x00034B08 File Offset: 0x00032D08
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPreDragBeginHandler()
		{
			Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPreDragBeginHandler");
			GizmoPreDragBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr, 100664037);
			GizmoPreDragBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr, 100664038);
			GizmoPreDragBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr, 100664039);
			GizmoPreDragBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr, 100664040);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00034B80 File Offset: 0x00032D80
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 59777, RefRangeEnd = 59837, XrefRangeStart = 59777, XrefRangeEnd = 59837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPreDragBeginHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPreDragBeginHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00034BDC File Offset: 0x00032DDC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00034C2C File Offset: 0x00032E2C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00034CB0 File Offset: 0x00032EB0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPreDragBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00003CD7 File Offset: 0x00001ED7
		public GizmoPreDragBeginHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public static implicit operator GizmoPreDragBeginHandler(Action<Gizmo, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoPreDragBeginHandler>(A_0);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public static GizmoPreDragBeginHandler operator +(GizmoPreDragBeginHandler A_0, GizmoPreDragBeginHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoPreDragBeginHandler>();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00003CF6 File Offset: 0x00001EF6
		public static GizmoPreDragBeginHandler operator -(GizmoPreDragBeginHandler A_0, GizmoPreDragBeginHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoPreDragBeginHandler>();
			}
			return delegate2;
		}

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_Int32_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_Int32_AsyncCallback_Object_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
