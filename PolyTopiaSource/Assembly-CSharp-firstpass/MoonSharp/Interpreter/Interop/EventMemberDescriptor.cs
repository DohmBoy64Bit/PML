using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B2 RID: 178
	public class EventMemberDescriptor : Object
	{
		// Token: 0x06000D9B RID: 3483 RVA: 0x0004BD4C File Offset: 0x00049F4C
		// Note: this type is marked as 'beforefieldinit'.
		static EventMemberDescriptor()
		{
			Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "EventMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr);
			EventMemberDescriptor.NativeFieldInfoPtr_MAX_ARGS_IN_DELEGATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "MAX_ARGS_IN_DELEGATE");
			EventMemberDescriptor.NativeFieldInfoPtr_m_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "m_Lock");
			EventMemberDescriptor.NativeFieldInfoPtr_m_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "m_Callbacks");
			EventMemberDescriptor.NativeFieldInfoPtr_m_Delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "m_Delegates");
			EventMemberDescriptor.NativeFieldInfoPtr__EventInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "<EventInfo>k__BackingField");
			EventMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "<IsStatic>k__BackingField");
			EventMemberDescriptor.NativeFieldInfoPtr_m_Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "m_Add");
			EventMemberDescriptor.NativeFieldInfoPtr_m_Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "m_Remove");
			EventMemberDescriptor.NativeMethodInfoPtr_get_EventInfo_Public_get_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665650);
			EventMemberDescriptor.NativeMethodInfoPtr_set_EventInfo_Private_set_Void_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665651);
			EventMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665652);
			EventMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665653);
			EventMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665661);
			EventMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665662);
			EventMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_EventInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665649);
			EventMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_EventMemberDescriptor_EventInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665647);
			EventMemberDescriptor.NativeMethodInfoPtr_CheckEventIsCompatible_Public_Static_Boolean_EventInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665648);
			EventMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665654);
			EventMemberDescriptor.NativeMethodInfoPtr_AddCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665655);
			EventMemberDescriptor.NativeMethodInfoPtr_RemoveCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665656);
			EventMemberDescriptor.NativeMethodInfoPtr_RegisterCallback_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665657);
			EventMemberDescriptor.NativeMethodInfoPtr_UnregisterCallback_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665658);
			EventMemberDescriptor.NativeMethodInfoPtr_CreateDelegate_Private_Delegate_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665659);
			EventMemberDescriptor.NativeMethodInfoPtr_DispatchEvent_Private_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665660);
			EventMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, 100665663);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0004BF70 File Offset: 0x0004A170
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x0004BFB0 File Offset: 0x0004A1B0
		public unsafe EventInfo EventInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_get_EventInfo_Public_get_EventInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_set_EventInfo_Private_set_Void_EventInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0004BFF4 File Offset: 0x0004A1F4
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x0004C030 File Offset: 0x0004A230
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0004C070 File Offset: 0x0004A270
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0004C0A8 File Offset: 0x0004A2A8
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0004C0E8 File Offset: 0x0004A2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35305, RefRangeEnd = 35306, XrefRangeStart = 35262, XrefRangeEnd = 35305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventMemberDescriptor(EventInfo ei, InteropAccessMode accessMode = InteropAccessMode.Default)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_EventInfo_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0004C148 File Offset: 0x0004A348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35330, RefRangeEnd = 35331, XrefRangeStart = 35306, XrefRangeEnd = 35330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventMemberDescriptor TryCreateIfVisible(EventInfo ei, InteropAccessMode accessMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_EventMemberDescriptor_EventInfo_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35374, RefRangeEnd = 35376, XrefRangeStart = 35331, XrefRangeEnd = 35374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckEventIsCompatible(EventInfo ei, bool throwException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ei);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_CheckEventIsCompatible_Public_Static_Boolean_EventInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0004C1F0 File Offset: 0x0004A3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35376, XrefRangeEnd = 35399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue GetValue(Script script, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0004C254 File Offset: 0x0004A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35399, XrefRangeEnd = 35433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue AddCallback(Object o, ScriptExecutionContext context, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_AddCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0004C2C8 File Offset: 0x0004A4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35433, XrefRangeEnd = 35464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RemoveCallback(Object o, ScriptExecutionContext context, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_RemoveCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0004C33C File Offset: 0x0004A53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35464, XrefRangeEnd = 35480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_RegisterCallback_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0004C380 File Offset: 0x0004A580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35480, XrefRangeEnd = 35502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallback(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_UnregisterCallback_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35572, RefRangeEnd = 35573, XrefRangeStart = 35502, XrefRangeEnd = 35572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delegate CreateDelegate(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_CreateDelegate_Private_Delegate_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0004C414 File Offset: 0x0004A614
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 35620, RefRangeEnd = 35637, XrefRangeStart = 35573, XrefRangeEnd = 35620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchEvent(Object sender, Object o01 = null, Object o02 = null, Object o03 = null, Object o04 = null, Object o05 = null, Object o06 = null, Object o07 = null, Object o08 = null, Object o09 = null, Object o10 = null, Object o11 = null, Object o12 = null, Object o13 = null, Object o14 = null, Object o15 = null, Object o16 = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o01);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o02);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o03);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o04);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o05);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o06);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o07);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o08);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o09);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o16);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_DispatchEvent_Private_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0004C590 File Offset: 0x0004A790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Script script, Object obj, DynValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000060AB File Offset: 0x000042AB
		public EventMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0004C5F8 File Offset: 0x0004A7F8
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x000060B4 File Offset: 0x000042B4
		public unsafe static int MAX_ARGS_IN_DELEGATE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EventMemberDescriptor.NativeFieldInfoPtr_MAX_ARGS_IN_DELEGATE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventMemberDescriptor.NativeFieldInfoPtr_MAX_ARGS_IN_DELEGATE, (void*)(&value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0004C614 File Offset: 0x0004A814
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x000060C2 File Offset: 0x000042C2
		public unsafe Object m_Lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0004C644 File Offset: 0x0004A844
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x000060E1 File Offset: 0x000042E1
		public unsafe MultiDictionary<Object, Closure> m_Callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiDictionary<Object, Closure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0004C674 File Offset: 0x0004A874
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00006100 File Offset: 0x00004300
		public unsafe Dictionary<Object, Delegate> m_Delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0004C6A4 File Offset: 0x0004A8A4
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe EventInfo _EventInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr__EventInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr__EventInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0004C6D4 File Offset: 0x0004A8D4
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0000613E File Offset: 0x0000433E
		public unsafe bool _IsStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0004C6FC File Offset: 0x0004A8FC
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00006159 File Offset: 0x00004359
		public unsafe MethodInfo m_Add
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Add);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Add), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0004C72C File Offset: 0x0004A92C
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00006178 File Offset: 0x00004378
		public unsafe MethodInfo m_Remove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Remove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.NativeFieldInfoPtr_m_Remove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ARGS_IN_DELEGATE;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_m_Lock;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_m_Callbacks;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_m_Delegates;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr__EventInfo_k__BackingField;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr__IsStatic_k__BackingField;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_m_Add;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_m_Remove;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_get_EventInfo_Public_get_EventInfo_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_set_EventInfo_Private_set_Void_EventInfo_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventInfo_InteropAccessMode_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_EventMemberDescriptor_EventInfo_InteropAccessMode_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_CheckEventIsCompatible_Public_Static_Boolean_EventInfo_Boolean_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_AddCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCallback_Internal_DynValue_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Private_Void_Object_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Private_Void_Object_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Delegate_Object_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Private_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0;

		// Token: 0x020001B4 RID: 436
		public sealed class EventWrapper00 : MulticastDelegate
		{
			// Token: 0x06001B11 RID: 6929 RVA: 0x0008340C File Offset: 0x0008160C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper00()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper00");
				EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr, 100665664);
				EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr, 100665665);
				EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr, 100665666);
				EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr, 100665667);
			}

			// Token: 0x06001B12 RID: 6930 RVA: 0x00083480 File Offset: 0x00081680
			[CallerCount(247)]
			[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14625, XrefRangeEnd = 14872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper00(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper00>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B13 RID: 6931 RVA: 0x000834DC File Offset: 0x000816DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B14 RID: 6932 RVA: 0x00083510 File Offset: 0x00081710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B15 RID: 6933 RVA: 0x00083574 File Offset: 0x00081774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper00.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B16 RID: 6934 RVA: 0x0000ABA2 File Offset: 0x00008DA2
			public EventWrapper00(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B17 RID: 6935 RVA: 0x0000ABAB File Offset: 0x00008DAB
			public static implicit operator EventMemberDescriptor.EventWrapper00(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper00>(A_0);
			}

			// Token: 0x06001B18 RID: 6936 RVA: 0x0000ABB3 File Offset: 0x00008DB3
			public static EventMemberDescriptor.EventWrapper00 operator +(EventMemberDescriptor.EventWrapper00 A_0, EventMemberDescriptor.EventWrapper00 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper00>();
			}

			// Token: 0x06001B19 RID: 6937 RVA: 0x0000ABC1 File Offset: 0x00008DC1
			public static EventMemberDescriptor.EventWrapper00 operator -(EventMemberDescriptor.EventWrapper00 A_0, EventMemberDescriptor.EventWrapper00 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper00>();
				}
				return delegate2;
			}

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001B5 RID: 437
		public sealed class EventWrapper01 : MulticastDelegate
		{
			// Token: 0x06001B1A RID: 6938 RVA: 0x000835B8 File Offset: 0x000817B8
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper01()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper01");
				EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr, 100665668);
				EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr, 100665669);
				EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr, 100665670);
				EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr, 100665671);
			}

			// Token: 0x06001B1B RID: 6939 RVA: 0x0008362C File Offset: 0x0008182C
			[CallerCount(530)]
			[CachedScanResults(RefRangeStart = 34422, RefRangeEnd = 34952, XrefRangeStart = 34412, XrefRangeEnd = 34422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper01(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper01>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1C RID: 6940 RVA: 0x00083688 File Offset: 0x00081888
			[CallerCount(0)]
			public unsafe void Invoke(Object o1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1D RID: 6941 RVA: 0x000836CC File Offset: 0x000818CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B1E RID: 6942 RVA: 0x00083740 File Offset: 0x00081940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper01.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1F RID: 6943 RVA: 0x0000ABD2 File Offset: 0x00008DD2
			public EventWrapper01(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B20 RID: 6944 RVA: 0x0000ABDB File Offset: 0x00008DDB
			public static implicit operator EventMemberDescriptor.EventWrapper01(Action<Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper01>(A_0);
			}

			// Token: 0x06001B21 RID: 6945 RVA: 0x0000ABE3 File Offset: 0x00008DE3
			public static EventMemberDescriptor.EventWrapper01 operator +(EventMemberDescriptor.EventWrapper01 A_0, EventMemberDescriptor.EventWrapper01 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper01>();
			}

			// Token: 0x06001B22 RID: 6946 RVA: 0x0000ABF1 File Offset: 0x00008DF1
			public static EventMemberDescriptor.EventWrapper01 operator -(EventMemberDescriptor.EventWrapper01 A_0, EventMemberDescriptor.EventWrapper01 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper01>();
				}
				return delegate2;
			}

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001B6 RID: 438
		public sealed class EventWrapper02 : MulticastDelegate
		{
			// Token: 0x06001B23 RID: 6947 RVA: 0x00083784 File Offset: 0x00081984
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper02()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper02");
				EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr, 100665672);
				EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr, 100665673);
				EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr, 100665674);
				EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr, 100665675);
			}

			// Token: 0x06001B24 RID: 6948 RVA: 0x000837F8 File Offset: 0x000819F8
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 34962, RefRangeEnd = 35067, XrefRangeStart = 34952, XrefRangeEnd = 34962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper02(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper02>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B25 RID: 6949 RVA: 0x00083854 File Offset: 0x00081A54
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B26 RID: 6950 RVA: 0x000838A8 File Offset: 0x00081AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35067, XrefRangeEnd = 35068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B27 RID: 6951 RVA: 0x00083930 File Offset: 0x00081B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper02.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x0000AC02 File Offset: 0x00008E02
			public EventWrapper02(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x0000AC0B File Offset: 0x00008E0B
			public static implicit operator EventMemberDescriptor.EventWrapper02(Action<Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper02>(A_0);
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x0000AC13 File Offset: 0x00008E13
			public static EventMemberDescriptor.EventWrapper02 operator +(EventMemberDescriptor.EventWrapper02 A_0, EventMemberDescriptor.EventWrapper02 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper02>();
			}

			// Token: 0x06001B2B RID: 6955 RVA: 0x0000AC21 File Offset: 0x00008E21
			public static EventMemberDescriptor.EventWrapper02 operator -(EventMemberDescriptor.EventWrapper02 A_0, EventMemberDescriptor.EventWrapper02 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper02>();
				}
				return delegate2;
			}

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001B7 RID: 439
		public sealed class EventWrapper03 : MulticastDelegate
		{
			// Token: 0x06001B2C RID: 6956 RVA: 0x00083974 File Offset: 0x00081B74
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper03()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper03");
				EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr, 100665676);
				EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr, 100665677);
				EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr, 100665678);
				EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr, 100665679);
			}

			// Token: 0x06001B2D RID: 6957 RVA: 0x000839E8 File Offset: 0x00081BE8
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 35078, RefRangeEnd = 35092, XrefRangeStart = 35068, XrefRangeEnd = 35078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper03(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper03>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2E RID: 6958 RVA: 0x00083A44 File Offset: 0x00081C44
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2F RID: 6959 RVA: 0x00083AAC File Offset: 0x00081CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35092, XrefRangeEnd = 35093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B30 RID: 6960 RVA: 0x00083B48 File Offset: 0x00081D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper03.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B31 RID: 6961 RVA: 0x0000AC32 File Offset: 0x00008E32
			public EventWrapper03(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B32 RID: 6962 RVA: 0x0000AC3B File Offset: 0x00008E3B
			public static implicit operator EventMemberDescriptor.EventWrapper03(Action<Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper03>(A_0);
			}

			// Token: 0x06001B33 RID: 6963 RVA: 0x0000AC43 File Offset: 0x00008E43
			public static EventMemberDescriptor.EventWrapper03 operator +(EventMemberDescriptor.EventWrapper03 A_0, EventMemberDescriptor.EventWrapper03 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper03>();
			}

			// Token: 0x06001B34 RID: 6964 RVA: 0x0000AC51 File Offset: 0x00008E51
			public static EventMemberDescriptor.EventWrapper03 operator -(EventMemberDescriptor.EventWrapper03 A_0, EventMemberDescriptor.EventWrapper03 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper03>();
				}
				return delegate2;
			}

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_0;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001B8 RID: 440
		public sealed class EventWrapper04 : MulticastDelegate
		{
			// Token: 0x06001B35 RID: 6965 RVA: 0x00083B8C File Offset: 0x00081D8C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper04()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper04");
				EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr, 100665680);
				EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr, 100665681);
				EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr, 100665682);
				EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr, 100665683);
			}

			// Token: 0x06001B36 RID: 6966 RVA: 0x00083C00 File Offset: 0x00081E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35093, XrefRangeEnd = 35103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper04(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper04>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B37 RID: 6967 RVA: 0x00083C5C File Offset: 0x00081E5C
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B38 RID: 6968 RVA: 0x00083CD8 File Offset: 0x00081ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35103, XrefRangeEnd = 35104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B39 RID: 6969 RVA: 0x00083D88 File Offset: 0x00081F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper04.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B3A RID: 6970 RVA: 0x0000AC62 File Offset: 0x00008E62
			public EventWrapper04(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B3B RID: 6971 RVA: 0x0000AC6B File Offset: 0x00008E6B
			public static implicit operator EventMemberDescriptor.EventWrapper04(Action<Object, Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper04>(A_0);
			}

			// Token: 0x06001B3C RID: 6972 RVA: 0x0000AC73 File Offset: 0x00008E73
			public static EventMemberDescriptor.EventWrapper04 operator +(EventMemberDescriptor.EventWrapper04 A_0, EventMemberDescriptor.EventWrapper04 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper04>();
			}

			// Token: 0x06001B3D RID: 6973 RVA: 0x0000AC81 File Offset: 0x00008E81
			public static EventMemberDescriptor.EventWrapper04 operator -(EventMemberDescriptor.EventWrapper04 A_0, EventMemberDescriptor.EventWrapper04 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper04>();
				}
				return delegate2;
			}

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_0;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001B9 RID: 441
		public sealed class EventWrapper05 : MulticastDelegate
		{
			// Token: 0x06001B3E RID: 6974 RVA: 0x00083DCC File Offset: 0x00081FCC
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper05()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper05");
				EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr, 100665684);
				EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr, 100665685);
				EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr, 100665686);
				EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr, 100665687);
			}

			// Token: 0x06001B3F RID: 6975 RVA: 0x00083E40 File Offset: 0x00082040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35104, XrefRangeEnd = 35114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper05(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper05>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B40 RID: 6976 RVA: 0x00083E9C File Offset: 0x0008209C
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B41 RID: 6977 RVA: 0x00083F28 File Offset: 0x00082128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35114, XrefRangeEnd = 35115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x00083FE8 File Offset: 0x000821E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper05.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x0000AC92 File Offset: 0x00008E92
			public EventWrapper05(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B44 RID: 6980 RVA: 0x0000AC9B File Offset: 0x00008E9B
			public static implicit operator EventMemberDescriptor.EventWrapper05(Action<Object, Object, Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper05>(A_0);
			}

			// Token: 0x06001B45 RID: 6981 RVA: 0x0000ACA3 File Offset: 0x00008EA3
			public static EventMemberDescriptor.EventWrapper05 operator +(EventMemberDescriptor.EventWrapper05 A_0, EventMemberDescriptor.EventWrapper05 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper05>();
			}

			// Token: 0x06001B46 RID: 6982 RVA: 0x0000ACB1 File Offset: 0x00008EB1
			public static EventMemberDescriptor.EventWrapper05 operator -(EventMemberDescriptor.EventWrapper05 A_0, EventMemberDescriptor.EventWrapper05 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper05>();
				}
				return delegate2;
			}

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BA RID: 442
		public sealed class EventWrapper06 : MulticastDelegate
		{
			// Token: 0x06001B47 RID: 6983 RVA: 0x0008402C File Offset: 0x0008222C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper06()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper06");
				EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr, 100665688);
				EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr, 100665689);
				EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr, 100665690);
				EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr, 100665691);
			}

			// Token: 0x06001B48 RID: 6984 RVA: 0x000840A0 File Offset: 0x000822A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35115, XrefRangeEnd = 35125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper06(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper06>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B49 RID: 6985 RVA: 0x000840FC File Offset: 0x000822FC
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B4A RID: 6986 RVA: 0x0008419C File Offset: 0x0008239C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35125, XrefRangeEnd = 35126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B4B RID: 6987 RVA: 0x00084270 File Offset: 0x00082470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper06.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B4C RID: 6988 RVA: 0x0000ACC2 File Offset: 0x00008EC2
			public EventWrapper06(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B4D RID: 6989 RVA: 0x0000ACCB File Offset: 0x00008ECB
			public static implicit operator EventMemberDescriptor.EventWrapper06(Action<Object, Object, Object, Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper06>(A_0);
			}

			// Token: 0x06001B4E RID: 6990 RVA: 0x0000ACD3 File Offset: 0x00008ED3
			public static EventMemberDescriptor.EventWrapper06 operator +(EventMemberDescriptor.EventWrapper06 A_0, EventMemberDescriptor.EventWrapper06 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper06>();
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x0000ACE1 File Offset: 0x00008EE1
			public static EventMemberDescriptor.EventWrapper06 operator -(EventMemberDescriptor.EventWrapper06 A_0, EventMemberDescriptor.EventWrapper06 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper06>();
				}
				return delegate2;
			}

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BB RID: 443
		public sealed class EventWrapper07 : MulticastDelegate
		{
			// Token: 0x06001B50 RID: 6992 RVA: 0x000842B4 File Offset: 0x000824B4
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper07()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper07");
				EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr, 100665692);
				EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr, 100665693);
				EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr, 100665694);
				EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr, 100665695);
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00084328 File Offset: 0x00082528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35126, XrefRangeEnd = 35136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper07(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper07>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x00084384 File Offset: 0x00082584
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B53 RID: 6995 RVA: 0x00084438 File Offset: 0x00082638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35136, XrefRangeEnd = 35137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x00084520 File Offset: 0x00082720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper07.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B55 RID: 6997 RVA: 0x0000ACF2 File Offset: 0x00008EF2
			public EventWrapper07(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B56 RID: 6998 RVA: 0x0000ACFB File Offset: 0x00008EFB
			public static implicit operator EventMemberDescriptor.EventWrapper07(Action<Object, Object, Object, Object, Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper07>(A_0);
			}

			// Token: 0x06001B57 RID: 6999 RVA: 0x0000AD03 File Offset: 0x00008F03
			public static EventMemberDescriptor.EventWrapper07 operator +(EventMemberDescriptor.EventWrapper07 A_0, EventMemberDescriptor.EventWrapper07 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper07>();
			}

			// Token: 0x06001B58 RID: 7000 RVA: 0x0000AD11 File Offset: 0x00008F11
			public static EventMemberDescriptor.EventWrapper07 operator -(EventMemberDescriptor.EventWrapper07 A_0, EventMemberDescriptor.EventWrapper07 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper07>();
				}
				return delegate2;
			}

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BC RID: 444
		public sealed class EventWrapper08 : MulticastDelegate
		{
			// Token: 0x06001B59 RID: 7001 RVA: 0x00084564 File Offset: 0x00082764
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper08()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper08");
				EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr, 100665696);
				EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr, 100665697);
				EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr, 100665698);
				EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr, 100665699);
			}

			// Token: 0x06001B5A RID: 7002 RVA: 0x000845D8 File Offset: 0x000827D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35137, XrefRangeEnd = 35147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper08(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper08>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B5B RID: 7003 RVA: 0x00084634 File Offset: 0x00082834
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B5C RID: 7004 RVA: 0x000846FC File Offset: 0x000828FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35147, XrefRangeEnd = 35148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B5D RID: 7005 RVA: 0x000847F8 File Offset: 0x000829F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper08.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B5E RID: 7006 RVA: 0x0000AD22 File Offset: 0x00008F22
			public EventWrapper08(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B5F RID: 7007 RVA: 0x0000AD2B File Offset: 0x00008F2B
			public static implicit operator EventMemberDescriptor.EventWrapper08(Action<Object, Object, Object, Object, Object, Object, Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventMemberDescriptor.EventWrapper08>(A_0);
			}

			// Token: 0x06001B60 RID: 7008 RVA: 0x0000AD33 File Offset: 0x00008F33
			public static EventMemberDescriptor.EventWrapper08 operator +(EventMemberDescriptor.EventWrapper08 A_0, EventMemberDescriptor.EventWrapper08 A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventMemberDescriptor.EventWrapper08>();
			}

			// Token: 0x06001B61 RID: 7009 RVA: 0x0000AD41 File Offset: 0x00008F41
			public static EventMemberDescriptor.EventWrapper08 operator -(EventMemberDescriptor.EventWrapper08 A_0, EventMemberDescriptor.EventWrapper08 A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventMemberDescriptor.EventWrapper08>();
				}
				return delegate2;
			}

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BD RID: 445
		public sealed class EventWrapper09 : MulticastDelegate
		{
			// Token: 0x06001B62 RID: 7010 RVA: 0x0008483C File Offset: 0x00082A3C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper09()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper09");
				EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr, 100665700);
				EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr, 100665701);
				EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr, 100665702);
				EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr, 100665703);
			}

			// Token: 0x06001B63 RID: 7011 RVA: 0x000848B0 File Offset: 0x00082AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35148, XrefRangeEnd = 35158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper09(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper09>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x0008490C File Offset: 0x00082B0C
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B65 RID: 7013 RVA: 0x000849E8 File Offset: 0x00082BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35158, XrefRangeEnd = 35159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B66 RID: 7014 RVA: 0x00084AF8 File Offset: 0x00082CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper09.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B67 RID: 7015 RVA: 0x0000AD52 File Offset: 0x00008F52
			public EventWrapper09(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BE RID: 446
		public sealed class EventWrapper10 : MulticastDelegate
		{
			// Token: 0x06001B68 RID: 7016 RVA: 0x00084B3C File Offset: 0x00082D3C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper10()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper10");
				EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr, 100665704);
				EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr, 100665705);
				EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr, 100665706);
				EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr, 100665707);
			}

			// Token: 0x06001B69 RID: 7017 RVA: 0x00084BB0 File Offset: 0x00082DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35159, XrefRangeEnd = 35169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper10(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper10>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B6A RID: 7018 RVA: 0x00084C0C File Offset: 0x00082E0C
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B6B RID: 7019 RVA: 0x00084CFC File Offset: 0x00082EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35169, XrefRangeEnd = 35170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B6C RID: 7020 RVA: 0x00084E20 File Offset: 0x00083020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper10.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6D RID: 7021 RVA: 0x0000AD5B File Offset: 0x00008F5B
			public EventWrapper10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BF RID: 447
		public sealed class EventWrapper11 : MulticastDelegate
		{
			// Token: 0x06001B6E RID: 7022 RVA: 0x00084E64 File Offset: 0x00083064
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper11()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper11");
				EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr, 100665708);
				EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr, 100665709);
				EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr, 100665710);
				EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr, 100665711);
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x00084ED8 File Offset: 0x000830D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35170, XrefRangeEnd = 35180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper11(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper11>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x00084F34 File Offset: 0x00083134
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B71 RID: 7025 RVA: 0x00085038 File Offset: 0x00083238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35180, XrefRangeEnd = 35181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B72 RID: 7026 RVA: 0x00085170 File Offset: 0x00083370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper11.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B73 RID: 7027 RVA: 0x0000AD64 File Offset: 0x00008F64
			public EventWrapper11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C0 RID: 448
		public sealed class EventWrapper12 : MulticastDelegate
		{
			// Token: 0x06001B74 RID: 7028 RVA: 0x000851B4 File Offset: 0x000833B4
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper12()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper12");
				EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr, 100665712);
				EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr, 100665713);
				EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr, 100665714);
				EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr, 100665715);
			}

			// Token: 0x06001B75 RID: 7029 RVA: 0x00085228 File Offset: 0x00083428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35181, XrefRangeEnd = 35191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper12(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper12>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B76 RID: 7030 RVA: 0x00085284 File Offset: 0x00083484
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B77 RID: 7031 RVA: 0x0008539C File Offset: 0x0008359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35191, XrefRangeEnd = 35192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B78 RID: 7032 RVA: 0x000854E8 File Offset: 0x000836E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper12.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B79 RID: 7033 RVA: 0x0000AD6D File Offset: 0x00008F6D
			public EventWrapper12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C1 RID: 449
		public sealed class EventWrapper13 : MulticastDelegate
		{
			// Token: 0x06001B7A RID: 7034 RVA: 0x0008552C File Offset: 0x0008372C
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper13()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper13");
				EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr, 100665716);
				EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr, 100665717);
				EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr, 100665718);
				EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr, 100665719);
			}

			// Token: 0x06001B7B RID: 7035 RVA: 0x000855A0 File Offset: 0x000837A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35192, XrefRangeEnd = 35202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper13(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper13>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B7C RID: 7036 RVA: 0x000855FC File Offset: 0x000837FC
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B7D RID: 7037 RVA: 0x00085728 File Offset: 0x00083928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35202, XrefRangeEnd = 35203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B7E RID: 7038 RVA: 0x00085888 File Offset: 0x00083A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper13.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B7F RID: 7039 RVA: 0x0000AD76 File Offset: 0x00008F76
			public EventWrapper13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C2 RID: 450
		public sealed class EventWrapper14 : MulticastDelegate
		{
			// Token: 0x06001B80 RID: 7040 RVA: 0x000858CC File Offset: 0x00083ACC
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper14()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper14");
				EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr, 100665720);
				EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr, 100665721);
				EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr, 100665722);
				EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr, 100665723);
			}

			// Token: 0x06001B81 RID: 7041 RVA: 0x00085940 File Offset: 0x00083B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35203, XrefRangeEnd = 35213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper14(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper14>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B82 RID: 7042 RVA: 0x0008599C File Offset: 0x00083B9C
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B83 RID: 7043 RVA: 0x00085ADC File Offset: 0x00083CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35213, XrefRangeEnd = 35214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B84 RID: 7044 RVA: 0x00085C50 File Offset: 0x00083E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper14.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B85 RID: 7045 RVA: 0x0000AD7F File Offset: 0x00008F7F
			public EventWrapper14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C3 RID: 451
		public sealed class EventWrapper15 : MulticastDelegate
		{
			// Token: 0x06001B86 RID: 7046 RVA: 0x00085C94 File Offset: 0x00083E94
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper15()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper15");
				EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr, 100665724);
				EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr, 100665725);
				EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr, 100665726);
				EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr, 100665727);
			}

			// Token: 0x06001B87 RID: 7047 RVA: 0x00085D08 File Offset: 0x00083F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35214, XrefRangeEnd = 35224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper15(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper15>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B88 RID: 7048 RVA: 0x00085D64 File Offset: 0x00083F64
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B89 RID: 7049 RVA: 0x00085EB8 File Offset: 0x000840B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35224, XrefRangeEnd = 35225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B8A RID: 7050 RVA: 0x00086040 File Offset: 0x00084240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper15.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x0000AD88 File Offset: 0x00008F88
			public EventWrapper15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C4 RID: 452
		public sealed class EventWrapper16 : MulticastDelegate
		{
			// Token: 0x06001B8C RID: 7052 RVA: 0x00086084 File Offset: 0x00084284
			// Note: this type is marked as 'beforefieldinit'.
			static EventWrapper16()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "EventWrapper16");
				EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr, 100665728);
				EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr, 100665729);
				EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr, 100665730);
				EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr, 100665731);
			}

			// Token: 0x06001B8D RID: 7053 RVA: 0x000860F8 File Offset: 0x000842F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35225, XrefRangeEnd = 35235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventWrapper16(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.EventWrapper16>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B8E RID: 7054 RVA: 0x00086154 File Offset: 0x00084354
			[CallerCount(0)]
			public unsafe void Invoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15, Object o16)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o16);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B8F RID: 7055 RVA: 0x000862BC File Offset: 0x000844BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35235, XrefRangeEnd = 35236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15, Object o16, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o16);
				ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001B90 RID: 7056 RVA: 0x00086458 File Offset: 0x00084658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.EventWrapper16.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B91 RID: 7057 RVA: 0x0000AD91 File Offset: 0x00008F91
			public EventWrapper16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_AsyncCallback_Object_0;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001C5 RID: 453
		[ObfuscatedName("MoonSharp.Interpreter.Interop.EventMemberDescriptor+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06001B92 RID: 7058 RVA: 0x0008649C File Offset: 0x0008469C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr);
				EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr, "o");
				EventMemberDescriptor.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr, 100665732);
				EventMemberDescriptor.__c__DisplayClass20_0.NativeMethodInfoPtr__RegisterCallback_b__0_Internal_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr, 100665733);
			}

			// Token: 0x06001B93 RID: 7059 RVA: 0x00086518 File Offset: 0x00084718
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B94 RID: 7060 RVA: 0x00086554 File Offset: 0x00084754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35236, XrefRangeEnd = 35245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Delegate _RegisterCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass20_0.NativeMethodInfoPtr__RegisterCallback_b__0_Internal_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x0000AD9A File Offset: 0x00008F9A
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00086594 File Offset: 0x00084794
			// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000ADA3 File Offset: 0x00008FA3
			public unsafe EventMemberDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventMemberDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000865C4 File Offset: 0x000847C4
			// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000ADC2 File Offset: 0x00008FC2
			public unsafe Object o
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr_o);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass20_0.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeFieldInfoPtr_o;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeMethodInfoPtr__RegisterCallback_b__0_Internal_Delegate_0;
		}

		// Token: 0x020001C6 RID: 454
		[ObfuscatedName("MoonSharp.Interpreter.Interop.EventMemberDescriptor+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06001B9A RID: 7066 RVA: 0x000865F4 File Offset: 0x000847F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMemberDescriptor>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, "sender");
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665734);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665735);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665736);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__2_Internal_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665737);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__3_Internal_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665738);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__4_Internal_Void_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665739);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__5_Internal_Void_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665740);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__6_Internal_Void_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665741);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__7_Internal_Void_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665742);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__8_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665743);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__9_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665744);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__10_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665745);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__11_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665746);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__12_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665747);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__13_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665748);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__14_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665749);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__15_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665750);
				EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__16_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr, 100665751);
			}

			// Token: 0x06001B9B RID: 7067 RVA: 0x000867B0 File Offset: 0x000849B0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMemberDescriptor.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9C RID: 7068 RVA: 0x000867EC File Offset: 0x000849EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35245, XrefRangeEnd = 35246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9D RID: 7069 RVA: 0x00086820 File Offset: 0x00084A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35246, XrefRangeEnd = 35247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__1(Object o1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B9E RID: 7070 RVA: 0x00086864 File Offset: 0x00084A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35247, XrefRangeEnd = 35248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__2(Object o1, Object o2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__2_Internal_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9F RID: 7071 RVA: 0x000868B8 File Offset: 0x00084AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35248, XrefRangeEnd = 35249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__3(Object o1, Object o2, Object o3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__3_Internal_Void_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA0 RID: 7072 RVA: 0x00086920 File Offset: 0x00084B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35249, XrefRangeEnd = 35250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__4(Object o1, Object o2, Object o3, Object o4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__4_Internal_Void_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA1 RID: 7073 RVA: 0x0008699C File Offset: 0x00084B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35250, XrefRangeEnd = 35251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__5(Object o1, Object o2, Object o3, Object o4, Object o5)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__5_Internal_Void_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA2 RID: 7074 RVA: 0x00086A28 File Offset: 0x00084C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35251, XrefRangeEnd = 35252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__6(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__6_Internal_Void_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA3 RID: 7075 RVA: 0x00086AC8 File Offset: 0x00084CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35252, XrefRangeEnd = 35253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__7(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__7_Internal_Void_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA4 RID: 7076 RVA: 0x00086B7C File Offset: 0x00084D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35253, XrefRangeEnd = 35254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__8(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__8_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA5 RID: 7077 RVA: 0x00086C44 File Offset: 0x00084E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35254, XrefRangeEnd = 35255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__9(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__9_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA6 RID: 7078 RVA: 0x00086D20 File Offset: 0x00084F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35255, XrefRangeEnd = 35256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__10(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__10_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA7 RID: 7079 RVA: 0x00086E10 File Offset: 0x00085010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35256, XrefRangeEnd = 35257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__11(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__11_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA8 RID: 7080 RVA: 0x00086F14 File Offset: 0x00085114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35257, XrefRangeEnd = 35258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__12(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__12_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x0008702C File Offset: 0x0008522C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35258, XrefRangeEnd = 35259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__13(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__13_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAA RID: 7082 RVA: 0x00087158 File Offset: 0x00085358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35259, XrefRangeEnd = 35260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__14(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__14_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x00087298 File Offset: 0x00085498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35260, XrefRangeEnd = 35261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__15(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__15_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAC RID: 7084 RVA: 0x000873EC File Offset: 0x000855EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35261, XrefRangeEnd = 35262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateDelegate_b__16(Object o1, Object o2, Object o3, Object o4, Object o5, Object o6, Object o7, Object o8, Object o9, Object o10, Object o11, Object o12, Object o13, Object o14, Object o15, Object o16)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o4);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o5);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o7);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o8);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o9);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o10);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o11);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o12);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o13);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o14);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o15);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o16);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMemberDescriptor.__c__DisplayClass22_0.NativeMethodInfoPtr__CreateDelegate_b__16_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAD RID: 7085 RVA: 0x0000ADE1 File Offset: 0x00008FE1
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00087554 File Offset: 0x00085754
			// (set) Token: 0x06001BAF RID: 7087 RVA: 0x0000ADEA File Offset: 0x00008FEA
			public unsafe EventMemberDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventMemberDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00087584 File Offset: 0x00085784
			// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0000AE09 File Offset: 0x00009009
			public unsafe Object sender
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr_sender);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMemberDescriptor.__c__DisplayClass22_0.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeFieldInfoPtr_sender;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__0_Internal_Void_0;

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__1_Internal_Void_Object_0;

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__2_Internal_Void_Object_Object_0;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__3_Internal_Void_Object_Object_Object_0;

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__4_Internal_Void_Object_Object_Object_Object_0;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__5_Internal_Void_Object_Object_Object_Object_Object_0;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__6_Internal_Void_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__7_Internal_Void_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__8_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__9_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__10_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__11_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__12_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__13_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__14_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__15_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeMethodInfoPtr__CreateDelegate_b__16_Internal_Void_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_Object_0;
		}
	}
}
