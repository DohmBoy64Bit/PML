using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EA RID: 746
	public class PartProxy : DynamicInstanceProxy
	{
		// Token: 0x06004150 RID: 16720 RVA: 0x001254B4 File Offset: 0x001236B4
		// Note: this type is marked as 'beforefieldinit'.
		static PartProxy()
		{
			Il2CppClassPointerStore<PartProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PartProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartProxy>.NativeClassPtr);
			PartProxy.NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, "part");
			PartProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673565);
			PartProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673566);
			PartProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673567);
			PartProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673568);
			PartProxy.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673569);
			PartProxy.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673570);
			PartProxy.NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673571);
			PartProxy.NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673572);
			PartProxy.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673573);
			PartProxy.NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673574);
			PartProxy.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673575);
			PartProxy.NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673576);
			PartProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673577);
			PartProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673578);
			PartProxy.NativeMethodInfoPtr_get_Drag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673579);
			PartProxy.NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673580);
			PartProxy.NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673581);
			PartProxy.NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673582);
			PartProxy.NativeMethodInfoPtr_get_Mass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673583);
			PartProxy.NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673584);
			PartProxy.NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673585);
			PartProxy.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673586);
			PartProxy.NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673587);
			PartProxy.NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673588);
			PartProxy.NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673589);
			PartProxy.NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673590);
			PartProxy.NativeMethodInfoPtr_get_Friction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673591);
			PartProxy.NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673592);
			PartProxy.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673593);
			PartProxy.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673594);
			PartProxy.NativeMethodInfoPtr__ctor_Public_Void_Part_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673564);
			PartProxy.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673595);
			PartProxy.NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673596);
			PartProxy.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673597);
			PartProxy.NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673598);
			PartProxy.NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673599);
			PartProxy.NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673600);
			PartProxy.NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProxy>.NativeClassPtr, 100673601);
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x001257F0 File Offset: 0x001239F0
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x00125830 File Offset: 0x00123A30
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128787, XrefRangeEnd = 128788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00125874 File Offset: 0x00123A74
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x001258B0 File Offset: 0x00123AB0
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128788, XrefRangeEnd = 128790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x001258F0 File Offset: 0x00123AF0
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x0012592C File Offset: 0x00123B2C
		public unsafe bool CanCollide
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128790, XrefRangeEnd = 128792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x0012596C File Offset: 0x00123B6C
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x001259A8 File Offset: 0x00123BA8
		public unsafe bool IsSpawn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128792, XrefRangeEnd = 128794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x001259E8 File Offset: 0x00123BE8
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x00125A28 File Offset: 0x00123C28
		public unsafe PartShape Shape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128794, XrefRangeEnd = 128796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x00125A6C File Offset: 0x00123C6C
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00125AAC File Offset: 0x00123CAC
		public unsafe PartMaterial Material
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128796, XrefRangeEnd = 128798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00125AF0 File Offset: 0x00123CF0
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x00125B30 File Offset: 0x00123D30
		public unsafe Vector3 Velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128798, XrefRangeEnd = 128799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128799, XrefRangeEnd = 128800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00125B74 File Offset: 0x00123D74
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x00125BB0 File Offset: 0x00123DB0
		public unsafe float Drag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128800, XrefRangeEnd = 128802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Drag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128802, XrefRangeEnd = 128804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00125BF0 File Offset: 0x00123DF0
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x00125C2C File Offset: 0x00123E2C
		public unsafe float AngularDrag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128804, XrefRangeEnd = 128806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128806, XrefRangeEnd = 128808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00125C6C File Offset: 0x00123E6C
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x00125CA8 File Offset: 0x00123EA8
		public unsafe float Mass
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128808, XrefRangeEnd = 128810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Mass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128810, XrefRangeEnd = 128812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00125CE8 File Offset: 0x00123EE8
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x00125D28 File Offset: 0x00123F28
		public unsafe Vector3 AngularVelocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128812, XrefRangeEnd = 128813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128813, XrefRangeEnd = 128814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00125D6C File Offset: 0x00123F6C
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x00125DA8 File Offset: 0x00123FA8
		public unsafe bool UseGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128814, XrefRangeEnd = 128816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x00125DE8 File Offset: 0x00123FE8
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x00125E24 File Offset: 0x00124024
		public unsafe float Bounciness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128816, XrefRangeEnd = 128818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128818, XrefRangeEnd = 128820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x00125E64 File Offset: 0x00124064
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x00125EA0 File Offset: 0x001240A0
		public unsafe float Friction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128820, XrefRangeEnd = 128822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_Friction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128822, XrefRangeEnd = 128824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x00125EE0 File Offset: 0x001240E0
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00125F1C File Offset: 0x0012411C
		public unsafe bool CastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128824, XrefRangeEnd = 128826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x00125F5C File Offset: 0x0012415C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartProxy(Part target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr__ctor_Public_Void_Part_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x00125FA8 File Offset: 0x001241A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128826, XrefRangeEnd = 128827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x00125FEC File Offset: 0x001241EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128827, XrefRangeEnd = 128828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(Vector3 rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00126030 File Offset: 0x00124230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128828, XrefRangeEnd = 128829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00126084 File Offset: 0x00124284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128829, XrefRangeEnd = 128830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torque);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x001260D8 File Offset: 0x001242D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128830, XrefRangeEnd = 128831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00126140 File Offset: 0x00124340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128831, XrefRangeEnd = 128832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRelativeForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00126194 File Offset: 0x00124394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128832, XrefRangeEnd = 128833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torque);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartProxy.NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x000188D1 File Offset: 0x00016AD1
		public PartProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x001261E8 File Offset: 0x001243E8
		// (set) Token: 0x06004179 RID: 16761 RVA: 0x000188DA File Offset: 0x00016ADA
		public unsafe Part part
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartProxy.NativeFieldInfoPtr_part);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Part>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartProxy.NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeFieldInfoPtr_part;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_get_Drag_Public_get_Single_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_get_Mass_Public_get_Single_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0;

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeMethodInfoPtr_get_Friction_Public_get_Single_0;

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Part_0;

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0;
	}
}
