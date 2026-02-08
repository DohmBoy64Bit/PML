using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000283 RID: 643
	public class CreatorProperty : PropertyAttribute
	{
		// Token: 0x060033AA RID: 13226 RVA: 0x00014668 File Offset: 0x00012868
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorProperty()
		{
			Il2CppClassPointerStore<CreatorProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "CreatorProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorProperty>.NativeClassPtr);
			CreatorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorProperty>.NativeClassPtr, 100671099);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000EBEF8 File Offset: 0x000EA0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000146A1 File Offset: 0x000128A1
		public CreatorProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
