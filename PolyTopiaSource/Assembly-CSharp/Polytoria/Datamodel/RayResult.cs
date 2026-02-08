using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027B RID: 635
	public sealed class RayResult : ValueType
	{
		// Token: 0x0600320E RID: 12814 RVA: 0x000E58A0 File Offset: 0x000E3AA0
		// Note: this type is marked as 'beforefieldinit'.
		static RayResult()
		{
			Il2CppClassPointerStore<RayResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "RayResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayResult>.NativeClassPtr);
			RayResult.NativeFieldInfoPtr__Origin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Origin>k__BackingField");
			RayResult.NativeFieldInfoPtr__Direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Direction>k__BackingField");
			RayResult.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Position>k__BackingField");
			RayResult.NativeFieldInfoPtr__Normal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Normal>k__BackingField");
			RayResult.NativeFieldInfoPtr__Distance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Distance>k__BackingField");
			RayResult.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayResult>.NativeClassPtr, "<Instance>k__BackingField");
			RayResult.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670840);
			RayResult.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670841);
			RayResult.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670842);
			RayResult.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670843);
			RayResult.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670844);
			RayResult.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670845);
			RayResult.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670846);
			RayResult.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670847);
			RayResult.NativeMethodInfoPtr_get_Distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670848);
			RayResult.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670849);
			RayResult.NativeMethodInfoPtr_get_Instance_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670850);
			RayResult.NativeMethodInfoPtr_set_Instance_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayResult>.NativeClassPtr, 100670851);
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x000E5A38 File Offset: 0x000E3C38
		// (set) Token: 0x06003210 RID: 12816 RVA: 0x000E5A7C File Offset: 0x000E3C7C
		public unsafe Vector3 Origin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x000E5AC4 File Offset: 0x000E3CC4
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x000E5B08 File Offset: 0x000E3D08
		public unsafe Vector3 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x000E5B50 File Offset: 0x000E3D50
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x000E5B94 File Offset: 0x000E3D94
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x000E5BDC File Offset: 0x000E3DDC
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x000E5C20 File Offset: 0x000E3E20
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000E5C68 File Offset: 0x000E3E68
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x000E5CAC File Offset: 0x000E3EAC
		public unsafe float Distance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Distance_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 17918, RefRangeEnd = 17920, XrefRangeStart = 17918, XrefRangeEnd = 17920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000E5CF0 File Offset: 0x000E3EF0
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x000E5D34 File Offset: 0x000E3F34
		public unsafe Instance Instance
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_get_Instance_Public_get_Instance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayResult.NativeMethodInfoPtr_set_Instance_Public_set_Void_Instance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00013D79 File Offset: 0x00011F79
		public RayResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00013D82 File Offset: 0x00011F82
		public RayResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayResult>.NativeClassPtr))
		{
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x000E5D7C File Offset: 0x000E3F7C
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x00013D94 File Offset: 0x00011F94
		public unsafe Vector3 _Origin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Origin_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Origin_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000E5DAC File Offset: 0x000E3FAC
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x00013DB3 File Offset: 0x00011FB3
		public unsafe Vector3 _Direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Direction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Direction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000E5DDC File Offset: 0x000E3FDC
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x00013DD2 File Offset: 0x00011FD2
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Position_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000E5E0C File Offset: 0x000E400C
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x00013DF1 File Offset: 0x00011FF1
		public unsafe Vector3 _Normal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Normal_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Normal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000E5E3C File Offset: 0x000E403C
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x00013E10 File Offset: 0x00012010
		public unsafe float _Distance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Distance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Distance_k__BackingField)) = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x000E5E64 File Offset: 0x000E4064
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x00013E2B File Offset: 0x0001202B
		public unsafe Instance _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Instance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RayResult.NativeFieldInfoPtr__Instance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr__Origin_k__BackingField;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeFieldInfoPtr__Direction_k__BackingField;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeFieldInfoPtr__Normal_k__BackingField;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeFieldInfoPtr__Distance_k__BackingField;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr_set_Origin_Public_set_Void_Vector3_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector3_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_Single_0;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_get_Instance_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Public_set_Void_Instance_0;
	}
}
