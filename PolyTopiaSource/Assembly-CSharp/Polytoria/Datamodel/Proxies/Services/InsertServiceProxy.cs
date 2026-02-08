using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000311 RID: 785
	public class InsertServiceProxy : Object
	{
		// Token: 0x060043C0 RID: 17344 RVA: 0x001302AC File Offset: 0x0012E4AC
		// Note: this type is marked as 'beforefieldinit'.
		static InsertServiceProxy()
		{
			Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "InsertServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr);
			InsertServiceProxy.NativeFieldInfoPtr_insertService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr, "insertService");
			InsertServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_InsertService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr, 100674031);
			InsertServiceProxy.NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr, 100674032);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00130318 File Offset: 0x0012E518
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InsertServiceProxy(InsertService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsertServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_InsertService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00130364 File Offset: 0x0012E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129380, XrefRangeEnd = 129382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Model(int id, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertServiceProxy.NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00018EFB File Offset: 0x000170FB
		public InsertServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x001303B4 File Offset: 0x0012E5B4
		// (set) Token: 0x060043C5 RID: 17349 RVA: 0x00018F04 File Offset: 0x00017104
		public unsafe InsertService insertService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertServiceProxy.NativeFieldInfoPtr_insertService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InsertService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertServiceProxy.NativeFieldInfoPtr_insertService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeFieldInfoPtr_insertService;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InsertService_0;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0;
	}
}
