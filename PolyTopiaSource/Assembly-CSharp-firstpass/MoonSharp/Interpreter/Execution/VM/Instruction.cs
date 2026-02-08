using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000EA RID: 234
	public class Instruction : Object
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x0005D228 File Offset: 0x0005B428
		// Note: this type is marked as 'beforefieldinit'.
		static Instruction()
		{
			Il2CppClassPointerStore<Instruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.VM", "Instruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Instruction>.NativeClassPtr);
			Instruction.NativeFieldInfoPtr_OpCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "OpCode");
			Instruction.NativeFieldInfoPtr_Symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "Symbol");
			Instruction.NativeFieldInfoPtr_SymbolList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "SymbolList");
			Instruction.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "Name");
			Instruction.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "Value");
			Instruction.NativeFieldInfoPtr_NumVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "NumVal");
			Instruction.NativeFieldInfoPtr_NumVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "NumVal2");
			Instruction.NativeFieldInfoPtr_SourceCodeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "SourceCodeRef");
			Instruction.NativeMethodInfoPtr__ctor_Internal_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666414);
			Instruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666415);
			Instruction.NativeMethodInfoPtr_PurifyFromNewLines_Private_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666416);
			Instruction.NativeMethodInfoPtr_GenSpaces_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666417);
			Instruction.NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_Int32_Dictionary_2_SymbolRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666418);
			Instruction.NativeMethodInfoPtr_WriteSymbol_Private_Static_Void_BinaryWriter_SymbolRef_Dictionary_2_SymbolRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666419);
			Instruction.NativeMethodInfoPtr_ReadSymbol_Private_Static_SymbolRef_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666420);
			Instruction.NativeMethodInfoPtr_ReadBinary_Internal_Static_Instruction_SourceRef_BinaryReader_Int32_Table_Il2CppReferenceArray_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666421);
			Instruction.NativeMethodInfoPtr_ReadValue_Private_Static_DynValue_BinaryReader_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666422);
			Instruction.NativeMethodInfoPtr_DumpValue_Private_Void_BinaryWriter_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666423);
			Instruction.NativeMethodInfoPtr_GetSymbolReferences_Internal_Void_byref_Il2CppReferenceArray_1_SymbolRef_byref_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100666424);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0005D3D4 File Offset: 0x0005B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43738, XrefRangeEnd = 43740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction(SourceRef sourceref)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Instruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr__ctor_Internal_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0005D420 File Offset: 0x0005B620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43740, XrefRangeEnd = 43803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0005D464 File Offset: 0x0005B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43803, XrefRangeEnd = 43807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PurifyFromNewLines(DynValue Value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_PurifyFromNewLines_Private_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0005D4AC File Offset: 0x0005B6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43807, XrefRangeEnd = 43811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_GenSpaces_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43829, RefRangeEnd = 43830, XrefRangeStart = 43811, XrefRangeEnd = 43829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, int> symbolMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseAddress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbolMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_Int32_Dictionary_2_SymbolRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0005D548 File Offset: 0x0005B748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43830, XrefRangeEnd = 43835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, int> symbolMap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbolRef);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbolMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_WriteSymbol_Private_Static_Void_BinaryWriter_SymbolRef_Dictionary_2_SymbolRef_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		[CallerCount(0)]
		public unsafe static SymbolRef ReadSymbol(BinaryReader rd, Il2CppReferenceArray<SymbolRef> deserializedSymbols)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deserializedSymbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_ReadSymbol_Private_Static_SymbolRef_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0005D5FC File Offset: 0x0005B7FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43855, RefRangeEnd = 43856, XrefRangeStart = 43835, XrefRangeEnd = 43855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, Il2CppReferenceArray<SymbolRef> deserializedSymbols)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunkRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseAddress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(envTable);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deserializedSymbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_ReadBinary_Internal_Static_Instruction_SourceRef_BinaryReader_Int32_Table_Il2CppReferenceArray_1_SymbolRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0005D688 File Offset: 0x0005B888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43875, RefRangeEnd = 43876, XrefRangeStart = 43856, XrefRangeEnd = 43875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ReadValue(BinaryReader rd, Table envTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(envTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_ReadValue_Private_Static_DynValue_BinaryReader_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43876, XrefRangeEnd = 43877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DumpValue(BinaryWriter wr, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_DumpValue_Private_Void_BinaryWriter_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0005D734 File Offset: 0x0005B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43877, XrefRangeEnd = 43882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSymbolReferences(out Il2CppReferenceArray<SymbolRef> symbolList, out SymbolRef symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_GetSymbolReferences_Internal_Void_byref_Il2CppReferenceArray_1_SymbolRef_byref_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			symbolList = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<SymbolRef>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			symbol = ((intPtr6 == 0) ? null : new SymbolRef(intPtr6));
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00007579 File Offset: 0x00005779
		public Instruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0005D7A8 File Offset: 0x0005B9A8
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00007582 File Offset: 0x00005782
		public unsafe OpCode OpCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_OpCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OpCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_OpCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0005D7D8 File Offset: 0x0005B9D8
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x000075A1 File Offset: 0x000057A1
		public unsafe SymbolRef Symbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Symbol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Symbol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0005D808 File Offset: 0x0005BA08
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x000075C0 File Offset: 0x000057C0
		public unsafe Il2CppReferenceArray<SymbolRef> SymbolList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_SymbolList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_SymbolList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0005D838 File Offset: 0x0005BA38
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x000075DF File Offset: 0x000057DF
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0005D860 File Offset: 0x0005BA60
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x000075FE File Offset: 0x000057FE
		public unsafe DynValue Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0005D890 File Offset: 0x0005BA90
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0000761D File Offset: 0x0000581D
		public unsafe int NumVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_NumVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_NumVal)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x00007638 File Offset: 0x00005838
		public unsafe int NumVal2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_NumVal2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_NumVal2)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0005D8E0 File Offset: 0x0005BAE0
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x00007653 File Offset: 0x00005853
		public unsafe SourceRef SourceCodeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_SourceCodeRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instruction.NativeFieldInfoPtr_SourceCodeRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeFieldInfoPtr_OpCode;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeFieldInfoPtr_Symbol;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_SymbolList;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_NumVal;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeFieldInfoPtr_NumVal2;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_SourceCodeRef;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SourceRef_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_PurifyFromNewLines_Private_String_DynValue_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_GenSpaces_Private_String_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_Int32_Dictionary_2_SymbolRef_Int32_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_WriteSymbol_Private_Static_Void_BinaryWriter_SymbolRef_Dictionary_2_SymbolRef_Int32_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_ReadSymbol_Private_Static_SymbolRef_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_ReadBinary_Internal_Static_Instruction_SourceRef_BinaryReader_Int32_Table_Il2CppReferenceArray_1_SymbolRef_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Private_Static_DynValue_BinaryReader_Table_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_DumpValue_Private_Void_BinaryWriter_DynValue_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_GetSymbolReferences_Internal_Void_byref_Il2CppReferenceArray_1_SymbolRef_byref_SymbolRef_0;

		// Token: 0x020001E0 RID: 480
		[ObfuscatedName("MoonSharp.Interpreter.Execution.VM.Instruction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001CE8 RID: 7400 RVA: 0x0008B08C File Offset: 0x0008928C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Instruction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr);
				Instruction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr, "<>9");
				Instruction.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr, "<>9__9_0");
				Instruction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr, 100666426);
				Instruction.__c.NativeMethodInfoPtr__ToString_b__9_0_Internal_String_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr, 100666427);
			}

			// Token: 0x06001CE9 RID: 7401 RVA: 0x0008B108 File Offset: 0x00089308
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Instruction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CEA RID: 7402 RVA: 0x0008B144 File Offset: 0x00089344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__9_0(SymbolRef s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.__c.NativeMethodInfoPtr__ToString_b__9_0_Internal_String_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001CEB RID: 7403 RVA: 0x0000B687 File Offset: 0x00009887
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001CEC RID: 7404 RVA: 0x0008B18C File Offset: 0x0008938C
			// (set) Token: 0x06001CED RID: 7405 RVA: 0x0000B690 File Offset: 0x00009890
			public unsafe static Instruction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Instruction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Instruction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06001CEE RID: 7406 RVA: 0x0008B1B4 File Offset: 0x000893B4
			// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0000B6A2 File Offset: 0x000098A2
			public unsafe static Func<SymbolRef, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Instruction.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SymbolRef, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Instruction.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__9_0_Internal_String_SymbolRef_0;
		}
	}
}
