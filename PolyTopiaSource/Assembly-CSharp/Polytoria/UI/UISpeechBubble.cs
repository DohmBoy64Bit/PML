using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace Polytoria.UI
{
	// Token: 0x02000257 RID: 599
	public class UISpeechBubble : MonoBehaviour
	{
		// Token: 0x06002E8B RID: 11915 RVA: 0x000D72EC File Offset: 0x000D54EC
		// Note: this type is marked as 'beforefieldinit'.
		static UISpeechBubble()
		{
			Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "UISpeechBubble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr);
			UISpeechBubble.NativeFieldInfoPtr_chatContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "chatContentRect");
			UISpeechBubble.NativeFieldInfoPtr_bubbleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "bubbleRect");
			UISpeechBubble.NativeFieldInfoPtr_chatText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "chatText");
			UISpeechBubble.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "message");
			UISpeechBubble.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "Padding");
			UISpeechBubble.NativeFieldInfoPtr_DisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "DisplayTime");
			UISpeechBubble.NativeFieldInfoPtr_targetOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "targetOpacity");
			UISpeechBubble.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "timer");
			UISpeechBubble.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, "canvasGroup");
			UISpeechBubble.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100670274);
			UISpeechBubble.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100670275);
			UISpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100670278);
			UISpeechBubble.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100670276);
			UISpeechBubble.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100670277);
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000D7434 File Offset: 0x000D5634
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x000D746C File Offset: 0x000D566C
		public unsafe string Message
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99169, RefRangeEnd = 99170, XrefRangeStart = 99165, XrefRangeEnd = 99169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000D74B0 File Offset: 0x000D56B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99170, XrefRangeEnd = 99171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISpeechBubble()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000D74EC File Offset: 0x000D56EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99171, XrefRangeEnd = 99199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000D7520 File Offset: 0x000D5720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99199, XrefRangeEnd = 99226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00012A5F File Offset: 0x00010C5F
		public UISpeechBubble(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06002E92 RID: 11922 RVA: 0x000D7554 File Offset: 0x000D5754
		// (set) Token: 0x06002E93 RID: 11923 RVA: 0x00012A68 File Offset: 0x00010C68
		public unsafe RectTransform chatContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_chatContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_chatContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000D7584 File Offset: 0x000D5784
		// (set) Token: 0x06002E95 RID: 11925 RVA: 0x00012A87 File Offset: 0x00010C87
		public unsafe RectTransform bubbleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000D75B4 File Offset: 0x000D57B4
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x00012AA6 File Offset: 0x00010CA6
		public unsafe TMP_Text chatText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_chatText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_chatText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000D75E4 File Offset: 0x000D57E4
		// (set) Token: 0x06002E99 RID: 11929 RVA: 0x00012AC5 File Offset: 0x00010CC5
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000D760C File Offset: 0x000D580C
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x00012AE4 File Offset: 0x00010CE4
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000D763C File Offset: 0x000D583C
		// (set) Token: 0x06002E9D RID: 11933 RVA: 0x00012B03 File Offset: 0x00010D03
		public unsafe float DisplayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_DisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_DisplayTime)) = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000D7664 File Offset: 0x000D5864
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x00012B1E File Offset: 0x00010D1E
		public unsafe float targetOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_targetOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_targetOpacity)) = value;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000D768C File Offset: 0x000D588C
		// (set) Token: 0x06002EA1 RID: 11937 RVA: 0x00012B39 File Offset: 0x00010D39
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000D76B4 File Offset: 0x000D58B4
		// (set) Token: 0x06002EA3 RID: 11939 RVA: 0x00012B54 File Offset: 0x00010D54
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeFieldInfoPtr_chatContentRect;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeFieldInfoPtr_bubbleRect;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeFieldInfoPtr_chatText;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeFieldInfoPtr_DisplayTime;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeFieldInfoPtr_targetOpacity;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
	}
}
