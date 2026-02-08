using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000222 RID: 546
	[Serializable]
	public class ObjectSelectionRotationSettings : Settings
	{
		// Token: 0x06002A9F RID: 10911 RVA: 0x000C9CF4 File Offset: 0x000C7EF4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionRotationSettings()
		{
			Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionRotationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr);
			ObjectSelectionRotationSettings.NativeFieldInfoPtr__rotationPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, "_rotationPivot");
			ObjectSelectionRotationSettings.NativeFieldInfoPtr__keyRotationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, "_keyRotationSettings");
			ObjectSelectionRotationSettings.NativeMethodInfoPtr_get_RotationPivot_Public_get_ObjectRotationPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, 100669785);
			ObjectSelectionRotationSettings.NativeMethodInfoPtr_set_RotationPivot_Public_set_Void_ObjectRotationPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, 100669786);
			ObjectSelectionRotationSettings.NativeMethodInfoPtr_get_KeyRotationSettings_Public_get_ObjectKeyRotationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, 100669787);
			ObjectSelectionRotationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr, 100669788);
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000C9D9C File Offset: 0x000C7F9C
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x000C9DDC File Offset: 0x000C7FDC
		public unsafe ObjectRotationPivot RotationPivot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationSettings.NativeMethodInfoPtr_get_RotationPivot_Public_get_ObjectRotationPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectRotationPivot>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationSettings.NativeMethodInfoPtr_set_RotationPivot_Public_set_Void_ObjectRotationPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000C9E20 File Offset: 0x000C8020
		public unsafe ObjectKeyRotationSettings KeyRotationSettings
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationSettings.NativeMethodInfoPtr_get_KeyRotationSettings_Public_get_ObjectKeyRotationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectKeyRotationSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000C9E60 File Offset: 0x000C8060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93576, XrefRangeEnd = 93582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionRotationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionRotationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00010D8A File Offset: 0x0000EF8A
		public ObjectSelectionRotationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000C9E9C File Offset: 0x000C809C
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x00010D93 File Offset: 0x0000EF93
		public unsafe ObjectRotationPivot _rotationPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationSettings.NativeFieldInfoPtr__rotationPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectRotationPivot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationSettings.NativeFieldInfoPtr__rotationPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000C9ECC File Offset: 0x000C80CC
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x00010DB2 File Offset: 0x0000EFB2
		public unsafe ObjectKeyRotationSettings _keyRotationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationSettings.NativeFieldInfoPtr__keyRotationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectKeyRotationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationSettings.NativeFieldInfoPtr__keyRotationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr__rotationPivot;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr__keyRotationSettings;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationPivot_Public_get_ObjectRotationPivot_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationPivot_Public_set_Void_ObjectRotationPivot_0;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyRotationSettings_Public_get_ObjectKeyRotationSettings_0;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
