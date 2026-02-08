using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000324 RID: 804
	public class AppearanceData : global::Il2CppSystem.Object
	{
		// Token: 0x06004502 RID: 17666 RVA: 0x00134EA4 File Offset: 0x001330A4
		// Note: this type is marked as 'beforefieldinit'.
		static AppearanceData()
		{
			Il2CppClassPointerStore<AppearanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "AppearanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr);
			AppearanceData.NativeFieldInfoPtr_headColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "headColor");
			AppearanceData.NativeFieldInfoPtr_torsoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "torsoColor");
			AppearanceData.NativeFieldInfoPtr_leftArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "leftArmColor");
			AppearanceData.NativeFieldInfoPtr_rightArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "rightArmColor");
			AppearanceData.NativeFieldInfoPtr_leftLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "leftLegColor");
			AppearanceData.NativeFieldInfoPtr_rightLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "rightLegColor");
			AppearanceData.NativeFieldInfoPtr_hatUrls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "hatUrls");
			AppearanceData.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "faceID");
			AppearanceData.NativeFieldInfoPtr_shirtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "shirtID");
			AppearanceData.NativeFieldInfoPtr_pantsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "pantsID");
			AppearanceData.NativeFieldInfoPtr_torsoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "torsoID");
			AppearanceData.NativeFieldInfoPtr_torsoUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, "torsoUrl");
			AppearanceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, 100674232);
			AppearanceData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, 100674230);
			AppearanceData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr, 100674231);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00135000 File Offset: 0x00133200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131752, RefRangeEnd = 131753, XrefRangeStart = 131745, XrefRangeEnd = 131752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppearanceData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x0013503C File Offset: 0x0013323C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131753, XrefRangeEnd = 131763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00135094 File Offset: 0x00133294
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19683, RefRangeEnd = 19688, XrefRangeStart = 19683, XrefRangeEnd = 19688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00019711 File Offset: 0x00017911
		public AppearanceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x001350DC File Offset: 0x001332DC
		// (set) Token: 0x06004508 RID: 17672 RVA: 0x0001971A File Offset: 0x0001791A
		public unsafe Color headColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_headColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_headColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x0013510C File Offset: 0x0013330C
		// (set) Token: 0x0600450A RID: 17674 RVA: 0x00019739 File Offset: 0x00017939
		public unsafe Color torsoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x0013513C File Offset: 0x0013333C
		// (set) Token: 0x0600450C RID: 17676 RVA: 0x00019758 File Offset: 0x00017958
		public unsafe Color leftArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_leftArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_leftArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x0013516C File Offset: 0x0013336C
		// (set) Token: 0x0600450E RID: 17678 RVA: 0x00019777 File Offset: 0x00017977
		public unsafe Color rightArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_rightArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_rightArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x0013519C File Offset: 0x0013339C
		// (set) Token: 0x06004510 RID: 17680 RVA: 0x00019796 File Offset: 0x00017996
		public unsafe Color leftLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_leftLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_leftLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x001351CC File Offset: 0x001333CC
		// (set) Token: 0x06004512 RID: 17682 RVA: 0x000197B5 File Offset: 0x000179B5
		public unsafe Color rightLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_rightLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_rightLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x001351FC File Offset: 0x001333FC
		// (set) Token: 0x06004514 RID: 17684 RVA: 0x000197D4 File Offset: 0x000179D4
		public unsafe Il2CppStringArray hatUrls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_hatUrls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_hatUrls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x0013522C File Offset: 0x0013342C
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x000197F3 File Offset: 0x000179F3
		public unsafe int faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x00135254 File Offset: 0x00133454
		// (set) Token: 0x06004518 RID: 17688 RVA: 0x0001980E File Offset: 0x00017A0E
		public unsafe int shirtID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_shirtID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_shirtID)) = value;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004519 RID: 17689 RVA: 0x0013527C File Offset: 0x0013347C
		// (set) Token: 0x0600451A RID: 17690 RVA: 0x00019829 File Offset: 0x00017A29
		public unsafe int pantsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_pantsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_pantsID)) = value;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x001352A4 File Offset: 0x001334A4
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x00019844 File Offset: 0x00017A44
		public unsafe int torsoID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoID)) = value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x001352CC File Offset: 0x001334CC
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x0001985F File Offset: 0x00017A5F
		public unsafe string torsoUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceData.NativeFieldInfoPtr_torsoUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040035A8 RID: 13736
		private static readonly IntPtr NativeFieldInfoPtr_headColor;

		// Token: 0x040035A9 RID: 13737
		private static readonly IntPtr NativeFieldInfoPtr_torsoColor;

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeFieldInfoPtr_leftArmColor;

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeFieldInfoPtr_rightArmColor;

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeFieldInfoPtr_leftLegColor;

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeFieldInfoPtr_rightLegColor;

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_hatUrls;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeFieldInfoPtr_shirtID;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_pantsID;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeFieldInfoPtr_torsoID;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeFieldInfoPtr_torsoUrl;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
