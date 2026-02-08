using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200019E RID: 414
	public sealed class PrefabLibDbPrefabSpawnedHander : MulticastDelegate
	{
		// Token: 0x06001FCD RID: 8141 RVA: 0x000A0124 File Offset: 0x0009E324
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLibDbPrefabSpawnedHander()
		{
			Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabLibDbPrefabSpawnedHander");
			PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr, 100668138);
			PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr, 100668139);
			PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_GameObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr, 100668140);
			PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr, 100668141);
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x000A019C File Offset: 0x0009E39C
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 34962, RefRangeEnd = 35067, XrefRangeStart = 34962, XrefRangeEnd = 35067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLibDbPrefabSpawnedHander(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLibDbPrefabSpawnedHander>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x000A01F8 File Offset: 0x0009E3F8
		[CallerCount(0)]
		public unsafe void Invoke(RTPrefab prefab, GameObject spawnedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000A024C File Offset: 0x0009E44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, GameObject spawnedObject, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnedObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_GameObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000A02D4 File Offset: 0x0009E4D4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbPrefabSpawnedHander.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0000CEB6 File Offset: 0x0000B0B6
		public PrefabLibDbPrefabSpawnedHander(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0000CEBF File Offset: 0x0000B0BF
		public static implicit operator PrefabLibDbPrefabSpawnedHander(Action<RTPrefab, GameObject> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrefabLibDbPrefabSpawnedHander>(A_0);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0000CEC7 File Offset: 0x0000B0C7
		public static PrefabLibDbPrefabSpawnedHander operator +(PrefabLibDbPrefabSpawnedHander A_0, PrefabLibDbPrefabSpawnedHander A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrefabLibDbPrefabSpawnedHander>();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0000CED5 File Offset: 0x0000B0D5
		public static PrefabLibDbPrefabSpawnedHander operator -(PrefabLibDbPrefabSpawnedHander A_0, PrefabLibDbPrefabSpawnedHander A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrefabLibDbPrefabSpawnedHander>();
			}
			return delegate2;
		}

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_GameObject_0;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_GameObject_AsyncCallback_Object_0;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
