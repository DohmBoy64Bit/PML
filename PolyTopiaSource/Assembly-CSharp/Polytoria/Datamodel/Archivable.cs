using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000284 RID: 644
	public class Archivable : PropertyAttribute
	{
		// Token: 0x060033AD RID: 13229 RVA: 0x000146AA File Offset: 0x000128AA
		// Note: this type is marked as 'beforefieldinit'.
		static Archivable()
		{
			Il2CppClassPointerStore<Archivable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Archivable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archivable>.NativeClassPtr);
			Archivable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archivable>.NativeClassPtr, 100671100);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000EBF34 File Offset: 0x000EA134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archivable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archivable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archivable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000146E3 File Offset: 0x000128E3
		public Archivable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
