using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020C RID: 524
	public static class ObjectSpawnUtil : global::Il2CppSystem.Object
	{
		// Token: 0x0600299C RID: 10652 RVA: 0x000C64B0 File Offset: 0x000C46B0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSpawnUtil()
		{
			Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSpawnUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr);
			ObjectSpawnUtil.NativeFieldInfoPtr__defaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr, "_defaultConfig");
			ObjectSpawnUtil.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr, 100669659);
			ObjectSpawnUtil.NativeMethodInfoPtr_SpawnInFrontOfCamera_Public_Static_GameObject_GameObject_Camera_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr, 100669660);
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000C651C File Offset: 0x000C471C
		public unsafe static ObjectSpawnUtil.Config DefaultConfig
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92340, XrefRangeEnd = 92344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSpawnUtil.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000C654C File Offset: 0x000C474C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92416, RefRangeEnd = 92417, XrefRangeStart = 92344, XrefRangeEnd = 92416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject SpawnInFrontOfCamera(GameObject sourceObject, Camera camera, ObjectSpawnUtil.Config config)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSpawnUtil.NativeMethodInfoPtr_SpawnInFrontOfCamera_Public_Static_GameObject_GameObject_Camera_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0001064D File Offset: 0x0000E84D
		public ObjectSpawnUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000C65B0 File Offset: 0x000C47B0
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x00010656 File Offset: 0x0000E856
		public unsafe static ObjectSpawnUtil.Config _defaultConfig
		{
			get
			{
				ObjectSpawnUtil.Config config;
				IL2CPP.il2cpp_field_static_get_value(ObjectSpawnUtil.NativeFieldInfoPtr__defaultConfig, (void*)(&config));
				return config;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectSpawnUtil.NativeFieldInfoPtr__defaultConfig, (void*)(&value));
			}
		}

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr__defaultConfig;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_SpawnInFrontOfCamera_Public_Static_GameObject_GameObject_Camera_Config_0;

		// Token: 0x020003CB RID: 971
		[StructLayout(2)]
		public struct Config
		{
			// Token: 0x06004CA0 RID: 19616 RVA: 0x0001CD3F File Offset: 0x0001AF3F
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<ObjectSpawnUtil.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSpawnUtil>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSpawnUtil.Config>.NativeClassPtr);
				ObjectSpawnUtil.Config.NativeFieldInfoPtr_ObjectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpawnUtil.Config>.NativeClassPtr, "ObjectSize");
			}

			// Token: 0x06004CA1 RID: 19617 RVA: 0x0001CD73 File Offset: 0x0001AF73
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectSpawnUtil.Config>.NativeClassPtr, ref this));
			}

			// Token: 0x04003B8D RID: 15245
			private static readonly IntPtr NativeFieldInfoPtr_ObjectSize;

			// Token: 0x04003B8E RID: 15246
			[FieldOffset(0)]
			public float ObjectSize;
		}
	}
}
