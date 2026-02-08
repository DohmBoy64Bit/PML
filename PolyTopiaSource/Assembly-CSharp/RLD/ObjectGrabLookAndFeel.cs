using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C9 RID: 457
	[Serializable]
	public class ObjectGrabLookAndFeel : Settings
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x000ACC50 File Offset: 0x000AAE50
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGrabLookAndFeel()
		{
			Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectGrabLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr);
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_drawAnchorLines");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorLineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_anchorLineColor");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectPosTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_drawObjectPosTicks");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorPosTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_drawAnchorPosTick");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_objectPosTickColor");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_anchorPosTickColor");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_objectPosTickSize");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_anchorPosTickSize");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_drawObjectBoxes");
			ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectBoxWireColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, "_objectBoxWireColor");
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawAnchorLines_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668595);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawAnchorLines_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668596);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorLineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668597);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorLineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668598);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawObjectPosTicks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668599);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawObjectPosTicks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668600);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawAnchorPosTick_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668601);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawAnchorPosTick_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668602);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectPosTickColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668603);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectPosTickColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668604);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectPosTickSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668605);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectPosTickSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668606);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorPosTickColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668607);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorPosTickColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668608);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorPosTickSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668609);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorPosTickSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668610);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawObjectBoxes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668611);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawObjectBoxes_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668612);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectBoxWireColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668613);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectBoxWireColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668614);
			ObjectGrabLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr, 100668615);
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000ACEEC File Offset: 0x000AB0EC
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x000ACF28 File Offset: 0x000AB128
		public unsafe bool DrawAnchorLines
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawAnchorLines_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawAnchorLines_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000ACF68 File Offset: 0x000AB168
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x000ACFA8 File Offset: 0x000AB1A8
		public unsafe Color AnchorLineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorLineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorLineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000ACFEC File Offset: 0x000AB1EC
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x000AD028 File Offset: 0x000AB228
		public unsafe bool DrawObjectPosTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawObjectPosTicks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawObjectPosTicks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000AD068 File Offset: 0x000AB268
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x000AD0A4 File Offset: 0x000AB2A4
		public unsafe bool DrawAnchorPosTick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawAnchorPosTick_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawAnchorPosTick_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000AD0E4 File Offset: 0x000AB2E4
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x000AD124 File Offset: 0x000AB324
		public unsafe Color ObjectPosTickColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectPosTickColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectPosTickColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000AD168 File Offset: 0x000AB368
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x000AD1A4 File Offset: 0x000AB3A4
		public unsafe float ObjectPosTickSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectPosTickSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectPosTickSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000AD1E4 File Offset: 0x000AB3E4
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x000AD224 File Offset: 0x000AB424
		public unsafe Color AnchorPosTickColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorPosTickColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorPosTickColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x000AD268 File Offset: 0x000AB468
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x000AD2A4 File Offset: 0x000AB4A4
		public unsafe float AnchorPosTickSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_AnchorPosTickSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_AnchorPosTickSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000AD2E4 File Offset: 0x000AB4E4
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x000AD320 File Offset: 0x000AB520
		public unsafe bool DrawObjectBoxes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_DrawObjectBoxes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_DrawObjectBoxes_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000AD360 File Offset: 0x000AB560
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
		public unsafe Color ObjectBoxWireColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_get_ObjectBoxWireColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr_set_ObjectBoxWireColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000AD3E4 File Offset: 0x000AB5E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87843, RefRangeEnd = 87844, XrefRangeStart = 87840, XrefRangeEnd = 87843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGrabLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGrabLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGrabLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0000E731 File Offset: 0x0000C931
		public ObjectGrabLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x000AD420 File Offset: 0x000AB620
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x0000E73A File Offset: 0x0000C93A
		public unsafe bool _drawAnchorLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorLines)) = value;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x000AD448 File Offset: 0x000AB648
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x0000E755 File Offset: 0x0000C955
		public unsafe Color _anchorLineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorLineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorLineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x000AD478 File Offset: 0x000AB678
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x0000E774 File Offset: 0x0000C974
		public unsafe bool _drawObjectPosTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectPosTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectPosTicks)) = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x000AD4A0 File Offset: 0x000AB6A0
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x0000E78F File Offset: 0x0000C98F
		public unsafe bool _drawAnchorPosTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorPosTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawAnchorPosTick)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x000AD4C8 File Offset: 0x000AB6C8
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x0000E7AA File Offset: 0x0000C9AA
		public unsafe Color _objectPosTickColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000AD4F8 File Offset: 0x000AB6F8
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x0000E7C9 File Offset: 0x0000C9C9
		public unsafe Color _anchorPosTickColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000AD528 File Offset: 0x000AB728
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
		public unsafe float _objectPosTickSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectPosTickSize)) = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000AD550 File Offset: 0x000AB750
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x0000E803 File Offset: 0x0000CA03
		public unsafe float _anchorPosTickSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__anchorPosTickSize)) = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000AD578 File Offset: 0x000AB778
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0000E81E File Offset: 0x0000CA1E
		public unsafe bool _drawObjectBoxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectBoxes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__drawObjectBoxes)) = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000AD5A0 File Offset: 0x000AB7A0
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0000E839 File Offset: 0x0000CA39
		public unsafe Color _objectBoxWireColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectBoxWireColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGrabLookAndFeel.NativeFieldInfoPtr__objectBoxWireColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr__drawAnchorLines;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr__anchorLineColor;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr__drawObjectPosTicks;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr__drawAnchorPosTick;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr__objectPosTickColor;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeFieldInfoPtr__anchorPosTickColor;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeFieldInfoPtr__objectPosTickSize;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr__anchorPosTickSize;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeFieldInfoPtr__drawObjectBoxes;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeFieldInfoPtr__objectBoxWireColor;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawAnchorLines_Public_get_Boolean_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawAnchorLines_Public_set_Void_Boolean_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_get_AnchorLineColor_Public_get_Color_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_set_AnchorLineColor_Public_set_Void_Color_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawObjectPosTicks_Public_get_Boolean_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawObjectPosTicks_Public_set_Void_Boolean_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawAnchorPosTick_Public_get_Boolean_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawAnchorPosTick_Public_set_Void_Boolean_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectPosTickColor_Public_get_Color_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectPosTickColor_Public_set_Void_Color_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectPosTickSize_Public_get_Single_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectPosTickSize_Public_set_Void_Single_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_get_AnchorPosTickColor_Public_get_Color_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_set_AnchorPosTickColor_Public_set_Void_Color_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_get_AnchorPosTickSize_Public_get_Single_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_set_AnchorPosTickSize_Public_set_Void_Single_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawObjectBoxes_Public_get_Boolean_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawObjectBoxes_Public_set_Void_Boolean_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectBoxWireColor_Public_get_Color_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectBoxWireColor_Public_set_Void_Color_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
