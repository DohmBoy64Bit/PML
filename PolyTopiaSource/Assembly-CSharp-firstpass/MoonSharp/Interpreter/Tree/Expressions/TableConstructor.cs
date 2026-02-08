using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007E RID: 126
	public class TableConstructor : Expression
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x000416BC File Offset: 0x0003F8BC
		// Note: this type is marked as 'beforefieldinit'.
		static TableConstructor()
		{
			Il2CppClassPointerStore<TableConstructor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "TableConstructor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr);
			TableConstructor.NativeFieldInfoPtr_m_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, "m_Shared");
			TableConstructor.NativeFieldInfoPtr_m_PositionalValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, "m_PositionalValues");
			TableConstructor.NativeFieldInfoPtr_m_CtorArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, "m_CtorArgs");
			TableConstructor.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665258);
			TableConstructor.NativeMethodInfoPtr_MapField_Private_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665259);
			TableConstructor.NativeMethodInfoPtr_StructField_Private_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665260);
			TableConstructor.NativeMethodInfoPtr_ArrayField_Private_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665261);
			TableConstructor.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665262);
			TableConstructor.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr, 100665263);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000417A0 File Offset: 0x0003F9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31440, RefRangeEnd = 31441, XrefRangeStart = 31409, XrefRangeEnd = 31440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableConstructor(ScriptLoadingContext lcontext, bool shared)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableConstructor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConstructor.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000417FC File Offset: 0x0003F9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31454, RefRangeEnd = 31455, XrefRangeStart = 31441, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MapField(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConstructor.NativeMethodInfoPtr_MapField_Private_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00041840 File Offset: 0x0003FA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31475, RefRangeEnd = 31476, XrefRangeStart = 31455, XrefRangeEnd = 31475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StructField(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConstructor.NativeMethodInfoPtr_StructField_Private_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00041884 File Offset: 0x0003FA84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31483, RefRangeEnd = 31484, XrefRangeStart = 31476, XrefRangeEnd = 31483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayField(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableConstructor.NativeMethodInfoPtr_ArrayField_Private_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000418C8 File Offset: 0x0003FAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31484, XrefRangeEnd = 31508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TableConstructor.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00041918 File Offset: 0x0003FB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31508, XrefRangeEnd = 31545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TableConstructor.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00005681 File Offset: 0x00003881
		public TableConstructor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00041974 File Offset: 0x0003FB74
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0000568A File Offset: 0x0000388A
		public unsafe bool m_Shared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_Shared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_Shared)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0004199C File Offset: 0x0003FB9C
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000056A5 File Offset: 0x000038A5
		public unsafe List<Expression> m_PositionalValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_PositionalValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_PositionalValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000419CC File Offset: 0x0003FBCC
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000056C4 File Offset: 0x000038C4
		public unsafe List<KeyValuePair<Expression, Expression>> m_CtorArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_CtorArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Expression, Expression>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableConstructor.NativeFieldInfoPtr_m_CtorArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_m_Shared;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionalValues;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr_m_CtorArgs;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_MapField_Private_Void_ScriptLoadingContext_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_StructField_Private_Void_ScriptLoadingContext_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_ArrayField_Private_Void_ScriptLoadingContext_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
