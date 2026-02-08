using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000164 RID: 356
	public class VoiceManager : Object
	{
		// Token: 0x06001854 RID: 6228 RVA: 0x0007A5D4 File Offset: 0x000787D4
		// Note: this type is marked as 'beforefieldinit'.
		static VoiceManager()
		{
			Il2CppClassPointerStore<VoiceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "VoiceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr);
			VoiceManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "MethodsPtr");
			VoiceManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "MethodsStructure");
			VoiceManager.NativeFieldInfoPtr_OnSettingsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "OnSettingsUpdate");
			VoiceManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668427);
			VoiceManager.NativeMethodInfoPtr_add_OnSettingsUpdate_Public_add_Void_SettingsUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668428);
			VoiceManager.NativeMethodInfoPtr_remove_OnSettingsUpdate_Public_rem_Void_SettingsUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668429);
			VoiceManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668430);
			VoiceManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668431);
			VoiceManager.NativeMethodInfoPtr_GetInputMode_Public_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668432);
			VoiceManager.NativeMethodInfoPtr_SetInputModeCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668433);
			VoiceManager.NativeMethodInfoPtr_SetInputMode_Public_Void_InputMode_SetInputModeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668434);
			VoiceManager.NativeMethodInfoPtr_IsSelfMute_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668435);
			VoiceManager.NativeMethodInfoPtr_SetSelfMute_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668436);
			VoiceManager.NativeMethodInfoPtr_IsSelfDeaf_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668437);
			VoiceManager.NativeMethodInfoPtr_SetSelfDeaf_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668438);
			VoiceManager.NativeMethodInfoPtr_IsLocalMute_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668439);
			VoiceManager.NativeMethodInfoPtr_SetLocalMute_Public_Void_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668440);
			VoiceManager.NativeMethodInfoPtr_GetLocalVolume_Public_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668441);
			VoiceManager.NativeMethodInfoPtr_SetLocalVolume_Public_Void_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668442);
			VoiceManager.NativeMethodInfoPtr_OnSettingsUpdateImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, 100668443);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0007A794 File Offset: 0x00078994
		public unsafe VoiceManager.FFIMethods Methods
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 55337, RefRangeEnd = 55347, XrefRangeStart = 55324, XrefRangeEnd = 55337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new VoiceManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0007A7CC File Offset: 0x000789CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55347, XrefRangeEnd = 55351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_add_OnSettingsUpdate_Public_add_Void_SettingsUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0007A810 File Offset: 0x00078A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55351, XrefRangeEnd = 55355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_remove_OnSettingsUpdate_Public_rem_Void_SettingsUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0007A854 File Offset: 0x00078A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55371, RefRangeEnd = 55372, XrefRangeStart = 55355, XrefRangeEnd = 55371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0007A8BC File Offset: 0x00078ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55372, XrefRangeEnd = 55389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0007A910 File Offset: 0x00078B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55389, XrefRangeEnd = 55390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputMode GetInputMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_GetInputMode_Public_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMode>(intPtr3) : null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0007A950 File Offset: 0x00078B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55390, XrefRangeEnd = 55397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetInputModeCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0007A994 File Offset: 0x00078B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55397, XrefRangeEnd = 55408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputMode(InputMode inputMode, VoiceManager.SetInputModeHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetInputMode_Public_Void_InputMode_SetInputModeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0007A9E8 File Offset: 0x00078BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55408, XrefRangeEnd = 55409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfMute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_IsSelfMute_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0007AA24 File Offset: 0x00078C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55409, XrefRangeEnd = 55410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelfMute(bool mute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mute;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetSelfMute_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0007AA64 File Offset: 0x00078C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55410, XrefRangeEnd = 55411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfDeaf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_IsSelfDeaf_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0007AAA0 File Offset: 0x00078CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55411, XrefRangeEnd = 55412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelfDeaf(bool deaf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deaf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetSelfDeaf_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0007AAE0 File Offset: 0x00078CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55412, XrefRangeEnd = 55413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalMute(long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_IsLocalMute_Public_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0007AB2C File Offset: 0x00078D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55413, XrefRangeEnd = 55414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalMute(long userId, bool mute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetLocalMute_Public_Void_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0007AB78 File Offset: 0x00078D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55414, XrefRangeEnd = 55415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte GetLocalVolume(long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_GetLocalVolume_Public_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55415, XrefRangeEnd = 55416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalVolume(long userId, byte volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_SetLocalVolume_Public_Void_Int64_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0007AC10 File Offset: 0x00078E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55416, XrefRangeEnd = 55422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSettingsUpdateImpl(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.NativeMethodInfoPtr_OnSettingsUpdateImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000099C4 File Offset: 0x00007BC4
		public VoiceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0007AC44 File Offset: 0x00078E44
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x000099CD File Offset: 0x00007BCD
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0007AC6C File Offset: 0x00078E6C
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x000099E8 File Offset: 0x00007BE8
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x0007AC9C File Offset: 0x00078E9C
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x00009A07 File Offset: 0x00007C07
		public unsafe VoiceManager.SettingsUpdateHandler OnSettingsUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_OnSettingsUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.SettingsUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.NativeFieldInfoPtr_OnSettingsUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_OnSettingsUpdate;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSettingsUpdate_Public_add_Void_SettingsUpdateHandler_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSettingsUpdate_Public_rem_Void_SettingsUpdateHandler_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_GetInputMode_Public_InputMode_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_SetInputModeCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_SetInputMode_Public_Void_InputMode_SetInputModeHandler_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfMute_Public_Boolean_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_SetSelfMute_Public_Void_Boolean_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfDeaf_Public_Boolean_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_SetSelfDeaf_Public_Void_Boolean_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalMute_Public_Boolean_Int64_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalMute_Public_Void_Int64_Boolean_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalVolume_Public_Byte_Int64_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalVolume_Public_Void_Int64_Byte_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_OnSettingsUpdateImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x02000243 RID: 579
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x0600211D RID: 8477 RVA: 0x0000DBD2 File Offset: 0x0000BDD2
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr);
				VoiceManager.FFIEvents.NativeFieldInfoPtr_OnSettingsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr, "OnSettingsUpdate");
			}

			// Token: 0x0600211E RID: 8478 RVA: 0x0000DC06 File Offset: 0x0000BE06
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600211F RID: 8479 RVA: 0x0000DC0F File Offset: 0x0000BE0F
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06002120 RID: 8480 RVA: 0x000974E8 File Offset: 0x000956E8
			// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000DC21 File Offset: 0x0000BE21
			public unsafe VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIEvents.NativeFieldInfoPtr_OnSettingsUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIEvents.SettingsUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIEvents.NativeFieldInfoPtr_OnSettingsUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400195D RID: 6493
			private static readonly IntPtr NativeFieldInfoPtr_OnSettingsUpdate;

			// Token: 0x0200030B RID: 779
			public sealed class SettingsUpdateHandler : MulticastDelegate
			{
				// Token: 0x06002779 RID: 10105 RVA: 0x000B09DC File Offset: 0x000AEBDC
				// Note: this type is marked as 'beforefieldinit'.
				static SettingsUpdateHandler()
				{
					Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr, "SettingsUpdateHandler");
					VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr, 100668444);
					VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr, 100668445);
					VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr, 100668446);
					VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr, 100668447);
				}

				// Token: 0x0600277A RID: 10106 RVA: 0x000B0A50 File Offset: 0x000AEC50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SettingsUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIEvents.SettingsUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600277B RID: 10107 RVA: 0x000B0AAC File Offset: 0x000AECAC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600277C RID: 10108 RVA: 0x000B0AEC File Offset: 0x000AECEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600277D RID: 10109 RVA: 0x000B0B5C File Offset: 0x000AED5C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIEvents.SettingsUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600277E RID: 10110 RVA: 0x0000FBA2 File Offset: 0x0000DDA2
				public SettingsUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600277F RID: 10111 RVA: 0x0000FBAB File Offset: 0x0000DDAB
				public static implicit operator VoiceManager.FFIEvents.SettingsUpdateHandler(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIEvents.SettingsUpdateHandler>(A_0);
				}

				// Token: 0x06002780 RID: 10112 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
				public static VoiceManager.FFIEvents.SettingsUpdateHandler operator +(VoiceManager.FFIEvents.SettingsUpdateHandler A_0, VoiceManager.FFIEvents.SettingsUpdateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIEvents.SettingsUpdateHandler>();
				}

				// Token: 0x06002781 RID: 10113 RVA: 0x0000FBC1 File Offset: 0x0000DDC1
				public static VoiceManager.FFIEvents.SettingsUpdateHandler operator -(VoiceManager.FFIEvents.SettingsUpdateHandler A_0, VoiceManager.FFIEvents.SettingsUpdateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIEvents.SettingsUpdateHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001C71 RID: 7281
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C72 RID: 7282
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x04001C73 RID: 7283
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001C74 RID: 7284
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x02000244 RID: 580
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06002122 RID: 8482 RVA: 0x00097518 File Offset: 0x00095718
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr);
				VoiceManager.FFIMethods.NativeFieldInfoPtr_GetInputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "GetInputMode");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_SetInputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetInputMode");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfMute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsSelfMute");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfMute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetSelfMute");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfDeaf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsSelfDeaf");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfDeaf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetSelfDeaf");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_IsLocalMute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsLocalMute");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalMute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetLocalMute");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_GetLocalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "GetLocalVolume");
				VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetLocalVolume");
			}

			// Token: 0x06002123 RID: 8483 RVA: 0x0000DC40 File Offset: 0x0000BE40
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002124 RID: 8484 RVA: 0x0000DC49 File Offset: 0x0000BE49
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06002125 RID: 8485 RVA: 0x0009760C File Offset: 0x0009580C
			// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000DC5B File Offset: 0x0000BE5B
			public unsafe VoiceManager.FFIMethods.GetInputModeMethod GetInputMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_GetInputMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.GetInputModeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_GetInputMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06002127 RID: 8487 RVA: 0x0009763C File Offset: 0x0009583C
			// (set) Token: 0x06002128 RID: 8488 RVA: 0x0000DC7A File Offset: 0x0000BE7A
			public unsafe VoiceManager.FFIMethods.SetInputModeMethod SetInputMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetInputMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.SetInputModeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetInputMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06002129 RID: 8489 RVA: 0x0009766C File Offset: 0x0009586C
			// (set) Token: 0x0600212A RID: 8490 RVA: 0x0000DC99 File Offset: 0x0000BE99
			public unsafe VoiceManager.FFIMethods.IsSelfMuteMethod IsSelfMute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfMute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.IsSelfMuteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfMute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x0600212B RID: 8491 RVA: 0x0009769C File Offset: 0x0009589C
			// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
			public unsafe VoiceManager.FFIMethods.SetSelfMuteMethod SetSelfMute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfMute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.SetSelfMuteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfMute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x0600212D RID: 8493 RVA: 0x000976CC File Offset: 0x000958CC
			// (set) Token: 0x0600212E RID: 8494 RVA: 0x0000DCD7 File Offset: 0x0000BED7
			public unsafe VoiceManager.FFIMethods.IsSelfDeafMethod IsSelfDeaf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfDeaf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.IsSelfDeafMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsSelfDeaf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x0600212F RID: 8495 RVA: 0x000976FC File Offset: 0x000958FC
			// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000DCF6 File Offset: 0x0000BEF6
			public unsafe VoiceManager.FFIMethods.SetSelfDeafMethod SetSelfDeaf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfDeaf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.SetSelfDeafMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetSelfDeaf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06002131 RID: 8497 RVA: 0x0009772C File Offset: 0x0009592C
			// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000DD15 File Offset: 0x0000BF15
			public unsafe VoiceManager.FFIMethods.IsLocalMuteMethod IsLocalMute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsLocalMute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.IsLocalMuteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_IsLocalMute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06002133 RID: 8499 RVA: 0x0009775C File Offset: 0x0009595C
			// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000DD34 File Offset: 0x0000BF34
			public unsafe VoiceManager.FFIMethods.SetLocalMuteMethod SetLocalMute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalMute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.SetLocalMuteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalMute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06002135 RID: 8501 RVA: 0x0009778C File Offset: 0x0009598C
			// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000DD53 File Offset: 0x0000BF53
			public unsafe VoiceManager.FFIMethods.GetLocalVolumeMethod GetLocalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_GetLocalVolume);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.GetLocalVolumeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_GetLocalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x000977BC File Offset: 0x000959BC
			// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000DD72 File Offset: 0x0000BF72
			public unsafe VoiceManager.FFIMethods.SetLocalVolumeMethod SetLocalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalVolume);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager.FFIMethods.SetLocalVolumeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoiceManager.FFIMethods.NativeFieldInfoPtr_SetLocalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400195E RID: 6494
			private static readonly IntPtr NativeFieldInfoPtr_GetInputMode;

			// Token: 0x0400195F RID: 6495
			private static readonly IntPtr NativeFieldInfoPtr_SetInputMode;

			// Token: 0x04001960 RID: 6496
			private static readonly IntPtr NativeFieldInfoPtr_IsSelfMute;

			// Token: 0x04001961 RID: 6497
			private static readonly IntPtr NativeFieldInfoPtr_SetSelfMute;

			// Token: 0x04001962 RID: 6498
			private static readonly IntPtr NativeFieldInfoPtr_IsSelfDeaf;

			// Token: 0x04001963 RID: 6499
			private static readonly IntPtr NativeFieldInfoPtr_SetSelfDeaf;

			// Token: 0x04001964 RID: 6500
			private static readonly IntPtr NativeFieldInfoPtr_IsLocalMute;

			// Token: 0x04001965 RID: 6501
			private static readonly IntPtr NativeFieldInfoPtr_SetLocalMute;

			// Token: 0x04001966 RID: 6502
			private static readonly IntPtr NativeFieldInfoPtr_GetLocalVolume;

			// Token: 0x04001967 RID: 6503
			private static readonly IntPtr NativeFieldInfoPtr_SetLocalVolume;

			// Token: 0x0200030C RID: 780
			public sealed class GetInputModeMethod : MulticastDelegate
			{
				// Token: 0x06002782 RID: 10114 RVA: 0x000B0BA0 File Offset: 0x000AEDA0
				// Note: this type is marked as 'beforefieldinit'.
				static GetInputModeMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "GetInputModeMethod");
					VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr, 100668448);
					VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr, 100668449);
					VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_InputMode_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr, 100668450);
					VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_InputMode_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr, 100668451);
				}

				// Token: 0x06002783 RID: 10115 RVA: 0x000B0C14 File Offset: 0x000AEE14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetInputModeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetInputModeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002784 RID: 10116 RVA: 0x000B0C70 File Offset: 0x000AEE70
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref InputMode inputMode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					inputMode = ((intPtr4 == 0) ? null : new InputMode(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002785 RID: 10117 RVA: 0x000B0CE8 File Offset: 0x000AEEE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55276, XrefRangeEnd = 55282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref InputMode inputMode, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_InputMode_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					inputMode = ((intPtr4 == 0) ? null : new InputMode(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002786 RID: 10118 RVA: 0x000B0D84 File Offset: 0x000AEF84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref InputMode inputMode, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetInputModeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_InputMode_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					inputMode = ((intPtr4 == 0) ? null : new InputMode(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002787 RID: 10119 RVA: 0x0000FBD2 File Offset: 0x0000DDD2
				public GetInputModeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C75 RID: 7285
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C76 RID: 7286
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_InputMode_0;

				// Token: 0x04001C77 RID: 7287
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_InputMode_AsyncCallback_Object_0;

				// Token: 0x04001C78 RID: 7288
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_InputMode_IAsyncResult_0;
			}

			// Token: 0x0200030D RID: 781
			public sealed class SetInputModeCallback : MulticastDelegate
			{
				// Token: 0x06002788 RID: 10120 RVA: 0x000B0E00 File Offset: 0x000AF000
				// Note: this type is marked as 'beforefieldinit'.
				static SetInputModeCallback()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetInputModeCallback");
					VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr, 100668452);
					VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr, 100668453);
					VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr, 100668454);
					VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr, 100668455);
				}

				// Token: 0x06002789 RID: 10121 RVA: 0x000B0E74 File Offset: 0x000AF074
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetInputModeCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600278A RID: 10122 RVA: 0x000B0ED0 File Offset: 0x000AF0D0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600278B RID: 10123 RVA: 0x000B0F20 File Offset: 0x000AF120
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55282, XrefRangeEnd = 55288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600278C RID: 10124 RVA: 0x000B0FA4 File Offset: 0x000AF1A4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600278D RID: 10125 RVA: 0x0000FBDB File Offset: 0x0000DDDB
				public SetInputModeCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600278E RID: 10126 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
				public static implicit operator VoiceManager.FFIMethods.SetInputModeCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetInputModeCallback>(A_0);
				}

				// Token: 0x0600278F RID: 10127 RVA: 0x0000FBEC File Offset: 0x0000DDEC
				public static VoiceManager.FFIMethods.SetInputModeCallback operator +(VoiceManager.FFIMethods.SetInputModeCallback A_0, VoiceManager.FFIMethods.SetInputModeCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetInputModeCallback>();
				}

				// Token: 0x06002790 RID: 10128 RVA: 0x0000FBFA File Offset: 0x0000DDFA
				public static VoiceManager.FFIMethods.SetInputModeCallback operator -(VoiceManager.FFIMethods.SetInputModeCallback A_0, VoiceManager.FFIMethods.SetInputModeCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetInputModeCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001C79 RID: 7289
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C7A RID: 7290
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001C7B RID: 7291
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001C7C RID: 7292
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200030E RID: 782
			public sealed class SetInputModeMethod : MulticastDelegate
			{
				// Token: 0x06002791 RID: 10129 RVA: 0x000B0FE8 File Offset: 0x000AF1E8
				// Note: this type is marked as 'beforefieldinit'.
				static SetInputModeMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetInputModeMethod");
					VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr, 100668456);
					VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_InputMode_IntPtr_SetInputModeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr, 100668457);
					VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_InputMode_IntPtr_SetInputModeCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr, 100668458);
					VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr, 100668459);
				}

				// Token: 0x06002792 RID: 10130 RVA: 0x000B105C File Offset: 0x000AF25C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55288, XrefRangeEnd = 55291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetInputModeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetInputModeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002793 RID: 10131 RVA: 0x000B10B8 File Offset: 0x000AF2B8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_InputMode_IntPtr_SetInputModeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002794 RID: 10132 RVA: 0x000B112C File Offset: 0x000AF32C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55291, XrefRangeEnd = 55299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMode);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_InputMode_IntPtr_SetInputModeCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002795 RID: 10133 RVA: 0x000B11D4 File Offset: 0x000AF3D4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetInputModeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002796 RID: 10134 RVA: 0x0000FC0B File Offset: 0x0000DE0B
				public SetInputModeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002797 RID: 10135 RVA: 0x0000FC14 File Offset: 0x0000DE14
				public static implicit operator VoiceManager.FFIMethods.SetInputModeMethod(Action<IntPtr, InputMode, IntPtr, VoiceManager.FFIMethods.SetInputModeCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetInputModeMethod>(A_0);
				}

				// Token: 0x06002798 RID: 10136 RVA: 0x0000FC1C File Offset: 0x0000DE1C
				public static VoiceManager.FFIMethods.SetInputModeMethod operator +(VoiceManager.FFIMethods.SetInputModeMethod A_0, VoiceManager.FFIMethods.SetInputModeMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetInputModeMethod>();
				}

				// Token: 0x06002799 RID: 10137 RVA: 0x0000FC2A File Offset: 0x0000DE2A
				public static VoiceManager.FFIMethods.SetInputModeMethod operator -(VoiceManager.FFIMethods.SetInputModeMethod A_0, VoiceManager.FFIMethods.SetInputModeMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetInputModeMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C7D RID: 7293
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C7E RID: 7294
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_InputMode_IntPtr_SetInputModeCallback_0;

				// Token: 0x04001C7F RID: 7295
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_InputMode_IntPtr_SetInputModeCallback_AsyncCallback_Object_0;

				// Token: 0x04001C80 RID: 7296
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200030F RID: 783
			public sealed class IsSelfMuteMethod : MulticastDelegate
			{
				// Token: 0x0600279A RID: 10138 RVA: 0x000B1218 File Offset: 0x000AF418
				// Note: this type is marked as 'beforefieldinit'.
				static IsSelfMuteMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsSelfMuteMethod");
					VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr, 100668460);
					VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr, 100668461);
					VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr, 100668462);
					VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr, 100668463);
				}

				// Token: 0x0600279B RID: 10139 RVA: 0x000B128C File Offset: 0x000AF48C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsSelfMuteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfMuteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600279C RID: 10140 RVA: 0x000B12E8 File Offset: 0x000AF4E8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref bool mute)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mute;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600279D RID: 10141 RVA: 0x000B1344 File Offset: 0x000AF544
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool mute, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mute;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600279E RID: 10142 RVA: 0x000B13C4 File Offset: 0x000AF5C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool mute, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &mute;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600279F RID: 10143 RVA: 0x0000FC3B File Offset: 0x0000DE3B
				public IsSelfMuteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C81 RID: 7297
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C82 RID: 7298
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0;

				// Token: 0x04001C83 RID: 7299
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C84 RID: 7300
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000310 RID: 784
			public sealed class SetSelfMuteMethod : MulticastDelegate
			{
				// Token: 0x060027A0 RID: 10144 RVA: 0x000B1424 File Offset: 0x000AF624
				// Note: this type is marked as 'beforefieldinit'.
				static SetSelfMuteMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetSelfMuteMethod");
					VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr, 100668464);
					VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr, 100668465);
					VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr, 100668466);
					VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr, 100668467);
				}

				// Token: 0x060027A1 RID: 10145 RVA: 0x000B1498 File Offset: 0x000AF698
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetSelfMuteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfMuteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027A2 RID: 10146 RVA: 0x000B14F4 File Offset: 0x000AF6F4
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, bool mute)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027A3 RID: 10147 RVA: 0x000B1550 File Offset: 0x000AF750
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, bool mute, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027A4 RID: 10148 RVA: 0x000B15D0 File Offset: 0x000AF7D0
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060027A5 RID: 10149 RVA: 0x0000FC44 File Offset: 0x0000DE44
				public SetSelfMuteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027A6 RID: 10150 RVA: 0x0000FC4D File Offset: 0x0000DE4D
				public static implicit operator VoiceManager.FFIMethods.SetSelfMuteMethod(Func<IntPtr, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetSelfMuteMethod>(A_0);
				}

				// Token: 0x060027A7 RID: 10151 RVA: 0x0000FC55 File Offset: 0x0000DE55
				public static VoiceManager.FFIMethods.SetSelfMuteMethod operator +(VoiceManager.FFIMethods.SetSelfMuteMethod A_0, VoiceManager.FFIMethods.SetSelfMuteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetSelfMuteMethod>();
				}

				// Token: 0x060027A8 RID: 10152 RVA: 0x0000FC63 File Offset: 0x0000DE63
				public static VoiceManager.FFIMethods.SetSelfMuteMethod operator -(VoiceManager.FFIMethods.SetSelfMuteMethod A_0, VoiceManager.FFIMethods.SetSelfMuteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetSelfMuteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C85 RID: 7301
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C86 RID: 7302
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0;

				// Token: 0x04001C87 RID: 7303
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C88 RID: 7304
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000311 RID: 785
			public sealed class IsSelfDeafMethod : MulticastDelegate
			{
				// Token: 0x060027A9 RID: 10153 RVA: 0x000B1620 File Offset: 0x000AF820
				// Note: this type is marked as 'beforefieldinit'.
				static IsSelfDeafMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsSelfDeafMethod");
					VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr, 100668468);
					VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr, 100668469);
					VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr, 100668470);
					VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr, 100668471);
				}

				// Token: 0x060027AA RID: 10154 RVA: 0x000B1694 File Offset: 0x000AF894
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsSelfDeafMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsSelfDeafMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027AB RID: 10155 RVA: 0x000B16F0 File Offset: 0x000AF8F0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref bool deaf)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &deaf;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027AC RID: 10156 RVA: 0x000B174C File Offset: 0x000AF94C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool deaf, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &deaf;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027AD RID: 10157 RVA: 0x000B17CC File Offset: 0x000AF9CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool deaf, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &deaf;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsSelfDeafMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027AE RID: 10158 RVA: 0x0000FC74 File Offset: 0x0000DE74
				public IsSelfDeafMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C89 RID: 7305
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C8A RID: 7306
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_Boolean_0;

				// Token: 0x04001C8B RID: 7307
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C8C RID: 7308
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000312 RID: 786
			public sealed class SetSelfDeafMethod : MulticastDelegate
			{
				// Token: 0x060027AF RID: 10159 RVA: 0x000B182C File Offset: 0x000AFA2C
				// Note: this type is marked as 'beforefieldinit'.
				static SetSelfDeafMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetSelfDeafMethod");
					VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr, 100668472);
					VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr, 100668473);
					VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr, 100668474);
					VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr, 100668475);
				}

				// Token: 0x060027B0 RID: 10160 RVA: 0x000B18A0 File Offset: 0x000AFAA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetSelfDeafMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetSelfDeafMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027B1 RID: 10161 RVA: 0x000B18FC File Offset: 0x000AFAFC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, bool deaf)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deaf;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027B2 RID: 10162 RVA: 0x000B1958 File Offset: 0x000AFB58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, bool deaf, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deaf;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027B3 RID: 10163 RVA: 0x000B19D8 File Offset: 0x000AFBD8
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetSelfDeafMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060027B4 RID: 10164 RVA: 0x0000FC7D File Offset: 0x0000DE7D
				public SetSelfDeafMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027B5 RID: 10165 RVA: 0x0000FC86 File Offset: 0x0000DE86
				public static implicit operator VoiceManager.FFIMethods.SetSelfDeafMethod(Func<IntPtr, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetSelfDeafMethod>(A_0);
				}

				// Token: 0x060027B6 RID: 10166 RVA: 0x0000FC8E File Offset: 0x0000DE8E
				public static VoiceManager.FFIMethods.SetSelfDeafMethod operator +(VoiceManager.FFIMethods.SetSelfDeafMethod A_0, VoiceManager.FFIMethods.SetSelfDeafMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetSelfDeafMethod>();
				}

				// Token: 0x060027B7 RID: 10167 RVA: 0x0000FC9C File Offset: 0x0000DE9C
				public static VoiceManager.FFIMethods.SetSelfDeafMethod operator -(VoiceManager.FFIMethods.SetSelfDeafMethod A_0, VoiceManager.FFIMethods.SetSelfDeafMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetSelfDeafMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C8D RID: 7309
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C8E RID: 7310
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0;

				// Token: 0x04001C8F RID: 7311
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C90 RID: 7312
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000313 RID: 787
			public sealed class IsLocalMuteMethod : MulticastDelegate
			{
				// Token: 0x060027B8 RID: 10168 RVA: 0x000B1A28 File Offset: 0x000AFC28
				// Note: this type is marked as 'beforefieldinit'.
				static IsLocalMuteMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "IsLocalMuteMethod");
					VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr, 100668476);
					VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr, 100668477);
					VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr, 100668478);
					VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr, 100668479);
				}

				// Token: 0x060027B9 RID: 10169 RVA: 0x000B1A9C File Offset: 0x000AFC9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsLocalMuteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.IsLocalMuteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027BA RID: 10170 RVA: 0x000B1AF8 File Offset: 0x000AFCF8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userId, ref bool mute)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mute;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027BB RID: 10171 RVA: 0x000B1B60 File Offset: 0x000AFD60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref bool mute, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mute;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027BC RID: 10172 RVA: 0x000B1BF0 File Offset: 0x000AFDF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool mute, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &mute;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.IsLocalMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027BD RID: 10173 RVA: 0x0000FCAD File Offset: 0x0000DEAD
				public IsLocalMuteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C91 RID: 7313
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C92 RID: 7314
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Boolean_0;

				// Token: 0x04001C93 RID: 7315
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C94 RID: 7316
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000314 RID: 788
			public sealed class SetLocalMuteMethod : MulticastDelegate
			{
				// Token: 0x060027BE RID: 10174 RVA: 0x000B1C50 File Offset: 0x000AFE50
				// Note: this type is marked as 'beforefieldinit'.
				static SetLocalMuteMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetLocalMuteMethod");
					VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr, 100668480);
					VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr, 100668481);
					VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr, 100668482);
					VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr, 100668483);
				}

				// Token: 0x060027BF RID: 10175 RVA: 0x000B1CC4 File Offset: 0x000AFEC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLocalMuteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalMuteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027C0 RID: 10176 RVA: 0x000B1D20 File Offset: 0x000AFF20
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userId, bool mute)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027C1 RID: 10177 RVA: 0x000B1D88 File Offset: 0x000AFF88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55299, XrefRangeEnd = 55306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, bool mute, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027C2 RID: 10178 RVA: 0x000B1E18 File Offset: 0x000B0018
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalMuteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060027C3 RID: 10179 RVA: 0x0000FCB6 File Offset: 0x0000DEB6
				public SetLocalMuteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027C4 RID: 10180 RVA: 0x0000FCBF File Offset: 0x0000DEBF
				public static implicit operator VoiceManager.FFIMethods.SetLocalMuteMethod(Func<IntPtr, long, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetLocalMuteMethod>(A_0);
				}

				// Token: 0x060027C5 RID: 10181 RVA: 0x0000FCC7 File Offset: 0x0000DEC7
				public static VoiceManager.FFIMethods.SetLocalMuteMethod operator +(VoiceManager.FFIMethods.SetLocalMuteMethod A_0, VoiceManager.FFIMethods.SetLocalMuteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetLocalMuteMethod>();
				}

				// Token: 0x060027C6 RID: 10182 RVA: 0x0000FCD5 File Offset: 0x0000DED5
				public static VoiceManager.FFIMethods.SetLocalMuteMethod operator -(VoiceManager.FFIMethods.SetLocalMuteMethod A_0, VoiceManager.FFIMethods.SetLocalMuteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetLocalMuteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C95 RID: 7317
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C96 RID: 7318
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Boolean_0;

				// Token: 0x04001C97 RID: 7319
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001C98 RID: 7320
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000315 RID: 789
			public sealed class GetLocalVolumeMethod : MulticastDelegate
			{
				// Token: 0x060027C7 RID: 10183 RVA: 0x000B1E68 File Offset: 0x000B0068
				// Note: this type is marked as 'beforefieldinit'.
				static GetLocalVolumeMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "GetLocalVolumeMethod");
					VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr, 100668484);
					VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr, 100668485);
					VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr, 100668486);
					VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Byte_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr, 100668487);
				}

				// Token: 0x060027C8 RID: 10184 RVA: 0x000B1EDC File Offset: 0x000B00DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLocalVolumeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.GetLocalVolumeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027C9 RID: 10185 RVA: 0x000B1F38 File Offset: 0x000B0138
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userId, ref byte volume)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &volume;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027CA RID: 10186 RVA: 0x000B1FA0 File Offset: 0x000B01A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55306, XrefRangeEnd = 55313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref byte volume, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &volume;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027CB RID: 10187 RVA: 0x000B2030 File Offset: 0x000B0230
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref byte volume, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &volume;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.GetLocalVolumeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Byte_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027CC RID: 10188 RVA: 0x0000FCE6 File Offset: 0x0000DEE6
				public GetLocalVolumeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001C99 RID: 7321
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C9A RID: 7322
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Byte_0;

				// Token: 0x04001C9B RID: 7323
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Byte_AsyncCallback_Object_0;

				// Token: 0x04001C9C RID: 7324
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Byte_IAsyncResult_0;
			}

			// Token: 0x02000316 RID: 790
			public sealed class SetLocalVolumeMethod : MulticastDelegate
			{
				// Token: 0x060027CD RID: 10189 RVA: 0x000B2090 File Offset: 0x000B0290
				// Note: this type is marked as 'beforefieldinit'.
				static SetLocalVolumeMethod()
				{
					Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager.FFIMethods>.NativeClassPtr, "SetLocalVolumeMethod");
					VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr, 100668488);
					VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr, 100668489);
					VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr, 100668490);
					VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr, 100668491);
				}

				// Token: 0x060027CE RID: 10190 RVA: 0x000B2104 File Offset: 0x000B0304
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLocalVolumeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.FFIMethods.SetLocalVolumeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027CF RID: 10191 RVA: 0x000B2160 File Offset: 0x000B0360
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userId, byte volume)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060027D0 RID: 10192 RVA: 0x000B21C8 File Offset: 0x000B03C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55313, XrefRangeEnd = 55320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, byte volume, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027D1 RID: 10193 RVA: 0x000B2258 File Offset: 0x000B0458
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.FFIMethods.SetLocalVolumeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060027D2 RID: 10194 RVA: 0x0000FCEF File Offset: 0x0000DEEF
				public SetLocalVolumeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027D3 RID: 10195 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
				public static implicit operator VoiceManager.FFIMethods.SetLocalVolumeMethod(Func<IntPtr, long, byte, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<VoiceManager.FFIMethods.SetLocalVolumeMethod>(A_0);
				}

				// Token: 0x060027D4 RID: 10196 RVA: 0x0000FD00 File Offset: 0x0000DF00
				public static VoiceManager.FFIMethods.SetLocalVolumeMethod operator +(VoiceManager.FFIMethods.SetLocalVolumeMethod A_0, VoiceManager.FFIMethods.SetLocalVolumeMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<VoiceManager.FFIMethods.SetLocalVolumeMethod>();
				}

				// Token: 0x060027D5 RID: 10197 RVA: 0x0000FD0E File Offset: 0x0000DF0E
				public static VoiceManager.FFIMethods.SetLocalVolumeMethod operator -(VoiceManager.FFIMethods.SetLocalVolumeMethod A_0, VoiceManager.FFIMethods.SetLocalVolumeMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<VoiceManager.FFIMethods.SetLocalVolumeMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001C9D RID: 7325
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001C9E RID: 7326
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_0;

				// Token: 0x04001C9F RID: 7327
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_AsyncCallback_Object_0;

				// Token: 0x04001CA0 RID: 7328
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}

		// Token: 0x02000245 RID: 581
		public sealed class SetInputModeHandler : MulticastDelegate
		{
			// Token: 0x06002139 RID: 8505 RVA: 0x000977EC File Offset: 0x000959EC
			// Note: this type is marked as 'beforefieldinit'.
			static SetInputModeHandler()
			{
				Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "SetInputModeHandler");
				VoiceManager.SetInputModeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr, 100668492);
				VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr, 100668493);
				VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr, 100668494);
				VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr, 100668495);
			}

			// Token: 0x0600213A RID: 8506 RVA: 0x00097860 File Offset: 0x00095A60
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetInputModeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.SetInputModeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SetInputModeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600213B RID: 8507 RVA: 0x000978BC File Offset: 0x00095ABC
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x00097900 File Offset: 0x00095B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55320, XrefRangeEnd = 55324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600213D RID: 8509 RVA: 0x00097974 File Offset: 0x00095B74
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SetInputModeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600213E RID: 8510 RVA: 0x0000DD91 File Offset: 0x0000BF91
			public SetInputModeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600213F RID: 8511 RVA: 0x0000DD9A File Offset: 0x0000BF9A
			public static implicit operator VoiceManager.SetInputModeHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<VoiceManager.SetInputModeHandler>(A_0);
			}

			// Token: 0x06002140 RID: 8512 RVA: 0x0000DDA2 File Offset: 0x0000BFA2
			public static VoiceManager.SetInputModeHandler operator +(VoiceManager.SetInputModeHandler A_0, VoiceManager.SetInputModeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VoiceManager.SetInputModeHandler>();
			}

			// Token: 0x06002141 RID: 8513 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
			public static VoiceManager.SetInputModeHandler operator -(VoiceManager.SetInputModeHandler A_0, VoiceManager.SetInputModeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VoiceManager.SetInputModeHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001968 RID: 6504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001969 RID: 6505
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400196A RID: 6506
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400196B RID: 6507
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000246 RID: 582
		public sealed class SettingsUpdateHandler : MulticastDelegate
		{
			// Token: 0x06002142 RID: 8514 RVA: 0x000979B8 File Offset: 0x00095BB8
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsUpdateHandler()
			{
				Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceManager>.NativeClassPtr, "SettingsUpdateHandler");
				VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr, 100668496);
				VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr, 100668497);
				VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr, 100668498);
				VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr, 100668499);
			}

			// Token: 0x06002143 RID: 8515 RVA: 0x00097A2C File Offset: 0x00095C2C
			[CallerCount(247)]
			[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14625, XrefRangeEnd = 14872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceManager.SettingsUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002144 RID: 8516 RVA: 0x00097A88 File Offset: 0x00095C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002145 RID: 8517 RVA: 0x00097ABC File Offset: 0x00095CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002146 RID: 8518 RVA: 0x00097B20 File Offset: 0x00095D20
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoiceManager.SettingsUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002147 RID: 8519 RVA: 0x0000DDC1 File Offset: 0x0000BFC1
			public SettingsUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002148 RID: 8520 RVA: 0x0000DDCA File Offset: 0x0000BFCA
			public static implicit operator VoiceManager.SettingsUpdateHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<VoiceManager.SettingsUpdateHandler>(A_0);
			}

			// Token: 0x06002149 RID: 8521 RVA: 0x0000DDD2 File Offset: 0x0000BFD2
			public static VoiceManager.SettingsUpdateHandler operator +(VoiceManager.SettingsUpdateHandler A_0, VoiceManager.SettingsUpdateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VoiceManager.SettingsUpdateHandler>();
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
			public static VoiceManager.SettingsUpdateHandler operator -(VoiceManager.SettingsUpdateHandler A_0, VoiceManager.SettingsUpdateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VoiceManager.SettingsUpdateHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400196C RID: 6508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400196D RID: 6509
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400196E RID: 6510
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400196F RID: 6511
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
