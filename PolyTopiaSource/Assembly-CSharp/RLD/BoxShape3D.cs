using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D7 RID: 471
	public class BoxShape3D : Shape3D
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x000B264C File Offset: 0x000B084C
		// Note: this type is marked as 'beforefieldinit'.
		static BoxShape3D()
		{
			Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr);
			BoxShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "_wireRenderDesc");
			BoxShape3D.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "_size");
			BoxShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "_center");
			BoxShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "_rotation");
			BoxShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "_epsilon");
			BoxShape3D.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668804);
			BoxShape3D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668805);
			BoxShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668806);
			BoxShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668807);
			BoxShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668808);
			BoxShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668809);
			BoxShape3D.NativeMethodInfoPtr_get_Depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668810);
			BoxShape3D.NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668811);
			BoxShape3D.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668812);
			BoxShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668813);
			BoxShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668814);
			BoxShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_BoxEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668815);
			BoxShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_BoxEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668816);
			BoxShape3D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668817);
			BoxShape3D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668818);
			BoxShape3D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668819);
			BoxShape3D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668820);
			BoxShape3D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668821);
			BoxShape3D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668822);
			BoxShape3D.NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668823);
			BoxShape3D.NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668824);
			BoxShape3D.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668825);
			BoxShape3D.NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668826);
			BoxShape3D.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668827);
			BoxShape3D.NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668828);
			BoxShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668829);
			BoxShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668830);
			BoxShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668831);
			BoxShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668832);
			BoxShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668833);
			BoxShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668834);
			BoxShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668835);
			BoxShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668836);
			BoxShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668837);
			BoxShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668838);
			BoxShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668852);
			BoxShape3D.NativeMethodInfoPtr_FromOBB_Public_Void_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668839);
			BoxShape3D.NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668840);
			BoxShape3D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668841);
			BoxShape3D.NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668842);
			BoxShape3D.NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668843);
			BoxShape3D.NativeMethodInfoPtr_GetFaceCenter_Public_Vector3_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668844);
			BoxShape3D.NativeMethodInfoPtr_SetFaceCenter_Public_Void_BoxFace_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668845);
			BoxShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668846);
			BoxShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668847);
			BoxShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668848);
			BoxShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668849);
			BoxShape3D.NativeMethodInfoPtr_GetOBB_Public_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668850);
			BoxShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, 100668851);
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x000B2AB4 File Offset: 0x000B0CB4
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x000B2AF4 File Offset: 0x000B0CF4
		public unsafe Vector3 Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88912, RefRangeEnd = 88914, XrefRangeStart = 88911, XrefRangeEnd = 88912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x000B2B38 File Offset: 0x000B0D38
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x000B2B74 File Offset: 0x000B0D74
		public unsafe float Width
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88928, XrefRangeStart = 88914, XrefRangeEnd = 88914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x000B2BF0 File Offset: 0x000B0DF0
		public unsafe float Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 88928, RefRangeEnd = 88946, XrefRangeStart = 88928, XrefRangeEnd = 88928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x000B2C30 File Offset: 0x000B0E30
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x000B2C6C File Offset: 0x000B0E6C
		public unsafe float Depth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88946, RefRangeEnd = 88960, XrefRangeStart = 88946, XrefRangeEnd = 88946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000B2CAC File Offset: 0x000B0EAC
		public unsafe Vector3 Extents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000B2CEC File Offset: 0x000B0EEC
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x000B2D2C File Offset: 0x000B0F2C
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000B2D70 File Offset: 0x000B0F70
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000B2DB0 File Offset: 0x000B0FB0
		public unsafe BoxEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_BoxEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxEpsilon>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88960, RefRangeEnd = 88961, XrefRangeStart = 88960, XrefRangeEnd = 88960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_BoxEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000B2DF4 File Offset: 0x000B0FF4
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000B2E34 File Offset: 0x000B1034
		public unsafe Vector3 SizeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 88962, RefRangeEnd = 88971, XrefRangeStart = 88961, XrefRangeEnd = 88962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000B2E78 File Offset: 0x000B1078
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x000B2EB4 File Offset: 0x000B10B4
		public unsafe float WidthEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88971, XrefRangeEnd = 88972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88972, XrefRangeEnd = 88973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000B2EF4 File Offset: 0x000B10F4
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x000B2F30 File Offset: 0x000B1130
		public unsafe float HeightEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88973, XrefRangeEnd = 88974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88974, XrefRangeEnd = 88975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000B2F70 File Offset: 0x000B1170
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x000B2FAC File Offset: 0x000B11AC
		public unsafe float DepthEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88975, XrefRangeEnd = 88976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88976, XrefRangeEnd = 88977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000B2FEC File Offset: 0x000B11EC
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x000B302C File Offset: 0x000B122C
		public unsafe Vector3 Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000B3070 File Offset: 0x000B1270
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x000B30B0 File Offset: 0x000B12B0
		public unsafe Vector3 Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000B30F4 File Offset: 0x000B12F4
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x000B3134 File Offset: 0x000B1334
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88978, RefRangeEnd = 88979, XrefRangeStart = 88977, XrefRangeEnd = 88978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000B3178 File Offset: 0x000B1378
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88979, XrefRangeEnd = 88982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000B31B8 File Offset: 0x000B13B8
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88982, XrefRangeEnd = 88985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000B31F8 File Offset: 0x000B13F8
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88985, XrefRangeEnd = 88988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000B3238 File Offset: 0x000B1438
		public unsafe BoxShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000B3278 File Offset: 0x000B1478
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88988, XrefRangeEnd = 88990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000B32AC File Offset: 0x000B14AC
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88990, XrefRangeEnd = 88992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000B32E0 File Offset: 0x000B14E0
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88992, XrefRangeEnd = 88994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000B3314 File Offset: 0x000B1514
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88994, XrefRangeEnd = 88996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000B3348 File Offset: 0x000B1548
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 89038, RefRangeEnd = 89048, XrefRangeStart = 89026, XrefRangeEnd = 89038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000B3384 File Offset: 0x000B1584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89048, XrefRangeEnd = 89050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FromOBB(OBB obb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_FromOBB_Public_Void_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000B33C8 File Offset: 0x000B15C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 89052, RefRangeEnd = 89060, XrefRangeStart = 89050, XrefRangeEnd = 89052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSizeAlongDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000B3418 File Offset: 0x000B1618
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89068, RefRangeEnd = 89077, XrefRangeStart = 89060, XrefRangeEnd = 89068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignWidth(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000B345C File Offset: 0x000B165C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 89085, RefRangeEnd = 89093, XrefRangeStart = 89077, XrefRangeEnd = 89085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignHeight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000B34A0 File Offset: 0x000B16A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89093, XrefRangeEnd = 89101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignDepth(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000B34E4 File Offset: 0x000B16E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89105, RefRangeEnd = 89109, XrefRangeStart = 89101, XrefRangeEnd = 89105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFaceCenter(BoxFace boxFace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_GetFaceCenter_Public_Vector3_BoxFace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000B3534 File Offset: 0x000B1734
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89113, RefRangeEnd = 89122, XrefRangeStart = 89109, XrefRangeEnd = 89113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceCenter(BoxFace boxFace, Vector3 newCenter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newCenter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_SetFaceCenter_Public_Void_BoxFace_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000B3588 File Offset: 0x000B1788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89122, XrefRangeEnd = 89134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000B35C4 File Offset: 0x000B17C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89134, XrefRangeEnd = 89136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000B3600 File Offset: 0x000B1800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89136, XrefRangeEnd = 89140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Raycast(Ray ray, out float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000B3668 File Offset: 0x000B1868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89140, XrefRangeEnd = 89141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000B36B4 File Offset: 0x000B18B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89141, XrefRangeEnd = 89142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB GetOBB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_GetOBB_Public_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000B36F4 File Offset: 0x000B18F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89142, XrefRangeEnd = 89146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0000F1CE File Offset: 0x0000D3CE
		public BoxShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000B3744 File Offset: 0x000B1944
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x0000F1D7 File Offset: 0x0000D3D7
		public unsafe BoxShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000B3774 File Offset: 0x000B1974
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0000F1F6 File Offset: 0x0000D3F6
		public unsafe Vector3 _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__size);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__size), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000B37A4 File Offset: 0x000B19A4
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x0000F215 File Offset: 0x0000D415
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000B37D4 File Offset: 0x000B19D4
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0000F234 File Offset: 0x0000D434
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000B3804 File Offset: 0x000B1A04
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x0000F253 File Offset: 0x0000D453
		public unsafe BoxEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_get_Single_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_BoxEpsilon_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_BoxEpsilon_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeEps_Public_get_Vector3_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector3_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_get_DepthEps_Public_get_Single_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_set_DepthEps_Public_set_Void_Single_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Vector3_0;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Vector3_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_FromOBB_Public_Void_OBB_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_GetSizeAlongDirection_Public_Single_Vector3_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceCenter_Public_Vector3_BoxFace_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceCenter_Public_Void_BoxFace_Vector3_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_GetOBB_Public_OBB_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x020003B3 RID: 947
		public enum WireRenderMode
		{
			// Token: 0x04003AF6 RID: 15094
			Wire,
			// Token: 0x04003AF7 RID: 15095
			WireCorners
		}

		// Token: 0x020003B4 RID: 948
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004BF8 RID: 19448 RVA: 0x0014C10C File Offset: 0x0014A30C
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoxShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr);
				BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__cornerLinePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, "_cornerLinePercentage");
				BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireMode");
				BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, 100668853);
				BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, 100668854);
				BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_CornerLinePercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, 100668855);
				BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_CornerLinePercentage_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, 100668856);
				BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr, 100668857);
			}

			// Token: 0x17001996 RID: 6550
			// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x0014C1C4 File Offset: 0x0014A3C4
			// (set) Token: 0x06004BFA RID: 19450 RVA: 0x0014C200 File Offset: 0x0014A400
			public unsafe BoxShape3D.WireRenderMode WireMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001997 RID: 6551
			// (get) Token: 0x06004BFB RID: 19451 RVA: 0x0014C240 File Offset: 0x0014A440
			// (set) Token: 0x06004BFC RID: 19452 RVA: 0x0014C27C File Offset: 0x0014A47C
			public unsafe float CornerLinePercentage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_CornerLinePercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_CornerLinePercentage_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004BFD RID: 19453 RVA: 0x0014C2BC File Offset: 0x0014A4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88910, XrefRangeEnd = 88911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BFE RID: 19454 RVA: 0x0001C7FA File Offset: 0x0001A9FA
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001994 RID: 6548
			// (get) Token: 0x06004BFF RID: 19455 RVA: 0x0014C2F8 File Offset: 0x0014A4F8
			// (set) Token: 0x06004C00 RID: 19456 RVA: 0x0001C803 File Offset: 0x0001AA03
			public unsafe float _cornerLinePercentage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__cornerLinePercentage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__cornerLinePercentage)) = value;
				}
			}

			// Token: 0x17001995 RID: 6549
			// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0014C320 File Offset: 0x0014A520
			// (set) Token: 0x06004C02 RID: 19458 RVA: 0x0001C81E File Offset: 0x0001AA1E
			public unsafe BoxShape3D.WireRenderMode _wireMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode)) = value;
				}
			}

			// Token: 0x04003AF8 RID: 15096
			private static readonly IntPtr NativeFieldInfoPtr__cornerLinePercentage;

			// Token: 0x04003AF9 RID: 15097
			private static readonly IntPtr NativeFieldInfoPtr__wireMode;

			// Token: 0x04003AFA RID: 15098
			private static readonly IntPtr NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0;

			// Token: 0x04003AFB RID: 15099
			private static readonly IntPtr NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0;

			// Token: 0x04003AFC RID: 15100
			private static readonly IntPtr NativeMethodInfoPtr_get_CornerLinePercentage_Public_get_Single_0;

			// Token: 0x04003AFD RID: 15101
			private static readonly IntPtr NativeMethodInfoPtr_set_CornerLinePercentage_Public_set_Void_Single_0;

			// Token: 0x04003AFE RID: 15102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
