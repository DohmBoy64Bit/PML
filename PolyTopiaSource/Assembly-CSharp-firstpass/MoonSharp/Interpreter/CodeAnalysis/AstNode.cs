using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CodeAnalysis
{
	// Token: 0x02000127 RID: 295
	public class AstNode : Object
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x000084D9 File Offset: 0x000066D9
		// Note: this type is marked as 'beforefieldinit'.
		static AstNode()
		{
			Il2CppClassPointerStore<AstNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CodeAnalysis", "AstNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstNode>.NativeClassPtr);
			AstNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100667185);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00071130 File Offset: 0x0006F330
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00008512 File Offset: 0x00006712
		public AstNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
