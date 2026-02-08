using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E2 RID: 482
	public class QuadShape2D : Shape2D
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x000BB2D0 File Offset: 0x000B94D0
		// Note: this type is marked as 'beforefieldinit'.
		static QuadShape2D()
		{
			Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuadShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr);
			QuadShape2D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, "_center");
			QuadShape2D.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, "_size");
			QuadShape2D.NativeFieldInfoPtr__rotationDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, "_rotationDegrees");
			QuadShape2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, "_epsilon");
			QuadShape2D.NativeFieldInfoPtr__ptContainMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, "_ptContainMode");
			QuadShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669190);
			QuadShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669191);
			QuadShape2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669192);
			QuadShape2D.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669193);
			QuadShape2D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669194);
			QuadShape2D.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669195);
			QuadShape2D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669196);
			QuadShape2D.NativeMethodInfoPtr_get_Extents_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669197);
			QuadShape2D.NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669198);
			QuadShape2D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669199);
			QuadShape2D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669200);
			QuadShape2D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669201);
			QuadShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669202);
			QuadShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669203);
			QuadShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669204);
			QuadShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669205);
			QuadShape2D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669206);
			QuadShape2D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669207);
			QuadShape2D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669208);
			QuadShape2D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669209);
			QuadShape2D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669210);
			QuadShape2D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669211);
			QuadShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669212);
			QuadShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669213);
			QuadShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669214);
			QuadShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669215);
			QuadShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669216);
			QuadShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669217);
			QuadShape2D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669218);
			QuadShape2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669226);
			QuadShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669219);
			QuadShape2D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669220);
			QuadShape2D.NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669221);
			QuadShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669222);
			QuadShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669223);
			QuadShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669224);
			QuadShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr, 100669225);
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000BB648 File Offset: 0x000B9848
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x000BB684 File Offset: 0x000B9884
		public unsafe float RotationDegrees
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90248, RefRangeEnd = 90251, XrefRangeStart = 90247, XrefRangeEnd = 90248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000BB6C4 File Offset: 0x000B98C4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90251, XrefRangeEnd = 90254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000BB704 File Offset: 0x000B9904
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000BB744 File Offset: 0x000B9944
		public unsafe Vector2 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89146, RefRangeEnd = 89148, XrefRangeStart = 89146, XrefRangeEnd = 89148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000BB788 File Offset: 0x000B9988
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000BB7C8 File Offset: 0x000B99C8
		public unsafe Vector2 Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90255, RefRangeEnd = 90258, XrefRangeStart = 90254, XrefRangeEnd = 90255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000BB80C File Offset: 0x000B9A0C
		public unsafe Vector2 Extents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Extents_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000BB84C File Offset: 0x000B9A4C
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x000BB888 File Offset: 0x000B9A88
		public unsafe float Width
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88928, XrefRangeStart = 88914, XrefRangeEnd = 88928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x000BB8C8 File Offset: 0x000B9AC8
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x000BB904 File Offset: 0x000B9B04
		public unsafe float Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 88928, RefRangeEnd = 88946, XrefRangeStart = 88928, XrefRangeEnd = 88946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000BB944 File Offset: 0x000B9B44
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x000BB984 File Offset: 0x000B9B84
		public unsafe QuadEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuadEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x000BB9C8 File Offset: 0x000B9BC8
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x000BBA08 File Offset: 0x000B9C08
		public unsafe Shape2DPtContainMode PtContainMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000BBA4C File Offset: 0x000B9C4C
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x000BBA8C File Offset: 0x000B9C8C
		public unsafe Vector2 SizeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90259, RefRangeEnd = 90261, XrefRangeStart = 90258, XrefRangeEnd = 90259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000BBAD0 File Offset: 0x000B9CD0
		// (set) Token: 0x060026F3 RID: 9971 RVA: 0x000BBB0C File Offset: 0x000B9D0C
		public unsafe float WidthEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90261, XrefRangeEnd = 90262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x000BBB4C File Offset: 0x000B9D4C
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x000BBB88 File Offset: 0x000B9D88
		public unsafe float HeightEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90262, XrefRangeEnd = 90263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000BBBC8 File Offset: 0x000B9DC8
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x000BBC04 File Offset: 0x000B9E04
		public unsafe float WireEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90264, RefRangeEnd = 90265, XrefRangeStart = 90263, XrefRangeEnd = 90264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000BBC44 File Offset: 0x000B9E44
		public unsafe Vector2 Right
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 90271, RefRangeEnd = 90276, XrefRangeStart = 90265, XrefRangeEnd = 90271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000BBC84 File Offset: 0x000B9E84
		public unsafe Vector2 Up
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90282, RefRangeEnd = 90286, XrefRangeStart = 90276, XrefRangeEnd = 90282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000BBCC4 File Offset: 0x000B9EC4
		public unsafe static Vector2 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		public unsafe static Vector2 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		public unsafe static Vector2 ModelCenter
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 89172, RefRangeEnd = 89203, XrefRangeStart = 89172, XrefRangeEnd = 89203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000BBD60 File Offset: 0x000B9F60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 90291, RefRangeEnd = 90297, XrefRangeStart = 90286, XrefRangeEnd = 90291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuadShape2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadShape2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000BBD9C File Offset: 0x000B9F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90307, RefRangeEnd = 90308, XrefRangeStart = 90297, XrefRangeEnd = 90307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000BBDEC File Offset: 0x000B9FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90315, RefRangeEnd = 90316, XrefRangeStart = 90308, XrefRangeEnd = 90315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignWidth(Vector2 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000BBE30 File Offset: 0x000BA030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90316, XrefRangeEnd = 90321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSizeAlongDirection(Vector2 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape2D.NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000BBE80 File Offset: 0x000BA080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90321, XrefRangeEnd = 90330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000BBED0 File Offset: 0x000BA0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90330, XrefRangeEnd = 90332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000BBF20 File Offset: 0x000BA120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90332, XrefRangeEnd = 90339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000BBF78 File Offset: 0x000BA178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90339, XrefRangeEnd = 90341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x0000F9C7 File Offset: 0x0000DBC7
		public QuadShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000BBFC4 File Offset: 0x000BA1C4
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		public unsafe Vector2 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000BBFF4 File Offset: 0x000BA1F4
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x0000F9EF File Offset: 0x0000DBEF
		public unsafe Vector2 _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__size);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__size), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000BC024 File Offset: 0x000BA224
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x0000FA0E File Offset: 0x0000DC0E
		public unsafe float _rotationDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__rotationDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__rotationDegrees)) = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000BC04C File Offset: 0x000BA24C
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x0000FA29 File Offset: 0x0000DC29
		public unsafe QuadEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000BC07C File Offset: 0x000BA27C
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x0000FA48 File Offset: 0x0000DC48
		public unsafe Shape2DPtContainMode _ptContainMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__ptContainMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2DPtContainMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape2D.NativeFieldInfoPtr__ptContainMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeFieldInfoPtr__rotationDegrees;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr__ptContainMode;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector2_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector2_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_Vector2_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainMode_Public_get_Shape2DPtContainMode_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainMode_Public_set_Void_Shape2DPtContainMode_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector2_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_GetExtentPoint_Public_Vector2_Shape2DExtentPoint_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_AlignWidth_Public_Void_Vector2_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector2_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;
	}
}
