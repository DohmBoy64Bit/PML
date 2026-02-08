using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000334 RID: 820
	public class NetworkController : MonoBehaviour
	{
		// Token: 0x0600463E RID: 17982 RVA: 0x0013903C File Offset: 0x0013723C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkController()
		{
			Il2CppClassPointerStore<NetworkController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "NetworkController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkController>.NativeClassPtr);
			NetworkController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, "singleton");
			NetworkController.NativeFieldInfoPtr_passphrase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, "passphrase");
			NetworkController.NativeFieldInfoPtr__PlaceID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, "<PlaceID>k__BackingField");
			NetworkController.NativeMethodInfoPtr_get_PlaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674407);
			NetworkController.NativeMethodInfoPtr_set_PlaceID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674408);
			NetworkController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674414);
			NetworkController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674409);
			NetworkController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674410);
			NetworkController.NativeMethodInfoPtr_StartClient_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674411);
			NetworkController.NativeMethodInfoPtr_PlaySolo_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674412);
			NetworkController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, 100674413);
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x00139148 File Offset: 0x00137348
		// (set) Token: 0x06004640 RID: 17984 RVA: 0x00139184 File Offset: 0x00137384
		public unsafe int PlaceID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_get_PlaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_set_PlaceID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x001391C4 File Offset: 0x001373C4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00139200 File Offset: 0x00137400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136207, XrefRangeEnd = 136222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00139234 File Offset: 0x00137434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136222, XrefRangeEnd = 136252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00139268 File Offset: 0x00137468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136252, XrefRangeEnd = 136257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_StartClient_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x001392A8 File Offset: 0x001374A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136257, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlaySolo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_PlaySolo_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x001392E8 File Offset: 0x001374E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136261, XrefRangeEnd = 136276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00019FFD File Offset: 0x000181FD
		public NetworkController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x0013931C File Offset: 0x0013751C
		// (set) Token: 0x06004649 RID: 17993 RVA: 0x0001A006 File Offset: 0x00018206
		public unsafe static NetworkController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NetworkController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NetworkController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x00139344 File Offset: 0x00137544
		// (set) Token: 0x0600464B RID: 17995 RVA: 0x0001A018 File Offset: 0x00018218
		public unsafe string passphrase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController.NativeFieldInfoPtr_passphrase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController.NativeFieldInfoPtr_passphrase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x0013936C File Offset: 0x0013756C
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x0001A037 File Offset: 0x00018237
		public unsafe int _PlaceID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController.NativeFieldInfoPtr__PlaceID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController.NativeFieldInfoPtr__PlaceID_k__BackingField)) = value;
			}
		}

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeFieldInfoPtr_passphrase;

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeFieldInfoPtr__PlaceID_k__BackingField;

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaceID_Public_get_Int32_0;

		// Token: 0x04003682 RID: 13954
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaceID_Private_set_Void_Int32_0;

		// Token: 0x04003683 RID: 13955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003684 RID: 13956
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003685 RID: 13957
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeMethodInfoPtr_StartClient_Private_IEnumerator_0;

		// Token: 0x04003687 RID: 13959
		private static readonly IntPtr NativeMethodInfoPtr_PlaySolo_Private_IEnumerator_0;

		// Token: 0x04003688 RID: 13960
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x02000433 RID: 1075
		[ObfuscatedName("Polytoria.Controllers.NetworkController+<PlaySolo>d__9")]
		public sealed class _PlaySolo_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06005266 RID: 21094 RVA: 0x0015EC9C File Offset: 0x0015CE9C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlaySolo_d__9()
			{
				Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, "<PlaySolo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr);
				NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, "<>1__state");
				NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, "<>2__current");
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674418);
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674420);
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674415);
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674416);
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674417);
				NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr, 100674419);
			}

			// Token: 0x17001BD1 RID: 7121
			// (get) Token: 0x06005267 RID: 21095 RVA: 0x0015ED68 File Offset: 0x0015CF68
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BD2 RID: 7122
			// (get) Token: 0x06005268 RID: 21096 RVA: 0x0015EDA8 File Offset: 0x0015CFA8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005269 RID: 21097 RVA: 0x0015EDE8 File Offset: 0x0015CFE8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlaySolo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkController._PlaySolo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600526A RID: 21098 RVA: 0x0015EE30 File Offset: 0x0015D030
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600526B RID: 21099 RVA: 0x0015EE64 File Offset: 0x0015D064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135869, XrefRangeEnd = 135918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600526C RID: 21100 RVA: 0x0015EEA0 File Offset: 0x0015D0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135918, XrefRangeEnd = 135923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._PlaySolo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600526D RID: 21101 RVA: 0x0001FE14 File Offset: 0x0001E014
			public _PlaySolo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BCF RID: 7119
			// (get) Token: 0x0600526E RID: 21102 RVA: 0x0015EED4 File Offset: 0x0015D0D4
			// (set) Token: 0x0600526F RID: 21103 RVA: 0x0001FE1D File Offset: 0x0001E01D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BD0 RID: 7120
			// (get) Token: 0x06005270 RID: 21104 RVA: 0x0015EEFC File Offset: 0x0015D0FC
			// (set) Token: 0x06005271 RID: 21105 RVA: 0x0001FE38 File Offset: 0x0001E038
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._PlaySolo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F16 RID: 16150
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F17 RID: 16151
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F18 RID: 16152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F19 RID: 16153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F1A RID: 16154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F1B RID: 16155
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F1C RID: 16156
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F1D RID: 16157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000434 RID: 1076
		[ObfuscatedName("Polytoria.Controllers.NetworkController+<StartClient>d__8")]
		public sealed class _StartClient_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06005272 RID: 21106 RVA: 0x0015EF2C File Offset: 0x0015D12C
			// Note: this type is marked as 'beforefieldinit'.
			static _StartClient_d__8()
			{
				Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkController>.NativeClassPtr, "<StartClient>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr);
				NetworkController._StartClient_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, "<>1__state");
				NetworkController._StartClient_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, "<>2__current");
				NetworkController._StartClient_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, "<>4__this");
				NetworkController._StartClient_d__8.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, "<uwr>5__2");
				NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674425);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674427);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674421);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674422);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674423);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674424);
				NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr, 100674426);
			}

			// Token: 0x17001BD7 RID: 7127
			// (get) Token: 0x06005273 RID: 21107 RVA: 0x0015F034 File Offset: 0x0015D234
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BD8 RID: 7128
			// (get) Token: 0x06005274 RID: 21108 RVA: 0x0015F074 File Offset: 0x0015D274
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005275 RID: 21109 RVA: 0x0015F0B4 File Offset: 0x0015D2B4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartClient_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkController._StartClient_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005276 RID: 21110 RVA: 0x0015F0FC File Offset: 0x0015D2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135923, XrefRangeEnd = 135928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005277 RID: 21111 RVA: 0x0015F130 File Offset: 0x0015D330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135928, XrefRangeEnd = 136199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005278 RID: 21112 RVA: 0x0015F16C File Offset: 0x0015D36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136199, XrefRangeEnd = 136202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005279 RID: 21113 RVA: 0x0015F1A0 File Offset: 0x0015D3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136202, XrefRangeEnd = 136207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkController._StartClient_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600527A RID: 21114 RVA: 0x0001FE57 File Offset: 0x0001E057
			public _StartClient_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BD3 RID: 7123
			// (get) Token: 0x0600527B RID: 21115 RVA: 0x0015F1D4 File Offset: 0x0015D3D4
			// (set) Token: 0x0600527C RID: 21116 RVA: 0x0001FE60 File Offset: 0x0001E060
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BD4 RID: 7124
			// (get) Token: 0x0600527D RID: 21117 RVA: 0x0015F1FC File Offset: 0x0015D3FC
			// (set) Token: 0x0600527E RID: 21118 RVA: 0x0001FE7B File Offset: 0x0001E07B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD5 RID: 7125
			// (get) Token: 0x0600527F RID: 21119 RVA: 0x0015F22C File Offset: 0x0015D42C
			// (set) Token: 0x06005280 RID: 21120 RVA: 0x0001FE9A File Offset: 0x0001E09A
			public unsafe NetworkController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD6 RID: 7126
			// (get) Token: 0x06005281 RID: 21121 RVA: 0x0015F25C File Offset: 0x0015D45C
			// (set) Token: 0x06005282 RID: 21122 RVA: 0x0001FEB9 File Offset: 0x0001E0B9
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkController._StartClient_d__8.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F1E RID: 16158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F1F RID: 16159
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F20 RID: 16160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F21 RID: 16161
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003F22 RID: 16162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F23 RID: 16163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F24 RID: 16164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F25 RID: 16165
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F26 RID: 16166
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F27 RID: 16167
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F28 RID: 16168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
