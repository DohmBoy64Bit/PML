using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C3 RID: 195
	public class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x06000F2E RID: 3886 RVA: 0x00052A90 File Offset: 0x00050C90
		// Note: this type is marked as 'beforefieldinit'.
		static HardwiredMethodMemberDescriptor()
		{
			Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors", "HardwiredMethodMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr);
			HardwiredMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr, 100666030);
			HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr, 100666027);
			HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_CalcArgsCount_Private_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr, 100666028);
			HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_Invoke_Protected_Abstract_Virtual_New_Object_Script_Object_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr, 100666029);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00052B10 File Offset: 0x00050D10
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwiredMethodMemberDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwiredMethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwiredMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00052B4C File Offset: 0x00050D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39626, XrefRangeEnd = 39635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00052BE0 File Offset: 0x00050DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39635, XrefRangeEnd = 39638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalcArgsCount(Il2CppReferenceArray<Object> pars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_CalcArgsCount_Private_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00052C30 File Offset: 0x00050E30
		[CallerCount(0)]
		public unsafe virtual Object Invoke(Script script, Object obj, Il2CppReferenceArray<Object> pars, int argscount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pars);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argscount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HardwiredMethodMemberDescriptor.NativeMethodInfoPtr_Invoke_Protected_Abstract_Virtual_New_Object_Script_Object_Il2CppReferenceArray_1_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000069C3 File Offset: 0x00004BC3
		public HardwiredMethodMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_CalcArgsCount_Private_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Protected_Abstract_Virtual_New_Object_Script_Object_Il2CppReferenceArray_1_Object_Int32_0;
	}
}
