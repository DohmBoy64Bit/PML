using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AB RID: 683
	public class SkyBase : Instance
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x001071D4 File Offset: 0x001053D4
		// Note: this type is marked as 'beforefieldinit'.
		static SkyBase()
		{
			Il2CppClassPointerStore<SkyBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "SkyBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyBase>.NativeClassPtr);
			SkyBase.NativeFieldInfoPtr_skyboxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, "skyboxMaterial");
			SkyBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672207);
			SkyBase.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672203);
			SkyBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672204);
			SkyBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672205);
			SkyBase.NativeMethodInfoPtr_Apply_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672206);
			SkyBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBase>.NativeClassPtr, 100672208);
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00107290 File Offset: 0x00105490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117851, RefRangeEnd = 117853, XrefRangeStart = 117847, XrefRangeEnd = 117851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001072CC File Offset: 0x001054CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117187, RefRangeEnd = 117189, XrefRangeStart = 117187, XrefRangeEnd = 117189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBase.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00107308 File Offset: 0x00105508
		[CallerCount(0)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x00107344 File Offset: 0x00105544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117853, XrefRangeEnd = 117863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00107380 File Offset: 0x00105580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117874, RefRangeEnd = 117876, XrefRangeStart = 117863, XrefRangeEnd = 117874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBase.NativeMethodInfoPtr_Apply_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x001073BC File Offset: 0x001055BC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0001682A File Offset: 0x00014A2A
		public SkyBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00107404 File Offset: 0x00105604
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x00016833 File Offset: 0x00014A33
		public unsafe Material skyboxMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBase.NativeFieldInfoPtr_skyboxMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBase.NativeFieldInfoPtr_skyboxMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeFieldInfoPtr_skyboxMaterial;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Protected_Virtual_New_Void_0;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
