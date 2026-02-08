using System;
using GLTFast;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using Polytoria.Datamodel;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000322 RID: 802
	public class AppearanceController : MonoBehaviour
	{
		// Token: 0x0600447C RID: 17532 RVA: 0x00132F10 File Offset: 0x00131110
		// Note: this type is marked as 'beforefieldinit'.
		static AppearanceController()
		{
			Il2CppClassPointerStore<AppearanceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "AppearanceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr);
			AppearanceController.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, "<Instance>k__BackingField");
			AppearanceController.NativeFieldInfoPtr_playerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, "playerQueue");
			AppearanceController.NativeFieldInfoPtr_isProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, "isProcessing");
			AppearanceController.NativeMethodInfoPtr_get_Instance_Public_Static_get_AppearanceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674128);
			AppearanceController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AppearanceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674129);
			AppearanceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674134);
			AppearanceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674130);
			AppearanceController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674131);
			AppearanceController.NativeMethodInfoPtr_ProcessPlayerAppearance_Private_IEnumerator_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674132);
			AppearanceController.NativeMethodInfoPtr_AddPlayerToQueue_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, 100674133);
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x00133008 File Offset: 0x00131208
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x0013303C File Offset: 0x0013123C
		public unsafe static AppearanceController Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130963, XrefRangeEnd = 130965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_get_Instance_Public_Static_get_AppearanceController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppearanceController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130965, XrefRangeEnd = 130969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AppearanceController_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00133074 File Offset: 0x00131274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130969, XrefRangeEnd = 130977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppearanceController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x001330B0 File Offset: 0x001312B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130977, XrefRangeEnd = 130981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x001330E4 File Offset: 0x001312E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130981, XrefRangeEnd = 130992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00133118 File Offset: 0x00131318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130992, XrefRangeEnd = 130998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessPlayerAppearance(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_ProcessPlayerAppearance_Private_IEnumerator_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00133168 File Offset: 0x00131368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130998, XrefRangeEnd = 131002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToQueue(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.NativeMethodInfoPtr_AddPlayerToQueue_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x0001938F File Offset: 0x0001758F
		public AppearanceController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x001331AC File Offset: 0x001313AC
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x00019398 File Offset: 0x00017598
		public unsafe static AppearanceController _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppearanceController.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppearanceController.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x001331D4 File Offset: 0x001313D4
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x000193AA File Offset: 0x000175AA
		public unsafe Queue<Player> playerQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.NativeFieldInfoPtr_playerQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.NativeFieldInfoPtr_playerQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00133204 File Offset: 0x00131404
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x000193C9 File Offset: 0x000175C9
		public unsafe bool isProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.NativeFieldInfoPtr_isProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.NativeFieldInfoPtr_isProcessing)) = value;
			}
		}

		// Token: 0x04003544 RID: 13636
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04003545 RID: 13637
		private static readonly IntPtr NativeFieldInfoPtr_playerQueue;

		// Token: 0x04003546 RID: 13638
		private static readonly IntPtr NativeFieldInfoPtr_isProcessing;

		// Token: 0x04003547 RID: 13639
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AppearanceController_0;

		// Token: 0x04003548 RID: 13640
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AppearanceController_0;

		// Token: 0x04003549 RID: 13641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400354A RID: 13642
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400354B RID: 13643
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400354C RID: 13644
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPlayerAppearance_Private_IEnumerator_Player_0;

		// Token: 0x0400354D RID: 13645
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToQueue_Public_Void_Player_0;

		// Token: 0x02000420 RID: 1056
		[ObfuscatedName("Polytoria.Controllers.AppearanceController+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600511E RID: 20766 RVA: 0x0015B4E0 File Offset: 0x001596E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr);
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_headObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "headObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftArmObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "leftArmObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightArmObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "rightArmObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_torsoObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "torsoObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftLegObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "leftLegObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightLegObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "rightLegObj");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "<>9__1");
				AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, "<>9__2");
				AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, 100674135);
				AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__0_Internal_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, 100674136);
				AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__1_Internal_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, 100674137);
				AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__2_Internal_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr, 100674138);
			}

			// Token: 0x0600511F RID: 20767 RVA: 0x0015B610 File Offset: 0x00159810
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceController.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005120 RID: 20768 RVA: 0x0015B64C File Offset: 0x0015984C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130600, XrefRangeEnd = 130608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPlayerAppearance_b__0(ImageCacheKey key, ImageCacheEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__0_Internal_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005121 RID: 20769 RVA: 0x0015B6A0 File Offset: 0x001598A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130608, XrefRangeEnd = 130623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPlayerAppearance_b__1(ImageCacheKey key, ImageCacheEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__1_Internal_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005122 RID: 20770 RVA: 0x0015B6F4 File Offset: 0x001598F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130623, XrefRangeEnd = 130641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPlayerAppearance_b__2(ImageCacheKey key, ImageCacheEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController.__c__DisplayClass8_0.NativeMethodInfoPtr__ProcessPlayerAppearance_b__2_Internal_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005123 RID: 20771 RVA: 0x0001F188 File Offset: 0x0001D388
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B57 RID: 6999
			// (get) Token: 0x06005124 RID: 20772 RVA: 0x0015B748 File Offset: 0x00159948
			// (set) Token: 0x06005125 RID: 20773 RVA: 0x0001F191 File Offset: 0x0001D391
			public unsafe Transform headObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_headObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_headObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B58 RID: 7000
			// (get) Token: 0x06005126 RID: 20774 RVA: 0x0015B778 File Offset: 0x00159978
			// (set) Token: 0x06005127 RID: 20775 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
			public unsafe Transform leftArmObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftArmObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftArmObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B59 RID: 7001
			// (get) Token: 0x06005128 RID: 20776 RVA: 0x0015B7A8 File Offset: 0x001599A8
			// (set) Token: 0x06005129 RID: 20777 RVA: 0x0001F1CF File Offset: 0x0001D3CF
			public unsafe Transform rightArmObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightArmObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightArmObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5A RID: 7002
			// (get) Token: 0x0600512A RID: 20778 RVA: 0x0015B7D8 File Offset: 0x001599D8
			// (set) Token: 0x0600512B RID: 20779 RVA: 0x0001F1EE File Offset: 0x0001D3EE
			public unsafe Transform torsoObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_torsoObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_torsoObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5B RID: 7003
			// (get) Token: 0x0600512C RID: 20780 RVA: 0x0015B808 File Offset: 0x00159A08
			// (set) Token: 0x0600512D RID: 20781 RVA: 0x0001F20D File Offset: 0x0001D40D
			public unsafe Transform leftLegObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftLegObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_leftLegObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5C RID: 7004
			// (get) Token: 0x0600512E RID: 20782 RVA: 0x0015B838 File Offset: 0x00159A38
			// (set) Token: 0x0600512F RID: 20783 RVA: 0x0001F22C File Offset: 0x0001D42C
			public unsafe Transform rightLegObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightLegObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr_rightLegObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5D RID: 7005
			// (get) Token: 0x06005130 RID: 20784 RVA: 0x0015B868 File Offset: 0x00159A68
			// (set) Token: 0x06005131 RID: 20785 RVA: 0x0001F24B File Offset: 0x0001D44B
			public unsafe Action<ImageCacheKey, ImageCacheEntry> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageCacheKey, ImageCacheEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5E RID: 7006
			// (get) Token: 0x06005132 RID: 20786 RVA: 0x0015B898 File Offset: 0x00159A98
			// (set) Token: 0x06005133 RID: 20787 RVA: 0x0001F26A File Offset: 0x0001D46A
			public unsafe Action<ImageCacheKey, ImageCacheEntry> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageCacheKey, ImageCacheEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5F RID: 7007
			// (get) Token: 0x06005134 RID: 20788 RVA: 0x0015B8C8 File Offset: 0x00159AC8
			// (set) Token: 0x06005135 RID: 20789 RVA: 0x0001F289 File Offset: 0x0001D489
			public unsafe Action<ImageCacheKey, ImageCacheEntry> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageCacheKey, ImageCacheEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E5E RID: 15966
			private static readonly IntPtr NativeFieldInfoPtr_headObj;

			// Token: 0x04003E5F RID: 15967
			private static readonly IntPtr NativeFieldInfoPtr_leftArmObj;

			// Token: 0x04003E60 RID: 15968
			private static readonly IntPtr NativeFieldInfoPtr_rightArmObj;

			// Token: 0x04003E61 RID: 15969
			private static readonly IntPtr NativeFieldInfoPtr_torsoObj;

			// Token: 0x04003E62 RID: 15970
			private static readonly IntPtr NativeFieldInfoPtr_leftLegObj;

			// Token: 0x04003E63 RID: 15971
			private static readonly IntPtr NativeFieldInfoPtr_rightLegObj;

			// Token: 0x04003E64 RID: 15972
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04003E65 RID: 15973
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04003E66 RID: 15974
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04003E67 RID: 15975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003E68 RID: 15976
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPlayerAppearance_b__0_Internal_Void_ImageCacheKey_ImageCacheEntry_0;

			// Token: 0x04003E69 RID: 15977
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPlayerAppearance_b__1_Internal_Void_ImageCacheKey_ImageCacheEntry_0;

			// Token: 0x04003E6A RID: 15978
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPlayerAppearance_b__2_Internal_Void_ImageCacheKey_ImageCacheEntry_0;
		}

		// Token: 0x02000421 RID: 1057
		[ObfuscatedName("Polytoria.Controllers.AppearanceController+<ProcessPlayerAppearance>d__8")]
		public sealed class _ProcessPlayerAppearance_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06005136 RID: 20790 RVA: 0x0015B8F8 File Offset: 0x00159AF8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessPlayerAppearance_d__8()
			{
				Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppearanceController>.NativeClassPtr, "<ProcessPlayerAppearance>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<>1__state");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<>2__current");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "player");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<>8__1");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<>4__this");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<uwr>5__2");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<>7__wrap2");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__hat_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<hat>5__4");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__gltf_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<gltf>5__5");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__t_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<t>5__6");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__task_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, "<task>5__7");
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674143);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674145);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674139);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674140);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674141);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674142);
				AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr, 100674144);
			}

			// Token: 0x17001B6B RID: 7019
			// (get) Token: 0x06005137 RID: 20791 RVA: 0x0015BA8C File Offset: 0x00159C8C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B6C RID: 7020
			// (get) Token: 0x06005138 RID: 20792 RVA: 0x0015BACC File Offset: 0x00159CCC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005139 RID: 20793 RVA: 0x0015BB0C File Offset: 0x00159D0C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessPlayerAppearance_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceController._ProcessPlayerAppearance_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600513A RID: 20794 RVA: 0x0015BB54 File Offset: 0x00159D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130641, XrefRangeEnd = 130646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600513B RID: 20795 RVA: 0x0015BB88 File Offset: 0x00159D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130646, XrefRangeEnd = 130954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600513C RID: 20796 RVA: 0x0015BBC4 File Offset: 0x00159DC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130957, RefRangeEnd = 130958, XrefRangeStart = 130954, XrefRangeEnd = 130957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600513D RID: 20797 RVA: 0x0015BBF8 File Offset: 0x00159DF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130958, XrefRangeEnd = 130963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceController._ProcessPlayerAppearance_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600513E RID: 20798 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
			public _ProcessPlayerAppearance_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B60 RID: 7008
			// (get) Token: 0x0600513F RID: 20799 RVA: 0x0015BC2C File Offset: 0x00159E2C
			// (set) Token: 0x06005140 RID: 20800 RVA: 0x0001F2B1 File Offset: 0x0001D4B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B61 RID: 7009
			// (get) Token: 0x06005141 RID: 20801 RVA: 0x0015BC54 File Offset: 0x00159E54
			// (set) Token: 0x06005142 RID: 20802 RVA: 0x0001F2CC File Offset: 0x0001D4CC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B62 RID: 7010
			// (get) Token: 0x06005143 RID: 20803 RVA: 0x0015BC84 File Offset: 0x00159E84
			// (set) Token: 0x06005144 RID: 20804 RVA: 0x0001F2EB File Offset: 0x0001D4EB
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B63 RID: 7011
			// (get) Token: 0x06005145 RID: 20805 RVA: 0x0015BCB4 File Offset: 0x00159EB4
			// (set) Token: 0x06005146 RID: 20806 RVA: 0x0001F30A File Offset: 0x0001D50A
			public unsafe AppearanceController.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceController.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B64 RID: 7012
			// (get) Token: 0x06005147 RID: 20807 RVA: 0x0015BCE4 File Offset: 0x00159EE4
			// (set) Token: 0x06005148 RID: 20808 RVA: 0x0001F329 File Offset: 0x0001D529
			public unsafe AppearanceController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B65 RID: 7013
			// (get) Token: 0x06005149 RID: 20809 RVA: 0x0015BD14 File Offset: 0x00159F14
			// (set) Token: 0x0600514A RID: 20810 RVA: 0x0001F348 File Offset: 0x0001D548
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B66 RID: 7014
			// (get) Token: 0x0600514B RID: 20811 RVA: 0x0015BD44 File Offset: 0x00159F44
			// (set) Token: 0x0600514C RID: 20812 RVA: 0x0001F367 File Offset: 0x0001D567
			public unsafe JSONNode.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B67 RID: 7015
			// (get) Token: 0x0600514D RID: 20813 RVA: 0x0015BD74 File Offset: 0x00159F74
			// (set) Token: 0x0600514E RID: 20814 RVA: 0x0001F386 File Offset: 0x0001D586
			public unsafe GameObject _hat_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__hat_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__hat_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B68 RID: 7016
			// (get) Token: 0x0600514F RID: 20815 RVA: 0x0015BDA4 File Offset: 0x00159FA4
			// (set) Token: 0x06005150 RID: 20816 RVA: 0x0001F3A5 File Offset: 0x0001D5A5
			public unsafe GltfImport _gltf_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__gltf_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GltfImport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__gltf_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B69 RID: 7017
			// (get) Token: 0x06005151 RID: 20817 RVA: 0x0015BDD4 File Offset: 0x00159FD4
			// (set) Token: 0x06005152 RID: 20818 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
			public unsafe Task<bool> _t_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__t_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__t_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B6A RID: 7018
			// (get) Token: 0x06005153 RID: 20819 RVA: 0x0015BE04 File Offset: 0x0015A004
			// (set) Token: 0x06005154 RID: 20820 RVA: 0x0001F3E3 File Offset: 0x0001D5E3
			public unsafe Task<bool> _task_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__task_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceController._ProcessPlayerAppearance_d__8.NativeFieldInfoPtr__task_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E6B RID: 15979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E6C RID: 15980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E6D RID: 15981
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003E6E RID: 15982
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003E6F RID: 15983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E70 RID: 15984
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003E71 RID: 15985
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003E72 RID: 15986
			private static readonly IntPtr NativeFieldInfoPtr__hat_5__4;

			// Token: 0x04003E73 RID: 15987
			private static readonly IntPtr NativeFieldInfoPtr__gltf_5__5;

			// Token: 0x04003E74 RID: 15988
			private static readonly IntPtr NativeFieldInfoPtr__t_5__6;

			// Token: 0x04003E75 RID: 15989
			private static readonly IntPtr NativeFieldInfoPtr__task_5__7;

			// Token: 0x04003E76 RID: 15990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E77 RID: 15991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E78 RID: 15992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E79 RID: 15993
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E7A RID: 15994
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E7B RID: 15995
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003E7C RID: 15996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
