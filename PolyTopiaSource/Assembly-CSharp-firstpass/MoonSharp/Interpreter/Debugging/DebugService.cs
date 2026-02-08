using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FB RID: 251
	public sealed class DebugService : Object
	{
		// Token: 0x060012F6 RID: 4854 RVA: 0x00062A60 File Offset: 0x00060C60
		// Note: this type is marked as 'beforefieldinit'.
		static DebugService()
		{
			Il2CppClassPointerStore<DebugService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "DebugService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugService>.NativeClassPtr);
			DebugService.NativeFieldInfoPtr_m_Processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugService>.NativeClassPtr, "m_Processor");
			DebugService.NativeFieldInfoPtr__OwnerScript_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugService>.NativeClassPtr, "<OwnerScript>k__BackingField");
			DebugService.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugService>.NativeClassPtr, 100666616);
			DebugService.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugService>.NativeClassPtr, 100666617);
			DebugService.NativeMethodInfoPtr__ctor_Internal_Void_Script_Processor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugService>.NativeClassPtr, 100666615);
			DebugService.NativeMethodInfoPtr_ResetBreakPoints_Public_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugService>.NativeClassPtr, 100666618);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00062B08 File Offset: 0x00060D08
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00062B48 File Offset: 0x00060D48
		public unsafe Script OwnerScript
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugService.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugService.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00062B8C File Offset: 0x00060D8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46498, RefRangeEnd = 46501, XrefRangeStart = 46495, XrefRangeEnd = 46498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugService(Script script, Processor processor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugService.NativeMethodInfoPtr__ctor_Internal_Void_Script_Processor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00062BEC File Offset: 0x00060DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46501, XrefRangeEnd = 46503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lines);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugService.NativeMethodInfoPtr_ResetBreakPoints_Public_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00007CBF File Offset: 0x00005EBF
		public DebugService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00062C50 File Offset: 0x00060E50
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public unsafe Processor m_Processor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugService.NativeFieldInfoPtr_m_Processor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugService.NativeFieldInfoPtr_m_Processor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00062C80 File Offset: 0x00060E80
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00007CE7 File Offset: 0x00005EE7
		public unsafe Script _OwnerScript_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugService.NativeFieldInfoPtr__OwnerScript_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugService.NativeFieldInfoPtr__OwnerScript_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_m_Processor;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr__OwnerScript_k__BackingField;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_Processor_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_ResetBreakPoints_Public_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0;
	}
}
