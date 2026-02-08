using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A6 RID: 422
	public class MeshPool : Singleton<MeshPool>
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x000A34CC File Offset: 0x000A16CC
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPool()
		{
			Il2CppClassPointerStore<MeshPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPool>.NativeClassPtr);
			MeshPool.NativeFieldInfoPtr__unitTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitTorus");
			MeshPool.NativeFieldInfoPtr__unitCylindricalTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitCylindricalTorus");
			MeshPool.NativeFieldInfoPtr__unitBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitBox");
			MeshPool.NativeFieldInfoPtr__unitWireBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireBox");
			MeshPool.NativeFieldInfoPtr__unitPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitPyramid");
			MeshPool.NativeFieldInfoPtr__unitWirePyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWirePyramid");
			MeshPool.NativeFieldInfoPtr__unitTriangularPrism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitTriangularPrism");
			MeshPool.NativeFieldInfoPtr__unitWireTriangularPrism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireTriangularPrism");
			MeshPool.NativeFieldInfoPtr__unitCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitCone");
			MeshPool.NativeFieldInfoPtr__unitCylinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitCylinder");
			MeshPool.NativeFieldInfoPtr__unitSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitSphere");
			MeshPool.NativeFieldInfoPtr__unitCoordSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitCoordSystem");
			MeshPool.NativeFieldInfoPtr__unitSegmentX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitSegmentX");
			MeshPool.NativeFieldInfoPtr__unitQuadXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitQuadXY");
			MeshPool.NativeFieldInfoPtr__unitQuadXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitQuadXZ");
			MeshPool.NativeFieldInfoPtr__unitWireQuadXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireQuadXY");
			MeshPool.NativeFieldInfoPtr__unitCircleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitCircleXY");
			MeshPool.NativeFieldInfoPtr__unitWireCircleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireCircleXY");
			MeshPool.NativeFieldInfoPtr__unitRightAngledTriangleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitRightAngledTriangleXY");
			MeshPool.NativeFieldInfoPtr__unitWireRightAngledTriangleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireRightAngledTriangleXY");
			MeshPool.NativeFieldInfoPtr__unitEqTriangleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitEqTriangleXY");
			MeshPool.NativeFieldInfoPtr__unitWireEqTriangleXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, "_unitWireEqTriangleXY");
			MeshPool.NativeMethodInfoPtr_get_UnitTorus_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668280);
			MeshPool.NativeMethodInfoPtr_get_UnitCylindricalTorus_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668281);
			MeshPool.NativeMethodInfoPtr_get_UnitQuadXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668282);
			MeshPool.NativeMethodInfoPtr_get_UnitQuadXZ_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668283);
			MeshPool.NativeMethodInfoPtr_get_UnitBox_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668284);
			MeshPool.NativeMethodInfoPtr_get_UnitWireBox_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668285);
			MeshPool.NativeMethodInfoPtr_get_UnitPyramid_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668286);
			MeshPool.NativeMethodInfoPtr_get_UnitWirePyramid_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668287);
			MeshPool.NativeMethodInfoPtr_get_UnitTriangularPrism_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668288);
			MeshPool.NativeMethodInfoPtr_get_UnitWireTriangularPrism_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668289);
			MeshPool.NativeMethodInfoPtr_get_UnitCone_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668290);
			MeshPool.NativeMethodInfoPtr_get_UnitCylinder_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668291);
			MeshPool.NativeMethodInfoPtr_get_UnitSphere_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668292);
			MeshPool.NativeMethodInfoPtr_get_UnitCoordSystem_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668293);
			MeshPool.NativeMethodInfoPtr_get_UnitSegmentX_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668294);
			MeshPool.NativeMethodInfoPtr_get_UnitWireQuadXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668295);
			MeshPool.NativeMethodInfoPtr_get_UnitCircleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668296);
			MeshPool.NativeMethodInfoPtr_get_UnitWireCircleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668297);
			MeshPool.NativeMethodInfoPtr_get_UnitRightAngledTriangleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668298);
			MeshPool.NativeMethodInfoPtr_get_UnitWireRightAngledTriangleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668299);
			MeshPool.NativeMethodInfoPtr_get_UnitEqTriangleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668300);
			MeshPool.NativeMethodInfoPtr_get_UnitWireEqTriangleXY_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668301);
			MeshPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPool>.NativeClassPtr, 100668302);
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x000A3880 File Offset: 0x000A1A80
		public unsafe Mesh UnitTorus
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85320, RefRangeEnd = 85321, XrefRangeStart = 85312, XrefRangeEnd = 85320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitTorus_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		public unsafe Mesh UnitCylindricalTorus
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85329, RefRangeEnd = 85330, XrefRangeStart = 85321, XrefRangeEnd = 85329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitCylindricalTorus_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000A3900 File Offset: 0x000A1B00
		public unsafe Mesh UnitQuadXY
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 85336, RefRangeEnd = 85340, XrefRangeStart = 85330, XrefRangeEnd = 85336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitQuadXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000A3940 File Offset: 0x000A1B40
		public unsafe Mesh UnitQuadXZ
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85346, RefRangeEnd = 85347, XrefRangeStart = 85340, XrefRangeEnd = 85346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitQuadXZ_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000A3980 File Offset: 0x000A1B80
		public unsafe Mesh UnitBox
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85353, RefRangeEnd = 85354, XrefRangeStart = 85347, XrefRangeEnd = 85353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitBox_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000A39C0 File Offset: 0x000A1BC0
		public unsafe Mesh UnitWireBox
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85360, RefRangeEnd = 85362, XrefRangeStart = 85354, XrefRangeEnd = 85360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireBox_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000A3A00 File Offset: 0x000A1C00
		public unsafe Mesh UnitPyramid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85370, RefRangeEnd = 85371, XrefRangeStart = 85362, XrefRangeEnd = 85370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitPyramid_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000A3A40 File Offset: 0x000A1C40
		public unsafe Mesh UnitWirePyramid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85379, RefRangeEnd = 85380, XrefRangeStart = 85371, XrefRangeEnd = 85379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWirePyramid_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000A3A80 File Offset: 0x000A1C80
		public unsafe Mesh UnitTriangularPrism
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85388, RefRangeEnd = 85389, XrefRangeStart = 85380, XrefRangeEnd = 85388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitTriangularPrism_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000A3AC0 File Offset: 0x000A1CC0
		public unsafe Mesh UnitWireTriangularPrism
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85397, RefRangeEnd = 85398, XrefRangeStart = 85389, XrefRangeEnd = 85397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireTriangularPrism_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000A3B00 File Offset: 0x000A1D00
		public unsafe Mesh UnitCone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85404, RefRangeEnd = 85405, XrefRangeStart = 85398, XrefRangeEnd = 85404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitCone_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000A3B40 File Offset: 0x000A1D40
		public unsafe Mesh UnitCylinder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85411, RefRangeEnd = 85412, XrefRangeStart = 85405, XrefRangeEnd = 85411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitCylinder_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000A3B80 File Offset: 0x000A1D80
		public unsafe Mesh UnitSphere
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85418, RefRangeEnd = 85419, XrefRangeStart = 85412, XrefRangeEnd = 85418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitSphere_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		public unsafe Mesh UnitCoordSystem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85425, RefRangeEnd = 85427, XrefRangeStart = 85419, XrefRangeEnd = 85425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitCoordSystem_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x000A3C00 File Offset: 0x000A1E00
		public unsafe Mesh UnitSegmentX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85427, XrefRangeEnd = 85435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitSegmentX_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x000A3C40 File Offset: 0x000A1E40
		public unsafe Mesh UnitWireQuadXY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85435, XrefRangeEnd = 85443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireQuadXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x000A3C80 File Offset: 0x000A1E80
		public unsafe Mesh UnitCircleXY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85449, RefRangeEnd = 85450, XrefRangeStart = 85443, XrefRangeEnd = 85449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitCircleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000A3CC0 File Offset: 0x000A1EC0
		public unsafe Mesh UnitWireCircleXY
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 85456, RefRangeEnd = 85468, XrefRangeStart = 85450, XrefRangeEnd = 85456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireCircleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x000A3D00 File Offset: 0x000A1F00
		public unsafe Mesh UnitRightAngledTriangleXY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85476, RefRangeEnd = 85477, XrefRangeStart = 85468, XrefRangeEnd = 85476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitRightAngledTriangleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000A3D40 File Offset: 0x000A1F40
		public unsafe Mesh UnitWireRightAngledTriangleXY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85485, RefRangeEnd = 85486, XrefRangeStart = 85477, XrefRangeEnd = 85485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireRightAngledTriangleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x000A3D80 File Offset: 0x000A1F80
		public unsafe Mesh UnitEqTriangleXY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85494, RefRangeEnd = 85495, XrefRangeStart = 85486, XrefRangeEnd = 85494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitEqTriangleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000A3DC0 File Offset: 0x000A1FC0
		public unsafe Mesh UnitWireEqTriangleXY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85503, RefRangeEnd = 85504, XrefRangeStart = 85495, XrefRangeEnd = 85503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr_get_UnitWireEqTriangleXY_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000A3E00 File Offset: 0x000A2000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85504, XrefRangeEnd = 85510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000D379 File Offset: 0x0000B579
		public MeshPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x000A3E3C File Offset: 0x000A203C
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0000D382 File Offset: 0x0000B582
		public unsafe Mesh _unitTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000A3E6C File Offset: 0x000A206C
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0000D3A1 File Offset: 0x0000B5A1
		public unsafe Mesh _unitCylindricalTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCylindricalTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCylindricalTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000A3E9C File Offset: 0x000A209C
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		public unsafe Mesh _unitBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000A3ECC File Offset: 0x000A20CC
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x0000D3DF File Offset: 0x0000B5DF
		public unsafe Mesh _unitWireBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x000A3EFC File Offset: 0x000A20FC
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x0000D3FE File Offset: 0x0000B5FE
		public unsafe Mesh _unitPyramid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitPyramid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitPyramid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x000A3F2C File Offset: 0x000A212C
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0000D41D File Offset: 0x0000B61D
		public unsafe Mesh _unitWirePyramid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWirePyramid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWirePyramid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x000A3F5C File Offset: 0x000A215C
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe Mesh _unitTriangularPrism
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitTriangularPrism);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitTriangularPrism), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x000A3F8C File Offset: 0x000A218C
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0000D45B File Offset: 0x0000B65B
		public unsafe Mesh _unitWireTriangularPrism
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireTriangularPrism);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireTriangularPrism), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x000A3FBC File Offset: 0x000A21BC
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0000D47A File Offset: 0x0000B67A
		public unsafe Mesh _unitCone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000A3FEC File Offset: 0x000A21EC
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0000D499 File Offset: 0x0000B699
		public unsafe Mesh _unitCylinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCylinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCylinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000A401C File Offset: 0x000A221C
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		public unsafe Mesh _unitSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitSphere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitSphere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000A404C File Offset: 0x000A224C
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x0000D4D7 File Offset: 0x0000B6D7
		public unsafe Mesh _unitCoordSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCoordSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCoordSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000A407C File Offset: 0x000A227C
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x0000D4F6 File Offset: 0x0000B6F6
		public unsafe Mesh _unitSegmentX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitSegmentX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitSegmentX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000A40AC File Offset: 0x000A22AC
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0000D515 File Offset: 0x0000B715
		public unsafe Mesh _unitQuadXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitQuadXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitQuadXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000A40DC File Offset: 0x000A22DC
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0000D534 File Offset: 0x0000B734
		public unsafe Mesh _unitQuadXZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitQuadXZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitQuadXZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000A410C File Offset: 0x000A230C
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0000D553 File Offset: 0x0000B753
		public unsafe Mesh _unitWireQuadXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireQuadXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireQuadXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x000A413C File Offset: 0x000A233C
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x0000D572 File Offset: 0x0000B772
		public unsafe Mesh _unitCircleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCircleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitCircleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x000A416C File Offset: 0x000A236C
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0000D591 File Offset: 0x0000B791
		public unsafe Mesh _unitWireCircleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireCircleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireCircleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000A419C File Offset: 0x000A239C
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		public unsafe Mesh _unitRightAngledTriangleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitRightAngledTriangleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitRightAngledTriangleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000A41CC File Offset: 0x000A23CC
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000D5CF File Offset: 0x0000B7CF
		public unsafe Mesh _unitWireRightAngledTriangleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireRightAngledTriangleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireRightAngledTriangleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000A41FC File Offset: 0x000A23FC
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000D5EE File Offset: 0x0000B7EE
		public unsafe Mesh _unitEqTriangleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitEqTriangleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitEqTriangleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000A422C File Offset: 0x000A242C
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0000D60D File Offset: 0x0000B80D
		public unsafe Mesh _unitWireEqTriangleXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireEqTriangleXY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPool.NativeFieldInfoPtr__unitWireEqTriangleXY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr__unitTorus;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr__unitCylindricalTorus;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeFieldInfoPtr__unitBox;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeFieldInfoPtr__unitWireBox;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr__unitPyramid;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr__unitWirePyramid;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr__unitTriangularPrism;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr__unitWireTriangularPrism;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr__unitCone;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeFieldInfoPtr__unitCylinder;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr__unitSphere;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr__unitCoordSystem;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr__unitSegmentX;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr__unitQuadXY;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr__unitQuadXZ;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr__unitWireQuadXY;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr__unitCircleXY;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr__unitWireCircleXY;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr__unitRightAngledTriangleXY;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr__unitWireRightAngledTriangleXY;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr__unitEqTriangleXY;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeFieldInfoPtr__unitWireEqTriangleXY;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitTorus_Public_get_Mesh_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitCylindricalTorus_Public_get_Mesh_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitQuadXY_Public_get_Mesh_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitQuadXZ_Public_get_Mesh_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitBox_Public_get_Mesh_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireBox_Public_get_Mesh_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitPyramid_Public_get_Mesh_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWirePyramid_Public_get_Mesh_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitTriangularPrism_Public_get_Mesh_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireTriangularPrism_Public_get_Mesh_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitCone_Public_get_Mesh_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitCylinder_Public_get_Mesh_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitSphere_Public_get_Mesh_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitCoordSystem_Public_get_Mesh_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitSegmentX_Public_get_Mesh_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireQuadXY_Public_get_Mesh_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitCircleXY_Public_get_Mesh_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireCircleXY_Public_get_Mesh_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitRightAngledTriangleXY_Public_get_Mesh_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireRightAngledTriangleXY_Public_get_Mesh_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitEqTriangleXY_Public_get_Mesh_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitWireEqTriangleXY_Public_get_Mesh_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
