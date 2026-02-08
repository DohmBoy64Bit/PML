using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006A RID: 106
	public class GizmoSolidMaterial : Singleton<GizmoSolidMaterial>
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x0003E57C File Offset: 0x0003C77C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoSolidMaterial()
		{
			Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoSolidMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr);
			GizmoSolidMaterial.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, "_material");
			GizmoSolidMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664427);
			GizmoSolidMaterial.NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664428);
			GizmoSolidMaterial.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664429);
			GizmoSolidMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664430);
			GizmoSolidMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664431);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664432);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664433);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664434);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664435);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664436);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664437);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664438);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664439);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664440);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeFront_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664441);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664442);
			GizmoSolidMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr, 100664443);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0003E714 File Offset: 0x0003C914
		public unsafe Material Material
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 62058, RefRangeEnd = 62082, XrefRangeStart = 62046, XrefRangeEnd = 62058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0003E754 File Offset: 0x0003C954
		public unsafe bool IsLit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62086, RefRangeEnd = 62088, XrefRangeStart = 62082, XrefRangeEnd = 62086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0003E790 File Offset: 0x0003C990
		public unsafe float LightIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62088, XrefRangeEnd = 62093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0003E7CC File Offset: 0x0003C9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62093, XrefRangeEnd = 62120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoSolidMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoSolidMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0003E808 File Offset: 0x0003CA08
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 62141, RefRangeEnd = 62150, XrefRangeStart = 62120, XrefRangeEnd = 62141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetValuesToSensibleDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0003E83C File Offset: 0x0003CA3C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 62155, RefRangeEnd = 62164, XrefRangeStart = 62150, XrefRangeEnd = 62155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLit(bool isLit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0003E87C File Offset: 0x0003CA7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62168, RefRangeEnd = 62172, XrefRangeStart = 62164, XrefRangeEnd = 62168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightDirection(Vector3 lightDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lightDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62172, XrefRangeEnd = 62177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intensity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0003E900 File Offset: 0x0003CB00
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 62181, RefRangeEnd = 62190, XrefRangeStart = 62177, XrefRangeEnd = 62181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0003E944 File Offset: 0x0003CB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62190, XrefRangeEnd = 62195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZWriteEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0003E984 File Offset: 0x0003CB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62195, XrefRangeEnd = 62200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0003E9C4 File Offset: 0x0003CBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62200, XrefRangeEnd = 62205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestAlways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62205, XrefRangeEnd = 62210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0003EA2C File Offset: 0x0003CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62210, XrefRangeEnd = 62215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0003EA60 File Offset: 0x0003CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62215, XrefRangeEnd = 62220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeFront_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0003EA94 File Offset: 0x0003CC94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62225, RefRangeEnd = 62228, XrefRangeStart = 62220, XrefRangeEnd = 62225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCullModeOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetCullModeOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 62231, RefRangeEnd = 62241, XrefRangeStart = 62228, XrefRangeEnd = 62231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPass(int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSolidMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00004823 File Offset: 0x00002A23
		public GizmoSolidMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0003EB08 File Offset: 0x0003CD08
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0000482C File Offset: 0x00002A2C
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSolidMaterial.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSolidMaterial.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_Material_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLit_Public_get_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_SetLit_Public_Void_Boolean_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_SetLightDirection_Public_Void_Vector3_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIntensity_Public_Void_Single_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestEnabled_Public_Void_Boolean_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestAlways_Public_Void_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLess_Public_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeBack_Public_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeFront_Public_Void_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeOff_Public_Void_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_SetPass_Public_Void_Int32_0;
	}
}
