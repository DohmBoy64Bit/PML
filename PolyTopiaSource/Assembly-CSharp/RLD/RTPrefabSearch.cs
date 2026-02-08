using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x020001A3 RID: 419
	public class RTPrefabSearch : MonoBehaviour
	{
		// Token: 0x06002060 RID: 8288 RVA: 0x000A2478 File Offset: 0x000A0678
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabSearch()
		{
			Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabSearch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr);
			RTPrefabSearch.NativeFieldInfoPtr__searchField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr, "_searchField");
			RTPrefabSearch.NativeMethodInfoPtr_get_SearchField_Public_get_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr, 100668245);
			RTPrefabSearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr, 100668247);
			RTPrefabSearch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr, 100668246);
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x000A24F8 File Offset: 0x000A06F8
		public unsafe InputField SearchField
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabSearch.NativeMethodInfoPtr_get_SearchField_Public_get_InputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr3) : null;
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000A2538 File Offset: 0x000A0738
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabSearch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabSearch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabSearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000A2574 File Offset: 0x000A0774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84776, XrefRangeEnd = 84780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabSearch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0000D247 File Offset: 0x0000B447
		public RTPrefabSearch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000A25A8 File Offset: 0x000A07A8
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0000D250 File Offset: 0x0000B450
		public unsafe InputField _searchField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabSearch.NativeFieldInfoPtr__searchField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabSearch.NativeFieldInfoPtr__searchField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeFieldInfoPtr__searchField;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_get_SearchField_Public_get_InputField_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
	}
}
