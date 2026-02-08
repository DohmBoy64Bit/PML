using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D5 RID: 725
	public class DecalProxy : DynamicInstanceProxy
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x0011E904 File Offset: 0x0011CB04
		// Note: this type is marked as 'beforefieldinit'.
		static DecalProxy()
		{
			Il2CppClassPointerStore<DecalProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "DecalProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr);
			DecalProxy.NativeFieldInfoPtr_decal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, "decal");
			DecalProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673276);
			DecalProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673277);
			DecalProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673278);
			DecalProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673279);
			DecalProxy.NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673280);
			DecalProxy.NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673281);
			DecalProxy.NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673282);
			DecalProxy.NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673283);
			DecalProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673284);
			DecalProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673285);
			DecalProxy.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673286);
			DecalProxy.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673287);
			DecalProxy.NativeMethodInfoPtr__ctor_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr, 100673275);
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0011EA4C File Offset: 0x0011CC4C
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x0011EA84 File Offset: 0x0011CC84
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128493, XrefRangeEnd = 128495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x0011EAC8 File Offset: 0x0011CCC8
		// (set) Token: 0x06003FDF RID: 16351 RVA: 0x0011EB08 File Offset: 0x0011CD08
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128495, XrefRangeEnd = 128497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06003FE0 RID: 16352 RVA: 0x0011EB4C File Offset: 0x0011CD4C
		// (set) Token: 0x06003FE1 RID: 16353 RVA: 0x0011EB8C File Offset: 0x0011CD8C
		public unsafe Vector2 TextureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128497, XrefRangeEnd = 128499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06003FE2 RID: 16354 RVA: 0x0011EBD0 File Offset: 0x0011CDD0
		// (set) Token: 0x06003FE3 RID: 16355 RVA: 0x0011EC10 File Offset: 0x0011CE10
		public unsafe Vector2 TextureOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128499, XrefRangeEnd = 128501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x0011EC54 File Offset: 0x0011CE54
		// (set) Token: 0x06003FE5 RID: 16357 RVA: 0x0011EC94 File Offset: 0x0011CE94
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128501, XrefRangeEnd = 128502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x0011ECD8 File Offset: 0x0011CED8
		// (set) Token: 0x06003FE7 RID: 16359 RVA: 0x0011ED14 File Offset: 0x0011CF14
		public unsafe bool CastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128502, XrefRangeEnd = 128504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0011ED54 File Offset: 0x0011CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalProxy(Decal target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProxy.NativeMethodInfoPtr__ctor_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00018589 File Offset: 0x00016789
		public DecalProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06003FEA RID: 16362 RVA: 0x0011EDA0 File Offset: 0x0011CFA0
		// (set) Token: 0x06003FEB RID: 16363 RVA: 0x00018592 File Offset: 0x00016792
		public unsafe Decal decal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProxy.NativeFieldInfoPtr_decal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProxy.NativeFieldInfoPtr_decal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeFieldInfoPtr_decal;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decal_0;
	}
}
