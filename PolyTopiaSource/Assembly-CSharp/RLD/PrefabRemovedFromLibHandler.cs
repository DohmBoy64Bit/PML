using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200019B RID: 411
	public sealed class PrefabRemovedFromLibHandler : MulticastDelegate
	{
		// Token: 0x06001F9A RID: 8090 RVA: 0x0009F46C File Offset: 0x0009D66C
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabRemovedFromLibHandler()
		{
			Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabRemovedFromLibHandler");
			PrefabRemovedFromLibHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr, 100668105);
			PrefabRemovedFromLibHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr, 100668106);
			PrefabRemovedFromLibHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr, 100668107);
			PrefabRemovedFromLibHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr, 100668108);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0009F4E4 File Offset: 0x0009D6E4
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 83642, RefRangeEnd = 83708, XrefRangeStart = 83642, XrefRangeEnd = 83708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabRemovedFromLibHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabRemovedFromLibHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabRemovedFromLibHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0009F540 File Offset: 0x0009D740
		[CallerCount(0)]
		public unsafe void Invoke(RTPrefabLib prefabLib, RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabRemovedFromLibHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0009F594 File Offset: 0x0009D794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(RTPrefabLib prefabLib, RTPrefab prefab, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabRemovedFromLibHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0009F61C File Offset: 0x0009D81C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabRemovedFromLibHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0000CDB2 File Offset: 0x0000AFB2
		public PrefabRemovedFromLibHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0000CDBB File Offset: 0x0000AFBB
		public static implicit operator PrefabRemovedFromLibHandler(Action<RTPrefabLib, RTPrefab> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrefabRemovedFromLibHandler>(A_0);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0000CDC3 File Offset: 0x0000AFC3
		public static PrefabRemovedFromLibHandler operator +(PrefabRemovedFromLibHandler A_0, PrefabRemovedFromLibHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrefabRemovedFromLibHandler>();
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0000CDD1 File Offset: 0x0000AFD1
		public static PrefabRemovedFromLibHandler operator -(PrefabRemovedFromLibHandler A_0, PrefabRemovedFromLibHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrefabRemovedFromLibHandler>();
			}
			return delegate2;
		}

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
