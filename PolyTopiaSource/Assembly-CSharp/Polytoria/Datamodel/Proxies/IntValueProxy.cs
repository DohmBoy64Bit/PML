using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E0 RID: 736
	public class IntValueProxy : ValueBaseProxy
	{
		// Token: 0x0600409E RID: 16542 RVA: 0x00122298 File Offset: 0x00120498
		// Note: this type is marked as 'beforefieldinit'.
		static IntValueProxy()
		{
			Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "IntValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr);
			IntValueProxy.NativeFieldInfoPtr_intValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr, "intValue");
			IntValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr, 100673427);
			IntValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr, 100673428);
			IntValueProxy.NativeMethodInfoPtr__ctor_Public_Void_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr, 100673426);
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x00122318 File Offset: 0x00120518
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x00122354 File Offset: 0x00120554
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128630, XrefRangeEnd = 128632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00122394 File Offset: 0x00120594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntValueProxy(IntValue target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntValueProxy.NativeMethodInfoPtr__ctor_Public_Void_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00018741 File Offset: 0x00016941
		public IntValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x001223E0 File Offset: 0x001205E0
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x0001874A File Offset: 0x0001694A
		public unsafe IntValue intValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValueProxy.NativeFieldInfoPtr_intValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntValueProxy.NativeFieldInfoPtr_intValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeFieldInfoPtr_intValue;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntValue_0;
	}
}
