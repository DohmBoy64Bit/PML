using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	public class Settings : Object
	{
		// Token: 0x06001AD3 RID: 6867 RVA: 0x0008968C File Offset: 0x0008788C
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr__canBeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_canBeDisplayed");
			Settings.NativeFieldInfoPtr__isExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_isExpanded");
			Settings.NativeFieldInfoPtr__foldoutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_foldoutLabel");
			Settings.NativeFieldInfoPtr__UsesFoldout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<UsesFoldout>k__BackingField");
			Settings.NativeMethodInfoPtr_get_CanBeDisplayed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667290);
			Settings.NativeMethodInfoPtr_set_CanBeDisplayed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667291);
			Settings.NativeMethodInfoPtr_get_UsesFoldout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667292);
			Settings.NativeMethodInfoPtr_set_UsesFoldout_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667293);
			Settings.NativeMethodInfoPtr_get_FoldoutLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667294);
			Settings.NativeMethodInfoPtr_set_FoldoutLabel_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667295);
			Settings.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667296);
			Settings.NativeMethodInfoPtr_set_IsExpanded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667297);
			Settings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100667298);
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x000897C0 File Offset: 0x000879C0
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x000897FC File Offset: 0x000879FC
		public unsafe bool CanBeDisplayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_CanBeDisplayed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_CanBeDisplayed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0008983C File Offset: 0x00087A3C
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x00089878 File Offset: 0x00087A78
		public unsafe bool UsesFoldout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_UsesFoldout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_UsesFoldout_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x000898B8 File Offset: 0x00087AB8
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x000898F0 File Offset: 0x00087AF0
		public unsafe string FoldoutLabel
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_FoldoutLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_FoldoutLabel_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00089934 File Offset: 0x00087B34
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x00089970 File Offset: 0x00087B70
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_IsExpanded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000899B0 File Offset: 0x00087BB0
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 75968, RefRangeEnd = 76031, XrefRangeStart = 75963, XrefRangeEnd = 75968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0000BB1D File Offset: 0x00009D1D
		public Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000899EC File Offset: 0x00087BEC
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000BB26 File Offset: 0x00009D26
		public unsafe bool _canBeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__canBeDisplayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__canBeDisplayed)) = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x00089A14 File Offset: 0x00087C14
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000BB41 File Offset: 0x00009D41
		public unsafe bool _isExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__isExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__isExpanded)) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00089A3C File Offset: 0x00087C3C
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public unsafe string _foldoutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__foldoutLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__foldoutLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x00089A64 File Offset: 0x00087C64
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000BB7B File Offset: 0x00009D7B
		public unsafe bool _UsesFoldout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__UsesFoldout_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__UsesFoldout_k__BackingField)) = value;
			}
		}

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr__canBeDisplayed;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr__isExpanded;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr__foldoutLabel;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr__UsesFoldout_k__BackingField;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeDisplayed_Public_get_Boolean_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeDisplayed_Public_set_Void_Boolean_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_get_UsesFoldout_Public_get_Boolean_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_set_UsesFoldout_Public_set_Void_Boolean_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_get_FoldoutLabel_Public_get_String_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_set_FoldoutLabel_Public_set_Void_String_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExpanded_Public_set_Void_Boolean_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
