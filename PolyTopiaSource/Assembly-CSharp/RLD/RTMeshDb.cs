using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018D RID: 397
	public class RTMeshDb : Singleton<RTMeshDb>
	{
		// Token: 0x06001F00 RID: 7936 RVA: 0x0009D104 File Offset: 0x0009B304
		// Note: this type is marked as 'beforefieldinit'.
		static RTMeshDb()
		{
			Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTMeshDb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr);
			RTMeshDb.NativeFieldInfoPtr__meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, "_meshes");
			RTMeshDb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668023);
			RTMeshDb.NativeMethodInfoPtr_Contains_Public_Boolean_RTMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668018);
			RTMeshDb.NativeMethodInfoPtr_Contains_Public_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668019);
			RTMeshDb.NativeMethodInfoPtr_GetRTMesh_Public_RTMesh_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668020);
			RTMeshDb.NativeMethodInfoPtr_OnMeshWillBeDestroyed_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668021);
			RTMeshDb.NativeMethodInfoPtr_CreateRTMesh_Private_RTMesh_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr, 100668022);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0009D1C0 File Offset: 0x0009B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83062, XrefRangeEnd = 83075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTMeshDb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTMeshDb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0009D1FC File Offset: 0x0009B3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83075, XrefRangeEnd = 83078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(RTMesh rtMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rtMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr_Contains_Public_Boolean_RTMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0009D24C File Offset: 0x0009B44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83078, XrefRangeEnd = 83085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Mesh unityMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr_Contains_Public_Boolean_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0009D29C File Offset: 0x0009B49C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83095, RefRangeEnd = 83098, XrefRangeStart = 83085, XrefRangeEnd = 83095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTMesh GetRTMesh(Mesh unityMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr_GetRTMesh_Public_RTMesh_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTMesh>(intPtr3) : null;
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0009D2EC File Offset: 0x0009B4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83098, XrefRangeEnd = 83104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMeshWillBeDestroyed(Mesh unityMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr_OnMeshWillBeDestroyed_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0009D330 File Offset: 0x0009B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83104, XrefRangeEnd = 83119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTMesh CreateRTMesh(Mesh unityMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshDb.NativeMethodInfoPtr_CreateRTMesh_Private_RTMesh_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTMesh>(intPtr3) : null;
			}
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		public RTMeshDb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0009D380 File Offset: 0x0009B580
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0000CA85 File Offset: 0x0000AC85
		public unsafe Dictionary<Mesh, RTMesh> _meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMeshDb.NativeFieldInfoPtr__meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Mesh, RTMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMeshDb.NativeFieldInfoPtr__meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeFieldInfoPtr__meshes;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_RTMesh_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Mesh_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_GetRTMesh_Public_RTMesh_Mesh_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_OnMeshWillBeDestroyed_Public_Void_Mesh_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_CreateRTMesh_Private_RTMesh_Mesh_0;
	}
}
