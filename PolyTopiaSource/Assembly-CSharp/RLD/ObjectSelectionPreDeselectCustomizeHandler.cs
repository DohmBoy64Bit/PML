using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000237 RID: 567
	public sealed class ObjectSelectionPreDeselectCustomizeHandler : MulticastDelegate
	{
		// Token: 0x06002B7F RID: 11135 RVA: 0x000CCD38 File Offset: 0x000CAF38
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionPreDeselectCustomizeHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionPreDeselectCustomizeHandler");
			ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr, 100669893);
			ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr, 100669894);
			ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreDeselectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr, 100669895);
			ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr, 100669896);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000CCDB0 File Offset: 0x000CAFB0
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 83642, RefRangeEnd = 83708, XrefRangeStart = 83642, XrefRangeEnd = 83708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionPreDeselectCustomizeHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionPreDeselectCustomizeHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000CCE0C File Offset: 0x000CB00C
		[CallerCount(0)]
		public unsafe void Invoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000CCE60 File Offset: 0x000CB060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreDeselectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000CCEE8 File Offset: 0x000CB0E8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionPreDeselectCustomizeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000112AE File Offset: 0x0000F4AE
		public ObjectSelectionPreDeselectCustomizeHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000112B7 File Offset: 0x0000F4B7
		public static implicit operator ObjectSelectionPreDeselectCustomizeHandler(Action<ObjectPreDeselectCustomizeInfo, List<GameObject>> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionPreDeselectCustomizeHandler>(A_0);
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x000112BF File Offset: 0x0000F4BF
		public static ObjectSelectionPreDeselectCustomizeHandler operator +(ObjectSelectionPreDeselectCustomizeHandler A_0, ObjectSelectionPreDeselectCustomizeHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionPreDeselectCustomizeHandler>();
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000112CD File Offset: 0x0000F4CD
		public static ObjectSelectionPreDeselectCustomizeHandler operator -(ObjectSelectionPreDeselectCustomizeHandler A_0, ObjectSelectionPreDeselectCustomizeHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionPreDeselectCustomizeHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectPreDeselectCustomizeInfo_List_1_GameObject_AsyncCallback_Object_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
