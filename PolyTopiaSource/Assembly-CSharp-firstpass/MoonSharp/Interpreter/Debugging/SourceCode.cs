using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FD RID: 253
	public class SourceCode : Object
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x00063134 File Offset: 0x00061334
		// Note: this type is marked as 'beforefieldinit'.
		static SourceCode()
		{
			Il2CppClassPointerStore<SourceCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "SourceCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceCode>.NativeClassPtr);
			SourceCode.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<Name>k__BackingField");
			SourceCode.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<Code>k__BackingField");
			SourceCode.NativeFieldInfoPtr__Lines_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<Lines>k__BackingField");
			SourceCode.NativeFieldInfoPtr__OwnerScript_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<OwnerScript>k__BackingField");
			SourceCode.NativeFieldInfoPtr__SourceID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<SourceID>k__BackingField");
			SourceCode.NativeFieldInfoPtr__Refs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, "<Refs>k__BackingField");
			SourceCode.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666630);
			SourceCode.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666631);
			SourceCode.NativeMethodInfoPtr_get_Code_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666632);
			SourceCode.NativeMethodInfoPtr_set_Code_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666633);
			SourceCode.NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666634);
			SourceCode.NativeMethodInfoPtr_set_Lines_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666635);
			SourceCode.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666636);
			SourceCode.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666637);
			SourceCode.NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666638);
			SourceCode.NativeMethodInfoPtr_set_SourceID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666639);
			SourceCode.NativeMethodInfoPtr_get_Refs_Internal_get_List_1_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666640);
			SourceCode.NativeMethodInfoPtr_set_Refs_Private_set_Void_List_1_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666641);
			SourceCode.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666642);
			SourceCode.NativeMethodInfoPtr_GetCodeSnippet_Public_String_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666643);
			SourceCode.NativeMethodInfoPtr_AdjustStrIndex_Private_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceCode>.NativeClassPtr, 100666644);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00063308 File Offset: 0x00061508
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00063340 File Offset: 0x00061540
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00063384 File Offset: 0x00061584
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x000633BC File Offset: 0x000615BC
		public unsafe string Code
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_Code_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_Code_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00063400 File Offset: 0x00061600
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00063440 File Offset: 0x00061640
		public unsafe Il2CppStringArray Lines
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_Lines_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x00063484 File Offset: 0x00061684
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x000634C4 File Offset: 0x000616C4
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00063508 File Offset: 0x00061708
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00063544 File Offset: 0x00061744
		public unsafe int SourceID
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_SourceID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00063584 File Offset: 0x00061784
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x000635C4 File Offset: 0x000617C4
		public unsafe List<SourceRef> Refs
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_get_Refs_Internal_get_List_1_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SourceRef>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_set_Refs_Private_set_Void_List_1_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00063608 File Offset: 0x00061808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46538, RefRangeEnd = 46540, XrefRangeStart = 46503, XrefRangeEnd = 46538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceCode(string name, string code, int sourceID, Script ownerScript)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceCode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerScript);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00063688 File Offset: 0x00061888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46540, XrefRangeEnd = 46560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCodeSnippet(SourceRef sourceCodeRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceCodeRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_GetCodeSnippet_Public_String_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000636D0 File Offset: 0x000618D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46560, XrefRangeEnd = 46566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AdjustStrIndex(string str, int loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceCode.NativeMethodInfoPtr_AdjustStrIndex_Private_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00007D0F File Offset: 0x00005F0F
		public SourceCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0006372C File Offset: 0x0006192C
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00007D18 File Offset: 0x00005F18
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00063754 File Offset: 0x00061954
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00007D37 File Offset: 0x00005F37
		public unsafe string _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Code_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Code_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0006377C File Offset: 0x0006197C
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00007D56 File Offset: 0x00005F56
		public unsafe Il2CppStringArray _Lines_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Lines_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Lines_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000637AC File Offset: 0x000619AC
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00007D75 File Offset: 0x00005F75
		public unsafe Script _OwnerScript_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__OwnerScript_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__OwnerScript_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000637DC File Offset: 0x000619DC
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00007D94 File Offset: 0x00005F94
		public unsafe int _SourceID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__SourceID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__SourceID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00063804 File Offset: 0x00061A04
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x00007DAF File Offset: 0x00005FAF
		public unsafe List<SourceRef> _Refs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Refs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SourceRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceCode.NativeFieldInfoPtr__Refs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeFieldInfoPtr__Lines_k__BackingField;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr__OwnerScript_k__BackingField;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr__SourceID_k__BackingField;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr__Refs_k__BackingField;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_String_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Private_set_Void_String_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_set_Lines_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceID_Private_set_Void_Int32_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_get_Refs_Internal_get_List_1_SourceRef_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_set_Refs_Private_set_Void_List_1_SourceRef_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Script_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_GetCodeSnippet_Public_String_SourceRef_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_AdjustStrIndex_Private_Int32_String_Int32_0;
	}
}
