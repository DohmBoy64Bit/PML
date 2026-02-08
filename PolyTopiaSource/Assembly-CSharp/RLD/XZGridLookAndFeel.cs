using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class XZGridLookAndFeel : Settings
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x000A69AC File Offset: 0x000A4BAC
		// Note: this type is marked as 'beforefieldinit'.
		static XZGridLookAndFeel()
		{
			Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "XZGridLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr);
			XZGridLookAndFeel.NativeFieldInfoPtr__lineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, "_lineColor");
			XZGridLookAndFeel.NativeFieldInfoPtr__useCellFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, "_useCellFading");
			XZGridLookAndFeel.NativeMethodInfoPtr_get_LineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, 100668390);
			XZGridLookAndFeel.NativeMethodInfoPtr_set_LineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, 100668391);
			XZGridLookAndFeel.NativeMethodInfoPtr_get_UseCellFading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, 100668392);
			XZGridLookAndFeel.NativeMethodInfoPtr_set_UseCellFading_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, 100668393);
			XZGridLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr, 100668394);
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x000A6A68 File Offset: 0x000A4C68
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x000A6AA8 File Offset: 0x000A4CA8
		public unsafe Color LineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridLookAndFeel.NativeMethodInfoPtr_get_LineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridLookAndFeel.NativeMethodInfoPtr_set_LineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000A6AEC File Offset: 0x000A4CEC
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x000A6B28 File Offset: 0x000A4D28
		public unsafe bool UseCellFading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridLookAndFeel.NativeMethodInfoPtr_get_UseCellFading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridLookAndFeel.NativeMethodInfoPtr_set_UseCellFading_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000A6B68 File Offset: 0x000A4D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86280, XrefRangeEnd = 86282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XZGridLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XZGridLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0000DA86 File Offset: 0x0000BC86
		public XZGridLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000A6BA4 File Offset: 0x000A4DA4
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x0000DA8F File Offset: 0x0000BC8F
		public unsafe Color _lineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridLookAndFeel.NativeFieldInfoPtr__lineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridLookAndFeel.NativeFieldInfoPtr__lineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		public unsafe bool _useCellFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridLookAndFeel.NativeFieldInfoPtr__useCellFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridLookAndFeel.NativeFieldInfoPtr__useCellFading)) = value;
			}
		}

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr__lineColor;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr__useCellFading;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_get_LineColor_Public_get_Color_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_set_LineColor_Public_set_Void_Color_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCellFading_Public_get_Boolean_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_set_UseCellFading_Public_set_Void_Boolean_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
