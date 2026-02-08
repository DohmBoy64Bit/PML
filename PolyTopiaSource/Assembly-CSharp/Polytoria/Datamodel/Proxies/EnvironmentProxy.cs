using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D7 RID: 727
	public class EnvironmentProxy : InstanceProxy
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x0011F998 File Offset: 0x0011DB98
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentProxy()
		{
			Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "EnvironmentProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr);
			EnvironmentProxy.NativeFieldInfoPtr_environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, "environment");
			EnvironmentProxy.NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673321);
			EnvironmentProxy.NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673322);
			EnvironmentProxy.NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673323);
			EnvironmentProxy.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673324);
			EnvironmentProxy.NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673325);
			EnvironmentProxy.NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673326);
			EnvironmentProxy.NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673327);
			EnvironmentProxy.NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673328);
			EnvironmentProxy.NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673329);
			EnvironmentProxy.NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673330);
			EnvironmentProxy.NativeMethodInfoPtr_get_FogColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673331);
			EnvironmentProxy.NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673332);
			EnvironmentProxy.NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673333);
			EnvironmentProxy.NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673334);
			EnvironmentProxy.NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673335);
			EnvironmentProxy.NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673336);
			EnvironmentProxy.NativeMethodInfoPtr__ctor_Public_Void_Environment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673320);
			EnvironmentProxy.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673337);
			EnvironmentProxy.NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673338);
			EnvironmentProxy.NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673339);
			EnvironmentProxy.NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673340);
			EnvironmentProxy.NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673341);
			EnvironmentProxy.NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673342);
			EnvironmentProxy.NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr, 100673343);
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x0011FBBC File Offset: 0x0011DDBC
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x0011FBFC File Offset: 0x0011DDFC
		public unsafe SkyboxPreset Skybox
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyboxPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128536, XrefRangeEnd = 128538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x0011FC40 File Offset: 0x0011DE40
		// (set) Token: 0x06004014 RID: 16404 RVA: 0x0011FC80 File Offset: 0x0011DE80
		public unsafe Vector3 Gravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128538, XrefRangeEnd = 128539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x0011FCC4 File Offset: 0x0011DEC4
		// (set) Token: 0x06004016 RID: 16406 RVA: 0x0011FD00 File Offset: 0x0011DF00
		public unsafe bool FogEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128539, XrefRangeEnd = 128541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x0011FD40 File Offset: 0x0011DF40
		// (set) Token: 0x06004018 RID: 16408 RVA: 0x0011FD7C File Offset: 0x0011DF7C
		public unsafe float FogStartDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128541, XrefRangeEnd = 128543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x0011FDBC File Offset: 0x0011DFBC
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x0011FDF8 File Offset: 0x0011DFF8
		public unsafe float FogEndDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128543, XrefRangeEnd = 128545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x0011FE38 File Offset: 0x0011E038
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x0011FE78 File Offset: 0x0011E078
		public unsafe Color FogColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_FogColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128545, XrefRangeEnd = 128546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x0011FEBC File Offset: 0x0011E0BC
		// (set) Token: 0x0600401E RID: 16414 RVA: 0x0011FEF8 File Offset: 0x0011E0F8
		public unsafe float PartDestroyHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128546, XrefRangeEnd = 128548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x0011FF38 File Offset: 0x0011E138
		// (set) Token: 0x06004020 RID: 16416 RVA: 0x0011FF74 File Offset: 0x0011E174
		public unsafe bool AutoGenerateNavMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128548, XrefRangeEnd = 128550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0011FFB4 File Offset: 0x0011E1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentProxy(Environment target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr__ctor_Public_Void_Environment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x00120000 File Offset: 0x0011E200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128550, XrefRangeEnd = 128551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 10000f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref affectKinematic;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00120090 File Offset: 0x0011E290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128551, XrefRangeEnd = 128552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<RayResult> Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00120114 File Offset: 0x0011E314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128552, XrefRangeEnd = 128553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RayResult> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RayResult>>(intPtr3) : null;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00120198 File Offset: 0x0011E398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128553, XrefRangeEnd = 128554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00120208 File Offset: 0x0011E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128554, XrefRangeEnd = 128555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> OverlapBox(Vector3 center, Vector3 halfExtents, Vector3 rotation, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(halfExtents);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00120290 File Offset: 0x0011E490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128555, XrefRangeEnd = 128557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildNavMesh(Instance root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x001202D4 File Offset: 0x0011E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128557, XrefRangeEnd = 128558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentProxy.NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x000185D9 File Offset: 0x000167D9
		public EnvironmentProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x00120334 File Offset: 0x0011E534
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x000185E2 File Offset: 0x000167E2
		public unsafe Environment environment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentProxy.NativeFieldInfoPtr_environment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Environment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentProxy.NativeFieldInfoPtr_environment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeFieldInfoPtr_environment;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeMethodInfoPtr_get_FogColor_Public_get_Color_0;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Environment_0;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0;
	}
}
