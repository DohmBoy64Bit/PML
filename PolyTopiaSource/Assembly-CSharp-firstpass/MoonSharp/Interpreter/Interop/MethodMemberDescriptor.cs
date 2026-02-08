using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B5 RID: 181
	public class MethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x0004D708 File Offset: 0x0004B908
		// Note: this type is marked as 'beforefieldinit'.
		static MethodMemberDescriptor()
		{
			Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "MethodMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr);
			MethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "<MethodInfo>k__BackingField");
			MethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			MethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "<IsConstructor>k__BackingField");
			MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "m_OptimizedFunc");
			MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "m_OptimizedAction");
			MethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "m_IsAction");
			MethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "m_IsArrayCtor");
			MethodMemberDescriptor.NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665789);
			MethodMemberDescriptor.NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665790);
			MethodMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665791);
			MethodMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665792);
			MethodMemberDescriptor.NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665793);
			MethodMemberDescriptor.NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665794);
			MethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665795);
			MethodMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_MethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665796);
			MethodMemberDescriptor.NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665797);
			MethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665798);
			MethodMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665799);
			MethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, 100665800);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0004D8B4 File Offset: 0x0004BAB4
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x0004D8F4 File Offset: 0x0004BAF4
		public unsafe MethodBase MethodInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0004D938 File Offset: 0x0004BB38
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x0004D978 File Offset: 0x0004BB78
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35810, RefRangeEnd = 35812, XrefRangeStart = 35810, XrefRangeEnd = 35812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35812, RefRangeEnd = 35813, XrefRangeStart = 35812, XrefRangeEnd = 35813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0004D9BC File Offset: 0x0004BBBC
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		public unsafe bool IsConstructor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35813, RefRangeEnd = 35814, XrefRangeStart = 35813, XrefRangeEnd = 35814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004DA38 File Offset: 0x0004BC38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36286, RefRangeEnd = 36291, XrefRangeStart = 36187, XrefRangeEnd = 36286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004DA98 File Offset: 0x0004BC98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36298, RefRangeEnd = 36300, XrefRangeStart = 36291, XrefRangeEnd = 36298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceVisibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_MethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004DAFC File Offset: 0x0004BCFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 36328, RefRangeEnd = 36334, XrefRangeStart = 36300, XrefRangeEnd = 36328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004DB4C File Offset: 0x0004BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36334, XrefRangeEnd = 36383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Execute(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36383, XrefRangeEnd = 36484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0004DC14 File Offset: 0x0004BE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36484, XrefRangeEnd = 36556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00006324 File Offset: 0x00004524
		public MethodMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0004DC58 File Offset: 0x0004BE58
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x0000632D File Offset: 0x0000452D
		public unsafe MethodBase _MethodInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0004DC88 File Offset: 0x0004BE88
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x0000634C File Offset: 0x0000454C
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0004DCB8 File Offset: 0x0004BEB8
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0000636B File Offset: 0x0000456B
		public unsafe bool _IsConstructor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00006386 File Offset: 0x00004586
		public unsafe Func<Object, Il2CppReferenceArray<Object>, Object> m_OptimizedFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Il2CppReferenceArray<Object>, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0004DD10 File Offset: 0x0004BF10
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x000063A5 File Offset: 0x000045A5
		public unsafe Action<Object, Il2CppReferenceArray<Object>> m_OptimizedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Il2CppReferenceArray<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_OptimizedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0004DD40 File Offset: 0x0004BF40
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x000063C4 File Offset: 0x000045C4
		public unsafe bool m_IsAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0004DD68 File Offset: 0x0004BF68
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x000063DF File Offset: 0x000045DF
		public unsafe bool m_IsArrayCtor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor)) = value;
			}
		}

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr__MethodInfo_k__BackingField;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr__IsConstructor_k__BackingField;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr_m_OptimizedFunc;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_m_OptimizedAction;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAction;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_m_IsArrayCtor;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_MethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;

		// Token: 0x020001C8 RID: 456
		[ObfuscatedName("MoonSharp.Interpreter.Interop.MethodMemberDescriptor+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001BC0 RID: 7104 RVA: 0x0008784C File Offset: 0x00085A4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MethodMemberDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr);
				MethodMemberDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, "<>9");
				MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, "<>9__16_0");
				MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, "<>9__16_1");
				MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, "<>9__18_0");
				MethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, 100665802);
				MethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_ParameterDescriptor_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, 100665803);
				MethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Boolean_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, 100665804);
				MethodMemberDescriptor.__c.NativeMethodInfoPtr__CheckMethodIsCompatible_b__18_0_Internal_Boolean_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr, 100665805);
			}

			// Token: 0x06001BC1 RID: 7105 RVA: 0x00087918 File Offset: 0x00085B18
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodMemberDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x00087954 File Offset: 0x00085B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36183, XrefRangeEnd = 36187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterDescriptor __ctor_b__16_0(ParameterInfo pi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_ParameterDescriptor_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x06001BC3 RID: 7107 RVA: 0x000879A4 File Offset: 0x00085BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__16_1(ParameterDescriptor p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Boolean_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BC4 RID: 7108 RVA: 0x000879F4 File Offset: 0x00085BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckMethodIsCompatible_b__18_0(ParameterInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodMemberDescriptor.__c.NativeMethodInfoPtr__CheckMethodIsCompatible_b__18_0_Internal_Boolean_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BC5 RID: 7109 RVA: 0x0000AE79 File Offset: 0x00009079
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00087A44 File Offset: 0x00085C44
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000AE82 File Offset: 0x00009082
			public unsafe static MethodMemberDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodMemberDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00087A6C File Offset: 0x00085C6C
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000AE94 File Offset: 0x00009094
			public unsafe static Func<ParameterInfo, ParameterDescriptor> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, ParameterDescriptor>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00087A94 File Offset: 0x00085C94
			// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0000AEA6 File Offset: 0x000090A6
			public unsafe static Func<ParameterDescriptor, bool> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterDescriptor, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00087ABC File Offset: 0x00085CBC
			// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0000AEB8 File Offset: 0x000090B8
			public unsafe static Func<ParameterInfo, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethodMemberDescriptor.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166B RID: 5739
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_0_Internal_ParameterDescriptor_ParameterInfo_0;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_1_Internal_Boolean_ParameterDescriptor_0;

			// Token: 0x04001672 RID: 5746
			private static readonly IntPtr NativeMethodInfoPtr__CheckMethodIsCompatible_b__18_0_Internal_Boolean_ParameterInfo_0;
		}
	}
}
