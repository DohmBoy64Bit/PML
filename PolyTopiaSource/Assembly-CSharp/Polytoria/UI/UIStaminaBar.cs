using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000258 RID: 600
	public class UIStaminaBar : MonoBehaviour
	{
		// Token: 0x06002EA4 RID: 11940 RVA: 0x000D76E4 File Offset: 0x000D58E4
		// Note: this type is marked as 'beforefieldinit'.
		static UIStaminaBar()
		{
			Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "UIStaminaBar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr);
			UIStaminaBar.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "fadeTime");
			UIStaminaBar.NativeFieldInfoPtr__fadeStartTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "_fadeStartTimer");
			UIStaminaBar.NativeFieldInfoPtr_fadeTimerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "fadeTimerState");
			UIStaminaBar.NativeFieldInfoPtr_fadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "fadeStartTime");
			UIStaminaBar.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "fill");
			UIStaminaBar.NativeFieldInfoPtr_cont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "cont");
			UIStaminaBar.NativeFieldInfoPtr_fillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "fillAmount");
			UIStaminaBar.NativeFieldInfoPtr_FillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "FillColor");
			UIStaminaBar.NativeFieldInfoPtr_FillExhaustedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "FillExhaustedColor");
			UIStaminaBar.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, "alpha");
			UIStaminaBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, 100670283);
			UIStaminaBar.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, 100670279);
			UIStaminaBar.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, 100670280);
			UIStaminaBar.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, 100670281);
			UIStaminaBar.NativeMethodInfoPtr_SetFill_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr, 100670282);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000D7840 File Offset: 0x000D5A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99226, XrefRangeEnd = 99230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIStaminaBar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIStaminaBar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIStaminaBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000D787C File Offset: 0x000D5A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99230, XrefRangeEnd = 99246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIStaminaBar.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000D78B0 File Offset: 0x000D5AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99246, XrefRangeEnd = 99250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIStaminaBar.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000D78E4 File Offset: 0x000D5AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99250, XrefRangeEnd = 99253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIStaminaBar.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000D7924 File Offset: 0x000D5B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99256, RefRangeEnd = 99257, XrefRangeStart = 99253, XrefRangeEnd = 99256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFill(float newFillAmount, bool exhausted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newFillAmount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exhausted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIStaminaBar.NativeMethodInfoPtr_SetFill_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00012B73 File Offset: 0x00010D73
		public UIStaminaBar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x000D7970 File Offset: 0x000D5B70
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00012B7C File Offset: 0x00010D7C
		public unsafe static float fadeTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UIStaminaBar.NativeFieldInfoPtr_fadeTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIStaminaBar.NativeFieldInfoPtr_fadeTime, (void*)(&value));
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000D798C File Offset: 0x000D5B8C
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00012B8A File Offset: 0x00010D8A
		public unsafe float _fadeStartTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr__fadeStartTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr__fadeStartTimer)) = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000D79B4 File Offset: 0x000D5BB4
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00012BA5 File Offset: 0x00010DA5
		public unsafe int fadeTimerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fadeTimerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fadeTimerState)) = value;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x000D79DC File Offset: 0x000D5BDC
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00012BC0 File Offset: 0x00010DC0
		public unsafe static float fadeStartTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UIStaminaBar.NativeFieldInfoPtr_fadeStartTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIStaminaBar.NativeFieldInfoPtr_fadeStartTime, (void*)(&value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x000D79F8 File Offset: 0x000D5BF8
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00012BCE File Offset: 0x00010DCE
		public unsafe Image fill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x000D7A28 File Offset: 0x000D5C28
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00012BED File Offset: 0x00010DED
		public unsafe Image cont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_cont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_cont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x000D7A58 File Offset: 0x000D5C58
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00012C0C File Offset: 0x00010E0C
		public unsafe float fillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_fillAmount)) = value;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x000D7A80 File Offset: 0x000D5C80
		// (set) Token: 0x06002EBA RID: 11962 RVA: 0x00012C27 File Offset: 0x00010E27
		public unsafe Color FillColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_FillColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_FillColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x000D7AB0 File Offset: 0x000D5CB0
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x00012C46 File Offset: 0x00010E46
		public unsafe Color FillExhaustedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_FillExhaustedColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_FillExhaustedColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00012C65 File Offset: 0x00010E65
		public unsafe float alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIStaminaBar.NativeFieldInfoPtr_alpha)) = value;
			}
		}

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeFieldInfoPtr__fadeStartTimer;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeFieldInfoPtr_fadeTimerState;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeFieldInfoPtr_fadeStartTime;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeFieldInfoPtr_fill;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeFieldInfoPtr_cont;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeFieldInfoPtr_fillAmount;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeFieldInfoPtr_FillColor;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeFieldInfoPtr_FillExhaustedColor;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_Boolean_0;
	}
}
