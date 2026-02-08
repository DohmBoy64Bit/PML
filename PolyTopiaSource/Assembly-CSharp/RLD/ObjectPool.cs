using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000191 RID: 401
	public class ObjectPool : global::Il2CppSystem.Object
	{
		// Token: 0x06001F2A RID: 7978 RVA: 0x0009DA9C File Offset: 0x0009BC9C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr);
			ObjectPool.NativeFieldInfoPtr__sourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, "_sourceObject");
			ObjectPool.NativeFieldInfoPtr__growMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, "_growMode");
			ObjectPool.NativeFieldInfoPtr__growAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, "_growAmount");
			ObjectPool.NativeFieldInfoPtr__pooledObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, "_pooledObjects");
			ObjectPool.NativeFieldInfoPtr__pooledParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, "_pooledParent");
			ObjectPool.NativeMethodInfoPtr_get_PoolGrowMode_Public_get_GrowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668041);
			ObjectPool.NativeMethodInfoPtr_set_PoolGrowMode_Public_set_Void_GrowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668042);
			ObjectPool.NativeMethodInfoPtr_get_GrowAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668043);
			ObjectPool.NativeMethodInfoPtr_set_GrowAmount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668044);
			ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_GrowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668045);
			ObjectPool.NativeMethodInfoPtr_SetPooledObjectsParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668046);
			ObjectPool.NativeMethodInfoPtr_GetPooledObject_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668047);
			ObjectPool.NativeMethodInfoPtr_MarkAsUnused_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668048);
			ObjectPool.NativeMethodInfoPtr_MarkAllAsUnused_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668049);
			ObjectPool.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668050);
			ObjectPool.NativeMethodInfoPtr_CreatePooledObject_Private_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100668051);
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0009DC0C File Offset: 0x0009BE0C
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0009DC48 File Offset: 0x0009BE48
		public unsafe ObjectPool.GrowMode PoolGrowMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_get_PoolGrowMode_Public_get_GrowMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_set_PoolGrowMode_Public_set_Void_GrowMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0009DC88 File Offset: 0x0009BE88
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0009DCC4 File Offset: 0x0009BEC4
		public unsafe int GrowAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_get_GrowAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83138, RefRangeEnd = 83139, XrefRangeStart = 83138, XrefRangeEnd = 83138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_set_GrowAmount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0009DD04 File Offset: 0x0009BF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83148, RefRangeEnd = 83149, XrefRangeStart = 83139, XrefRangeEnd = 83148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(GameObject sourceObject, int numPooled, ObjectPool.GrowMode growMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPooled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_GrowMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0009DD6C File Offset: 0x0009BF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83171, RefRangeEnd = 83172, XrefRangeStart = 83149, XrefRangeEnd = 83171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPooledObjectsParent(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_SetPooledObjectsParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x0009DDB0 File Offset: 0x0009BFB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83195, RefRangeEnd = 83196, XrefRangeStart = 83172, XrefRangeEnd = 83195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetPooledObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_GetPooledObject_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0009DDF0 File Offset: 0x0009BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83196, XrefRangeEnd = 83201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsUnused(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_MarkAsUnused_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0009DE34 File Offset: 0x0009C034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83220, RefRangeEnd = 83222, XrefRangeStart = 83201, XrefRangeEnd = 83220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAllAsUnused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_MarkAllAsUnused_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0009DE68 File Offset: 0x0009C068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83222, XrefRangeEnd = 83238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0009DE9C File Offset: 0x0009C09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83253, RefRangeEnd = 83254, XrefRangeStart = 83238, XrefRangeEnd = 83253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject CreatePooledObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_CreatePooledObject_Private_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0000CB39 File Offset: 0x0000AD39
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0009DEDC File Offset: 0x0009C0DC
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x0000CB42 File Offset: 0x0000AD42
		public unsafe GameObject _sourceObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__sourceObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__sourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0009DF0C File Offset: 0x0009C10C
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0000CB61 File Offset: 0x0000AD61
		public unsafe ObjectPool.GrowMode _growMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__growMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__growMode)) = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0009DF34 File Offset: 0x0009C134
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		public unsafe int _growAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__growAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__growAmount)) = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0009DF5C File Offset: 0x0009C15C
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x0000CB97 File Offset: 0x0000AD97
		public unsafe List<GameObject> _pooledObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__pooledObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__pooledObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0009DF8C File Offset: 0x0009C18C
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x0000CBB6 File Offset: 0x0000ADB6
		public unsafe Transform _pooledParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__pooledParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr__pooledParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr__sourceObject;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr__growMode;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr__growAmount;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeFieldInfoPtr__pooledObjects;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeFieldInfoPtr__pooledParent;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_get_PoolGrowMode_Public_get_GrowMode_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_set_PoolGrowMode_Public_set_Void_GrowMode_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_get_GrowAmount_Public_get_Int32_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_set_GrowAmount_Public_set_Void_Int32_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_GrowMode_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_SetPooledObjectsParent_Public_Void_Transform_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_GetPooledObject_Public_GameObject_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsUnused_Public_Void_GameObject_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_MarkAllAsUnused_Public_Void_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledObject_Private_GameObject_0;

		// Token: 0x02000396 RID: 918
		public enum GrowMode
		{
			// Token: 0x04003A71 RID: 14961
			None,
			// Token: 0x04003A72 RID: 14962
			Increment,
			// Token: 0x04003A73 RID: 14963
			ByAmount
		}
	}
}
