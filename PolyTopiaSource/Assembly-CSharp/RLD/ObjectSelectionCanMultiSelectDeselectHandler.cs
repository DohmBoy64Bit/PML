using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200022F RID: 559
	public sealed class ObjectSelectionCanMultiSelectDeselectHandler : MulticastDelegate
	{
		// Token: 0x06002B37 RID: 11063 RVA: 0x000CBF14 File Offset: 0x000CA114
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionCanMultiSelectDeselectHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionCanMultiSelectDeselectHandler");
			ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr, 100669861);
			ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr, 100669862);
			ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr, 100669863);
			ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr, 100669864);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000CBF8C File Offset: 0x000CA18C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionCanMultiSelectDeselectHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionCanMultiSelectDeselectHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000CBFE8 File Offset: 0x000CA1E8
		[CallerCount(0)]
		public unsafe void Invoke(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000CC02C File Offset: 0x000CA22C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000CC0A0 File Offset: 0x000CA2A0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionCanMultiSelectDeselectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0001112E File Offset: 0x0000F32E
		public ObjectSelectionCanMultiSelectDeselectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00011137 File Offset: 0x0000F337
		public static implicit operator ObjectSelectionCanMultiSelectDeselectHandler(Action<YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionCanMultiSelectDeselectHandler>(A_0);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x0001113F File Offset: 0x0000F33F
		public static ObjectSelectionCanMultiSelectDeselectHandler operator +(ObjectSelectionCanMultiSelectDeselectHandler A_0, ObjectSelectionCanMultiSelectDeselectHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionCanMultiSelectDeselectHandler>();
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0001114D File Offset: 0x0000F34D
		public static ObjectSelectionCanMultiSelectDeselectHandler operator -(ObjectSelectionCanMultiSelectDeselectHandler A_0, ObjectSelectionCanMultiSelectDeselectHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionCanMultiSelectDeselectHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
