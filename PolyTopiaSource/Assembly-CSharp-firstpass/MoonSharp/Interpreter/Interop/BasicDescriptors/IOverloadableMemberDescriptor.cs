using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D8 RID: 216
	public class IOverloadableMemberDescriptor : Object
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x0005964C File Offset: 0x0005784C
		// Note: this type is marked as 'beforefieldinit'.
		static IOverloadableMemberDescriptor()
		{
			Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "IOverloadableMemberDescriptor");
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_ExtensionMethodType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666283);
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_Parameters_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666284);
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_VarArgsArrayType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666285);
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_VarArgsElementType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666286);
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_SortDiscriminant_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666287);
			IOverloadableMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverloadableMemberDescriptor>.NativeClassPtr, 100666282);
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x000596EC File Offset: 0x000578EC
		public unsafe virtual Type ExtensionMethodType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_ExtensionMethodType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00059738 File Offset: 0x00057938
		public unsafe virtual Il2CppReferenceArray<ParameterDescriptor> Parameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_Parameters_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00059784 File Offset: 0x00057984
		public unsafe virtual Type VarArgsArrayType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_VarArgsArrayType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x000597D0 File Offset: 0x000579D0
		public unsafe virtual Type VarArgsElementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_VarArgsElementType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0005981C File Offset: 0x00057A1C
		public unsafe virtual string SortDiscriminant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_get_SortDiscriminant_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00059860 File Offset: 0x00057A60
		[CallerCount(0)]
		public unsafe virtual DynValue Execute(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverloadableMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00006F31 File Offset: 0x00005131
		public IOverloadableMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionMethodType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_get_VarArgsArrayType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_get_VarArgsElementType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_get_SortDiscriminant_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;
	}
}
