using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class InterpreterException : Exception
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00032FA8 File Offset: 0x000311A8
		// Note: this type is marked as 'beforefieldinit'.
		static InterpreterException()
		{
			Il2CppClassPointerStore<InterpreterException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "InterpreterException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr);
			InterpreterException.NativeFieldInfoPtr__InstructionPtr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, "<InstructionPtr>k__BackingField");
			InterpreterException.NativeFieldInfoPtr__CallStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, "<CallStack>k__BackingField");
			InterpreterException.NativeFieldInfoPtr__DecoratedMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, "<DecoratedMessage>k__BackingField");
			InterpreterException.NativeFieldInfoPtr__DoNotDecorateMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, "<DoNotDecorateMessage>k__BackingField");
			InterpreterException.NativeMethodInfoPtr_get_InstructionPtr_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664765);
			InterpreterException.NativeMethodInfoPtr_set_InstructionPtr_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664766);
			InterpreterException.NativeMethodInfoPtr_get_CallStack_Public_get_IList_1_WatchItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664767);
			InterpreterException.NativeMethodInfoPtr_set_CallStack_Internal_set_Void_IList_1_WatchItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664768);
			InterpreterException.NativeMethodInfoPtr_get_DecoratedMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664769);
			InterpreterException.NativeMethodInfoPtr_set_DecoratedMessage_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664770);
			InterpreterException.NativeMethodInfoPtr_get_DoNotDecorateMessage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664771);
			InterpreterException.NativeMethodInfoPtr_set_DoNotDecorateMessage_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664772);
			InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664761);
			InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664762);
			InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664763);
			InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664764);
			InterpreterException.NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_SourceRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664773);
			InterpreterException.NativeMethodInfoPtr_Rethrow_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr, 100664774);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00033140 File Offset: 0x00031340
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0003317C File Offset: 0x0003137C
		public unsafe int InstructionPtr
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 24691, RefRangeEnd = 24697, XrefRangeStart = 24691, XrefRangeEnd = 24691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_get_InstructionPtr_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_set_InstructionPtr_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000331BC File Offset: 0x000313BC
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000331FC File Offset: 0x000313FC
		public unsafe IList<WatchItem> CallStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_get_CallStack_Public_get_IList_1_WatchItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<WatchItem>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_set_CallStack_Internal_set_Void_IList_1_WatchItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00033240 File Offset: 0x00031440
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00033278 File Offset: 0x00031478
		public unsafe string DecoratedMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_get_DecoratedMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_set_DecoratedMessage_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000332BC File Offset: 0x000314BC
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000332F8 File Offset: 0x000314F8
		public unsafe bool DoNotDecorateMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_get_DoNotDecorateMessage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24697, RefRangeEnd = 24698, XrefRangeStart = 24697, XrefRangeEnd = 24697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_set_DoNotDecorateMessage_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00033338 File Offset: 0x00031538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24698, XrefRangeEnd = 24702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpreterException(Exception ex, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00033398 File Offset: 0x00031598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24702, XrefRangeEnd = 24707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpreterException(Exception ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000333E4 File Offset: 0x000315E4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 24653, RefRangeEnd = 24672, XrefRangeStart = 24653, XrefRangeEnd = 24672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpreterException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00033430 File Offset: 0x00031630
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 24716, RefRangeEnd = 24762, XrefRangeStart = 24707, XrefRangeEnd = 24716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpreterException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpreterException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003349C File Offset: 0x0003169C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24775, RefRangeEnd = 24780, XrefRangeStart = 24762, XrefRangeEnd = 24775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecorateMessage(Script script, SourceRef sref, int ip = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sref);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpreterException.NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_SourceRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00033500 File Offset: 0x00031700
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InterpreterException.NativeMethodInfoPtr_Rethrow_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00003ED7 File Offset: 0x000020D7
		public InterpreterException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00003EE6 File Offset: 0x000020E6
		public InterpreterException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0003353C File Offset: 0x0003173C
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00003EEF File Offset: 0x000020EF
		public unsafe int _InstructionPtr_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__InstructionPtr_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__InstructionPtr_k__BackingField)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00033564 File Offset: 0x00031764
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00003F0A File Offset: 0x0000210A
		public unsafe IList<WatchItem> _CallStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__CallStack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<WatchItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__CallStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00033594 File Offset: 0x00031794
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00003F29 File Offset: 0x00002129
		public unsafe string _DecoratedMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__DecoratedMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__DecoratedMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000335BC File Offset: 0x000317BC
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00003F48 File Offset: 0x00002148
		public unsafe bool _DoNotDecorateMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__DoNotDecorateMessage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpreterException.NativeFieldInfoPtr__DoNotDecorateMessage_k__BackingField)) = value;
			}
		}

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr__InstructionPtr_k__BackingField;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr__CallStack_k__BackingField;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr__DecoratedMessage_k__BackingField;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr__DoNotDecorateMessage_k__BackingField;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionPtr_Public_get_Int32_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_set_InstructionPtr_Internal_set_Void_Int32_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_get_CallStack_Public_get_IList_1_WatchItem_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_set_CallStack_Internal_set_Void_IList_1_WatchItem_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_get_DecoratedMessage_Public_get_String_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_set_DecoratedMessage_Internal_set_Void_String_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotDecorateMessage_Public_get_Boolean_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_set_DoNotDecorateMessage_Public_set_Void_Boolean_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Exception_String_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Exception_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_DecorateMessage_Internal_Void_Script_SourceRef_Int32_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_Rethrow_Public_Virtual_New_Void_0;
	}
}
