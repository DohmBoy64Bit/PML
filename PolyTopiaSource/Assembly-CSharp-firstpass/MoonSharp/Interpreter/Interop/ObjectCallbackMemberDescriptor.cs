using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B0 RID: 176
	public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x0004B518 File Offset: 0x00049718
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectCallbackMemberDescriptor()
		{
			Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "ObjectCallbackMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr);
			ObjectCallbackMemberDescriptor.NativeFieldInfoPtr_m_CallbackFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, "m_CallbackFunc");
			ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, 100665629);
			ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, 100665630);
			ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_Il2CppReferenceArray_1_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, 100665631);
			ObjectCallbackMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, 100665632);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004B5AC File Offset: 0x000497AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34326, XrefRangeEnd = 34347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectCallbackMemberDescriptor(string funcName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004B5F8 File Offset: 0x000497F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34347, XrefRangeEnd = 34353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectCallbackMemberDescriptor(string funcName, Func<Object, ScriptExecutionContext, CallbackArguments, Object> callBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0004B658 File Offset: 0x00049858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34353, XrefRangeEnd = 34356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectCallbackMemberDescriptor(string funcName, Func<Object, ScriptExecutionContext, CallbackArguments, Object> callBack, Il2CppReferenceArray<ParameterDescriptor> parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCallbackMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_Il2CppReferenceArray_1_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0004B6C8 File Offset: 0x000498C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34356, XrefRangeEnd = 34363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Execute(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectCallbackMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0000601D File Offset: 0x0000421D
		public ObjectCallbackMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0004B75C File Offset: 0x0004995C
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00006026 File Offset: 0x00004226
		public unsafe Func<Object, ScriptExecutionContext, CallbackArguments, Object> m_CallbackFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCallbackMemberDescriptor.NativeFieldInfoPtr_m_CallbackFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ScriptExecutionContext, CallbackArguments, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCallbackMemberDescriptor.NativeFieldInfoPtr_m_CallbackFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_m_CallbackFunc;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_Object_ScriptExecutionContext_CallbackArguments_Object_Il2CppReferenceArray_1_ParameterDescriptor_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x020001B3 RID: 435
		[ObfuscatedName("MoonSharp.Interpreter.Interop.ObjectCallbackMemberDescriptor+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001B09 RID: 6921 RVA: 0x00083290 File Offset: 0x00081490
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr);
				ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr, "<>9");
				ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr, "<>9__1_0");
				ObjectCallbackMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr, 100665634);
				ObjectCallbackMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_Object_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr, 100665635);
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x0008330C File Offset: 0x0008150C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCallbackMemberDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCallbackMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0B RID: 6923 RVA: 0x00083348 File Offset: 0x00081548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34318, XrefRangeEnd = 34326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object __ctor_b__1_0(Object o, ScriptExecutionContext c, CallbackArguments a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCallbackMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_Object_Object_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06001B0C RID: 6924 RVA: 0x0000AB75 File Offset: 0x00008D75
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000833BC File Offset: 0x000815BC
			// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000AB7E File Offset: 0x00008D7E
			public unsafe static ObjectCallbackMemberDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectCallbackMemberDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000833E4 File Offset: 0x000815E4
			// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000AB90 File Offset: 0x00008D90
			public unsafe static Func<Object, ScriptExecutionContext, CallbackArguments, Object> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ScriptExecutionContext, CallbackArguments, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectCallbackMemberDescriptor.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Internal_Object_Object_ScriptExecutionContext_CallbackArguments_0;
		}
	}
}
