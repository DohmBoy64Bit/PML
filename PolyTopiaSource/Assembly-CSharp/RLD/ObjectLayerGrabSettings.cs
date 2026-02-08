using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public class ObjectLayerGrabSettings : Object
	{
		// Token: 0x0600244C RID: 9292 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectLayerGrabSettings()
		{
			Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectLayerGrabSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr);
			ObjectLayerGrabSettings.NativeFieldInfoPtr__layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, "_layer");
			ObjectLayerGrabSettings.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, "_isActive");
			ObjectLayerGrabSettings.NativeFieldInfoPtr__alignAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, "_alignAxis");
			ObjectLayerGrabSettings.NativeFieldInfoPtr__alignmentAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, "_alignmentAxis");
			ObjectLayerGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, "_defaultOffsetFromSurface");
			ObjectLayerGrabSettings.NativeMethodInfoPtr_get_Layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668726);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668727);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668728);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668729);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668730);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668731);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668732);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668733);
			ObjectLayerGrabSettings.NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668734);
			ObjectLayerGrabSettings.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr, 100668735);
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000B0714 File Offset: 0x000AE914
		public unsafe int Layer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_get_Layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000B0750 File Offset: 0x000AE950
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x000B078C File Offset: 0x000AE98C
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000B07CC File Offset: 0x000AE9CC
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x000B0808 File Offset: 0x000AEA08
		public unsafe bool AlignAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000B0848 File Offset: 0x000AEA48
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x000B0888 File Offset: 0x000AEA88
		public unsafe TransformAxis AlignmentAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAxis>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x000B08CC File Offset: 0x000AEACC
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x000B0908 File Offset: 0x000AEB08
		public unsafe float DefaultOffsetFromSurface
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57146, RefRangeEnd = 57149, XrefRangeStart = 57146, XrefRangeEnd = 57149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x000B0948 File Offset: 0x000AEB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88769, XrefRangeEnd = 88770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectLayerGrabSettings(int layer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectLayerGrabSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLayerGrabSettings.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000EE2A File Offset: 0x0000D02A
		public ObjectLayerGrabSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000B0990 File Offset: 0x000AEB90
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0000EE33 File Offset: 0x0000D033
		public unsafe int _layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__layer)) = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000B09B8 File Offset: 0x000AEBB8
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0000EE4E File Offset: 0x0000D04E
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000B09E0 File Offset: 0x000AEBE0
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0000EE69 File Offset: 0x0000D069
		public unsafe bool _alignAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__alignAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__alignAxis)) = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000B0A08 File Offset: 0x000AEC08
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0000EE84 File Offset: 0x0000D084
		public unsafe TransformAxis _alignmentAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__alignmentAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransformAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__alignmentAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000B0A38 File Offset: 0x000AEC38
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0000EEA3 File Offset: 0x0000D0A3
		public unsafe float _defaultOffsetFromSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLayerGrabSettings.NativeFieldInfoPtr__defaultOffsetFromSurface)) = value;
			}
		}

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeFieldInfoPtr__layer;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeFieldInfoPtr__alignAxis;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeFieldInfoPtr__alignmentAxis;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeFieldInfoPtr__defaultOffsetFromSurface;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_get_Layer_Public_get_Int32_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Public_set_Void_Boolean_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_get_AlignAxis_Public_get_Boolean_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignAxis_Public_set_Void_Boolean_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_get_AlignmentAxis_Public_get_TransformAxis_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignmentAxis_Public_set_Void_TransformAxis_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultOffsetFromSurface_Public_get_Single_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultOffsetFromSurface_Public_set_Void_Single_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
