using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000019 RID: 25
public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Token: 0x060004D5 RID: 1237 RVA: 0x0002632C File Offset: 0x0002452C
	// Note: this type is marked as 'beforefieldinit'.
	static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
		Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100664161);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100664160);
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00026384 File Offset: 0x00024584
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000263C0 File Offset: 0x000245C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18024, XrefRangeEnd = 18037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(intPtr);
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00003404 File Offset: 0x00001604
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400044C RID: 1100
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400044D RID: 1101
	private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;

	// Token: 0x02000171 RID: 369
	public sealed class MonoScriptData : ValueType
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x0007CCFC File Offset: 0x0007AEFC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoScriptData()
		{
			Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, "MonoScriptData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "FilePathsData");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TypesData");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalTypes");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalFiles");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "IsEditorOnly");
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00009DBB File Offset: 0x00007FBB
		public MonoScriptData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00009DC4 File Offset: 0x00007FC4
		public MonoScriptData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
		{
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0007CD8C File Offset: 0x0007AF8C
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00009DD6 File Offset: 0x00007FD6
		public unsafe Il2CppStructArray<byte> FilePathsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007CDBC File Offset: 0x0007AFBC
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00009DF5 File Offset: 0x00007FF5
		public unsafe Il2CppStructArray<byte> TypesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0007CDEC File Offset: 0x0007AFEC
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00009E14 File Offset: 0x00008014
		public unsafe int TotalTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0007CE14 File Offset: 0x0007B014
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00009E2F File Offset: 0x0000802F
		public unsafe int TotalFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0007CE3C File Offset: 0x0007B03C
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00009E4A File Offset: 0x0000804A
		public unsafe bool IsEditorOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
			}
		}

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_TypesData;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
	}
}
