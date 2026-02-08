using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A7 RID: 167
	public class DelegateProxyFactory<TProxy, TTarget> : Object where TProxy : class where TTarget : class
	{
		// Token: 0x06000D0B RID: 3339 RVA: 0x000492FC File Offset: 0x000474FC
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateProxyFactory()
		{
			Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "DelegateProxyFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProxy>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr);
			DelegateProxyFactory<TProxy, TTarget>.NativeFieldInfoPtr_wrapDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, "wrapDelegate");
			DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_get_TargetType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665559);
			DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_get_ProxyType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665560);
			DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TTarget_TProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665556);
			DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_TProxy_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665557);
			DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr, 100665558);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000493F4 File Offset: 0x000475F4
		public unsafe virtual Type TargetType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_get_TargetType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00049434 File Offset: 0x00047634
		public unsafe virtual Type ProxyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_get_ProxyType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00049474 File Offset: 0x00047674
		[CallerCount(0)]
		public unsafe DelegateProxyFactory(Func<TTarget, TProxy> wrapDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateProxyFactory<TProxy, TTarget>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TTarget_TProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000494C0 File Offset: 0x000476C0
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_TProxy_TTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TProxy>(intPtr2, false, true);
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00049540 File Offset: 0x00047740
		[CallerCount(0)]
		public unsafe virtual Object CreateProxyObject(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateProxyFactory<TProxy, TTarget>.NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00005DDB File Offset: 0x00003FDB
		public DelegateProxyFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00049590 File Offset: 0x00047790
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public unsafe Func<TTarget, TProxy> wrapDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProxyFactory<TProxy, TTarget>.NativeFieldInfoPtr_wrapDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TTarget, TProxy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProxyFactory<TProxy, TTarget>.NativeFieldInfoPtr_wrapDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_wrapDelegate;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_TTarget_TProxy_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_TProxy_TTarget_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyObject_Public_Virtual_Final_New_Object_Object_0;
	}
}
