using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F2 RID: 498
	public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x06002885 RID: 10373 RVA: 0x000C260C File Offset: 0x000C080C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoSingleton()
		{
			Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MonoSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr);
			MonoSingleton<T>.NativeFieldInfoPtr__singletonLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr, "_singletonLock");
			MonoSingleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr, "_instance");
			MonoSingleton<T>.NativeMethodInfoPtr_get_Get_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr, 100669507);
			MonoSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr, 100669508);
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000C26C8 File Offset: 0x000C08C8
		public unsafe static T Get
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSingleton<T>.NativeMethodInfoPtr_get_Get_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000C26F8 File Offset: 0x000C08F8
		[CallerCount(0)]
		public unsafe MonoSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0001001F File Offset: 0x0000E21F
		public MonoSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x000C2734 File Offset: 0x000C0934
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x00010028 File Offset: 0x0000E228
		public unsafe static global::Il2CppSystem.Object _singletonLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoSingleton<T>.NativeFieldInfoPtr__singletonLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoSingleton<T>.NativeFieldInfoPtr__singletonLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x000C275C File Offset: 0x000C095C
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x000C2780 File Offset: 0x000C0980
		public unsafe static T _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoSingleton<T>.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__instance = MonoSingleton<T>.NativeFieldInfoPtr__instance;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__instance, (void*)(&ptr2));
			}
		}

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr__singletonLock;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_get_Get_Public_Static_get_T_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
