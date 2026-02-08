using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000244 RID: 580
	public class PropertyGridFloat : PropertyGridItem<float>
	{
		// Token: 0x06002D63 RID: 11619 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridFloat()
		{
			Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr);
			PropertyGridFloat.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, "caption");
			PropertyGridFloat.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, "controls");
			PropertyGridFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, 100670154);
			PropertyGridFloat.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, 100670150);
			PropertyGridFloat.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, 100670151);
			PropertyGridFloat.NativeMethodInfoPtr_OnValueChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, 100670152);
			PropertyGridFloat.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr, 100670153);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000D3A84 File Offset: 0x000D1C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97666, XrefRangeEnd = 97669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridFloat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridFloat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000D3AC0 File Offset: 0x000D1CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97669, XrefRangeEnd = 97685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridFloat.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000D3AFC File Offset: 0x000D1CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97685, XrefRangeEnd = 97708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridFloat.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000D3B30 File Offset: 0x000D1D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97708, XrefRangeEnd = 97712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChange(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridFloat.NativeMethodInfoPtr_OnValueChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000D3B74 File Offset: 0x000D1D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97712, XrefRangeEnd = 97724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEdit(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridFloat.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00012110 File Offset: 0x00010310
		public PropertyGridFloat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000D3BB8 File Offset: 0x000D1DB8
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x00012119 File Offset: 0x00010319
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridFloat.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridFloat.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000D3BE8 File Offset: 0x000D1DE8
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x00012138 File Offset: 0x00010338
		public unsafe GameObject controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridFloat.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridFloat.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_String_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0;
	}
}
