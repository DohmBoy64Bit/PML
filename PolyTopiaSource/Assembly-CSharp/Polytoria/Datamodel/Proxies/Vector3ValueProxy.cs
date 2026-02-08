using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000308 RID: 776
	public class Vector3ValueProxy : ValueBaseProxy
	{
		// Token: 0x06004350 RID: 17232 RVA: 0x0012E4AC File Offset: 0x0012C6AC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3ValueProxy()
		{
			Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "Vector3ValueProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr);
			Vector3ValueProxy.NativeFieldInfoPtr_vector3Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr, "vector3Value");
			Vector3ValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr, 100673957);
			Vector3ValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr, 100673958);
			Vector3ValueProxy.NativeMethodInfoPtr__ctor_Public_Void_Vector3Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr, 100673956);
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x0012E52C File Offset: 0x0012C72C
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x0012E56C File Offset: 0x0012C76C
		public unsafe Vector3 Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ValueProxy.NativeMethodInfoPtr_get_Value_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129181, XrefRangeEnd = 129182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ValueProxy.NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x0012E5B0 File Offset: 0x0012C7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3ValueProxy(Vector3Value target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3ValueProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ValueProxy.NativeMethodInfoPtr__ctor_Public_Void_Vector3Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00018D81 File Offset: 0x00016F81
		public Vector3ValueProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x0012E5FC File Offset: 0x0012C7FC
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x00018D8A File Offset: 0x00016F8A
		public unsafe Vector3Value vector3Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ValueProxy.NativeFieldInfoPtr_vector3Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3Value>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ValueProxy.NativeFieldInfoPtr_vector3Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003477 RID: 13431
		private static readonly IntPtr NativeFieldInfoPtr_vector3Value;

		// Token: 0x04003478 RID: 13432
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Vector3_0;

		// Token: 0x04003479 RID: 13433
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0;

		// Token: 0x0400347A RID: 13434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Value_0;
	}
}
