using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009F RID: 159
	public class IUserDataMemberDescriptor : Object
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x00047CBC File Offset: 0x00045EBC
		// Note: this type is marked as 'beforefieldinit'.
		static IUserDataMemberDescriptor()
		{
			Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IUserDataMemberDescriptor");
			IUserDataMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665515);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665516);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_UserDataMemberType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665519);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665521);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665517);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665518);
			IUserDataMemberDescriptor.NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataMemberDescriptor>.NativeClassPtr, 100665520);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00047D70 File Offset: 0x00045F70
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00047DB4 File Offset: 0x00045FB4
		public unsafe virtual Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00047E00 File Offset: 0x00046000
		public unsafe virtual UserDataMemberType MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_UserDataMemberType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserDataMemberType>(intPtr3) : null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00047E4C File Offset: 0x0004604C
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00047E94 File Offset: 0x00046094
		[CallerCount(0)]
		public unsafe virtual DynValue GetValue(Script script, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00047F04 File Offset: 0x00046104
		[CallerCount(0)]
		public unsafe virtual bool SetValue(Script script, Object obj, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00047F80 File Offset: 0x00046180
		[CallerCount(0)]
		public unsafe virtual void Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataMemberDescriptor.NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00005C1A File Offset: 0x00003E1A
		public IUserDataMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_UserDataMemberType_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Public_Abstract_Virtual_New_Void_0;
	}
}
