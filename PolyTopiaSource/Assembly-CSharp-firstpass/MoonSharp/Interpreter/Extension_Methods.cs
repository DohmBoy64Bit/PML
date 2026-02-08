using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000026 RID: 38
	public static class Extension_Methods : Object
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x0002B610 File Offset: 0x00029810
		// Note: this type is marked as 'beforefieldinit'.
		static Extension_Methods()
		{
			Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "Extension_Methods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr);
			Extension_Methods.NativeMethodInfoPtr_GetOrDefault_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr, 100664427);
			Extension_Methods.NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_Func_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr, 100664428);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002B668 File Offset: 0x00029868
		[CallerCount(0)]
		public unsafe static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extension_Methods.MethodInfoStoreGeneric_GetOrDefault_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0002B6F0 File Offset: 0x000298F0
		[CallerCount(0)]
		public unsafe static TValue GetOrCreate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> creator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extension_Methods.MethodInfoStoreGeneric_GetOrCreate_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_Func_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00003614 File Offset: 0x00001814
		public Extension_Methods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_GetOrDefault_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_Func_1_TValue_0;

		// Token: 0x0200017B RID: 379
		private sealed class MethodInfoStoreGeneric_GetOrDefault_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0<TKey, TValue>
		{
			// Token: 0x04001515 RID: 5397
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extension_Methods.NativeMethodInfoPtr_GetOrDefault_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0, Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200017C RID: 380
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_Func_1_TValue_0<TKey, TValue>
		{
			// Token: 0x04001516 RID: 5398
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extension_Methods.NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_Func_1_TValue_0, Il2CppClassPointerStore<Extension_Methods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
