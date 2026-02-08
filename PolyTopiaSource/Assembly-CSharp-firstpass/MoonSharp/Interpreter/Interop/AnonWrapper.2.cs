using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A2 RID: 162
	public class AnonWrapper<T> : AnonWrapper
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x000481D4 File Offset: 0x000463D4
		// Note: this type is marked as 'beforefieldinit'.
		static AnonWrapper()
		{
			Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "AnonWrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr);
			AnonWrapper<T>.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr, "<Value>k__BackingField");
			AnonWrapper<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr, 100665528);
			AnonWrapper<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr, 100665529);
			AnonWrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr, 100665526);
			AnonWrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr, 100665527);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x000482A4 File Offset: 0x000464A4
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000482E0 File Offset: 0x000464E0
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnonWrapper<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AnonWrapper<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00048358 File Offset: 0x00046558
		[CallerCount(0)]
		public unsafe AnonWrapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnonWrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00048394 File Offset: 0x00046594
		[CallerCount(0)]
		public unsafe AnonWrapper(T o)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnonWrapper<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = o;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref o;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AnonWrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00005C6E File Offset: 0x00003E6E
		public AnonWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00048418 File Offset: 0x00046618
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00048440 File Offset: 0x00046640
		public unsafe T _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnonWrapper<T>.NativeFieldInfoPtr__Value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnonWrapper<T>.NativeFieldInfoPtr__Value_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;
	}
}
