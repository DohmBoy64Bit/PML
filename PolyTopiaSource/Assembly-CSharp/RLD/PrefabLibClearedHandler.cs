using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200019C RID: 412
	public sealed class PrefabLibClearedHandler : MulticastDelegate
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x0009F660 File Offset: 0x0009D860
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLibClearedHandler()
		{
			Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabLibClearedHandler");
			PrefabLibClearedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr, 100668109);
			PrefabLibClearedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr, 100668110);
			PrefabLibClearedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr, 100668111);
			PrefabLibClearedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr, 100668112);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
		[CallerCount(530)]
		[CachedScanResults(RefRangeStart = 34422, RefRangeEnd = 34952, XrefRangeStart = 34422, XrefRangeEnd = 34952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLibClearedHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLibClearedHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibClearedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0009F734 File Offset: 0x0009D934
		[CallerCount(0)]
		public unsafe void Invoke(RTPrefabLib prefabLib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibClearedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0009F778 File Offset: 0x0009D978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(RTPrefabLib prefabLib, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibClearedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0009F7EC File Offset: 0x0009D9EC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibClearedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0000CDE2 File Offset: 0x0000AFE2
		public PrefabLibClearedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0000CDEB File Offset: 0x0000AFEB
		public static implicit operator PrefabLibClearedHandler(Action<RTPrefabLib> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrefabLibClearedHandler>(A_0);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0000CDF3 File Offset: 0x0000AFF3
		public static PrefabLibClearedHandler operator +(PrefabLibClearedHandler A_0, PrefabLibClearedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrefabLibClearedHandler>();
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0000CE01 File Offset: 0x0000B001
		public static PrefabLibClearedHandler operator -(PrefabLibClearedHandler A_0, PrefabLibClearedHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrefabLibClearedHandler>();
			}
			return delegate2;
		}

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_AsyncCallback_Object_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
