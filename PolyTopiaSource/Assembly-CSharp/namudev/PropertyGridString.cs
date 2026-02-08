using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200024A RID: 586
	public class PropertyGridString : PropertyGridItem<string>
	{
		// Token: 0x06002DAE RID: 11694 RVA: 0x000D49A4 File Offset: 0x000D2BA4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridString()
		{
			Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr);
			PropertyGridString.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, "caption");
			PropertyGridString.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, "controls");
			PropertyGridString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, 100670191);
			PropertyGridString.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, 100670189);
			PropertyGridString.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, 100670190);
			PropertyGridString.NativeMethodInfoPtr__Start_b__3_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr, 100670192);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000D4A4C File Offset: 0x000D2C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98108, XrefRangeEnd = 98111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000D4A88 File Offset: 0x000D2C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98111, XrefRangeEnd = 98127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridString.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000D4AC4 File Offset: 0x000D2CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98127, XrefRangeEnd = 98150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridString.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000D4AF8 File Offset: 0x000D2CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98150, XrefRangeEnd = 98153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__3_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridString.NativeMethodInfoPtr__Start_b__3_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x0001232C File Offset: 0x0001052C
		public PropertyGridString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000D4B3C File Offset: 0x000D2D3C
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x00012335 File Offset: 0x00010535
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridString.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridString.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000D4B6C File Offset: 0x000D2D6C
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x00012354 File Offset: 0x00010554
		public unsafe GameObject controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridString.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridString.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Private_Void_String_0;
	}
}
