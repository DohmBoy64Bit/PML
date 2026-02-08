using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003E RID: 62
	public class GizmoPlaneDrag3D : GizmoDragSession
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x0003075C File Offset: 0x0002E95C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneDrag3D()
		{
			Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr);
			GizmoPlaneDrag3D.NativeFieldInfoPtr__isSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, "_isSnapEnabled");
			GizmoPlaneDrag3D.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, "_sensitivity");
			GizmoPlaneDrag3D.NativeFieldInfoPtr__planeDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, "_planeDragSession");
			GizmoPlaneDrag3D.NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663879);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663880);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663881);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663882);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663883);
			GizmoPlaneDrag3D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663889);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663884);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663885);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663886);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_CanSnap_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663887);
			GizmoPlaneDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Abstract_Virtual_New_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr, 100663888);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000308A4 File Offset: 0x0002EAA4
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000308E0 File Offset: 0x0002EAE0
		public unsafe bool IsSnapEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00030920 File Offset: 0x0002EB20
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0003095C File Offset: 0x0002EB5C
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 59415, RefRangeEnd = 59431, XrefRangeStart = 59415, XrefRangeEnd = 59415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0003099C File Offset: 0x0002EB9C
		public unsafe override bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneDrag3D.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000309E4 File Offset: 0x0002EBE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58933, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00030A20 File Offset: 0x0002EC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59431, XrefRangeEnd = 59451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoBeginSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneDrag3D.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00030A68 File Offset: 0x0002EC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59451, XrefRangeEnd = 59453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoUpdateSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneDrag3D.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59453, XrefRangeEnd = 59456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoEndSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneDrag3D.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00030AEC File Offset: 0x0002ECEC
		[CallerCount(0)]
		public unsafe bool CanSnap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneDrag3D.NativeMethodInfoPtr_CanSnap_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00030B28 File Offset: 0x0002ED28
		[CallerCount(0)]
		public unsafe virtual Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Abstract_Virtual_New_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00003721 File Offset: 0x00001921
		public GizmoPlaneDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00030B74 File Offset: 0x0002ED74
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0000372A File Offset: 0x0000192A
		public unsafe bool _isSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__isSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__isSnapEnabled)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00030B9C File Offset: 0x0002ED9C
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003745 File Offset: 0x00001945
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003760 File Offset: 0x00001960
		public unsafe InputDevicePlaneDragSession3D _planeDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__planeDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevicePlaneDragSession3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneDrag3D.NativeFieldInfoPtr__planeDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr__isSnapEnabled;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr__planeDragSession;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_CanSnap_Protected_Boolean_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Abstract_Virtual_New_Plane_0;
	}
}
