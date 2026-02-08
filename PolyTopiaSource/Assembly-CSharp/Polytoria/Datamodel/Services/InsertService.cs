using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CB RID: 715
	public class InsertService : MonoBehaviour
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x0011B824 File Offset: 0x00119A24
		// Note: this type is marked as 'beforefieldinit'.
		static InsertService()
		{
			Il2CppClassPointerStore<InsertService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "InsertService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsertService>.NativeClassPtr);
			InsertService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertService>.NativeClassPtr, "<Instance>k__BackingField");
			InsertService.NativeMethodInfoPtr_get_Instance_Public_Static_get_InsertService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673050);
			InsertService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_InsertService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673051);
			InsertService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673055);
			InsertService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673052);
			InsertService.NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673053);
			InsertService.NativeMethodInfoPtr_NetworkSpawn_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService>.NativeClassPtr, 100673054);
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x0011B8E0 File Offset: 0x00119AE0
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x0011B914 File Offset: 0x00119B14
		public unsafe static InsertService Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125286, XrefRangeEnd = 125288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr_get_Instance_Public_Static_get_InsertService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InsertService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125288, XrefRangeEnd = 125292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_InsertService_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x0011B94C File Offset: 0x00119B4C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InsertService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsertService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0011B988 File Offset: 0x00119B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125292, XrefRangeEnd = 125296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0011B9BC File Offset: 0x00119BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125316, RefRangeEnd = 125317, XrefRangeStart = 125296, XrefRangeEnd = 125316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Model(int id, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0011BA0C File Offset: 0x00119C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125325, RefRangeEnd = 125327, XrefRangeStart = 125317, XrefRangeEnd = 125325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NetworkSpawn(Instance i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.NativeMethodInfoPtr_NetworkSpawn_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000182EF File Offset: 0x000164EF
		public InsertService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x0011BA50 File Offset: 0x00119C50
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x000182F8 File Offset: 0x000164F8
		public unsafe static InsertService _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InsertService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InsertService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InsertService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_InsertService_0;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_InsertService_0;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr_Model_Public_Void_Int32_DynValue_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr_NetworkSpawn_Private_Void_Instance_0;

		// Token: 0x02000412 RID: 1042
		[ObfuscatedName("Polytoria.Datamodel.Services.InsertService+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FA3 RID: 20387 RVA: 0x00156BA8 File Offset: 0x00154DA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InsertService>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr);
				InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				InsertService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr, 100673056);
				InsertService.__c__DisplayClass5_0.NativeMethodInfoPtr__Model_b__0_Internal_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr, 100673057);
			}

			// Token: 0x06004FA4 RID: 20388 RVA: 0x00156C24 File Offset: 0x00154E24
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsertService.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x00156C60 File Offset: 0x00154E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125271, XrefRangeEnd = 125286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Model_b__0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertService.__c__DisplayClass5_0.NativeMethodInfoPtr__Model_b__0_Internal_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FA6 RID: 20390 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ADC RID: 6876
			// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x00156CA4 File Offset: 0x00154EA4
			// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x0001E6AD File Offset: 0x0001C8AD
			public unsafe InsertService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InsertService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADD RID: 6877
			// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x00156CD4 File Offset: 0x00154ED4
			// (set) Token: 0x06004FAA RID: 20394 RVA: 0x0001E6CC File Offset: 0x0001C8CC
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertService.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D74 RID: 15732
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D75 RID: 15733
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D76 RID: 15734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D77 RID: 15735
			private static readonly IntPtr NativeMethodInfoPtr__Model_b__0_Internal_Void_Instance_0;
		}
	}
}
