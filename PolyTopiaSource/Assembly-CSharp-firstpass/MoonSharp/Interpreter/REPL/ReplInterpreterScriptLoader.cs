using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000087 RID: 135
	public class ReplInterpreterScriptLoader : FileSystemScriptLoader
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00042B08 File Offset: 0x00040D08
		// Note: this type is marked as 'beforefieldinit'.
		static ReplInterpreterScriptLoader()
		{
			Il2CppClassPointerStore<ReplInterpreterScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.REPL", "ReplInterpreterScriptLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplInterpreterScriptLoader>.NativeClassPtr);
			ReplInterpreterScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreterScriptLoader>.NativeClassPtr, 100665302);
			ReplInterpreterScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreterScriptLoader>.NativeClassPtr, 100665303);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00042B60 File Offset: 0x00040D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32153, XrefRangeEnd = 32176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplInterpreterScriptLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplInterpreterScriptLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreterScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00042B9C File Offset: 0x00040D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32176, XrefRangeEnd = 32185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ResolveModuleName(string modname, Table globalContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplInterpreterScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_String_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000058A2 File Offset: 0x00003AA2
		public ReplInterpreterScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_String_String_Table_0;
	}
}
