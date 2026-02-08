using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000068 RID: 104
	public class GizmoLabelMaterial : Singleton<GizmoLabelMaterial>
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0003DEB4 File Offset: 0x0003C0B4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLabelMaterial()
		{
			Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLabelMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr);
			GizmoLabelMaterial.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, "_material");
			GizmoLabelMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664408);
			GizmoLabelMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664417);
			GizmoLabelMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664409);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetTexture_Public_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664410);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664411);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664412);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664413);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664414);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664415);
			GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr, 100664416);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
		public unsafe Material Material
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 61879, RefRangeEnd = 61892, XrefRangeStart = 61867, XrefRangeEnd = 61879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0003E000 File Offset: 0x0003C200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61892, XrefRangeEnd = 61898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLabelMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLabelMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003E03C File Offset: 0x0003C23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61898, XrefRangeEnd = 61903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetValuesToSensibleDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003E070 File Offset: 0x0003C270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61903, XrefRangeEnd = 61908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(Texture2D texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetTexture_Public_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003E0B4 File Offset: 0x0003C2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61908, XrefRangeEnd = 61912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003E0F8 File Offset: 0x0003C2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61912, XrefRangeEnd = 61915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPass(int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003E138 File Offset: 0x0003C338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61915, XrefRangeEnd = 61920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZWriteEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003E178 File Offset: 0x0003C378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61920, XrefRangeEnd = 61925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLessEqual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0003E1AC File Offset: 0x0003C3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61925, XrefRangeEnd = 61930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestAlways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61930, XrefRangeEnd = 61935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLabelMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000047D3 File Offset: 0x000029D3
		public GizmoLabelMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0003E214 File Offset: 0x0003C414
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000047DC File Offset: 0x000029DC
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLabelMaterial.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLabelMaterial.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_Material_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Texture2D_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_SetPass_Public_Void_Int32_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestAlways_Public_Void_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLess_Public_Void_0;
	}
}
