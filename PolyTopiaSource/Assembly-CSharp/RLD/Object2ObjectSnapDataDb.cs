using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000206 RID: 518
	public class Object2ObjectSnapDataDb : Singleton<Object2ObjectSnapDataDb>
	{
		// Token: 0x0600296C RID: 10604 RVA: 0x000C57BC File Offset: 0x000C39BC
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapDataDb()
		{
			Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapDataDb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr);
			Object2ObjectSnapDataDb.NativeFieldInfoPtr__objectToSnapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr, "_objectToSnapData");
			Object2ObjectSnapDataDb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr, 100669629);
			Object2ObjectSnapDataDb.NativeMethodInfoPtr_GetObject2ObjectSnapData_Public_Object2ObjectSnapData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr, 100669628);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000C5828 File Offset: 0x000C3A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91803, XrefRangeEnd = 91816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapDataDb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapDataDb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapDataDb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000C5864 File Offset: 0x000C3A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91816, XrefRangeEnd = 91856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapData GetObject2ObjectSnapData(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapDataDb.NativeMethodInfoPtr_GetObject2ObjectSnapData_Public_Object2ObjectSnapData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapData>(intPtr3) : null;
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000105C5 File Offset: 0x0000E7C5
		public Object2ObjectSnapDataDb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000C58B4 File Offset: 0x000C3AB4
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x000105CE File Offset: 0x0000E7CE
		public unsafe Dictionary<GameObject, Object2ObjectSnapData> _objectToSnapData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapDataDb.NativeFieldInfoPtr__objectToSnapData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, Object2ObjectSnapData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapDataDb.NativeFieldInfoPtr__objectToSnapData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr__objectToSnapData;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr_GetObject2ObjectSnapData_Public_Object2ObjectSnapData_GameObject_0;
	}
}
