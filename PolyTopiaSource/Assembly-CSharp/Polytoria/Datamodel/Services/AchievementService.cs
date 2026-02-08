using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Mirror;
using MoonSharp.Interpreter;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C1 RID: 705
	public class AchievementService : NetworkBehaviour
	{
		// Token: 0x06003E3B RID: 15931 RVA: 0x00117F0C File Offset: 0x0011610C
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementService()
		{
			Il2CppClassPointerStore<AchievementService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "AchievementService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementService>.NativeClassPtr);
			AchievementService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "<Instance>k__BackingField");
			AchievementService.NativeFieldInfoPtr_MaxRequestsPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "MaxRequestsPerMinute");
			AchievementService.NativeFieldInfoPtr_RequestsPerPlayerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "RequestsPerPlayerModifier");
			AchievementService.NativeFieldInfoPtr_requestsThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "requestsThisMinute");
			AchievementService.NativeFieldInfoPtr_currentMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "currentMinute");
			AchievementService.NativeMethodInfoPtr_get_Instance_Public_Static_get_AchievementService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672867);
			AchievementService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AchievementService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672868);
			AchievementService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672875);
			AchievementService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672869);
			AchievementService.NativeMethodInfoPtr_UseRequest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672870);
			AchievementService.NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672871);
			AchievementService.NativeMethodInfoPtr_DoAward_Private_IEnumerator_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672872);
			AchievementService.NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672873);
			AchievementService.NativeMethodInfoPtr_DoHasAchievement_Private_IEnumerator_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672874);
			AchievementService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, 100672876);
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x00118068 File Offset: 0x00116268
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x0011809C File Offset: 0x0011629C
		public unsafe static AchievementService Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123618, XrefRangeEnd = 123620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_get_Instance_Public_Static_get_AchievementService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123620, XrefRangeEnd = 123624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AchievementService_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x001180D4 File Offset: 0x001162D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123624, XrefRangeEnd = 123625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00118110 File Offset: 0x00116310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123625, XrefRangeEnd = 123629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00118144 File Offset: 0x00116344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123640, RefRangeEnd = 123642, XrefRangeStart = 123629, XrefRangeEnd = 123640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_UseRequest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00118180 File Offset: 0x00116380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123658, RefRangeEnd = 123659, XrefRangeStart = 123642, XrefRangeEnd = 123658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Award(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x001181E0 File Offset: 0x001163E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123659, XrefRangeEnd = 123664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoAward(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_DoAward_Private_IEnumerator_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0011824C File Offset: 0x0011644C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123680, RefRangeEnd = 123681, XrefRangeStart = 123664, XrefRangeEnd = 123680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HasAchievement(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x001182AC File Offset: 0x001164AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123681, XrefRangeEnd = 123686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoHasAchievement(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService.NativeMethodInfoPtr_DoHasAchievement_Private_IEnumerator_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00118318 File Offset: 0x00116518
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00017DB8 File Offset: 0x00015FB8
		public AchievementService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x00118360 File Offset: 0x00116560
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x00017DC1 File Offset: 0x00015FC1
		public unsafe static AchievementService _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AchievementService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AchievementService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x00118388 File Offset: 0x00116588
		// (set) Token: 0x06003E4A RID: 15946 RVA: 0x00017DD3 File Offset: 0x00015FD3
		public unsafe int MaxRequestsPerMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_MaxRequestsPerMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_MaxRequestsPerMinute)) = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x001183B0 File Offset: 0x001165B0
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00017DEE File Offset: 0x00015FEE
		public unsafe int RequestsPerPlayerModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_RequestsPerPlayerModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_RequestsPerPlayerModifier)) = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x001183D8 File Offset: 0x001165D8
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x00017E09 File Offset: 0x00016009
		public unsafe int requestsThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_requestsThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_requestsThisMinute)) = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x00118400 File Offset: 0x00116600
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x00017E24 File Offset: 0x00016024
		public unsafe int currentMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_currentMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService.NativeFieldInfoPtr_currentMinute)) = value;
			}
		}

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeFieldInfoPtr_MaxRequestsPerMinute;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeFieldInfoPtr_RequestsPerPlayerModifier;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeFieldInfoPtr_requestsThisMinute;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeFieldInfoPtr_currentMinute;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AchievementService_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_AchievementService_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeMethodInfoPtr_UseRequest_Public_Boolean_0;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr_DoAward_Private_IEnumerator_Int32_Int32_DynValue_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeMethodInfoPtr_DoHasAchievement_Private_IEnumerator_Int32_Int32_DynValue_0;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x02000406 RID: 1030
		[ObfuscatedName("Polytoria.Datamodel.Services.AchievementService+<DoAward>d__11")]
		public sealed class _DoAward_d__11 : Object
		{
			// Token: 0x06004EE4 RID: 20196 RVA: 0x00154A14 File Offset: 0x00152C14
			// Note: this type is marked as 'beforefieldinit'.
			static _DoAward_d__11()
			{
				Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "<DoAward>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr);
				AchievementService._DoAward_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "<>1__state");
				AchievementService._DoAward_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "<>2__current");
				AchievementService._DoAward_d__11.NativeFieldInfoPtr_achievementID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "achievementID");
				AchievementService._DoAward_d__11.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "userID");
				AchievementService._DoAward_d__11.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "callback");
				AchievementService._DoAward_d__11.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, "<uwr>5__2");
				AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672880);
				AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672882);
				AchievementService._DoAward_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672877);
				AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672878);
				AchievementService._DoAward_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672879);
				AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr, 100672881);
			}

			// Token: 0x17001A9D RID: 6813
			// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x00154B30 File Offset: 0x00152D30
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A9E RID: 6814
			// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x00154B70 File Offset: 0x00152D70
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EE7 RID: 20199 RVA: 0x00154BB0 File Offset: 0x00152DB0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoAward_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementService._DoAward_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EE8 RID: 20200 RVA: 0x00154BF8 File Offset: 0x00152DF8
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE9 RID: 20201 RVA: 0x00154C2C File Offset: 0x00152E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123538, XrefRangeEnd = 123581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004EEA RID: 20202 RVA: 0x00154C68 File Offset: 0x00152E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123581, XrefRangeEnd = 123586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoAward_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EEB RID: 20203 RVA: 0x0001DFC9 File Offset: 0x0001C1C9
			public _DoAward_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A97 RID: 6807
			// (get) Token: 0x06004EEC RID: 20204 RVA: 0x00154C9C File Offset: 0x00152E9C
			// (set) Token: 0x06004EED RID: 20205 RVA: 0x0001DFD2 File Offset: 0x0001C1D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A98 RID: 6808
			// (get) Token: 0x06004EEE RID: 20206 RVA: 0x00154CC4 File Offset: 0x00152EC4
			// (set) Token: 0x06004EEF RID: 20207 RVA: 0x0001DFED File Offset: 0x0001C1ED
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A99 RID: 6809
			// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x00154CF4 File Offset: 0x00152EF4
			// (set) Token: 0x06004EF1 RID: 20209 RVA: 0x0001E00C File Offset: 0x0001C20C
			public unsafe int achievementID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_achievementID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_achievementID)) = value;
				}
			}

			// Token: 0x17001A9A RID: 6810
			// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x00154D1C File Offset: 0x00152F1C
			// (set) Token: 0x06004EF3 RID: 20211 RVA: 0x0001E027 File Offset: 0x0001C227
			public unsafe int userID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_userID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_userID)) = value;
				}
			}

			// Token: 0x17001A9B RID: 6811
			// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x00154D44 File Offset: 0x00152F44
			// (set) Token: 0x06004EF5 RID: 20213 RVA: 0x0001E042 File Offset: 0x0001C242
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A9C RID: 6812
			// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x00154D74 File Offset: 0x00152F74
			// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0001E061 File Offset: 0x0001C261
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoAward_d__11.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D05 RID: 15621
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D06 RID: 15622
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D07 RID: 15623
			private static readonly IntPtr NativeFieldInfoPtr_achievementID;

			// Token: 0x04003D08 RID: 15624
			private static readonly IntPtr NativeFieldInfoPtr_userID;

			// Token: 0x04003D09 RID: 15625
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D0A RID: 15626
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D0B RID: 15627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D0C RID: 15628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D0D RID: 15629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D0E RID: 15630
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D0F RID: 15631
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D10 RID: 15632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000407 RID: 1031
		[ObfuscatedName("Polytoria.Datamodel.Services.AchievementService+<DoHasAchievement>d__13")]
		public sealed class _DoHasAchievement_d__13 : Object
		{
			// Token: 0x06004EF8 RID: 20216 RVA: 0x00154DA4 File Offset: 0x00152FA4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoHasAchievement_d__13()
			{
				Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementService>.NativeClassPtr, "<DoHasAchievement>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr);
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "<>1__state");
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "<>2__current");
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "userID");
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_achievementID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "achievementID");
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "callback");
				AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, "<uwr>5__2");
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672886);
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672888);
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672883);
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672884);
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672885);
				AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr, 100672887);
			}

			// Token: 0x17001AA5 RID: 6821
			// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x00154EC0 File Offset: 0x001530C0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001AA6 RID: 6822
			// (get) Token: 0x06004EFA RID: 20218 RVA: 0x00154F00 File Offset: 0x00153100
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EFB RID: 20219 RVA: 0x00154F40 File Offset: 0x00153140
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoHasAchievement_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementService._DoHasAchievement_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EFC RID: 20220 RVA: 0x00154F88 File Offset: 0x00153188
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFD RID: 20221 RVA: 0x00154FBC File Offset: 0x001531BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123586, XrefRangeEnd = 123613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004EFE RID: 20222 RVA: 0x00154FF8 File Offset: 0x001531F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123613, XrefRangeEnd = 123618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementService._DoHasAchievement_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFF RID: 20223 RVA: 0x0001E080 File Offset: 0x0001C280
			public _DoHasAchievement_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A9F RID: 6815
			// (get) Token: 0x06004F00 RID: 20224 RVA: 0x0015502C File Offset: 0x0015322C
			// (set) Token: 0x06004F01 RID: 20225 RVA: 0x0001E089 File Offset: 0x0001C289
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AA0 RID: 6816
			// (get) Token: 0x06004F02 RID: 20226 RVA: 0x00155054 File Offset: 0x00153254
			// (set) Token: 0x06004F03 RID: 20227 RVA: 0x0001E0A4 File Offset: 0x0001C2A4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA1 RID: 6817
			// (get) Token: 0x06004F04 RID: 20228 RVA: 0x00155084 File Offset: 0x00153284
			// (set) Token: 0x06004F05 RID: 20229 RVA: 0x0001E0C3 File Offset: 0x0001C2C3
			public unsafe int userID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_userID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_userID)) = value;
				}
			}

			// Token: 0x17001AA2 RID: 6818
			// (get) Token: 0x06004F06 RID: 20230 RVA: 0x001550AC File Offset: 0x001532AC
			// (set) Token: 0x06004F07 RID: 20231 RVA: 0x0001E0DE File Offset: 0x0001C2DE
			public unsafe int achievementID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_achievementID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_achievementID)) = value;
				}
			}

			// Token: 0x17001AA3 RID: 6819
			// (get) Token: 0x06004F08 RID: 20232 RVA: 0x001550D4 File Offset: 0x001532D4
			// (set) Token: 0x06004F09 RID: 20233 RVA: 0x0001E0F9 File Offset: 0x0001C2F9
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA4 RID: 6820
			// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00155104 File Offset: 0x00153304
			// (set) Token: 0x06004F0B RID: 20235 RVA: 0x0001E118 File Offset: 0x0001C318
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementService._DoHasAchievement_d__13.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D11 RID: 15633
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D12 RID: 15634
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D13 RID: 15635
			private static readonly IntPtr NativeFieldInfoPtr_userID;

			// Token: 0x04003D14 RID: 15636
			private static readonly IntPtr NativeFieldInfoPtr_achievementID;

			// Token: 0x04003D15 RID: 15637
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D16 RID: 15638
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D17 RID: 15639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D18 RID: 15640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D19 RID: 15641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D1A RID: 15642
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D1B RID: 15643
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D1C RID: 15644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
