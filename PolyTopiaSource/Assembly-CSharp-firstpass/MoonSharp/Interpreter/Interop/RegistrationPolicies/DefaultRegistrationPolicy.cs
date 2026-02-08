using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C6 RID: 198
	public class DefaultRegistrationPolicy : Object
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x00052DF8 File Offset: 0x00050FF8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultRegistrationPolicy()
		{
			Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.RegistrationPolicies", "DefaultRegistrationPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr);
			DefaultRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr, 100666036);
			DefaultRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr, 100666034);
			DefaultRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr, 100666035);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00052E64 File Offset: 0x00051064
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultRegistrationPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultRegistrationPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00052EA0 File Offset: 0x000510A0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00052F04 File Offset: 0x00051104
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllowTypeAutoRegistration(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00006A17 File Offset: 0x00004C17
		public DefaultRegistrationPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_New_Boolean_Type_0;
	}
}
