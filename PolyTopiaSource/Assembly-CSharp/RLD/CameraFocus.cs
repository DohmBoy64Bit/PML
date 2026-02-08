using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F9 RID: 249
	public static class CameraFocus : global::Il2CppSystem.Object
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x0000AB28 File Offset: 0x00008D28
		// Note: this type is marked as 'beforefieldinit'.
		static CameraFocus()
		{
			Il2CppClassPointerStore<CameraFocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraFocus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFocus>.NativeClassPtr);
			CameraFocus.NativeMethodInfoPtr_CalculateFocusData_Public_Static_Data_Camera_AABB_CameraFocusSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocus>.NativeClassPtr, 100666885);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0008025C File Offset: 0x0007E45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74389, XrefRangeEnd = 74404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CameraFocus.Data CalculateFocusData(Camera camera, AABB focusAABB, CameraFocusSettings focusSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusAABB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocus.NativeMethodInfoPtr_CalculateFocusData_Public_Static_Data_Camera_AABB_CameraFocusSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraFocus.Data>(intPtr3) : null;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0000AB61 File Offset: 0x00008D61
		public CameraFocus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFocusData_Public_Static_Data_Camera_AABB_CameraFocusSettings_0;

		// Token: 0x02000379 RID: 889
		public class Data : global::Il2CppSystem.Object
		{
			// Token: 0x06004A29 RID: 18985 RVA: 0x00146D08 File Offset: 0x00144F08
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraFocus>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr);
				CameraFocus.Data.NativeFieldInfoPtr__cameraWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, "_cameraWorldPosition");
				CameraFocus.Data.NativeFieldInfoPtr__focusPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, "_focusPoint");
				CameraFocus.Data.NativeFieldInfoPtr__focusPointOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, "_focusPointOffset");
				CameraFocus.Data.NativeMethodInfoPtr_get_CameraWorldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, 100666886);
				CameraFocus.Data.NativeMethodInfoPtr_get_FocusPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, 100666887);
				CameraFocus.Data.NativeMethodInfoPtr_get_FocusPointOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, 100666888);
				CameraFocus.Data.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr, 100666889);
			}

			// Token: 0x17001916 RID: 6422
			// (get) Token: 0x06004A2A RID: 18986 RVA: 0x00146DC0 File Offset: 0x00144FC0
			public unsafe Vector3 CameraWorldPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocus.Data.NativeMethodInfoPtr_get_CameraWorldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x17001917 RID: 6423
			// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00146E00 File Offset: 0x00145000
			public unsafe Vector3 FocusPoint
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocus.Data.NativeMethodInfoPtr_get_FocusPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x17001918 RID: 6424
			// (get) Token: 0x06004A2C RID: 18988 RVA: 0x00146E40 File Offset: 0x00145040
			public unsafe float FocusPointOffset
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocus.Data.NativeMethodInfoPtr_get_FocusPointOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A2D RID: 18989 RVA: 0x00146E7C File Offset: 0x0014507C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74387, XrefRangeEnd = 74389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Data(Vector3 cameraWorldPosition, Vector3 focusPoint)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFocus.Data>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraWorldPosition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFocus.Data.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A2E RID: 18990 RVA: 0x0001B9C7 File Offset: 0x00019BC7
			public Data(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001913 RID: 6419
			// (get) Token: 0x06004A2F RID: 18991 RVA: 0x00146EDC File Offset: 0x001450DC
			// (set) Token: 0x06004A30 RID: 18992 RVA: 0x0001B9D0 File Offset: 0x00019BD0
			public unsafe Vector3 _cameraWorldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__cameraWorldPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__cameraWorldPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001914 RID: 6420
			// (get) Token: 0x06004A31 RID: 18993 RVA: 0x00146F0C File Offset: 0x0014510C
			// (set) Token: 0x06004A32 RID: 18994 RVA: 0x0001B9EF File Offset: 0x00019BEF
			public unsafe Vector3 _focusPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__focusPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__focusPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001915 RID: 6421
			// (get) Token: 0x06004A33 RID: 18995 RVA: 0x00146F3C File Offset: 0x0014513C
			// (set) Token: 0x06004A34 RID: 18996 RVA: 0x0001BA0E File Offset: 0x00019C0E
			public unsafe float _focusPointOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__focusPointOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFocus.Data.NativeFieldInfoPtr__focusPointOffset)) = value;
				}
			}

			// Token: 0x0400399F RID: 14751
			private static readonly IntPtr NativeFieldInfoPtr__cameraWorldPosition;

			// Token: 0x040039A0 RID: 14752
			private static readonly IntPtr NativeFieldInfoPtr__focusPoint;

			// Token: 0x040039A1 RID: 14753
			private static readonly IntPtr NativeFieldInfoPtr__focusPointOffset;

			// Token: 0x040039A2 RID: 14754
			private static readonly IntPtr NativeMethodInfoPtr_get_CameraWorldPosition_Public_get_Vector3_0;

			// Token: 0x040039A3 RID: 14755
			private static readonly IntPtr NativeMethodInfoPtr_get_FocusPoint_Public_get_Vector3_0;

			// Token: 0x040039A4 RID: 14756
			private static readonly IntPtr NativeMethodInfoPtr_get_FocusPointOffset_Public_get_Single_0;

			// Token: 0x040039A5 RID: 14757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;
		}
	}
}
