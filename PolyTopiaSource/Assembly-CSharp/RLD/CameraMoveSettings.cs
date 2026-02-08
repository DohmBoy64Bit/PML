using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class CameraMoveSettings : Settings
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x00081444 File Offset: 0x0007F644
		// Note: this type is marked as 'beforefieldinit'.
		static CameraMoveSettings()
		{
			Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraMoveSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr);
			CameraMoveSettings.NativeFieldInfoPtr__minMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, "_minMoveSpeed");
			CameraMoveSettings.NativeFieldInfoPtr__moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, "_moveSpeed");
			CameraMoveSettings.NativeFieldInfoPtr__alternateMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, "_alternateMoveSpeed");
			CameraMoveSettings.NativeFieldInfoPtr__accelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, "_accelerationRate");
			CameraMoveSettings.NativeMethodInfoPtr_get_MoveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666926);
			CameraMoveSettings.NativeMethodInfoPtr_set_MoveSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666927);
			CameraMoveSettings.NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666928);
			CameraMoveSettings.NativeMethodInfoPtr_set_AlternateMoveSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666929);
			CameraMoveSettings.NativeMethodInfoPtr_get_AccelerationRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666930);
			CameraMoveSettings.NativeMethodInfoPtr_set_AccelerationRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666931);
			CameraMoveSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr, 100666932);
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00081550 File Offset: 0x0007F750
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0008158C File Offset: 0x0007F78C
		public unsafe float MoveSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_get_MoveSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74488, XrefRangeEnd = 74492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_set_MoveSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000815CC File Offset: 0x0007F7CC
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00081608 File Offset: 0x0007F808
		public unsafe float AlternateMoveSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74492, XrefRangeEnd = 74496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_set_AlternateMoveSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00081648 File Offset: 0x0007F848
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x00081684 File Offset: 0x0007F884
		public unsafe float AccelerationRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_get_AccelerationRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 67305, RefRangeEnd = 67314, XrefRangeStart = 67305, XrefRangeEnd = 67314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr_set_AccelerationRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000816C4 File Offset: 0x0007F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74496, XrefRangeEnd = 74501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraMoveSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMoveSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoveSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public CameraMoveSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00081700 File Offset: 0x0007F900
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000ADF5 File Offset: 0x00008FF5
		public unsafe static float _minMoveSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CameraMoveSettings.NativeFieldInfoPtr__minMoveSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraMoveSettings.NativeFieldInfoPtr__minMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0008171C File Offset: 0x0007F91C
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000AE03 File Offset: 0x00009003
		public unsafe float _moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__moveSpeed)) = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00081744 File Offset: 0x0007F944
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000AE1E File Offset: 0x0000901E
		public unsafe float _alternateMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__alternateMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__alternateMoveSpeed)) = value;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0008176C File Offset: 0x0007F96C
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0000AE39 File Offset: 0x00009039
		public unsafe float _accelerationRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__accelerationRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoveSettings.NativeFieldInfoPtr__accelerationRate)) = value;
			}
		}

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr__minMoveSpeed;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr__moveSpeed;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr__alternateMoveSpeed;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr__accelerationRate;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeed_Public_get_Single_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveSpeed_Public_set_Void_Single_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Single_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_set_AlternateMoveSpeed_Public_set_Void_Single_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerationRate_Public_get_Single_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_set_AccelerationRate_Public_set_Void_Single_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
