using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000338 RID: 824
	public class ScriptingAPIDumper : MonoBehaviour
	{
		// Token: 0x0600468E RID: 18062 RVA: 0x0013A0A8 File Offset: 0x001382A8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingAPIDumper()
		{
			Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ScriptingAPIDumper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr);
			ScriptingAPIDumper.NativeFieldInfoPtr_basePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr, "basePath");
			ScriptingAPIDumper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr, 100674470);
			ScriptingAPIDumper.NativeMethodInfoPtr_DumpAPI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr, 100674469);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x0013A114 File Offset: 0x00138314
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptingAPIDumper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingAPIDumper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x0013A150 File Offset: 0x00138350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136949, RefRangeEnd = 136950, XrefRangeStart = 136701, XrefRangeEnd = 136949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DumpAPI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingAPIDumper.NativeMethodInfoPtr_DumpAPI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x0001A225 File Offset: 0x00018425
		public ScriptingAPIDumper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x0013A178 File Offset: 0x00138378
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x0001A22E File Offset: 0x0001842E
		public unsafe static string basePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptingAPIDumper.NativeFieldInfoPtr_basePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptingAPIDumper.NativeFieldInfoPtr_basePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeFieldInfoPtr_basePath;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeMethodInfoPtr_DumpAPI_Public_Static_Void_0;

		// Token: 0x02000437 RID: 1079
		[ObfuscatedName("Polytoria.Controllers.ScriptingAPIDumper+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060052A8 RID: 21160 RVA: 0x0015F974 File Offset: 0x0015DB74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingAPIDumper>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr);
				ScriptingAPIDumper.__c__DisplayClass1_0.NativeFieldInfoPtr_namespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr, "namespaceName");
				ScriptingAPIDumper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr, 100674472);
				ScriptingAPIDumper.__c__DisplayClass1_0.NativeMethodInfoPtr__DumpAPI_b__0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr, 100674473);
			}

			// Token: 0x060052A9 RID: 21161 RVA: 0x0015F9DC File Offset: 0x0015DBDC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingAPIDumper.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingAPIDumper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052AA RID: 21162 RVA: 0x0015FA18 File Offset: 0x0015DC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136699, XrefRangeEnd = 136701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DumpAPI_b__0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingAPIDumper.__c__DisplayClass1_0.NativeMethodInfoPtr__DumpAPI_b__0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052AB RID: 21163 RVA: 0x00020014 File Offset: 0x0001E214
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE7 RID: 7143
			// (get) Token: 0x060052AC RID: 21164 RVA: 0x0015FA68 File Offset: 0x0015DC68
			// (set) Token: 0x060052AD RID: 21165 RVA: 0x0002001D File Offset: 0x0001E21D
			public unsafe string namespaceName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingAPIDumper.__c__DisplayClass1_0.NativeFieldInfoPtr_namespaceName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingAPIDumper.__c__DisplayClass1_0.NativeFieldInfoPtr_namespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003F40 RID: 16192
			private static readonly IntPtr NativeFieldInfoPtr_namespaceName;

			// Token: 0x04003F41 RID: 16193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F42 RID: 16194
			private static readonly IntPtr NativeMethodInfoPtr__DumpAPI_b__0_Internal_Boolean_Type_0;
		}
	}
}
