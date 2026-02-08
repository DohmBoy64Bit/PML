using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011F RID: 287
	public class StandardIOFileUserDataBase : StreamFileUserDataBase
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x0006E7E0 File Offset: 0x0006C9E0
		// Note: this type is marked as 'beforefieldinit'.
		static StandardIOFileUserDataBase()
		{
			Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.IO", "StandardIOFileUserDataBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr);
			StandardIOFileUserDataBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr, 100667098);
			StandardIOFileUserDataBase.NativeMethodInfoPtr_Close_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr, 100667095);
			StandardIOFileUserDataBase.NativeMethodInfoPtr_CreateInputStream_Public_Static_StandardIOFileUserDataBase_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr, 100667096);
			StandardIOFileUserDataBase.NativeMethodInfoPtr_CreateOutputStream_Public_Static_StandardIOFileUserDataBase_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr, 100667097);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0006E860 File Offset: 0x0006CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardIOFileUserDataBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardIOFileUserDataBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardIOFileUserDataBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0006E89C File Offset: 0x0006CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51564, XrefRangeEnd = 51566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardIOFileUserDataBase.NativeMethodInfoPtr_Close_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51577, RefRangeEnd = 51580, XrefRangeStart = 51566, XrefRangeEnd = 51577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandardIOFileUserDataBase CreateInputStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardIOFileUserDataBase.NativeMethodInfoPtr_CreateInputStream_Public_Static_StandardIOFileUserDataBase_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardIOFileUserDataBase>(intPtr3) : null;
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0006E924 File Offset: 0x0006CB24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 51591, RefRangeEnd = 51595, XrefRangeStart = 51580, XrefRangeEnd = 51591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandardIOFileUserDataBase CreateOutputStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardIOFileUserDataBase.NativeMethodInfoPtr_CreateOutputStream_Public_Static_StandardIOFileUserDataBase_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardIOFileUserDataBase>(intPtr3) : null;
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000083A4 File Offset: 0x000065A4
		public StandardIOFileUserDataBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_String_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputStream_Public_Static_StandardIOFileUserDataBase_Stream_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_CreateOutputStream_Public_Static_StandardIOFileUserDataBase_Stream_0;
	}
}
