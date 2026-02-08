using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000216 RID: 534
	public class MultiSelectShape : global::Il2CppSystem.Object
	{
		// Token: 0x060029ED RID: 10733 RVA: 0x000C75FC File Offset: 0x000C57FC
		// Note: this type is marked as 'beforefieldinit'.
		static MultiSelectShape()
		{
			Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MultiSelectShape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr);
			MultiSelectShape.NativeFieldInfoPtr__enclosingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, "_enclosingRect");
			MultiSelectShape.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, "_isVisible");
			MultiSelectShape.NativeFieldInfoPtr__minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, "_minSize");
			MultiSelectShape.NativeMethodInfoPtr_get_EnclosingRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669703);
			MultiSelectShape.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669704);
			MultiSelectShape.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669705);
			MultiSelectShape.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669706);
			MultiSelectShape.NativeMethodInfoPtr_set_MinSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669707);
			MultiSelectShape.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669714);
			MultiSelectShape.NativeMethodInfoPtr_SetEnclosingRectTopLeftPoint_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669708);
			MultiSelectShape.NativeMethodInfoPtr_SetEnclosingRectBottomRightPoint_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669709);
			MultiSelectShape.NativeMethodInfoPtr_GetOverlappedObjects_Public_Void_List_1_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669710);
			MultiSelectShape.NativeMethodInfoPtr_OverlapsObject_Public_Boolean_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669711);
			MultiSelectShape.NativeMethodInfoPtr_Render_Public_Void_Color_Color_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669712);
			MultiSelectShape.NativeMethodInfoPtr_IsBigEnoughForOverlap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr, 100669713);
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x000C7758 File Offset: 0x000C5958
		public unsafe Rect EnclosingRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_get_EnclosingRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000C7798 File Offset: 0x000C5998
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000C77D4 File Offset: 0x000C59D4
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000C7814 File Offset: 0x000C5A14
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000C7850 File Offset: 0x000C5A50
		public unsafe int MinSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_set_MinSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000C7890 File Offset: 0x000C5A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93139, XrefRangeEnd = 93140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiSelectShape()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiSelectShape>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000C78CC File Offset: 0x000C5ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93140, XrefRangeEnd = 93146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnclosingRectTopLeftPoint(Vector2 topLeftPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(topLeftPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_SetEnclosingRectTopLeftPoint_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000C7910 File Offset: 0x000C5B10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93152, RefRangeEnd = 93155, XrefRangeStart = 93146, XrefRangeEnd = 93152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnclosingRectBottomRightPoint(Vector2 bottomRightPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bottomRightPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_SetEnclosingRectBottomRightPoint_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000C7954 File Offset: 0x000C5B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93210, RefRangeEnd = 93211, XrefRangeStart = 93155, XrefRangeEnd = 93210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOverlappedObjects(List<GameObject> gameObjects, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode, List<GameObject> overlappedObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsQConfig;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overlapMode);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overlappedObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_GetOverlappedObjects_Public_Void_List_1_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000C79DC File Offset: 0x000C5BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93219, RefRangeEnd = 93220, XrefRangeStart = 93211, XrefRangeEnd = 93219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapsObject(GameObject gameObject, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsQConfig;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overlapMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_OverlapsObject_Public_Boolean_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000C7A5C File Offset: 0x000C5C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93220, XrefRangeEnd = 93234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Color fillColor, Color borderColor, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillColor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(borderColor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_Render_Public_Void_Color_Color_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000C7AC4 File Offset: 0x000C5CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93238, RefRangeEnd = 93240, XrefRangeStart = 93234, XrefRangeEnd = 93238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBigEnoughForOverlap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiSelectShape.NativeMethodInfoPtr_IsBigEnoughForOverlap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000108AE File Offset: 0x0000EAAE
		public MultiSelectShape(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x000C7B00 File Offset: 0x000C5D00
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x000108B7 File Offset: 0x0000EAB7
		public unsafe Rect _enclosingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__enclosingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__enclosingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000C7B30 File Offset: 0x000C5D30
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x000108D6 File Offset: 0x0000EAD6
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000C7B58 File Offset: 0x000C5D58
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x000108F1 File Offset: 0x0000EAF1
		public unsafe int _minSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__minSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiSelectShape.NativeFieldInfoPtr__minSize)) = value;
			}
		}

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr__enclosingRect;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeFieldInfoPtr__minSize;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_get_EnclosingRect_Public_get_Rect_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr_set_MinSize_Public_set_Void_Int32_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr_SetEnclosingRectTopLeftPoint_Public_Void_Vector2_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_SetEnclosingRectBottomRightPoint_Public_Void_Vector2_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr_GetOverlappedObjects_Public_Void_List_1_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_List_1_GameObject_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_OverlapsObject_Public_Boolean_GameObject_Camera_QueryConfig_MultiSelectOverlapMode_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Color_Color_Camera_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_IsBigEnoughForOverlap_Private_Boolean_0;
	}
}
