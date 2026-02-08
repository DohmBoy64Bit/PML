using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000069 RID: 105
	public class GizmoLineMaterial : Singleton<GizmoLineMaterial>
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0003E244 File Offset: 0x0003C444
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineMaterial()
		{
			Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr);
			GizmoLineMaterial.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, "_material");
			GizmoLineMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664418);
			GizmoLineMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664426);
			GizmoLineMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664419);
			GizmoLineMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664420);
			GizmoLineMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664421);
			GizmoLineMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664422);
			GizmoLineMaterial.NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664423);
			GizmoLineMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664424);
			GizmoLineMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr, 100664425);
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0003E33C File Offset: 0x0003C53C
		public unsafe Material Material
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 61947, RefRangeEnd = 61965, XrefRangeStart = 61935, XrefRangeEnd = 61947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_get_Material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0003E37C File Offset: 0x0003C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61965, XrefRangeEnd = 61971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 61980, RefRangeEnd = 61995, XrefRangeStart = 61971, XrefRangeEnd = 61980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetValuesToSensibleDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0003E3EC File Offset: 0x0003C5EC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 61999, RefRangeEnd = 62011, XrefRangeStart = 61995, XrefRangeEnd = 61999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0003E430 File Offset: 0x0003C630
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 62014, RefRangeEnd = 62026, XrefRangeStart = 62011, XrefRangeEnd = 62014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPass(int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetPass_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0003E470 File Offset: 0x0003C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62026, XrefRangeEnd = 62031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZWriteEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003E4B0 File Offset: 0x0003C6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62031, XrefRangeEnd = 62036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLessEqual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62036, XrefRangeEnd = 62041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestAlways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetZTestAlways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003E518 File Offset: 0x0003C718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62041, XrefRangeEnd = 62046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZTestLess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineMaterial.NativeMethodInfoPtr_SetZTestLess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000047FB File Offset: 0x000029FB
		public GizmoLineMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0003E54C File Offset: 0x0003C74C
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00004804 File Offset: 0x00002A04
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineMaterial.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineMaterial.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_Material_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_ResetValuesToSensibleDefaults_Public_Void_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_SetPass_Public_Void_Int32_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_SetZWriteEnabled_Public_Void_Boolean_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLessEqual_Public_Void_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestAlways_Public_Void_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLess_Public_Void_0;
	}
}
