using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x02000197 RID: 407
	public class RTActiveLibDropDown : MonoBehaviour
	{
		// Token: 0x06001F6B RID: 8043 RVA: 0x0009E9A0 File Offset: 0x0009CBA0
		// Note: this type is marked as 'beforefieldinit'.
		static RTActiveLibDropDown()
		{
			Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTActiveLibDropDown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr);
			RTActiveLibDropDown.NativeFieldInfoPtr__dropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, "_dropDown");
			RTActiveLibDropDown.NativeFieldInfoPtr__valueChangedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, "_valueChangedListeners");
			RTActiveLibDropDown.NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668081);
			RTActiveLibDropDown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668087);
			RTActiveLibDropDown.NativeMethodInfoPtr_AddValueChangedListener_Public_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668082);
			RTActiveLibDropDown.NativeMethodInfoPtr_SetActiveLibIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668083);
			RTActiveLibDropDown.NativeMethodInfoPtr_ClearLibs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668084);
			RTActiveLibDropDown.NativeMethodInfoPtr_SyncWithLibDb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668085);
			RTActiveLibDropDown.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr, 100668086);
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0009EA84 File Offset: 0x0009CC84
		public unsafe int ActiveLibIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0009EAC0 File Offset: 0x0009CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83518, XrefRangeEnd = 83526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTActiveLibDropDown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTActiveLibDropDown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0009EAFC File Offset: 0x0009CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83526, XrefRangeEnd = 83535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValueChangedListener(UnityAction<int> listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_AddValueChangedListener_Public_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0009EB40 File Offset: 0x0009CD40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83554, RefRangeEnd = 83556, XrefRangeStart = 83535, XrefRangeEnd = 83554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveLibIndex(int activeLibIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeLibIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_SetActiveLibIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0009EB80 File Offset: 0x0009CD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83556, XrefRangeEnd = 83558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLibs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_ClearLibs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0009EBB4 File Offset: 0x0009CDB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83575, RefRangeEnd = 83580, XrefRangeStart = 83558, XrefRangeEnd = 83575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncWithLibDb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_SyncWithLibDb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83580, XrefRangeEnd = 83586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTActiveLibDropDown.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0000CCAD File Offset: 0x0000AEAD
		public RTActiveLibDropDown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0009EC1C File Offset: 0x0009CE1C
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000CCB6 File Offset: 0x0000AEB6
		public unsafe Dropdown _dropDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTActiveLibDropDown.NativeFieldInfoPtr__dropDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTActiveLibDropDown.NativeFieldInfoPtr__dropDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0009EC4C File Offset: 0x0009CE4C
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000CCD5 File Offset: 0x0000AED5
		public unsafe List<UnityAction<int>> _valueChangedListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTActiveLibDropDown.NativeFieldInfoPtr__valueChangedListeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityAction<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTActiveLibDropDown.NativeFieldInfoPtr__valueChangedListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr__dropDown;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr__valueChangedListeners;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_AddValueChangedListener_Public_Void_UnityAction_1_Int32_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveLibIndex_Public_Void_Int32_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_ClearLibs_Public_Void_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_SyncWithLibDb_Public_Void_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
	}
}
