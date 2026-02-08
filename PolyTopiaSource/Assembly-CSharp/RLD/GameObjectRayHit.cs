using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AB RID: 427
	public class GameObjectRayHit : global::Il2CppSystem.Object
	{
		// Token: 0x06002123 RID: 8483 RVA: 0x000A5020 File Offset: 0x000A3220
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectRayHit()
		{
			Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GameObjectRayHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr);
			GameObjectRayHit.NativeFieldInfoPtr__hitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_hitObject");
			GameObjectRayHit.NativeFieldInfoPtr__hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_hitPoint");
			GameObjectRayHit.NativeFieldInfoPtr__hitEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_hitEnter");
			GameObjectRayHit.NativeFieldInfoPtr__hitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_hitNormal");
			GameObjectRayHit.NativeFieldInfoPtr__hitPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_hitPlane");
			GameObjectRayHit.NativeFieldInfoPtr__meshRayHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "_meshRayHit");
			GameObjectRayHit.NativeMethodInfoPtr_get_HitObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668332);
			GameObjectRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668333);
			GameObjectRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668334);
			GameObjectRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668335);
			GameObjectRayHit.NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668336);
			GameObjectRayHit.NativeMethodInfoPtr_get_MeshRayHit_Public_get_MeshRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668337);
			GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668340);
			GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668341);
			GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668342);
			GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_MeshRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668343);
			GameObjectRayHit.NativeMethodInfoPtr_SortByHitDistance_Public_Static_Void_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668338);
			GameObjectRayHit.NativeMethodInfoPtr_Store_Public_Static_Void_Ray_IEnumerable_1_RaycastHit2D_IEnumerable_1_RaycastHit_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, 100668339);
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x000A51B8 File Offset: 0x000A33B8
		public unsafe GameObject HitObject
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_HitObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000A51F8 File Offset: 0x000A33F8
		public unsafe Vector3 HitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000A5238 File Offset: 0x000A3438
		public unsafe float HitEnter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000A5274 File Offset: 0x000A3474
		public unsafe Vector3 HitNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000A52B4 File Offset: 0x000A34B4
		public unsafe Plane HitPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000A52F4 File Offset: 0x000A34F4
		public unsafe MeshRayHit MeshRayHit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_get_MeshRayHit_Public_get_MeshRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRayHit>(intPtr3) : null;
			}
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000A5334 File Offset: 0x000A3534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85825, RefRangeEnd = 85827, XrefRangeStart = 85816, XrefRangeEnd = 85825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit(Ray hitRay, RaycastHit hit3D)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hitRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hit3D);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000A5394 File Offset: 0x000A3594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85827, XrefRangeEnd = 85836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hitRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hit2D);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000A53F4 File Offset: 0x000A35F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85840, RefRangeEnd = 85842, XrefRangeStart = 85836, XrefRangeEnd = 85840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hitRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitNormal);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000A5474 File Offset: 0x000A3674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85842, XrefRangeEnd = 85848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshRayHit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_MeshRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000A54E4 File Offset: 0x000A36E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85848, XrefRangeEnd = 85867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortByHitDistance(List<GameObjectRayHit> hits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_SortByHitDistance_Public_Static_Void_List_1_GameObjectRayHit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000A551C File Offset: 0x000A371C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85926, RefRangeEnd = 85927, XrefRangeStart = 85867, XrefRangeEnd = 85926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Store(Ray hitRay, IEnumerable<RaycastHit2D> hits2D, IEnumerable<RaycastHit> hits3D, List<GameObjectRayHit> hits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hitRay);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits2D);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits3D);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.NativeMethodInfoPtr_Store_Public_Static_Void_Ray_IEnumerable_1_RaycastHit2D_IEnumerable_1_RaycastHit_List_1_GameObjectRayHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0000D837 File Offset: 0x0000BA37
		public GameObjectRayHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000A5588 File Offset: 0x000A3788
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000D840 File Offset: 0x0000BA40
		public unsafe GameObject _hitObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000A55B8 File Offset: 0x000A37B8
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000D85F File Offset: 0x0000BA5F
		public unsafe Vector3 _hitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000A55E8 File Offset: 0x000A37E8
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000D87E File Offset: 0x0000BA7E
		public unsafe float _hitEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitEnter)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000A5610 File Offset: 0x000A3810
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000D899 File Offset: 0x0000BA99
		public unsafe Vector3 _hitNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000A5640 File Offset: 0x000A3840
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
		public unsafe Plane _hitPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__hitPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000A5670 File Offset: 0x000A3870
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
		public unsafe MeshRayHit _meshRayHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__meshRayHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRayHit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectRayHit.NativeFieldInfoPtr__meshRayHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr__hitObject;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr__hitPoint;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr__hitEnter;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr__hitNormal;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr__hitPlane;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr__meshRayHit;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_get_HitObject_Public_get_GameObject_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPoint_Public_get_Vector3_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_get_HitEnter_Public_get_Single_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_get_HitNormal_Public_get_Vector3_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_get_HitPlane_Public_get_Plane_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_get_MeshRayHit_Public_get_MeshRayHit_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_RaycastHit2D_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_Vector3_Single_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Ray_GameObject_MeshRayHit_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_SortByHitDistance_Public_Static_Void_List_1_GameObjectRayHit_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Static_Void_Ray_IEnumerable_1_RaycastHit2D_IEnumerable_1_RaycastHit_List_1_GameObjectRayHit_0;

		// Token: 0x020003A3 RID: 931
		[ObfuscatedName("RLD.GameObjectRayHit+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004BA8 RID: 19368 RVA: 0x0014B38C File Offset: 0x0014958C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectRayHit>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr);
				GameObjectRayHit.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr, "<>9");
				GameObjectRayHit.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr, "<>9__18_0");
				GameObjectRayHit.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr, 100668345);
				GameObjectRayHit.__c.NativeMethodInfoPtr__SortByHitDistance_b__18_0_Internal_Int32_GameObjectRayHit_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr, 100668346);
			}

			// Token: 0x06004BA9 RID: 19369 RVA: 0x0014B408 File Offset: 0x00149608
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectRayHit.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BAA RID: 19370 RVA: 0x0014B444 File Offset: 0x00149644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85815, XrefRangeEnd = 85816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortByHitDistance_b__18_0(GameObjectRayHit h0, GameObjectRayHit h1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(h0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectRayHit.__c.NativeMethodInfoPtr__SortByHitDistance_b__18_0_Internal_Int32_GameObjectRayHit_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BAB RID: 19371 RVA: 0x0001C546 File Offset: 0x0001A746
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001979 RID: 6521
			// (get) Token: 0x06004BAC RID: 19372 RVA: 0x0014B4A4 File Offset: 0x001496A4
			// (set) Token: 0x06004BAD RID: 19373 RVA: 0x0001C54F File Offset: 0x0001A74F
			public unsafe static GameObjectRayHit.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameObjectRayHit.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameObjectRayHit.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197A RID: 6522
			// (get) Token: 0x06004BAE RID: 19374 RVA: 0x0014B4CC File Offset: 0x001496CC
			// (set) Token: 0x06004BAF RID: 19375 RVA: 0x0001C561 File Offset: 0x0001A761
			public unsafe static Comparison<GameObjectRayHit> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameObjectRayHit.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<GameObjectRayHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameObjectRayHit.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A9F RID: 15007
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003AA0 RID: 15008
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04003AA1 RID: 15009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003AA2 RID: 15010
			private static readonly IntPtr NativeMethodInfoPtr__SortByHitDistance_b__18_0_Internal_Int32_GameObjectRayHit_GameObjectRayHit_0;
		}
	}
}
