using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200004A RID: 74
	public sealed class GizmoPostDisabledHandler : MulticastDelegate
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00033DE8 File Offset: 0x00031FE8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPostDisabledHandler()
		{
			Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPostDisabledHandler");
			GizmoPostDisabledHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr, 100664009);
			GizmoPostDisabledHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr, 100664010);
			GizmoPostDisabledHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr, 100664011);
			GizmoPostDisabledHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr, 100664012);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00033E60 File Offset: 0x00032060
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59684, XrefRangeEnd = 59694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPostDisabledHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPostDisabledHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostDisabledHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00033EBC File Offset: 0x000320BC
		[CallerCount(0)]
		public unsafe void Invoke(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostDisabledHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00033F00 File Offset: 0x00032100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Gizmo gizmo, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostDisabledHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00033F74 File Offset: 0x00032174
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPostDisabledHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00003B87 File Offset: 0x00001D87
		public GizmoPostDisabledHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00003B90 File Offset: 0x00001D90
		public static implicit operator GizmoPostDisabledHandler(Action<Gizmo> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoPostDisabledHandler>(A_0);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00003B98 File Offset: 0x00001D98
		public static GizmoPostDisabledHandler operator +(GizmoPostDisabledHandler A_0, GizmoPostDisabledHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoPostDisabledHandler>();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003BA6 File Offset: 0x00001DA6
		public static GizmoPostDisabledHandler operator -(GizmoPostDisabledHandler A_0, GizmoPostDisabledHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoPostDisabledHandler>();
			}
			return delegate2;
		}

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Gizmo_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Gizmo_AsyncCallback_Object_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
