using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000091 RID: 145
	public class InvalidScriptLoader : Object
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x00044F94 File Offset: 0x00043194
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidScriptLoader()
		{
			Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "InvalidScriptLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr);
			InvalidScriptLoader.NativeFieldInfoPtr_m_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr, "m_Error");
			InvalidScriptLoader.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr, 100665392);
			InvalidScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Final_New_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr, 100665393);
			InvalidScriptLoader.NativeMethodInfoPtr_ResolveFileName_Public_Virtual_Final_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr, 100665394);
			InvalidScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_Final_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr, 100665395);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00045028 File Offset: 0x00043228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32578, XrefRangeEnd = 32585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidScriptLoader(string frameworkname)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidScriptLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(frameworkname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidScriptLoader.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00045074 File Offset: 0x00043274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32585, XrefRangeEnd = 32590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Final_New_Object_String_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000450D8 File Offset: 0x000432D8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidScriptLoader.NativeMethodInfoPtr_ResolveFileName_Public_Virtual_Final_New_String_String_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00045134 File Offset: 0x00043334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32590, XrefRangeEnd = 32595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidScriptLoader.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_Final_New_String_String_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000059E9 File Offset: 0x00003BE9
		public InvalidScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00045190 File Offset: 0x00043390
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000059F2 File Offset: 0x00003BF2
		public unsafe string m_Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidScriptLoader.NativeFieldInfoPtr_m_Error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidScriptLoader.NativeFieldInfoPtr_m_Error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_m_Error;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Virtual_Final_New_Object_String_Table_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFileName_Public_Virtual_Final_New_String_String_Table_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_Final_New_String_String_Table_0;
	}
}
