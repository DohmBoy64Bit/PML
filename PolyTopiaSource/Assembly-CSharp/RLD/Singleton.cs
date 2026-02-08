using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001F3 RID: 499
	public class Singleton<T> : Object where T : class, new()
	{
		// Token: 0x0600288D RID: 10381 RVA: 0x000C27E8 File Offset: 0x000C09E8
		// Note: this type is marked as 'beforefieldinit'.
		static Singleton()
		{
			Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr);
			Singleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "_instance");
			Singleton<T>.NativeMethodInfoPtr_get_Get_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669510);
			Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669511);
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000C2890 File Offset: 0x000C0A90
		public unsafe static T Get
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_Get_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000C28C0 File Offset: 0x000C0AC0
		[CallerCount(0)]
		public unsafe Singleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0001003A File Offset: 0x0000E23A
		public Singleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000C28FC File Offset: 0x000C0AFC
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x000C2920 File Offset: 0x000C0B20
		public unsafe static T _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Singleton<T>.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__instance = Singleton<T>.NativeFieldInfoPtr__instance;
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

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_get_Get_Public_Static_get_T_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
