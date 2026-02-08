using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000230 RID: 560
	public sealed class ObjectSelectionChangedHandler : MulticastDelegate
	{
		// Token: 0x06002B40 RID: 11072 RVA: 0x000CC0E4 File Offset: 0x000CA2E4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionChangedHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionChangedHandler");
			ObjectSelectionChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr, 100669865);
			ObjectSelectionChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr, 100669866);
			ObjectSelectionChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionChangedEventArgs_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr, 100669867);
			ObjectSelectionChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr, 100669868);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000CC15C File Offset: 0x000CA35C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionChangedHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000CC1B8 File Offset: 0x000CA3B8
		[CallerCount(0)]
		public unsafe void Invoke(ObjectSelectionChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000CC1FC File Offset: 0x000CA3FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObjectSelectionChangedEventArgs args, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionChangedEventArgs_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000CC270 File Offset: 0x000CA470
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0001115E File Offset: 0x0000F35E
		public ObjectSelectionChangedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00011167 File Offset: 0x0000F367
		public static implicit operator ObjectSelectionChangedHandler(Action<ObjectSelectionChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionChangedHandler>(A_0);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x0001116F File Offset: 0x0000F36F
		public static ObjectSelectionChangedHandler operator +(ObjectSelectionChangedHandler A_0, ObjectSelectionChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionChangedHandler>();
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x0001117D File Offset: 0x0000F37D
		public static ObjectSelectionChangedHandler operator -(ObjectSelectionChangedHandler A_0, ObjectSelectionChangedHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionChangedHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionChangedEventArgs_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionChangedEventArgs_AsyncCallback_Object_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
