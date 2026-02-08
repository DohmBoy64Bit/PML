using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000236 RID: 566
	public sealed class ObjectSelectionPreSelectCustomizeHandler : MulticastDelegate
	{
		// Token: 0x06002B76 RID: 11126 RVA: 0x000CCB44 File Offset: 0x000CAD44
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionPreSelectCustomizeHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionPreSelectCustomizeHandler");
			ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr, 100669889);
			ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr, 100669890);
			ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreSelectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr, 100669891);
			ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr, 100669892);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000CCBBC File Offset: 0x000CADBC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 83642, RefRangeEnd = 83708, XrefRangeStart = 83642, XrefRangeEnd = 83708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionPreSelectCustomizeHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionPreSelectCustomizeHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000CCC18 File Offset: 0x000CAE18
		[CallerCount(0)]
		public unsafe void Invoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000CCC6C File Offset: 0x000CAE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreSelectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000CCCF4 File Offset: 0x000CAEF4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreSelectCustomizeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x0001127E File Offset: 0x0000F47E
		public ObjectSelectionPreSelectCustomizeHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00011287 File Offset: 0x0000F487
		public static implicit operator ObjectSelectionPreSelectCustomizeHandler(Action<ObjectPreSelectCustomizeInfo, List<GameObject>> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionPreSelectCustomizeHandler>(A_0);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0001128F File Offset: 0x0000F48F
		public static ObjectSelectionPreSelectCustomizeHandler operator +(ObjectSelectionPreSelectCustomizeHandler A_0, ObjectSelectionPreSelectCustomizeHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionPreSelectCustomizeHandler>();
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0001129D File Offset: 0x0000F49D
		public static ObjectSelectionPreSelectCustomizeHandler operator -(ObjectSelectionPreSelectCustomizeHandler A_0, ObjectSelectionPreSelectCustomizeHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionPreSelectCustomizeHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreSelectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
