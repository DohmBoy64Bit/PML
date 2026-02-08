using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors
{
	// Token: 0x020000C0 RID: 192
	public class EventFacade : Object
	{
		// Token: 0x06000F03 RID: 3843 RVA: 0x00051EFC File Offset: 0x000500FC
		// Note: this type is marked as 'beforefieldinit'.
		static EventFacade()
		{
			Il2CppClassPointerStore<EventFacade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.StandardDescriptors", "EventFacade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventFacade>.NativeClassPtr);
			EventFacade.NativeFieldInfoPtr_m_AddCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, "m_AddCallback");
			EventFacade.NativeFieldInfoPtr_m_RemoveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, "m_RemoveCallback");
			EventFacade.NativeFieldInfoPtr_m_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, "m_Object");
			EventFacade.NativeMethodInfoPtr__ctor_Public_Void_EventMemberDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666005);
			EventFacade.NativeMethodInfoPtr__ctor_Public_Void_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666006);
			EventFacade.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666007);
			EventFacade.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666008);
			EventFacade.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666009);
			EventFacade.NativeMethodInfoPtr__Index_b__5_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666010);
			EventFacade.NativeMethodInfoPtr__Index_b__5_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFacade>.NativeClassPtr, 100666011);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00051FF4 File Offset: 0x000501F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39548, XrefRangeEnd = 39563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventFacade(EventMemberDescriptor parent, Object obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventFacade>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr__ctor_Public_Void_EventMemberDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00052054 File Offset: 0x00050254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39563, XrefRangeEnd = 39567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventFacade(Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, Object obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventFacade>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removeCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr__ctor_Public_Void_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000520C4 File Offset: 0x000502C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39567, XrefRangeEnd = 39597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00052134 File Offset: 0x00050334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39597, XrefRangeEnd = 39603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000521B4 File Offset: 0x000503B4
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue MetaIndex(Script script, string metaname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metaname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00052218 File Offset: 0x00050418
		[CallerCount(0)]
		public unsafe DynValue _Index_b__5_0(ScriptExecutionContext c, CallbackArguments a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr__Index_b__5_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0005227C File Offset: 0x0005047C
		[CallerCount(0)]
		public unsafe DynValue _Index_b__5_1(ScriptExecutionContext c, CallbackArguments a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFacade.NativeMethodInfoPtr__Index_b__5_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000068C1 File Offset: 0x00004AC1
		public EventFacade(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000522E0 File Offset: 0x000504E0
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000068CA File Offset: 0x00004ACA
		public unsafe Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_AddCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_AddCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00052310 File Offset: 0x00050510
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000068E9 File Offset: 0x00004AE9
		public unsafe Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_RemoveCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_RemoveCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00052340 File Offset: 0x00050540
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00006908 File Offset: 0x00004B08
		public unsafe Object m_Object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_Object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFacade.NativeFieldInfoPtr_m_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_m_AddCallback;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveCallback;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_m_Object;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventMemberDescriptor_Object_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Func_4_Object_ScriptExecutionContext_CallbackArguments_DynValue_Object_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr__Index_b__5_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr__Index_b__5_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
