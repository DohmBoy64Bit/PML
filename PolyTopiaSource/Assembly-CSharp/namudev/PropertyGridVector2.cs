using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200024C RID: 588
	public class PropertyGridVector2 : PropertyGridItem<Vector2>
	{
		// Token: 0x06002DBE RID: 11710 RVA: 0x000D4CA4 File Offset: 0x000D2EA4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridVector2()
		{
			Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr);
			PropertyGridVector2.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, "caption");
			PropertyGridVector2.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, "inputFieldX");
			PropertyGridVector2.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, "inputFieldY");
			PropertyGridVector2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670201);
			PropertyGridVector2.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670195);
			PropertyGridVector2.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670196);
			PropertyGridVector2.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670197);
			PropertyGridVector2.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670198);
			PropertyGridVector2.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670199);
			PropertyGridVector2.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr, 100670200);
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000D4D9C File Offset: 0x000D2F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98153, XrefRangeEnd = 98156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridVector2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridVector2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000D4DD8 File Offset: 0x000D2FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98156, XrefRangeEnd = 98178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridVector2.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000D4E14 File Offset: 0x000D3014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98178, XrefRangeEnd = 98214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000D4E48 File Offset: 0x000D3048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98214, XrefRangeEnd = 98221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000D4E8C File Offset: 0x000D308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98221, XrefRangeEnd = 98236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x000D4ED0 File Offset: 0x000D30D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98236, XrefRangeEnd = 98243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x000D4F14 File Offset: 0x000D3114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98243, XrefRangeEnd = 98258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector2.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x0001239B File Offset: 0x0001059B
		public PropertyGridVector2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000D4F58 File Offset: 0x000D3158
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x000123A4 File Offset: 0x000105A4
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000D4F88 File Offset: 0x000D3188
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x000123C3 File Offset: 0x000105C3
		public unsafe GameObject inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000D4FB8 File Offset: 0x000D31B8
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x000123E2 File Offset: 0x000105E2
		public unsafe GameObject inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector2.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0;
	}
}
