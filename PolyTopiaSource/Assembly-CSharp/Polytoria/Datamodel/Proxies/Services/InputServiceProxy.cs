using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000310 RID: 784
	public class InputServiceProxy : global::Il2CppSystem.Object
	{
		// Token: 0x06004399 RID: 17305 RVA: 0x0012F76C File Offset: 0x0012D96C
		// Note: this type is marked as 'beforefieldinit'.
		static InputServiceProxy()
		{
			Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "InputServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr);
			InputServiceProxy.NativeFieldInfoPtr_inputService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, "inputService");
			InputServiceProxy.NativeFieldInfoPtr_KeyUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, "KeyUp");
			InputServiceProxy.NativeMethodInfoPtr_get_KeyDown_Public_Static_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100673998);
			InputServiceProxy.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100673999);
			InputServiceProxy.NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674000);
			InputServiceProxy.NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674001);
			InputServiceProxy.NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674002);
			InputServiceProxy.NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674003);
			InputServiceProxy.NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674004);
			InputServiceProxy.NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674005);
			InputServiceProxy.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674006);
			InputServiceProxy.NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674007);
			InputServiceProxy.NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674008);
			InputServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_InputService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100673997);
			InputServiceProxy.NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674009);
			InputServiceProxy.NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674010);
			InputServiceProxy.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674011);
			InputServiceProxy.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674012);
			InputServiceProxy.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674013);
			InputServiceProxy.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674014);
			InputServiceProxy.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674015);
			InputServiceProxy.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674016);
			InputServiceProxy.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674017);
			InputServiceProxy.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674018);
			InputServiceProxy.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674019);
			InputServiceProxy.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674020);
			InputServiceProxy.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674021);
			InputServiceProxy.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674022);
			InputServiceProxy.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674023);
			InputServiceProxy.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674024);
			InputServiceProxy.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674025);
			InputServiceProxy.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674026);
			InputServiceProxy.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674027);
			InputServiceProxy.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674028);
			InputServiceProxy.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr, 100674029);
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x0012FA58 File Offset: 0x0012DC58
		public unsafe static LuaEvent KeyDown
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129252, XrefRangeEnd = 129256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_KeyDown_Public_Static_get_LuaEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x0012FA8C File Offset: 0x0012DC8C
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129256, XrefRangeEnd = 129260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x0012FAC0 File Offset: 0x0012DCC0
		// (set) Token: 0x0600439D RID: 17309 RVA: 0x0012FAF0 File Offset: 0x0012DCF0
		public unsafe static bool CursorLocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129260, XrefRangeEnd = 129264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129264, XrefRangeEnd = 129268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x0012FB24 File Offset: 0x0012DD24
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x0012FB54 File Offset: 0x0012DD54
		public unsafe static bool CursorVisible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129268, XrefRangeEnd = 129272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129272, XrefRangeEnd = 129276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x0012FB88 File Offset: 0x0012DD88
		public unsafe static int ScreenWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129276, XrefRangeEnd = 129280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0012FBB8 File Offset: 0x0012DDB8
		public unsafe static int ScreenHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129280, XrefRangeEnd = 129284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x0012FBE8 File Offset: 0x0012DDE8
		public unsafe static bool AnyKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129284, XrefRangeEnd = 129288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0012FC18 File Offset: 0x0012DE18
		public unsafe static bool AnyKeyDown
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129288, XrefRangeEnd = 129292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x0012FC48 File Offset: 0x0012DE48
		public unsafe static bool IsInputFocused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129292, XrefRangeEnd = 129296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x0012FC78 File Offset: 0x0012DE78
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputServiceProxy(InputService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_InputService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x0012FCC4 File Offset: 0x0012DEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129296, XrefRangeEnd = 129300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetMouseWorldPosition()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0012FCF8 File Offset: 0x0012DEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129300, XrefRangeEnd = 129304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetMouseWorldPoint()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x0012FD2C File Offset: 0x0012DF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129304, XrefRangeEnd = 129308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToWorldPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x0012FD70 File Offset: 0x0012DF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129308, XrefRangeEnd = 129312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToViewportPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0012FDB4 File Offset: 0x0012DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129312, XrefRangeEnd = 129316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToScreenPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x0012FDF8 File Offset: 0x0012DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129316, XrefRangeEnd = 129320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToViewportPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0012FE3C File Offset: 0x0012E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129320, XrefRangeEnd = 129324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ViewportToWorldPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0012FE80 File Offset: 0x0012E080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129324, XrefRangeEnd = 129328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ViewportToScreenPoint(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0012FEC4 File Offset: 0x0012E0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129328, XrefRangeEnd = 129332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x0012FF1C File Offset: 0x0012E11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129332, XrefRangeEnd = 129336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0012FF74 File Offset: 0x0012E174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129336, XrefRangeEnd = 129340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x0012FFB8 File Offset: 0x0012E1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129340, XrefRangeEnd = 129344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0012FFFC File Offset: 0x0012E1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129344, XrefRangeEnd = 129348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00130040 File Offset: 0x0012E240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129348, XrefRangeEnd = 129352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00130084 File Offset: 0x0012E284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129352, XrefRangeEnd = 129356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x001300C8 File Offset: 0x0012E2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129356, XrefRangeEnd = 129360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0013010C File Offset: 0x0012E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129360, XrefRangeEnd = 129364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00130150 File Offset: 0x0012E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129364, XrefRangeEnd = 129368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUp(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00130194 File Offset: 0x0012E394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129368, XrefRangeEnd = 129372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x001301D4 File Offset: 0x0012E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129372, XrefRangeEnd = 129376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonDown(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00130214 File Offset: 0x0012E414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129376, XrefRangeEnd = 129380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonUp(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputServiceProxy.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00018EC1 File Offset: 0x000170C1
		public InputServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x00130254 File Offset: 0x0012E454
		// (set) Token: 0x060043BD RID: 17341 RVA: 0x00018ECA File Offset: 0x000170CA
		public unsafe InputService inputService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputServiceProxy.NativeFieldInfoPtr_inputService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputServiceProxy.NativeFieldInfoPtr_inputService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x00130284 File Offset: 0x0012E484
		// (set) Token: 0x060043BF RID: 17343 RVA: 0x00018EE9 File Offset: 0x000170E9
		public unsafe static LuaEvent KeyUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputServiceProxy.NativeFieldInfoPtr_KeyUp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputServiceProxy.NativeFieldInfoPtr_KeyUp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeFieldInfoPtr_inputService;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeFieldInfoPtr_KeyUp;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyDown_Public_Static_get_LuaEvent_0;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeMethodInfoPtr_get_CursorLocked_Public_Static_get_Boolean_0;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeMethodInfoPtr_set_CursorLocked_Public_Static_set_Void_Boolean_0;

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeMethodInfoPtr_get_CursorVisible_Public_Static_get_Boolean_0;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeMethodInfoPtr_set_CursorVisible_Public_Static_set_Void_Boolean_0;

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenWidth_Public_Static_get_Int32_0;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenHeight_Public_Static_get_Int32_0;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Boolean_0;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKeyDown_Public_Static_get_Boolean_0;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputFocused_Public_Static_get_Boolean_0;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputService_0;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseWorldPosition_Public_Static_Vector3_0;

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseWorldPoint_Public_Static_Vector3_0;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_Vector3_Vector3_0;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Nullable_1_RayResult_Vector3_List_1_Instance_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;
	}
}
