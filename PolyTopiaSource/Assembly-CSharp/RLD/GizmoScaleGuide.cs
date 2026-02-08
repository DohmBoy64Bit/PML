using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000072 RID: 114
	public class GizmoScaleGuide : global::Il2CppSystem.Object
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x000427A0 File Offset: 0x000409A0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoScaleGuide()
		{
			Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoScaleGuide");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr);
			GizmoScaleGuide.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, "_lookAndFeel");
			GizmoScaleGuide.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoScaleGuide.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, 100664597);
			GizmoScaleGuide.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, 100664598);
			GizmoScaleGuide.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoScaleGuideLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, 100664599);
			GizmoScaleGuide.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, 100664601);
			GizmoScaleGuide.NativeMethodInfoPtr_Render_Public_Void_IEnumerable_1_GameObject_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr, 100664600);
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0004285C File Offset: 0x00040A5C
		public unsafe GizmoScaleGuideLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuide.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuideLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0004289C File Offset: 0x00040A9C
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x000428DC File Offset: 0x00040ADC
		public unsafe GizmoScaleGuideLookAndFeel SharedLookAndFeel
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuide.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuideLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuide.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoScaleGuideLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00042920 File Offset: 0x00040B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63628, RefRangeEnd = 63630, XrefRangeStart = 63619, XrefRangeEnd = 63628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoScaleGuide()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoScaleGuide>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuide.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0004295C File Offset: 0x00040B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63684, RefRangeEnd = 63686, XrefRangeStart = 63630, XrefRangeEnd = 63684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(IEnumerable<GameObject> gameObjects, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuide.NativeMethodInfoPtr_Render_Public_Void_IEnumerable_1_GameObject_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00004D5D File Offset: 0x00002F5D
		public GizmoScaleGuide(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000429B0 File Offset: 0x00040BB0
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00004D66 File Offset: 0x00002F66
		public unsafe GizmoScaleGuideLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuide.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuideLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuide.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000429E0 File Offset: 0x00040BE0
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00004D85 File Offset: 0x00002F85
		public unsafe GizmoScaleGuideLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuide.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuideLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuide.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoScaleGuideLookAndFeel_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoScaleGuideLookAndFeel_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_IEnumerable_1_GameObject_Camera_0;
	}
}
