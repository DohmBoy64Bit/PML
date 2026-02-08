using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C2 RID: 450
	public class InputDeviceScreenDragSession : global::Il2CppSystem.Object
	{
		// Token: 0x060022BB RID: 8891 RVA: 0x000AB0C0 File Offset: 0x000A92C0
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceScreenDragSession()
		{
			Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "InputDeviceScreenDragSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr);
			InputDeviceScreenDragSession.NativeFieldInfoPtr__dragPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, "_dragPoint");
			InputDeviceScreenDragSession.NativeFieldInfoPtr__dragDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, "_dragDelta");
			InputDeviceScreenDragSession.NativeFieldInfoPtr__accumDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, "_accumDrag");
			InputDeviceScreenDragSession.NativeFieldInfoPtr__inputDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, "_inputDevice");
			InputDeviceScreenDragSession.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, "_isActive");
			InputDeviceScreenDragSession.NativeMethodInfoPtr_get_DragPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668540);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_get_DragDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668541);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668542);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668543);
			InputDeviceScreenDragSession.NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668544);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_Begin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668545);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668546);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_Update_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668547);
			InputDeviceScreenDragSession.NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr, 100668548);
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000AB208 File Offset: 0x000A9408
		public unsafe Vector2 DragPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_get_DragPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000AB248 File Offset: 0x000A9448
		public unsafe Vector2 DragDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_get_DragDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000AB288 File Offset: 0x000A9488
		public unsafe Vector2 AccumDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000AB2C8 File Offset: 0x000A94C8
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000AB304 File Offset: 0x000A9504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87504, RefRangeEnd = 87506, XrefRangeStart = 87502, XrefRangeEnd = 87504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceScreenDragSession(IInputDevice inputDevice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceScreenDragSession>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000AB350 File Offset: 0x000A9550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87507, RefRangeEnd = 87508, XrefRangeStart = 87506, XrefRangeEnd = 87507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_Begin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000AB38C File Offset: 0x000A958C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87514, RefRangeEnd = 87515, XrefRangeStart = 87508, XrefRangeEnd = 87514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000AB3C0 File Offset: 0x000A95C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87516, RefRangeEnd = 87517, XrefRangeStart = 87515, XrefRangeEnd = 87516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_Update_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000AB3FC File Offset: 0x000A95FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87520, RefRangeEnd = 87522, XrefRangeStart = 87517, XrefRangeEnd = 87520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateDragPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceScreenDragSession.NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		public InputDeviceScreenDragSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x000AB438 File Offset: 0x000A9638
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0000E308 File Offset: 0x0000C508
		public unsafe Vector2 _dragPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__dragPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__dragPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x000AB468 File Offset: 0x000A9668
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0000E327 File Offset: 0x0000C527
		public unsafe Vector2 _dragDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__dragDelta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__dragDelta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x000AB498 File Offset: 0x000A9698
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x0000E346 File Offset: 0x0000C546
		public unsafe Vector2 _accumDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__accumDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__accumDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x000AB4C8 File Offset: 0x000A96C8
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x0000E365 File Offset: 0x0000C565
		public unsafe IInputDevice _inputDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__inputDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__inputDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0000E384 File Offset: 0x0000C584
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceScreenDragSession.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeFieldInfoPtr__dragPoint;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeFieldInfoPtr__dragDelta;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr__accumDrag;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr__inputDevice;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_get_DragPoint_Public_get_Vector2_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_get_DragDelta_Public_get_Vector2_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector2_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Boolean_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Boolean_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0;
	}
}
