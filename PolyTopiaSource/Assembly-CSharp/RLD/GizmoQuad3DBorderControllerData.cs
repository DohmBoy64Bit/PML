using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000CA RID: 202
	public class GizmoQuad3DBorderControllerData : Object
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x0005EFB8 File Offset: 0x0005D1B8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoQuad3DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoQuad3DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr);
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "Border");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TargetQuad");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BorderQuad");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "RightBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "LeftBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopLeftBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopRightBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomRightBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomLeftBox");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BorderQuadIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "RightBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "LeftBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopLeftBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "TopRightBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomRightBoxIndex");
			GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, "BottomLeftBoxIndex");
			GizmoQuad3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr, 100665573);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoQuad3DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoQuad3DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00008526 File Offset: 0x00006726
		public GizmoQuad3DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0005F204 File Offset: 0x0005D404
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x0000852F File Offset: 0x0000672F
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0005F234 File Offset: 0x0005D434
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x0000854E File Offset: 0x0000674E
		public unsafe GizmoPlaneSlider3D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0005F264 File Offset: 0x0005D464
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0000856D File Offset: 0x0000676D
		public unsafe GizmoQuad3DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0005F294 File Offset: 0x0005D494
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x0000858C File Offset: 0x0000678C
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0005F2C4 File Offset: 0x0005D4C4
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x000085AB File Offset: 0x000067AB
		public unsafe QuadShape3D TargetQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TargetQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x000085CA File Offset: 0x000067CA
		public unsafe QuadShape3D BorderQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0005F324 File Offset: 0x0005D524
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x000085E9 File Offset: 0x000067E9
		public unsafe BoxShape3D TopBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0005F354 File Offset: 0x0005D554
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00008608 File Offset: 0x00006808
		public unsafe BoxShape3D RightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0005F384 File Offset: 0x0005D584
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00008627 File Offset: 0x00006827
		public unsafe BoxShape3D BottomBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x00008646 File Offset: 0x00006846
		public unsafe BoxShape3D LeftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x0005F3E4 File Offset: 0x0005D5E4
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x00008665 File Offset: 0x00006865
		public unsafe BoxShape3D TopLeftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0005F414 File Offset: 0x0005D614
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00008684 File Offset: 0x00006884
		public unsafe BoxShape3D TopRightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005F444 File Offset: 0x0005D644
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x000086A3 File Offset: 0x000068A3
		public unsafe BoxShape3D BottomRightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x0005F474 File Offset: 0x0005D674
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x000086C2 File Offset: 0x000068C2
		public unsafe BoxShape3D BottomLeftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x000086E1 File Offset: 0x000068E1
		public unsafe int BorderQuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex)) = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0005F4CC File Offset: 0x0005D6CC
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x000086FC File Offset: 0x000068FC
		public unsafe int TopBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopBoxIndex)) = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00008717 File Offset: 0x00006917
		public unsafe int RightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_RightBoxIndex)) = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0005F51C File Offset: 0x0005D71C
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00008732 File Offset: 0x00006932
		public unsafe int BottomBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomBoxIndex)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0005F544 File Offset: 0x0005D744
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0000874D File Offset: 0x0000694D
		public unsafe int LeftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_LeftBoxIndex)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0005F56C File Offset: 0x0005D76C
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00008768 File Offset: 0x00006968
		public unsafe int TopLeftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopLeftBoxIndex)) = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0005F594 File Offset: 0x0005D794
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00008783 File Offset: 0x00006983
		public unsafe int TopRightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_TopRightBoxIndex)) = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0000879E File Offset: 0x0000699E
		public unsafe int BottomRightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomRightBoxIndex)) = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x000087B9 File Offset: 0x000069B9
		public unsafe int BottomLeftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorderControllerData.NativeFieldInfoPtr_BottomLeftBoxIndex)) = value;
			}
		}

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuad;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr_BorderQuad;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeFieldInfoPtr_TopBox;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeFieldInfoPtr_RightBox;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_BottomBox;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_LeftBox;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_TopLeftBox;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr_TopRightBox;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_BottomRightBox;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_BottomLeftBox;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_BorderQuadIndex;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr_TopBoxIndex;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_RightBoxIndex;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeFieldInfoPtr_BottomBoxIndex;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeFieldInfoPtr_LeftBoxIndex;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeFieldInfoPtr_TopLeftBoxIndex;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr_TopRightBoxIndex;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr_BottomRightBoxIndex;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_BottomLeftBoxIndex;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
