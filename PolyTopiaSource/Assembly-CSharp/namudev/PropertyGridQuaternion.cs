using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000248 RID: 584
	public class PropertyGridQuaternion : PropertyGridItem<Quaternion>
	{
		// Token: 0x06002D8C RID: 11660 RVA: 0x000D42B8 File Offset: 0x000D24B8
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridQuaternion()
		{
			Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridQuaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr);
			PropertyGridQuaternion.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, "caption");
			PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, "inputFieldX");
			PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, "inputFieldY");
			PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, "inputFieldZ");
			PropertyGridQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670182);
			PropertyGridQuaternion.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670174);
			PropertyGridQuaternion.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670175);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670176);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670177);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670178);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670179);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670180);
			PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr, 100670181);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000D43EC File Offset: 0x000D25EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97843, XrefRangeEnd = 97846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridQuaternion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridQuaternion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000D4428 File Offset: 0x000D2628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97846, XrefRangeEnd = 97874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridQuaternion.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x000D4464 File Offset: 0x000D2664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97874, XrefRangeEnd = 97929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000D4498 File Offset: 0x000D2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97929, XrefRangeEnd = 97939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000D44DC File Offset: 0x000D26DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97939, XrefRangeEnd = 97959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000D4520 File Offset: 0x000D2720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97959, XrefRangeEnd = 97969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000D4564 File Offset: 0x000D2764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97969, XrefRangeEnd = 97989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000D45A8 File Offset: 0x000D27A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97989, XrefRangeEnd = 97999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000D45EC File Offset: 0x000D27EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97999, XrefRangeEnd = 98019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridQuaternion.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x0001222F File Offset: 0x0001042F
		public PropertyGridQuaternion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000D4630 File Offset: 0x000D2830
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x00012238 File Offset: 0x00010438
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000D4660 File Offset: 0x000D2860
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x00012257 File Offset: 0x00010457
		public unsafe GameObject inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000D4690 File Offset: 0x000D2890
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x00012276 File Offset: 0x00010476
		public unsafe GameObject inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000D46C0 File Offset: 0x000D28C0
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x00012295 File Offset: 0x00010495
		public unsafe GameObject inputFieldZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridQuaternion.NativeFieldInfoPtr_inputFieldZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldZ;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0;
	}
}
