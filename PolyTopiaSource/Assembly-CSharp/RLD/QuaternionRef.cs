using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000176 RID: 374
	public class QuaternionRef : global::Il2CppSystem.Object
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x00099A5C File Offset: 0x00097C5C
		// Note: this type is marked as 'beforefieldinit'.
		static QuaternionRef()
		{
			Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuaternionRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr);
			QuaternionRef.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr, "_value");
			QuaternionRef.NativeMethodInfoPtr_get_Value_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr, 100667905);
			QuaternionRef.NativeMethodInfoPtr_set_Value_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr, 100667906);
			QuaternionRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr, 100667907);
			QuaternionRef.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr, 100667908);
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00099AF0 File Offset: 0x00097CF0
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00099B30 File Offset: 0x00097D30
		public unsafe Quaternion Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionRef.NativeMethodInfoPtr_get_Value_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionRef.NativeMethodInfoPtr_set_Value_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00099B74 File Offset: 0x00097D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81463, XrefRangeEnd = 81466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuaternionRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00099BB0 File Offset: 0x00097DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81466, XrefRangeEnd = 81469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuaternionRef(Quaternion quat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuaternionRef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionRef.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000C5D1 File Offset: 0x0000A7D1
		public QuaternionRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00099BFC File Offset: 0x00097DFC
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0000C5DA File Offset: 0x0000A7DA
		public unsafe Quaternion _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuaternionRef.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuaternionRef.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Quaternion_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Quaternion_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0;
	}
}
