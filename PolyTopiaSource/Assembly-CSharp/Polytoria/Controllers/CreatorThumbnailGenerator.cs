using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000341 RID: 833
	public class CreatorThumbnailGenerator : MonoBehaviour
	{
		// Token: 0x0600485E RID: 18526 RVA: 0x001406F4 File Offset: 0x0013E8F4
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorThumbnailGenerator()
		{
			Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "CreatorThumbnailGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr);
			CreatorThumbnailGenerator.NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "preview");
			CreatorThumbnailGenerator.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "width");
			CreatorThumbnailGenerator.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "height");
			CreatorThumbnailGenerator.NativeFieldInfoPtr__padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "_padding");
			CreatorThumbnailGenerator.NativeFieldInfoPtr_thumbnailCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "thumbnailCamera");
			CreatorThumbnailGenerator.NativeFieldInfoPtr_oldLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, "oldLayers");
			CreatorThumbnailGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674871);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_GenerateThumbnail_Public_Texture2D_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674864);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_SetLayer_Private_Void_Instance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674865);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_PositionCamera_Public_Void_Camera_Bounds_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674866);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_FindClosestPointsOnTwoLines_Private_Static_Void_Ray_Ray_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674867);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_GetPlanesIntersection_Private_Static_Ray_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674868);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_IsOutermostPointInDirection_Private_Static_Boolean_Int32_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674869);
			CreatorThumbnailGenerator.NativeMethodInfoPtr_TestRender_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr, 100674870);
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x0014083C File Offset: 0x0013EA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143315, XrefRangeEnd = 143323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorThumbnailGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorThumbnailGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00140878 File Offset: 0x0013EA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143377, RefRangeEnd = 143378, XrefRangeStart = 143323, XrefRangeEnd = 143377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GenerateThumbnail(Instance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_GenerateThumbnail_Public_Texture2D_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x001408C8 File Offset: 0x0013EAC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143400, RefRangeEnd = 143403, XrefRangeStart = 143378, XrefRangeEnd = 143400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayer(Instance i, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_SetLayer_Private_Void_Instance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00140918 File Offset: 0x0013EB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143441, RefRangeEnd = 143442, XrefRangeStart = 143403, XrefRangeEnd = 143441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionCamera(global::UnityEngine.Camera camera, Bounds bounds, float padding = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_PositionCamera_Public_Void_Camera_Bounds_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x0014097C File Offset: 0x0013EB7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143442, RefRangeEnd = 143443, XrefRangeStart = 143442, XrefRangeEnd = 143442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindClosestPointsOnTwoLines(Ray line1, Ray line2, out Vector3 closestPointLine1, out Vector3 closestPointLine2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(line1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(line2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPointLine1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPointLine2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_FindClosestPointsOnTwoLines_Private_Static_Void_Ray_Ray_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x001409E0 File Offset: 0x0013EBE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143445, RefRangeEnd = 143447, XrefRangeStart = 143443, XrefRangeEnd = 143445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ray GetPlanesIntersection(Plane p1, Plane p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_GetPlanesIntersection_Private_Static_Ray_Plane_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00140A38 File Offset: 0x0013EC38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143448, RefRangeEnd = 143452, XrefRangeStart = 143447, XrefRangeEnd = 143448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOutermostPointInDirection(int pointIndex, Vector3 direction, Il2CppStructArray<Vector3> boundingBoxPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boundingBoxPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_IsOutermostPointInDirection_Private_Static_Boolean_Int32_Vector3_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x00140A9C File Offset: 0x0013EC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143452, XrefRangeEnd = 143462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorThumbnailGenerator.NativeMethodInfoPtr_TestRender_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x0001AEB2 File Offset: 0x000190B2
		public CreatorThumbnailGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x00140AD0 File Offset: 0x0013ECD0
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x0001AEBB File Offset: 0x000190BB
		public unsafe RawImage preview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_preview);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RawImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_preview), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x00140B00 File Offset: 0x0013ED00
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x0001AEDA File Offset: 0x000190DA
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x00140B28 File Offset: 0x0013ED28
		// (set) Token: 0x0600486D RID: 18541 RVA: 0x0001AEF5 File Offset: 0x000190F5
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x00140B50 File Offset: 0x0013ED50
		// (set) Token: 0x0600486F RID: 18543 RVA: 0x0001AF10 File Offset: 0x00019110
		public unsafe float _padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr__padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr__padding)) = value;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x00140B78 File Offset: 0x0013ED78
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x0001AF2B File Offset: 0x0001912B
		public unsafe global::UnityEngine.Camera thumbnailCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_thumbnailCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_thumbnailCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x00140BA8 File Offset: 0x0013EDA8
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x0001AF4A File Offset: 0x0001914A
		public unsafe Dictionary<GameObject, int> oldLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_oldLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorThumbnailGenerator.NativeFieldInfoPtr_oldLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeFieldInfoPtr_preview;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeFieldInfoPtr__padding;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeFieldInfoPtr_thumbnailCamera;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeFieldInfoPtr_oldLayers;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeMethodInfoPtr_GenerateThumbnail_Public_Texture2D_Instance_0;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Private_Void_Instance_Int32_0;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeMethodInfoPtr_PositionCamera_Public_Void_Camera_Bounds_Single_0;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeMethodInfoPtr_FindClosestPointsOnTwoLines_Private_Static_Void_Ray_Ray_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeMethodInfoPtr_GetPlanesIntersection_Private_Static_Ray_Plane_Plane_0;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeMethodInfoPtr_IsOutermostPointInDirection_Private_Static_Boolean_Int32_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeMethodInfoPtr_TestRender_Public_Void_0;
	}
}
