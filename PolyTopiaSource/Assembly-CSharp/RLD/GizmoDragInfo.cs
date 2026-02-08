using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000025 RID: 37
	[StructLayout(2)]
	public struct GizmoDragInfo
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0002A728 File Offset: 0x00028928
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoDragInfo()
		{
			Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoDragInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr);
			GizmoDragInfo.NativeFieldInfoPtr__isDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_isDragged");
			GizmoDragInfo.NativeFieldInfoPtr__handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_handleId");
			GizmoDragInfo.NativeFieldInfoPtr__dragBeginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_dragBeginPoint");
			GizmoDragInfo.NativeFieldInfoPtr__dragChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_dragChannel");
			GizmoDragInfo.NativeFieldInfoPtr__handleDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_handleDimension");
			GizmoDragInfo.NativeFieldInfoPtr__totalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_totalOffset");
			GizmoDragInfo.NativeFieldInfoPtr__totalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_totalRotation");
			GizmoDragInfo.NativeFieldInfoPtr__totalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_totalScale");
			GizmoDragInfo.NativeFieldInfoPtr__relativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_relativeOffset");
			GizmoDragInfo.NativeFieldInfoPtr__relativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_relativeRotation");
			GizmoDragInfo.NativeFieldInfoPtr__relativeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, "_relativeScale");
			GizmoDragInfo.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663647);
			GizmoDragInfo.NativeMethodInfoPtr_set_IsDragged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663648);
			GizmoDragInfo.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663649);
			GizmoDragInfo.NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663650);
			GizmoDragInfo.NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663651);
			GizmoDragInfo.NativeMethodInfoPtr_set_DragBeginPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663652);
			GizmoDragInfo.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663653);
			GizmoDragInfo.NativeMethodInfoPtr_set_DragChannel_Public_set_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663654);
			GizmoDragInfo.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663655);
			GizmoDragInfo.NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663656);
			GizmoDragInfo.NativeMethodInfoPtr_get_TotalOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663657);
			GizmoDragInfo.NativeMethodInfoPtr_set_TotalOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663658);
			GizmoDragInfo.NativeMethodInfoPtr_get_TotalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663659);
			GizmoDragInfo.NativeMethodInfoPtr_set_TotalRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663660);
			GizmoDragInfo.NativeMethodInfoPtr_get_TotalScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663661);
			GizmoDragInfo.NativeMethodInfoPtr_set_TotalScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663662);
			GizmoDragInfo.NativeMethodInfoPtr_get_RelativeOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663663);
			GizmoDragInfo.NativeMethodInfoPtr_set_RelativeOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663664);
			GizmoDragInfo.NativeMethodInfoPtr_get_RelativeRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663665);
			GizmoDragInfo.NativeMethodInfoPtr_set_RelativeRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663666);
			GizmoDragInfo.NativeMethodInfoPtr_get_RelativeScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663667);
			GizmoDragInfo.NativeMethodInfoPtr_set_RelativeScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663668);
			GizmoDragInfo.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, 100663669);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0002AA00 File Offset: 0x00028C00
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0002AA30 File Offset: 0x00028C30
		public unsafe bool IsDragged
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 58106, RefRangeEnd = 58118, XrefRangeStart = 58106, XrefRangeEnd = 58106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_IsDragged_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002AA64 File Offset: 0x00028C64
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0002AA94 File Offset: 0x00028C94
		public unsafe int HandleId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58118, RefRangeEnd = 58119, XrefRangeStart = 58118, XrefRangeEnd = 58118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0002AAFC File Offset: 0x00028CFC
		public unsafe Vector3 DragBeginPoint
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_DragBeginPoint_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0002AB34 File Offset: 0x00028D34
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0002AB68 File Offset: 0x00028D68
		public unsafe GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_DragChannel_Public_set_Void_GizmoDragChannel_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0002ABA0 File Offset: 0x00028DA0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		public unsafe GizmoDimension HandleDimension
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0002AC0C File Offset: 0x00028E0C
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0002AC40 File Offset: 0x00028E40
		public unsafe Vector3 TotalOffset
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_TotalOffset_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_TotalOffset_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0002AC78 File Offset: 0x00028E78
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0002ACAC File Offset: 0x00028EAC
		public unsafe Quaternion TotalRotation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_TotalRotation_Public_get_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_TotalRotation_Public_set_Void_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0002ACE4 File Offset: 0x00028EE4
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0002AD18 File Offset: 0x00028F18
		public unsafe Vector3 TotalScale
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_TotalScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_TotalScale_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0002AD50 File Offset: 0x00028F50
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0002AD84 File Offset: 0x00028F84
		public unsafe Vector3 RelativeOffset
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_RelativeOffset_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_RelativeOffset_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0002ADBC File Offset: 0x00028FBC
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0002ADF0 File Offset: 0x00028FF0
		public unsafe Quaternion RelativeRotation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_RelativeRotation_Public_get_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_RelativeRotation_Public_set_Void_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0002AE28 File Offset: 0x00029028
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0002AE5C File Offset: 0x0002905C
		public unsafe Vector3 RelativeScale
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_get_RelativeScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_set_RelativeScale_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0002AE94 File Offset: 0x00029094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58131, RefRangeEnd = 58133, XrefRangeStart = 58122, XrefRangeEnd = 58131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragInfo.NativeMethodInfoPtr_Reset_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002EA6 File Offset: 0x000010A6
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoDragInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr__isDragged;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr__handleId;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr__dragBeginPoint;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr__dragChannel;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr__handleDimension;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr__totalOffset;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr__totalRotation;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr__totalScale;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr__relativeOffset;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr__relativeRotation;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr__relativeScale;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDragged_Public_set_Void_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_set_DragBeginPoint_Public_set_Void_Vector3_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_set_DragChannel_Public_set_Void_GizmoDragChannel_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalOffset_Public_get_Vector3_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalOffset_Public_set_Void_Vector3_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalRotation_Public_get_Quaternion_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalScale_Public_get_Vector3_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalScale_Public_set_Void_Vector3_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeOffset_Public_get_Vector3_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativeOffset_Public_set_Void_Vector3_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeRotation_Public_get_Quaternion_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativeRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeScale_Public_get_Vector3_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativeScale_Public_set_Void_Vector3_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040001EF RID: 495
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _isDragged;

		// Token: 0x040001F0 RID: 496
		[FieldOffset(4)]
		public int _handleId;

		// Token: 0x040001F1 RID: 497
		[FieldOffset(8)]
		public IntPtr _dragBeginPoint;

		// Token: 0x040001F2 RID: 498
		[FieldOffset(20)]
		public IntPtr _dragChannel;

		// Token: 0x040001F3 RID: 499
		[FieldOffset(24)]
		public IntPtr _handleDimension;

		// Token: 0x040001F4 RID: 500
		[FieldOffset(28)]
		public IntPtr _totalOffset;

		// Token: 0x040001F5 RID: 501
		[FieldOffset(40)]
		public IntPtr _totalRotation;

		// Token: 0x040001F6 RID: 502
		[FieldOffset(56)]
		public IntPtr _totalScale;

		// Token: 0x040001F7 RID: 503
		[FieldOffset(68)]
		public IntPtr _relativeOffset;

		// Token: 0x040001F8 RID: 504
		[FieldOffset(80)]
		public IntPtr _relativeRotation;

		// Token: 0x040001F9 RID: 505
		[FieldOffset(96)]
		public IntPtr _relativeScale;
	}
}
