using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C8 RID: 200
	public class PermanentRegistrationPolicy : Object
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x00053074 File Offset: 0x00051274
		// Note: this type is marked as 'beforefieldinit'.
		static PermanentRegistrationPolicy()
		{
			Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.RegistrationPolicies", "PermanentRegistrationPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr);
			PermanentRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr, 100666041);
			PermanentRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr, 100666039);
			PermanentRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Final_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr, 100666040);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000530E0 File Offset: 0x000512E0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PermanentRegistrationPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermanentRegistrationPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermanentRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0005311C File Offset: 0x0005131C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermanentRegistrationPolicy.NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00053180 File Offset: 0x00051380
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermanentRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Final_New_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00006A29 File Offset: 0x00004C29
		public PermanentRegistrationPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_HandleRegistration_Public_Virtual_Final_New_IUserDataDescriptor_IUserDataDescriptor_IUserDataDescriptor_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Final_New_Boolean_Type_0;
	}
}
