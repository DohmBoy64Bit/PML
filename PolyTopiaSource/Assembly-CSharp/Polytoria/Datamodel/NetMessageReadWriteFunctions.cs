using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000294 RID: 660
	public static class NetMessageReadWriteFunctions : Object
	{
		// Token: 0x06003496 RID: 13462 RVA: 0x000EFCC8 File Offset: 0x000EDEC8
		// Note: this type is marked as 'beforefieldinit'.
		static NetMessageReadWriteFunctions()
		{
			Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "NetMessageReadWriteFunctions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr);
			NetMessageReadWriteFunctions.NativeMethodInfoPtr_WriteDictionary_Private_Static_Void_NetworkWriter_Dictionary_2_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr, 100671248);
			NetMessageReadWriteFunctions.NativeMethodInfoPtr_ReadDictionary_Public_Static_Dictionary_2_String_T_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr, 100671249);
			NetMessageReadWriteFunctions.NativeMethodInfoPtr_WriteNetMessage_Public_Static_Void_NetworkWriter_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr, 100671250);
			NetMessageReadWriteFunctions.NativeMethodInfoPtr_ReadNetMessage_Public_Static_NetMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr, 100671251);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x000EFD48 File Offset: 0x000EDF48
		[CallerCount(0)]
		public unsafe static void WriteDictionary<T>(this NetworkWriter writer, Dictionary<string, T> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessageReadWriteFunctions.MethodInfoStoreGeneric_WriteDictionary_Private_Static_Void_NetworkWriter_Dictionary_2_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000EFD90 File Offset: 0x000EDF90
		[CallerCount(0)]
		public unsafe static Dictionary<string, T> ReadDictionary<T>(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessageReadWriteFunctions.MethodInfoStoreGeneric_ReadDictionary_Public_Static_Dictionary_2_String_T_NetworkReader_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x000EFDD4 File Offset: 0x000EDFD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 107263, RefRangeEnd = 107269, XrefRangeStart = 107238, XrefRangeEnd = 107263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteNetMessage(this NetworkWriter writer, NetMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessageReadWriteFunctions.NativeMethodInfoPtr_WriteNetMessage_Public_Static_Void_NetworkWriter_NetMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000EFE1C File Offset: 0x000EE01C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107305, RefRangeEnd = 107308, XrefRangeStart = 107269, XrefRangeEnd = 107305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetMessage ReadNetMessage(this NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessageReadWriteFunctions.NativeMethodInfoPtr_ReadNetMessage_Public_Static_NetMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00014B3E File Offset: 0x00012D3E
		public NetMessageReadWriteFunctions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_WriteDictionary_Private_Static_Void_NetworkWriter_Dictionary_2_String_T_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_ReadDictionary_Public_Static_Dictionary_2_String_T_NetworkReader_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_WriteNetMessage_Public_Static_Void_NetworkWriter_NetMessage_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_ReadNetMessage_Public_Static_NetMessage_NetworkReader_0;

		// Token: 0x020003F6 RID: 1014
		private sealed class MethodInfoStoreGeneric_WriteDictionary_Private_Static_Void_NetworkWriter_Dictionary_2_String_T_0<T>
		{
			// Token: 0x04003C88 RID: 15496
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NetMessageReadWriteFunctions.NativeMethodInfoPtr_WriteDictionary_Private_Static_Void_NetworkWriter_Dictionary_2_String_T_0, Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003F7 RID: 1015
		private sealed class MethodInfoStoreGeneric_ReadDictionary_Public_Static_Dictionary_2_String_T_NetworkReader_0<T>
		{
			// Token: 0x04003C89 RID: 15497
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NetMessageReadWriteFunctions.NativeMethodInfoPtr_ReadDictionary_Public_Static_Dictionary_2_String_T_NetworkReader_0, Il2CppClassPointerStore<NetMessageReadWriteFunctions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
