using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000343 RID: 835
	public class ProceduralImage : Image
	{
		// Token: 0x0600487A RID: 18554 RVA: 0x00140CF0 File Offset: 0x0013EEF0
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralImage()
		{
			Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.ProceduralImage", "ProceduralImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr);
			ProceduralImage.NativeFieldInfoPtr_borderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, "borderWidth");
			ProceduralImage.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, "modifier");
			ProceduralImage.NativeFieldInfoPtr_materialInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, "materialInstance");
			ProceduralImage.NativeFieldInfoPtr_falloffDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, "falloffDistance");
			ProceduralImage.NativeMethodInfoPtr_get_DefaultProceduralImageMaterial_Private_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674874);
			ProceduralImage.NativeMethodInfoPtr_set_DefaultProceduralImageMaterial_Private_Static_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674875);
			ProceduralImage.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674876);
			ProceduralImage.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674877);
			ProceduralImage.NativeMethodInfoPtr_get_FalloffDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674878);
			ProceduralImage.NativeMethodInfoPtr_set_FalloffDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674879);
			ProceduralImage.NativeMethodInfoPtr_get_Modifier_Protected_get_ProceduralImageModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674880);
			ProceduralImage.NativeMethodInfoPtr_set_Modifier_Protected_set_Void_ProceduralImageModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674881);
			ProceduralImage.NativeMethodInfoPtr_get_ModifierType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674882);
			ProceduralImage.NativeMethodInfoPtr_set_ModifierType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674883);
			ProceduralImage.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674896);
			ProceduralImage.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674897);
			ProceduralImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674898);
			ProceduralImage.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674884);
			ProceduralImage.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674885);
			ProceduralImage.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674886);
			ProceduralImage.NativeMethodInfoPtr_OnVerticesDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674887);
			ProceduralImage.NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674888);
			ProceduralImage.NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674889);
			ProceduralImage.NativeMethodInfoPtr_FixRadius_Private_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674890);
			ProceduralImage.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674891);
			ProceduralImage.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674892);
			ProceduralImage.NativeMethodInfoPtr_CalculateInfo_Private_ProceduralImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674893);
			ProceduralImage.NativeMethodInfoPtr_EncodeAllInfoIntoVertices_Private_Void_VertexHelper_ProceduralImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674894);
			ProceduralImage.NativeMethodInfoPtr_EncodeFloats_0_1_16_16_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr, 100674895);
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x00140F64 File Offset: 0x0013F164
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x00140F98 File Offset: 0x0013F198
		public unsafe static Material DefaultProceduralImageMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143462, XrefRangeEnd = 143479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_get_DefaultProceduralImageMaterial_Private_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143479, XrefRangeEnd = 143483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_set_DefaultProceduralImageMaterial_Private_Static_set_Void_Material_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x00140FD0 File Offset: 0x0013F1D0
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x0014100C File Offset: 0x0013F20C
		public unsafe float BorderWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0014104C File Offset: 0x0013F24C
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x00141088 File Offset: 0x0013F288
		public unsafe float FalloffDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_get_FalloffDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_set_FalloffDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x001410C8 File Offset: 0x0013F2C8
		// (set) Token: 0x06004882 RID: 18562 RVA: 0x00141108 File Offset: 0x0013F308
		public unsafe ProceduralImageModifier Modifier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 143500, RefRangeEnd = 143502, XrefRangeStart = 143483, XrefRangeEnd = 143500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_get_Modifier_Protected_get_ProceduralImageModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralImageModifier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143502, XrefRangeEnd = 143503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_set_Modifier_Protected_set_Void_ProceduralImageModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x0014114C File Offset: 0x0013F34C
		// (set) Token: 0x06004884 RID: 18564 RVA: 0x0014118C File Offset: 0x0013F38C
		public unsafe global::Il2CppSystem.Type ModifierType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143503, XrefRangeEnd = 143506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_get_ModifierType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Type>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 143530, RefRangeEnd = 143531, XrefRangeStart = 143506, XrefRangeEnd = 143530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_set_ModifierType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x001411D0 File Offset: 0x0013F3D0
		// (set) Token: 0x06004886 RID: 18566 RVA: 0x0014121C File Offset: 0x0013F41C
		public unsafe override Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143531, XrefRangeEnd = 143553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143553, XrefRangeEnd = 143554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x0014126C File Offset: 0x0013F46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143554, XrefRangeEnd = 143558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x001412A8 File Offset: 0x0013F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143558, XrefRangeEnd = 143578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x001412E4 File Offset: 0x0013F4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143578, XrefRangeEnd = 143592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00141320 File Offset: 0x0013F520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143592, XrefRangeEnd = 143611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00141354 File Offset: 0x0013F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143611, XrefRangeEnd = 143617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_OnVerticesDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00141388 File Offset: 0x0013F588
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143626, RefRangeEnd = 143629, XrefRangeStart = 143617, XrefRangeEnd = 143626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixTexCoordsInCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x001413BC File Offset: 0x0013F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143629, XrefRangeEnd = 143632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixTexCoordsInCanvas(Canvas c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00141400 File Offset: 0x0013F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143632, XrefRangeEnd = 143637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 FixRadius(Vector4 vec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_FixRadius_Private_Vector4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
			}
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00141450 File Offset: 0x0013F650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143637, XrefRangeEnd = 143640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x001414A0 File Offset: 0x0013F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143640, XrefRangeEnd = 143642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImage.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x001414DC File Offset: 0x0013F6DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143654, RefRangeEnd = 143655, XrefRangeStart = 143642, XrefRangeEnd = 143654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralImageInfo CalculateInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_CalculateInfo_Private_ProceduralImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralImageInfo>(intPtr3) : null;
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x0014151C File Offset: 0x0013F71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143665, RefRangeEnd = 143666, XrefRangeStart = 143655, XrefRangeEnd = 143665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_EncodeAllInfoIntoVertices_Private_Void_VertexHelper_ProceduralImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00141570 File Offset: 0x0013F770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143666, XrefRangeEnd = 143668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EncodeFloats_0_1_16_16(float a, float b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImage.NativeMethodInfoPtr_EncodeFloats_0_1_16_16_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x0001AF91 File Offset: 0x00019191
		public ProceduralImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x001415C8 File Offset: 0x0013F7C8
		// (set) Token: 0x06004896 RID: 18582 RVA: 0x0001AF9A File Offset: 0x0001919A
		public unsafe float borderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_borderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_borderWidth)) = value;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x001415F0 File Offset: 0x0013F7F0
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x0001AFB5 File Offset: 0x000191B5
		public unsafe ProceduralImageModifier modifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_modifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralImageModifier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x00141620 File Offset: 0x0013F820
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x0001AFD4 File Offset: 0x000191D4
		public unsafe static Material materialInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProceduralImage.NativeFieldInfoPtr_materialInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProceduralImage.NativeFieldInfoPtr_materialInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x00141648 File Offset: 0x0013F848
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x0001AFE6 File Offset: 0x000191E6
		public unsafe float falloffDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_falloffDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImage.NativeFieldInfoPtr_falloffDistance)) = value;
			}
		}

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeFieldInfoPtr_borderWidth;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeFieldInfoPtr_modifier;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeFieldInfoPtr_materialInstance;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeFieldInfoPtr_falloffDistance;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultProceduralImageMaterial_Private_Static_get_Material_0;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultProceduralImageMaterial_Private_Static_set_Void_Material_0;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeMethodInfoPtr_get_FalloffDistance_Public_get_Single_0;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeMethodInfoPtr_set_FalloffDistance_Public_set_Void_Single_0;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeMethodInfoPtr_get_Modifier_Protected_get_ProceduralImageModifier_0;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeMethodInfoPtr_set_Modifier_Protected_set_Void_ProceduralImageModifier_0;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeMethodInfoPtr_get_ModifierType_Public_get_Type_0;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeMethodInfoPtr_set_ModifierType_Public_set_Void_Type_0;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeMethodInfoPtr_OnVerticesDirty_Protected_Void_0;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_0;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeMethodInfoPtr_FixTexCoordsInCanvas_Protected_Void_Canvas_0;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeMethodInfoPtr_FixRadius_Private_Vector4_Vector4_0;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeMethodInfoPtr_CalculateInfo_Private_ProceduralImageInfo_0;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeMethodInfoPtr_EncodeAllInfoIntoVertices_Private_Void_VertexHelper_ProceduralImageInfo_0;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeMethodInfoPtr_EncodeFloats_0_1_16_16_Private_Single_Single_Single_0;
	}
}
