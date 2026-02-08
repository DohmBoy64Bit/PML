using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007C RID: 124
	public class LiteralExpression : Expression
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x000410E8 File Offset: 0x0003F2E8
		// Note: this type is marked as 'beforefieldinit'.
		static LiteralExpression()
		{
			Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "LiteralExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr);
			LiteralExpression.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, "m_Value");
			LiteralExpression.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, 100665247);
			LiteralExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, 100665248);
			LiteralExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, 100665249);
			LiteralExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, 100665250);
			LiteralExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr, 100665251);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00041190 File Offset: 0x0003F390
		public unsafe DynValue Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiteralExpression.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000411D0 File Offset: 0x0003F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiteralExpression(ScriptLoadingContext lcontext, DynValue value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiteralExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00041230 File Offset: 0x0003F430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31370, RefRangeEnd = 31371, XrefRangeStart = 31318, XrefRangeEnd = 31370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiteralExpression(ScriptLoadingContext lcontext, Token t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiteralExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiteralExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00041290 File Offset: 0x0003F490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31371, XrefRangeEnd = 31373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiteralExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000412E0 File Offset: 0x0003F4E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiteralExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00005612 File Offset: 0x00003812
		public LiteralExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0004133C File Offset: 0x0003F53C
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0000561B File Offset: 0x0000381B
		public unsafe DynValue m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiteralExpression.NativeFieldInfoPtr_m_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiteralExpression.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_DynValue_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_DynValue_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
