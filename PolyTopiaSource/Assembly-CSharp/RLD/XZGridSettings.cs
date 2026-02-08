using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class XZGridSettings : Settings
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x000A6F98 File Offset: 0x000A5198
		// Note: this type is marked as 'beforefieldinit'.
		static XZGridSettings()
		{
			Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "XZGridSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr);
			XZGridSettings.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_isVisible");
			XZGridSettings.NativeFieldInfoPtr__cellSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_cellSizeX");
			XZGridSettings.NativeFieldInfoPtr__cellSizeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_cellSizeZ");
			XZGridSettings.NativeFieldInfoPtr__yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_yOffset");
			XZGridSettings.NativeFieldInfoPtr__rotationAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_rotationAngles");
			XZGridSettings.NativeFieldInfoPtr__upDownStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, "_upDownStep");
			XZGridSettings.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668401);
			XZGridSettings.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668402);
			XZGridSettings.NativeMethodInfoPtr_get_CellSizeX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668403);
			XZGridSettings.NativeMethodInfoPtr_set_CellSizeX_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668404);
			XZGridSettings.NativeMethodInfoPtr_get_CellSizeZ_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668405);
			XZGridSettings.NativeMethodInfoPtr_set_CellSizeZ_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668406);
			XZGridSettings.NativeMethodInfoPtr_get_RotationAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668407);
			XZGridSettings.NativeMethodInfoPtr_set_RotationAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668408);
			XZGridSettings.NativeMethodInfoPtr_get_YOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668409);
			XZGridSettings.NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668410);
			XZGridSettings.NativeMethodInfoPtr_get_UpDownStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668411);
			XZGridSettings.NativeMethodInfoPtr_set_UpDownStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668412);
			XZGridSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr, 100668413);
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000A7144 File Offset: 0x000A5344
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x000A7180 File Offset: 0x000A5380
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000A71C0 File Offset: 0x000A53C0
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x000A71FC File Offset: 0x000A53FC
		public unsafe float CellSizeX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_CellSizeX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_CellSizeX_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000A723C File Offset: 0x000A543C
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000A7278 File Offset: 0x000A5478
		public unsafe float CellSizeZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_CellSizeZ_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_CellSizeZ_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000A72B8 File Offset: 0x000A54B8
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x000A72F8 File Offset: 0x000A54F8
		public unsafe Vector3 RotationAngles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_RotationAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_RotationAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000A733C File Offset: 0x000A553C
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x000A7378 File Offset: 0x000A5578
		public unsafe float YOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_YOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000A73B8 File Offset: 0x000A55B8
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000A73F4 File Offset: 0x000A55F4
		public unsafe float UpDownStep
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_get_UpDownStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68177, RefRangeEnd = 68180, XrefRangeStart = 68177, XrefRangeEnd = 68180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr_set_UpDownStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000A7434 File Offset: 0x000A5634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86287, XrefRangeEnd = 86290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XZGridSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XZGridSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XZGridSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0000DB69 File Offset: 0x0000BD69
		public XZGridSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000A7470 File Offset: 0x000A5670
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000DB72 File Offset: 0x0000BD72
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000A7498 File Offset: 0x000A5698
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0000DB8D File Offset: 0x0000BD8D
		public unsafe float _cellSizeX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__cellSizeX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__cellSizeX)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000A74C0 File Offset: 0x000A56C0
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		public unsafe float _cellSizeZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__cellSizeZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__cellSizeZ)) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000A74E8 File Offset: 0x000A56E8
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		public unsafe float _yOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__yOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__yOffset)) = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000A7510 File Offset: 0x000A5710
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x0000DBDE File Offset: 0x0000BDDE
		public unsafe Vector3 _rotationAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__rotationAngles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__rotationAngles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000A7540 File Offset: 0x000A5740
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x0000DBFD File Offset: 0x0000BDFD
		public unsafe float _upDownStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__upDownStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XZGridSettings.NativeFieldInfoPtr__upDownStep)) = value;
			}
		}

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr__cellSizeX;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr__cellSizeZ;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr__yOffset;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr__rotationAngles;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr__upDownStep;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_get_CellSizeX_Public_get_Single_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_set_CellSizeX_Public_set_Void_Single_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_get_CellSizeZ_Public_get_Single_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_set_CellSizeZ_Public_set_Void_Single_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationAngles_Public_get_Vector3_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationAngles_Public_set_Void_Vector3_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_get_YOffset_Public_get_Single_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_set_YOffset_Public_set_Void_Single_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_get_UpDownStep_Public_get_Single_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_set_UpDownStep_Public_set_Void_Single_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
