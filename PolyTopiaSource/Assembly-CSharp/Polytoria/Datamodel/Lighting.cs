using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028A RID: 650
	public class Lighting : Instance
	{
		// Token: 0x060033DA RID: 13274 RVA: 0x000EC9F0 File Offset: 0x000EABF0
		// Note: this type is marked as 'beforefieldinit'.
		static Lighting()
		{
			Il2CppClassPointerStore<Lighting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Lighting");
			Lighting.NativeFieldInfoPtr_ambientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lighting>.NativeClassPtr, "ambientColor");
			Lighting.NativeFieldInfoPtr_ambientSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lighting>.NativeClassPtr, "ambientSource");
			Lighting.NativeFieldInfoPtr_sun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lighting>.NativeClassPtr, "sun");
			Lighting.NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671125);
			Lighting.NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671126);
			Lighting.NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671127);
			Lighting.NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671128);
			Lighting.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671129);
			Lighting.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671130);
			Lighting.NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671131);
			Lighting.NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671132);
			Lighting.NativeMethodInfoPtr_get_SunColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671133);
			Lighting.NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671134);
			Lighting.NativeMethodInfoPtr_get_NetworkambientColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671141);
			Lighting.NativeMethodInfoPtr_set_NetworkambientColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671142);
			Lighting.NativeMethodInfoPtr_get_NetworkambientSource_Public_get_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671143);
			Lighting.NativeMethodInfoPtr_set_NetworkambientSource_Public_set_Void_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671144);
			Lighting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671139);
			Lighting.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671135);
			Lighting.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671136);
			Lighting.NativeMethodInfoPtr_RpcSetAmbientColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671137);
			Lighting.NativeMethodInfoPtr_RpcSetAmbientSource_Private_Void_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671138);
			Lighting.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671140);
			Lighting.NativeMethodInfoPtr_UserCode_RpcSetAmbientColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671145);
			Lighting.NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671146);
			Lighting.NativeMethodInfoPtr_UserCode_RpcSetAmbientSource__AmbientSource_Protected_Void_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671147);
			Lighting.NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientSource__AmbientSource_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671148);
			Lighting.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671150);
			Lighting.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lighting>.NativeClassPtr, 100671151);
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x000ECC5C File Offset: 0x000EAE5C
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x000ECC9C File Offset: 0x000EAE9C
		public unsafe Color AmbientColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106029, RefRangeEnd = 106030, XrefRangeStart = 106028, XrefRangeEnd = 106029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 106053, RefRangeEnd = 106057, XrefRangeStart = 106030, XrefRangeEnd = 106053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x000ECCE0 File Offset: 0x000EAEE0
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x000ECD20 File Offset: 0x000EAF20
		public unsafe AmbientSource AmbientSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmbientSource>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 106082, RefRangeEnd = 106086, XrefRangeStart = 106057, XrefRangeEnd = 106082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x000ECD64 File Offset: 0x000EAF64
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x000ECDA0 File Offset: 0x000EAFA0
		public unsafe bool Shadows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106086, RefRangeEnd = 106087, XrefRangeStart = 106086, XrefRangeEnd = 106086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106089, RefRangeEnd = 106090, XrefRangeStart = 106087, XrefRangeEnd = 106089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000ECDE0 File Offset: 0x000EAFE0
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x000ECE1C File Offset: 0x000EB01C
		public unsafe float SunBrightness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106090, RefRangeEnd = 106091, XrefRangeStart = 106090, XrefRangeEnd = 106090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106093, RefRangeEnd = 106094, XrefRangeStart = 106091, XrefRangeEnd = 106093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000ECE5C File Offset: 0x000EB05C
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x000ECE9C File Offset: 0x000EB09C
		public unsafe Color SunColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106094, RefRangeEnd = 106095, XrefRangeStart = 106094, XrefRangeEnd = 106094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_SunColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106096, RefRangeEnd = 106097, XrefRangeStart = 106095, XrefRangeEnd = 106096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000ECEE0 File Offset: 0x000EB0E0
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x000ECF20 File Offset: 0x000EB120
		public unsafe Color NetworkambientColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_NetworkambientColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106097, XrefRangeEnd = 106103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_NetworkambientColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000ECF64 File Offset: 0x000EB164
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x000ECFA4 File Offset: 0x000EB1A4
		public unsafe AmbientSource NetworkambientSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_get_NetworkambientSource_Public_get_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmbientSource>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106103, XrefRangeEnd = 106109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_set_NetworkambientSource_Public_set_Void_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000ECFE8 File Offset: 0x000EB1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106109, XrefRangeEnd = 106113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lighting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lighting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000ED024 File Offset: 0x000EB224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106113, XrefRangeEnd = 106114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lighting.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000ED060 File Offset: 0x000EB260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106114, XrefRangeEnd = 106146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lighting.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000ED09C File Offset: 0x000EB29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106146, XrefRangeEnd = 106167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAmbientColor(Color c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_RpcSetAmbientColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000ED0E0 File Offset: 0x000EB2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106167, XrefRangeEnd = 106188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAmbientSource(AmbientSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_RpcSetAmbientSource_Private_Void_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000ED124 File Offset: 0x000EB324
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lighting.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000ED16C File Offset: 0x000EB36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106188, XrefRangeEnd = 106190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAmbientColor__Color(Color c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_UserCode_RpcSetAmbientColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000ED1B0 File Offset: 0x000EB3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106190, XrefRangeEnd = 106201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAmbientColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000ED20C File Offset: 0x000EB40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106201, XrefRangeEnd = 106203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAmbientSource__AmbientSource(AmbientSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_UserCode_RpcSetAmbientSource__AmbientSource_Protected_Void_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000ED250 File Offset: 0x000EB450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106203, XrefRangeEnd = 106218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAmbientSource__AmbientSource(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lighting.NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientSource__AmbientSource_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000ED2AC File Offset: 0x000EB4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106218, XrefRangeEnd = 106227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lighting.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000ED308 File Offset: 0x000EB508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106227, XrefRangeEnd = 106241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lighting.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000147E0 File Offset: 0x000129E0
		public Lighting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x000ED364 File Offset: 0x000EB564
		// (set) Token: 0x060033F7 RID: 13303 RVA: 0x000147E9 File Offset: 0x000129E9
		public unsafe Color ambientColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_ambientColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_ambientColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x000ED394 File Offset: 0x000EB594
		// (set) Token: 0x060033F9 RID: 13305 RVA: 0x00014808 File Offset: 0x00012A08
		public unsafe AmbientSource ambientSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_ambientSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_ambientSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060033FA RID: 13306 RVA: 0x000ED3C4 File Offset: 0x000EB5C4
		// (set) Token: 0x060033FB RID: 13307 RVA: 0x00014827 File Offset: 0x00012A27
		public unsafe SunLight sun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_sun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SunLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lighting.NativeFieldInfoPtr_sun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeFieldInfoPtr_ambientColor;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeFieldInfoPtr_ambientSource;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeFieldInfoPtr_sun;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr_get_SunColor_Public_get_Color_0;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0;

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkambientColor_Public_get_Color_0;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkambientColor_Public_set_Void_Color_0;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkambientSource_Public_get_AmbientSource_0;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkambientSource_Public_set_Void_AmbientSource_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAmbientColor_Private_Void_Color_0;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAmbientSource_Private_Void_AmbientSource_0;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAmbientColor__Color_Protected_Void_Color_0;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAmbientSource__AmbientSource_Protected_Void_AmbientSource_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAmbientSource__AmbientSource_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
