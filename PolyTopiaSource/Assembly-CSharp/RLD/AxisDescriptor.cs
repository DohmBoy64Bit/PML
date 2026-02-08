using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000141 RID: 321
	public class AxisDescriptor : Object
	{
		// Token: 0x06001CCC RID: 7372 RVA: 0x000921E4 File Offset: 0x000903E4
		// Note: this type is marked as 'beforefieldinit'.
		static AxisDescriptor()
		{
			Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "AxisDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr);
			AxisDescriptor.NativeFieldInfoPtr__sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, "_sign");
			AxisDescriptor.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, "_index");
			AxisDescriptor.NativeMethodInfoPtr_get_Sign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667642);
			AxisDescriptor.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667643);
			AxisDescriptor.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667644);
			AxisDescriptor.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667645);
			AxisDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667646);
			AxisDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667647);
			AxisDescriptor.NativeMethodInfoPtr_GetAssociatedBoxFace_Public_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr, 100667648);
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x000922C8 File Offset: 0x000904C8
		public unsafe AxisSign Sign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr_get_Sign_Public_get_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00092308 File Offset: 0x00090508
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00092344 File Offset: 0x00090544
		public unsafe bool IsPositive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78935, RefRangeEnd = 78937, XrefRangeStart = 78935, XrefRangeEnd = 78935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00092380 File Offset: 0x00090580
		public unsafe bool IsNegative
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 78937, RefRangeEnd = 78946, XrefRangeStart = 78937, XrefRangeEnd = 78937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000923BC File Offset: 0x000905BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 78947, RefRangeEnd = 78957, XrefRangeStart = 78946, XrefRangeEnd = 78947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisDescriptor(int axisIndex, AxisSign axisSign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00092418 File Offset: 0x00090618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78957, XrefRangeEnd = 78958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisDescriptor(int axisIndex, bool isNegative)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNegative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00092470 File Offset: 0x00090670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78958, RefRangeEnd = 78959, XrefRangeStart = 78958, XrefRangeEnd = 78958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxFace GetAssociatedBoxFace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisDescriptor.NativeMethodInfoPtr_GetAssociatedBoxFace_Public_BoxFace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFace>(intPtr3) : null;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000C1FD File Offset: 0x0000A3FD
		public AxisDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000924B0 File Offset: 0x000906B0
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0000C206 File Offset: 0x0000A406
		public unsafe AxisSign _sign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisDescriptor.NativeFieldInfoPtr__sign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisDescriptor.NativeFieldInfoPtr__sign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x000924E0 File Offset: 0x000906E0
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0000C225 File Offset: 0x0000A425
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisDescriptor.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisDescriptor.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeFieldInfoPtr__sign;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_get_Sign_Public_get_AxisSign_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisSign_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_GetAssociatedBoxFace_Public_BoxFace_0;
	}
}
