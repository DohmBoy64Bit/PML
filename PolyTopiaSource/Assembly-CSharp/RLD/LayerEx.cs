using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000123 RID: 291
	public static class LayerEx : Object
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x0008B7E0 File Offset: 0x000899E0
		// Note: this type is marked as 'beforefieldinit'.
		static LayerEx()
		{
			Il2CppClassPointerStore<LayerEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "LayerEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerEx>.NativeClassPtr);
			LayerEx.NativeMethodInfoPtr_GetMinLayer_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667379);
			LayerEx.NativeMethodInfoPtr_GetMaxLayer_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667380);
			LayerEx.NativeMethodInfoPtr_IsLayerBitSet_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667381);
			LayerEx.NativeMethodInfoPtr_SetLayerBit_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667382);
			LayerEx.NativeMethodInfoPtr_ClearLayerBit_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667383);
			LayerEx.NativeMethodInfoPtr_IsLayerValid_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667384);
			LayerEx.NativeMethodInfoPtr_GetAllLayerNames_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerEx>.NativeClassPtr, 100667385);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0008B89C File Offset: 0x00089A9C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinLayer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_GetMinLayer_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0008B8CC File Offset: 0x00089ACC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 61574, RefRangeEnd = 61581, XrefRangeStart = 61574, XrefRangeEnd = 61581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxLayer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_GetMaxLayer_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0008B8FC File Offset: 0x00089AFC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 77116, RefRangeEnd = 77130, XrefRangeStart = 77116, XrefRangeEnd = 77116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLayerBitSet(int layerBits, int layerNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_IsLayerBitSet_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0008B948 File Offset: 0x00089B48
		[CallerCount(0)]
		public unsafe static int SetLayerBit(int layerBits, int layerNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_SetLayerBit_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0008B994 File Offset: 0x00089B94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77130, RefRangeEnd = 77134, XrefRangeStart = 77130, XrefRangeEnd = 77130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ClearLayerBit(int layerBits, int layerNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_ClearLayerBit_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0008B9E0 File Offset: 0x00089BE0
		[CallerCount(0)]
		public unsafe static bool IsLayerValid(int layerNumber)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_IsLayerValid_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0008BA20 File Offset: 0x00089C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77134, XrefRangeEnd = 77145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetAllLayerNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerEx.NativeMethodInfoPtr_GetAllLayerNames_Public_Static_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0000BD31 File Offset: 0x00009F31
		public LayerEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_GetMinLayer_Public_Static_Int32_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxLayer_Public_Static_Int32_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_IsLayerBitSet_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerBit_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_ClearLayerBit_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_IsLayerValid_Public_Static_Boolean_Int32_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLayerNames_Public_Static_List_1_String_0;
	}
}
