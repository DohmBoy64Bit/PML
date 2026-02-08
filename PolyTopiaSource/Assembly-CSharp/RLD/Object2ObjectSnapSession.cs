using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C6 RID: 454
	public class Object2ObjectSnapSession : global::Il2CppSystem.Object
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x000ABB60 File Offset: 0x000A9D60
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapSession()
		{
			Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr);
			Object2ObjectSnapSession.NativeFieldInfoPtr_SessionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "SessionBegin");
			Object2ObjectSnapSession.NativeFieldInfoPtr_SessionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "SessionEnd");
			Object2ObjectSnapSession.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_state");
			Object2ObjectSnapSession.NativeFieldInfoPtr__targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_targetObjects");
			Object2ObjectSnapSession.NativeFieldInfoPtr__targetParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_targetParents");
			Object2ObjectSnapSession.NativeFieldInfoPtr__targetAABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_targetAABB");
			Object2ObjectSnapSession.NativeFieldInfoPtr__sitSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_sitSurface");
			Object2ObjectSnapSession.NativeFieldInfoPtr__sitBelowSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_sitBelowSurface");
			Object2ObjectSnapSession.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_sharedSettings");
			Object2ObjectSnapSession.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_sharedHotkeys");
			Object2ObjectSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "_preTargetTransformSnapshots");
			Object2ObjectSnapSession.NativeMethodInfoPtr_get_SharedSettings_Public_get_Object2ObjectSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668566);
			Object2ObjectSnapSession.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_Object2ObjectSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668567);
			Object2ObjectSnapSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_Object2ObjectSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668568);
			Object2ObjectSnapSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_Object2ObjectSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668569);
			Object2ObjectSnapSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668570);
			Object2ObjectSnapSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_Object2ObjectSnapSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668562);
			Object2ObjectSnapSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_Object2ObjectSnapSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668563);
			Object2ObjectSnapSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_Object2ObjectSnapSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668564);
			Object2ObjectSnapSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_Object2ObjectSnapSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668565);
			Object2ObjectSnapSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668577);
			Object2ObjectSnapSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668571);
			Object2ObjectSnapSession.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668572);
			Object2ObjectSnapSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668573);
			Object2ObjectSnapSession.NativeMethodInfoPtr_SnapTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668574);
			Object2ObjectSnapSession.NativeMethodInfoPtr_CalculateTargetAABB_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668575);
			Object2ObjectSnapSession.NativeMethodInfoPtr_IdentifySitSurface_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, 100668576);
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000ABDAC File Offset: 0x000A9FAC
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x000ABDEC File Offset: 0x000A9FEC
		public unsafe Object2ObjectSnapSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_get_SharedSettings_Public_get_Object2ObjectSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSettings>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87553, RefRangeEnd = 87554, XrefRangeStart = 87552, XrefRangeEnd = 87553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_Object2ObjectSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000ABE30 File Offset: 0x000AA030
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x000ABE70 File Offset: 0x000AA070
		public unsafe Object2ObjectSnapHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_Object2ObjectSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapHotkeys>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87555, RefRangeEnd = 87556, XrefRangeStart = 87554, XrefRangeEnd = 87555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_Object2ObjectSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000ABEB4 File Offset: 0x000AA0B4
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000ABEF0 File Offset: 0x000AA0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87560, RefRangeEnd = 87561, XrefRangeStart = 87556, XrefRangeEnd = 87560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionBegin(Object2ObjectSnapSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_Object2ObjectSnapSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000ABF34 File Offset: 0x000AA134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87561, XrefRangeEnd = 87565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionBegin(Object2ObjectSnapSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_Object2ObjectSnapSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000ABF78 File Offset: 0x000AA178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87569, RefRangeEnd = 87570, XrefRangeStart = 87565, XrefRangeEnd = 87569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionEnd(Object2ObjectSnapSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_Object2ObjectSnapSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000ABFBC File Offset: 0x000AA1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87570, XrefRangeEnd = 87574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionEnd(Object2ObjectSnapSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_Object2ObjectSnapSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000AC000 File Offset: 0x000AA200
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x000AC03C File Offset: 0x000AA23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87599, RefRangeEnd = 87600, XrefRangeStart = 87574, XrefRangeEnd = 87599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000AC080 File Offset: 0x000AA280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87609, RefRangeEnd = 87611, XrefRangeStart = 87600, XrefRangeEnd = 87609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87629, RefRangeEnd = 87630, XrefRangeStart = 87611, XrefRangeEnd = 87629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Begin(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000AC104 File Offset: 0x000AA304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87683, RefRangeEnd = 87684, XrefRangeStart = 87630, XrefRangeEnd = 87683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_SnapTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000AC138 File Offset: 0x000AA338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87688, RefRangeEnd = 87690, XrefRangeStart = 87684, XrefRangeEnd = 87688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CalculateTargetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_CalculateTargetAABB_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000AC174 File Offset: 0x000AA374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87741, RefRangeEnd = 87743, XrefRangeStart = 87690, XrefRangeEnd = 87741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdentifySitSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSession.NativeMethodInfoPtr_IdentifySitSurface_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0000E484 File Offset: 0x0000C684
		public Object2ObjectSnapSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000AC1B0 File Offset: 0x000AA3B0
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0000E48D File Offset: 0x0000C68D
		public unsafe Object2ObjectSnapSessionBeginHandler SessionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr_SessionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSessionBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr_SessionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000AC1E0 File Offset: 0x000AA3E0
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		public unsafe Object2ObjectSnapSessionEndHandler SessionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr_SessionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSessionEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr_SessionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000AC210 File Offset: 0x000AA410
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0000E4CB File Offset: 0x0000C6CB
		public unsafe Object2ObjectSnapSession.State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000AC238 File Offset: 0x000AA438
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x0000E4E6 File Offset: 0x0000C6E6
		public unsafe List<GameObject> _targetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000AC268 File Offset: 0x000AA468
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x0000E505 File Offset: 0x0000C705
		public unsafe List<GameObject> _targetParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000AC298 File Offset: 0x000AA498
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x0000E524 File Offset: 0x0000C724
		public unsafe AABB _targetAABB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetAABB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__targetAABB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000AC2C8 File Offset: 0x000AA4C8
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x0000E543 File Offset: 0x0000C743
		public unsafe Object2ObjectSnapSession.SitSurface _sitSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sitSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sitSurface)) = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x0000E55E File Offset: 0x0000C75E
		public unsafe bool _sitBelowSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sitBelowSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sitBelowSurface)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000AC318 File Offset: 0x000AA518
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x0000E579 File Offset: 0x0000C779
		public unsafe Object2ObjectSnapSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000AC348 File Offset: 0x000AA548
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x0000E598 File Offset: 0x0000C798
		public unsafe Object2ObjectSnapHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000AC378 File Offset: 0x000AA578
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		public unsafe List<LocalTransformSnapshot> _preTargetTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSession.NativeFieldInfoPtr__preTargetTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_SessionBegin;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_SessionEnd;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeFieldInfoPtr__targetObjects;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr__targetParents;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr__targetAABB;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr__sitSurface;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr__sitBelowSurface;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeFieldInfoPtr__preTargetTransformSnapshots;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_Object2ObjectSnapSettings_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_Object2ObjectSnapSettings_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_Object2ObjectSnapHotkeys_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_Object2ObjectSnapHotkeys_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_Object2ObjectSnapSessionBeginHandler_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_Object2ObjectSnapSessionBeginHandler_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_Object2ObjectSnapSessionEndHandler_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_Object2ObjectSnapSessionEndHandler_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_SnapTargets_Private_Void_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTargetAABB_Private_Boolean_0;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_IdentifySitSurface_Private_Boolean_0;

		// Token: 0x020003A7 RID: 935
		public enum State
		{
			// Token: 0x04003AB3 RID: 15027
			Inactive,
			// Token: 0x04003AB4 RID: 15028
			Active
		}

		// Token: 0x020003A8 RID: 936
		public enum SitSurfaceType
		{
			// Token: 0x04003AB6 RID: 15030
			Invalid,
			// Token: 0x04003AB7 RID: 15031
			Grid,
			// Token: 0x04003AB8 RID: 15032
			Object
		}

		// Token: 0x020003A9 RID: 937
		[StructLayout(2)]
		public struct SitSurface
		{
			// Token: 0x06004BC6 RID: 19398 RVA: 0x0014B928 File Offset: 0x00149B28
			// Note: this type is marked as 'beforefieldinit'.
			static SitSurface()
			{
				Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnapSession>.NativeClassPtr, "SitSurface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr);
				Object2ObjectSnapSession.SitSurface.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr, "SurfaceType");
				Object2ObjectSnapSession.SitSurface.NativeFieldInfoPtr_SitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr, "SitPoint");
				Object2ObjectSnapSession.SitSurface.NativeFieldInfoPtr_SitPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr, "SitPlane");
			}

			// Token: 0x06004BC7 RID: 19399 RVA: 0x0001C5F1 File Offset: 0x0001A7F1
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Object2ObjectSnapSession.SitSurface>.NativeClassPtr, ref this));
			}

			// Token: 0x04003AB9 RID: 15033
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

			// Token: 0x04003ABA RID: 15034
			private static readonly IntPtr NativeFieldInfoPtr_SitPoint;

			// Token: 0x04003ABB RID: 15035
			private static readonly IntPtr NativeFieldInfoPtr_SitPlane;

			// Token: 0x04003ABC RID: 15036
			[FieldOffset(0)]
			public Object2ObjectSnapSession.SitSurfaceType SurfaceType;

			// Token: 0x04003ABD RID: 15037
			[FieldOffset(4)]
			public IntPtr SitPoint;

			// Token: 0x04003ABE RID: 15038
			[FieldOffset(16)]
			public IntPtr SitPlane;
		}
	}
}
