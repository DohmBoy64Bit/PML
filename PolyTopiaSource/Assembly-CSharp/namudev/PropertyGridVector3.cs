using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200024D RID: 589
	public class PropertyGridVector3 : PropertyGridItem<Vector3>
	{
		// Token: 0x06002DCD RID: 11725 RVA: 0x000D4FE8 File Offset: 0x000D31E8
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridVector3()
		{
			Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr);
			PropertyGridVector3.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, "caption");
			PropertyGridVector3.NativeFieldInfoPtr_inputFieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, "inputFieldX");
			PropertyGridVector3.NativeFieldInfoPtr_inputFieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, "inputFieldY");
			PropertyGridVector3.NativeFieldInfoPtr_inputFieldZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, "inputFieldZ");
			PropertyGridVector3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670210);
			PropertyGridVector3.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670202);
			PropertyGridVector3.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670203);
			PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670204);
			PropertyGridVector3.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670205);
			PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670206);
			PropertyGridVector3.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670207);
			PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670208);
			PropertyGridVector3.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr, 100670209);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000D511C File Offset: 0x000D331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98258, XrefRangeEnd = 98261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridVector3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridVector3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000D5158 File Offset: 0x000D3358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98261, XrefRangeEnd = 98289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridVector3.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000D5194 File Offset: 0x000D3394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98289, XrefRangeEnd = 98338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000D51C8 File Offset: 0x000D33C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98338, XrefRangeEnd = 98345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000D520C File Offset: 0x000D340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98345, XrefRangeEnd = 98360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditX(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000D5250 File Offset: 0x000D3450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98360, XrefRangeEnd = 98367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000D5294 File Offset: 0x000D3494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98367, XrefRangeEnd = 98382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditY(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000D52D8 File Offset: 0x000D34D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98382, XrefRangeEnd = 98389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChangeZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000D531C File Offset: 0x000D351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98389, XrefRangeEnd = 98404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEditZ(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridVector3.NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00012401 File Offset: 0x00010601
		public PropertyGridVector3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x000D5360 File Offset: 0x000D3560
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x0001240A File Offset: 0x0001060A
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000D5390 File Offset: 0x000D3590
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x00012429 File Offset: 0x00010629
		public unsafe GameObject inputFieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000D53C0 File Offset: 0x000D35C0
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00012448 File Offset: 0x00010648
		public unsafe GameObject inputFieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000D53F0 File Offset: 0x000D35F0
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00012467 File Offset: 0x00010667
		public unsafe GameObject inputFieldZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridVector3.NativeFieldInfoPtr_inputFieldZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldX;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldY;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldZ;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeX_Private_Void_String_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditX_Private_Void_String_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeY_Private_Void_String_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditY_Private_Void_String_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChangeZ_Private_Void_String_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEditZ_Private_Void_String_0;
	}
}
