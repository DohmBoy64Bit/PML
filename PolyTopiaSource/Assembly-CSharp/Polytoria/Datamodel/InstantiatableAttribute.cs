using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel
{
	// Token: 0x02000285 RID: 645
	public class InstantiatableAttribute : Attribute
	{
		// Token: 0x060033B0 RID: 13232 RVA: 0x000146EC File Offset: 0x000128EC
		// Note: this type is marked as 'beforefieldinit'.
		static InstantiatableAttribute()
		{
			Il2CppClassPointerStore<InstantiatableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "InstantiatableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiatableAttribute>.NativeClassPtr);
			InstantiatableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatableAttribute>.NativeClassPtr, 100671101);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000EBF70 File Offset: 0x000EA170
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20605, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstantiatableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiatableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00014725 File Offset: 0x00012925
		public InstantiatableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
