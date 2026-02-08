using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel;

namespace Polytoria.Controllers
{
	// Token: 0x02000333 RID: 819
	public sealed class MeshPartLoadRequest : ValueType
	{
		// Token: 0x06004634 RID: 17972 RVA: 0x00138EC4 File Offset: 0x001370C4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPartLoadRequest()
		{
			Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "MeshPartLoadRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr);
			MeshPartLoadRequest.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr, "assetID");
			MeshPartLoadRequest.NativeFieldInfoPtr_meshPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr, "meshPart");
			MeshPartLoadRequest.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr, "onComplete");
			MeshPartLoadRequest.NativeMethodInfoPtr__ctor_Public_Void_Int32_MeshPart_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr, 100674406);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00138F44 File Offset: 0x00137144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135867, RefRangeEnd = 135869, XrefRangeStart = 135865, XrefRangeEnd = 135867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshPartLoadRequest(int assetID, MeshPart meshPart, Action onLoadComplete = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshPart);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onLoadComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartLoadRequest.NativeMethodInfoPtr__ctor_Public_Void_Int32_MeshPart_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00019F89 File Offset: 0x00018189
		public MeshPartLoadRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00019F92 File Offset: 0x00018192
		public MeshPartLoadRequest()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartLoadRequest>.NativeClassPtr))
		{
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x00138FB4 File Offset: 0x001371B4
		// (set) Token: 0x06004639 RID: 17977 RVA: 0x00019FA4 File Offset: 0x000181A4
		public unsafe int assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_assetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_assetID)) = value;
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x00138FDC File Offset: 0x001371DC
		// (set) Token: 0x0600463B RID: 17979 RVA: 0x00019FBF File Offset: 0x000181BF
		public unsafe MeshPart meshPart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_meshPart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_meshPart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x0013900C File Offset: 0x0013720C
		// (set) Token: 0x0600463D RID: 17981 RVA: 0x00019FDE File Offset: 0x000181DE
		public unsafe Action onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartLoadRequest.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400367A RID: 13946
		private static readonly IntPtr NativeFieldInfoPtr_assetID;

		// Token: 0x0400367B RID: 13947
		private static readonly IntPtr NativeFieldInfoPtr_meshPart;

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_MeshPart_Action_0;
	}
}
