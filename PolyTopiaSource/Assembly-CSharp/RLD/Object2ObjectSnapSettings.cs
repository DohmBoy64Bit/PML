using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class Object2ObjectSnapSettings : Settings
	{
		// Token: 0x06002319 RID: 8985 RVA: 0x000AC3A8 File Offset: 0x000AA5A8
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapSettings()
		{
			Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr);
			Object2ObjectSnapSettings.NativeFieldInfoPtr__snapDestinationLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, "_snapDestinationLayers");
			Object2ObjectSnapSettings.NativeFieldInfoPtr__canClimbObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, "_canClimbObjects");
			Object2ObjectSnapSettings.NativeFieldInfoPtr__snapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, "_snapRadius");
			Object2ObjectSnapSettings.NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668578);
			Object2ObjectSnapSettings.NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668579);
			Object2ObjectSnapSettings.NativeMethodInfoPtr_get_CanClimbObjects_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668580);
			Object2ObjectSnapSettings.NativeMethodInfoPtr_set_CanClimbObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668581);
			Object2ObjectSnapSettings.NativeMethodInfoPtr_get_SnapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668582);
			Object2ObjectSnapSettings.NativeMethodInfoPtr_set_SnapRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668583);
			Object2ObjectSnapSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr, 100668584);
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x000AC4DC File Offset: 0x000AA6DC
		public unsafe int SnapDestinationLayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000AC51C File Offset: 0x000AA71C
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000AC558 File Offset: 0x000AA758
		public unsafe bool CanClimbObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_get_CanClimbObjects_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_set_CanClimbObjects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000AC598 File Offset: 0x000AA798
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x000AC5D4 File Offset: 0x000AA7D4
		public unsafe float SnapRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_get_SnapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 67305, RefRangeEnd = 67314, XrefRangeStart = 67305, XrefRangeEnd = 67314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr_set_SnapRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000AC614 File Offset: 0x000AA814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87744, RefRangeEnd = 87745, XrefRangeStart = 87743, XrefRangeEnd = 87744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
		public Object2ObjectSnapSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000AC650 File Offset: 0x000AA850
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000E5DF File Offset: 0x0000C7DF
		public unsafe int _snapDestinationLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__snapDestinationLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__snapDestinationLayers)) = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000AC678 File Offset: 0x000AA878
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0000E5FA File Offset: 0x0000C7FA
		public unsafe bool _canClimbObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__canClimbObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__canClimbObjects)) = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000AC6A0 File Offset: 0x000AA8A0
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0000E615 File Offset: 0x0000C815
		public unsafe float _snapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__snapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapSettings.NativeFieldInfoPtr__snapRadius)) = value;
			}
		}

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr__snapDestinationLayers;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeFieldInfoPtr__canClimbObjects;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr__snapRadius;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapDestinationLayers_Public_get_Int32_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_set_SnapDestinationLayers_Public_set_Void_Int32_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_get_CanClimbObjects_Public_get_Boolean_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_set_CanClimbObjects_Public_set_Void_Boolean_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapRadius_Public_get_Single_0;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeMethodInfoPtr_set_SnapRadius_Public_set_Void_Single_0;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
