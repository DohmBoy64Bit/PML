using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FD RID: 765
	public class TrussProxy : ClimbableProxy
	{
		// Token: 0x060042A9 RID: 17065 RVA: 0x0012B714 File Offset: 0x00129914
		// Note: this type is marked as 'beforefieldinit'.
		static TrussProxy()
		{
			Il2CppClassPointerStore<TrussProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "TrussProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrussProxy>.NativeClassPtr);
			TrussProxy.NativeFieldInfoPtr_truss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrussProxy>.NativeClassPtr, "truss");
			TrussProxy.NativeMethodInfoPtr__ctor_Public_Void_Truss_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrussProxy>.NativeClassPtr, 100673833);
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0012B76C File Offset: 0x0012996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129068, XrefRangeEnd = 129074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrussProxy(Truss target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrussProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrussProxy.NativeMethodInfoPtr__ctor_Public_Void_Truss_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x00018BC9 File Offset: 0x00016DC9
		public TrussProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0012B7B8 File Offset: 0x001299B8
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x00018BD2 File Offset: 0x00016DD2
		public unsafe Truss truss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrussProxy.NativeFieldInfoPtr_truss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Truss>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrussProxy.NativeFieldInfoPtr_truss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr_truss;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Truss_0;
	}
}
