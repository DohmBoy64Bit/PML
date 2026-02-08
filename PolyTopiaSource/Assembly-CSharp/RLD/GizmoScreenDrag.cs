using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200003F RID: 63
	public class GizmoScreenDrag : GizmoDragSession
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00030BF4 File Offset: 0x0002EDF4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoScreenDrag()
		{
			Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoScreenDrag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr);
			GizmoScreenDrag.NativeFieldInfoPtr__isSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, "_isSnapEnabled");
			GizmoScreenDrag.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, "_sensitivity");
			GizmoScreenDrag.NativeFieldInfoPtr__screenDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, "_screenDragSession");
			GizmoScreenDrag.NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663890);
			GizmoScreenDrag.NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663891);
			GizmoScreenDrag.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663892);
			GizmoScreenDrag.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663893);
			GizmoScreenDrag.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663894);
			GizmoScreenDrag.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663899);
			GizmoScreenDrag.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663895);
			GizmoScreenDrag.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663896);
			GizmoScreenDrag.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663897);
			GizmoScreenDrag.NativeMethodInfoPtr_CanSnap_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr, 100663898);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00030D28 File Offset: 0x0002EF28
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00030D64 File Offset: 0x0002EF64
		public unsafe bool IsSnapEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00030DA4 File Offset: 0x0002EFA4
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 59415, RefRangeEnd = 59431, XrefRangeStart = 59415, XrefRangeEnd = 59431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00030E20 File Offset: 0x0002F020
		public unsafe override bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoScreenDrag.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00030E68 File Offset: 0x0002F068
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58933, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoScreenDrag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoScreenDrag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00030EA4 File Offset: 0x0002F0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59456, XrefRangeEnd = 59469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoBeginSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoScreenDrag.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00030EEC File Offset: 0x0002F0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59469, XrefRangeEnd = 59471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoUpdateSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoScreenDrag.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00030F34 File Offset: 0x0002F134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59471, XrefRangeEnd = 59474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoEndSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoScreenDrag.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00030F70 File Offset: 0x0002F170
		[CallerCount(0)]
		public unsafe bool CanSnap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScreenDrag.NativeMethodInfoPtr_CanSnap_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000377F File Offset: 0x0000197F
		public GizmoScreenDrag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00030FAC File Offset: 0x0002F1AC
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003788 File Offset: 0x00001988
		public unsafe bool _isSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__isSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__isSnapEnabled)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00030FD4 File Offset: 0x0002F1D4
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000037A3 File Offset: 0x000019A3
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00030FFC File Offset: 0x0002F1FC
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000037BE File Offset: 0x000019BE
		public unsafe InputDeviceScreenDragSession _screenDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__screenDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDeviceScreenDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScreenDrag.NativeFieldInfoPtr__screenDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr__isSnapEnabled;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr__screenDragSession;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSnapEnabled_Public_get_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSnapEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_CanSnap_Protected_Boolean_0;
	}
}
