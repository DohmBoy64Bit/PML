using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CA RID: 714
	public class InputService : global::Il2CppSystem.Object
	{
		// Token: 0x06003F06 RID: 16134 RVA: 0x0011AD44 File Offset: 0x00118F44
		// Note: this type is marked as 'beforefieldinit'.
		static InputService()
		{
			Il2CppClassPointerStore<InputService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "InputService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputService>.NativeClassPtr);
			InputService.NativeFieldInfoPtr_KeyDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputService>.NativeClassPtr, "KeyDown");
			InputService.NativeFieldInfoPtr_KeyUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputService>.NativeClassPtr, "KeyUp");
			InputService.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673017);
			InputService.NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673018);
			InputService.NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673019);
			InputService.NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673020);
			InputService.NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673021);
			InputService.NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673022);
			InputService.NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673023);
			InputService.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673024);
			InputService.NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673025);
			InputService.NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673026);
			InputService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673048);
			InputService.NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673027);
			InputService.NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673028);
			InputService.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673029);
			InputService.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673030);
			InputService.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673031);
			InputService.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673032);
			InputService.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673033);
			InputService.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673034);
			InputService.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673035);
			InputService.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673036);
			InputService.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673037);
			InputService.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673038);
			InputService.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673039);
			InputService.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673040);
			InputService.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673041);
			InputService.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673042);
			InputService.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673043);
			InputService.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673044);
			InputService.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673045);
			InputService.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673046);
			InputService.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputService>.NativeClassPtr, 100673047);
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x0011B01C File Offset: 0x0011921C
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78623, RefRangeEnd = 78624, XrefRangeStart = 78623, XrefRangeEnd = 78624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x0011B050 File Offset: 0x00119250
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x0011B080 File Offset: 0x00119280
		public unsafe static bool CursorLocked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125070, RefRangeEnd = 125071, XrefRangeStart = 125069, XrefRangeEnd = 125070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125072, RefRangeEnd = 125073, XrefRangeStart = 125071, XrefRangeEnd = 125072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x0011B0B4 File Offset: 0x001192B4
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x0011B0E4 File Offset: 0x001192E4
		public unsafe static bool CursorVisible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125074, RefRangeEnd = 125075, XrefRangeStart = 125073, XrefRangeEnd = 125074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125076, RefRangeEnd = 125077, XrefRangeStart = 125075, XrefRangeEnd = 125076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x0011B118 File Offset: 0x00119318
		public unsafe static int ScreenWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125078, RefRangeEnd = 125079, XrefRangeStart = 125077, XrefRangeEnd = 125078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x0011B148 File Offset: 0x00119348
		public unsafe static int ScreenHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125080, RefRangeEnd = 125081, XrefRangeStart = 125079, XrefRangeEnd = 125080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x0011B178 File Offset: 0x00119378
		public unsafe static bool AnyKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125082, RefRangeEnd = 125083, XrefRangeStart = 125081, XrefRangeEnd = 125082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0011B1A8 File Offset: 0x001193A8
		public unsafe static bool AnyKeyDown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125084, RefRangeEnd = 125085, XrefRangeStart = 125083, XrefRangeEnd = 125084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0011B1D8 File Offset: 0x001193D8
		public unsafe static bool IsInputFocused
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 125106, RefRangeEnd = 125115, XrefRangeStart = 125085, XrefRangeEnd = 125106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0011B208 File Offset: 0x00119408
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0011B244 File Offset: 0x00119444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125130, RefRangeEnd = 125131, XrefRangeStart = 125115, XrefRangeEnd = 125130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetMouseWorldPosition()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0011B278 File Offset: 0x00119478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125134, RefRangeEnd = 125135, XrefRangeStart = 125131, XrefRangeEnd = 125134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetMouseWorldPoint()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x0011B2AC File Offset: 0x001194AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125137, RefRangeEnd = 125138, XrefRangeStart = 125135, XrefRangeEnd = 125137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToWorldPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0011B2F0 File Offset: 0x001194F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125140, RefRangeEnd = 125141, XrefRangeStart = 125138, XrefRangeEnd = 125140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToViewportPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0011B334 File Offset: 0x00119534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125143, RefRangeEnd = 125144, XrefRangeStart = 125141, XrefRangeEnd = 125143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToScreenPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0011B378 File Offset: 0x00119578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125146, RefRangeEnd = 125147, XrefRangeStart = 125144, XrefRangeEnd = 125146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToViewportPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0011B3BC File Offset: 0x001195BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125149, RefRangeEnd = 125150, XrefRangeStart = 125147, XrefRangeEnd = 125149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ViewportToWorldPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0011B400 File Offset: 0x00119600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125152, RefRangeEnd = 125153, XrefRangeStart = 125150, XrefRangeEnd = 125152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ViewportToScreenPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0011B444 File Offset: 0x00119644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125200, RefRangeEnd = 125201, XrefRangeStart = 125153, XrefRangeEnd = 125200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<RayResult> ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0011B49C File Offset: 0x0011969C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125248, RefRangeEnd = 125249, XrefRangeStart = 125201, XrefRangeEnd = 125248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<RayResult> ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0011B4F4 File Offset: 0x001196F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125250, RefRangeEnd = 125251, XrefRangeStart = 125249, XrefRangeEnd = 125250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0011B538 File Offset: 0x00119738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125252, RefRangeEnd = 125253, XrefRangeStart = 125251, XrefRangeEnd = 125252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x0011B57C File Offset: 0x0011977C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125254, RefRangeEnd = 125255, XrefRangeStart = 125253, XrefRangeEnd = 125254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0011B5C0 File Offset: 0x001197C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125256, RefRangeEnd = 125257, XrefRangeStart = 125255, XrefRangeEnd = 125256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0011B604 File Offset: 0x00119804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125258, RefRangeEnd = 125259, XrefRangeStart = 125257, XrefRangeEnd = 125258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0011B648 File Offset: 0x00119848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125260, RefRangeEnd = 125261, XrefRangeStart = 125259, XrefRangeEnd = 125260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0011B68C File Offset: 0x0011988C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125262, RefRangeEnd = 125263, XrefRangeStart = 125261, XrefRangeEnd = 125262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0011B6D0 File Offset: 0x001198D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125264, RefRangeEnd = 125265, XrefRangeStart = 125263, XrefRangeEnd = 125264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUp(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0011B714 File Offset: 0x00119914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125266, RefRangeEnd = 125267, XrefRangeStart = 125265, XrefRangeEnd = 125266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0011B754 File Offset: 0x00119954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125268, RefRangeEnd = 125269, XrefRangeStart = 125267, XrefRangeEnd = 125268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonDown(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0011B794 File Offset: 0x00119994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125270, RefRangeEnd = 125271, XrefRangeStart = 125269, XrefRangeEnd = 125270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonUp(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputService.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x000182C2 File Offset: 0x000164C2
		public InputService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x0011B7D4 File Offset: 0x001199D4
		// (set) Token: 0x06003F29 RID: 16169 RVA: 0x000182CB File Offset: 0x000164CB
		public unsafe static LuaEvent KeyDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputService.NativeFieldInfoPtr_KeyDown, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputService.NativeFieldInfoPtr_KeyDown, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x0011B7FC File Offset: 0x001199FC
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x000182DD File Offset: 0x000164DD
		public unsafe static LuaEvent KeyUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputService.NativeFieldInfoPtr_KeyUp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputService.NativeFieldInfoPtr_KeyUp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeFieldInfoPtr_KeyDown;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeFieldInfoPtr_KeyUp;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;
	}
}
