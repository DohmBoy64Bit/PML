using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F6 RID: 502
	public class WorldTransformSnapshot : global::Il2CppSystem.Object
	{
		// Token: 0x060028A5 RID: 10405 RVA: 0x000C2D0C File Offset: 0x000C0F0C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldTransformSnapshot()
		{
			Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "WorldTransformSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr);
			WorldTransformSnapshot.NativeFieldInfoPtr__worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, "_worldPosition");
			WorldTransformSnapshot.NativeFieldInfoPtr__worldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, "_worldRotation");
			WorldTransformSnapshot.NativeFieldInfoPtr__worldScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, "_worldScale");
			WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669519);
			WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669520);
			WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669521);
			WorldTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669524);
			WorldTransformSnapshot.NativeMethodInfoPtr_Snaphot_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669522);
			WorldTransformSnapshot.NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr, 100669523);
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000C2DF0 File Offset: 0x000C0FF0
		public unsafe Vector3 WorldPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000C2E30 File Offset: 0x000C1030
		public unsafe Quaternion WorldRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000C2E70 File Offset: 0x000C1070
		public unsafe Vector3 WorldScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr_get_WorldScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000C2EB0 File Offset: 0x000C10B0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldTransformSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldTransformSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000C2EEC File Offset: 0x000C10EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90987, RefRangeEnd = 90990, XrefRangeStart = 90980, XrefRangeEnd = 90987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snaphot(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr_Snaphot_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000C2F30 File Offset: 0x000C1130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90993, RefRangeEnd = 90995, XrefRangeStart = 90990, XrefRangeEnd = 90993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SameAs(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldTransformSnapshot.NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000100E7 File Offset: 0x0000E2E7
		public WorldTransformSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000C2F80 File Offset: 0x000C1180
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x000100F0 File Offset: 0x0000E2F0
		public unsafe Vector3 _worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000C2FB0 File Offset: 0x000C11B0
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0001010F File Offset: 0x0000E30F
		public unsafe Quaternion _worldRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000C2FE0 File Offset: 0x000C11E0
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0001012E File Offset: 0x0000E32E
		public unsafe Vector3 _worldScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldTransformSnapshot.NativeFieldInfoPtr__worldScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr__worldPosition;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr__worldRotation;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr__worldScale;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldScale_Public_get_Vector3_0;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeMethodInfoPtr_Snaphot_Public_Void_Transform_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0;
	}
}
