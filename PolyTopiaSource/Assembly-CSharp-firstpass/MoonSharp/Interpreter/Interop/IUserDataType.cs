using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A0 RID: 160
	public class IUserDataType : Object
	{
		// Token: 0x06000CC7 RID: 3271 RVA: 0x00047FBC File Offset: 0x000461BC
		// Note: this type is marked as 'beforefieldinit'.
		static IUserDataType()
		{
			Il2CppClassPointerStore<IUserDataType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IUserDataType");
			IUserDataType.NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataType>.NativeClassPtr, 100665522);
			IUserDataType.NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataType>.NativeClassPtr, 100665523);
			IUserDataType.NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataType>.NativeClassPtr, 100665524);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00048020 File Offset: 0x00046220
		[CallerCount(0)]
		public unsafe virtual DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataType.NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0004809C File Offset: 0x0004629C
		[CallerCount(0)]
		public unsafe virtual bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataType.NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_DynValue_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00048128 File Offset: 0x00046328
		[CallerCount(0)]
		public unsafe virtual DynValue MetaIndex(Script script, string metaname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metaname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataType.NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00005C23 File Offset: 0x00003E23
		public IUserDataType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_DynValue_Boolean_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_DynValue_DynValue_Boolean_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_String_0;
	}
}
