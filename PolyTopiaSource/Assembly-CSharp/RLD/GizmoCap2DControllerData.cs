using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000010 RID: 16
	public class GizmoCap2DControllerData : Object
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0002446C File Offset: 0x0002266C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap2DControllerData()
		{
			Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap2DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr);
			GizmoCap2DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "Gizmo");
			GizmoCap2DControllerData.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "Cap");
			GizmoCap2DControllerData.NativeFieldInfoPtr_CapHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "CapHandle");
			GizmoCap2DControllerData.NativeFieldInfoPtr_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "Quad");
			GizmoCap2DControllerData.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "Circle");
			GizmoCap2DControllerData.NativeFieldInfoPtr_Arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "Arrow");
			GizmoCap2DControllerData.NativeFieldInfoPtr_QuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "QuadIndex");
			GizmoCap2DControllerData.NativeFieldInfoPtr_CircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "CircleIndex");
			GizmoCap2DControllerData.NativeFieldInfoPtr_ArrowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, "ArrowIndex");
			GizmoCap2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr, 100663433);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00024564 File Offset: 0x00022764
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap2DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap2DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002507 File Offset: 0x00000707
		public GizmoCap2DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000245A0 File Offset: 0x000227A0
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002510 File Offset: 0x00000710
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000245D0 File Offset: 0x000227D0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000252F File Offset: 0x0000072F
		public unsafe GizmoCap2D Cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00024600 File Offset: 0x00022800
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000254E File Offset: 0x0000074E
		public unsafe GizmoHandle CapHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_CapHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_CapHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00024630 File Offset: 0x00022830
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000256D File Offset: 0x0000076D
		public unsafe QuadShape2D Quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00024660 File Offset: 0x00022860
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe CircleShape2D Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00024690 File Offset: 0x00022890
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe ConeShape2D Arrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Arrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_Arrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000246C0 File Offset: 0x000228C0
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000025CA File Offset: 0x000007CA
		public unsafe int QuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_QuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_QuadIndex)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000246E8 File Offset: 0x000228E8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe int CircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_CircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_CircleIndex)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00024710 File Offset: 0x00022910
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe int ArrowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_ArrowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DControllerData.NativeFieldInfoPtr_ArrowIndex)) = value;
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_CapHandle;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_Quad;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_Arrow;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_QuadIndex;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_CircleIndex;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_ArrowIndex;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
