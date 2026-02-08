using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Discord
{
	// Token: 0x0200015D RID: 349
	public class ImageManager : global::Il2CppSystem.Object
	{
		// Token: 0x06001751 RID: 5969 RVA: 0x000755D0 File Offset: 0x000737D0
		// Note: this type is marked as 'beforefieldinit'.
		static ImageManager()
		{
			Il2CppClassPointerStore<ImageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ImageManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageManager>.NativeClassPtr);
			ImageManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, "MethodsPtr");
			ImageManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, "MethodsStructure");
			ImageManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667568);
			ImageManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667569);
			ImageManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667570);
			ImageManager.NativeMethodInfoPtr_FetchCallbackImpl_Private_Static_Void_IntPtr_Result_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667571);
			ImageManager.NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_Boolean_FetchHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667572);
			ImageManager.NativeMethodInfoPtr_GetDimensions_Public_ImageDimensions_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667573);
			ImageManager.NativeMethodInfoPtr_GetData_Public_Void_ImageHandle_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667574);
			ImageManager.NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_FetchHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667575);
			ImageManager.NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667576);
			ImageManager.NativeMethodInfoPtr_GetTexture_Public_Texture2D_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, 100667577);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x000756F0 File Offset: 0x000738F0
		public unsafe ImageManager.FFIMethods Methods
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 52943, RefRangeEnd = 52949, XrefRangeStart = 52930, XrefRangeEnd = 52943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ImageManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00075728 File Offset: 0x00073928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52949, XrefRangeEnd = 52956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageManager(IntPtr ptr, IntPtr eventsPtr, ref ImageManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0007578C File Offset: 0x0007398C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52956, XrefRangeEnd = 52962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref ImageManager.FFIEvents events)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000757D8 File Offset: 0x000739D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52962, XrefRangeEnd = 52969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_FetchCallbackImpl_Private_Static_Void_IntPtr_Result_ImageHandle_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00075830 File Offset: 0x00073A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52969, XrefRangeEnd = 52980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fetch(ImageHandle handle, bool refresh, ImageManager.FetchHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refresh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_Boolean_FetchHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00075894 File Offset: 0x00073A94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52981, RefRangeEnd = 52984, XrefRangeStart = 52980, XrefRangeEnd = 52981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageDimensions GetDimensions(ImageHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_GetDimensions_Public_ImageDimensions_ImageHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageDimensions>(intPtr3) : null;
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000758E4 File Offset: 0x00073AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52984, XrefRangeEnd = 52985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetData(ImageHandle handle, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_GetData_Public_Void_ImageHandle_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00075938 File Offset: 0x00073B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52985, XrefRangeEnd = 52996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fetch(ImageHandle handle, ImageManager.FetchHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_FetchHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0007598C File Offset: 0x00073B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52996, XrefRangeEnd = 53001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetData(ImageHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_ImageHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000759DC File Offset: 0x00073BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53001, XrefRangeEnd = 53013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture(ImageHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.NativeMethodInfoPtr_GetTexture_Public_Texture2D_ImageHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0000961E File Offset: 0x0000781E
		public ImageManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00075A2C File Offset: 0x00073C2C
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00009627 File Offset: 0x00007827
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00075A54 File Offset: 0x00073C54
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x00009642 File Offset: 0x00007842
		public unsafe global::Il2CppSystem.Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_FetchCallbackImpl_Private_Static_Void_IntPtr_Result_ImageHandle_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_Boolean_FetchHandler_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_ImageDimensions_ImageHandle_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Void_ImageHandle_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Public_Void_ImageHandle_FetchHandler_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_ImageHandle_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_ImageHandle_0;

		// Token: 0x0200020D RID: 525
		[StructLayout(2)]
		public struct FFIEvents
		{
			// Token: 0x06001ED7 RID: 7895 RVA: 0x0000C735 File Offset: 0x0000A935
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<ImageManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageManager.FFIEvents>.NativeClassPtr);
			}

			// Token: 0x06001ED8 RID: 7896 RVA: 0x0000C755 File Offset: 0x0000A955
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImageManager.FFIEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200020E RID: 526
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001ED9 RID: 7897 RVA: 0x00090B88 File Offset: 0x0008ED88
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr);
				ImageManager.FFIMethods.NativeFieldInfoPtr_Fetch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "Fetch");
				ImageManager.FFIMethods.NativeFieldInfoPtr_GetDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "GetDimensions");
				ImageManager.FFIMethods.NativeFieldInfoPtr_GetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "GetData");
			}

			// Token: 0x06001EDA RID: 7898 RVA: 0x0000C767 File Offset: 0x0000A967
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EDB RID: 7899 RVA: 0x0000C770 File Offset: 0x0000A970
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00090BF0 File Offset: 0x0008EDF0
			// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0000C782 File Offset: 0x0000A982
			public unsafe ImageManager.FFIMethods.FetchMethod Fetch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_Fetch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageManager.FFIMethods.FetchMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_Fetch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00090C20 File Offset: 0x0008EE20
			// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
			public unsafe ImageManager.FFIMethods.GetDimensionsMethod GetDimensions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_GetDimensions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageManager.FFIMethods.GetDimensionsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_GetDimensions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00090C50 File Offset: 0x0008EE50
			// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
			public unsafe ImageManager.FFIMethods.GetDataMethod GetData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_GetData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageManager.FFIMethods.GetDataMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageManager.FFIMethods.NativeFieldInfoPtr_GetData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr_Fetch;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeFieldInfoPtr_GetDimensions;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeFieldInfoPtr_GetData;

			// Token: 0x0200028B RID: 651
			public sealed class FetchCallback : MulticastDelegate
			{
				// Token: 0x06002371 RID: 9073 RVA: 0x0009FA58 File Offset: 0x0009DC58
				// Note: this type is marked as 'beforefieldinit'.
				static FetchCallback()
				{
					Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "FetchCallback");
					ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr, 100667578);
					ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr, 100667579);
					ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_ImageHandle_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr, 100667580);
					ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr, 100667581);
				}

				// Token: 0x06002372 RID: 9074 RVA: 0x0009FACC File Offset: 0x0009DCCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52872, XrefRangeEnd = 52875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchCallback(global::Il2CppSystem.Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002373 RID: 9075 RVA: 0x0009FB28 File Offset: 0x0009DD28
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ImageHandle handleResult)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_ImageHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002374 RID: 9076 RVA: 0x0009FB8C File Offset: 0x0009DD8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52875, XrefRangeEnd = 52884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ImageHandle handleResult, AsyncCallback callback, global::Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleResult);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_ImageHandle_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002375 RID: 9077 RVA: 0x0009FC24 File Offset: 0x0009DE24
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002376 RID: 9078 RVA: 0x0000E9BA File Offset: 0x0000CBBA
				public FetchCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002377 RID: 9079 RVA: 0x0000E9C3 File Offset: 0x0000CBC3
				public static implicit operator ImageManager.FFIMethods.FetchCallback(Action<IntPtr, Result, ImageHandle> A_0)
				{
					return DelegateSupport.ConvertDelegate<ImageManager.FFIMethods.FetchCallback>(A_0);
				}

				// Token: 0x06002378 RID: 9080 RVA: 0x0000E9CB File Offset: 0x0000CBCB
				public static ImageManager.FFIMethods.FetchCallback operator +(ImageManager.FFIMethods.FetchCallback A_0, ImageManager.FFIMethods.FetchCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ImageManager.FFIMethods.FetchCallback>();
				}

				// Token: 0x06002379 RID: 9081 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
				public static ImageManager.FFIMethods.FetchCallback operator -(ImageManager.FFIMethods.FetchCallback A_0, ImageManager.FFIMethods.FetchCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ImageManager.FFIMethods.FetchCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001A71 RID: 6769
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A72 RID: 6770
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_ImageHandle_0;

				// Token: 0x04001A73 RID: 6771
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_ImageHandle_AsyncCallback_Object_0;

				// Token: 0x04001A74 RID: 6772
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200028C RID: 652
			public sealed class FetchMethod : MulticastDelegate
			{
				// Token: 0x0600237A RID: 9082 RVA: 0x0009FC68 File Offset: 0x0009DE68
				// Note: this type is marked as 'beforefieldinit'.
				static FetchMethod()
				{
					Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "FetchMethod");
					ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr, 100667582);
					ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr, 100667583);
					ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr, 100667584);
					ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr, 100667585);
				}

				// Token: 0x0600237B RID: 9083 RVA: 0x0009FCDC File Offset: 0x0009DEDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52884, XrefRangeEnd = 52887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchMethod(global::Il2CppSystem.Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FFIMethods.FetchMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600237C RID: 9084 RVA: 0x0009FD38 File Offset: 0x0009DF38
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refresh;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600237D RID: 9085 RVA: 0x0009FDB8 File Offset: 0x0009DFB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52887, XrefRangeEnd = 52897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback, AsyncCallback __callback, global::Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refresh;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600237E RID: 9086 RVA: 0x0009FE6C File Offset: 0x0009E06C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.FetchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600237F RID: 9087 RVA: 0x0000E9EA File Offset: 0x0000CBEA
				public FetchMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002380 RID: 9088 RVA: 0x0000E9F3 File Offset: 0x0000CBF3
				public static implicit operator ImageManager.FFIMethods.FetchMethod(Action<IntPtr, ImageHandle, bool, IntPtr, ImageManager.FFIMethods.FetchCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ImageManager.FFIMethods.FetchMethod>(A_0);
				}

				// Token: 0x06002381 RID: 9089 RVA: 0x0000E9FB File Offset: 0x0000CBFB
				public static ImageManager.FFIMethods.FetchMethod operator +(ImageManager.FFIMethods.FetchMethod A_0, ImageManager.FFIMethods.FetchMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ImageManager.FFIMethods.FetchMethod>();
				}

				// Token: 0x06002382 RID: 9090 RVA: 0x0000EA09 File Offset: 0x0000CC09
				public static ImageManager.FFIMethods.FetchMethod operator -(ImageManager.FFIMethods.FetchMethod A_0, ImageManager.FFIMethods.FetchMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ImageManager.FFIMethods.FetchMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A75 RID: 6773
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A76 RID: 6774
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_0;

				// Token: 0x04001A77 RID: 6775
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Boolean_IntPtr_FetchCallback_AsyncCallback_Object_0;

				// Token: 0x04001A78 RID: 6776
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200028D RID: 653
			public sealed class GetDimensionsMethod : MulticastDelegate
			{
				// Token: 0x06002383 RID: 9091 RVA: 0x0009FEB0 File Offset: 0x0009E0B0
				// Note: this type is marked as 'beforefieldinit'.
				static GetDimensionsMethod()
				{
					Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "GetDimensionsMethod");
					ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr, 100667586);
					ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_byref_ImageDimensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr, 100667587);
					ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_byref_ImageDimensions_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr, 100667588);
					ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_ImageDimensions_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr, 100667589);
				}

				// Token: 0x06002384 RID: 9092 RVA: 0x0009FF24 File Offset: 0x0009E124
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52897, XrefRangeEnd = 52900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetDimensionsMethod(global::Il2CppSystem.Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDimensionsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002385 RID: 9093 RVA: 0x0009FF80 File Offset: 0x0009E180
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dimensions;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_byref_ImageDimensions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002386 RID: 9094 RVA: 0x0009FFEC File Offset: 0x0009E1EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52900, XrefRangeEnd = 52909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions, AsyncCallback callback, global::Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dimensions;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_byref_ImageDimensions_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002387 RID: 9095 RVA: 0x000A0080 File Offset: 0x0009E280
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref ImageDimensions dimensions, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &dimensions;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDimensionsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_ImageDimensions_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002388 RID: 9096 RVA: 0x0000EA1A File Offset: 0x0000CC1A
				public GetDimensionsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A79 RID: 6777
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A7A RID: 6778
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_byref_ImageDimensions_0;

				// Token: 0x04001A7B RID: 6779
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_byref_ImageDimensions_AsyncCallback_Object_0;

				// Token: 0x04001A7C RID: 6780
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_ImageDimensions_IAsyncResult_0;
			}

			// Token: 0x0200028E RID: 654
			public sealed class GetDataMethod : MulticastDelegate
			{
				// Token: 0x06002389 RID: 9097 RVA: 0x000A00E0 File Offset: 0x0009E2E0
				// Note: this type is marked as 'beforefieldinit'.
				static GetDataMethod()
				{
					Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager.FFIMethods>.NativeClassPtr, "GetDataMethod");
					ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr, 100667590);
					ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr, 100667591);
					ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr, 100667592);
					ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr, 100667593);
				}

				// Token: 0x0600238A RID: 9098 RVA: 0x000A0154 File Offset: 0x0009E354
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52909, XrefRangeEnd = 52912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetDataMethod(global::Il2CppSystem.Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FFIMethods.GetDataMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600238B RID: 9099 RVA: 0x000A01B0 File Offset: 0x0009E3B0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ImageHandle handle, Il2CppStructArray<byte> data, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600238C RID: 9100 RVA: 0x000A0230 File Offset: 0x0009E430
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52912, XrefRangeEnd = 52920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, Il2CppStructArray<byte> data, int dataLen, AsyncCallback callback, global::Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600238D RID: 9101 RVA: 0x000A02D4 File Offset: 0x0009E4D4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FFIMethods.GetDataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600238E RID: 9102 RVA: 0x0000EA23 File Offset: 0x0000CC23
				public GetDataMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600238F RID: 9103 RVA: 0x0000EA2C File Offset: 0x0000CC2C
				public static implicit operator ImageManager.FFIMethods.GetDataMethod(Func<IntPtr, ImageHandle, Il2CppStructArray<byte>, int, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ImageManager.FFIMethods.GetDataMethod>(A_0);
				}

				// Token: 0x06002390 RID: 9104 RVA: 0x0000EA34 File Offset: 0x0000CC34
				public static ImageManager.FFIMethods.GetDataMethod operator +(ImageManager.FFIMethods.GetDataMethod A_0, ImageManager.FFIMethods.GetDataMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ImageManager.FFIMethods.GetDataMethod>();
				}

				// Token: 0x06002391 RID: 9105 RVA: 0x0000EA42 File Offset: 0x0000CC42
				public static ImageManager.FFIMethods.GetDataMethod operator -(ImageManager.FFIMethods.GetDataMethod A_0, ImageManager.FFIMethods.GetDataMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ImageManager.FFIMethods.GetDataMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A7D RID: 6781
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A7E RID: 6782
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_0;

				// Token: 0x04001A7F RID: 6783
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ImageHandle_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0;

				// Token: 0x04001A80 RID: 6784
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}

		// Token: 0x0200020F RID: 527
		public sealed class FetchHandler : MulticastDelegate
		{
			// Token: 0x06001EE2 RID: 7906 RVA: 0x00090C80 File Offset: 0x0008EE80
			// Note: this type is marked as 'beforefieldinit'.
			static FetchHandler()
			{
				Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageManager>.NativeClassPtr, "FetchHandler");
				ImageManager.FetchHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr, 100667594);
				ImageManager.FetchHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_ImageHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr, 100667595);
				ImageManager.FetchHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_ImageHandle_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr, 100667596);
				ImageManager.FetchHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr, 100667597);
			}

			// Token: 0x06001EE3 RID: 7907 RVA: 0x00090CF4 File Offset: 0x0008EEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52920, XrefRangeEnd = 52923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FetchHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageManager.FetchHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FetchHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE4 RID: 7908 RVA: 0x00090D50 File Offset: 0x0008EF50
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ImageHandle handleResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FetchHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_ImageHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE5 RID: 7909 RVA: 0x00090DA4 File Offset: 0x0008EFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52923, XrefRangeEnd = 52930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ImageHandle handleResult, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleResult);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FetchHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_ImageHandle_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EE6 RID: 7910 RVA: 0x00090E2C File Offset: 0x0008F02C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageManager.FetchHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x0000C7DF File Offset: 0x0000A9DF
			public FetchHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EE8 RID: 7912 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
			public static implicit operator ImageManager.FetchHandler(Action<Result, ImageHandle> A_0)
			{
				return DelegateSupport.ConvertDelegate<ImageManager.FetchHandler>(A_0);
			}

			// Token: 0x06001EE9 RID: 7913 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
			public static ImageManager.FetchHandler operator +(ImageManager.FetchHandler A_0, ImageManager.FetchHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ImageManager.FetchHandler>();
			}

			// Token: 0x06001EEA RID: 7914 RVA: 0x0000C7FE File Offset: 0x0000A9FE
			public static ImageManager.FetchHandler operator -(ImageManager.FetchHandler A_0, ImageManager.FetchHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ImageManager.FetchHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_ImageHandle_0;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_ImageHandle_AsyncCallback_Object_0;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
