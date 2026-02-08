using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AD RID: 173
	public class ArrayMemberDescriptor : ObjectCallbackMemberDescriptor
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x00049FD0 File Offset: 0x000481D0
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayMemberDescriptor()
		{
			Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "ArrayMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr);
			ArrayMemberDescriptor.NativeFieldInfoPtr_m_IsSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, "m_IsSetter");
			ArrayMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665580);
			ArrayMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665581);
			ArrayMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665582);
			ArrayMemberDescriptor.NativeMethodInfoPtr_BuildArrayIndices_Private_Static_Il2CppStructArray_1_Int32_CallbackArguments_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665583);
			ArrayMemberDescriptor.NativeMethodInfoPtr_ArrayIndexerSet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665584);
			ArrayMemberDescriptor.NativeMethodInfoPtr_ArrayIndexerGet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr, 100665585);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0004A08C File Offset: 0x0004828C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33893, XrefRangeEnd = 33904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayMemberDescriptor(string name, bool isSetter, Il2CppReferenceArray<ParameterDescriptor> indexerParams)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSetter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexerParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0004A0F8 File Offset: 0x000482F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33918, RefRangeEnd = 33919, XrefRangeStart = 33904, XrefRangeEnd = 33918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayMemberDescriptor(string name, bool isSetter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSetter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0004A154 File Offset: 0x00048354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33919, XrefRangeEnd = 33949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0004A198 File Offset: 0x00048398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33955, RefRangeEnd = 33957, XrefRangeStart = 33949, XrefRangeEnd = 33955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> BuildArrayIndices(CallbackArguments args, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr_BuildArrayIndices_Private_Static_Il2CppStructArray_1_Int32_CallbackArguments_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0004A1EC File Offset: 0x000483EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33957, XrefRangeEnd = 33970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ArrayIndexerSet(Object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr_ArrayIndexerSet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0004A254 File Offset: 0x00048454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33970, XrefRangeEnd = 33975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ArrayIndexerGet(Object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMemberDescriptor.NativeMethodInfoPtr_ArrayIndexerGet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00005EB5 File Offset: 0x000040B5
		public ArrayMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0004A2BC File Offset: 0x000484BC
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00005EBE File Offset: 0x000040BE
		public unsafe bool m_IsSetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMemberDescriptor.NativeFieldInfoPtr_m_IsSetter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMemberDescriptor.NativeFieldInfoPtr_m_IsSetter)) = value;
			}
		}

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSetter;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_BuildArrayIndices_Private_Static_Il2CppStructArray_1_Int32_CallbackArguments_Int32_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_ArrayIndexerSet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_ArrayIndexerGet_Private_Static_Object_Object_ScriptExecutionContext_CallbackArguments_0;
	}
}
