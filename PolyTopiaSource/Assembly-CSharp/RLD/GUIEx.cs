using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000122 RID: 290
	public static class GUIEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B4D RID: 6989 RVA: 0x0008B6EC File Offset: 0x000898EC
		// Note: this type is marked as 'beforefieldinit'.
		static GUIEx()
		{
			Il2CppClassPointerStore<GUIEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GUIEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIEx>.NativeClassPtr);
			GUIEx.NativeFieldInfoPtr__colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIEx>.NativeClassPtr, "_colorStack");
			GUIEx.NativeMethodInfoPtr_PushColor_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIEx>.NativeClassPtr, 100667376);
			GUIEx.NativeMethodInfoPtr_PopColor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIEx>.NativeClassPtr, 100667377);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0008B758 File Offset: 0x00089958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77098, RefRangeEnd = 77100, XrefRangeStart = 77086, XrefRangeEnd = 77098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushColor(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIEx.NativeMethodInfoPtr_PushColor_Public_Static_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0008B790 File Offset: 0x00089990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77114, RefRangeEnd = 77116, XrefRangeStart = 77100, XrefRangeEnd = 77114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopColor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIEx.NativeMethodInfoPtr_PopColor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0000BD16 File Offset: 0x00009F16
		public GUIEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0008B7B8 File Offset: 0x000899B8
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0000BD1F File Offset: 0x00009F1F
		public unsafe static Stack<Color> _colorStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIEx.NativeFieldInfoPtr__colorStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Color>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIEx.NativeFieldInfoPtr__colorStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr__colorStack;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_PushColor_Public_Static_Void_Color_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_PopColor_Public_Static_Void_0;
	}
}
