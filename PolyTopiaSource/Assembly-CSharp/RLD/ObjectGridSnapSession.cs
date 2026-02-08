using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D3 RID: 467
	public class ObjectGridSnapSession : global::Il2CppSystem.Object
	{
		// Token: 0x06002425 RID: 9253 RVA: 0x000AFCD0 File Offset: 0x000ADED0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGridSnapSession()
		{
			Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGridSnapSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr);
			ObjectGridSnapSession.NativeFieldInfoPtr_SessionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "SessionBegin");
			ObjectGridSnapSession.NativeFieldInfoPtr_SessionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "SessionEnd");
			ObjectGridSnapSession.NativeFieldInfoPtr__targetParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_targetParents");
			ObjectGridSnapSession.NativeFieldInfoPtr__targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_targetObjects");
			ObjectGridSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_preTargetTransformSnapshots");
			ObjectGridSnapSession.NativeFieldInfoPtr__snapPivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_snapPivotPoint");
			ObjectGridSnapSession.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_state");
			ObjectGridSnapSession.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_sharedHotkeys");
			ObjectGridSnapSession.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, "_sharedLookAndFeel");
			ObjectGridSnapSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668711);
			ObjectGridSnapSession.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668712);
			ObjectGridSnapSession.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGridSnapLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668713);
			ObjectGridSnapSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGridSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668714);
			ObjectGridSnapSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGridSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668715);
			ObjectGridSnapSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGridSnapSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668707);
			ObjectGridSnapSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGridSnapSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668708);
			ObjectGridSnapSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGridSnapSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668709);
			ObjectGridSnapSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGridSnapSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668710);
			ObjectGridSnapSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668725);
			ObjectGridSnapSession.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668716);
			ObjectGridSnapSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668717);
			ObjectGridSnapSession.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668718);
			ObjectGridSnapSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668719);
			ObjectGridSnapSession.NativeMethodInfoPtr_IdentifyTargetParents_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668720);
			ObjectGridSnapSession.NativeMethodInfoPtr_IdentifyTargetObjects_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668721);
			ObjectGridSnapSession.NativeMethodInfoPtr_SelectPivot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668722);
			ObjectGridSnapSession.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668723);
			ObjectGridSnapSession.NativeMethodInfoPtr_Snap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr, 100668724);
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x000AFF30 File Offset: 0x000AE130
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000AFF6C File Offset: 0x000AE16C
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x000AFFAC File Offset: 0x000AE1AC
		public unsafe ObjectGridSnapLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63738, RefRangeEnd = 63739, XrefRangeStart = 63738, XrefRangeEnd = 63739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGridSnapLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x000B0030 File Offset: 0x000AE230
		public unsafe ObjectGridSnapHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGridSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapHotkeys>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88494, RefRangeEnd = 88495, XrefRangeStart = 88493, XrefRangeEnd = 88494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGridSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000B0074 File Offset: 0x000AE274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88499, RefRangeEnd = 88500, XrefRangeStart = 88495, XrefRangeEnd = 88499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionBegin(ObjectGridSnapSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGridSnapSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000B00B8 File Offset: 0x000AE2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88500, XrefRangeEnd = 88504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionBegin(ObjectGridSnapSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGridSnapSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000B00FC File Offset: 0x000AE2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88508, RefRangeEnd = 88509, XrefRangeStart = 88504, XrefRangeEnd = 88508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionEnd(ObjectGridSnapSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGridSnapSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000B0140 File Offset: 0x000AE340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88509, XrefRangeEnd = 88513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionEnd(ObjectGridSnapSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGridSnapSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000B0184 File Offset: 0x000AE384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88526, RefRangeEnd = 88527, XrefRangeStart = 88513, XrefRangeEnd = 88526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGridSnapSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGridSnapSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000B01C0 File Offset: 0x000AE3C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88571, RefRangeEnd = 88572, XrefRangeStart = 88527, XrefRangeEnd = 88571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000B0204 File Offset: 0x000AE404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88595, RefRangeEnd = 88596, XrefRangeStart = 88572, XrefRangeEnd = 88595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000B0248 File Offset: 0x000AE448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88605, RefRangeEnd = 88606, XrefRangeStart = 88596, XrefRangeEnd = 88605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000B027C File Offset: 0x000AE47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88616, RefRangeEnd = 88617, XrefRangeStart = 88606, XrefRangeEnd = 88616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Begin(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000B02CC File Offset: 0x000AE4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88617, XrefRangeEnd = 88623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdentifyTargetParents(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_IdentifyTargetParents_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000B031C File Offset: 0x000AE51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88663, RefRangeEnd = 88664, XrefRangeStart = 88623, XrefRangeEnd = 88663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdentifyTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_IdentifyTargetObjects_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000B036C File Offset: 0x000AE56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88664, XrefRangeEnd = 88720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPivot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_SelectPivot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x000B03A0 File Offset: 0x000AE5A0
		[CallerCount(0)]
		public unsafe ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000B03DC File Offset: 0x000AE5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88768, RefRangeEnd = 88769, XrefRangeStart = 88720, XrefRangeEnd = 88768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGridSnapSession.NativeMethodInfoPtr_Snap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0000ED0E File Offset: 0x0000CF0E
		public ObjectGridSnapSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000B0410 File Offset: 0x000AE610
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x0000ED17 File Offset: 0x0000CF17
		public unsafe ObjectGridSnapSessionBeginHandler SessionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr_SessionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapSessionBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr_SessionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000B0440 File Offset: 0x000AE640
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0000ED36 File Offset: 0x0000CF36
		public unsafe ObjectGridSnapSessionEndHandler SessionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr_SessionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapSessionEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr_SessionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000B0470 File Offset: 0x000AE670
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x0000ED55 File Offset: 0x0000CF55
		public unsafe List<GameObject> _targetParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__targetParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__targetParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000B04A0 File Offset: 0x000AE6A0
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public unsafe List<GameObject> _targetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__targetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000B04D0 File Offset: 0x000AE6D0
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x0000ED93 File Offset: 0x0000CF93
		public unsafe List<LocalTransformSnapshot> _preTargetTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000B0500 File Offset: 0x000AE700
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x0000EDB2 File Offset: 0x0000CFB2
		public unsafe Vector3 _snapPivotPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__snapPivotPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__snapPivotPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000B0530 File Offset: 0x000AE730
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x0000EDD1 File Offset: 0x0000CFD1
		public unsafe ObjectGridSnapSession.State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000B0558 File Offset: 0x000AE758
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		public unsafe ObjectGridSnapHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000B0588 File Offset: 0x000AE788
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0000EE0B File Offset: 0x0000D00B
		public unsafe ObjectGridSnapLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGridSnapSession.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr_SessionBegin;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_SessionEnd;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr__targetParents;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr__targetObjects;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr__preTargetTransformSnapshots;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr__snapPivotPoint;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGridSnapLookAndFeel_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGridSnapHotkeys_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGridSnapHotkeys_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGridSnapSessionBeginHandler_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGridSnapSessionBeginHandler_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGridSnapSessionEndHandler_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGridSnapSessionEndHandler_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyTargetParents_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyTargetObjects_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_SelectPivot_Private_Void_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_Snap_Private_Void_0;

		// Token: 0x020003AE RID: 942
		public enum State
		{
			// Token: 0x04003AE0 RID: 15072
			Inactive,
			// Token: 0x04003AE1 RID: 15073
			SelectPivot,
			// Token: 0x04003AE2 RID: 15074
			Snap
		}
	}
}
