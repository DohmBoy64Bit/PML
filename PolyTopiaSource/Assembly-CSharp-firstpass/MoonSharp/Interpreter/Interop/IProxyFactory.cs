using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A8 RID: 168
	public class IProxyFactory : Object
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x000495C0 File Offset: 0x000477C0
		// Note: this type is marked as 'beforefieldinit'.
		static IProxyFactory()
		{
			Il2CppClassPointerStore<IProxyFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IProxyFactory");
			IProxyFactory.NativeMethodInfoPtr_get_TargetType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProxyFactory>.NativeClassPtr, 100665562);
			IProxyFactory.NativeMethodInfoPtr_get_ProxyType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProxyFactory>.NativeClassPtr, 100665563);
			IProxyFactory.NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProxyFactory>.NativeClassPtr, 100665561);
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00049624 File Offset: 0x00047824
		public unsafe virtual Type TargetType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProxyFactory.NativeMethodInfoPtr_get_TargetType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00049670 File Offset: 0x00047870
		public unsafe virtual Type ProxyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProxyFactory.NativeMethodInfoPtr_get_ProxyType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000496BC File Offset: 0x000478BC
		[CallerCount(0)]
		public unsafe virtual Object CreateProxyObject(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProxyFactory.NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00005E03 File Offset: 0x00004003
		public IProxyFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyObject_Public_Abstract_Virtual_New_Object_Object_0;
	}
}
