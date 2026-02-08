using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C7 RID: 199
	public class IRegistrationPolicy : Object
	{
		// Token: 0x06000F40 RID: 3904 RVA: 0x00052F5C File Offset: 0x0005115C
		// Note: this type is marked as 'beforefieldinit'.
		static IRegistrationPolicy()
		{
			Il2CppClassPointerStore<IRegistrationPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.RegistrationPolicies", "IRegistrationPolicy");
			IRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Abstract_Virtual_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistrationPolicy>.NativeClassPtr, 100666037);
			IRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistrationPolicy>.NativeClassPtr, 100666038);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00052FAC File Offset: 0x000511AC
		[CallerCount(0)]
		public unsafe virtual IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newDescriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldDescriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Abstract_Virtual_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0005301C File Offset: 0x0005121C
		[CallerCount(0)]
		public unsafe virtual bool AllowTypeAutoRegistration(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00006A20 File Offset: 0x00004C20
		public IRegistrationPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_HandleRegistration_Public_Abstract_Virtual_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Abstract_Virtual_New_Boolean_Type_0;
	}
}
