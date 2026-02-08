using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
	// Token: 0x0200011B RID: 283
	public class StringRange : Object
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x0006D82C File Offset: 0x0006BA2C
		// Note: this type is marked as 'beforefieldinit'.
		static StringRange()
		{
			Il2CppClassPointerStore<StringRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.StringLib", "StringRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringRange>.NativeClassPtr);
			StringRange.NativeFieldInfoPtr__Start_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringRange>.NativeClassPtr, "<Start>k__BackingField");
			StringRange.NativeFieldInfoPtr__End_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringRange>.NativeClassPtr, "<End>k__BackingField");
			StringRange.NativeMethodInfoPtr_get_Start_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667056);
			StringRange.NativeMethodInfoPtr_set_Start_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667057);
			StringRange.NativeMethodInfoPtr_get_End_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667058);
			StringRange.NativeMethodInfoPtr_set_End_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667059);
			StringRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667060);
			StringRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667061);
			StringRange.NativeMethodInfoPtr_FromLuaRange_Public_Static_StringRange_DynValue_DynValue_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667062);
			StringRange.NativeMethodInfoPtr_ApplyToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667063);
			StringRange.NativeMethodInfoPtr_Length_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringRange>.NativeClassPtr, 100667064);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0006D938 File Offset: 0x0006BB38
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0006D974 File Offset: 0x0006BB74
		public unsafe int Start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_get_Start_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_set_Start_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0006D9B4 File Offset: 0x0006BBB4
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0006D9F0 File Offset: 0x0006BBF0
		public unsafe int End
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_get_End_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_set_End_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0006DA30 File Offset: 0x0006BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51320, XrefRangeEnd = 51321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0006DA6C File Offset: 0x0006BC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51322, RefRangeEnd = 51323, XrefRangeStart = 51321, XrefRangeEnd = 51322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringRange(int start, int end)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringRange>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0006DAC4 File Offset: 0x0006BCC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51333, RefRangeEnd = 51335, XrefRangeStart = 51323, XrefRangeEnd = 51333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringRange FromLuaRange(DynValue start, DynValue end, Nullable<int> defaultEnd = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_FromLuaRange_Public_Static_StringRange_DynValue_DynValue_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringRange>(intPtr3) : null;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51339, RefRangeEnd = 51341, XrefRangeStart = 51335, XrefRangeEnd = 51339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ApplyToString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_ApplyToString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0006DB74 File Offset: 0x0006BD74
		[CallerCount(0)]
		public unsafe int Length()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringRange.NativeMethodInfoPtr_Length_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00008311 File Offset: 0x00006511
		public StringRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0006DBB0 File Offset: 0x0006BDB0
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000831A File Offset: 0x0000651A
		public unsafe int _Start_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringRange.NativeFieldInfoPtr__Start_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringRange.NativeFieldInfoPtr__Start_k__BackingField)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x00008335 File Offset: 0x00006535
		public unsafe int _End_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringRange.NativeFieldInfoPtr__End_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringRange.NativeFieldInfoPtr__End_k__BackingField)) = value;
			}
		}

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr__Start_k__BackingField;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr__End_k__BackingField;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_get_Int32_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_set_Start_Public_set_Void_Int32_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_get_End_Public_get_Int32_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_set_End_Public_set_Void_Int32_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_FromLuaRange_Public_Static_StringRange_DynValue_DynValue_Nullable_1_Int32_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToString_Public_String_String_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_Length_Public_Int32_0;
	}
}
