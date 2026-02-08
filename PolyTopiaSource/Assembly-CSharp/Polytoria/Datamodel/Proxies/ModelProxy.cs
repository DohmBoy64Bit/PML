using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E4 RID: 740
	public class ModelProxy : DynamicInstanceProxy
	{
		// Token: 0x060040CB RID: 16587 RVA: 0x00122E50 File Offset: 0x00121050
		// Note: this type is marked as 'beforefieldinit'.
		static ModelProxy()
		{
			Il2CppClassPointerStore<ModelProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ModelProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelProxy>.NativeClassPtr);
			ModelProxy.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelProxy>.NativeClassPtr, "model");
			ModelProxy.NativeMethodInfoPtr__ctor_Public_Void_Model_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelProxy>.NativeClassPtr, 100673455);
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00122EA8 File Offset: 0x001210A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModelProxy(Model target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelProxy.NativeMethodInfoPtr__ctor_Public_Void_Model_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x000187E1 File Offset: 0x000169E1
		public ModelProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x00122EF4 File Offset: 0x001210F4
		// (set) Token: 0x060040CF RID: 16591 RVA: 0x000187EA File Offset: 0x000169EA
		public unsafe Model model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelProxy.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Model>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelProxy.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Model_0;
	}
}
