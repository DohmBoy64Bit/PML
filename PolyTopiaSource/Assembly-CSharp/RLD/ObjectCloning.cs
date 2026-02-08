using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000209 RID: 521
	public static class ObjectCloning : global::Il2CppSystem.Object
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x000C6120 File Offset: 0x000C4320
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectCloning()
		{
			Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectCloning");
			ObjectCloning.NativeFieldInfoPtr__defaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr, "_defaultConfig");
			ObjectCloning.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr, 100669652);
			ObjectCloning.NativeMethodInfoPtr_CloneHierarchies_Public_Static_List_1_GameObject_List_1_GameObject_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr, 100669653);
			ObjectCloning.NativeMethodInfoPtr_CloneHierarchy_Public_Static_GameObject_GameObject_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr, 100669654);
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x000C6198 File Offset: 0x000C4398
		public unsafe static ObjectCloning.Config DefaultConfig
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92227, XrefRangeEnd = 92231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCloning.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ObjectCloning.Config(intPtr);
			}
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000C61C4 File Offset: 0x000C43C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92231, XrefRangeEnd = 92264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> CloneHierarchies(List<GameObject> roots, ObjectCloning.Config cloneConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cloneConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCloning.NativeMethodInfoPtr_CloneHierarchies_Public_Static_List_1_GameObject_List_1_GameObject_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000C6220 File Offset: 0x000C4420
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92295, RefRangeEnd = 92299, XrefRangeStart = 92264, XrefRangeEnd = 92295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CloneHierarchy(GameObject root, ObjectCloning.Config cloneConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cloneConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCloning.NativeMethodInfoPtr_CloneHierarchy_Public_Static_GameObject_GameObject_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0001060D File Offset: 0x0000E80D
		public ObjectCloning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x000C627C File Offset: 0x000C447C
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x00010616 File Offset: 0x0000E816
		public unsafe static ObjectCloning.Config _defaultConfig
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ObjectCloning.NativeFieldInfoPtr__defaultConfig, intPtr);
				return new ObjectCloning.Config(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectCloning.NativeFieldInfoPtr__defaultConfig, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr__defaultConfig;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr_CloneHierarchies_Public_Static_List_1_GameObject_List_1_GameObject_Config_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr_CloneHierarchy_Public_Static_GameObject_GameObject_Config_0;

		// Token: 0x020003C9 RID: 969
		[Flags]
		public enum TransformFlags
		{
			// Token: 0x04003B85 RID: 15237
			None = 0,
			// Token: 0x04003B86 RID: 15238
			Position = 1,
			// Token: 0x04003B87 RID: 15239
			Rotation = 2,
			// Token: 0x04003B88 RID: 15240
			Scale = 4,
			// Token: 0x04003B89 RID: 15241
			All = 7
		}

		// Token: 0x020003CA RID: 970
		public sealed class Config : ValueType
		{
			// Token: 0x06004C97 RID: 19607 RVA: 0x0014DF1C File Offset: 0x0014C11C
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCloning>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr);
				ObjectCloning.Config.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr, "Parent");
				ObjectCloning.Config.NativeFieldInfoPtr_TransformFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr, "TransformFlags");
				ObjectCloning.Config.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr, "Layer");
			}

			// Token: 0x06004C98 RID: 19608 RVA: 0x0001CCCF File Offset: 0x0001AECF
			public Config(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004C99 RID: 19609 RVA: 0x0001CCD8 File Offset: 0x0001AED8
			public Config()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCloning.Config>.NativeClassPtr))
			{
			}

			// Token: 0x170019D1 RID: 6609
			// (get) Token: 0x06004C9A RID: 19610 RVA: 0x0014DF84 File Offset: 0x0014C184
			// (set) Token: 0x06004C9B RID: 19611 RVA: 0x0001CCEA File Offset: 0x0001AEEA
			public unsafe Transform Parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_Parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D2 RID: 6610
			// (get) Token: 0x06004C9C RID: 19612 RVA: 0x0014DFB4 File Offset: 0x0014C1B4
			// (set) Token: 0x06004C9D RID: 19613 RVA: 0x0001CD09 File Offset: 0x0001AF09
			public unsafe ObjectCloning.TransformFlags TransformFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_TransformFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_TransformFlags)) = value;
				}
			}

			// Token: 0x170019D3 RID: 6611
			// (get) Token: 0x06004C9E RID: 19614 RVA: 0x0014DFDC File Offset: 0x0014C1DC
			// (set) Token: 0x06004C9F RID: 19615 RVA: 0x0001CD24 File Offset: 0x0001AF24
			public unsafe int Layer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_Layer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCloning.Config.NativeFieldInfoPtr_Layer)) = value;
				}
			}

			// Token: 0x04003B8A RID: 15242
			private static readonly IntPtr NativeFieldInfoPtr_Parent;

			// Token: 0x04003B8B RID: 15243
			private static readonly IntPtr NativeFieldInfoPtr_TransformFlags;

			// Token: 0x04003B8C RID: 15244
			private static readonly IntPtr NativeFieldInfoPtr_Layer;
		}
	}
}
