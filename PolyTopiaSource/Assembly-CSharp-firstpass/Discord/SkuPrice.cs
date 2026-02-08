using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000151 RID: 337
	public sealed class SkuPrice : ValueType
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x00072DE0 File Offset: 0x00070FE0
		// Note: this type is marked as 'beforefieldinit'.
		static SkuPrice()
		{
			Il2CppClassPointerStore<SkuPrice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "SkuPrice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkuPrice>.NativeClassPtr);
			SkuPrice.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkuPrice>.NativeClassPtr, "Amount");
			SkuPrice.NativeFieldInfoPtr_Currency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkuPrice>.NativeClassPtr, "Currency");
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00008CE6 File Offset: 0x00006EE6
		public SkuPrice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00008CEF File Offset: 0x00006EEF
		public SkuPrice()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkuPrice>.NativeClassPtr))
		{
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00072E38 File Offset: 0x00071038
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00008D01 File Offset: 0x00006F01
		public unsafe uint Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuPrice.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuPrice.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00072E60 File Offset: 0x00071060
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00008D1C File Offset: 0x00006F1C
		public unsafe string Currency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuPrice.NativeFieldInfoPtr_Currency);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuPrice.NativeFieldInfoPtr_Currency), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_Currency;
	}
}
