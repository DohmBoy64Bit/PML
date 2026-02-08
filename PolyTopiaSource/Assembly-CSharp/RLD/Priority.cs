using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000115 RID: 277
	public class Priority : Object
	{
		// Token: 0x06001A7F RID: 6783 RVA: 0x0008821C File Offset: 0x0008641C
		// Note: this type is marked as 'beforefieldinit'.
		static Priority()
		{
			Il2CppClassPointerStore<Priority>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Priority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Priority>.NativeClassPtr);
			Priority.NativeFieldInfoPtr__priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Priority>.NativeClassPtr, "_priority");
			Priority.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667242);
			Priority.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667243);
			Priority.NativeMethodInfoPtr_get_Lowest_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667244);
			Priority.NativeMethodInfoPtr_get_Highest_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667245);
			Priority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667259);
			Priority.NativeMethodInfoPtr_MakeLowest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667246);
			Priority.NativeMethodInfoPtr_MakeHighest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667247);
			Priority.NativeMethodInfoPtr_MakeLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667248);
			Priority.NativeMethodInfoPtr_MakeHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667249);
			Priority.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667250);
			Priority.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667251);
			Priority.NativeMethodInfoPtr_CompareTo_Public_Int32_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667252);
			Priority.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667253);
			Priority.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667254);
			Priority.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667255);
			Priority.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667256);
			Priority.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667257);
			Priority.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Priority_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Priority>.NativeClassPtr, 100667258);
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000883C8 File Offset: 0x000865C8
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00088404 File Offset: 0x00086604
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00088444 File Offset: 0x00086644
		public unsafe static int Lowest
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_get_Lowest_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00088474 File Offset: 0x00086674
		public unsafe static int Highest
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75830, RefRangeEnd = 75832, XrefRangeStart = 75830, XrefRangeEnd = 75830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_get_Highest_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000884A4 File Offset: 0x000866A4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Priority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Priority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000884E0 File Offset: 0x000866E0
		[CallerCount(0)]
		public unsafe void MakeLowest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_MakeLowest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00088514 File Offset: 0x00086714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75832, RefRangeEnd = 75835, XrefRangeStart = 75832, XrefRangeEnd = 75832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeHighest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_MakeHighest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00088548 File Offset: 0x00086748
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 75835, RefRangeEnd = 75848, XrefRangeStart = 75835, XrefRangeEnd = 75835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_MakeLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0008858C File Offset: 0x0008678C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 75848, RefRangeEnd = 75854, XrefRangeStart = 75848, XrefRangeEnd = 75848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_MakeHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000885D0 File Offset: 0x000867D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19683, RefRangeEnd = 19688, XrefRangeStart = 19683, XrefRangeEnd = 19688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Priority.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00088618 File Offset: 0x00086818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75854, XrefRangeEnd = 75856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Priority.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00088670 File Offset: 0x00086870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75858, RefRangeEnd = 75859, XrefRangeStart = 75856, XrefRangeEnd = 75858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Priority other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_CompareTo_Public_Int32_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000886C0 File Offset: 0x000868C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75859, RefRangeEnd = 75862, XrefRangeStart = 75859, XrefRangeEnd = 75859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00088714 File Offset: 0x00086914
		[CallerCount(0)]
		public unsafe static bool operator !=(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00088768 File Offset: 0x00086968
		[CallerCount(0)]
		public unsafe static bool operator >(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000887BC File Offset: 0x000869BC
		[CallerCount(0)]
		public unsafe static bool operator >=(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00088810 File Offset: 0x00086A10
		[CallerCount(0)]
		public unsafe static bool operator <(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00088864 File Offset: 0x00086A64
		[CallerCount(0)]
		public unsafe static bool operator <=(Priority firstPriority, Priority secondPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPriority);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondPriority);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Priority.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Priority_Priority_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000B975 File Offset: 0x00009B75
		public Priority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x000888B8 File Offset: 0x00086AB8
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000B97E File Offset: 0x00009B7E
		public unsafe int _priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Priority.NativeFieldInfoPtr__priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Priority.NativeFieldInfoPtr__priority)) = value;
			}
		}

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr__priority;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_Lowest_Public_Static_get_Int32_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_get_Highest_Public_Static_get_Int32_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_MakeLowest_Public_Void_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_MakeHighest_Public_Void_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_MakeLowerThan_Public_Void_Priority_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_MakeHigherThan_Public_Void_Priority_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_Priority_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Priority_Priority_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Priority_Priority_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Priority_Priority_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Priority_Priority_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Priority_Priority_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Priority_Priority_0;
	}
}
