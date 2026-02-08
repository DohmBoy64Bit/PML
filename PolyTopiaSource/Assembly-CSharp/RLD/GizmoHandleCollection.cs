using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000060 RID: 96
	public class GizmoHandleCollection : global::Il2CppSystem.Object
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x0003A078 File Offset: 0x00038278
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandleCollection()
		{
			Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandleCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr);
			GizmoHandleCollection.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, "_gizmo");
			GizmoHandleCollection.NativeFieldInfoPtr__handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, "_handles");
			GizmoHandleCollection.NativeFieldInfoPtr__idToHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, "_idToHandle");
			GizmoHandleCollection.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664236);
			GizmoHandleCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664237);
			GizmoHandleCollection.NativeMethodInfoPtr_get_Item_Public_get_IGizmoHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664238);
			GizmoHandleCollection.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664239);
			GizmoHandleCollection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664240);
			GizmoHandleCollection.NativeMethodInfoPtr_GetHandleById_Public_IGizmoHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664241);
			GizmoHandleCollection.NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664242);
			GizmoHandleCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664243);
			GizmoHandleCollection.NativeMethodInfoPtr_Add_Public_Void_IGizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664244);
			GizmoHandleCollection.NativeMethodInfoPtr_Remove_Public_Void_IGizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664245);
			GizmoHandleCollection.NativeMethodInfoPtr_GetAll_Public_List_1_IGizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664246);
			GizmoHandleCollection.NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr, 100664247);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0003A1D4 File Offset: 0x000383D4
		public unsafe Gizmo Gizmo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0003A214 File Offset: 0x00038414
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61409, XrefRangeEnd = 61410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FF RID: 511
		public unsafe IGizmoHandle this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61410, XrefRangeEnd = 61414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_get_Item_Public_get_IGizmoHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoHandle>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0003A29C File Offset: 0x0003849C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61414, XrefRangeEnd = 61430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleCollection(Gizmo gizmo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0003A2E8 File Offset: 0x000384E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61430, XrefRangeEnd = 61436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0003A31C File Offset: 0x0003851C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61440, RefRangeEnd = 61441, XrefRangeStart = 61436, XrefRangeEnd = 61440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGizmoHandle GetHandleById(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_GetHandleById_Public_IGizmoHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0003A368 File Offset: 0x00038568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61441, XrefRangeEnd = 61448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(IGizmoHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0003A3B8 File Offset: 0x000385B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61448, XrefRangeEnd = 61452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0003A404 File Offset: 0x00038604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61452, XrefRangeEnd = 61471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(IGizmoHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_Add_Public_Void_IGizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0003A448 File Offset: 0x00038648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61471, XrefRangeEnd = 61481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(IGizmoHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_Remove_Public_Void_IGizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0003A48C File Offset: 0x0003868C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61481, XrefRangeEnd = 61487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IGizmoHandle> GetAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_GetAll_Public_List_1_IGizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IGizmoHandle>>(intPtr3) : null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0003A4CC File Offset: 0x000386CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61514, RefRangeEnd = 61516, XrefRangeStart = 61487, XrefRangeEnd = 61514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleCollection.NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoHandleHoverData>>(intPtr3) : null;
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000455A File Offset: 0x0000275A
		public GizmoHandleCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0003A51C File Offset: 0x0003871C
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00004563 File Offset: 0x00002763
		public unsafe Gizmo _gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0003A54C File Offset: 0x0003874C
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00004582 File Offset: 0x00002782
		public unsafe List<IGizmoHandle> _handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGizmoHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0003A57C File Offset: 0x0003877C
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x000045A1 File Offset: 0x000027A1
		public unsafe Dictionary<int, IGizmoHandle> _idToHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__idToHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IGizmoHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleCollection.NativeFieldInfoPtr__idToHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr__gizmo;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr__handles;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr__idToHandle;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IGizmoHandle_Int32_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_GetHandleById_Public_IGizmoHandle_Int32_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoHandle_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_IGizmoHandle_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_IGizmoHandle_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_List_1_IGizmoHandle_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0;
	}
}
