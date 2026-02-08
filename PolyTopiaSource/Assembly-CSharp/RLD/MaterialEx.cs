using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000124 RID: 292
	public static class MaterialEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B5C RID: 7004 RVA: 0x0008BA54 File Offset: 0x00089C54
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialEx()
		{
			Il2CppClassPointerStore<MaterialEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MaterialEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr);
			MaterialEx.NativeMethodInfoPtr_SetZWriteEnabled_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667386);
			MaterialEx.NativeMethodInfoPtr_SetZTestEnabled_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667387);
			MaterialEx.NativeMethodInfoPtr_SetZTestAlways_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667388);
			MaterialEx.NativeMethodInfoPtr_SetZTestLess_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667389);
			MaterialEx.NativeMethodInfoPtr_SetCullModeBack_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667390);
			MaterialEx.NativeMethodInfoPtr_SetCullModeFront_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667391);
			MaterialEx.NativeMethodInfoPtr_SetCullModeOff_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667392);
			MaterialEx.NativeMethodInfoPtr_SetColor_Public_Static_Void_Material_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667393);
			MaterialEx.NativeMethodInfoPtr_SetStencilCmpAlways_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667394);
			MaterialEx.NativeMethodInfoPtr_SetStencilCmpNotEqual_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEx>.NativeClassPtr, 100667395);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0008BB4C File Offset: 0x00089D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77149, RefRangeEnd = 77150, XrefRangeStart = 77145, XrefRangeEnd = 77149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZWriteEnabled(this Material material, bool enabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetZWriteEnabled_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0008BB90 File Offset: 0x00089D90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77154, RefRangeEnd = 77157, XrefRangeStart = 77150, XrefRangeEnd = 77154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTestEnabled(this Material material, bool enabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetZTestEnabled_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0008BBD4 File Offset: 0x00089DD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77161, RefRangeEnd = 77165, XrefRangeStart = 77157, XrefRangeEnd = 77161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTestAlways(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetZTestAlways_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0008BC0C File Offset: 0x00089E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77169, RefRangeEnd = 77170, XrefRangeStart = 77165, XrefRangeEnd = 77169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTestLess(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetZTestLess_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0008BC44 File Offset: 0x00089E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77170, XrefRangeEnd = 77174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCullModeBack(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetCullModeBack_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0008BC7C File Offset: 0x00089E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77174, XrefRangeEnd = 77178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCullModeFront(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetCullModeFront_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0008BCB4 File Offset: 0x00089EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77182, RefRangeEnd = 77184, XrefRangeStart = 77178, XrefRangeEnd = 77182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCullModeOff(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetCullModeOff_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0008BCEC File Offset: 0x00089EEC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 77187, RefRangeEnd = 77202, XrefRangeStart = 77184, XrefRangeEnd = 77187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetColor(this Material material, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetColor_Public_Static_Void_Material_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0008BD34 File Offset: 0x00089F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77202, XrefRangeEnd = 77206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilCmpAlways(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetStencilCmpAlways_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0008BD6C File Offset: 0x00089F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77206, XrefRangeEnd = 77210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilCmpNotEqual(this Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEx.NativeMethodInfoPtr_SetStencilCmpNotEqual_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0000BD3A File Offset: 0x00009F3A
		public MaterialEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_SetZWriteEnabled_Public_Static_Void_Material_Boolean_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestEnabled_Public_Static_Void_Material_Boolean_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestAlways_Public_Static_Void_Material_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_SetZTestLess_Public_Static_Void_Material_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeBack_Public_Static_Void_Material_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeFront_Public_Static_Void_Material_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_SetCullModeOff_Public_Static_Void_Material_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Material_Color_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilCmpAlways_Public_Static_Void_Material_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilCmpNotEqual_Public_Static_Void_Material_0;
	}
}
