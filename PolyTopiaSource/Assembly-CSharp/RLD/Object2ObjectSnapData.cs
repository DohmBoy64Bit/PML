using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000205 RID: 517
	public class Object2ObjectSnapData : global::Il2CppSystem.Object
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x000C5424 File Offset: 0x000C3624
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapData()
		{
			Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr);
			Object2ObjectSnapData.NativeFieldInfoPtr__gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, "_gameObject");
			Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, "_snapAreaBounds");
			Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, "_snapAreaDesc");
			Object2ObjectSnapData.NativeFieldInfoPtr__vertsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, "_vertsBuffer");
			Object2ObjectSnapData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669627);
			Object2ObjectSnapData.NativeMethodInfoPtr_Initialize_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669622);
			Object2ObjectSnapData.NativeMethodInfoPtr_GetWorldSnapAreaDesc_Public_BoxFaceAreaDesc_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669623);
			Object2ObjectSnapData.NativeMethodInfoPtr_GetAllWorldSnapAreaBounds_Public_List_1_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669624);
			Object2ObjectSnapData.NativeMethodInfoPtr_GetWorldSnapAreaBounds_Public_OBB_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669625);
			Object2ObjectSnapData.NativeMethodInfoPtr_BuildVertOverlapAABBs_Private_List_1_AABB_GameObject_Sprite_RTMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr, 100669626);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000C551C File Offset: 0x000C371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91675, XrefRangeEnd = 91705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000C5558 File Offset: 0x000C3758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91753, RefRangeEnd = 91754, XrefRangeStart = 91705, XrefRangeEnd = 91753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr_Initialize_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000C55A8 File Offset: 0x000C37A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91754, XrefRangeEnd = 91761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxFaceAreaDesc GetWorldSnapAreaDesc(BoxFace boxFace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr_GetWorldSnapAreaDesc_Public_BoxFaceAreaDesc_BoxFace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFaceAreaDesc>(intPtr3) : null;
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000C55F8 File Offset: 0x000C37F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91761, XrefRangeEnd = 91779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<OBB> GetAllWorldSnapAreaBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr_GetAllWorldSnapAreaBounds_Public_List_1_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<OBB>>(intPtr3) : null;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000C5638 File Offset: 0x000C3838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91779, XrefRangeEnd = 91787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB GetWorldSnapAreaBounds(BoxFace boxFace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr_GetWorldSnapAreaBounds_Public_OBB_BoxFace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000C5688 File Offset: 0x000C3888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91787, XrefRangeEnd = 91803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<AABB> BuildVertOverlapAABBs(GameObject gameObject, Sprite sprite, RTMesh rtMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtMesh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapData.NativeMethodInfoPtr_BuildVertOverlapAABBs_Private_List_1_AABB_GameObject_Sprite_RTMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AABB>>(intPtr3) : null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00010540 File Offset: 0x0000E740
		public Object2ObjectSnapData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000C56FC File Offset: 0x000C38FC
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x00010549 File Offset: 0x0000E749
		public unsafe GameObject _gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000C572C File Offset: 0x000C392C
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x00010568 File Offset: 0x0000E768
		public unsafe Il2CppStructArray<AABB> _snapAreaBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AABB>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000C575C File Offset: 0x000C395C
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x00010587 File Offset: 0x0000E787
		public unsafe Il2CppStructArray<BoxFaceAreaDesc> _snapAreaDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BoxFaceAreaDesc>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__snapAreaDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000C578C File Offset: 0x000C398C
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x000105A6 File Offset: 0x0000E7A6
		public unsafe List<Vector3> _vertsBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__vertsBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnapData.NativeFieldInfoPtr__vertsBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr__gameObject;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr__snapAreaBounds;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr__snapAreaDesc;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr__vertsBuffer;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_GameObject_0;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldSnapAreaDesc_Public_BoxFaceAreaDesc_BoxFace_0;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeMethodInfoPtr_GetAllWorldSnapAreaBounds_Public_List_1_OBB_0;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldSnapAreaBounds_Public_OBB_BoxFace_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_BuildVertOverlapAABBs_Private_List_1_AABB_GameObject_Sprite_RTMesh_0;
	}
}
