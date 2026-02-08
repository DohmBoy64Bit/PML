using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Polytoria.Helpers
{
	// Token: 0x0200026B RID: 619
	public class CloseOnClickOutside : MonoBehaviour
	{
		// Token: 0x06002F9D RID: 12189 RVA: 0x000DBB5C File Offset: 0x000D9D5C
		// Note: this type is marked as 'beforefieldinit'.
		static CloseOnClickOutside()
		{
			Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Helpers", "CloseOnClickOutside");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr);
			CloseOnClickOutside.NativeFieldInfoPtr_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr, "close");
			CloseOnClickOutside.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr, 100670466);
			CloseOnClickOutside.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr, 100670464);
			CloseOnClickOutside.NativeMethodInfoPtr_ClickingSelfOrChild_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr, 100670465);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x000DBBDC File Offset: 0x000D9DDC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CloseOnClickOutside()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloseOnClickOutside>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloseOnClickOutside.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x000DBC18 File Offset: 0x000D9E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100229, XrefRangeEnd = 100248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloseOnClickOutside.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000DBC4C File Offset: 0x000D9E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100248, XrefRangeEnd = 100261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ClickingSelfOrChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloseOnClickOutside.NativeMethodInfoPtr_ClickingSelfOrChild_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00012FB4 File Offset: 0x000111B4
		public CloseOnClickOutside(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000DBC88 File Offset: 0x000D9E88
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00012FBD File Offset: 0x000111BD
		public unsafe bool close
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloseOnClickOutside.NativeFieldInfoPtr_close);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloseOnClickOutside.NativeFieldInfoPtr_close)) = value;
			}
		}

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_close;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeMethodInfoPtr_ClickingSelfOrChild_Private_Boolean_0;
	}
}
