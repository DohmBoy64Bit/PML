using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000071 RID: 113
	public class ReturnStatement : Statement
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x0003EA3C File Offset: 0x0003CC3C
		// Note: this type is marked as 'beforefieldinit'.
		static ReturnStatement()
		{
			Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "ReturnStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr);
			ReturnStatement.NativeFieldInfoPtr_m_Expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr, "m_Expression");
			ReturnStatement.NativeFieldInfoPtr_m_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr, "m_Ref");
			ReturnStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr, 100665181);
			ReturnStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr, 100665182);
			ReturnStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr, 100665183);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0003EAD0 File Offset: 0x0003CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30510, XrefRangeEnd = 30517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnStatement(ScriptLoadingContext lcontext, Expression e, SourceRef sref)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sref);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0003EB40 File Offset: 0x0003CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30517, XrefRangeEnd = 30541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0003EB8C File Offset: 0x0003CD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30541, XrefRangeEnd = 30553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0000511C File Offset: 0x0000331C
		public ReturnStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00005125 File Offset: 0x00003325
		public unsafe Expression m_Expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnStatement.NativeFieldInfoPtr_m_Expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnStatement.NativeFieldInfoPtr_m_Expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0003EC0C File Offset: 0x0003CE0C
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00005144 File Offset: 0x00003344
		public unsafe SourceRef m_Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnStatement.NativeFieldInfoPtr_m_Ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnStatement.NativeFieldInfoPtr_m_Ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_m_Expression;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_m_Ref;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_SourceRef_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
