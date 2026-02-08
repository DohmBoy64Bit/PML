using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200015E RID: 350
	public class RelationshipManager : Object
	{
		// Token: 0x06001761 RID: 5985 RVA: 0x00075A84 File Offset: 0x00073C84
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipManager()
		{
			Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "RelationshipManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr);
			RelationshipManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "MethodsPtr");
			RelationshipManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "MethodsStructure");
			RelationshipManager.NativeFieldInfoPtr_OnRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "OnRefresh");
			RelationshipManager.NativeFieldInfoPtr_OnRelationshipUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "OnRelationshipUpdate");
			RelationshipManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667598);
			RelationshipManager.NativeMethodInfoPtr_add_OnRefresh_Public_add_Void_RefreshHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667599);
			RelationshipManager.NativeMethodInfoPtr_remove_OnRefresh_Public_rem_Void_RefreshHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667600);
			RelationshipManager.NativeMethodInfoPtr_add_OnRelationshipUpdate_Public_add_Void_RelationshipUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667601);
			RelationshipManager.NativeMethodInfoPtr_remove_OnRelationshipUpdate_Public_rem_Void_RelationshipUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667602);
			RelationshipManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667603);
			RelationshipManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667604);
			RelationshipManager.NativeMethodInfoPtr_FilterCallbackImpl_Private_Static_Boolean_IntPtr_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667605);
			RelationshipManager.NativeMethodInfoPtr_Filter_Public_Void_FilterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667606);
			RelationshipManager.NativeMethodInfoPtr_Count_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667607);
			RelationshipManager.NativeMethodInfoPtr_Get_Public_Relationship_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667608);
			RelationshipManager.NativeMethodInfoPtr_GetAt_Public_Relationship_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667609);
			RelationshipManager.NativeMethodInfoPtr_OnRefreshImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667610);
			RelationshipManager.NativeMethodInfoPtr_OnRelationshipUpdateImpl_Private_Static_Void_IntPtr_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, 100667611);
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00075C1C File Offset: 0x00073E1C
		public unsafe RelationshipManager.FFIMethods Methods
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 53148, RefRangeEnd = 53152, XrefRangeStart = 53135, XrefRangeEnd = 53148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RelationshipManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00075C54 File Offset: 0x00073E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53152, XrefRangeEnd = 53156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRefresh(RelationshipManager.RefreshHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_add_OnRefresh_Public_add_Void_RefreshHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00075C98 File Offset: 0x00073E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53156, XrefRangeEnd = 53160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRefresh(RelationshipManager.RefreshHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_remove_OnRefresh_Public_rem_Void_RefreshHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00075CDC File Offset: 0x00073EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53160, XrefRangeEnd = 53164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_add_OnRelationshipUpdate_Public_add_Void_RelationshipUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00075D20 File Offset: 0x00073F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53164, XrefRangeEnd = 53168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_remove_OnRelationshipUpdate_Public_rem_Void_RelationshipUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00075D64 File Offset: 0x00073F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53168, XrefRangeEnd = 53170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00075DCC File Offset: 0x00073FCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53194, RefRangeEnd = 53196, XrefRangeStart = 53170, XrefRangeEnd = 53194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00075E20 File Offset: 0x00074020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53196, XrefRangeEnd = 53210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_FilterCallbackImpl_Private_Static_Boolean_IntPtr_byref_Relationship_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00075E88 File Offset: 0x00074088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53210, XrefRangeEnd = 53222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Filter(RelationshipManager.FilterHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_Filter_Public_Void_FilterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00075ECC File Offset: 0x000740CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53222, XrefRangeEnd = 53223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_Count_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00075F08 File Offset: 0x00074108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53223, XrefRangeEnd = 53225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Relationship Get(long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_Get_Public_Relationship_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr3) : null;
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00075F54 File Offset: 0x00074154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53225, XrefRangeEnd = 53227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Relationship GetAt(uint index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_GetAt_Public_Relationship_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr3) : null;
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00075FA0 File Offset: 0x000741A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53227, XrefRangeEnd = 53233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRefreshImpl(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_OnRefreshImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00075FD4 File Offset: 0x000741D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53233, XrefRangeEnd = 53239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.NativeMethodInfoPtr_OnRelationshipUpdateImpl_Private_Static_Void_IntPtr_byref_Relationship_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00009661 File Offset: 0x00007861
		public RelationshipManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x00076030 File Offset: 0x00074230
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0000966A File Offset: 0x0000786A
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00076058 File Offset: 0x00074258
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x00009685 File Offset: 0x00007885
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x00076088 File Offset: 0x00074288
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x000096A4 File Offset: 0x000078A4
		public unsafe RelationshipManager.RefreshHandler OnRefresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_OnRefresh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.RefreshHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_OnRefresh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x000760B8 File Offset: 0x000742B8
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x000096C3 File Offset: 0x000078C3
		public unsafe RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_OnRelationshipUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.RelationshipUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.NativeFieldInfoPtr_OnRelationshipUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_OnRefresh;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_OnRelationshipUpdate;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRefresh_Public_add_Void_RefreshHandler_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRefresh_Public_rem_Void_RefreshHandler_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRelationshipUpdate_Public_add_Void_RelationshipUpdateHandler_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRelationshipUpdate_Public_rem_Void_RelationshipUpdateHandler_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_FilterCallbackImpl_Private_Static_Boolean_IntPtr_byref_Relationship_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Void_FilterHandler_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Int32_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Relationship_Int64_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_GetAt_Public_Relationship_UInt32_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_OnRefreshImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_OnRelationshipUpdateImpl_Private_Static_Void_IntPtr_byref_Relationship_0;

		// Token: 0x02000210 RID: 528
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x06001EEB RID: 7915 RVA: 0x00090E70 File Offset: 0x0008F070
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr);
				RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, "OnRefresh");
				RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRelationshipUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, "OnRelationshipUpdate");
			}

			// Token: 0x06001EEC RID: 7916 RVA: 0x0000C80F File Offset: 0x0000AA0F
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EED RID: 7917 RVA: 0x0000C818 File Offset: 0x0000AA18
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00090EC4 File Offset: 0x0008F0C4
			// (set) Token: 0x06001EEF RID: 7919 RVA: 0x0000C82A File Offset: 0x0000AA2A
			public unsafe RelationshipManager.FFIEvents.RefreshHandler OnRefresh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRefresh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIEvents.RefreshHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRefresh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00090EF4 File Offset: 0x0008F0F4
			// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0000C849 File Offset: 0x0000AA49
			public unsafe RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRelationshipUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIEvents.RelationshipUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIEvents.NativeFieldInfoPtr_OnRelationshipUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr_OnRefresh;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeFieldInfoPtr_OnRelationshipUpdate;

			// Token: 0x0200028F RID: 655
			public sealed class RefreshHandler : MulticastDelegate
			{
				// Token: 0x06002392 RID: 9106 RVA: 0x000A0324 File Offset: 0x0009E524
				// Note: this type is marked as 'beforefieldinit'.
				static RefreshHandler()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, "RefreshHandler");
					RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr, 100667612);
					RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr, 100667613);
					RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr, 100667614);
					RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr, 100667615);
				}

				// Token: 0x06002393 RID: 9107 RVA: 0x000A0398 File Offset: 0x0009E598
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RefreshHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RefreshHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002394 RID: 9108 RVA: 0x000A03F4 File Offset: 0x0009E5F4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002395 RID: 9109 RVA: 0x000A0434 File Offset: 0x0009E634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002396 RID: 9110 RVA: 0x000A04A4 File Offset: 0x0009E6A4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RefreshHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002397 RID: 9111 RVA: 0x0000EA53 File Offset: 0x0000CC53
				public RefreshHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002398 RID: 9112 RVA: 0x0000EA5C File Offset: 0x0000CC5C
				public static implicit operator RelationshipManager.FFIEvents.RefreshHandler(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<RelationshipManager.FFIEvents.RefreshHandler>(A_0);
				}

				// Token: 0x06002399 RID: 9113 RVA: 0x0000EA64 File Offset: 0x0000CC64
				public static RelationshipManager.FFIEvents.RefreshHandler operator +(RelationshipManager.FFIEvents.RefreshHandler A_0, RelationshipManager.FFIEvents.RefreshHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<RelationshipManager.FFIEvents.RefreshHandler>();
				}

				// Token: 0x0600239A RID: 9114 RVA: 0x0000EA72 File Offset: 0x0000CC72
				public static RelationshipManager.FFIEvents.RefreshHandler operator -(RelationshipManager.FFIEvents.RefreshHandler A_0, RelationshipManager.FFIEvents.RefreshHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<RelationshipManager.FFIEvents.RefreshHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001A81 RID: 6785
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A82 RID: 6786
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x04001A83 RID: 6787
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A84 RID: 6788
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000290 RID: 656
			public sealed class RelationshipUpdateHandler : MulticastDelegate
			{
				// Token: 0x0600239B RID: 9115 RVA: 0x000A04E8 File Offset: 0x0009E6E8
				// Note: this type is marked as 'beforefieldinit'.
				static RelationshipUpdateHandler()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, "RelationshipUpdateHandler");
					RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr, 100667616);
					RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr, 100667617);
					RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr, 100667618);
					RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr, 100667619);
				}

				// Token: 0x0600239C RID: 9116 RVA: 0x000A055C File Offset: 0x0009E75C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RelationshipUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIEvents.RelationshipUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600239D RID: 9117 RVA: 0x000A05B8 File Offset: 0x0009E7B8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ref Relationship relationship)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				}

				// Token: 0x0600239E RID: 9118 RVA: 0x000A0620 File Offset: 0x0009E820
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53013, XrefRangeEnd = 53019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x0600239F RID: 9119 RVA: 0x000A06BC File Offset: 0x0009E8BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Relationship relationship, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIEvents.RelationshipUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				}

				// Token: 0x060023A0 RID: 9120 RVA: 0x0000EA83 File Offset: 0x0000CC83
				public RelationshipUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A85 RID: 6789
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A86 RID: 6790
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Relationship_0;

				// Token: 0x04001A87 RID: 6791
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0;

				// Token: 0x04001A88 RID: 6792
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0;
			}
		}

		// Token: 0x02000211 RID: 529
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001EF2 RID: 7922 RVA: 0x00090F24 File Offset: 0x0008F124
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr);
				RelationshipManager.FFIMethods.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "Filter");
				RelationshipManager.FFIMethods.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "Count");
				RelationshipManager.FFIMethods.NativeFieldInfoPtr_Get = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "Get");
				RelationshipManager.FFIMethods.NativeFieldInfoPtr_GetAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "GetAt");
			}

			// Token: 0x06001EF3 RID: 7923 RVA: 0x0000C868 File Offset: 0x0000AA68
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x0000C871 File Offset: 0x0000AA71
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00090FA0 File Offset: 0x0008F1A0
			// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x0000C883 File Offset: 0x0000AA83
			public unsafe RelationshipManager.FFIMethods.FilterMethod Filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIMethods.FilterMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00090FD0 File Offset: 0x0008F1D0
			// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x0000C8A2 File Offset: 0x0000AAA2
			public unsafe RelationshipManager.FFIMethods.CountMethod Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Count);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIMethods.CountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Count), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00091000 File Offset: 0x0008F200
			// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0000C8C1 File Offset: 0x0000AAC1
			public unsafe RelationshipManager.FFIMethods.GetMethod Get
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Get);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIMethods.GetMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_Get), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00091030 File Offset: 0x0008F230
			// (set) Token: 0x06001EFC RID: 7932 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
			public unsafe RelationshipManager.FFIMethods.GetAtMethod GetAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_GetAt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager.FFIMethods.GetAtMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipManager.FFIMethods.NativeFieldInfoPtr_GetAt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeFieldInfoPtr_Filter;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeFieldInfoPtr_Get;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeFieldInfoPtr_GetAt;

			// Token: 0x02000291 RID: 657
			public sealed class FilterCallback : MulticastDelegate
			{
				// Token: 0x060023A1 RID: 9121 RVA: 0x000A0728 File Offset: 0x0009E928
				// Note: this type is marked as 'beforefieldinit'.
				static FilterCallback()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "FilterCallback");
					RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr, 100667620);
					RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr, 100667621);
					RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr, 100667622);
					RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr, 100667623);
				}

				// Token: 0x060023A2 RID: 9122 RVA: 0x000A079C File Offset: 0x0009E99C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53019, XrefRangeEnd = 53022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FilterCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023A3 RID: 9123 RVA: 0x000A07F8 File Offset: 0x0009E9F8
				[CallerCount(0)]
				public unsafe bool Invoke(IntPtr ptr, ref Relationship relationship)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x060023A4 RID: 9124 RVA: 0x000A086C File Offset: 0x0009EA6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53022, XrefRangeEnd = 53028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060023A5 RID: 9125 RVA: 0x000A0908 File Offset: 0x0009EB08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53028, XrefRangeEnd = 53030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(ref Relationship relationship, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x060023A6 RID: 9126 RVA: 0x0000EA8C File Offset: 0x0000CC8C
				public FilterCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A89 RID: 6793
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A8A RID: 6794
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_byref_Relationship_0;

				// Token: 0x04001A8B RID: 6795
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Relationship_AsyncCallback_Object_0;

				// Token: 0x04001A8C RID: 6796
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0;
			}

			// Token: 0x02000292 RID: 658
			public sealed class FilterMethod : MulticastDelegate
			{
				// Token: 0x060023A7 RID: 9127 RVA: 0x000A0980 File Offset: 0x0009EB80
				// Note: this type is marked as 'beforefieldinit'.
				static FilterMethod()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "FilterMethod");
					RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr, 100667624);
					RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FilterCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr, 100667625);
					RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FilterCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr, 100667626);
					RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr, 100667627);
				}

				// Token: 0x060023A8 RID: 9128 RVA: 0x000A09F4 File Offset: 0x0009EBF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FilterMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods.FilterMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023A9 RID: 9129 RVA: 0x000A0A50 File Offset: 0x0009EC50
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FilterCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023AA RID: 9130 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FilterCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023AB RID: 9131 RVA: 0x000A0B44 File Offset: 0x0009ED44
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.FilterMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023AC RID: 9132 RVA: 0x0000EA95 File Offset: 0x0000CC95
				public FilterMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023AD RID: 9133 RVA: 0x0000EA9E File Offset: 0x0000CC9E
				public static implicit operator RelationshipManager.FFIMethods.FilterMethod(Action<IntPtr, IntPtr, RelationshipManager.FFIMethods.FilterCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<RelationshipManager.FFIMethods.FilterMethod>(A_0);
				}

				// Token: 0x060023AE RID: 9134 RVA: 0x0000EAA6 File Offset: 0x0000CCA6
				public static RelationshipManager.FFIMethods.FilterMethod operator +(RelationshipManager.FFIMethods.FilterMethod A_0, RelationshipManager.FFIMethods.FilterMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<RelationshipManager.FFIMethods.FilterMethod>();
				}

				// Token: 0x060023AF RID: 9135 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
				public static RelationshipManager.FFIMethods.FilterMethod operator -(RelationshipManager.FFIMethods.FilterMethod A_0, RelationshipManager.FFIMethods.FilterMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<RelationshipManager.FFIMethods.FilterMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A8D RID: 6797
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A8E RID: 6798
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FilterCallback_0;

				// Token: 0x04001A8F RID: 6799
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FilterCallback_AsyncCallback_Object_0;

				// Token: 0x04001A90 RID: 6800
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000293 RID: 659
			public sealed class CountMethod : MulticastDelegate
			{
				// Token: 0x060023B0 RID: 9136 RVA: 0x000A0B88 File Offset: 0x0009ED88
				// Note: this type is marked as 'beforefieldinit'.
				static CountMethod()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "CountMethod");
					RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr, 100667628);
					RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr, 100667629);
					RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr, 100667630);
					RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr, 100667631);
				}

				// Token: 0x060023B1 RID: 9137 RVA: 0x000A0BFC File Offset: 0x0009EDFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods.CountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023B2 RID: 9138 RVA: 0x000A0C58 File Offset: 0x0009EE58
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060023B3 RID: 9139 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53030, XrefRangeEnd = 53035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023B4 RID: 9140 RVA: 0x000A0D34 File Offset: 0x0009EF34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.CountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060023B5 RID: 9141 RVA: 0x0000EAC5 File Offset: 0x0000CCC5
				public CountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A91 RID: 6801
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A92 RID: 6802
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Int32_0;

				// Token: 0x04001A93 RID: 6803
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001A94 RID: 6804
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x02000294 RID: 660
			public sealed class GetMethod : MulticastDelegate
			{
				// Token: 0x060023B6 RID: 9142 RVA: 0x000A0D94 File Offset: 0x0009EF94
				// Note: this type is marked as 'beforefieldinit'.
				static GetMethod()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "GetMethod");
					RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr, 100667632);
					RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr, 100667633);
					RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr, 100667634);
					RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr, 100667635);
				}

				// Token: 0x060023B7 RID: 9143 RVA: 0x000A0E08 File Offset: 0x0009F008
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023B8 RID: 9144 RVA: 0x000A0E64 File Offset: 0x0009F064
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userId, ref Relationship relationship)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060023B9 RID: 9145 RVA: 0x000A0EE8 File Offset: 0x0009F0E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53035, XrefRangeEnd = 53043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref Relationship relationship, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060023BA RID: 9146 RVA: 0x000A0F94 File Offset: 0x0009F194
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Relationship relationship, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060023BB RID: 9147 RVA: 0x0000EACE File Offset: 0x0000CCCE
				public GetMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A95 RID: 6805
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A96 RID: 6806
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Relationship_0;

				// Token: 0x04001A97 RID: 6807
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Relationship_AsyncCallback_Object_0;

				// Token: 0x04001A98 RID: 6808
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0;
			}

			// Token: 0x02000295 RID: 661
			public sealed class GetAtMethod : MulticastDelegate
			{
				// Token: 0x060023BC RID: 9148 RVA: 0x000A1010 File Offset: 0x0009F210
				// Note: this type is marked as 'beforefieldinit'.
				static GetAtMethod()
				{
					Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager.FFIMethods>.NativeClassPtr, "GetAtMethod");
					RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr, 100667636);
					RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr, 100667637);
					RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr, 100667638);
					RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr, 100667639);
				}

				// Token: 0x060023BD RID: 9149 RVA: 0x000A1084 File Offset: 0x0009F284
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetAtMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FFIMethods.GetAtMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023BE RID: 9150 RVA: 0x000A10E0 File Offset: 0x0009F2E0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, uint index, ref Relationship relationship)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060023BF RID: 9151 RVA: 0x000A1164 File Offset: 0x0009F364
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53043, XrefRangeEnd = 53051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, uint index, ref Relationship relationship, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060023C0 RID: 9152 RVA: 0x000A1210 File Offset: 0x0009F410
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Relationship relationship, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FFIMethods.GetAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060023C1 RID: 9153 RVA: 0x0000EAD7 File Offset: 0x0000CCD7
				public GetAtMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A99 RID: 6809
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A9A RID: 6810
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_byref_Relationship_0;

				// Token: 0x04001A9B RID: 6811
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_byref_Relationship_AsyncCallback_Object_0;

				// Token: 0x04001A9C RID: 6812
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Relationship_IAsyncResult_0;
			}
		}

		// Token: 0x02000212 RID: 530
		public sealed class FilterHandler : MulticastDelegate
		{
			// Token: 0x06001EFD RID: 7933 RVA: 0x00091060 File Offset: 0x0008F260
			// Note: this type is marked as 'beforefieldinit'.
			static FilterHandler()
			{
				Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "FilterHandler");
				RelationshipManager.FilterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr, 100667640);
				RelationshipManager.FilterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr, 100667641);
				RelationshipManager.FilterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr, 100667642);
				RelationshipManager.FilterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr, 100667643);
			}

			// Token: 0x06001EFE RID: 7934 RVA: 0x000910D4 File Offset: 0x0008F2D4
			[CallerCount(72)]
			[CachedScanResults(RefRangeStart = 53055, RefRangeEnd = 53127, XrefRangeStart = 53051, XrefRangeEnd = 53055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.FilterHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FilterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EFF RID: 7935 RVA: 0x00091130 File Offset: 0x0008F330
			[CallerCount(0)]
			public unsafe bool Invoke(ref Relationship relationship)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FilterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001F00 RID: 7936 RVA: 0x00091194 File Offset: 0x0008F394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53127, XrefRangeEnd = 53131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FilterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x00091220 File Offset: 0x0008F420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(ref Relationship relationship, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.FilterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x0000C8FF File Offset: 0x0000AAFF
			public FilterHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_Relationship_0;

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_Relationship_IAsyncResult_0;
		}

		// Token: 0x02000213 RID: 531
		public sealed class RefreshHandler : MulticastDelegate
		{
			// Token: 0x06001F03 RID: 7939 RVA: 0x00091298 File Offset: 0x0008F498
			// Note: this type is marked as 'beforefieldinit'.
			static RefreshHandler()
			{
				Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "RefreshHandler");
				RelationshipManager.RefreshHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr, 100667644);
				RelationshipManager.RefreshHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr, 100667645);
				RelationshipManager.RefreshHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr, 100667646);
				RelationshipManager.RefreshHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr, 100667647);
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x0009130C File Offset: 0x0008F50C
			[CallerCount(247)]
			[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14625, XrefRangeEnd = 14872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RefreshHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.RefreshHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RefreshHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F05 RID: 7941 RVA: 0x00091368 File Offset: 0x0008F568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RefreshHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F06 RID: 7942 RVA: 0x0009139C File Offset: 0x0008F59C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RefreshHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F07 RID: 7943 RVA: 0x00091400 File Offset: 0x0008F600
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RefreshHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F08 RID: 7944 RVA: 0x0000C908 File Offset: 0x0000AB08
			public RefreshHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F09 RID: 7945 RVA: 0x0000C911 File Offset: 0x0000AB11
			public static implicit operator RelationshipManager.RefreshHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<RelationshipManager.RefreshHandler>(A_0);
			}

			// Token: 0x06001F0A RID: 7946 RVA: 0x0000C919 File Offset: 0x0000AB19
			public static RelationshipManager.RefreshHandler operator +(RelationshipManager.RefreshHandler A_0, RelationshipManager.RefreshHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RelationshipManager.RefreshHandler>();
			}

			// Token: 0x06001F0B RID: 7947 RVA: 0x0000C927 File Offset: 0x0000AB27
			public static RelationshipManager.RefreshHandler operator -(RelationshipManager.RefreshHandler A_0, RelationshipManager.RefreshHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RelationshipManager.RefreshHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000214 RID: 532
		public sealed class RelationshipUpdateHandler : MulticastDelegate
		{
			// Token: 0x06001F0C RID: 7948 RVA: 0x00091444 File Offset: 0x0008F644
			// Note: this type is marked as 'beforefieldinit'.
			static RelationshipUpdateHandler()
			{
				Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelationshipManager>.NativeClassPtr, "RelationshipUpdateHandler");
				RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr, 100667648);
				RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr, 100667649);
				RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr, 100667650);
				RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr, 100667651);
			}

			// Token: 0x06001F0D RID: 7949 RVA: 0x000914B8 File Offset: 0x0008F6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RelationshipUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipManager.RelationshipUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x00091514 File Offset: 0x0008F714
			[CallerCount(0)]
			public unsafe void Invoke(ref Relationship relationship)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				}
			}

			// Token: 0x06001F0F RID: 7951 RVA: 0x0009156C File Offset: 0x0008F76C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53131, XrefRangeEnd = 53135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001F10 RID: 7952 RVA: 0x000915F8 File Offset: 0x0008F7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Relationship relationship, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(relationship);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RelationshipManager.RelationshipUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				relationship = ((intPtr4 == 0) ? null : new Relationship(intPtr4));
			}

			// Token: 0x06001F11 RID: 7953 RVA: 0x0000C938 File Offset: 0x0000AB38
			public RelationshipUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400186B RID: 6251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Relationship_0;

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Relationship_AsyncCallback_Object_0;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Relationship_IAsyncResult_0;
		}
	}
}
