using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A5 RID: 421
	public class MaterialPool : Singleton<MaterialPool>
	{
		// Token: 0x06002080 RID: 8320 RVA: 0x000A2F8C File Offset: 0x000A118C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialPool()
		{
			Il2CppClassPointerStore<MaterialPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MaterialPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr);
			MaterialPool.NativeFieldInfoPtr__linearGradientCameraBk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_linearGradientCameraBk");
			MaterialPool.NativeFieldInfoPtr__xzGrid_Plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_xzGrid_Plane");
			MaterialPool.NativeFieldInfoPtr__gizmoSolidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_gizmoSolidHandle");
			MaterialPool.NativeFieldInfoPtr__tintedTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_tintedTexture");
			MaterialPool.NativeFieldInfoPtr__simpleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_simpleColor");
			MaterialPool.NativeFieldInfoPtr__circleCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_circleCull");
			MaterialPool.NativeFieldInfoPtr__torusCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_torusCull");
			MaterialPool.NativeFieldInfoPtr__cylindricalTorusCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, "_cylindricalTorusCull");
			MaterialPool.NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668271);
			MaterialPool.NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668272);
			MaterialPool.NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668273);
			MaterialPool.NativeMethodInfoPtr_get_TintedTexture_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668274);
			MaterialPool.NativeMethodInfoPtr_get_SimpleColor_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668275);
			MaterialPool.NativeMethodInfoPtr_get_CircleCull_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668276);
			MaterialPool.NativeMethodInfoPtr_get_TorusCull_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668277);
			MaterialPool.NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668278);
			MaterialPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100668279);
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x000A3110 File Offset: 0x000A1310
		public unsafe Material LinearGradientCameraBk
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85129, RefRangeEnd = 85130, XrefRangeStart = 85106, XrefRangeEnd = 85129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000A3150 File Offset: 0x000A1350
		public unsafe Material XZGrid_Plane
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85153, RefRangeEnd = 85154, XrefRangeStart = 85130, XrefRangeEnd = 85153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x000A3190 File Offset: 0x000A1390
		public unsafe Material GizmoSolidHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85177, RefRangeEnd = 85178, XrefRangeStart = 85154, XrefRangeEnd = 85177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000A31D0 File Offset: 0x000A13D0
		public unsafe Material TintedTexture
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 85201, RefRangeEnd = 85204, XrefRangeStart = 85178, XrefRangeEnd = 85201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_TintedTexture_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000A3210 File Offset: 0x000A1410
		public unsafe Material SimpleColor
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 85227, RefRangeEnd = 85233, XrefRangeStart = 85204, XrefRangeEnd = 85227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_SimpleColor_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x000A3250 File Offset: 0x000A1450
		public unsafe Material CircleCull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85256, RefRangeEnd = 85257, XrefRangeStart = 85233, XrefRangeEnd = 85256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_CircleCull_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x000A3290 File Offset: 0x000A1490
		public unsafe Material TorusCull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85280, RefRangeEnd = 85281, XrefRangeStart = 85257, XrefRangeEnd = 85280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_TorusCull_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x000A32D0 File Offset: 0x000A14D0
		public unsafe Material CylindricalTorusCull
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85304, RefRangeEnd = 85306, XrefRangeStart = 85281, XrefRangeEnd = 85304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000A3310 File Offset: 0x000A1510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85306, XrefRangeEnd = 85312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x0000D278 File Offset: 0x0000B478
		public MaterialPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x000A334C File Offset: 0x000A154C
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000D281 File Offset: 0x0000B481
		public unsafe Material _linearGradientCameraBk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__linearGradientCameraBk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__linearGradientCameraBk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000A337C File Offset: 0x000A157C
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000D2A0 File Offset: 0x0000B4A0
		public unsafe Material _xzGrid_Plane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__xzGrid_Plane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__xzGrid_Plane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000A33AC File Offset: 0x000A15AC
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000D2BF File Offset: 0x0000B4BF
		public unsafe Material _gizmoSolidHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__gizmoSolidHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__gizmoSolidHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x000A33DC File Offset: 0x000A15DC
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000D2DE File Offset: 0x0000B4DE
		public unsafe Material _tintedTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__tintedTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__tintedTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000A340C File Offset: 0x000A160C
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000D2FD File Offset: 0x0000B4FD
		public unsafe Material _simpleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__simpleColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__simpleColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x000A343C File Offset: 0x000A163C
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000D31C File Offset: 0x0000B51C
		public unsafe Material _circleCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__circleCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__circleCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000A346C File Offset: 0x000A166C
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0000D33B File Offset: 0x0000B53B
		public unsafe Material _torusCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__torusCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__torusCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000A349C File Offset: 0x000A169C
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0000D35A File Offset: 0x0000B55A
		public unsafe Material _cylindricalTorusCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__cylindricalTorusCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__cylindricalTorusCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr__linearGradientCameraBk;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr__xzGrid_Plane;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr__gizmoSolidHandle;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr__tintedTexture;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr__simpleColor;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr__circleCull;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr__torusCull;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr__cylindricalTorusCull;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Material_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Material_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Material_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_get_TintedTexture_Public_get_Material_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleColor_Public_get_Material_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleCull_Public_get_Material_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_get_TorusCull_Public_get_Material_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Material_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
