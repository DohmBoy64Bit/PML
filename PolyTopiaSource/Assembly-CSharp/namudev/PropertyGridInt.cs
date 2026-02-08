using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000245 RID: 581
	public class PropertyGridInt : PropertyGridItem<int>
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x000D3C18 File Offset: 0x000D1E18
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGridInt()
		{
			Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "namudev", "PropertyGridInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr);
			PropertyGridInt.NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, "caption");
			PropertyGridInt.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, "controls");
			PropertyGridInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, 100670159);
			PropertyGridInt.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, 100670155);
			PropertyGridInt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, 100670156);
			PropertyGridInt.NativeMethodInfoPtr_OnValueChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, 100670157);
			PropertyGridInt.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr, 100670158);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000D3CD4 File Offset: 0x000D1ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97724, XrefRangeEnd = 97783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGridInt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGridInt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000D3D10 File Offset: 0x000D1F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97783, XrefRangeEnd = 97799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyGridInt.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000D3D4C File Offset: 0x000D1F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97799, XrefRangeEnd = 97822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridInt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000D3D80 File Offset: 0x000D1F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97822, XrefRangeEnd = 97826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChange(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridInt.NativeMethodInfoPtr_OnValueChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000D3DC4 File Offset: 0x000D1FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97826, XrefRangeEnd = 97838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEdit(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGridInt.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00012157 File Offset: 0x00010357
		public PropertyGridInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x000D3E08 File Offset: 0x000D2008
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00012160 File Offset: 0x00010360
		public unsafe GameObject caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridInt.NativeFieldInfoPtr_caption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridInt.NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000D3E38 File Offset: 0x000D2038
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x0001217F File Offset: 0x0001037F
		public unsafe GameObject controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridInt.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyGridInt.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeFieldInfoPtr_caption;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_String_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0;
	}
}
