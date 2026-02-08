using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Discord
{
	// Token: 0x02000162 RID: 354
	public class StorageManager : Object
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x00079454 File Offset: 0x00077654
		// Note: this type is marked as 'beforefieldinit'.
		static StorageManager()
		{
			Il2CppClassPointerStore<StorageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "StorageManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageManager>.NativeClassPtr);
			StorageManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "MethodsPtr");
			StorageManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "MethodsStructure");
			StorageManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668237);
			StorageManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668238);
			StorageManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668239);
			StorageManager.NativeMethodInfoPtr_Read_Public_UInt32_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668240);
			StorageManager.NativeMethodInfoPtr_ReadAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668241);
			StorageManager.NativeMethodInfoPtr_ReadAsync_Public_Void_String_ReadAsyncHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668242);
			StorageManager.NativeMethodInfoPtr_ReadAsyncPartialCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668243);
			StorageManager.NativeMethodInfoPtr_ReadAsyncPartial_Public_Void_String_UInt64_UInt64_ReadAsyncPartialHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668244);
			StorageManager.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668245);
			StorageManager.NativeMethodInfoPtr_WriteAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668246);
			StorageManager.NativeMethodInfoPtr_WriteAsync_Public_Void_String_Il2CppStructArray_1_Byte_WriteAsyncHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668247);
			StorageManager.NativeMethodInfoPtr_Delete_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668248);
			StorageManager.NativeMethodInfoPtr_Exists_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668249);
			StorageManager.NativeMethodInfoPtr_Count_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668250);
			StorageManager.NativeMethodInfoPtr_Stat_Public_FileStat_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668251);
			StorageManager.NativeMethodInfoPtr_StatAt_Public_FileStat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668252);
			StorageManager.NativeMethodInfoPtr_GetPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668253);
			StorageManager.NativeMethodInfoPtr_Files_Public_IEnumerable_1_FileStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, 100668254);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00079614 File Offset: 0x00077814
		public unsafe StorageManager.FFIMethods Methods
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 54892, RefRangeEnd = 54905, XrefRangeStart = 54879, XrefRangeEnd = 54892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StorageManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0007964C File Offset: 0x0007784C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54912, RefRangeEnd = 54913, XrefRangeStart = 54905, XrefRangeEnd = 54912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageManager(IntPtr ptr, IntPtr eventsPtr, ref StorageManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &events;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000796B0 File Offset: 0x000778B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54913, XrefRangeEnd = 54919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref StorageManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &events;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000796FC File Offset: 0x000778FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54919, XrefRangeEnd = 54920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint Read(string name, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Read_Public_UInt32_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0007975C File Offset: 0x0007795C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54920, XrefRangeEnd = 54934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_ReadAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000797BC File Offset: 0x000779BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54934, XrefRangeEnd = 54945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAsync(string name, StorageManager.ReadAsyncHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_ReadAsync_Public_Void_String_ReadAsyncHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00079810 File Offset: 0x00077A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54945, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_ReadAsyncPartialCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00079870 File Offset: 0x00077A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54959, XrefRangeEnd = 54970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAsyncPartial(string name, ulong offset, ulong length, StorageManager.ReadAsyncPartialHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_ReadAsyncPartial_Public_Void_String_UInt64_UInt64_ReadAsyncPartialHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000798E4 File Offset: 0x00077AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54970, XrefRangeEnd = 54971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string name, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00079938 File Offset: 0x00077B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54971, XrefRangeEnd = 54978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_WriteAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0007997C File Offset: 0x00077B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54978, XrefRangeEnd = 54989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAsync(string name, Il2CppStructArray<byte> data, StorageManager.WriteAsyncHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_WriteAsync_Public_Void_String_Il2CppStructArray_1_Byte_WriteAsyncHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000799E4 File Offset: 0x00077BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54989, XrefRangeEnd = 54990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Delete_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00079A28 File Offset: 0x00077C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54990, XrefRangeEnd = 54991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exists(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Exists_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00079A78 File Offset: 0x00077C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54991, XrefRangeEnd = 54992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Count_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00079AB4 File Offset: 0x00077CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54992, XrefRangeEnd = 54993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStat Stat(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Stat_Public_FileStat_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStat>(intPtr3) : null;
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00079B04 File Offset: 0x00077D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54993, XrefRangeEnd = 54994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStat StatAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_StatAt_Public_FileStat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStat>(intPtr3) : null;
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00079B50 File Offset: 0x00077D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54994, XrefRangeEnd = 55005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_GetPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00079B88 File Offset: 0x00077D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55005, XrefRangeEnd = 55018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<FileStat> Files()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.NativeMethodInfoPtr_Files_Public_IEnumerable_1_FileStat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileStat>>(intPtr3) : null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00009900 File Offset: 0x00007B00
		public StorageManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00079BC8 File Offset: 0x00077DC8
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x00009909 File Offset: 0x00007B09
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00079BF0 File Offset: 0x00077DF0
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x00009924 File Offset: 0x00007B24
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_UInt32_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Void_String_ReadAsyncHandler_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncPartialCallbackImpl_Private_Static_Void_IntPtr_Result_IntPtr_Int32_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncPartial_Public_Void_String_UInt64_UInt64_ReadAsyncPartialHandler_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Void_String_Il2CppStructArray_1_Byte_WriteAsyncHandler_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_String_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_String_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Int32_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_Stat_Public_FileStat_String_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_StatAt_Public_FileStat_Int32_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_String_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_Files_Public_IEnumerable_1_FileStat_0;

		// Token: 0x02000237 RID: 567
		[StructLayout(2)]
		public struct FFIEvents
		{
			// Token: 0x060020A2 RID: 8354 RVA: 0x0000D754 File Offset: 0x0000B954
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<StorageManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageManager.FFIEvents>.NativeClassPtr);
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x0000D774 File Offset: 0x0000B974
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StorageManager.FFIEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000238 RID: 568
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x060020A4 RID: 8356 RVA: 0x00095F98 File Offset: 0x00094198
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr);
				StorageManager.FFIMethods.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Read");
				StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsync");
				StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsyncPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsyncPartial");
				StorageManager.FFIMethods.NativeFieldInfoPtr_Write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Write");
				StorageManager.FFIMethods.NativeFieldInfoPtr_WriteAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "WriteAsync");
				StorageManager.FFIMethods.NativeFieldInfoPtr_Delete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Delete");
				StorageManager.FFIMethods.NativeFieldInfoPtr_Exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Exists");
				StorageManager.FFIMethods.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Count");
				StorageManager.FFIMethods.NativeFieldInfoPtr_Stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "Stat");
				StorageManager.FFIMethods.NativeFieldInfoPtr_StatAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "StatAt");
				StorageManager.FFIMethods.NativeFieldInfoPtr_GetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "GetPath");
			}

			// Token: 0x060020A5 RID: 8357 RVA: 0x0000D786 File Offset: 0x0000B986
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020A6 RID: 8358 RVA: 0x0000D78F File Offset: 0x0000B98F
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000960A0 File Offset: 0x000942A0
			// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000D7A1 File Offset: 0x0000B9A1
			public unsafe StorageManager.FFIMethods.ReadMethod Read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.ReadMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x060020A9 RID: 8361 RVA: 0x000960D0 File Offset: 0x000942D0
			// (set) Token: 0x060020AA RID: 8362 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
			public unsafe StorageManager.FFIMethods.ReadAsyncMethod ReadAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsync);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.ReadAsyncMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsync), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x060020AB RID: 8363 RVA: 0x00096100 File Offset: 0x00094300
			// (set) Token: 0x060020AC RID: 8364 RVA: 0x0000D7DF File Offset: 0x0000B9DF
			public unsafe StorageManager.FFIMethods.ReadAsyncPartialMethod ReadAsyncPartial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsyncPartial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.ReadAsyncPartialMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_ReadAsyncPartial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x060020AD RID: 8365 RVA: 0x00096130 File Offset: 0x00094330
			// (set) Token: 0x060020AE RID: 8366 RVA: 0x0000D7FE File Offset: 0x0000B9FE
			public unsafe StorageManager.FFIMethods.WriteMethod Write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.WriteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x060020AF RID: 8367 RVA: 0x00096160 File Offset: 0x00094360
			// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0000D81D File Offset: 0x0000BA1D
			public unsafe StorageManager.FFIMethods.WriteAsyncMethod WriteAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_WriteAsync);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.WriteAsyncMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_WriteAsync), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00096190 File Offset: 0x00094390
			// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0000D83C File Offset: 0x0000BA3C
			public unsafe StorageManager.FFIMethods.DeleteMethod Delete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Delete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.DeleteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Delete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000961C0 File Offset: 0x000943C0
			// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0000D85B File Offset: 0x0000BA5B
			public unsafe StorageManager.FFIMethods.ExistsMethod Exists
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Exists);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.ExistsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Exists), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000961F0 File Offset: 0x000943F0
			// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0000D87A File Offset: 0x0000BA7A
			public unsafe StorageManager.FFIMethods.CountMethod Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Count);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.CountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Count), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x060020B7 RID: 8375 RVA: 0x00096220 File Offset: 0x00094420
			// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0000D899 File Offset: 0x0000BA99
			public unsafe StorageManager.FFIMethods.StatMethod Stat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Stat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.StatMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_Stat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x060020B9 RID: 8377 RVA: 0x00096250 File Offset: 0x00094450
			// (set) Token: 0x060020BA RID: 8378 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
			public unsafe StorageManager.FFIMethods.StatAtMethod StatAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_StatAt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.StatAtMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_StatAt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x060020BB RID: 8379 RVA: 0x00096280 File Offset: 0x00094480
			// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
			public unsafe StorageManager.FFIMethods.GetPathMethod GetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_GetPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager.FFIMethods.GetPathMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageManager.FFIMethods.NativeFieldInfoPtr_GetPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001926 RID: 6438
			private static readonly IntPtr NativeFieldInfoPtr_Read;

			// Token: 0x04001927 RID: 6439
			private static readonly IntPtr NativeFieldInfoPtr_ReadAsync;

			// Token: 0x04001928 RID: 6440
			private static readonly IntPtr NativeFieldInfoPtr_ReadAsyncPartial;

			// Token: 0x04001929 RID: 6441
			private static readonly IntPtr NativeFieldInfoPtr_Write;

			// Token: 0x0400192A RID: 6442
			private static readonly IntPtr NativeFieldInfoPtr_WriteAsync;

			// Token: 0x0400192B RID: 6443
			private static readonly IntPtr NativeFieldInfoPtr_Delete;

			// Token: 0x0400192C RID: 6444
			private static readonly IntPtr NativeFieldInfoPtr_Exists;

			// Token: 0x0400192D RID: 6445
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x0400192E RID: 6446
			private static readonly IntPtr NativeFieldInfoPtr_Stat;

			// Token: 0x0400192F RID: 6447
			private static readonly IntPtr NativeFieldInfoPtr_StatAt;

			// Token: 0x04001930 RID: 6448
			private static readonly IntPtr NativeFieldInfoPtr_GetPath;

			// Token: 0x020002EE RID: 750
			public sealed class ReadMethod : MulticastDelegate
			{
				// Token: 0x0600269E RID: 9886 RVA: 0x000ACBC0 File Offset: 0x000AADC0
				// Note: this type is marked as 'beforefieldinit'.
				static ReadMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadMethod");
					StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr, 100668255);
					StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr, 100668256);
					StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr, 100668257);
					StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UInt32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr, 100668258);
				}

				// Token: 0x0600269F RID: 9887 RVA: 0x000ACC34 File Offset: 0x000AAE34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ReadMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026A0 RID: 9888 RVA: 0x000ACC90 File Offset: 0x000AAE90
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen, ref uint read)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &read;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026A1 RID: 9889 RVA: 0x000ACD20 File Offset: 0x000AAF20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54788, XrefRangeEnd = 54795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen, ref uint read, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &read;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026A2 RID: 9890 RVA: 0x000ACDD4 File Offset: 0x000AAFD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref uint read, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &read;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UInt32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026A3 RID: 9891 RVA: 0x0000F854 File Offset: 0x0000DA54
				public ReadMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001BFD RID: 7165
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BFE RID: 7166
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

				// Token: 0x04001BFF RID: 7167
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_byref_UInt32_AsyncCallback_Object_0;

				// Token: 0x04001C00 RID: 7168
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UInt32_IAsyncResult_0;
			}

			// Token: 0x020002EF RID: 751
			public sealed class ReadAsyncCallback : MulticastDelegate
			{
				// Token: 0x060026A4 RID: 9892 RVA: 0x000ACE34 File Offset: 0x000AB034
				// Note: this type is marked as 'beforefieldinit'.
				static ReadAsyncCallback()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsyncCallback");
					StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr, 100668259);
					StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr, 100668260);
					StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr, 100668261);
					StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr, 100668262);
				}

				// Token: 0x060026A5 RID: 9893 RVA: 0x000ACEA8 File Offset: 0x000AB0A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54795, XrefRangeEnd = 54798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ReadAsyncCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026A6 RID: 9894 RVA: 0x000ACF04 File Offset: 0x000AB104
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026A7 RID: 9895 RVA: 0x000ACF70 File Offset: 0x000AB170
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54798, XrefRangeEnd = 54808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026A8 RID: 9896 RVA: 0x000AD010 File Offset: 0x000AB210
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026A9 RID: 9897 RVA: 0x0000F85D File Offset: 0x0000DA5D
				public ReadAsyncCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026AA RID: 9898 RVA: 0x0000F866 File Offset: 0x0000DA66
				public static implicit operator StorageManager.FFIMethods.ReadAsyncCallback(Action<IntPtr, Result, IntPtr, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.ReadAsyncCallback>(A_0);
				}

				// Token: 0x060026AB RID: 9899 RVA: 0x0000F86E File Offset: 0x0000DA6E
				public static StorageManager.FFIMethods.ReadAsyncCallback operator +(StorageManager.FFIMethods.ReadAsyncCallback A_0, StorageManager.FFIMethods.ReadAsyncCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.ReadAsyncCallback>();
				}

				// Token: 0x060026AC RID: 9900 RVA: 0x0000F87C File Offset: 0x0000DA7C
				public static StorageManager.FFIMethods.ReadAsyncCallback operator -(StorageManager.FFIMethods.ReadAsyncCallback A_0, StorageManager.FFIMethods.ReadAsyncCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.ReadAsyncCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C01 RID: 7169
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C02 RID: 7170
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0;

				// Token: 0x04001C03 RID: 7171
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C04 RID: 7172
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F0 RID: 752
			public sealed class ReadAsyncMethod : MulticastDelegate
			{
				// Token: 0x060026AD RID: 9901 RVA: 0x000AD054 File Offset: 0x000AB254
				// Note: this type is marked as 'beforefieldinit'.
				static ReadAsyncMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsyncMethod");
					StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr, 100668263);
					StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ReadAsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr, 100668264);
					StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ReadAsyncCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr, 100668265);
					StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr, 100668266);
				}

				// Token: 0x060026AE RID: 9902 RVA: 0x000AD0C8 File Offset: 0x000AB2C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ReadAsyncMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026AF RID: 9903 RVA: 0x000AD124 File Offset: 0x000AB324
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ReadAsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026B0 RID: 9904 RVA: 0x000AD198 File Offset: 0x000AB398
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ReadAsyncCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026B1 RID: 9905 RVA: 0x000AD240 File Offset: 0x000AB440
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026B2 RID: 9906 RVA: 0x0000F88D File Offset: 0x0000DA8D
				public ReadAsyncMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026B3 RID: 9907 RVA: 0x0000F896 File Offset: 0x0000DA96
				public static implicit operator StorageManager.FFIMethods.ReadAsyncMethod(Action<IntPtr, string, IntPtr, StorageManager.FFIMethods.ReadAsyncCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.ReadAsyncMethod>(A_0);
				}

				// Token: 0x060026B4 RID: 9908 RVA: 0x0000F89E File Offset: 0x0000DA9E
				public static StorageManager.FFIMethods.ReadAsyncMethod operator +(StorageManager.FFIMethods.ReadAsyncMethod A_0, StorageManager.FFIMethods.ReadAsyncMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.ReadAsyncMethod>();
				}

				// Token: 0x060026B5 RID: 9909 RVA: 0x0000F8AC File Offset: 0x0000DAAC
				public static StorageManager.FFIMethods.ReadAsyncMethod operator -(StorageManager.FFIMethods.ReadAsyncMethod A_0, StorageManager.FFIMethods.ReadAsyncMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.ReadAsyncMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C05 RID: 7173
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C06 RID: 7174
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ReadAsyncCallback_0;

				// Token: 0x04001C07 RID: 7175
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ReadAsyncCallback_AsyncCallback_Object_0;

				// Token: 0x04001C08 RID: 7176
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F1 RID: 753
			public sealed class ReadAsyncPartialCallback : MulticastDelegate
			{
				// Token: 0x060026B6 RID: 9910 RVA: 0x000AD284 File Offset: 0x000AB484
				// Note: this type is marked as 'beforefieldinit'.
				static ReadAsyncPartialCallback()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsyncPartialCallback");
					StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr, 100668267);
					StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr, 100668268);
					StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr, 100668269);
					StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr, 100668270);
				}

				// Token: 0x060026B7 RID: 9911 RVA: 0x000AD2F8 File Offset: 0x000AB4F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ReadAsyncPartialCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026B8 RID: 9912 RVA: 0x000AD354 File Offset: 0x000AB554
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026B9 RID: 9913 RVA: 0x000AD3C0 File Offset: 0x000AB5C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54808, XrefRangeEnd = 54818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026BA RID: 9914 RVA: 0x000AD460 File Offset: 0x000AB660
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026BB RID: 9915 RVA: 0x0000F8BD File Offset: 0x0000DABD
				public ReadAsyncPartialCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026BC RID: 9916 RVA: 0x0000F8C6 File Offset: 0x0000DAC6
				public static implicit operator StorageManager.FFIMethods.ReadAsyncPartialCallback(Action<IntPtr, Result, IntPtr, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.ReadAsyncPartialCallback>(A_0);
				}

				// Token: 0x060026BD RID: 9917 RVA: 0x0000F8CE File Offset: 0x0000DACE
				public static StorageManager.FFIMethods.ReadAsyncPartialCallback operator +(StorageManager.FFIMethods.ReadAsyncPartialCallback A_0, StorageManager.FFIMethods.ReadAsyncPartialCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.ReadAsyncPartialCallback>();
				}

				// Token: 0x060026BE RID: 9918 RVA: 0x0000F8DC File Offset: 0x0000DADC
				public static StorageManager.FFIMethods.ReadAsyncPartialCallback operator -(StorageManager.FFIMethods.ReadAsyncPartialCallback A_0, StorageManager.FFIMethods.ReadAsyncPartialCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.ReadAsyncPartialCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C09 RID: 7177
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C0A RID: 7178
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_IntPtr_Int32_0;

				// Token: 0x04001C0B RID: 7179
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_IntPtr_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C0C RID: 7180
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F2 RID: 754
			public sealed class ReadAsyncPartialMethod : MulticastDelegate
			{
				// Token: 0x060026BF RID: 9919 RVA: 0x000AD4A4 File Offset: 0x000AB6A4
				// Note: this type is marked as 'beforefieldinit'.
				static ReadAsyncPartialMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ReadAsyncPartialMethod");
					StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr, 100668271);
					StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr, 100668272);
					StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr, 100668273);
					StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr, 100668274);
				}

				// Token: 0x060026C0 RID: 9920 RVA: 0x000AD518 File Offset: 0x000AB718
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ReadAsyncPartialMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ReadAsyncPartialMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026C1 RID: 9921 RVA: 0x000AD574 File Offset: 0x000AB774
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026C2 RID: 9922 RVA: 0x000AD604 File Offset: 0x000AB804
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54818, XrefRangeEnd = 54827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026C3 RID: 9923 RVA: 0x000AD6C8 File Offset: 0x000AB8C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ReadAsyncPartialMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026C4 RID: 9924 RVA: 0x0000F8ED File Offset: 0x0000DAED
				public ReadAsyncPartialMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026C5 RID: 9925 RVA: 0x0000F8F6 File Offset: 0x0000DAF6
				public static implicit operator StorageManager.FFIMethods.ReadAsyncPartialMethod(Action<IntPtr, string, ulong, ulong, IntPtr, StorageManager.FFIMethods.ReadAsyncPartialCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.ReadAsyncPartialMethod>(A_0);
				}

				// Token: 0x060026C6 RID: 9926 RVA: 0x0000F8FE File Offset: 0x0000DAFE
				public static StorageManager.FFIMethods.ReadAsyncPartialMethod operator +(StorageManager.FFIMethods.ReadAsyncPartialMethod A_0, StorageManager.FFIMethods.ReadAsyncPartialMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.ReadAsyncPartialMethod>();
				}

				// Token: 0x060026C7 RID: 9927 RVA: 0x0000F90C File Offset: 0x0000DB0C
				public static StorageManager.FFIMethods.ReadAsyncPartialMethod operator -(StorageManager.FFIMethods.ReadAsyncPartialMethod A_0, StorageManager.FFIMethods.ReadAsyncPartialMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.ReadAsyncPartialMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C0D RID: 7181
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C0E RID: 7182
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_0;

				// Token: 0x04001C0F RID: 7183
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_UInt64_UInt64_IntPtr_ReadAsyncPartialCallback_AsyncCallback_Object_0;

				// Token: 0x04001C10 RID: 7184
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F3 RID: 755
			public sealed class WriteMethod : MulticastDelegate
			{
				// Token: 0x060026C8 RID: 9928 RVA: 0x000AD70C File Offset: 0x000AB90C
				// Note: this type is marked as 'beforefieldinit'.
				static WriteMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "WriteMethod");
					StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr, 100668275);
					StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr, 100668276);
					StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr, 100668277);
					StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr, 100668278);
				}

				// Token: 0x060026C9 RID: 9929 RVA: 0x000AD780 File Offset: 0x000AB980
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54827, XrefRangeEnd = 54830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WriteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026CA RID: 9930 RVA: 0x000AD7DC File Offset: 0x000AB9DC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026CB RID: 9931 RVA: 0x000AD85C File Offset: 0x000ABA5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54830, XrefRangeEnd = 54835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026CC RID: 9932 RVA: 0x000AD900 File Offset: 0x000ABB00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060026CD RID: 9933 RVA: 0x0000F91D File Offset: 0x0000DB1D
				public WriteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026CE RID: 9934 RVA: 0x0000F926 File Offset: 0x0000DB26
				public static implicit operator StorageManager.FFIMethods.WriteMethod(Func<IntPtr, string, Il2CppStructArray<byte>, int, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.WriteMethod>(A_0);
				}

				// Token: 0x060026CF RID: 9935 RVA: 0x0000F92E File Offset: 0x0000DB2E
				public static StorageManager.FFIMethods.WriteMethod operator +(StorageManager.FFIMethods.WriteMethod A_0, StorageManager.FFIMethods.WriteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.WriteMethod>();
				}

				// Token: 0x060026D0 RID: 9936 RVA: 0x0000F93C File Offset: 0x0000DB3C
				public static StorageManager.FFIMethods.WriteMethod operator -(StorageManager.FFIMethods.WriteMethod A_0, StorageManager.FFIMethods.WriteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.WriteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C11 RID: 7185
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C12 RID: 7186
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_Il2CppStructArray_1_Byte_Int32_0;

				// Token: 0x04001C13 RID: 7187
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C14 RID: 7188
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002F4 RID: 756
			public sealed class WriteAsyncCallback : MulticastDelegate
			{
				// Token: 0x060026D1 RID: 9937 RVA: 0x000AD950 File Offset: 0x000ABB50
				// Note: this type is marked as 'beforefieldinit'.
				static WriteAsyncCallback()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "WriteAsyncCallback");
					StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr, 100668279);
					StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr, 100668280);
					StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr, 100668281);
					StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr, 100668282);
				}

				// Token: 0x060026D2 RID: 9938 RVA: 0x000AD9C4 File Offset: 0x000ABBC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WriteAsyncCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026D3 RID: 9939 RVA: 0x000ADA20 File Offset: 0x000ABC20
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026D4 RID: 9940 RVA: 0x000ADA70 File Offset: 0x000ABC70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54835, XrefRangeEnd = 54841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026D5 RID: 9941 RVA: 0x000ADAF4 File Offset: 0x000ABCF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026D6 RID: 9942 RVA: 0x0000F94D File Offset: 0x0000DB4D
				public WriteAsyncCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026D7 RID: 9943 RVA: 0x0000F956 File Offset: 0x0000DB56
				public static implicit operator StorageManager.FFIMethods.WriteAsyncCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.WriteAsyncCallback>(A_0);
				}

				// Token: 0x060026D8 RID: 9944 RVA: 0x0000F95E File Offset: 0x0000DB5E
				public static StorageManager.FFIMethods.WriteAsyncCallback operator +(StorageManager.FFIMethods.WriteAsyncCallback A_0, StorageManager.FFIMethods.WriteAsyncCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.WriteAsyncCallback>();
				}

				// Token: 0x060026D9 RID: 9945 RVA: 0x0000F96C File Offset: 0x0000DB6C
				public static StorageManager.FFIMethods.WriteAsyncCallback operator -(StorageManager.FFIMethods.WriteAsyncCallback A_0, StorageManager.FFIMethods.WriteAsyncCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.WriteAsyncCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C15 RID: 7189
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C16 RID: 7190
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001C17 RID: 7191
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001C18 RID: 7192
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F5 RID: 757
			public sealed class WriteAsyncMethod : MulticastDelegate
			{
				// Token: 0x060026DA RID: 9946 RVA: 0x000ADB38 File Offset: 0x000ABD38
				// Note: this type is marked as 'beforefieldinit'.
				static WriteAsyncMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "WriteAsyncMethod");
					StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr, 100668283);
					StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr, 100668284);
					StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr, 100668285);
					StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr, 100668286);
				}

				// Token: 0x060026DB RID: 9947 RVA: 0x000ADBAC File Offset: 0x000ABDAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WriteAsyncMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.WriteAsyncMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026DC RID: 9948 RVA: 0x000ADC08 File Offset: 0x000ABE08
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026DD RID: 9949 RVA: 0x000ADC9C File Offset: 0x000ABE9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54841, XrefRangeEnd = 54848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Il2CppStructArray<byte> data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026DE RID: 9950 RVA: 0x000ADD64 File Offset: 0x000ABF64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.WriteAsyncMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060026DF RID: 9951 RVA: 0x0000F97D File Offset: 0x0000DB7D
				public WriteAsyncMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026E0 RID: 9952 RVA: 0x0000F986 File Offset: 0x0000DB86
				public static implicit operator StorageManager.FFIMethods.WriteAsyncMethod(Action<IntPtr, string, Il2CppStructArray<byte>, int, IntPtr, StorageManager.FFIMethods.WriteAsyncCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.WriteAsyncMethod>(A_0);
				}

				// Token: 0x060026E1 RID: 9953 RVA: 0x0000F98E File Offset: 0x0000DB8E
				public static StorageManager.FFIMethods.WriteAsyncMethod operator +(StorageManager.FFIMethods.WriteAsyncMethod A_0, StorageManager.FFIMethods.WriteAsyncMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.WriteAsyncMethod>();
				}

				// Token: 0x060026E2 RID: 9954 RVA: 0x0000F99C File Offset: 0x0000DB9C
				public static StorageManager.FFIMethods.WriteAsyncMethod operator -(StorageManager.FFIMethods.WriteAsyncMethod A_0, StorageManager.FFIMethods.WriteAsyncMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.WriteAsyncMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C19 RID: 7193
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C1A RID: 7194
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_0;

				// Token: 0x04001C1B RID: 7195
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_Il2CppStructArray_1_Byte_Int32_IntPtr_WriteAsyncCallback_AsyncCallback_Object_0;

				// Token: 0x04001C1C RID: 7196
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002F6 RID: 758
			public sealed class DeleteMethod : MulticastDelegate
			{
				// Token: 0x060026E3 RID: 9955 RVA: 0x000ADDA8 File Offset: 0x000ABFA8
				// Note: this type is marked as 'beforefieldinit'.
				static DeleteMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "DeleteMethod");
					StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr, 100668287);
					StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr, 100668288);
					StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr, 100668289);
					StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr, 100668290);
				}

				// Token: 0x060026E4 RID: 9956 RVA: 0x000ADE1C File Offset: 0x000AC01C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DeleteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.DeleteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026E5 RID: 9957 RVA: 0x000ADE78 File Offset: 0x000AC078
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string name)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026E6 RID: 9958 RVA: 0x000ADED8 File Offset: 0x000AC0D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026E7 RID: 9959 RVA: 0x000ADF5C File Offset: 0x000AC15C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.DeleteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060026E8 RID: 9960 RVA: 0x0000F9AD File Offset: 0x0000DBAD
				public DeleteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060026E9 RID: 9961 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
				public static implicit operator StorageManager.FFIMethods.DeleteMethod(Func<IntPtr, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.DeleteMethod>(A_0);
				}

				// Token: 0x060026EA RID: 9962 RVA: 0x0000F9BE File Offset: 0x0000DBBE
				public static StorageManager.FFIMethods.DeleteMethod operator +(StorageManager.FFIMethods.DeleteMethod A_0, StorageManager.FFIMethods.DeleteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.DeleteMethod>();
				}

				// Token: 0x060026EB RID: 9963 RVA: 0x0000F9CC File Offset: 0x0000DBCC
				public static StorageManager.FFIMethods.DeleteMethod operator -(StorageManager.FFIMethods.DeleteMethod A_0, StorageManager.FFIMethods.DeleteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.DeleteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C1D RID: 7197
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C1E RID: 7198
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0;

				// Token: 0x04001C1F RID: 7199
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x04001C20 RID: 7200
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002F7 RID: 759
			public sealed class ExistsMethod : MulticastDelegate
			{
				// Token: 0x060026EC RID: 9964 RVA: 0x000ADFAC File Offset: 0x000AC1AC
				// Note: this type is marked as 'beforefieldinit'.
				static ExistsMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "ExistsMethod");
					StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr, 100668291);
					StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr, 100668292);
					StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr, 100668293);
					StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr, 100668294);
				}

				// Token: 0x060026ED RID: 9965 RVA: 0x000AE020 File Offset: 0x000AC220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExistsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.ExistsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026EE RID: 9966 RVA: 0x000AE07C File Offset: 0x000AC27C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string name, ref bool exists)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &exists;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026EF RID: 9967 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54848, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref bool exists, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &exists;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026F0 RID: 9968 RVA: 0x000AE17C File Offset: 0x000AC37C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool exists, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &exists;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.ExistsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060026F1 RID: 9969 RVA: 0x0000F9DD File Offset: 0x0000DBDD
				public ExistsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C21 RID: 7201
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C22 RID: 7202
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_Boolean_0;

				// Token: 0x04001C23 RID: 7203
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C24 RID: 7204
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x020002F8 RID: 760
			public sealed class CountMethod : MulticastDelegate
			{
				// Token: 0x060026F2 RID: 9970 RVA: 0x000AE1DC File Offset: 0x000AC3DC
				// Note: this type is marked as 'beforefieldinit'.
				static CountMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "CountMethod");
					StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr, 100668295);
					StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr, 100668296);
					StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr, 100668297);
					StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr, 100668298);
				}

				// Token: 0x060026F3 RID: 9971 RVA: 0x000AE250 File Offset: 0x000AC450
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.CountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026F4 RID: 9972 RVA: 0x000AE2AC File Offset: 0x000AC4AC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026F5 RID: 9973 RVA: 0x000AE2F8 File Offset: 0x000AC4F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060026F6 RID: 9974 RVA: 0x000AE378 File Offset: 0x000AC578
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.CountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026F7 RID: 9975 RVA: 0x0000F9E6 File Offset: 0x0000DBE6
				public CountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C25 RID: 7205
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C26 RID: 7206
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0;

				// Token: 0x04001C27 RID: 7207
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001C28 RID: 7208
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x020002F9 RID: 761
			public sealed class StatMethod : MulticastDelegate
			{
				// Token: 0x060026F8 RID: 9976 RVA: 0x000AE3C8 File Offset: 0x000AC5C8
				// Note: this type is marked as 'beforefieldinit'.
				static StatMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "StatMethod");
					StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr, 100668299);
					StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_FileStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr, 100668300);
					StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_FileStat_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr, 100668301);
					StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr, 100668302);
				}

				// Token: 0x060026F9 RID: 9977 RVA: 0x000AE43C File Offset: 0x000AC63C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe StatMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.StatMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060026FA RID: 9978 RVA: 0x000AE498 File Offset: 0x000AC698
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string name, ref FileStat stat)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_FileStat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060026FB RID: 9979 RVA: 0x000AE520 File Offset: 0x000AC720
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54853, XrefRangeEnd = 54859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref FileStat stat, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_FileStat_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060026FC RID: 9980 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref FileStat stat, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060026FD RID: 9981 RVA: 0x0000F9EF File Offset: 0x0000DBEF
				public StatMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C29 RID: 7209
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C2A RID: 7210
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_byref_FileStat_0;

				// Token: 0x04001C2B RID: 7211
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_FileStat_AsyncCallback_Object_0;

				// Token: 0x04001C2C RID: 7212
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0;
			}

			// Token: 0x020002FA RID: 762
			public sealed class StatAtMethod : MulticastDelegate
			{
				// Token: 0x060026FE RID: 9982 RVA: 0x000AE64C File Offset: 0x000AC84C
				// Note: this type is marked as 'beforefieldinit'.
				static StatAtMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "StatAtMethod");
					StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr, 100668303);
					StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_FileStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr, 100668304);
					StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_FileStat_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr, 100668305);
					StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr, 100668306);
				}

				// Token: 0x060026FF RID: 9983 RVA: 0x000AE6C0 File Offset: 0x000AC8C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe StatAtMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.StatAtMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002700 RID: 9984 RVA: 0x000AE71C File Offset: 0x000AC91C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, int index, ref FileStat stat)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_FileStat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002701 RID: 9985 RVA: 0x000AE7A0 File Offset: 0x000AC9A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54859, XrefRangeEnd = 54867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref FileStat stat, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_FileStat_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002702 RID: 9986 RVA: 0x000AE84C File Offset: 0x000ACA4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref FileStat stat, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(stat);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.StatAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					stat = ((intPtr4 == 0) ? null : new FileStat(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002703 RID: 9987 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
				public StatAtMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C2D RID: 7213
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C2E RID: 7214
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_FileStat_0;

				// Token: 0x04001C2F RID: 7215
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_FileStat_AsyncCallback_Object_0;

				// Token: 0x04001C30 RID: 7216
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_FileStat_IAsyncResult_0;
			}

			// Token: 0x020002FB RID: 763
			public sealed class GetPathMethod : MulticastDelegate
			{
				// Token: 0x06002704 RID: 9988 RVA: 0x000AE8C8 File Offset: 0x000ACAC8
				// Note: this type is marked as 'beforefieldinit'.
				static GetPathMethod()
				{
					Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager.FFIMethods>.NativeClassPtr, "GetPathMethod");
					StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr, 100668307);
					StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr, 100668308);
					StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr, 100668309);
					StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr, 100668310);
				}

				// Token: 0x06002705 RID: 9989 RVA: 0x000AE93C File Offset: 0x000ACB3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetPathMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.FFIMethods.GetPathMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002706 RID: 9990 RVA: 0x000AE998 File Offset: 0x000ACB98
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, StringBuilder path)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002707 RID: 9991 RVA: 0x000AE9F8 File Offset: 0x000ACBF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder path, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002708 RID: 9992 RVA: 0x000AEA7C File Offset: 0x000ACC7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.FFIMethods.GetPathMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002709 RID: 9993 RVA: 0x0000FA01 File Offset: 0x0000DC01
				public GetPathMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600270A RID: 9994 RVA: 0x0000FA0A File Offset: 0x0000DC0A
				public static implicit operator StorageManager.FFIMethods.GetPathMethod(Func<IntPtr, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<StorageManager.FFIMethods.GetPathMethod>(A_0);
				}

				// Token: 0x0600270B RID: 9995 RVA: 0x0000FA12 File Offset: 0x0000DC12
				public static StorageManager.FFIMethods.GetPathMethod operator +(StorageManager.FFIMethods.GetPathMethod A_0, StorageManager.FFIMethods.GetPathMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<StorageManager.FFIMethods.GetPathMethod>();
				}

				// Token: 0x0600270C RID: 9996 RVA: 0x0000FA20 File Offset: 0x0000DC20
				public static StorageManager.FFIMethods.GetPathMethod operator -(StorageManager.FFIMethods.GetPathMethod A_0, StorageManager.FFIMethods.GetPathMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<StorageManager.FFIMethods.GetPathMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C31 RID: 7217
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C32 RID: 7218
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_StringBuilder_0;

				// Token: 0x04001C33 RID: 7219
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001C34 RID: 7220
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}

		// Token: 0x02000239 RID: 569
		public sealed class ReadAsyncHandler : MulticastDelegate
		{
			// Token: 0x060020BD RID: 8381 RVA: 0x000962B0 File Offset: 0x000944B0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadAsyncHandler()
			{
				Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "ReadAsyncHandler");
				StorageManager.ReadAsyncHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr, 100668311);
				StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr, 100668312);
				StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr, 100668313);
				StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr, 100668314);
			}

			// Token: 0x060020BE RID: 8382 RVA: 0x00096324 File Offset: 0x00094524
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadAsyncHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.ReadAsyncHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020BF RID: 8383 RVA: 0x00096380 File Offset: 0x00094580
			[CallerCount(0)]
			public unsafe void Invoke(Result result, Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C0 RID: 8384 RVA: 0x000963D4 File Offset: 0x000945D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54867, XrefRangeEnd = 54871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, Il2CppStructArray<byte> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060020C1 RID: 8385 RVA: 0x0009645C File Offset: 0x0009465C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020C2 RID: 8386 RVA: 0x0000D8F6 File Offset: 0x0000BAF6
			public ReadAsyncHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020C3 RID: 8387 RVA: 0x0000D8FF File Offset: 0x0000BAFF
			public static implicit operator StorageManager.ReadAsyncHandler(Action<Result, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<StorageManager.ReadAsyncHandler>(A_0);
			}

			// Token: 0x060020C4 RID: 8388 RVA: 0x0000D907 File Offset: 0x0000BB07
			public static StorageManager.ReadAsyncHandler operator +(StorageManager.ReadAsyncHandler A_0, StorageManager.ReadAsyncHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StorageManager.ReadAsyncHandler>();
			}

			// Token: 0x060020C5 RID: 8389 RVA: 0x0000D915 File Offset: 0x0000BB15
			public static StorageManager.ReadAsyncHandler operator -(StorageManager.ReadAsyncHandler A_0, StorageManager.ReadAsyncHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StorageManager.ReadAsyncHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001931 RID: 6449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001932 RID: 6450
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0;

			// Token: 0x04001933 RID: 6451
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;

			// Token: 0x04001934 RID: 6452
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023A RID: 570
		public sealed class ReadAsyncPartialHandler : MulticastDelegate
		{
			// Token: 0x060020C6 RID: 8390 RVA: 0x000964A0 File Offset: 0x000946A0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadAsyncPartialHandler()
			{
				Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "ReadAsyncPartialHandler");
				StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr, 100668315);
				StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr, 100668316);
				StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr, 100668317);
				StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr, 100668318);
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x00096514 File Offset: 0x00094714
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadAsyncPartialHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.ReadAsyncPartialHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x00096570 File Offset: 0x00094770
			[CallerCount(0)]
			public unsafe void Invoke(Result result, Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x000965C4 File Offset: 0x000947C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54871, XrefRangeEnd = 54875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, Il2CppStructArray<byte> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060020CA RID: 8394 RVA: 0x0009664C File Offset: 0x0009484C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.ReadAsyncPartialHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x0000D926 File Offset: 0x0000BB26
			public ReadAsyncPartialHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020CC RID: 8396 RVA: 0x0000D92F File Offset: 0x0000BB2F
			public static implicit operator StorageManager.ReadAsyncPartialHandler(Action<Result, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<StorageManager.ReadAsyncPartialHandler>(A_0);
			}

			// Token: 0x060020CD RID: 8397 RVA: 0x0000D937 File Offset: 0x0000BB37
			public static StorageManager.ReadAsyncPartialHandler operator +(StorageManager.ReadAsyncPartialHandler A_0, StorageManager.ReadAsyncPartialHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StorageManager.ReadAsyncPartialHandler>();
			}

			// Token: 0x060020CE RID: 8398 RVA: 0x0000D945 File Offset: 0x0000BB45
			public static StorageManager.ReadAsyncPartialHandler operator -(StorageManager.ReadAsyncPartialHandler A_0, StorageManager.ReadAsyncPartialHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StorageManager.ReadAsyncPartialHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001935 RID: 6453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001936 RID: 6454
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_Il2CppStructArray_1_Byte_0;

			// Token: 0x04001937 RID: 6455
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;

			// Token: 0x04001938 RID: 6456
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023B RID: 571
		public sealed class WriteAsyncHandler : MulticastDelegate
		{
			// Token: 0x060020CF RID: 8399 RVA: 0x00096690 File Offset: 0x00094890
			// Note: this type is marked as 'beforefieldinit'.
			static WriteAsyncHandler()
			{
				Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageManager>.NativeClassPtr, "WriteAsyncHandler");
				StorageManager.WriteAsyncHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr, 100668319);
				StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr, 100668320);
				StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr, 100668321);
				StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr, 100668322);
			}

			// Token: 0x060020D0 RID: 8400 RVA: 0x00096704 File Offset: 0x00094904
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteAsyncHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageManager.WriteAsyncHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.WriteAsyncHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D1 RID: 8401 RVA: 0x00096760 File Offset: 0x00094960
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020D2 RID: 8402 RVA: 0x000967A4 File Offset: 0x000949A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54875, XrefRangeEnd = 54879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060020D3 RID: 8403 RVA: 0x00096818 File Offset: 0x00094A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageManager.WriteAsyncHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020D4 RID: 8404 RVA: 0x0000D956 File Offset: 0x0000BB56
			public WriteAsyncHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x0000D95F File Offset: 0x0000BB5F
			public static implicit operator StorageManager.WriteAsyncHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<StorageManager.WriteAsyncHandler>(A_0);
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x0000D967 File Offset: 0x0000BB67
			public static StorageManager.WriteAsyncHandler operator +(StorageManager.WriteAsyncHandler A_0, StorageManager.WriteAsyncHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StorageManager.WriteAsyncHandler>();
			}

			// Token: 0x060020D7 RID: 8407 RVA: 0x0000D975 File Offset: 0x0000BB75
			public static StorageManager.WriteAsyncHandler operator -(StorageManager.WriteAsyncHandler A_0, StorageManager.WriteAsyncHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StorageManager.WriteAsyncHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001939 RID: 6457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400193A RID: 6458
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400193B RID: 6459
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400193C RID: 6460
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
