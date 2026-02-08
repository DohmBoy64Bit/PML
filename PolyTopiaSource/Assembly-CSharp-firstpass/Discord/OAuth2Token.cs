using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000141 RID: 321
	public sealed class OAuth2Token : ValueType
	{
		// Token: 0x060015FE RID: 5630 RVA: 0x00071F70 File Offset: 0x00070170
		// Note: this type is marked as 'beforefieldinit'.
		static OAuth2Token()
		{
			Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "OAuth2Token");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr);
			OAuth2Token.NativeFieldInfoPtr_AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr, "AccessToken");
			OAuth2Token.NativeFieldInfoPtr_Scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr, "Scopes");
			OAuth2Token.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr, "Expires");
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0000871E File Offset: 0x0000691E
		public OAuth2Token(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00008727 File Offset: 0x00006927
		public OAuth2Token()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OAuth2Token>.NativeClassPtr))
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00071FDC File Offset: 0x000701DC
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00008739 File Offset: 0x00006939
		public unsafe string AccessToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_AccessToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_AccessToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00072004 File Offset: 0x00070204
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00008758 File Offset: 0x00006958
		public unsafe string Scopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_Scopes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_Scopes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0007202C File Offset: 0x0007022C
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x00008777 File Offset: 0x00006977
		public unsafe long Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OAuth2Token.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_AccessToken;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_Scopes;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_Expires;
	}
}
