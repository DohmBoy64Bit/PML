using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200006F RID: 111
	public sealed class GizmoEngineCanDoHoverUpdateHandler : MulticastDelegate
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x000413D0 File Offset: 0x0003F5D0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoEngineCanDoHoverUpdateHandler()
		{
			Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoEngineCanDoHoverUpdateHandler");
			GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr, 100664545);
			GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr, 100664546);
			GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr, 100664547);
			GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr, 100664548);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00041448 File Offset: 0x0003F648
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoEngineCanDoHoverUpdateHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoEngineCanDoHoverUpdateHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000414A4 File Offset: 0x0003F6A4
		[CallerCount(0)]
		public unsafe void Invoke(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000414E8 File Offset: 0x0003F6E8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0004155C File Offset: 0x0003F75C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEngineCanDoHoverUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00004B95 File Offset: 0x00002D95
		public GizmoEngineCanDoHoverUpdateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00004B9E File Offset: 0x00002D9E
		public static implicit operator GizmoEngineCanDoHoverUpdateHandler(Action<YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoEngineCanDoHoverUpdateHandler>(A_0);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00004BA6 File Offset: 0x00002DA6
		public static GizmoEngineCanDoHoverUpdateHandler operator +(GizmoEngineCanDoHoverUpdateHandler A_0, GizmoEngineCanDoHoverUpdateHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoEngineCanDoHoverUpdateHandler>();
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public static GizmoEngineCanDoHoverUpdateHandler operator -(GizmoEngineCanDoHoverUpdateHandler A_0, GizmoEngineCanDoHoverUpdateHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoEngineCanDoHoverUpdateHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
