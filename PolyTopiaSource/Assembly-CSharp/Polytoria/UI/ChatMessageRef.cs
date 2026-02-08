using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace Polytoria.UI
{
	// Token: 0x02000250 RID: 592
	public class ChatMessageRef : Object
	{
		// Token: 0x06002DF7 RID: 11767 RVA: 0x000D594C File Offset: 0x000D3B4C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatMessageRef()
		{
			Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "ChatMessageRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr);
			ChatMessageRef.NativeFieldInfoPtr_txt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr, "txt");
			ChatMessageRef.NativeFieldInfoPtr_faded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr, "faded");
			ChatMessageRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr, 100670222);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x000D59B8 File Offset: 0x000D3BB8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatMessageRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x0001252A File Offset: 0x0001072A
		public ChatMessageRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000D59F4 File Offset: 0x000D3BF4
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00012533 File Offset: 0x00010733
		public unsafe TMP_Text txt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageRef.NativeFieldInfoPtr_txt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageRef.NativeFieldInfoPtr_txt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000D5A24 File Offset: 0x000D3C24
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00012552 File Offset: 0x00010752
		public unsafe bool faded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageRef.NativeFieldInfoPtr_faded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageRef.NativeFieldInfoPtr_faded)) = value;
			}
		}

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeFieldInfoPtr_txt;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeFieldInfoPtr_faded;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
