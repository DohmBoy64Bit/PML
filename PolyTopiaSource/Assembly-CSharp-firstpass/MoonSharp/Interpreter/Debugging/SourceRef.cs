using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FE RID: 254
	public class SourceRef : Object
	{
		// Token: 0x0600132A RID: 4906 RVA: 0x00063834 File Offset: 0x00061A34
		// Note: this type is marked as 'beforefieldinit'.
		static SourceRef()
		{
			Il2CppClassPointerStore<SourceRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "SourceRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceRef>.NativeClassPtr);
			SourceRef.NativeFieldInfoPtr__IsClrLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<IsClrLocation>k__BackingField");
			SourceRef.NativeFieldInfoPtr__SourceIdx_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<SourceIdx>k__BackingField");
			SourceRef.NativeFieldInfoPtr__FromChar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<FromChar>k__BackingField");
			SourceRef.NativeFieldInfoPtr__ToChar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<ToChar>k__BackingField");
			SourceRef.NativeFieldInfoPtr__FromLine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<FromLine>k__BackingField");
			SourceRef.NativeFieldInfoPtr__ToLine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<ToLine>k__BackingField");
			SourceRef.NativeFieldInfoPtr__IsStepStop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<IsStepStop>k__BackingField");
			SourceRef.NativeFieldInfoPtr_Breakpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "Breakpoint");
			SourceRef.NativeFieldInfoPtr__CannotBreakpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, "<CannotBreakpoint>k__BackingField");
			SourceRef.NativeMethodInfoPtr_get_IsClrLocation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666645);
			SourceRef.NativeMethodInfoPtr_set_IsClrLocation_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666646);
			SourceRef.NativeMethodInfoPtr_get_SourceIdx_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666647);
			SourceRef.NativeMethodInfoPtr_set_SourceIdx_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666648);
			SourceRef.NativeMethodInfoPtr_get_FromChar_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666649);
			SourceRef.NativeMethodInfoPtr_set_FromChar_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666650);
			SourceRef.NativeMethodInfoPtr_get_ToChar_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666651);
			SourceRef.NativeMethodInfoPtr_set_ToChar_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666652);
			SourceRef.NativeMethodInfoPtr_get_FromLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666653);
			SourceRef.NativeMethodInfoPtr_set_FromLine_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666654);
			SourceRef.NativeMethodInfoPtr_get_ToLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666655);
			SourceRef.NativeMethodInfoPtr_set_ToLine_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666656);
			SourceRef.NativeMethodInfoPtr_get_IsStepStop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666657);
			SourceRef.NativeMethodInfoPtr_set_IsStepStop_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666658);
			SourceRef.NativeMethodInfoPtr_get_CannotBreakpoint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666659);
			SourceRef.NativeMethodInfoPtr_set_CannotBreakpoint_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666660);
			SourceRef.NativeMethodInfoPtr__ctor_Public_Void_SourceRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666662);
			SourceRef.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666663);
			SourceRef.NativeMethodInfoPtr_GetClrLocation_Internal_Static_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666661);
			SourceRef.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666664);
			SourceRef.NativeMethodInfoPtr_GetLocationDistance_Internal_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666665);
			SourceRef.NativeMethodInfoPtr_IncludesLocation_Public_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666666);
			SourceRef.NativeMethodInfoPtr_SetNoBreakPoint_Public_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666667);
			SourceRef.NativeMethodInfoPtr_FormatLocation_Public_String_Script_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceRef>.NativeClassPtr, 100666668);
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00063AF8 File Offset: 0x00061CF8
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00063B34 File Offset: 0x00061D34
		public unsafe bool IsClrLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_IsClrLocation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_IsClrLocation_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00063B74 File Offset: 0x00061D74
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00063BB0 File Offset: 0x00061DB0
		public unsafe int SourceIdx
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_SourceIdx_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_SourceIdx_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00063BF0 File Offset: 0x00061DF0
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00063C2C File Offset: 0x00061E2C
		public unsafe int FromChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_FromChar_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_FromChar_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00063C6C File Offset: 0x00061E6C
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x00063CA8 File Offset: 0x00061EA8
		public unsafe int ToChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_ToChar_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_ToChar_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00063CE8 File Offset: 0x00061EE8
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x00063D24 File Offset: 0x00061F24
		public unsafe int FromLine
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_FromLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_FromLine_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00063D64 File Offset: 0x00061F64
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00063DA0 File Offset: 0x00061FA0
		public unsafe int ToLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_ToLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_ToLine_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00063DE0 File Offset: 0x00061FE0
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00063E1C File Offset: 0x0006201C
		public unsafe bool IsStepStop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_IsStepStop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_IsStepStop_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00063E5C File Offset: 0x0006205C
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00063E98 File Offset: 0x00062098
		public unsafe bool CannotBreakpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_get_CannotBreakpoint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_set_CannotBreakpoint_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00063ED8 File Offset: 0x000620D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46566, XrefRangeEnd = 46567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef(SourceRef src, bool isStepStop)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStepStop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr__ctor_Public_Void_SourceRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00063F34 File Offset: 0x00062134
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 46568, RefRangeEnd = 46582, XrefRangeStart = 46567, XrefRangeEnd = 46568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIdx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toline;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStepStop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00063FC4 File Offset: 0x000621C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46586, RefRangeEnd = 46588, XrefRangeStart = 46582, XrefRangeEnd = 46586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SourceRef GetClrLocation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_GetClrLocation_Internal_Static_SourceRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00063FF8 File Offset: 0x000621F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46588, XrefRangeEnd = 46620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceRef.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0006403C File Offset: 0x0006223C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46630, RefRangeEnd = 46631, XrefRangeStart = 46620, XrefRangeEnd = 46630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLocationDistance(int sourceIdx, int line, int col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIdx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_GetLocationDistance_Internal_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000640A4 File Offset: 0x000622A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46631, RefRangeEnd = 46632, XrefRangeStart = 46631, XrefRangeEnd = 46631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IncludesLocation(int sourceIdx, int line, int col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIdx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_IncludesLocation_Public_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0006410C File Offset: 0x0006230C
		[CallerCount(0)]
		public unsafe SourceRef SetNoBreakPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_SetNoBreakPoint_Public_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0006414C File Offset: 0x0006234C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46661, RefRangeEnd = 46663, XrefRangeStart = 46632, XrefRangeEnd = 46661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatLocation(Script script, bool forceClassicFormat = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceClassicFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceRef.NativeMethodInfoPtr_FormatLocation_Public_String_Script_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00007DCE File Offset: 0x00005FCE
		public SourceRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000641A4 File Offset: 0x000623A4
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x00007DD7 File Offset: 0x00005FD7
		public unsafe bool _IsClrLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__IsClrLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__IsClrLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x000641CC File Offset: 0x000623CC
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00007DF2 File Offset: 0x00005FF2
		public unsafe int _SourceIdx_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__SourceIdx_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__SourceIdx_k__BackingField)) = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x000641F4 File Offset: 0x000623F4
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00007E0D File Offset: 0x0000600D
		public unsafe int _FromChar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__FromChar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__FromChar_k__BackingField)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0006421C File Offset: 0x0006241C
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00007E28 File Offset: 0x00006028
		public unsafe int _ToChar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__ToChar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__ToChar_k__BackingField)) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00064244 File Offset: 0x00062444
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00007E43 File Offset: 0x00006043
		public unsafe int _FromLine_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__FromLine_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__FromLine_k__BackingField)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0006426C File Offset: 0x0006246C
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe int _ToLine_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__ToLine_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__ToLine_k__BackingField)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00064294 File Offset: 0x00062494
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00007E79 File Offset: 0x00006079
		public unsafe bool _IsStepStop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__IsStepStop_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__IsStepStop_k__BackingField)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000642BC File Offset: 0x000624BC
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00007E94 File Offset: 0x00006094
		public unsafe bool Breakpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr_Breakpoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr_Breakpoint)) = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000642E4 File Offset: 0x000624E4
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x00007EAF File Offset: 0x000060AF
		public unsafe bool _CannotBreakpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__CannotBreakpoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceRef.NativeFieldInfoPtr__CannotBreakpoint_k__BackingField)) = value;
			}
		}

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr__IsClrLocation_k__BackingField;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeFieldInfoPtr__SourceIdx_k__BackingField;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeFieldInfoPtr__FromChar_k__BackingField;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr__ToChar_k__BackingField;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr__FromLine_k__BackingField;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr__ToLine_k__BackingField;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr__IsStepStop_k__BackingField;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeFieldInfoPtr_Breakpoint;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr__CannotBreakpoint_k__BackingField;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClrLocation_Public_get_Boolean_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_set_IsClrLocation_Private_set_Void_Boolean_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceIdx_Public_get_Int32_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceIdx_Private_set_Void_Int32_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_get_FromChar_Public_get_Int32_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_set_FromChar_Private_set_Void_Int32_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_get_ToChar_Public_get_Int32_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_set_ToChar_Private_set_Void_Int32_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_get_FromLine_Public_get_Int32_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_set_FromLine_Private_set_Void_Int32_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_get_ToLine_Public_get_Int32_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_set_ToLine_Private_set_Void_Int32_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStepStop_Public_get_Boolean_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_set_IsStepStop_Private_set_Void_Boolean_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_get_CannotBreakpoint_Public_get_Boolean_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_set_CannotBreakpoint_Private_set_Void_Boolean_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SourceRef_Boolean_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_GetClrLocation_Internal_Static_SourceRef_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_GetLocationDistance_Internal_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_IncludesLocation_Public_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_SetNoBreakPoint_Public_SourceRef_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_FormatLocation_Public_String_Script_Boolean_0;
	}
}
