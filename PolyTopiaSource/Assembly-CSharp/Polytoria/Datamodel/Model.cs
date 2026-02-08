using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Polytoria.Datamodel
{
	// Token: 0x02000290 RID: 656
	public class Model : DynamicInstance
	{
		// Token: 0x06003453 RID: 13395 RVA: 0x000EEA44 File Offset: 0x000ECC44
		// Note: this type is marked as 'beforefieldinit'.
		static Model()
		{
			Il2CppClassPointerStore<Model>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Model");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Model>.NativeClassPtr);
			Model.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Model>.NativeClassPtr, 100671210);
			Model.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Model>.NativeClassPtr, 100671208);
			Model.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Model>.NativeClassPtr, 100671209);
			Model.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Model>.NativeClassPtr, 100671211);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x000EEAC4 File Offset: 0x000ECCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106911, XrefRangeEnd = 106915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Model()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Model>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Model.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x000EEB00 File Offset: 0x000ECD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Model.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x000EEB3C File Offset: 0x000ECD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Model.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x000EEB78 File Offset: 0x000ECD78
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Model.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x000149E4 File Offset: 0x00012BE4
		public Model(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
