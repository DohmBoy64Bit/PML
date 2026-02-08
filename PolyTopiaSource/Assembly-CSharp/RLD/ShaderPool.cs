using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A7 RID: 423
	public class ShaderPool : Singleton<ShaderPool>
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x000A425C File Offset: 0x000A245C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderPool()
		{
			Il2CppClassPointerStore<ShaderPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ShaderPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr);
			ShaderPool.NativeFieldInfoPtr__linearGradientCameraBk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_linearGradientCameraBk");
			ShaderPool.NativeFieldInfoPtr__xzGrid_Plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_xzGrid_Plane");
			ShaderPool.NativeFieldInfoPtr__gizmoSolidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_gizmoSolidHandle");
			ShaderPool.NativeFieldInfoPtr__tintedTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_tintedTexture");
			ShaderPool.NativeFieldInfoPtr__simpleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_simpleColor");
			ShaderPool.NativeFieldInfoPtr__circleCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_circleCull");
			ShaderPool.NativeFieldInfoPtr__torusCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_torusCull");
			ShaderPool.NativeFieldInfoPtr__cylindricalTorusCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, "_cylindricalTorusCull");
			ShaderPool.NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668303);
			ShaderPool.NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668304);
			ShaderPool.NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668305);
			ShaderPool.NativeMethodInfoPtr_get_TintedTexture_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668306);
			ShaderPool.NativeMethodInfoPtr_get_SimpleColor_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668307);
			ShaderPool.NativeMethodInfoPtr_get_CircleCull_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668308);
			ShaderPool.NativeMethodInfoPtr_get_TorusCull_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668309);
			ShaderPool.NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668310);
			ShaderPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr, 100668311);
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000A43E0 File Offset: 0x000A25E0
		public unsafe Shader LinearGradientCameraBk
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85510, XrefRangeEnd = 85518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000A4420 File Offset: 0x000A2620
		public unsafe Shader XZGrid_Plane
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85518, XrefRangeEnd = 85526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000A4460 File Offset: 0x000A2660
		public unsafe Shader GizmoSolidHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85526, XrefRangeEnd = 85534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000A44A0 File Offset: 0x000A26A0
		public unsafe Shader TintedTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85534, XrefRangeEnd = 85542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_TintedTexture_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000A44E0 File Offset: 0x000A26E0
		public unsafe Shader SimpleColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85542, XrefRangeEnd = 85550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_SimpleColor_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000A4520 File Offset: 0x000A2720
		public unsafe Shader CircleCull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85550, XrefRangeEnd = 85558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_CircleCull_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x000A4560 File Offset: 0x000A2760
		public unsafe Shader TorusCull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85558, XrefRangeEnd = 85566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_TorusCull_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000A45A0 File Offset: 0x000A27A0
		public unsafe Shader CylindricalTorusCull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85566, XrefRangeEnd = 85574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000A45E0 File Offset: 0x000A27E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85574, XrefRangeEnd = 85580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0000D62C File Offset: 0x0000B82C
		public ShaderPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x000A461C File Offset: 0x000A281C
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000D635 File Offset: 0x0000B835
		public unsafe Shader _linearGradientCameraBk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__linearGradientCameraBk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__linearGradientCameraBk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x000A464C File Offset: 0x000A284C
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000D654 File Offset: 0x0000B854
		public unsafe Shader _xzGrid_Plane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__xzGrid_Plane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__xzGrid_Plane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x000A467C File Offset: 0x000A287C
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0000D673 File Offset: 0x0000B873
		public unsafe Shader _gizmoSolidHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__gizmoSolidHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__gizmoSolidHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x000A46AC File Offset: 0x000A28AC
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0000D692 File Offset: 0x0000B892
		public unsafe Shader _tintedTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__tintedTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__tintedTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x000A46DC File Offset: 0x000A28DC
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0000D6B1 File Offset: 0x0000B8B1
		public unsafe Shader _simpleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__simpleColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__simpleColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000A470C File Offset: 0x000A290C
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		public unsafe Shader _circleCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__circleCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__circleCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000A473C File Offset: 0x000A293C
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x0000D6EF File Offset: 0x0000B8EF
		public unsafe Shader _torusCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__torusCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__torusCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000A476C File Offset: 0x000A296C
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x0000D70E File Offset: 0x0000B90E
		public unsafe Shader _cylindricalTorusCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__cylindricalTorusCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPool.NativeFieldInfoPtr__cylindricalTorusCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr__linearGradientCameraBk;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr__xzGrid_Plane;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr__gizmoSolidHandle;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeFieldInfoPtr__tintedTexture;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr__simpleColor;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr__circleCull;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr__torusCull;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr__cylindricalTorusCull;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_get_LinearGradientCameraBk_Public_get_Shader_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_get_XZGrid_Plane_Public_get_Shader_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_get_GizmoSolidHandle_Public_get_Shader_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_get_TintedTexture_Public_get_Shader_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleColor_Public_get_Shader_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleCull_Public_get_Shader_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_get_TorusCull_Public_get_Shader_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_get_CylindricalTorusCull_Public_get_Shader_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
