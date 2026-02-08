using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000312 RID: 786
	public class PurchasesServiceProxy : Object
	{
		// Token: 0x060043C6 RID: 17350 RVA: 0x001303E4 File Offset: 0x0012E5E4
		// Note: this type is marked as 'beforefieldinit'.
		static PurchasesServiceProxy()
		{
			Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "PurchasesServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr);
			PurchasesServiceProxy.NativeFieldInfoPtr_purchasesService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr, "purchasesService");
			PurchasesServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_PurchasesService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr, 100674033);
			PurchasesServiceProxy.NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr, 100674034);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00130450 File Offset: 0x0012E650
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchasesServiceProxy(PurchasesService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasesServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_PurchasesService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x0013049C File Offset: 0x0012E69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129382, XrefRangeEnd = 129384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prompt(Player player, int assetID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasesServiceProxy.NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00018F23 File Offset: 0x00017123
		public PurchasesServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x00130500 File Offset: 0x0012E700
		// (set) Token: 0x060043CB RID: 17355 RVA: 0x00018F2C File Offset: 0x0001712C
		public unsafe PurchasesService purchasesService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesServiceProxy.NativeFieldInfoPtr_purchasesService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasesService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasesServiceProxy.NativeFieldInfoPtr_purchasesService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeFieldInfoPtr_purchasesService;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PurchasesService_0;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeMethodInfoPtr_Prompt_Public_Void_Player_Int32_DynValue_0;
	}
}
