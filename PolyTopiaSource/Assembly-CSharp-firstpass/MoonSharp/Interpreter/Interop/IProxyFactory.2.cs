using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A9 RID: 169
	public class IProxyFactory<TProxy, TTarget> : Object where TProxy : class where TTarget : class
	{
		// Token: 0x06000D19 RID: 3353 RVA: 0x00049718 File Offset: 0x00047918
		// Note: this type is marked as 'beforefieldinit'.
		static IProxyFactory()
		{
			Il2CppClassPointerStore<IProxyFactory<TProxy, TTarget>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IProxyFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProxy>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
			})).TypeHandle.value);
			IProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_TProxy_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665564);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000497A0 File Offset: 0x000479A0
		[CallerCount(0)]
		public unsafe virtual TProxy CreateProxyObject(TTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTarget).IsValueType)
				{
					TTarget ttarget = target;
					intPtr = ((ttarget is string) ? IL2CPP.ManagedStringToIl2Cpp(ttarget as string) : IL2CPP.Il2CppObjectBaseToPtr(ttarget as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_TProxy_TTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TProxy>(intPtr2, false, true);
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00005E0C File Offset: 0x0000400C
		public IProxyFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_TProxy_TTarget_0;
	}
}
