using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000CF RID: 207
	public static class ClrToScriptConversions : Object
	{
		// Token: 0x0600100F RID: 4111 RVA: 0x00056CE4 File Offset: 0x00054EE4
		// Note: this type is marked as 'beforefieldinit'.
		static ClrToScriptConversions()
		{
			Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.Converters", "ClrToScriptConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr);
			ClrToScriptConversions.NativeMethodInfoPtr_TryObjectToTrivialDynValue_Internal_Static_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr, 100666186);
			ClrToScriptConversions.NativeMethodInfoPtr_TryObjectToSimpleDynValue_Internal_Static_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr, 100666187);
			ClrToScriptConversions.NativeMethodInfoPtr_ObjectToDynValue_Internal_Static_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr, 100666188);
			ClrToScriptConversions.NativeMethodInfoPtr_EnumerationToDynValue_Public_Static_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClrToScriptConversions>.NativeClassPtr, 100666189);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00056D64 File Offset: 0x00054F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41249, RefRangeEnd = 41250, XrefRangeStart = 41228, XrefRangeEnd = 41249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue TryObjectToTrivialDynValue(Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClrToScriptConversions.NativeMethodInfoPtr_TryObjectToTrivialDynValue_Internal_Static_DynValue_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00056DBC File Offset: 0x00054FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41279, RefRangeEnd = 41280, XrefRangeStart = 41250, XrefRangeEnd = 41279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue TryObjectToSimpleDynValue(Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClrToScriptConversions.NativeMethodInfoPtr_TryObjectToSimpleDynValue_Internal_Static_DynValue_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00056E14 File Offset: 0x00055014
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 41322, RefRangeEnd = 41356, XrefRangeStart = 41280, XrefRangeEnd = 41322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ObjectToDynValue(Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClrToScriptConversions.NativeMethodInfoPtr_ObjectToDynValue_Internal_Static_DynValue_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00056E6C File Offset: 0x0005506C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41356, XrefRangeEnd = 41362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue EnumerationToDynValue(Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClrToScriptConversions.NativeMethodInfoPtr_EnumerationToDynValue_Public_Static_DynValue_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00006C5B File Offset: 0x00004E5B
		public ClrToScriptConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_TryObjectToTrivialDynValue_Internal_Static_DynValue_Script_Object_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_TryObjectToSimpleDynValue_Internal_Static_DynValue_Script_Object_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_ObjectToDynValue_Internal_Static_DynValue_Script_Object_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_EnumerationToDynValue_Public_Static_DynValue_Script_Object_0;
	}
}
