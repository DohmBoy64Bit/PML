using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000092 RID: 146
	public class IScriptLoader : Object
	{
		// Token: 0x06000C2C RID: 3116 RVA: 0x000451B8 File Offset: 0x000433B8
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptLoader()
		{
			Il2CppClassPointerStore<IScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "IScriptLoader");
			IScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptLoader>.NativeClassPtr, 100665396);
			IScriptLoader.NativeMethodInfoPtr_ResolveFileName_Public_Abstract_Virtual_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptLoader>.NativeClassPtr, 100665397);
			IScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Abstract_Virtual_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptLoader>.NativeClassPtr, 100665398);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0004521C File Offset: 0x0004341C
		[CallerCount(0)]
		public unsafe virtual Object LoadFile(string file, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0004528C File Offset: 0x0004348C
		[CallerCount(0)]
		public unsafe virtual string ResolveFileName(string filename, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptLoader.NativeMethodInfoPtr_ResolveFileName_Public_Abstract_Virtual_New_String_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000452F4 File Offset: 0x000434F4
		[CallerCount(0)]
		public unsafe virtual string ResolveModuleName(string modname, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Abstract_Virtual_New_String_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00005A11 File Offset: 0x00003C11
		public IScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFileName_Public_Abstract_Virtual_New_String_String_Table_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_ResolveModuleName_Public_Abstract_Virtual_New_String_String_Table_0;
	}
}
