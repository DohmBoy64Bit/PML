using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200033A RID: 826
	public static class SpawnpointController : global::Il2CppSystem.Object
	{
		// Token: 0x060046C4 RID: 18116 RVA: 0x0013ABDC File Offset: 0x00138DDC
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnpointController()
		{
			Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "SpawnpointController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr);
			SpawnpointController.NativeFieldInfoPtr_spawns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr, "spawns");
			SpawnpointController.NativeMethodInfoPtr_GetDefaultSpawnPosition_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr, 100674498);
			SpawnpointController.NativeMethodInfoPtr_AddSpawn_Public_Static_Void_Part_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr, 100674499);
			SpawnpointController.NativeMethodInfoPtr_RemoveSpawn_Public_Static_Void_Part_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr, 100674500);
			SpawnpointController.NativeMethodInfoPtr_GetSpawnPosition_Public_Static_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnpointController>.NativeClassPtr, 100674501);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0013AC70 File Offset: 0x00138E70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137365, RefRangeEnd = 137367, XrefRangeStart = 137363, XrefRangeEnd = 137365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetDefaultSpawnPosition()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnpointController.NativeMethodInfoPtr_GetDefaultSpawnPosition_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x0013ACA4 File Offset: 0x00138EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137386, RefRangeEnd = 137387, XrefRangeStart = 137367, XrefRangeEnd = 137386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpawn(Part p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnpointController.NativeMethodInfoPtr_AddSpawn_Public_Static_Void_Part_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0013ACDC File Offset: 0x00138EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137406, RefRangeEnd = 137408, XrefRangeStart = 137387, XrefRangeEnd = 137406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSpawn(Part p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnpointController.NativeMethodInfoPtr_RemoveSpawn_Public_Static_Void_Part_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0013AD14 File Offset: 0x00138F14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137426, RefRangeEnd = 137429, XrefRangeStart = 137408, XrefRangeEnd = 137426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetSpawnPosition()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnpointController.NativeMethodInfoPtr_GetSpawnPosition_Public_Static_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0001A34D File Offset: 0x0001854D
		public SpawnpointController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x0013AD48 File Offset: 0x00138F48
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x0001A356 File Offset: 0x00018556
		public unsafe static List<Part> spawns
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpawnpointController.NativeFieldInfoPtr_spawns, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Part>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpawnpointController.NativeFieldInfoPtr_spawns, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeFieldInfoPtr_spawns;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSpawnPosition_Public_Static_Vector3_0;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeMethodInfoPtr_AddSpawn_Public_Static_Void_Part_0;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpawn_Public_Static_Void_Part_0;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnPosition_Public_Static_Transform_0;
	}
}
