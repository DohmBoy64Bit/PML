using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B4 RID: 180
	public class GenericMethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004D084 File Offset: 0x0004B284
		// Note: this type is marked as 'beforefieldinit'.
		static GenericMethodMemberDescriptor()
		{
			Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "GenericMethodMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr);
			GenericMethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "<MethodInfo>k__BackingField");
			GenericMethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			GenericMethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "<IsConstructor>k__BackingField");
			GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "m_IsAction");
			GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "m_IsArrayCtor");
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665772);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665773);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665774);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665775);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665776);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665777);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665778);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_GenericMethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665779);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665780);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665781);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665782);
			GenericMethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, 100665783);
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0004D208 File Offset: 0x0004B408
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x0004D248 File Offset: 0x0004B448
		public unsafe MethodBase MethodInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0004D28C File Offset: 0x0004B48C
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35810, RefRangeEnd = 35812, XrefRangeStart = 35810, XrefRangeEnd = 35810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35812, RefRangeEnd = 35813, XrefRangeStart = 35812, XrefRangeEnd = 35812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0004D310 File Offset: 0x0004B510
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x0004D34C File Offset: 0x0004B54C
		public unsafe bool IsConstructor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35813, RefRangeEnd = 35814, XrefRangeStart = 35813, XrefRangeEnd = 35813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0004D38C File Offset: 0x0004B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35814, XrefRangeEnd = 35939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericMethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004D3EC File Offset: 0x0004B5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35946, RefRangeEnd = 35947, XrefRangeStart = 35939, XrefRangeEnd = 35946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GenericMethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_GenericMethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericMethodMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0004D450 File Offset: 0x0004B650
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35973, RefRangeEnd = 35976, XrefRangeStart = 35947, XrefRangeEnd = 35973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0004D4A0 File Offset: 0x0004B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35976, XrefRangeEnd = 36020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericMethodMemberDescriptor.NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0004D534 File Offset: 0x0004B734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36020, XrefRangeEnd = 36111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> BuildArgumentList(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericMethodMemberDescriptor.NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outParams = ((intPtr4 == 0) ? null : new List<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr5) : null;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0004D5EC File Offset: 0x0004B7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36111, XrefRangeEnd = 36183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000628C File Offset: 0x0000448C
		public GenericMethodMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0004D630 File Offset: 0x0004B830
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00006295 File Offset: 0x00004495
		public unsafe MethodBase _MethodInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__MethodInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0004D660 File Offset: 0x0004B860
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x000062B4 File Offset: 0x000044B4
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0004D690 File Offset: 0x0004B890
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x000062D3 File Offset: 0x000044D3
		public unsafe bool _IsConstructor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr__IsConstructor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x000062EE File Offset: 0x000044EE
		public unsafe bool m_IsAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsAction)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0004D6E0 File Offset: 0x0004B8E0
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00006309 File Offset: 0x00004509
		public unsafe bool m_IsArrayCtor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericMethodMemberDescriptor.NativeFieldInfoPtr_m_IsArrayCtor)) = value;
			}
		}

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr__MethodInfo_k__BackingField;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr__IsConstructor_k__BackingField;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAction;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_m_IsArrayCtor;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodInfo_Public_get_MethodBase_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_set_MethodInfo_Private_set_Void_MethodBase_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructor_Public_get_Boolean_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_set_IsConstructor_Private_set_Void_Boolean_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_InteropAccessMode_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_GenericMethodMemberDescriptor_MethodBase_InteropAccessMode_Boolean_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_CheckMethodIsCompatible_Public_Static_Boolean_MethodBase_Boolean_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;

		// Token: 0x020001C7 RID: 455
		[ObfuscatedName("MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001BB2 RID: 7090 RVA: 0x000875B4 File Offset: 0x000857B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericMethodMemberDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr);
				GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, "<>9");
				GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, "<>9__14_0");
				GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, "<>9__14_1");
				GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, "<>9__16_0");
				GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, 100665785);
				GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_ParameterDescriptor_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, 100665786);
				GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Boolean_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, 100665787);
				GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr__CheckMethodIsCompatible_b__16_0_Internal_Boolean_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr, 100665788);
			}

			// Token: 0x06001BB3 RID: 7091 RVA: 0x00087680 File Offset: 0x00085880
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericMethodMemberDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BB4 RID: 7092 RVA: 0x000876BC File Offset: 0x000858BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35802, XrefRangeEnd = 35806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterDescriptor __ctor_b__14_0(ParameterInfo pi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_ParameterDescriptor_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x06001BB5 RID: 7093 RVA: 0x0008770C File Offset: 0x0008590C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35806, XrefRangeEnd = 35808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__14_1(ParameterDescriptor p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Boolean_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BB6 RID: 7094 RVA: 0x0008775C File Offset: 0x0008595C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35808, XrefRangeEnd = 35810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckMethodIsCompatible_b__16_0(ParameterInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericMethodMemberDescriptor.__c.NativeMethodInfoPtr__CheckMethodIsCompatible_b__16_0_Internal_Boolean_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x0000AE28 File Offset: 0x00009028
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x000877AC File Offset: 0x000859AC
			// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0000AE31 File Offset: 0x00009031
			public unsafe static GenericMethodMemberDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericMethodMemberDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000877D4 File Offset: 0x000859D4
			// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0000AE43 File Offset: 0x00009043
			public unsafe static Func<ParameterInfo, ParameterDescriptor> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, ParameterDescriptor>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000877FC File Offset: 0x000859FC
			// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0000AE55 File Offset: 0x00009055
			public unsafe static Func<ParameterDescriptor, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterDescriptor, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00087824 File Offset: 0x00085A24
			// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0000AE67 File Offset: 0x00009067
			public unsafe static Func<ParameterInfo, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04001666 RID: 5734
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04001667 RID: 5735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001668 RID: 5736
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Internal_ParameterDescriptor_ParameterInfo_0;

			// Token: 0x04001669 RID: 5737
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Internal_Boolean_ParameterDescriptor_0;

			// Token: 0x0400166A RID: 5738
			private static readonly IntPtr NativeMethodInfoPtr__CheckMethodIsCompatible_b__16_0_Internal_Boolean_ParameterInfo_0;
		}
	}
}
