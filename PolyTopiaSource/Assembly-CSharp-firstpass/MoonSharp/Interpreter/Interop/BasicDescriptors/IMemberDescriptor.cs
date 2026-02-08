using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D5 RID: 213
	public class IMemberDescriptor : Object
	{
		// Token: 0x0600109F RID: 4255 RVA: 0x000590D0 File Offset: 0x000572D0
		// Note: this type is marked as 'beforefieldinit'.
		static IMemberDescriptor()
		{
			Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "IMemberDescriptor");
			IMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr, 100666267);
			IMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr, 100666268);
			IMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Abstract_Virtual_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr, 100666269);
			IMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr, 100666270);
			IMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemberDescriptor>.NativeClassPtr, 100666271);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0005915C File Offset: 0x0005735C
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x000591A4 File Offset: 0x000573A4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000591E8 File Offset: 0x000573E8
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Abstract_Virtual_New_get_MemberDescriptorAccess_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00059234 File Offset: 0x00057434
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000592A4 File Offset: 0x000574A4
		[CallerCount(0)]
		public unsafe virtual void SetValue(Script script, Object obj, DynValue value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Script_Object_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00006EE7 File Offset: 0x000050E7
		public IMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Abstract_Virtual_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_DynValue_Script_Object_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Script_Object_DynValue_0;
	}
}
