using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000067 RID: 103
	public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x0003D488 File Offset: 0x0003B688
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircularMaterial()
		{
			Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircularMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr);
			GizmoCircularMaterial.NativeFieldInfoPtr__circularType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, "_circularType");
			GizmoCircularMaterial.NativeFieldInfoPtr__circleMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, "_circleMaterial");
			GizmoCircularMaterial.NativeFieldInfoPtr__torusMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, "_torusMaterial");
			GizmoCircularMaterial.NativeFieldInfoPtr__cylindricalTorusMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, "_cylindricalTorusMaterial");
			GizmoCircularMaterial.NativeMethodInfoPtr_get_CircleMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664380);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_TorusMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664381);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_CylindricalTorusMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664382);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664383);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_CircularType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664384);
			GizmoCircularMaterial.NativeMethodInfoPtr_set_CircularType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664385);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664386);
			GizmoCircularMaterial.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664387);
			GizmoCircularMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664388);
			GizmoCircularMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664389);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCullAlphaScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664390);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetShapeCenter_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664391);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetTorusCoreRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664392);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetTorusTubeRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664393);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCylindricalTorusRadii_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664394);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664395);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664396);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664397);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664398);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664399);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664400);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664401);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664402);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664403);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664404);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeFront_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664405);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664406);
			GizmoCircularMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr, 100664407);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0003D738 File Offset: 0x0003B938
		public unsafe Material CircleMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61625, XrefRangeEnd = 61637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_CircleMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0003D778 File Offset: 0x0003B978
		public unsafe Material TorusMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61637, XrefRangeEnd = 61649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_TorusMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0003D7B8 File Offset: 0x0003B9B8
		public unsafe Material CylindricalTorusMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61649, XrefRangeEnd = 61661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_CylindricalTorusMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		public unsafe Material Material
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 61673, RefRangeEnd = 61705, XrefRangeStart = 61661, XrefRangeEnd = 61673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0003D838 File Offset: 0x0003BA38
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x0003D874 File Offset: 0x0003BA74
		public unsafe GizmoCircularMaterial.Type CircularType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_CircularType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_set_CircularType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
		public unsafe bool IsLit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61709, RefRangeEnd = 61710, XrefRangeStart = 61705, XrefRangeEnd = 61709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0003D8F0 File Offset: 0x0003BAF0
		public unsafe float LightIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61710, XrefRangeEnd = 61715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0003D92C File Offset: 0x0003BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61715, XrefRangeEnd = 61742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircularMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircularMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0003D968 File Offset: 0x0003BB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61763, RefRangeEnd = 61764, XrefRangeStart = 61742, XrefRangeEnd = 61763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetValuesToSensibleDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0003D99C File Offset: 0x0003BB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61769, RefRangeEnd = 61770, XrefRangeStart = 61764, XrefRangeEnd = 61769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullAlphaScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCullAlphaScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61775, RefRangeEnd = 61776, XrefRangeStart = 61770, XrefRangeEnd = 61775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShapeCenter(Vector3 center)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetShapeCenter_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003DA20 File Offset: 0x0003BC20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61780, RefRangeEnd = 61781, XrefRangeStart = 61776, XrefRangeEnd = 61780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTorusCoreRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetTorusCoreRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003DA60 File Offset: 0x0003BC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61781, XrefRangeEnd = 61785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTorusTubeRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetTorusTubeRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61793, RefRangeEnd = 61794, XrefRangeStart = 61785, XrefRangeEnd = 61793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCylindricalTorusRadii(float hrzRadius, float vertRadius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hrzRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCylindricalTorusRadii_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61806, RefRangeEnd = 61807, XrefRangeStart = 61794, XrefRangeEnd = 61806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003DB30 File Offset: 0x0003BD30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61812, RefRangeEnd = 61813, XrefRangeStart = 61807, XrefRangeEnd = 61812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLit(bool isLit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0003DB70 File Offset: 0x0003BD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61817, RefRangeEnd = 61818, XrefRangeStart = 61813, XrefRangeEnd = 61817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightDirection(Vector3 lightDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lightDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0003DBB4 File Offset: 0x0003BDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61818, XrefRangeEnd = 61823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intensity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61827, RefRangeEnd = 61828, XrefRangeStart = 61823, XrefRangeEnd = 61827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0003DC38 File Offset: 0x0003BE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61828, XrefRangeEnd = 61833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZWriteEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0003DC78 File Offset: 0x0003BE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61833, XrefRangeEnd = 61838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61838, XrefRangeEnd = 61843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestAlways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0003DCEC File Offset: 0x0003BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61843, XrefRangeEnd = 61848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0003DD20 File Offset: 0x0003BF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61848, XrefRangeEnd = 61853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0003DD54 File Offset: 0x0003BF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61853, XrefRangeEnd = 61858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeFront_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0003DD88 File Offset: 0x0003BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61858, XrefRangeEnd = 61863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetCullModeOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61866, RefRangeEnd = 61867, XrefRangeStart = 61863, XrefRangeEnd = 61866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPass(int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircularMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004752 File Offset: 0x00002952
		public GizmoCircularMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0003DDFC File Offset: 0x0003BFFC
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0000475B File Offset: 0x0000295B
		public unsafe GizmoCircularMaterial.Type _circularType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__circularType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__circularType)) = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0003DE24 File Offset: 0x0003C024
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00004776 File Offset: 0x00002976
		public unsafe Material _circleMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__circleMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__circleMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0003DE54 File Offset: 0x0003C054
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00004795 File Offset: 0x00002995
		public unsafe Material _torusMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__torusMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__torusMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0003DE84 File Offset: 0x0003C084
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000047B4 File Offset: 0x000029B4
		public unsafe Material _cylindricalTorusMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__cylindricalTorusMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircularMaterial.NativeFieldInfoPtr__cylindricalTorusMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr__circularType;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr__circleMaterial;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr__torusMaterial;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr__cylindricalTorusMaterial;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleMaterial_Public_get_Material_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_get_TorusMaterial_Public_get_Material_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_CylindricalTorusMaterial_Public_get_Material_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_Material_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_CircularType_Public_get_Type_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_set_CircularType_Public_set_Void_Type_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_SetCullAlphaScale_Public_Void_Single_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_SetShapeCenter_Public_Void_Vector3_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_SetTorusCoreRadius_Public_Void_Single_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_SetTorusTubeRadius_Public_Void_Single_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_SetCylindricalTorusRadii_Public_Void_Single_Single_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_SetCamera_Public_Void_Camera_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestAlways_Public_Void_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLess_Public_Void_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeBack_Public_Void_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeFront_Public_Void_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeOff_Public_Void_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_SetPass_Public_Void_Int32_0;

		// Token: 0x02000363 RID: 867
		public enum Type
		{
			// Token: 0x04003945 RID: 14661
			Circle,
			// Token: 0x04003946 RID: 14662
			Torus,
			// Token: 0x04003947 RID: 14663
			CylindricalTorus
		}
	}
}
