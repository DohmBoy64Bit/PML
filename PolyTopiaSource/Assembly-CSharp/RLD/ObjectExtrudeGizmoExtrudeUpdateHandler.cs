using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006B RID: 107
	public sealed class ObjectExtrudeGizmoExtrudeUpdateHandler : MulticastDelegate
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x0003EB38 File Offset: 0x0003CD38
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectExtrudeGizmoExtrudeUpdateHandler()
		{
			Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectExtrudeGizmoExtrudeUpdateHandler");
			ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr, 100664444);
			ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr, 100664445);
			ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_GameObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr, 100664446);
			ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr, 100664447);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0003EBB0 File Offset: 0x0003CDB0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmoExtrudeUpdateHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmoExtrudeUpdateHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0003EC0C File Offset: 0x0003CE0C
		[CallerCount(0)]
		public unsafe void Invoke(List<GameObject> clones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clones);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0003EC50 File Offset: 0x0003CE50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(List<GameObject> clones, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clones);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_GameObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoExtrudeUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000484B File Offset: 0x00002A4B
		public ObjectExtrudeGizmoExtrudeUpdateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004854 File Offset: 0x00002A54
		public static implicit operator ObjectExtrudeGizmoExtrudeUpdateHandler(Action<List<GameObject>> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectExtrudeGizmoExtrudeUpdateHandler>(A_0);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000485C File Offset: 0x00002A5C
		public static ObjectExtrudeGizmoExtrudeUpdateHandler operator +(ObjectExtrudeGizmoExtrudeUpdateHandler A_0, ObjectExtrudeGizmoExtrudeUpdateHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectExtrudeGizmoExtrudeUpdateHandler>();
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000486A File Offset: 0x00002A6A
		public static ObjectExtrudeGizmoExtrudeUpdateHandler operator -(ObjectExtrudeGizmoExtrudeUpdateHandler A_0, ObjectExtrudeGizmoExtrudeUpdateHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectExtrudeGizmoExtrudeUpdateHandler>();
			}
			return delegate2;
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_GameObject_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_GameObject_AsyncCallback_Object_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
