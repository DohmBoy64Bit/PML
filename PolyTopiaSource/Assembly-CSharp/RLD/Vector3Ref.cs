using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017A RID: 378
	public class Vector3Ref : global::Il2CppSystem.Object
	{
		// Token: 0x06001E49 RID: 7753 RVA: 0x0009A1EC File Offset: 0x000983EC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Ref()
		{
			Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Vector3Ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr);
			Vector3Ref.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr, "_value");
			Vector3Ref.NativeMethodInfoPtr_get_Value_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr, 100667923);
			Vector3Ref.NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr, 100667924);
			Vector3Ref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr, 100667925);
			Vector3Ref.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr, 100667926);
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0009A280 File Offset: 0x00098480
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0009A2C0 File Offset: 0x000984C0
		public unsafe Vector3 Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ref.NativeMethodInfoPtr_get_Value_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ref.NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0009A304 File Offset: 0x00098504
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Ref()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0009A340 File Offset: 0x00098540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81520, XrefRangeEnd = 81521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Ref(Vector3 vec)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Ref>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ref.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0000C626 File Offset: 0x0000A826
		public Vector3Ref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0009A38C File Offset: 0x0009858C
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0000C62F File Offset: 0x0000A82F
		public unsafe Vector3 _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Ref.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Ref.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Vector3_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Vector3_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;
	}
}
