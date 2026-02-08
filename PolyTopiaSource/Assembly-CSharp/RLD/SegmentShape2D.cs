using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E6 RID: 486
	public class SegmentShape2D : Shape2D
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x000BECDC File Offset: 0x000BCEDC
		// Note: this type is marked as 'beforefieldinit'.
		static SegmentShape2D()
		{
			Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SegmentShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr);
			SegmentShape2D.NativeFieldInfoPtr__startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, "_startPoint");
			SegmentShape2D.NativeFieldInfoPtr__endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, "_endPoint");
			SegmentShape2D.NativeFieldInfoPtr__direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, "_direction");
			SegmentShape2D.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, "_length");
			SegmentShape2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, "_epsilon");
			SegmentShape2D.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669346);
			SegmentShape2D.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669347);
			SegmentShape2D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669348);
			SegmentShape2D.NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669349);
			SegmentShape2D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669350);
			SegmentShape2D.NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669351);
			SegmentShape2D.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669352);
			SegmentShape2D.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669353);
			SegmentShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669354);
			SegmentShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669355);
			SegmentShape2D.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669356);
			SegmentShape2D.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669357);
			SegmentShape2D.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669358);
			SegmentShape2D.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669359);
			SegmentShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669365);
			SegmentShape2D.NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669360);
			SegmentShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669361);
			SegmentShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669362);
			SegmentShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669363);
			SegmentShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr, 100669364);
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x000BEF00 File Offset: 0x000BD100
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x000BEF3C File Offset: 0x000BD13C
		public unsafe float Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000BEF7C File Offset: 0x000BD17C
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x000BEFBC File Offset: 0x000BD1BC
		public unsafe Vector2 StartPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90611, RefRangeEnd = 90612, XrefRangeStart = 90611, XrefRangeEnd = 90611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000BF000 File Offset: 0x000BD200
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x000BF040 File Offset: 0x000BD240
		public unsafe Vector2 EndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90612, XrefRangeEnd = 90614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000BF084 File Offset: 0x000BD284
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x000BF0C4 File Offset: 0x000BD2C4
		public unsafe Vector2 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90614, XrefRangeEnd = 90615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000BF108 File Offset: 0x000BD308
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x000BF148 File Offset: 0x000BD348
		public unsafe SegmentEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SegmentEpsilon>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x000BF18C File Offset: 0x000BD38C
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x000BF1C8 File Offset: 0x000BD3C8
		public unsafe float RaycastEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90615, XrefRangeEnd = 90616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x000BF208 File Offset: 0x000BD408
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x000BF244 File Offset: 0x000BD444
		public unsafe float PtOnSegmentEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90617, RefRangeEnd = 90618, XrefRangeStart = 90616, XrefRangeEnd = 90617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000BF284 File Offset: 0x000BD484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90625, RefRangeEnd = 90626, XrefRangeStart = 90618, XrefRangeEnd = 90625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SegmentShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SegmentShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000BF2C0 File Offset: 0x000BD4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90628, RefRangeEnd = 90629, XrefRangeStart = 90626, XrefRangeEnd = 90628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEndPtFromStart(Vector2 dirDromStart, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dirDromStart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape2D.NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000BF310 File Offset: 0x000BD510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90629, XrefRangeEnd = 90630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000BF360 File Offset: 0x000BD560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000BF3B0 File Offset: 0x000BD5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90630, XrefRangeEnd = 90631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000BF408 File Offset: 0x000BD608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90631, XrefRangeEnd = 90635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0000FCBB File Offset: 0x0000DEBB
		public SegmentShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000BF454 File Offset: 0x000BD654
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		public unsafe Vector2 _startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000BF484 File Offset: 0x000BD684
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0000FCE3 File Offset: 0x0000DEE3
		public unsafe Vector2 _endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000BF4B4 File Offset: 0x000BD6B4
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0000FD02 File Offset: 0x0000DF02
		public unsafe Vector2 _direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__direction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__direction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x0000FD21 File Offset: 0x0000DF21
		public unsafe float _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000BF50C File Offset: 0x000BD70C
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		public unsafe SegmentEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeFieldInfoPtr__startPoint;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr__endPoint;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr__direction;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPoint_Public_get_Vector2_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector2_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPoint_Public_get_Vector2_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector2_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector2_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector2_Single_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;
	}
}
