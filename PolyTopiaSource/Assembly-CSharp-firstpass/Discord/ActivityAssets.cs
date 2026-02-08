using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000145 RID: 325
	public sealed class ActivityAssets : ValueType
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x00072228 File Offset: 0x00070428
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityAssets()
		{
			Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ActivityAssets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr);
			ActivityAssets.NativeFieldInfoPtr_LargeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr, "LargeImage");
			ActivityAssets.NativeFieldInfoPtr_LargeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr, "LargeText");
			ActivityAssets.NativeFieldInfoPtr_SmallImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr, "SmallImage");
			ActivityAssets.NativeFieldInfoPtr_SmallText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr, "SmallText");
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000087C8 File Offset: 0x000069C8
		public ActivityAssets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000087D1 File Offset: 0x000069D1
		public ActivityAssets()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityAssets>.NativeClassPtr))
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000722A8 File Offset: 0x000704A8
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x000087E3 File Offset: 0x000069E3
		public unsafe string LargeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_LargeImage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_LargeImage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000722D0 File Offset: 0x000704D0
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x00008802 File Offset: 0x00006A02
		public unsafe string LargeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_LargeText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_LargeText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x000722F8 File Offset: 0x000704F8
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00008821 File Offset: 0x00006A21
		public unsafe string SmallImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_SmallImage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_SmallImage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00072320 File Offset: 0x00070520
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x00008840 File Offset: 0x00006A40
		public unsafe string SmallText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_SmallText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityAssets.NativeFieldInfoPtr_SmallText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr_LargeImage;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr_LargeText;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr_SmallImage;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeFieldInfoPtr_SmallText;
	}
}
