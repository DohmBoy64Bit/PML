using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000340 RID: 832
	public class CreatorStart : MonoBehaviour
	{
		// Token: 0x0600485A RID: 18522 RVA: 0x0014062C File Offset: 0x0013E82C
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorStart()
		{
			Il2CppClassPointerStore<CreatorStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "CreatorStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorStart>.NativeClassPtr);
			CreatorStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorStart>.NativeClassPtr, 100674863);
			CreatorStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorStart>.NativeClassPtr, 100674862);
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00140684 File Offset: 0x0013E884
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorStart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x001406C0 File Offset: 0x0013E8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143298, XrefRangeEnd = 143315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x0001AEA9 File Offset: 0x000190A9
		public CreatorStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
	}
}
