using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000152 RID: 338
	public sealed class Sku : ValueType
	{
		// Token: 0x0600167A RID: 5754 RVA: 0x00072E88 File Offset: 0x00071088
		// Note: this type is marked as 'beforefieldinit'.
		static Sku()
		{
			Il2CppClassPointerStore<Sku>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Sku");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sku>.NativeClassPtr);
			Sku.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sku>.NativeClassPtr, "Id");
			Sku.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sku>.NativeClassPtr, "Type");
			Sku.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sku>.NativeClassPtr, "Name");
			Sku.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sku>.NativeClassPtr, "Price");
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00008D3B File Offset: 0x00006F3B
		public Sku(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00008D44 File Offset: 0x00006F44
		public Sku()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sku>.NativeClassPtr))
		{
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00072F08 File Offset: 0x00071108
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00008D56 File Offset: 0x00006F56
		public unsafe long Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Id)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00072F30 File Offset: 0x00071130
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00008D71 File Offset: 0x00006F71
		public unsafe SkuType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkuType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00072F60 File Offset: 0x00071160
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00008D90 File Offset: 0x00006F90
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00072F88 File Offset: 0x00071188
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00008DAF File Offset: 0x00006FAF
		public unsafe SkuPrice Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Price);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkuPrice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sku.NativeFieldInfoPtr_Price), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeFieldInfoPtr_Price;
	}
}
