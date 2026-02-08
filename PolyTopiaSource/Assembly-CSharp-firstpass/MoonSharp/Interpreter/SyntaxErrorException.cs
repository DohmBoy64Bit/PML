using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class SyntaxErrorException : InterpreterException
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x000351B8 File Offset: 0x000333B8
		// Note: this type is marked as 'beforefieldinit'.
		static SyntaxErrorException()
		{
			Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "SyntaxErrorException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr);
			SyntaxErrorException.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, "<Token>k__BackingField");
			SyntaxErrorException.NativeFieldInfoPtr__IsPrematureStreamTermination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, "<IsPrematureStreamTermination>k__BackingField");
			SyntaxErrorException.NativeMethodInfoPtr_get_Token_Internal_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664846);
			SyntaxErrorException.NativeMethodInfoPtr_set_Token_Private_set_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664847);
			SyntaxErrorException.NativeMethodInfoPtr_get_IsPrematureStreamTermination_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664848);
			SyntaxErrorException.NativeMethodInfoPtr_set_IsPrematureStreamTermination_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664849);
			SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Token_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664850);
			SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664851);
			SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664852);
			SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664853);
			SyntaxErrorException.NativeMethodInfoPtr__ctor_Private_Void_SyntaxErrorException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664854);
			SyntaxErrorException.NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664855);
			SyntaxErrorException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr, 100664856);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000352EC File Offset: 0x000334EC
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0003532C File Offset: 0x0003352C
		public unsafe Token Token
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr_get_Token_Internal_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr_set_Token_Private_set_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00035370 File Offset: 0x00033570
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000353AC File Offset: 0x000335AC
		public unsafe bool IsPrematureStreamTermination
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 25668, RefRangeEnd = 25669, XrefRangeStart = 25668, XrefRangeEnd = 25668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr_get_IsPrematureStreamTermination_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 25669, RefRangeEnd = 25673, XrefRangeStart = 25669, XrefRangeEnd = 25669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr_set_IsPrematureStreamTermination_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000353EC File Offset: 0x000335EC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 25675, RefRangeEnd = 25685, XrefRangeStart = 25673, XrefRangeEnd = 25675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxErrorException(Token t, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Token_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00035468 File Offset: 0x00033668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25690, RefRangeEnd = 25691, XrefRangeStart = 25685, XrefRangeEnd = 25690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxErrorException(Token t, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Token_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000354C8 File Offset: 0x000336C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25691, XrefRangeEnd = 25693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxErrorException(Script script, SourceRef sref, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sref);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00035558 File Offset: 0x00033758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25693, XrefRangeEnd = 25698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxErrorException(Script script, SourceRef sref, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sref);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000355C8 File Offset: 0x000337C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25698, XrefRangeEnd = 25705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxErrorException(SyntaxErrorException syntaxErrorException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxErrorException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntaxErrorException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr__ctor_Private_Void_SyntaxErrorException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00035614 File Offset: 0x00033814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25705, XrefRangeEnd = 25707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecorateMessage(Script script)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxErrorException.NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00035658 File Offset: 0x00033858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25707, XrefRangeEnd = 25714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Rethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxErrorException.NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00003FD5 File Offset: 0x000021D5
		public SyntaxErrorException(Token t, string format, params Object[] args)
			: this(t, format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00003FE5 File Offset: 0x000021E5
		public SyntaxErrorException(Script script, SourceRef sref, string format, params Object[] args)
			: this(script, sref, format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00003FF7 File Offset: 0x000021F7
		public SyntaxErrorException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00035694 File Offset: 0x00033894
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004000 File Offset: 0x00002200
		public unsafe Token _Token_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyntaxErrorException.NativeFieldInfoPtr__Token_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Token>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyntaxErrorException.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000356C4 File Offset: 0x000338C4
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x0000401F File Offset: 0x0000221F
		public unsafe bool _IsPrematureStreamTermination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyntaxErrorException.NativeFieldInfoPtr__IsPrematureStreamTermination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyntaxErrorException.NativeFieldInfoPtr__IsPrematureStreamTermination_k__BackingField)) = value;
			}
		}

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr__Token_k__BackingField;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__IsPrematureStreamTermination_k__BackingField;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_Token_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Private_set_Void_Token_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrematureStreamTermination_Public_get_Boolean_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPrematureStreamTermination_Public_set_Void_Boolean_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_String_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_SourceRef_String_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SyntaxErrorException_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_Rethrow_Public_Virtual_Void_0;
	}
}
