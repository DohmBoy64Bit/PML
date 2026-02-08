using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B0 RID: 688
	public class Text3D : DynamicInstance
	{
		// Token: 0x06003B11 RID: 15121 RVA: 0x0010B18C File Offset: 0x0010938C
		// Note: this type is marked as 'beforefieldinit'.
		static Text3D()
		{
			Il2CppClassPointerStore<Text3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Text3D");
			Text3D.NativeFieldInfoPtr_tmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "tmp");
			Text3D.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "text");
			Text3D.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "color");
			Text3D.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "fontSize");
			Text3D.NativeFieldInfoPtr_faceCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "faceCamera");
			Text3D.NativeFieldInfoPtr_horizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "horizontalAlignment");
			Text3D.NativeFieldInfoPtr_verticalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "verticalAlignment");
			Text3D.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "font");
			Text3D.NativeFieldInfoPtr_rotationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "rotationCache");
			Text3D.NativeFieldInfoPtr_positionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "positionCache");
			Text3D.NativeFieldInfoPtr_csf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "csf");
			Text3D.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3D>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_font");
			Text3D.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672385);
			Text3D.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672386);
			Text3D.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672387);
			Text3D.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672388);
			Text3D.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672389);
			Text3D.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672390);
			Text3D.NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672391);
			Text3D.NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672392);
			Text3D.NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672393);
			Text3D.NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672394);
			Text3D.NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672395);
			Text3D.NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672396);
			Text3D.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672397);
			Text3D.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672398);
			Text3D.NativeMethodInfoPtr_get_Networktext_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672411);
			Text3D.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672412);
			Text3D.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672413);
			Text3D.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672414);
			Text3D.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672415);
			Text3D.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672416);
			Text3D.NativeMethodInfoPtr_get_NetworkfaceCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672417);
			Text3D.NativeMethodInfoPtr_set_NetworkfaceCamera_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672418);
			Text3D.NativeMethodInfoPtr_get_NetworkhorizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672419);
			Text3D.NativeMethodInfoPtr_set_NetworkhorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672420);
			Text3D.NativeMethodInfoPtr_get_NetworkverticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672421);
			Text3D.NativeMethodInfoPtr_set_NetworkverticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672422);
			Text3D.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672423);
			Text3D.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672424);
			Text3D.NativeMethodInfoPtr_get_NetworkrotationCache_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672425);
			Text3D.NativeMethodInfoPtr_set_NetworkrotationCache_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672426);
			Text3D.NativeMethodInfoPtr_get_NetworkpositionCache_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672427);
			Text3D.NativeMethodInfoPtr_set_NetworkpositionCache_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672428);
			Text3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672409);
			Text3D.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672383);
			Text3D.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672384);
			Text3D.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672399);
			Text3D.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672400);
			Text3D.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672401);
			Text3D.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672402);
			Text3D.NativeMethodInfoPtr_RpcSetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672403);
			Text3D.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672404);
			Text3D.NativeMethodInfoPtr_RpcSetFontSize_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672405);
			Text3D.NativeMethodInfoPtr_RpcSetHorizontalAlignment_Private_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672406);
			Text3D.NativeMethodInfoPtr_RpcSetVerticalAlignment_Private_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672407);
			Text3D.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672408);
			Text3D.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672410);
			Text3D.NativeMethodInfoPtr_UserCode_RpcSetText__String_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672429);
			Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetText__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672430);
			Text3D.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672431);
			Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672432);
			Text3D.NativeMethodInfoPtr_UserCode_RpcSetFontSize__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672433);
			Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetFontSize__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672434);
			Text3D.NativeMethodInfoPtr_UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672435);
			Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672436);
			Text3D.NativeMethodInfoPtr_UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672437);
			Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672438);
			Text3D.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672440);
			Text3D.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3D>.NativeClassPtr, 100672441);
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x0010B72C File Offset: 0x0010992C
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x0010B764 File Offset: 0x00109964
		public unsafe string Text
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119631, RefRangeEnd = 119632, XrefRangeStart = 119630, XrefRangeEnd = 119631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119649, RefRangeEnd = 119654, XrefRangeStart = 119632, XrefRangeEnd = 119649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x0010B7A8 File Offset: 0x001099A8
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x0010B7E8 File Offset: 0x001099E8
		public unsafe Color Color
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119654, RefRangeEnd = 119655, XrefRangeStart = 119654, XrefRangeEnd = 119654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119672, RefRangeEnd = 119677, XrefRangeStart = 119655, XrefRangeEnd = 119672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x0010B82C File Offset: 0x00109A2C
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x0010B868 File Offset: 0x00109A68
		public unsafe float FontSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 119677, RefRangeEnd = 119678, XrefRangeStart = 119677, XrefRangeEnd = 119677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119701, RefRangeEnd = 119706, XrefRangeStart = 119678, XrefRangeEnd = 119701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x0010B8A8 File Offset: 0x00109AA8
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x0010B8E4 File Offset: 0x00109AE4
		public unsafe bool FaceCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 119730, RefRangeEnd = 119733, XrefRangeStart = 119706, XrefRangeEnd = 119730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x0010B924 File Offset: 0x00109B24
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x0010B964 File Offset: 0x00109B64
		public unsafe HorizontalAlignmentOptions HorizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HorizontalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119760, RefRangeEnd = 119765, XrefRangeStart = 119733, XrefRangeEnd = 119760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x0010B9A8 File Offset: 0x00109BA8
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x0010B9E8 File Offset: 0x00109BE8
		public unsafe VerticalAlignmentOptions VerticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VerticalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 119792, RefRangeEnd = 119797, XrefRangeStart = 119765, XrefRangeEnd = 119792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0010BA2C File Offset: 0x00109C2C
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x0010BA6C File Offset: 0x00109C6C
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 119851, RefRangeEnd = 119854, XrefRangeStart = 119797, XrefRangeEnd = 119851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0010BAB0 File Offset: 0x00109CB0
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x0010BAE8 File Offset: 0x00109CE8
		public unsafe string Networktext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Networktext_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119860, RefRangeEnd = 119862, XrefRangeStart = 119854, XrefRangeEnd = 119860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x0010BB2C File Offset: 0x00109D2C
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x0010BB6C File Offset: 0x00109D6C
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119868, RefRangeEnd = 119870, XrefRangeStart = 119862, XrefRangeEnd = 119868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x0010BBB0 File Offset: 0x00109DB0
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x0010BBEC File Offset: 0x00109DEC
		public unsafe float NetworkfontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119870, XrefRangeEnd = 119876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x0010BC2C File Offset: 0x00109E2C
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x0010BC68 File Offset: 0x00109E68
		public unsafe bool NetworkfaceCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkfaceCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119876, XrefRangeEnd = 119882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkfaceCamera_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x0010BCA8 File Offset: 0x00109EA8
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x0010BCE8 File Offset: 0x00109EE8
		public unsafe HorizontalAlignmentOptions NetworkhorizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkhorizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HorizontalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119888, RefRangeEnd = 119890, XrefRangeStart = 119882, XrefRangeEnd = 119888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkhorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x0010BD2C File Offset: 0x00109F2C
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x0010BD6C File Offset: 0x00109F6C
		public unsafe VerticalAlignmentOptions NetworkverticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkverticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VerticalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119896, RefRangeEnd = 119898, XrefRangeStart = 119890, XrefRangeEnd = 119896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkverticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x0010BDF0 File Offset: 0x00109FF0
		public unsafe TextFontPreset Networkfont
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119898, XrefRangeEnd = 119901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x0010BE34 File Offset: 0x0010A034
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x0010BE74 File Offset: 0x0010A074
		public unsafe Vector3 NetworkrotationCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkrotationCache_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119901, XrefRangeEnd = 119907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkrotationCache_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0010BEB8 File Offset: 0x0010A0B8
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x0010BEF8 File Offset: 0x0010A0F8
		public unsafe Vector3 NetworkpositionCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_get_NetworkpositionCache_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119907, XrefRangeEnd = 119913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_set_NetworkpositionCache_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x0010BF3C File Offset: 0x0010A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119913, XrefRangeEnd = 119928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Text3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Text3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x0010BF78 File Offset: 0x0010A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119928, XrefRangeEnd = 119934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x0010BFB4 File Offset: 0x0010A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119934, XrefRangeEnd = 119940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x0010BFF0 File Offset: 0x0010A1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119940, XrefRangeEnd = 119945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x0010C02C File Offset: 0x0010A22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119945, XrefRangeEnd = 119967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x0010C068 File Offset: 0x0010A268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119967, XrefRangeEnd = 119987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x0010C0A4 File Offset: 0x0010A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119987, XrefRangeEnd = 120001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x0010C0F4 File Offset: 0x0010A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120001, XrefRangeEnd = 120022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetText(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_RpcSetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x0010C138 File Offset: 0x0010A338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120022, XrefRangeEnd = 120043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x0010C17C File Offset: 0x0010A37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120043, XrefRangeEnd = 120064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFontSize(float fs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_RpcSetFontSize_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x0010C1BC File Offset: 0x0010A3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120064, XrefRangeEnd = 120085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetHorizontalAlignment(HorizontalAlignmentOptions al)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_RpcSetHorizontalAlignment_Private_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x0010C200 File Offset: 0x0010A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120085, XrefRangeEnd = 120106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetVerticalAlignment(VerticalAlignmentOptions al)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_RpcSetVerticalAlignment_Private_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x0010C244 File Offset: 0x0010A444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120106, XrefRangeEnd = 120108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x0010C298 File Offset: 0x0010A498
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x0010C2E0 File Offset: 0x0010A4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120108, XrefRangeEnd = 120110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetText__String(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_UserCode_RpcSetText__String_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x0010C324 File Offset: 0x0010A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120110, XrefRangeEnd = 120125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetText__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetText__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x0010C380 File Offset: 0x0010A580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120125, XrefRangeEnd = 120127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetColor__Color(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x0010C3C4 File Offset: 0x0010A5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120127, XrefRangeEnd = 120138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x0010C420 File Offset: 0x0010A620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120138, XrefRangeEnd = 120140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFontSize__Single(float fs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_UserCode_RpcSetFontSize__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x0010C460 File Offset: 0x0010A660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120140, XrefRangeEnd = 120151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFontSize__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetFontSize__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x0010C4BC File Offset: 0x0010A6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120151, XrefRangeEnd = 120153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(HorizontalAlignmentOptions al)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x0010C500 File Offset: 0x0010A700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120153, XrefRangeEnd = 120168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x0010C55C File Offset: 0x0010A75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120168, XrefRangeEnd = 120170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(VerticalAlignmentOptions al)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x0010C5A0 File Offset: 0x0010A7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120170, XrefRangeEnd = 120185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3D.NativeMethodInfoPtr_InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x0010C5FC File Offset: 0x0010A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120185, XrefRangeEnd = 120205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x0010C658 File Offset: 0x0010A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120205, XrefRangeEnd = 120267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text3D.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00016BA9 File Offset: 0x00014DA9
		public Text3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x0010C6B4 File Offset: 0x0010A8B4
		// (set) Token: 0x06003B4E RID: 15182 RVA: 0x00016BB2 File Offset: 0x00014DB2
		public unsafe TMP_Text tmp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_tmp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_tmp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x0010C6E4 File Offset: 0x0010A8E4
		// (set) Token: 0x06003B50 RID: 15184 RVA: 0x00016BD1 File Offset: 0x00014DD1
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x0010C70C File Offset: 0x0010A90C
		// (set) Token: 0x06003B52 RID: 15186 RVA: 0x00016BF0 File Offset: 0x00014DF0
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x0010C73C File Offset: 0x0010A93C
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x00016C0F File Offset: 0x00014E0F
		public unsafe float fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x0010C764 File Offset: 0x0010A964
		// (set) Token: 0x06003B56 RID: 15190 RVA: 0x00016C2A File Offset: 0x00014E2A
		public unsafe bool faceCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_faceCamera);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_faceCamera)) = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x0010C78C File Offset: 0x0010A98C
		// (set) Token: 0x06003B58 RID: 15192 RVA: 0x00016C45 File Offset: 0x00014E45
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_horizontalAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HorizontalAlignmentOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_horizontalAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x0010C7BC File Offset: 0x0010A9BC
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x00016C64 File Offset: 0x00014E64
		public unsafe VerticalAlignmentOptions verticalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_verticalAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalAlignmentOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_verticalAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x0010C7EC File Offset: 0x0010A9EC
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x00016C83 File Offset: 0x00014E83
		public unsafe TextFontPreset font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x0010C81C File Offset: 0x0010AA1C
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x00016CA2 File Offset: 0x00014EA2
		public unsafe Vector3 rotationCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_rotationCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_rotationCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x0010C84C File Offset: 0x0010AA4C
		// (set) Token: 0x06003B60 RID: 15200 RVA: 0x00016CC1 File Offset: 0x00014EC1
		public unsafe Vector3 positionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_positionCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_positionCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x0010C87C File Offset: 0x0010AA7C
		// (set) Token: 0x06003B62 RID: 15202 RVA: 0x00016CE0 File Offset: 0x00014EE0
		public unsafe ContentSizeFitter csf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_csf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentSizeFitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr_csf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x0010C8AC File Offset: 0x0010AAAC
		// (set) Token: 0x06003B64 RID: 15204 RVA: 0x00016CFF File Offset: 0x00014EFF
		public unsafe Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextFontPreset, TextFontPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3D.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeFieldInfoPtr_tmp;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_faceCamera;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAlignment;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeFieldInfoPtr_verticalAlignment;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeFieldInfoPtr_rotationCache;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeFieldInfoPtr_positionCache;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeFieldInfoPtr_csf;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_get_Networktext_Public_get_String_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfaceCamera_Public_get_Boolean_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfaceCamera_Public_set_Void_Boolean_0;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkhorizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkhorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkverticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkverticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrotationCache_Public_get_Vector3_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrotationCache_Public_set_Void_Vector3_0;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpositionCache_Public_get_Vector3_0;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpositionCache_Public_set_Void_Vector3_0;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetText_Private_Void_String_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetColor_Private_Void_Color_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFontSize_Private_Void_Single_0;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetHorizontalAlignment_Private_Void_HorizontalAlignmentOptions_0;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetVerticalAlignment_Private_Void_VerticalAlignmentOptions_0;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetText__String_Protected_Void_String_0;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetText__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetColor__Color_Protected_Void_Color_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFontSize__Single_Protected_Void_Single_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFontSize__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Void_HorizontalAlignmentOptions_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Void_VerticalAlignmentOptions_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
