using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000032 RID: 50
	public sealed class GizmoEntityTransformChangedHandler : MulticastDelegate
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x0002B408 File Offset: 0x00029608
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoEntityTransformChangedHandler()
		{
			Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoEntityTransformChangedHandler");
			GizmoEntityTransformChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr, 100663684);
			GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr, 100663685);
			GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GizmoTransform_ChangeData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr, 100663686);
			GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr, 100663687);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0002B480 File Offset: 0x00029680
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 58153, RefRangeEnd = 58210, XrefRangeStart = 58143, XrefRangeEnd = 58153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoEntityTransformChangedHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoEntityTransformChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEntityTransformChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0002B4DC File Offset: 0x000296DC
		[CallerCount(0)]
		public unsafe void Invoke(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0002B52C File Offset: 0x0002972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58210, XrefRangeEnd = 58214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(GizmoTransform transform, GizmoTransform.ChangeData changeData, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GizmoTransform_ChangeData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0002B5B0 File Offset: 0x000297B0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoEntityTransformChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002F0D File Offset: 0x0000110D
		public GizmoEntityTransformChangedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002F16 File Offset: 0x00001116
		public static implicit operator GizmoEntityTransformChangedHandler(Action<GizmoTransform, GizmoTransform.ChangeData> A_0)
		{
			return DelegateSupport.ConvertDelegate<GizmoEntityTransformChangedHandler>(A_0);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002F1E File Offset: 0x0000111E
		public static GizmoEntityTransformChangedHandler operator +(GizmoEntityTransformChangedHandler A_0, GizmoEntityTransformChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GizmoEntityTransformChangedHandler>();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002F2C File Offset: 0x0000112C
		public static GizmoEntityTransformChangedHandler operator -(GizmoEntityTransformChangedHandler A_0, GizmoEntityTransformChangedHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GizmoEntityTransformChangedHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_GizmoTransform_ChangeData_AsyncCallback_Object_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
