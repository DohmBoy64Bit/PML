using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200023E RID: 574
	[Serializable]
	public class UniversalGizmoConfig : Settings
	{
		// Token: 0x06002CEA RID: 11498 RVA: 0x000D1F80 File Offset: 0x000D0180
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmoConfig()
		{
			Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmoConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr);
			UniversalGizmoConfig.NativeFieldInfoPtr__inheritCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, "_inheritCategory");
			UniversalGizmoConfig.NativeFieldInfoPtr__inheritType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, "_inheritType");
			UniversalGizmoConfig.NativeFieldInfoPtr__displayCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, "_displayCategory");
			UniversalGizmoConfig.NativeMethodInfoPtr_get_InheritCategory_Public_get_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670090);
			UniversalGizmoConfig.NativeMethodInfoPtr_set_InheritCategory_Public_set_Void_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670091);
			UniversalGizmoConfig.NativeMethodInfoPtr_get_InheritType_Public_get_UniversalGizmoSettingsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670092);
			UniversalGizmoConfig.NativeMethodInfoPtr_set_InheritType_Public_set_Void_UniversalGizmoSettingsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670093);
			UniversalGizmoConfig.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670094);
			UniversalGizmoConfig.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670095);
			UniversalGizmoConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr, 100670096);
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000D2078 File Offset: 0x000D0278
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x000D20B8 File Offset: 0x000D02B8
		public unsafe UniversalGizmoSettingsCategory InheritCategory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_get_InheritCategory_Public_get_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_set_InheritCategory_Public_set_Void_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x000D20FC File Offset: 0x000D02FC
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x000D213C File Offset: 0x000D033C
		public unsafe UniversalGizmoSettingsType InheritType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28412, RefRangeEnd = 28413, XrefRangeStart = 28412, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_get_InheritType_Public_get_UniversalGizmoSettingsType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsType>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28413, RefRangeEnd = 28414, XrefRangeStart = 28413, XrefRangeEnd = 28414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_set_InheritType_Public_set_Void_UniversalGizmoSettingsType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000D2180 File Offset: 0x000D0380
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x000D21C0 File Offset: 0x000D03C0
		public unsafe UniversalGizmoSettingsCategory DisplayCategory
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000D2204 File Offset: 0x000D0404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96878, XrefRangeEnd = 96882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmoConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmoConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00011D7A File Offset: 0x0000FF7A
		public UniversalGizmoConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000D2240 File Offset: 0x000D0440
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00011D83 File Offset: 0x0000FF83
		public unsafe UniversalGizmoSettingsCategory _inheritCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__inheritCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__inheritCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000D2270 File Offset: 0x000D0470
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x00011DA2 File Offset: 0x0000FFA2
		public unsafe UniversalGizmoSettingsType _inheritType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__inheritType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__inheritType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000D22A0 File Offset: 0x000D04A0
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x00011DC1 File Offset: 0x0000FFC1
		public unsafe UniversalGizmoSettingsCategory _displayCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__displayCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoConfig.NativeFieldInfoPtr__displayCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr__inheritCategory;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeFieldInfoPtr__inheritType;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeFieldInfoPtr__displayCategory;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_get_InheritCategory_Public_get_UniversalGizmoSettingsCategory_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr_set_InheritCategory_Public_set_Void_UniversalGizmoSettingsCategory_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_get_InheritType_Public_get_UniversalGizmoSettingsType_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_set_InheritType_Public_set_Void_UniversalGizmoSettingsType_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
