using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A2 RID: 674
	public class PlayerGUI : Instance
	{
		// Token: 0x06003921 RID: 14625 RVA: 0x00102A30 File Offset: 0x00100C30
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerGUI()
		{
			Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "PlayerGUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr);
			PlayerGUI.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, "canvasGroup");
			PlayerGUI.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, "interactable");
			PlayerGUI.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, "opacity");
			PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_interactable");
			PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_opacity");
			PlayerGUI.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672022);
			PlayerGUI.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672023);
			PlayerGUI.NativeMethodInfoPtr_get_Opacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672024);
			PlayerGUI.NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672025);
			PlayerGUI.NativeMethodInfoPtr_get_Networkinteractable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672032);
			PlayerGUI.NativeMethodInfoPtr_set_Networkinteractable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672033);
			PlayerGUI.NativeMethodInfoPtr_get_Networkopacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672034);
			PlayerGUI.NativeMethodInfoPtr_set_Networkopacity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672035);
			PlayerGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672030);
			PlayerGUI.NativeMethodInfoPtr_SyncSetInteractable_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672026);
			PlayerGUI.NativeMethodInfoPtr_SyncSetOpacity_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672027);
			PlayerGUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672028);
			PlayerGUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672029);
			PlayerGUI.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672031);
			PlayerGUI.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672036);
			PlayerGUI.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr, 100672037);
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00102C04 File Offset: 0x00100E04
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x00102C40 File Offset: 0x00100E40
		public unsafe bool Interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116265, RefRangeEnd = 116266, XrefRangeStart = 116260, XrefRangeEnd = 116265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x00102C80 File Offset: 0x00100E80
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x00102CBC File Offset: 0x00100EBC
		public unsafe float Opacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_get_Opacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116271, RefRangeEnd = 116272, XrefRangeStart = 116266, XrefRangeEnd = 116271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x00102CFC File Offset: 0x00100EFC
		// (set) Token: 0x06003927 RID: 14631 RVA: 0x00102D38 File Offset: 0x00100F38
		public unsafe bool Networkinteractable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_get_Networkinteractable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116272, XrefRangeEnd = 116275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_set_Networkinteractable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x00102D78 File Offset: 0x00100F78
		// (set) Token: 0x06003929 RID: 14633 RVA: 0x00102DB4 File Offset: 0x00100FB4
		public unsafe float Networkopacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_get_Networkopacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116275, XrefRangeEnd = 116278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_set_Networkopacity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00102DF4 File Offset: 0x00100FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116278, XrefRangeEnd = 116296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerGUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerGUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00102E30 File Offset: 0x00101030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116296, XrefRangeEnd = 116301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetInteractable(bool oldValue, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_SyncSetInteractable_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00102E7C File Offset: 0x0010107C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116301, XrefRangeEnd = 116306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetOpacity(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerGUI.NativeMethodInfoPtr_SyncSetOpacity_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00102EC8 File Offset: 0x001010C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116306, XrefRangeEnd = 116311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerGUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x00102F04 File Offset: 0x00101104
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerGUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x00102F40 File Offset: 0x00101140
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerGUI.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x00102F88 File Offset: 0x00101188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116311, XrefRangeEnd = 116317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerGUI.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00102FE4 File Offset: 0x001011E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116317, XrefRangeEnd = 116331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerGUI.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x000163CB File Offset: 0x000145CB
		public PlayerGUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x00103040 File Offset: 0x00101240
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x000163D4 File Offset: 0x000145D4
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00103070 File Offset: 0x00101270
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x000163F3 File Offset: 0x000145F3
		public unsafe bool interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_interactable)) = value;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x00103098 File Offset: 0x00101298
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0001640E File Offset: 0x0001460E
		public unsafe float opacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_opacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr_opacity)) = value;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x001030C0 File Offset: 0x001012C0
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x00016429 File Offset: 0x00014629
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x001030F0 File Offset: 0x001012F0
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x00016448 File Offset: 0x00014648
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_opacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_opacity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerGUI.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_opacity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeFieldInfoPtr_opacity;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_interactable;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_opacity;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_get_Opacity_Public_get_Single_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_set_Opacity_Public_set_Void_Single_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkinteractable_Public_get_Boolean_0;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkinteractable_Public_set_Void_Boolean_0;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkopacity_Public_get_Single_0;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkopacity_Public_set_Void_Single_0;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetInteractable_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetOpacity_Private_Void_Single_Single_0;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
