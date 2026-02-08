using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200022E RID: 558
	public sealed class ObjectSelectionCanClickSelectDeselectHandler : MulticastDelegate
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x000CBD44 File Offset: 0x000C9F44
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionCanClickSelectDeselectHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionCanClickSelectDeselectHandler");
			ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr, 100669857);
			ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr, 100669858);
			ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr, 100669859);
			ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr, 100669860);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000CBDBC File Offset: 0x000C9FBC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionCanClickSelectDeselectHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionCanClickSelectDeselectHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000CBE18 File Offset: 0x000CA018
		[CallerCount(0)]
		public unsafe void Invoke(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000CBE5C File Offset: 0x000CA05C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000CBED0 File Offset: 0x000CA0D0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanClickSelectDeselectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000110FE File Offset: 0x0000F2FE
		public ObjectSelectionCanClickSelectDeselectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00011107 File Offset: 0x0000F307
		public static implicit operator ObjectSelectionCanClickSelectDeselectHandler(Action<YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionCanClickSelectDeselectHandler>(A_0);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0001110F File Offset: 0x0000F30F
		public static ObjectSelectionCanClickSelectDeselectHandler operator +(ObjectSelectionCanClickSelectDeselectHandler A_0, ObjectSelectionCanClickSelectDeselectHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionCanClickSelectDeselectHandler>();
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0001111D File Offset: 0x0000F31D
		public static ObjectSelectionCanClickSelectDeselectHandler operator -(ObjectSelectionCanClickSelectDeselectHandler A_0, ObjectSelectionCanClickSelectDeselectHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionCanClickSelectDeselectHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
