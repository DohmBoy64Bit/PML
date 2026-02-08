using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x020001A1 RID: 417
	public class RTPrefabPreviewButton : MonoBehaviour
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x000A1764 File Offset: 0x0009F964
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabPreviewButton()
		{
			Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabPreviewButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr);
			RTPrefabPreviewButton.NativeFieldInfoPtr_HoverEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "HoverEnter");
			RTPrefabPreviewButton.NativeFieldInfoPtr_HoverExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "HoverExit");
			RTPrefabPreviewButton.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "_text");
			RTPrefabPreviewButton.NativeFieldInfoPtr__prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "_prefab");
			RTPrefabPreviewButton.NativeMethodInfoPtr_get_Prefab_Public_get_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668201);
			RTPrefabPreviewButton.NativeMethodInfoPtr_set_Prefab_Public_set_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668202);
			RTPrefabPreviewButton.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668203);
			RTPrefabPreviewButton.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668204);
			RTPrefabPreviewButton.NativeMethodInfoPtr_add_HoverEnter_Public_add_Void_HoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668197);
			RTPrefabPreviewButton.NativeMethodInfoPtr_remove_HoverEnter_Public_rem_Void_HoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668198);
			RTPrefabPreviewButton.NativeMethodInfoPtr_add_HoverExit_Public_add_Void_HoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668199);
			RTPrefabPreviewButton.NativeMethodInfoPtr_remove_HoverExit_Public_rem_Void_HoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668200);
			RTPrefabPreviewButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668208);
			RTPrefabPreviewButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668205);
			RTPrefabPreviewButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668206);
			RTPrefabPreviewButton.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, 100668207);
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x000A18D4 File Offset: 0x0009FAD4
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x000A1914 File Offset: 0x0009FB14
		public unsafe RTPrefab Prefab
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_get_Prefab_Public_get_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84493, RefRangeEnd = 84495, XrefRangeStart = 84492, XrefRangeEnd = 84493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_set_Prefab_Public_set_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x000A1958 File Offset: 0x0009FB58
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x000A1990 File Offset: 0x0009FB90
		public unsafe string Text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84495, XrefRangeEnd = 84500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84504, RefRangeEnd = 84505, XrefRangeStart = 84500, XrefRangeEnd = 84504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000A19D4 File Offset: 0x0009FBD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84509, RefRangeEnd = 84510, XrefRangeStart = 84505, XrefRangeEnd = 84509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_HoverEnter(RTPrefabPreviewButton.HoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_add_HoverEnter_Public_add_Void_HoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000A1A18 File Offset: 0x0009FC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84514, RefRangeEnd = 84515, XrefRangeStart = 84510, XrefRangeEnd = 84514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_HoverEnter(RTPrefabPreviewButton.HoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_remove_HoverEnter_Public_rem_Void_HoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000A1A5C File Offset: 0x0009FC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84519, RefRangeEnd = 84520, XrefRangeStart = 84515, XrefRangeEnd = 84519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_HoverExit(RTPrefabPreviewButton.HoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_add_HoverExit_Public_add_Void_HoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000A1AA0 File Offset: 0x0009FCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84524, RefRangeEnd = 84525, XrefRangeStart = 84520, XrefRangeEnd = 84524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_HoverExit(RTPrefabPreviewButton.HoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_remove_HoverExit_Public_rem_Void_HoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x000A1AE4 File Offset: 0x0009FCE4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabPreviewButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x000A1B20 File Offset: 0x0009FD20
		[CallerCount(0)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000A1B64 File Offset: 0x0009FD64
		[CallerCount(0)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000A1BA8 File Offset: 0x0009FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84525, XrefRangeEnd = 84531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0000D0A2 File Offset: 0x0000B2A2
		public RTPrefabPreviewButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000A1BDC File Offset: 0x0009FDDC
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x0000D0AB File Offset: 0x0000B2AB
		public unsafe RTPrefabPreviewButton.HoverEnterHandler HoverEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr_HoverEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabPreviewButton.HoverEnterHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr_HoverEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000A1C0C File Offset: 0x0009FE0C
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x0000D0CA File Offset: 0x0000B2CA
		public unsafe RTPrefabPreviewButton.HoverExitHandler HoverExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr_HoverExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabPreviewButton.HoverExitHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr_HoverExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x000A1C3C File Offset: 0x0009FE3C
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x0000D0E9 File Offset: 0x0000B2E9
		public unsafe Text _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr__text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr__text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x000A1C6C File Offset: 0x0009FE6C
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x0000D108 File Offset: 0x0000B308
		public unsafe RTPrefab _prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr__prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabPreviewButton.NativeFieldInfoPtr__prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_HoverEnter;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_HoverExit;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr__prefab;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefab_Public_get_RTPrefab_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefab_Public_set_Void_RTPrefab_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_add_HoverEnter_Public_add_Void_HoverEnterHandler_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_remove_HoverEnter_Public_rem_Void_HoverEnterHandler_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_add_HoverExit_Public_add_Void_HoverExitHandler_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_remove_HoverExit_Public_rem_Void_HoverExitHandler_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0200039E RID: 926
		public sealed class HoverEnterHandler : MulticastDelegate
		{
			// Token: 0x06004B7B RID: 19323 RVA: 0x0014AA90 File Offset: 0x00148C90
			// Note: this type is marked as 'beforefieldinit'.
			static HoverEnterHandler()
			{
				Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "HoverEnterHandler");
				RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr, 100668209);
				RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr, 100668210);
				RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr, 100668211);
				RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr, 100668212);
			}

			// Token: 0x06004B7C RID: 19324 RVA: 0x0014AB04 File Offset: 0x00148D04
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HoverEnterHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverEnterHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B7D RID: 19325 RVA: 0x0014AB60 File Offset: 0x00148D60
			[CallerCount(0)]
			public unsafe void Invoke(RTPrefab prefab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B7E RID: 19326 RVA: 0x0014ABA4 File Offset: 0x00148DA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B7F RID: 19327 RVA: 0x0014AC18 File Offset: 0x00148E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverEnterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B80 RID: 19328 RVA: 0x0001C456 File Offset: 0x0001A656
			public HoverEnterHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B81 RID: 19329 RVA: 0x0001C45F File Offset: 0x0001A65F
			public static implicit operator RTPrefabPreviewButton.HoverEnterHandler(Action<RTPrefab> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTPrefabPreviewButton.HoverEnterHandler>(A_0);
			}

			// Token: 0x06004B82 RID: 19330 RVA: 0x0001C467 File Offset: 0x0001A667
			public static RTPrefabPreviewButton.HoverEnterHandler operator +(RTPrefabPreviewButton.HoverEnterHandler A_0, RTPrefabPreviewButton.HoverEnterHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTPrefabPreviewButton.HoverEnterHandler>();
			}

			// Token: 0x06004B83 RID: 19331 RVA: 0x0001C475 File Offset: 0x0001A675
			public static RTPrefabPreviewButton.HoverEnterHandler operator -(RTPrefabPreviewButton.HoverEnterHandler A_0, RTPrefabPreviewButton.HoverEnterHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTPrefabPreviewButton.HoverEnterHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A8B RID: 14987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A8C RID: 14988
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0;

			// Token: 0x04003A8D RID: 14989
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0;

			// Token: 0x04003A8E RID: 14990
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200039F RID: 927
		public sealed class HoverExitHandler : MulticastDelegate
		{
			// Token: 0x06004B84 RID: 19332 RVA: 0x0014AC5C File Offset: 0x00148E5C
			// Note: this type is marked as 'beforefieldinit'.
			static HoverExitHandler()
			{
				Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabPreviewButton>.NativeClassPtr, "HoverExitHandler");
				RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr, 100668213);
				RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr, 100668214);
				RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr, 100668215);
				RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr, 100668216);
			}

			// Token: 0x06004B85 RID: 19333 RVA: 0x0014ACD0 File Offset: 0x00148ED0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HoverExitHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabPreviewButton.HoverExitHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x0014AD2C File Offset: 0x00148F2C
			[CallerCount(0)]
			public unsafe void Invoke(RTPrefab prefab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B87 RID: 19335 RVA: 0x0014AD70 File Offset: 0x00148F70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B88 RID: 19336 RVA: 0x0014ADE4 File Offset: 0x00148FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabPreviewButton.HoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B89 RID: 19337 RVA: 0x0001C486 File Offset: 0x0001A686
			public HoverExitHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B8A RID: 19338 RVA: 0x0001C48F File Offset: 0x0001A68F
			public static implicit operator RTPrefabPreviewButton.HoverExitHandler(Action<RTPrefab> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTPrefabPreviewButton.HoverExitHandler>(A_0);
			}

			// Token: 0x06004B8B RID: 19339 RVA: 0x0001C497 File Offset: 0x0001A697
			public static RTPrefabPreviewButton.HoverExitHandler operator +(RTPrefabPreviewButton.HoverExitHandler A_0, RTPrefabPreviewButton.HoverExitHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTPrefabPreviewButton.HoverExitHandler>();
			}

			// Token: 0x06004B8C RID: 19340 RVA: 0x0001C4A5 File Offset: 0x0001A6A5
			public static RTPrefabPreviewButton.HoverExitHandler operator -(RTPrefabPreviewButton.HoverExitHandler A_0, RTPrefabPreviewButton.HoverExitHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTPrefabPreviewButton.HoverExitHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A8F RID: 14991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A90 RID: 14992
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0;

			// Token: 0x04003A91 RID: 14993
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0;

			// Token: 0x04003A92 RID: 14994
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
