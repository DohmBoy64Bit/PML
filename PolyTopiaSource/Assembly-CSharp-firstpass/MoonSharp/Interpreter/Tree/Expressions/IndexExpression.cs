using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007B RID: 123
	public class IndexExpression : Expression
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		// Note: this type is marked as 'beforefieldinit'.
		static IndexExpression()
		{
			Il2CppClassPointerStore<IndexExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "IndexExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr);
			IndexExpression.NativeFieldInfoPtr_m_BaseExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "m_BaseExp");
			IndexExpression.NativeFieldInfoPtr_m_IndexExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "m_IndexExp");
			IndexExpression.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "m_Name");
			IndexExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100665242);
			IndexExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_String_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100665243);
			IndexExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100665244);
			IndexExpression.NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100665245);
			IndexExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100665246);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00040E74 File Offset: 0x0003F074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31285, XrefRangeEnd = 31288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexExpression(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseExp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexExp);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_Expression_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00040EE4 File Offset: 0x0003F0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31288, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexExpression(Expression baseExp, string name, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseExp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_String_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00040F54 File Offset: 0x0003F154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31291, XrefRangeEnd = 31298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00040FA4 File Offset: 0x0003F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31298, XrefRangeEnd = 31305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackofs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tupleidx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00041004 File Offset: 0x0003F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31305, XrefRangeEnd = 31318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000055AC File Offset: 0x000037AC
		public IndexExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00041060 File Offset: 0x0003F260
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000055B5 File Offset: 0x000037B5
		public unsafe Expression m_BaseExp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_BaseExp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_BaseExp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00041090 File Offset: 0x0003F290
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000055D4 File Offset: 0x000037D4
		public unsafe Expression m_IndexExp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_IndexExp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_IndexExp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000410C0 File Offset: 0x0003F2C0
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000055F3 File Offset: 0x000037F3
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseExp;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexExp;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Expression_ScriptLoadingContext_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_String_ScriptLoadingContext_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
