using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000195 RID: 405
	[Serializable]
	public class PrefabLibDbSettings : Object
	{
		// Token: 0x06001F50 RID: 8016 RVA: 0x0009E3E0 File Offset: 0x0009C5E0
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLibDbSettings()
		{
			Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabLibDbSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr);
			PrefabLibDbSettings.NativeFieldInfoPtr__spawnPrefabOnPreviewClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr, "_spawnPrefabOnPreviewClick");
			PrefabLibDbSettings.NativeMethodInfoPtr_get_SpawnPrefabOnPreviewClick_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr, 100668068);
			PrefabLibDbSettings.NativeMethodInfoPtr_set_SpawnPrefabOnPreviewClick_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr, 100668069);
			PrefabLibDbSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr, 100668070);
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0009E460 File Offset: 0x0009C660
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0009E49C File Offset: 0x0009C69C
		public unsafe bool SpawnPrefabOnPreviewClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbSettings.NativeMethodInfoPtr_get_SpawnPrefabOnPreviewClick_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbSettings.NativeMethodInfoPtr_set_SpawnPrefabOnPreviewClick_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0009E4DC File Offset: 0x0009C6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83373, XrefRangeEnd = 83374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLibDbSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLibDbSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLibDbSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x0000CBFD File Offset: 0x0000ADFD
		public PrefabLibDbSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0009E518 File Offset: 0x0009C718
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x0000CC06 File Offset: 0x0000AE06
		public unsafe bool _spawnPrefabOnPreviewClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLibDbSettings.NativeFieldInfoPtr__spawnPrefabOnPreviewClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLibDbSettings.NativeFieldInfoPtr__spawnPrefabOnPreviewClick)) = value;
			}
		}

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeFieldInfoPtr__spawnPrefabOnPreviewClick;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnPrefabOnPreviewClick_Public_get_Boolean_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_set_SpawnPrefabOnPreviewClick_Public_set_Void_Boolean_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
