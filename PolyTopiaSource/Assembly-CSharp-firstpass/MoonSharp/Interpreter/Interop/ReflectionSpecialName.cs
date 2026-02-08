using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AB RID: 171
	public sealed class ReflectionSpecialName : ValueType
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x0004982C File Offset: 0x00047A2C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionSpecialName()
		{
			Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "ReflectionSpecialName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr);
			ReflectionSpecialName.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, "<Type>k__BackingField");
			ReflectionSpecialName.NativeFieldInfoPtr__Argument_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, "<Argument>k__BackingField");
			ReflectionSpecialName.NativeMethodInfoPtr_get_Type_Public_get_ReflectionSpecialNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665565);
			ReflectionSpecialName.NativeMethodInfoPtr_set_Type_Private_set_Void_ReflectionSpecialNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665566);
			ReflectionSpecialName.NativeMethodInfoPtr_get_Argument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665567);
			ReflectionSpecialName.NativeMethodInfoPtr_set_Argument_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665568);
			ReflectionSpecialName.NativeMethodInfoPtr__ctor_Public_Void_ReflectionSpecialNameType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665569);
			ReflectionSpecialName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr, 100665570);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000498FC File Offset: 0x00047AFC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00049940 File Offset: 0x00047B40
		public unsafe ReflectionSpecialNameType Type
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 33677, RefRangeEnd = 33740, XrefRangeStart = 33677, XrefRangeEnd = 33677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr_get_Type_Public_get_ReflectionSpecialNameType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionSpecialNameType>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 33740, RefRangeEnd = 33751, XrefRangeStart = 33740, XrefRangeEnd = 33740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr_set_Type_Private_set_Void_ReflectionSpecialNameType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00049988 File Offset: 0x00047B88
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000499C4 File Offset: 0x00047BC4
		public unsafe string Argument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr_get_Argument_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33751, XrefRangeEnd = 33752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr_set_Argument_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00049A0C File Offset: 0x00047C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33752, XrefRangeEnd = 33753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionSpecialName(ReflectionSpecialNameType type, string argument = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr__ctor_Public_Void_ReflectionSpecialNameType_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00049A70 File Offset: 0x00047C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33753, XrefRangeEnd = 33812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionSpecialName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSpecialName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00005E15 File Offset: 0x00004015
		public ReflectionSpecialName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00005E1E File Offset: 0x0000401E
		public ReflectionSpecialName()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSpecialName>.NativeClassPtr))
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00049AC0 File Offset: 0x00047CC0
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00005E30 File Offset: 0x00004030
		public unsafe ReflectionSpecialNameType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSpecialName.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionSpecialNameType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSpecialName.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00049AF0 File Offset: 0x00047CF0
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00005E4F File Offset: 0x0000404F
		public unsafe string _Argument_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSpecialName.NativeFieldInfoPtr__Argument_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSpecialName.NativeFieldInfoPtr__Argument_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr__Argument_k__BackingField;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ReflectionSpecialNameType_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_ReflectionSpecialNameType_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_get_Argument_Public_get_String_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_set_Argument_Private_set_Void_String_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReflectionSpecialNameType_String_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
