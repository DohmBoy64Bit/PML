using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000234 RID: 564
	public sealed class ObjectSelectionDuplicatedHandler : MulticastDelegate
	{
		// Token: 0x06002B64 RID: 11108 RVA: 0x000CC7C4 File Offset: 0x000CA9C4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionDuplicatedHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionDuplicatedHandler");
			ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr, 100669881);
			ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionDuplicationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr, 100669882);
			ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionDuplicationResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr, 100669883);
			ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr, 100669884);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000CC83C File Offset: 0x000CAA3C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionDuplicatedHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionDuplicatedHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000CC898 File Offset: 0x000CAA98
		[CallerCount(0)]
		public unsafe void Invoke(ObjectSelectionDuplicationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionDuplicationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000CC8DC File Offset: 0x000CAADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObjectSelectionDuplicationResult result, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionDuplicationResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000CC950 File Offset: 0x000CAB50
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionDuplicatedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0001121E File Offset: 0x0000F41E
		public ObjectSelectionDuplicatedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00011227 File Offset: 0x0000F427
		public static implicit operator ObjectSelectionDuplicatedHandler(Action<ObjectSelectionDuplicationResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionDuplicatedHandler>(A_0);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0001122F File Offset: 0x0000F42F
		public static ObjectSelectionDuplicatedHandler operator +(ObjectSelectionDuplicatedHandler A_0, ObjectSelectionDuplicatedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionDuplicatedHandler>();
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x0001123D File Offset: 0x0000F43D
		public static ObjectSelectionDuplicatedHandler operator -(ObjectSelectionDuplicatedHandler A_0, ObjectSelectionDuplicatedHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionDuplicatedHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionDuplicationResult_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionDuplicationResult_AsyncCallback_Object_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
