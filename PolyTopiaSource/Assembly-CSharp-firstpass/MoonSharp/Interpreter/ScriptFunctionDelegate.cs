using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000032 RID: 50
	public sealed class ScriptFunctionDelegate : MulticastDelegate
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptFunctionDelegate()
		{
			Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptFunctionDelegate");
			ScriptFunctionDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr, 100664622);
			ScriptFunctionDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr, 100664623);
			ScriptFunctionDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr, 100664624);
			ScriptFunctionDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr, 100664625);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002F63C File Offset: 0x0002D83C
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 23239, RefRangeEnd = 23448, XrefRangeStart = 23229, XrefRangeEnd = 23239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptFunctionDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptFunctionDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002F698 File Offset: 0x0002D898
		[CallerCount(0)]
		public unsafe Object Invoke([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002F6F8 File Offset: 0x0002D8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23448, XrefRangeEnd = 23449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Il2CppReferenceArray<Object> args, AsyncCallback callback, Object @object)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002F76C File Offset: 0x0002D96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00003A46 File Offset: 0x00001C46
		public ScriptFunctionDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00003A4F File Offset: 0x00001C4F
		public static implicit operator ScriptFunctionDelegate(Func<Il2CppReferenceArray<Object>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ScriptFunctionDelegate>(A_0);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00003A57 File Offset: 0x00001C57
		public static ScriptFunctionDelegate operator +(ScriptFunctionDelegate A_0, ScriptFunctionDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ScriptFunctionDelegate>();
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00003A65 File Offset: 0x00001C65
		public static ScriptFunctionDelegate operator -(ScriptFunctionDelegate A_0, ScriptFunctionDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ScriptFunctionDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0;
	}
}
