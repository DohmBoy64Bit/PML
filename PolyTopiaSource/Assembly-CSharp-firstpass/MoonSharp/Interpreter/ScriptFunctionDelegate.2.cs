using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000033 RID: 51
	public sealed class ScriptFunctionDelegate<T> : MulticastDelegate
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x0002F7BC File Offset: 0x0002D9BC
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptFunctionDelegate()
		{
			Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptFunctionDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ScriptFunctionDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr, 100664626);
			ScriptFunctionDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr, 100664627);
			ScriptFunctionDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr, 100664628);
			ScriptFunctionDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr, 100664629);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002F870 File Offset: 0x0002DA70
		[CallerCount(0)]
		public unsafe ScriptFunctionDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptFunctionDelegate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002F8CC File Offset: 0x0002DACC
		[CallerCount(0)]
		public unsafe T Invoke([Optional] Il2CppReferenceArray<Object> args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002F924 File Offset: 0x0002DB24
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0002F998 File Offset: 0x0002DB98
		[CallerCount(0)]
		public unsafe T EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptFunctionDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00003A76 File Offset: 0x00001C76
		public ScriptFunctionDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00003A7F File Offset: 0x00001C7F
		public static implicit operator ScriptFunctionDelegate<T>(Func<Il2CppReferenceArray<Object>, T> A_0)
		{
			return DelegateSupport.ConvertDelegate<ScriptFunctionDelegate<T>>(A_0);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00003A87 File Offset: 0x00001C87
		public static ScriptFunctionDelegate<T>operator +(ScriptFunctionDelegate<T> A_0, ScriptFunctionDelegate<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ScriptFunctionDelegate<T>>();
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00003A95 File Offset: 0x00001C95
		public static ScriptFunctionDelegate<T>operator -(ScriptFunctionDelegate<T> A_0, ScriptFunctionDelegate<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ScriptFunctionDelegate<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0;
	}
}
