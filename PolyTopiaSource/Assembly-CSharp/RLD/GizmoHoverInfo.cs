using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000028 RID: 40
	[StructLayout(2)]
	public struct GizmoHoverInfo
	{
		// Token: 0x0600028C RID: 652 RVA: 0x0002AEBC File Offset: 0x000290BC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHoverInfo()
		{
			Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHoverInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr);
			GizmoHoverInfo.NativeFieldInfoPtr__isHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, "_isHovered");
			GizmoHoverInfo.NativeFieldInfoPtr__handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, "_handleId");
			GizmoHoverInfo.NativeFieldInfoPtr__handleDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, "_handleDimension");
			GizmoHoverInfo.NativeFieldInfoPtr__hoverPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, "_hoverPoint");
			GizmoHoverInfo.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663670);
			GizmoHoverInfo.NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663671);
			GizmoHoverInfo.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663672);
			GizmoHoverInfo.NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663673);
			GizmoHoverInfo.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663674);
			GizmoHoverInfo.NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663675);
			GizmoHoverInfo.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663676);
			GizmoHoverInfo.NativeMethodInfoPtr_set_HoverPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663677);
			GizmoHoverInfo.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, 100663678);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0002AFF0 File Offset: 0x000291F0
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0002B020 File Offset: 0x00029220
		public unsafe bool IsHovered
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 58106, RefRangeEnd = 58118, XrefRangeStart = 58106, XrefRangeEnd = 58118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0002B054 File Offset: 0x00029254
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0002B084 File Offset: 0x00029284
		public unsafe int HandleId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58118, RefRangeEnd = 58119, XrefRangeStart = 58118, XrefRangeEnd = 58119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0002B0B8 File Offset: 0x000292B8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0002B0EC File Offset: 0x000292EC
		public unsafe GizmoDimension HandleDimension
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58133, RefRangeEnd = 58136, XrefRangeStart = 58133, XrefRangeEnd = 58133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0002B124 File Offset: 0x00029324
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0002B158 File Offset: 0x00029358
		public unsafe Vector3 HoverPoint
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_set_HoverPoint_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0002B190 File Offset: 0x00029390
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58139, RefRangeEnd = 58143, XrefRangeStart = 58136, XrefRangeEnd = 58139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHoverInfo.NativeMethodInfoPtr_Reset_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002EB8 File Offset: 0x000010B8
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoHoverInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr__isHovered;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr__handleId;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr__handleDimension;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr__hoverPoint;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleId_Public_set_Void_Int32_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleDimension_Public_get_GizmoDimension_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleDimension_Public_set_Void_GizmoDimension_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_set_HoverPoint_Public_set_Void_Vector3_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400020E RID: 526
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _isHovered;

		// Token: 0x0400020F RID: 527
		[FieldOffset(4)]
		public int _handleId;

		// Token: 0x04000210 RID: 528
		[FieldOffset(8)]
		public IntPtr _handleDimension;

		// Token: 0x04000211 RID: 529
		[FieldOffset(12)]
		public IntPtr _hoverPoint;
	}
}
