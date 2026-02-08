using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200019A RID: 410
	public sealed class PrefabCreatedInLibHandler : MulticastDelegate
	{
		// Token: 0x06001F91 RID: 8081 RVA: 0x0009F278 File Offset: 0x0009D478
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabCreatedInLibHandler()
		{
			Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabCreatedInLibHandler");
			PrefabCreatedInLibHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr, 100668101);
			PrefabCreatedInLibHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr, 100668102);
			PrefabCreatedInLibHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr, 100668103);
			PrefabCreatedInLibHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr, 100668104);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0009F2F0 File Offset: 0x0009D4F0
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 83642, RefRangeEnd = 83708, XrefRangeStart = 83632, XrefRangeEnd = 83642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabCreatedInLibHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCreatedInLibHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabCreatedInLibHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0009F34C File Offset: 0x0009D54C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabCreatedInLibHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0009F3A0 File Offset: 0x0009D5A0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabCreatedInLibHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0009F428 File Offset: 0x0009D628
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabCreatedInLibHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0000CD82 File Offset: 0x0000AF82
		public PrefabCreatedInLibHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x0000CD8B File Offset: 0x0000AF8B
		public static implicit operator PrefabCreatedInLibHandler(Action<RTPrefabLib, RTPrefab> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrefabCreatedInLibHandler>(A_0);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0000CD93 File Offset: 0x0000AF93
		public static PrefabCreatedInLibHandler operator +(PrefabCreatedInLibHandler A_0, PrefabCreatedInLibHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrefabCreatedInLibHandler>();
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0000CDA1 File Offset: 0x0000AFA1
		public static PrefabCreatedInLibHandler operator -(PrefabCreatedInLibHandler A_0, PrefabCreatedInLibHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrefabCreatedInLibHandler>();
			}
			return delegate2;
		}

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefabLib_RTPrefab_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefabLib_RTPrefab_AsyncCallback_Object_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
