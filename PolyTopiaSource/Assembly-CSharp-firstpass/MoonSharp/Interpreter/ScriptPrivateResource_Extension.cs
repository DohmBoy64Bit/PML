using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000030 RID: 48
	public static class ScriptPrivateResource_Extension : Object
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0002F28C File Offset: 0x0002D48C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPrivateResource_Extension()
		{
			Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptPrivateResource_Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr);
			ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr, 100664615);
			ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr, 100664616);
			ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr, 100664617);
			ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_IScriptPrivateResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPrivateResource_Extension>.NativeClassPtr, 100664618);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002F30C File Offset: 0x0002D50C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 23163, RefRangeEnd = 23168, XrefRangeStart = 23158, XrefRangeEnd = 23163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckScriptOwnership(this IScriptPrivateResource containingResource, Il2CppReferenceArray<DynValue> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingResource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Il2CppReferenceArray_1_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002F354 File Offset: 0x0002D554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23168, XrefRangeEnd = 23172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckScriptOwnership(this IScriptPrivateResource containingResource, DynValue value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingResource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0002F39C File Offset: 0x0002D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23172, XrefRangeEnd = 23177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckScriptOwnership(this IScriptPrivateResource resource, Script script)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Script_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 23190, RefRangeEnd = 23212, XrefRangeStart = 23177, XrefRangeEnd = 23190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckScriptOwnership(this IScriptPrivateResource containingResource, IScriptPrivateResource itemResource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingResource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemResource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPrivateResource_Extension.NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_IScriptPrivateResource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003A0B File Offset: 0x00001C0B
		public ScriptPrivateResource_Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_DynValue_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_Script_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_CheckScriptOwnership_Public_Static_Void_IScriptPrivateResource_IScriptPrivateResource_0;
	}
}
