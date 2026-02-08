using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000061 RID: 97
	public class LoopBoundary : Object
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x0003BA60 File Offset: 0x00039C60
		// Note: this type is marked as 'beforefieldinit'.
		static LoopBoundary()
		{
			Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "LoopBoundary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr);
			LoopBoundary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr, 100665096);
			LoopBoundary.NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr, 100665094);
			LoopBoundary.NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr, 100665095);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0003BACC File Offset: 0x00039CCC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopBoundary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopBoundary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopBoundary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0003BB08 File Offset: 0x00039D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29431, XrefRangeEnd = 29437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompileBreak(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopBoundary.NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0003BB4C File Offset: 0x00039D4C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopBoundary.NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0000499E File Offset: 0x00002B9E
		public LoopBoundary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0;
	}
}
