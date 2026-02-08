using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200024E RID: 590
	public class PropertyGridVector4 : PropertyGridItem<Vector4>
	{
		// Token: 0x06002DE0 RID: 11744 RVA: 0x000D5420 File Offset: 0x000D3620
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridVector4()
		{
			Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridVector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr);
			PropertyGridVector4.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, "caption");
			PropertyGridVector4.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, "inputFieldX");
			PropertyGridVector4.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, "inputFieldY");
			PropertyGridVector4.NativeFieldInfoPtr_inputFieldZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, "inputFieldZ");
			PropertyGridVector4.NativeFieldInfoPtr_inputFieldW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, "inputFieldW");
			PropertyGridVector4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670221);
			PropertyGridVector4.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670211);
			PropertyGridVector4.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670212);
			PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670213);
			PropertyGridVector4.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670214);
			PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670215);
			PropertyGridVector4.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670216);
			PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670217);
			PropertyGridVector4.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670218);
			PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeW_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670219);
			PropertyGridVector4.NativeMethodInfoPtr_OnEndEditW_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr, 100670220);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000D5590 File Offset: 0x000D3790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98404, XrefRangeEnd = 98407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridVector4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridVector4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000D55CC File Offset: 0x000D37CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98407, XrefRangeEnd = 98441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridVector4.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000D5608 File Offset: 0x000D3808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98441, XrefRangeEnd = 98503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000D563C File Offset: 0x000D383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98503, XrefRangeEnd = 98510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000D5680 File Offset: 0x000D3880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98510, XrefRangeEnd = 98525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000D56C4 File Offset: 0x000D38C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98525, XrefRangeEnd = 98532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000D5708 File Offset: 0x000D3908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98532, XrefRangeEnd = 98547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x000D574C File Offset: 0x000D394C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98547, XrefRangeEnd = 98554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000D5790 File Offset: 0x000D3990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98554, XrefRangeEnd = 98569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000D57D4 File Offset: 0x000D39D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98569, XrefRangeEnd = 98576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeW(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnValueChangeW_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000D5818 File Offset: 0x000D3A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98576, XrefRangeEnd = 98591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditW(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector4.NativeMethodInfoPtr_OnEndEditW_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x00012486 File Offset: 0x00010686
		public PropertyGridVector4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000D585C File Offset: 0x000D3A5C
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x0001248F File Offset: 0x0001068F
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000D588C File Offset: 0x000D3A8C
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x000124AE File Offset: 0x000106AE
		public unsafe GameObject inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x000D58BC File Offset: 0x000D3ABC
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x000124CD File Offset: 0x000106CD
		public unsafe GameObject inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000D58EC File Offset: 0x000D3AEC
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x000124EC File Offset: 0x000106EC
		public unsafe GameObject inputFieldZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000D591C File Offset: 0x000D3B1C
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x0001250B File Offset: 0x0001070B
		public unsafe GameObject inputFieldW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector4.NativeFieldInfoPtr_inputFieldW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldZ;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldW;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeW_Private_Void_String_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditW_Private_Void_String_0;
	}
}
