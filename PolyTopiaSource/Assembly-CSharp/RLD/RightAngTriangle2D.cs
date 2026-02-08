using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E4 RID: 484
	public class RightAngTriangle2D : Shape2D
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x000BD294 File Offset: 0x000BB494
		// Note: this type is marked as 'beforefieldinit'.
		static RightAngTriangle2D()
		{
			Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RightAngTriangle2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr);
			RightAngTriangle2D.NativeFieldInfoPtr__rightAngleCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, "_rightAngleCorner");
			RightAngTriangle2D.NativeFieldInfoPtr__XLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, "_XLength");
			RightAngTriangle2D.NativeFieldInfoPtr__YLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, "_YLength");
			RightAngTriangle2D.NativeFieldInfoPtr__rotationDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, "_rotationDegrees");
			RightAngTriangle2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, "_epsilon");
			RightAngTriangle2D.NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669278);
			RightAngTriangle2D.NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669279);
			RightAngTriangle2D.NativeMethodInfoPtr_get_XLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669280);
			RightAngTriangle2D.NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669281);
			RightAngTriangle2D.NativeMethodInfoPtr_get_YLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669282);
			RightAngTriangle2D.NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669283);
			RightAngTriangle2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669284);
			RightAngTriangle2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669285);
			RightAngTriangle2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669286);
			RightAngTriangle2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669287);
			RightAngTriangle2D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669288);
			RightAngTriangle2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669289);
			RightAngTriangle2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669290);
			RightAngTriangle2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669291);
			RightAngTriangle2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669292);
			RightAngTriangle2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669293);
			RightAngTriangle2D.NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669294);
			RightAngTriangle2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669300);
			RightAngTriangle2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669295);
			RightAngTriangle2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669296);
			RightAngTriangle2D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669297);
			RightAngTriangle2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669298);
			RightAngTriangle2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr, 100669299);
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000BD4F4 File Offset: 0x000BB6F4
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x000BD534 File Offset: 0x000BB734
		public unsafe Vector2 RightAngleCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000BD578 File Offset: 0x000BB778
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x000BD5B4 File Offset: 0x000BB7B4
		public unsafe float XLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_XLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000BD5F4 File Offset: 0x000BB7F4
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x000BD630 File Offset: 0x000BB830
		public unsafe float YLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_YLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000BD670 File Offset: 0x000BB870
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x000BD6AC File Offset: 0x000BB8AC
		public unsafe float RotationDegrees
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000BD6EC File Offset: 0x000BB8EC
		public unsafe Vector2 Right
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 90271, RefRangeEnd = 90276, XrefRangeStart = 90271, XrefRangeEnd = 90276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000BD72C File Offset: 0x000BB92C
		public unsafe Vector2 Up
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90282, RefRangeEnd = 90286, XrefRangeStart = 90282, XrefRangeEnd = 90286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000BD76C File Offset: 0x000BB96C
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x000BD7AC File Offset: 0x000BB9AC
		public unsafe TriangleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x000BD7F0 File Offset: 0x000BB9F0
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x000BD82C File Offset: 0x000BBA2C
		public unsafe float AreaEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x000BD86C File Offset: 0x000BBA6C
		public unsafe static Vector2 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000BD8A0 File Offset: 0x000BBAA0
		public unsafe static Vector2 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000BD8D4 File Offset: 0x000BBAD4
		public unsafe static Vector2 ModelRightAngleCorner
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 89172, RefRangeEnd = 89203, XrefRangeStart = 89172, XrefRangeEnd = 89203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000BD908 File Offset: 0x000BBB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90460, XrefRangeEnd = 90463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RightAngTriangle2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightAngTriangle2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000BD944 File Offset: 0x000BBB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90463, XrefRangeEnd = 90472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000BD994 File Offset: 0x000BBB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90472, XrefRangeEnd = 90474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000BD9E4 File Offset: 0x000BBBE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90478, RefRangeEnd = 90482, XrefRangeStart = 90474, XrefRangeEnd = 90478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle2D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000BDA24 File Offset: 0x000BBC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90482, XrefRangeEnd = 90494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000BDA7C File Offset: 0x000BBC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90494, XrefRangeEnd = 90496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0000FB2A File Offset: 0x0000DD2A
		public RightAngTriangle2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000BDAC8 File Offset: 0x000BBCC8
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x0000FB33 File Offset: 0x0000DD33
		public unsafe Vector2 _rightAngleCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__rightAngleCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__rightAngleCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000BDAF8 File Offset: 0x000BBCF8
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x0000FB52 File Offset: 0x0000DD52
		public unsafe float _XLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__XLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__XLength)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000BDB20 File Offset: 0x000BBD20
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0000FB6D File Offset: 0x0000DD6D
		public unsafe float _YLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__YLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__YLength)) = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000BDB48 File Offset: 0x000BBD48
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public unsafe float _rotationDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__rotationDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__rotationDegrees)) = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000BDB70 File Offset: 0x000BBD70
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0000FBA3 File Offset: 0x0000DDA3
		public unsafe TriangleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeFieldInfoPtr__rightAngleCorner;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeFieldInfoPtr__XLength;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeFieldInfoPtr__YLength;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeFieldInfoPtr__rotationDegrees;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector2_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector2_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_get_XLength_Public_get_Single_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_get_YLength_Public_get_Single_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector2_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Public_List_1_Vector2_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;
	}
}
