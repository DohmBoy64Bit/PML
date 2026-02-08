using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F8 RID: 760
	public class SpotlightProxy : DynamicInstanceProxy
	{
		// Token: 0x06004269 RID: 17001 RVA: 0x0012A634 File Offset: 0x00128834
		// Note: this type is marked as 'beforefieldinit'.
		static SpotlightProxy()
		{
			Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SpotlightProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr);
			SpotlightProxy.NativeFieldInfoPtr_spotlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, "spotlight");
			SpotlightProxy.NativeMethodInfoPtr_get_Range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673790);
			SpotlightProxy.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673791);
			SpotlightProxy.NativeMethodInfoPtr_get_Angle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673792);
			SpotlightProxy.NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673793);
			SpotlightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673794);
			SpotlightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673795);
			SpotlightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673796);
			SpotlightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673797);
			SpotlightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673798);
			SpotlightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673799);
			SpotlightProxy.NativeMethodInfoPtr__ctor_Public_Void_Spotlight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr, 100673789);
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x0012A754 File Offset: 0x00128954
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x0012A790 File Offset: 0x00128990
		public unsafe float Range
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129021, XrefRangeEnd = 129023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_get_Range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129023, XrefRangeEnd = 129025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x0012A7D0 File Offset: 0x001289D0
		// (set) Token: 0x0600426D RID: 17005 RVA: 0x0012A80C File Offset: 0x00128A0C
		public unsafe float Angle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129025, XrefRangeEnd = 129027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_get_Angle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129027, XrefRangeEnd = 129029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x0012A84C File Offset: 0x00128A4C
		// (set) Token: 0x0600426F RID: 17007 RVA: 0x0012A888 File Offset: 0x00128A88
		public unsafe float Brightness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129029, XrefRangeEnd = 129031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129031, XrefRangeEnd = 129033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x0012A8C8 File Offset: 0x00128AC8
		// (set) Token: 0x06004271 RID: 17009 RVA: 0x0012A908 File Offset: 0x00128B08
		public unsafe Color Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129033, XrefRangeEnd = 129034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129034, XrefRangeEnd = 129035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x0012A94C File Offset: 0x00128B4C
		// (set) Token: 0x06004273 RID: 17011 RVA: 0x0012A988 File Offset: 0x00128B88
		public unsafe bool Shadows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129035, XrefRangeEnd = 129037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129037, XrefRangeEnd = 129039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x0012A9C8 File Offset: 0x00128BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpotlightProxy(Spotlight target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpotlightProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightProxy.NativeMethodInfoPtr__ctor_Public_Void_Spotlight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00018B01 File Offset: 0x00016D01
		public SpotlightProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0012AA14 File Offset: 0x00128C14
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x00018B0A File Offset: 0x00016D0A
		public unsafe Spotlight spotlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightProxy.NativeFieldInfoPtr_spotlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spotlight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightProxy.NativeFieldInfoPtr_spotlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeFieldInfoPtr_spotlight;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Single_0;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeMethodInfoPtr_get_Angle_Public_get_Single_0;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeMethodInfoPtr_set_Angle_Public_set_Void_Single_0;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Spotlight_0;
	}
}
