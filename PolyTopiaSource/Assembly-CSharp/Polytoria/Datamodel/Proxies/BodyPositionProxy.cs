using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D0 RID: 720
	public class BodyPositionProxy : InstanceProxy
	{
		// Token: 0x06003F8D RID: 16269 RVA: 0x0011D3B8 File Offset: 0x0011B5B8
		// Note: this type is marked as 'beforefieldinit'.
		static BodyPositionProxy()
		{
			Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "BodyPositionProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr);
			BodyPositionProxy.NativeFieldInfoPtr_bodyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, "bodyPosition");
			BodyPositionProxy.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673218);
			BodyPositionProxy.NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673219);
			BodyPositionProxy.NativeMethodInfoPtr_get_Force_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673220);
			BodyPositionProxy.NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673221);
			BodyPositionProxy.NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673222);
			BodyPositionProxy.NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673223);
			BodyPositionProxy.NativeMethodInfoPtr__ctor_Public_Void_BodyPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr, 100673217);
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06003F8E RID: 16270 RVA: 0x0011D488 File Offset: 0x0011B688
		// (set) Token: 0x06003F8F RID: 16271 RVA: 0x0011D4C8 File Offset: 0x0011B6C8
		public unsafe Vector3 TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128460, XrefRangeEnd = 128461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x0011D50C File Offset: 0x0011B70C
		// (set) Token: 0x06003F91 RID: 16273 RVA: 0x0011D548 File Offset: 0x0011B748
		public unsafe float Force
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_get_Force_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128461, XrefRangeEnd = 128463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06003F92 RID: 16274 RVA: 0x0011D588 File Offset: 0x0011B788
		// (set) Token: 0x06003F93 RID: 16275 RVA: 0x0011D5C4 File Offset: 0x0011B7C4
		public unsafe float AcceptanceDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x0011D604 File Offset: 0x0011B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodyPositionProxy(BodyPosition target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodyPositionProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodyPositionProxy.NativeMethodInfoPtr__ctor_Public_Void_BodyPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000184C1 File Offset: 0x000166C1
		public BodyPositionProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x0011D650 File Offset: 0x0011B850
		// (set) Token: 0x06003F97 RID: 16279 RVA: 0x000184CA File Offset: 0x000166CA
		public unsafe BodyPosition bodyPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPositionProxy.NativeFieldInfoPtr_bodyPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodyPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodyPositionProxy.NativeFieldInfoPtr_bodyPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeFieldInfoPtr_bodyPosition;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_get_Force_Public_get_Single_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_set_Force_Public_set_Void_Single_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptanceDistance_Public_get_Single_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptanceDistance_Public_set_Void_Single_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BodyPosition_0;
	}
}
