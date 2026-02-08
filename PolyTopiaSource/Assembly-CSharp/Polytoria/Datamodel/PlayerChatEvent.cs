using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029F RID: 671
	public class PlayerChatEvent : Object
	{
		// Token: 0x060038CA RID: 14538 RVA: 0x001013D0 File Offset: 0x000FF5D0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerChatEvent()
		{
			Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "PlayerChatEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr);
			PlayerChatEvent.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, "<Player>k__BackingField");
			PlayerChatEvent.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, "<Message>k__BackingField");
			PlayerChatEvent.NativeFieldInfoPtr__Canceled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, "<Canceled>k__BackingField");
			PlayerChatEvent.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671964);
			PlayerChatEvent.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671965);
			PlayerChatEvent.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671966);
			PlayerChatEvent.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671967);
			PlayerChatEvent.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671968);
			PlayerChatEvent.NativeMethodInfoPtr_set_Canceled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671969);
			PlayerChatEvent.NativeMethodInfoPtr__ctor_Public_Void_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr, 100671970);
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x001014C8 File Offset: 0x000FF6C8
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x00101508 File Offset: 0x000FF708
		public unsafe Player Player
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x0010154C File Offset: 0x000FF74C
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x00101584 File Offset: 0x000FF784
		public unsafe string Message
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x001015C8 File Offset: 0x000FF7C8
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x00101604 File Offset: 0x000FF804
		public unsafe bool Canceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr_set_Canceled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00101644 File Offset: 0x000FF844
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 33819, RefRangeEnd = 33846, XrefRangeStart = 33819, XrefRangeEnd = 33846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerChatEvent(Player player, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerChatEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerChatEvent.NativeMethodInfoPtr__ctor_Public_Void_Player_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0001624E File Offset: 0x0001444E
		public PlayerChatEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x001016A4 File Offset: 0x000FF8A4
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x00016257 File Offset: 0x00014457
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001016D4 File Offset: 0x000FF8D4
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x00016276 File Offset: 0x00014476
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x001016FC File Offset: 0x000FF8FC
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x00016295 File Offset: 0x00014495
		public unsafe bool _Canceled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Canceled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerChatEvent.NativeFieldInfoPtr__Canceled_k__BackingField)) = value;
			}
		}

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeFieldInfoPtr__Canceled_k__BackingField;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Private_set_Void_String_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_set_Canceled_Public_set_Void_Boolean_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_String_0;
	}
}
