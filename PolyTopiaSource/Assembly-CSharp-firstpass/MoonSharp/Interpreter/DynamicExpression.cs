using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000044 RID: 68
	public class DynamicExpression : Object
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x000356EC File Offset: 0x000338EC
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicExpression()
		{
			Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "DynamicExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr);
			DynamicExpression.NativeFieldInfoPtr_m_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, "m_Exp");
			DynamicExpression.NativeFieldInfoPtr_m_Constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, "m_Constant");
			DynamicExpression.NativeFieldInfoPtr_ExpressionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, "ExpressionCode");
			DynamicExpression.NativeFieldInfoPtr__OwnerScript_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, "<OwnerScript>k__BackingField");
			DynamicExpression.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664861);
			DynamicExpression.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664862);
			DynamicExpression.NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynamicExprExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664857);
			DynamicExpression.NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664858);
			DynamicExpression.NativeMethodInfoPtr_Evaluate_Public_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664859);
			DynamicExpression.NativeMethodInfoPtr_FindSymbol_Public_SymbolRef_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664860);
			DynamicExpression.NativeMethodInfoPtr_IsConstant_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664863);
			DynamicExpression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664864);
			DynamicExpression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr, 100664865);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00035820 File Offset: 0x00033A20
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00035860 File Offset: 0x00033A60
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000358A4 File Offset: 0x00033AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25714, XrefRangeEnd = 25718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpression(Script S, string strExpr, DynamicExprExpression expr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strExpr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynamicExprExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00035914 File Offset: 0x00033B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25718, XrefRangeEnd = 25722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpression(Script S, string strExpr, DynValue constant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strExpr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00035984 File Offset: 0x00033B84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25728, RefRangeEnd = 25733, XrefRangeStart = 25722, XrefRangeEnd = 25728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Evaluate(ScriptExecutionContext context = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr_Evaluate_Public_DynValue_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000359D4 File Offset: 0x00033BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25738, RefRangeEnd = 25739, XrefRangeStart = 25733, XrefRangeEnd = 25738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef FindSymbol(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr_FindSymbol_Public_SymbolRef_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00035A24 File Offset: 0x00033C24
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 25739, RefRangeEnd = 25748, XrefRangeStart = 25739, XrefRangeEnd = 25739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpression.NativeMethodInfoPtr_IsConstant_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00035A60 File Offset: 0x00033C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25748, XrefRangeEnd = 25749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicExpression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00035AA8 File Offset: 0x00033CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25749, XrefRangeEnd = 25752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicExpression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0000403A File Offset: 0x0000223A
		public DynamicExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00035B00 File Offset: 0x00033D00
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00004043 File Offset: 0x00002243
		public unsafe DynamicExprExpression m_Exp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_m_Exp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicExprExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_m_Exp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00035B30 File Offset: 0x00033D30
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00004062 File Offset: 0x00002262
		public unsafe DynValue m_Constant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_m_Constant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_m_Constant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00035B60 File Offset: 0x00033D60
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00004081 File Offset: 0x00002281
		public unsafe string ExpressionCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_ExpressionCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr_ExpressionCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00035B88 File Offset: 0x00033D88
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x000040A0 File Offset: 0x000022A0
		public unsafe Script _OwnerScript_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr__OwnerScript_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExpression.NativeFieldInfoPtr__OwnerScript_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_m_Exp;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_Constant;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_ExpressionCode;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr__OwnerScript_k__BackingField;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynamicExprExpression_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_String_DynValue_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_FindSymbol_Public_SymbolRef_ScriptExecutionContext_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Public_Boolean_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
