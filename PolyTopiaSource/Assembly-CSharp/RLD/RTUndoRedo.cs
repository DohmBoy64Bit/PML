using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x020001FE RID: 510
	public class RTUndoRedo : MonoSingleton<RTUndoRedo>
	{
		// Token: 0x060028E6 RID: 10470 RVA: 0x000C3AAC File Offset: 0x000C1CAC
		// Note: this type is marked as 'beforefieldinit'.
		static RTUndoRedo()
		{
			Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTUndoRedo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr);
			RTUndoRedo.NativeFieldInfoPtr_UndoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "UndoStart");
			RTUndoRedo.NativeFieldInfoPtr_UndoEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "UndoEnd");
			RTUndoRedo.NativeFieldInfoPtr_RedoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "RedoStart");
			RTUndoRedo.NativeFieldInfoPtr_RedoEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "RedoEnd");
			RTUndoRedo.NativeFieldInfoPtr_CanUndoRedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "CanUndoRedo");
			RTUndoRedo.NativeFieldInfoPtr__isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "_isEnabled");
			RTUndoRedo.NativeFieldInfoPtr__actionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "_actionLimit");
			RTUndoRedo.NativeFieldInfoPtr__actionGroupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "_actionGroupStack");
			RTUndoRedo.NativeFieldInfoPtr__stackPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "_stackPointer");
			RTUndoRedo.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669559);
			RTUndoRedo.NativeMethodInfoPtr_get_ActionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669560);
			RTUndoRedo.NativeMethodInfoPtr_set_ActionLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669561);
			RTUndoRedo.NativeMethodInfoPtr_add_UndoStart_Public_add_Void_UndoStartHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669549);
			RTUndoRedo.NativeMethodInfoPtr_remove_UndoStart_Public_rem_Void_UndoStartHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669550);
			RTUndoRedo.NativeMethodInfoPtr_add_UndoEnd_Public_add_Void_UndoEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669551);
			RTUndoRedo.NativeMethodInfoPtr_remove_UndoEnd_Public_rem_Void_UndoEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669552);
			RTUndoRedo.NativeMethodInfoPtr_add_RedoStart_Public_add_Void_RedoStartHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669553);
			RTUndoRedo.NativeMethodInfoPtr_remove_RedoStart_Public_rem_Void_RedoStartHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669554);
			RTUndoRedo.NativeMethodInfoPtr_add_RedoEnd_Public_add_Void_RedoEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669555);
			RTUndoRedo.NativeMethodInfoPtr_remove_RedoEnd_Public_rem_Void_RedoEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669556);
			RTUndoRedo.NativeMethodInfoPtr_add_CanUndoRedo_Public_add_Void_CanUndoRedoHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669557);
			RTUndoRedo.NativeMethodInfoPtr_remove_CanUndoRedo_Public_rem_Void_CanUndoRedoHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669558);
			RTUndoRedo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669570);
			RTUndoRedo.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669562);
			RTUndoRedo.NativeMethodInfoPtr_ClearActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669563);
			RTUndoRedo.NativeMethodInfoPtr_RecordAction_Public_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669564);
			RTUndoRedo.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669565);
			RTUndoRedo.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669566);
			RTUndoRedo.NativeMethodInfoPtr_Redo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669567);
			RTUndoRedo.NativeMethodInfoPtr_RemoveGroups_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669568);
			RTUndoRedo.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, 100669569);
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000C3D48 File Offset: 0x000C1F48
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000C3D84 File Offset: 0x000C1F84
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x000C3DC0 File Offset: 0x000C1FC0
		public unsafe int ActionLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_get_ActionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91013, XrefRangeEnd = 91015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_set_ActionLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000C3E00 File Offset: 0x000C2000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91015, XrefRangeEnd = 91019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UndoStart(UndoStartHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_add_UndoStart_Public_add_Void_UndoStartHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000C3E44 File Offset: 0x000C2044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91019, XrefRangeEnd = 91023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UndoStart(UndoStartHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_remove_UndoStart_Public_rem_Void_UndoStartHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000C3E88 File Offset: 0x000C2088
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91027, RefRangeEnd = 91032, XrefRangeStart = 91023, XrefRangeEnd = 91027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UndoEnd(UndoEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_add_UndoEnd_Public_add_Void_UndoEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000C3ECC File Offset: 0x000C20CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91036, RefRangeEnd = 91039, XrefRangeStart = 91032, XrefRangeEnd = 91036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UndoEnd(UndoEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_remove_UndoEnd_Public_rem_Void_UndoEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000C3F10 File Offset: 0x000C2110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91039, XrefRangeEnd = 91043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RedoStart(RedoStartHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_add_RedoStart_Public_add_Void_RedoStartHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000C3F54 File Offset: 0x000C2154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91043, XrefRangeEnd = 91047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RedoStart(RedoStartHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_remove_RedoStart_Public_rem_Void_RedoStartHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000C3F98 File Offset: 0x000C2198
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91051, RefRangeEnd = 91056, XrefRangeStart = 91047, XrefRangeEnd = 91051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RedoEnd(RedoEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_add_RedoEnd_Public_add_Void_RedoEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000C3FDC File Offset: 0x000C21DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91060, RefRangeEnd = 91063, XrefRangeStart = 91056, XrefRangeEnd = 91060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RedoEnd(RedoEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_remove_RedoEnd_Public_rem_Void_RedoEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000C4020 File Offset: 0x000C2220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91067, RefRangeEnd = 91068, XrefRangeStart = 91063, XrefRangeEnd = 91067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanUndoRedo(CanUndoRedoHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_add_CanUndoRedo_Public_add_Void_CanUndoRedoHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000C4064 File Offset: 0x000C2264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91068, XrefRangeEnd = 91072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanUndoRedo(CanUndoRedoHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_remove_CanUndoRedo_Public_rem_Void_CanUndoRedoHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000C40A8 File Offset: 0x000C22A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91072, XrefRangeEnd = 91085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTUndoRedo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000C40E4 File Offset: 0x000C22E4
		[CallerCount(0)]
		public unsafe void SetEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000C4124 File Offset: 0x000C2324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91085, XrefRangeEnd = 91087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_ClearActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000C4158 File Offset: 0x000C2358
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 91111, RefRangeEnd = 91118, XrefRangeStart = 91087, XrefRangeEnd = 91111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordAction(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_RecordAction_Public_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000C419C File Offset: 0x000C239C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91128, RefRangeEnd = 91129, XrefRangeStart = 91118, XrefRangeEnd = 91128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000C41D0 File Offset: 0x000C23D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91153, RefRangeEnd = 91155, XrefRangeStart = 91129, XrefRangeEnd = 91153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000C4204 File Offset: 0x000C2404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91180, RefRangeEnd = 91182, XrefRangeStart = 91155, XrefRangeEnd = 91180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_Redo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000C4238 File Offset: 0x000C2438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91219, RefRangeEnd = 91224, XrefRangeStart = 91182, XrefRangeEnd = 91219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGroups(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_RemoveGroups_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000C4284 File Offset: 0x000C2484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91224, XrefRangeEnd = 91226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00010246 File Offset: 0x0000E446
		public RTUndoRedo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000C42B8 File Offset: 0x000C24B8
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x0001024F File Offset: 0x0000E44F
		public unsafe UndoStartHandler UndoStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_UndoStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoStartHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_UndoStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000C42E8 File Offset: 0x000C24E8
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x0001026E File Offset: 0x0000E46E
		public unsafe UndoEndHandler UndoEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_UndoEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_UndoEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000C4318 File Offset: 0x000C2518
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x0001028D File Offset: 0x0000E48D
		public unsafe RedoStartHandler RedoStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_RedoStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RedoStartHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_RedoStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000C4348 File Offset: 0x000C2548
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x000102AC File Offset: 0x0000E4AC
		public unsafe RedoEndHandler RedoEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_RedoEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RedoEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_RedoEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000C4378 File Offset: 0x000C2578
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x000102CB File Offset: 0x0000E4CB
		public unsafe CanUndoRedoHandler CanUndoRedo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_CanUndoRedo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanUndoRedoHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr_CanUndoRedo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000C43A8 File Offset: 0x000C25A8
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x000102EA File Offset: 0x0000E4EA
		public unsafe bool _isEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__isEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__isEnabled)) = value;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000C43D0 File Offset: 0x000C25D0
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x00010305 File Offset: 0x0000E505
		public unsafe int _actionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__actionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__actionLimit)) = value;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000C43F8 File Offset: 0x000C25F8
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x00010320 File Offset: 0x0000E520
		public unsafe List<RTUndoRedo.ActionGroup> _actionGroupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__actionGroupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTUndoRedo.ActionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__actionGroupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000C4428 File Offset: 0x000C2628
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x0001033F File Offset: 0x0000E53F
		public unsafe int _stackPointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__stackPointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.NativeFieldInfoPtr__stackPointer)) = value;
			}
		}

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeFieldInfoPtr_UndoStart;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_UndoEnd;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_RedoStart;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeFieldInfoPtr_RedoEnd;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_CanUndoRedo;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr__actionLimit;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr__actionGroupStack;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr__stackPointer;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionLimit_Public_get_Int32_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionLimit_Public_set_Void_Int32_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_add_UndoStart_Public_add_Void_UndoStartHandler_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_remove_UndoStart_Public_rem_Void_UndoStartHandler_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr_add_UndoEnd_Public_add_Void_UndoEndHandler_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_remove_UndoEnd_Public_rem_Void_UndoEndHandler_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_add_RedoStart_Public_add_Void_RedoStartHandler_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_remove_RedoStart_Public_rem_Void_RedoStartHandler_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_add_RedoEnd_Public_add_Void_RedoEndHandler_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_remove_RedoEnd_Public_rem_Void_RedoEndHandler_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_add_CanUndoRedo_Public_add_Void_CanUndoRedoHandler_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanUndoRedo_Public_rem_Void_CanUndoRedoHandler_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_ClearActions_Public_Void_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr_RecordAction_Public_Void_IUndoRedoAction_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Void_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGroups_Private_Void_Int32_Int32_0;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x020003BF RID: 959
		public class ActionGroup : Object
		{
			// Token: 0x06004C4E RID: 19534 RVA: 0x0014D2F4 File Offset: 0x0014B4F4
			// Note: this type is marked as 'beforefieldinit'.
			static ActionGroup()
			{
				Il2CppClassPointerStore<RTUndoRedo.ActionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTUndoRedo>.NativeClassPtr, "ActionGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTUndoRedo.ActionGroup>.NativeClassPtr);
				RTUndoRedo.ActionGroup.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTUndoRedo.ActionGroup>.NativeClassPtr, "Actions");
				RTUndoRedo.ActionGroup.NativeMethodInfoPtr__ctor_Public_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTUndoRedo.ActionGroup>.NativeClassPtr, 100669571);
			}

			// Token: 0x06004C4F RID: 19535 RVA: 0x0014D348 File Offset: 0x0014B548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90999, XrefRangeEnd = 91013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionGroup(IUndoRedoAction action)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTUndoRedo.ActionGroup>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTUndoRedo.ActionGroup.NativeMethodInfoPtr__ctor_Public_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C50 RID: 19536 RVA: 0x0001CA03 File Offset: 0x0001AC03
			public ActionGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019B6 RID: 6582
			// (get) Token: 0x06004C51 RID: 19537 RVA: 0x0014D394 File Offset: 0x0014B594
			// (set) Token: 0x06004C52 RID: 19538 RVA: 0x0001CA0C File Offset: 0x0001AC0C
			public unsafe List<IUndoRedoAction> Actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.ActionGroup.NativeFieldInfoPtr_Actions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IUndoRedoAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTUndoRedo.ActionGroup.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B46 RID: 15174
			private static readonly IntPtr NativeFieldInfoPtr_Actions;

			// Token: 0x04003B47 RID: 15175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IUndoRedoAction_0;
		}
	}
}
