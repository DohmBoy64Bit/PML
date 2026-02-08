using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E3 RID: 227
	public class RuntimeScopeBlock : Object
	{
		// Token: 0x06001110 RID: 4368 RVA: 0x0005AD90 File Offset: 0x00058F90
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeScopeBlock()
		{
			Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "RuntimeScopeBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr);
			RuntimeScopeBlock.NativeFieldInfoPtr__From_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, "<From>k__BackingField");
			RuntimeScopeBlock.NativeFieldInfoPtr__To_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, "<To>k__BackingField");
			RuntimeScopeBlock.NativeFieldInfoPtr__ToInclusive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, "<ToInclusive>k__BackingField");
			RuntimeScopeBlock.NativeMethodInfoPtr_get_From_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666337);
			RuntimeScopeBlock.NativeMethodInfoPtr_set_From_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666338);
			RuntimeScopeBlock.NativeMethodInfoPtr_get_To_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666339);
			RuntimeScopeBlock.NativeMethodInfoPtr_set_To_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666340);
			RuntimeScopeBlock.NativeMethodInfoPtr_get_ToInclusive_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666341);
			RuntimeScopeBlock.NativeMethodInfoPtr_set_ToInclusive_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666342);
			RuntimeScopeBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666344);
			RuntimeScopeBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr, 100666343);
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0005AE9C File Offset: 0x0005909C
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0005AED8 File Offset: 0x000590D8
		public unsafe int From
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_get_From_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_set_From_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0005AF18 File Offset: 0x00059118
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0005AF54 File Offset: 0x00059154
		public unsafe int To
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_get_To_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_set_To_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0005AF94 File Offset: 0x00059194
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0005AFD0 File Offset: 0x000591D0
		public unsafe int ToInclusive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_get_ToInclusive_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr_set_ToInclusive_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005B010 File Offset: 0x00059210
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeScopeBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005B04C File Offset: 0x0005924C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43073, XrefRangeEnd = 43082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeScopeBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0000717D File Offset: 0x0000537D
		public RuntimeScopeBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0005B090 File Offset: 0x00059290
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00007186 File Offset: 0x00005386
		public unsafe int _From_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__From_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__From_k__BackingField)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0005B0B8 File Offset: 0x000592B8
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x000071A1 File Offset: 0x000053A1
		public unsafe int _To_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__To_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__To_k__BackingField)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0005B0E0 File Offset: 0x000592E0
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x000071BC File Offset: 0x000053BC
		public unsafe int _ToInclusive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__ToInclusive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeBlock.NativeFieldInfoPtr__ToInclusive_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr__From_k__BackingField;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeFieldInfoPtr__To_k__BackingField;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeFieldInfoPtr__ToInclusive_k__BackingField;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_get_From_Public_get_Int32_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_set_From_Internal_set_Void_Int32_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_get_To_Public_get_Int32_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_set_To_Internal_set_Void_Int32_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_get_ToInclusive_Public_get_Int32_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_set_ToInclusive_Internal_set_Void_Int32_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
