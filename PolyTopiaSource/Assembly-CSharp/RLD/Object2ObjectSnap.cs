using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000204 RID: 516
	public static class Object2ObjectSnap : global::Il2CppSystem.Object
	{
		// Token: 0x06002951 RID: 10577 RVA: 0x000C51A8 File Offset: 0x000C33A8
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnap()
		{
			Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnap");
			Object2ObjectSnap.NativeFieldInfoPtr__nearbyObjectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "_nearbyObjectBuffer");
			Object2ObjectSnap.NativeFieldInfoPtr__defaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "_defaultConfig");
			Object2ObjectSnap.NativeMethodInfoPtr_get_MaxSourceObjects_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, 100669601);
			Object2ObjectSnap.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, 100669603);
			Object2ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_SnapResult_List_1_GameObject_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, 100669604);
			Object2ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_SnapResult_GameObject_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, 100669605);
			Object2ObjectSnap.NativeMethodInfoPtr_CalculateSnapResult_Public_Static_SnapResult_GameObject_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, 100669606);
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000C525C File Offset: 0x000C345C
		public unsafe static int MaxSourceObjects
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.NativeMethodInfoPtr_get_MaxSourceObjects_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x000C528C File Offset: 0x000C348C
		public unsafe static Object2ObjectSnap.Config DefaultConfig
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91586, XrefRangeEnd = 91590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Object2ObjectSnap.Config(intPtr);
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000C52B8 File Offset: 0x000C34B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91609, RefRangeEnd = 91610, XrefRangeStart = 91590, XrefRangeEnd = 91609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object2ObjectSnap.SnapResult Snap(List<GameObject> roots, Object2ObjectSnap.Config snapConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(snapConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_SnapResult_List_1_GameObject_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000C5310 File Offset: 0x000C3510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91610, XrefRangeEnd = 91615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object2ObjectSnap.SnapResult Snap(GameObject root, Object2ObjectSnap.Config snapConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(snapConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.NativeMethodInfoPtr_Snap_Public_Static_SnapResult_GameObject_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000C5368 File Offset: 0x000C3568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91673, RefRangeEnd = 91675, XrefRangeStart = 91615, XrefRangeEnd = 91673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object2ObjectSnap.SnapResult CalculateSnapResult(GameObject root, Object2ObjectSnap.Config snapConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(snapConfig));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.NativeMethodInfoPtr_CalculateSnapResult_Public_Static_SnapResult_GameObject_Config_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0001050E File Offset: 0x0000E70E
		public Object2ObjectSnap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000C53C0 File Offset: 0x000C35C0
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00010517 File Offset: 0x0000E717
		public unsafe static List<GameObject> _nearbyObjectBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object2ObjectSnap.NativeFieldInfoPtr__nearbyObjectBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object2ObjectSnap.NativeFieldInfoPtr__nearbyObjectBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000C53E8 File Offset: 0x000C35E8
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x00010529 File Offset: 0x0000E729
		public unsafe static Object2ObjectSnap.Config _defaultConfig
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Object2ObjectSnap.NativeFieldInfoPtr__defaultConfig, intPtr);
				return new Object2ObjectSnap.Config(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object2ObjectSnap.NativeFieldInfoPtr__defaultConfig, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeFieldInfoPtr__nearbyObjectBuffer;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeFieldInfoPtr__defaultConfig;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSourceObjects_Public_Static_get_Int32_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConfig_Public_Static_get_Config_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_Snap_Public_Static_SnapResult_List_1_GameObject_Config_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_Snap_Public_Static_SnapResult_GameObject_Config_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSnapResult_Public_Static_SnapResult_GameObject_Config_0;

		// Token: 0x020003C0 RID: 960
		[Flags]
		public enum Prefs
		{
			// Token: 0x04003B49 RID: 15177
			None = 0,
			// Token: 0x04003B4A RID: 15178
			TryMatchArea = 1,
			// Token: 0x04003B4B RID: 15179
			All = 1
		}

		// Token: 0x020003C1 RID: 961
		public enum SnapFailReson
		{
			// Token: 0x04003B4D RID: 15181
			None,
			// Token: 0x04003B4E RID: 15182
			MaxObjectsExceeded,
			// Token: 0x04003B4F RID: 15183
			InvalidSourceObjects,
			// Token: 0x04003B50 RID: 15184
			NoDestinationFound
		}

		// Token: 0x020003C2 RID: 962
		[StructLayout(2)]
		public struct SnapResult
		{
			// Token: 0x06004C53 RID: 19539 RVA: 0x0014D3C4 File Offset: 0x0014B5C4
			// Note: this type is marked as 'beforefieldinit'.
			static SnapResult()
			{
				Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "SnapResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr);
				Object2ObjectSnap.SnapResult.NativeFieldInfoPtr__success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, "_success");
				Object2ObjectSnap.SnapResult.NativeFieldInfoPtr__snapPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, "_snapPivot");
				Object2ObjectSnap.SnapResult.NativeFieldInfoPtr__snapDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, "_snapDestination");
				Object2ObjectSnap.SnapResult.NativeFieldInfoPtr__snapDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, "_snapDistance");
				Object2ObjectSnap.SnapResult.NativeFieldInfoPtr__failReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, "_failReason");
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669607);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669608);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapDestination_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669609);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669610);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_FailReason_Public_get_SnapFailReson_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669611);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_SnapFailReson_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669612);
				Object2ObjectSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, 100669613);
			}

			// Token: 0x170019B7 RID: 6583
			// (get) Token: 0x06004C54 RID: 19540 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
			public unsafe bool Success
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 58106, RefRangeEnd = 58118, XrefRangeStart = 58106, XrefRangeEnd = 58118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019B8 RID: 6584
			// (get) Token: 0x06004C55 RID: 19541 RVA: 0x0014D510 File Offset: 0x0014B710
			public unsafe Vector3 SnapPivot
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x170019B9 RID: 6585
			// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0014D544 File Offset: 0x0014B744
			public unsafe Vector3 SnapDestination
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapDestination_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x170019BA RID: 6586
			// (get) Token: 0x06004C57 RID: 19543 RVA: 0x0014D578 File Offset: 0x0014B778
			public unsafe float SnapDistance
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_SnapDistance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019BB RID: 6587
			// (get) Token: 0x06004C58 RID: 19544 RVA: 0x0014D5A8 File Offset: 0x0014B7A8
			public unsafe Object2ObjectSnap.SnapFailReson FailReason
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr_get_FailReason_Public_get_SnapFailReson_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C59 RID: 19545 RVA: 0x0014D5D8 File Offset: 0x0014B7D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91575, RefRangeEnd = 91576, XrefRangeStart = 91571, XrefRangeEnd = 91575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SnapResult(Object2ObjectSnap.SnapFailReson failReson)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failReson;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_SnapFailReson_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C5A RID: 19546 RVA: 0x0014D60C File Offset: 0x0014B80C
			[CallerCount(0)]
			public unsafe SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapPivot);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snapDestination);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapDistance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.SnapResult.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C5B RID: 19547 RVA: 0x0001CA2B File Offset: 0x0001AC2B
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Object2ObjectSnap.SnapResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04003B51 RID: 15185
			private static readonly IntPtr NativeFieldInfoPtr__success;

			// Token: 0x04003B52 RID: 15186
			private static readonly IntPtr NativeFieldInfoPtr__snapPivot;

			// Token: 0x04003B53 RID: 15187
			private static readonly IntPtr NativeFieldInfoPtr__snapDestination;

			// Token: 0x04003B54 RID: 15188
			private static readonly IntPtr NativeFieldInfoPtr__snapDistance;

			// Token: 0x04003B55 RID: 15189
			private static readonly IntPtr NativeFieldInfoPtr__failReason;

			// Token: 0x04003B56 RID: 15190
			private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

			// Token: 0x04003B57 RID: 15191
			private static readonly IntPtr NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0;

			// Token: 0x04003B58 RID: 15192
			private static readonly IntPtr NativeMethodInfoPtr_get_SnapDestination_Public_get_Vector3_0;

			// Token: 0x04003B59 RID: 15193
			private static readonly IntPtr NativeMethodInfoPtr_get_SnapDistance_Public_get_Single_0;

			// Token: 0x04003B5A RID: 15194
			private static readonly IntPtr NativeMethodInfoPtr_get_FailReason_Public_get_SnapFailReson_0;

			// Token: 0x04003B5B RID: 15195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SnapFailReson_0;

			// Token: 0x04003B5C RID: 15196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0;

			// Token: 0x04003B5D RID: 15197
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool _success;

			// Token: 0x04003B5E RID: 15198
			[FieldOffset(4)]
			public IntPtr _snapPivot;

			// Token: 0x04003B5F RID: 15199
			[FieldOffset(16)]
			public IntPtr _snapDestination;

			// Token: 0x04003B60 RID: 15200
			[FieldOffset(28)]
			public float _snapDistance;

			// Token: 0x04003B61 RID: 15201
			[FieldOffset(32)]
			public Object2ObjectSnap.SnapFailReson _failReason;
		}

		// Token: 0x020003C3 RID: 963
		public sealed class Config : ValueType
		{
			// Token: 0x06004C5C RID: 19548 RVA: 0x0014D664 File Offset: 0x0014B864
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr);
				Object2ObjectSnap.Config.NativeFieldInfoPtr__areaMatchEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, "_areaMatchEps");
				Object2ObjectSnap.Config.NativeFieldInfoPtr_IgnoreDestObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, "IgnoreDestObjects");
				Object2ObjectSnap.Config.NativeFieldInfoPtr_DestinationLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, "DestinationLayers");
				Object2ObjectSnap.Config.NativeFieldInfoPtr_SnapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, "SnapRadius");
				Object2ObjectSnap.Config.NativeFieldInfoPtr_Prefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, "Prefs");
				Object2ObjectSnap.Config.NativeMethodInfoPtr_get_AreaMatchEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, 100669614);
				Object2ObjectSnap.Config.NativeMethodInfoPtr_set_AreaMatchEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, 100669615);
			}

			// Token: 0x170019C1 RID: 6593
			// (get) Token: 0x06004C5D RID: 19549 RVA: 0x0014D71C File Offset: 0x0014B91C
			// (set) Token: 0x06004C5E RID: 19550 RVA: 0x0014D760 File Offset: 0x0014B960
			public unsafe float AreaMatchEps
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.Config.NativeMethodInfoPtr_get_AreaMatchEps_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(21)]
				[CachedScanResults(RefRangeStart = 80206, RefRangeEnd = 80227, XrefRangeStart = 80206, XrefRangeEnd = 80227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.Config.NativeMethodInfoPtr_set_AreaMatchEps_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C5F RID: 19551 RVA: 0x0001CA3D File Offset: 0x0001AC3D
			public Config(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004C60 RID: 19552 RVA: 0x0001CA46 File Offset: 0x0001AC46
			public Config()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr))
			{
			}

			// Token: 0x170019BC RID: 6588
			// (get) Token: 0x06004C61 RID: 19553 RVA: 0x0014D7A4 File Offset: 0x0014B9A4
			// (set) Token: 0x06004C62 RID: 19554 RVA: 0x0001CA58 File Offset: 0x0001AC58
			public unsafe float _areaMatchEps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr__areaMatchEps);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr__areaMatchEps)) = value;
				}
			}

			// Token: 0x170019BD RID: 6589
			// (get) Token: 0x06004C63 RID: 19555 RVA: 0x0014D7CC File Offset: 0x0014B9CC
			// (set) Token: 0x06004C64 RID: 19556 RVA: 0x0001CA73 File Offset: 0x0001AC73
			public unsafe List<GameObject> IgnoreDestObjects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_IgnoreDestObjects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_IgnoreDestObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019BE RID: 6590
			// (get) Token: 0x06004C65 RID: 19557 RVA: 0x0014D7FC File Offset: 0x0014B9FC
			// (set) Token: 0x06004C66 RID: 19558 RVA: 0x0001CA92 File Offset: 0x0001AC92
			public unsafe int DestinationLayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_DestinationLayers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_DestinationLayers)) = value;
				}
			}

			// Token: 0x170019BF RID: 6591
			// (get) Token: 0x06004C67 RID: 19559 RVA: 0x0014D824 File Offset: 0x0014BA24
			// (set) Token: 0x06004C68 RID: 19560 RVA: 0x0001CAAD File Offset: 0x0001ACAD
			public unsafe float SnapRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_SnapRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_SnapRadius)) = value;
				}
			}

			// Token: 0x170019C0 RID: 6592
			// (get) Token: 0x06004C69 RID: 19561 RVA: 0x0014D84C File Offset: 0x0014BA4C
			// (set) Token: 0x06004C6A RID: 19562 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
			public unsafe Object2ObjectSnap.Prefs Prefs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_Prefs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.Config.NativeFieldInfoPtr_Prefs)) = value;
				}
			}

			// Token: 0x04003B62 RID: 15202
			private static readonly IntPtr NativeFieldInfoPtr__areaMatchEps;

			// Token: 0x04003B63 RID: 15203
			private static readonly IntPtr NativeFieldInfoPtr_IgnoreDestObjects;

			// Token: 0x04003B64 RID: 15204
			private static readonly IntPtr NativeFieldInfoPtr_DestinationLayers;

			// Token: 0x04003B65 RID: 15205
			private static readonly IntPtr NativeFieldInfoPtr_SnapRadius;

			// Token: 0x04003B66 RID: 15206
			private static readonly IntPtr NativeFieldInfoPtr_Prefs;

			// Token: 0x04003B67 RID: 15207
			private static readonly IntPtr NativeMethodInfoPtr_get_AreaMatchEps_Public_get_Single_0;

			// Token: 0x04003B68 RID: 15208
			private static readonly IntPtr NativeMethodInfoPtr_set_AreaMatchEps_Public_set_Void_Single_0;
		}

		// Token: 0x020003C4 RID: 964
		public sealed class SnapSortData : ValueType
		{
			// Token: 0x06004C6B RID: 19563 RVA: 0x0014D874 File Offset: 0x0014BA74
			// Note: this type is marked as 'beforefieldinit'.
			static SnapSortData()
			{
				Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "SnapSortData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr);
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "SrcObject");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "DestObject");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcSnapFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "SrcSnapFace");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestSnapFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "DestSnapFace");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreasMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "FaceAreasMatch");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreaDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "FaceAreaDiff");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "SnapPivot");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "SnapDest");
				Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr, "SnapDistance");
			}

			// Token: 0x06004C6C RID: 19564 RVA: 0x0001CAE3 File Offset: 0x0001ACE3
			public SnapSortData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004C6D RID: 19565 RVA: 0x0001CAEC File Offset: 0x0001ACEC
			public SnapSortData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnap.SnapSortData>.NativeClassPtr))
			{
			}

			// Token: 0x170019C2 RID: 6594
			// (get) Token: 0x06004C6E RID: 19566 RVA: 0x0014D954 File Offset: 0x0014BB54
			// (set) Token: 0x06004C6F RID: 19567 RVA: 0x0001CAFE File Offset: 0x0001ACFE
			public unsafe GameObject SrcObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C3 RID: 6595
			// (get) Token: 0x06004C70 RID: 19568 RVA: 0x0014D984 File Offset: 0x0014BB84
			// (set) Token: 0x06004C71 RID: 19569 RVA: 0x0001CB1D File Offset: 0x0001AD1D
			public unsafe GameObject DestObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C4 RID: 6596
			// (get) Token: 0x06004C72 RID: 19570 RVA: 0x0014D9B4 File Offset: 0x0014BBB4
			// (set) Token: 0x06004C73 RID: 19571 RVA: 0x0001CB3C File Offset: 0x0001AD3C
			public unsafe BoxFace SrcSnapFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcSnapFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxFace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SrcSnapFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C5 RID: 6597
			// (get) Token: 0x06004C74 RID: 19572 RVA: 0x0014D9E4 File Offset: 0x0014BBE4
			// (set) Token: 0x06004C75 RID: 19573 RVA: 0x0001CB5B File Offset: 0x0001AD5B
			public unsafe BoxFace DestSnapFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestSnapFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxFace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_DestSnapFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C6 RID: 6598
			// (get) Token: 0x06004C76 RID: 19574 RVA: 0x0014DA14 File Offset: 0x0014BC14
			// (set) Token: 0x06004C77 RID: 19575 RVA: 0x0001CB7A File Offset: 0x0001AD7A
			public unsafe bool FaceAreasMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreasMatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreasMatch)) = value;
				}
			}

			// Token: 0x170019C7 RID: 6599
			// (get) Token: 0x06004C78 RID: 19576 RVA: 0x0014DA3C File Offset: 0x0014BC3C
			// (set) Token: 0x06004C79 RID: 19577 RVA: 0x0001CB95 File Offset: 0x0001AD95
			public unsafe float FaceAreaDiff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreaDiff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_FaceAreaDiff)) = value;
				}
			}

			// Token: 0x170019C8 RID: 6600
			// (get) Token: 0x06004C7A RID: 19578 RVA: 0x0014DA64 File Offset: 0x0014BC64
			// (set) Token: 0x06004C7B RID: 19579 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
			public unsafe Vector3 SnapPivot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapPivot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C9 RID: 6601
			// (get) Token: 0x06004C7C RID: 19580 RVA: 0x0014DA94 File Offset: 0x0014BC94
			// (set) Token: 0x06004C7D RID: 19581 RVA: 0x0001CBCF File Offset: 0x0001ADCF
			public unsafe Vector3 SnapDest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CA RID: 6602
			// (get) Token: 0x06004C7E RID: 19582 RVA: 0x0014DAC4 File Offset: 0x0014BCC4
			// (set) Token: 0x06004C7F RID: 19583 RVA: 0x0001CBEE File Offset: 0x0001ADEE
			public unsafe float SnapDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.SnapSortData.NativeFieldInfoPtr_SnapDistance)) = value;
				}
			}

			// Token: 0x04003B69 RID: 15209
			private static readonly IntPtr NativeFieldInfoPtr_SrcObject;

			// Token: 0x04003B6A RID: 15210
			private static readonly IntPtr NativeFieldInfoPtr_DestObject;

			// Token: 0x04003B6B RID: 15211
			private static readonly IntPtr NativeFieldInfoPtr_SrcSnapFace;

			// Token: 0x04003B6C RID: 15212
			private static readonly IntPtr NativeFieldInfoPtr_DestSnapFace;

			// Token: 0x04003B6D RID: 15213
			private static readonly IntPtr NativeFieldInfoPtr_FaceAreasMatch;

			// Token: 0x04003B6E RID: 15214
			private static readonly IntPtr NativeFieldInfoPtr_FaceAreaDiff;

			// Token: 0x04003B6F RID: 15215
			private static readonly IntPtr NativeFieldInfoPtr_SnapPivot;

			// Token: 0x04003B70 RID: 15216
			private static readonly IntPtr NativeFieldInfoPtr_SnapDest;

			// Token: 0x04003B71 RID: 15217
			private static readonly IntPtr NativeFieldInfoPtr_SnapDistance;
		}

		// Token: 0x020003C5 RID: 965
		[ObfuscatedName("RLD.Object2ObjectSnap+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004C80 RID: 19584 RVA: 0x0014DAEC File Offset: 0x0014BCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr);
				Object2ObjectSnap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, "<>9");
				Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, "<>9__14_0");
				Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, "<>9__14_1");
				Object2ObjectSnap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, 100669617);
				Object2ObjectSnap.__c.NativeMethodInfoPtr__CalculateSnapResult_b__14_0_Internal_Int32_SnapSortData_SnapSortData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, 100669618);
				Object2ObjectSnap.__c.NativeMethodInfoPtr__CalculateSnapResult_b__14_1_Internal_Int32_SnapSortData_SnapSortData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr, 100669619);
			}

			// Token: 0x06004C81 RID: 19585 RVA: 0x0014DB90 File Offset: 0x0014BD90
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnap.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C82 RID: 19586 RVA: 0x0014DBCC File Offset: 0x0014BDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91576, XrefRangeEnd = 91577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CalculateSnapResult_b__14_0(Object2ObjectSnap.SnapSortData s0, Object2ObjectSnap.SnapSortData s1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s0));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s1));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.__c.NativeMethodInfoPtr__CalculateSnapResult_b__14_0_Internal_Int32_SnapSortData_SnapSortData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004C83 RID: 19587 RVA: 0x0014DC38 File Offset: 0x0014BE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91577, XrefRangeEnd = 91578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CalculateSnapResult_b__14_1(Object2ObjectSnap.SnapSortData s0, Object2ObjectSnap.SnapSortData s1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s0));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s1));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.__c.NativeMethodInfoPtr__CalculateSnapResult_b__14_1_Internal_Int32_SnapSortData_SnapSortData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004C84 RID: 19588 RVA: 0x0001CC09 File Offset: 0x0001AE09
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019CB RID: 6603
			// (get) Token: 0x06004C85 RID: 19589 RVA: 0x0014DCA4 File Offset: 0x0014BEA4
			// (set) Token: 0x06004C86 RID: 19590 RVA: 0x0001CC12 File Offset: 0x0001AE12
			public unsafe static Object2ObjectSnap.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnap.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CC RID: 6604
			// (get) Token: 0x06004C87 RID: 19591 RVA: 0x0014DCCC File Offset: 0x0014BECC
			// (set) Token: 0x06004C88 RID: 19592 RVA: 0x0001CC24 File Offset: 0x0001AE24
			public unsafe static Comparison<Object2ObjectSnap.SnapSortData> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Object2ObjectSnap.SnapSortData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CD RID: 6605
			// (get) Token: 0x06004C89 RID: 19593 RVA: 0x0014DCF4 File Offset: 0x0014BEF4
			// (set) Token: 0x06004C8A RID: 19594 RVA: 0x0001CC36 File Offset: 0x0001AE36
			public unsafe static Comparison<Object2ObjectSnap.SnapSortData> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Object2ObjectSnap.SnapSortData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Object2ObjectSnap.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B72 RID: 15218
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003B73 RID: 15219
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04003B74 RID: 15220
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04003B75 RID: 15221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B76 RID: 15222
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSnapResult_b__14_0_Internal_Int32_SnapSortData_SnapSortData_0;

			// Token: 0x04003B77 RID: 15223
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSnapResult_b__14_1_Internal_Int32_SnapSortData_SnapSortData_0;
		}

		// Token: 0x020003C6 RID: 966
		[ObfuscatedName("RLD.Object2ObjectSnap+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004C8B RID: 19595 RVA: 0x0014DD1C File Offset: 0x0014BF1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object2ObjectSnap>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr);
				Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr, "root");
				Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_snapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr, "snapConfig");
				Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr, "<>9__2");
				Object2ObjectSnap.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr, 100669620);
				Object2ObjectSnap.__c__DisplayClass14_0.NativeMethodInfoPtr__CalculateSnapResult_b__2_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr, 100669621);
			}

			// Token: 0x06004C8C RID: 19596 RVA: 0x0014DDAC File Offset: 0x0014BFAC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnap.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C8D RID: 19597 RVA: 0x0014DDE8 File Offset: 0x0014BFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91578, XrefRangeEnd = 91586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateSnapResult_b__2(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnap.__c__DisplayClass14_0.NativeMethodInfoPtr__CalculateSnapResult_b__2_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C8E RID: 19598 RVA: 0x0001CC48 File Offset: 0x0001AE48
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019CE RID: 6606
			// (get) Token: 0x06004C8F RID: 19599 RVA: 0x0014DE38 File Offset: 0x0014C038
			// (set) Token: 0x06004C90 RID: 19600 RVA: 0x0001CC51 File Offset: 0x0001AE51
			public unsafe GameObject root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CF RID: 6607
			// (get) Token: 0x06004C91 RID: 19601 RVA: 0x0014DE68 File Offset: 0x0014C068
			// (set) Token: 0x06004C92 RID: 19602 RVA: 0x0001CC70 File Offset: 0x0001AE70
			public Object2ObjectSnap.Config snapConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_snapConfig);
					return new Object2ObjectSnap.Config(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr_snapConfig), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Object2ObjectSnap.Config>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170019D0 RID: 6608
			// (get) Token: 0x06004C93 RID: 19603 RVA: 0x0014DE98 File Offset: 0x0014C098
			// (set) Token: 0x06004C94 RID: 19604 RVA: 0x0001CC9E File Offset: 0x0001AE9E
			public unsafe Predicate<GameObject> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object2ObjectSnap.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B78 RID: 15224
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x04003B79 RID: 15225
			private static readonly IntPtr NativeFieldInfoPtr_snapConfig;

			// Token: 0x04003B7A RID: 15226
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04003B7B RID: 15227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B7C RID: 15228
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSnapResult_b__2_Internal_Boolean_GameObject_0;
		}
	}
}
